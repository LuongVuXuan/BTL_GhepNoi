using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using QuanLiRaVao.Models;


namespace QuanLiRaVao
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = null;
        List<User> GLBusers;
        List<UserLog> GLBuserLogs;

        DataTable dt = new DataTable();
        // Cau hinh firebase
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "GBeAbt7UJ0dOtIVyCRnLLa4EE8uA3ufZitz7JsRv",
            BasePath = "https://comportdata-4f2b1.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // firebase
            client = new FireSharp.FirebaseClient(config);

            // com port
            string[] listPort = SerialPort.GetPortNames();
            if (listPort == null)
            {

            }
            else
            {
                cbCOM.Items.AddRange(listPort);
            }

            // data table
            dt.Columns.Add("User Code");
            dt.Columns.Add("Time Log");
            dgvLog.DataSource = dt;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            SetText(indata.ToString());

        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {


            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.tbRFIDCode.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbRFIDCode.AppendText(text);
                if (this.tbRFIDCode.Text.Length == 5)
                {
                    Console.WriteLine("rfid code: " + this.tbRFIDCode.Text);
                    //viet funcrtion o DAY

                    //switch (tbRFIDCode.Text)
                    //{
                    //    case "y`??":
                    //        tbDetect.Text = "LINH";
                    //        break;
                    //    case "??*z":
                    //        tbDetect.Text = "Luong";
                    //        break;
                    //    default:
                    //        tbDetect.Text = "Undefine!";
                    //        break;
                    //};

                    var _findUser = GLBusers.Where(m => m.UserCode == ConvertToHexString(tbRFIDCode.Text)).FirstOrDefault();
                    if (_findUser != null)
                    {
                        tbDetect.Text = _findUser.UserName;

                        UserLog _newLog = new UserLog
                        {
                            UserCode = _findUser.UserCode
                        };

                        AddNewLog(_newLog);

                        dt.Rows.Clear();
                        // duyet list user va them vao bang
                        foreach (var item in GLBuserLogs)
                        {
                            if (item.UserCode == _findUser.UserCode)
                            {
                                DataRow row = dt.NewRow();
                                row["User Code"] = item.UserCode;
                                row["Time Log"] = item.TimeLog;
                                dt.Rows.InsertAt(row, 0);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Deo Co, dang ki di!");
                        tbxUserCode.Text = ConvertToHexString(tbRFIDCode.Text);
                        tbxUserName.Focus();
                    }

                    this.tbRFIDCode.Text = "";
                }

            }

        }



        private async void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            serialPort = new SerialPort();
            serialPort.PortName = cbCOM.Text;
            serialPort.BaudRate = Convert.ToInt32(cbBaudrate.Text);
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Parity = Parity.None;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.Open();
            btOpenPort.Visible = false;
            btClosePort.Visible = true;


            // Test
            // Get listUser
            FirebaseResponse resCounter = await client.GetTaskAsync("Counter/UserList/");
            Counter counter = resCounter.ResultAs<Counter>();
            var cnt = Convert.ToInt32(counter.Cnt);
            var listUser = new List<User>();
            int i = 0;
            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("UserList/" + i);
                    User user = resp2.ResultAs<User>();
                    listUser.Add(user);
                }
                catch (Exception)
                {

                }
            }
            GLBusers = listUser;

            progressBar1.Value = 80;
            // get list userlog
            FirebaseResponse resCounter2 = await client.GetTaskAsync("Counter/UserLog/");
            Counter counter2 = resCounter2.ResultAs<Counter>();
            var cnt2 = Convert.ToInt32(counter2.Cnt);
            var listUserLogs = new List<UserLog>();
            int i2 = 0;
            while (true)
            {
                if (i2 == cnt2)
                {
                    break;
                }
                i2++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("UserLog/" + i2);
                    UserLog userLog = resp2.ResultAs<UserLog>();
                    listUserLogs.Add(userLog);
                }
                catch (Exception)
                {

                }
            }
            progressBar1.Value = 100;
            GLBuserLogs = listUserLogs;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbRFIDCode.Text = "";
        }


        private void btClosePort_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            serialPort.Close();

            btClosePort.Visible = false;
            btOpenPort.Visible = true;

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbRFIDCode.Text = "";
            tbDetect.Text = "";
        }

        public async void AddNewUser(User user)
        {
            GLBusers.Add(user);

            var id = GLBusers.Count.ToString();
            await client.SetTaskAsync("UserList/" + id, user);
            await client.SetTaskAsync("Counter/UserList", new Counter { Cnt = id });
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                // Them txtbox nhap vao day
                UserCode = tbxUserCode.Text,
                UserName = tbxUserName.Text
            };

            //GLBusers.Add(user);
            AddNewUser(user);
            MessageBox.Show("Them moi user thanh cong!");
            tbxUserCode.Text = "";
            tbxUserName.Text = "";
        }

        public async void AddNewLog(UserLog userLog)
        {
            GLBuserLogs.Add(userLog);

            var id = GLBuserLogs.Count.ToString();
            await client.SetTaskAsync("UserLog/" + id, userLog);
            await client.SetTaskAsync("Counter/UserLog", new Counter { Cnt = id });
        }

        // Ham convert sieu quan trọng
        public string ConvertToHexString(string s)
        {
            byte[] ba = Encoding.Default.GetBytes(s);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            tbRFIDCode.Text = "";
            dt.Rows.Clear();
            List<UserLog> htrList = GLBuserLogs.Skip(GLBuserLogs.Count - 15).ToList();
            foreach (var item in htrList)
            {
                DataRow row = dt.NewRow();
                row["User Code"] = item.UserCode;
                row["Time Log"] = item.TimeLog;
                dt.Rows.InsertAt(row, 0);
            }
        }
    }
}
