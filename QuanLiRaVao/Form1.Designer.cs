namespace QuanLiRaVao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btOpenPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbDetect = new System.Windows.Forms.TextBox();
            this.tbRFIDCode = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btClosePort = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnHistory = new System.Windows.Forms.Button();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxUserCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btOpenPort
            // 
            this.btOpenPort.Location = new System.Drawing.Point(14, 124);
            this.btOpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.btOpenPort.Name = "btOpenPort";
            this.btOpenPort.Size = new System.Drawing.Size(130, 28);
            this.btOpenPort.TabIndex = 0;
            this.btOpenPort.Text = "Open Port";
            this.btOpenPort.UseVisualStyleBackColor = true;
            this.btOpenPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(62, 96);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(82, 21);
            this.cbBaudrate.TabIndex = 9;
            this.cbBaudrate.Text = "2400";
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(62, 74);
            this.cbCOM.Margin = new System.Windows.Forms.Padding(2);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(82, 21);
            this.cbCOM.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxUserCode);
            this.panel1.Controls.Add(this.tbxUserName);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnCreateUser);
            this.panel1.Controls.Add(this.tbDetect);
            this.panel1.Controls.Add(this.tbRFIDCode);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btClosePort);
            this.panel1.Controls.Add(this.cbCOM);
            this.panel1.Controls.Add(this.cbBaudrate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btOpenPort);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 357);
            this.panel1.TabIndex = 11;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(8, 327);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(65, 23);
            this.btnCreateUser.TabIndex = 17;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tbDetect
            // 
            this.tbDetect.Location = new System.Drawing.Point(14, 219);
            this.tbDetect.Margin = new System.Windows.Forms.Padding(2);
            this.tbDetect.Name = "tbDetect";
            this.tbDetect.ReadOnly = true;
            this.tbDetect.Size = new System.Drawing.Size(132, 20);
            this.tbDetect.TabIndex = 16;
            // 
            // tbRFIDCode
            // 
            this.tbRFIDCode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbRFIDCode.Location = new System.Drawing.Point(14, 166);
            this.tbRFIDCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbRFIDCode.Name = "tbRFIDCode";
            this.tbRFIDCode.ReadOnly = true;
            this.tbRFIDCode.Size = new System.Drawing.Size(132, 20);
            this.tbRFIDCode.TabIndex = 14;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(40, 188);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(79, 25);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clean";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClosePort
            // 
            this.btClosePort.Location = new System.Drawing.Point(14, 124);
            this.btClosePort.Margin = new System.Windows.Forms.Padding(2);
            this.btClosePort.Name = "btClosePort";
            this.btClosePort.Size = new System.Drawing.Size(130, 28);
            this.btClosePort.TabIndex = 12;
            this.btClosePort.Text = "Close Port";
            this.btClosePort.UseVisualStyleBackColor = true;
            this.btClosePort.Visible = false;
            this.btClosePort.Click += new System.EventHandler(this.btClosePort_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLog);
            this.panel2.Location = new System.Drawing.Point(165, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 355);
            this.panel2.TabIndex = 12;
            // 
            // dgvLog
            // 
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.RowTemplate.Height = 24;
            this.dgvLog.Size = new System.Drawing.Size(433, 355);
            this.dgvLog.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 17);
            this.progressBar1.TabIndex = 18;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(79, 327);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(73, 23);
            this.btnHistory.TabIndex = 19;
            this.btnHistory.Text = "History (15)";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(52, 300);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxUserName.TabIndex = 20;
            // 
            // tbxUserCode
            // 
            this.tbxUserCode.Location = new System.Drawing.Point(52, 271);
            this.tbxUserCode.Name = "tbxUserCode";
            this.tbxUserCode.Size = new System.Drawing.Size(100, 20);
            this.tbxUserCode.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ra vào - Hội CĐV Nam Định";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClosePort;
        private System.Windows.Forms.TextBox tbDetect;
        private System.Windows.Forms.TextBox tbRFIDCode;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUserCode;
        private System.Windows.Forms.TextBox tbxUserName;
    }
}

