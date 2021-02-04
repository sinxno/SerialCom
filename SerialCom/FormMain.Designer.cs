
namespace SerialCom
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.buttonResult = new System.Windows.Forms.Button();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.tabPageLoop = new System.Windows.Forms.TabPage();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.checkBoxSorted = new System.Windows.Forms.CheckBox();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.comboBoxRemove = new System.Windows.Forms.ComboBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelBitRate = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.textBoxSerialDataRecieved = new System.Windows.Forms.TextBox();
            this.radioButtonConnectedStatus = new System.Windows.Forms.RadioButton();
            this.buttonRecieve = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBitRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageString.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageString);
            this.tabControlMain.Controls.Add(this.tabPageLoop);
            this.tabControlMain.Controls.Add(this.tabPageList);
            this.tabControlMain.Controls.Add(this.tabPageSerial);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.buttonResult);
            this.tabPageString.Controls.Add(this.checkBoxCase);
            this.tabPageString.Controls.Add(this.textBoxResult);
            this.tabPageString.Controls.Add(this.textBoxInput2);
            this.tabPageString.Controls.Add(this.textBoxInput1);
            this.tabPageString.Location = new System.Drawing.Point(4, 22);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageString.Size = new System.Drawing.Size(792, 424);
            this.tabPageString.TabIndex = 0;
            this.tabPageString.Text = "String";
            this.tabPageString.UseVisualStyleBackColor = true;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(26, 150);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(205, 23);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Checked = true;
            this.checkBoxCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCase.Location = new System.Drawing.Point(26, 88);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(117, 20);
            this.checkBoxCase.TabIndex = 3;
            this.checkBoxCase.Text = "Case Sensitive";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(285, 32);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(276, 141);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.TabStop = false;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput2.Location = new System.Drawing.Point(26, 60);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(205, 22);
            this.textBoxInput2.TabIndex = 2;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput1.Location = new System.Drawing.Point(26, 32);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(205, 22);
            this.textBoxInput1.TabIndex = 1;
            // 
            // tabPageLoop
            // 
            this.tabPageLoop.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoop.Name = "tabPageLoop";
            this.tabPageLoop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoop.Size = new System.Drawing.Size(792, 424);
            this.tabPageLoop.TabIndex = 1;
            this.tabPageLoop.Text = "Loop";
            this.tabPageLoop.UseVisualStyleBackColor = true;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.checkBoxSorted);
            this.tabPageList.Controls.Add(this.buttonMinus);
            this.tabPageList.Controls.Add(this.buttonAdd);
            this.tabPageList.Controls.Add(this.listBoxResult);
            this.tabPageList.Controls.Add(this.comboBoxRemove);
            this.tabPageList.Controls.Add(this.textBoxAdd);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Size = new System.Drawing.Size(792, 424);
            this.tabPageList.TabIndex = 2;
            this.tabPageList.Text = "List";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // checkBoxSorted
            // 
            this.checkBoxSorted.AutoSize = true;
            this.checkBoxSorted.Location = new System.Drawing.Point(204, 293);
            this.checkBoxSorted.Name = "checkBoxSorted";
            this.checkBoxSorted.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSorted.TabIndex = 5;
            this.checkBoxSorted.Text = "Sorted";
            this.checkBoxSorted.UseVisualStyleBackColor = true;
            this.checkBoxSorted.CheckedChanged += new System.EventHandler(this.checkBoxSorted_CheckedChanged);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(145, 53);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(28, 23);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(145, 23);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(28, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(204, 23);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(120, 264);
            this.listBoxResult.TabIndex = 2;
            // 
            // comboBoxRemove
            // 
            this.comboBoxRemove.FormattingEnabled = true;
            this.comboBoxRemove.Location = new System.Drawing.Point(18, 55);
            this.comboBoxRemove.Name = "comboBoxRemove";
            this.comboBoxRemove.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRemove.TabIndex = 1;
            this.comboBoxRemove.Enter += new System.EventHandler(this.comboBoxRemove_Enter);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(18, 23);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(121, 20);
            this.textBoxAdd.TabIndex = 0;
            // 
            // tabPageSerial
            // 
            this.tabPageSerial.Controls.Add(this.labelCommand);
            this.tabPageSerial.Controls.Add(this.labelBitRate);
            this.tabPageSerial.Controls.Add(this.labelComPort);
            this.tabPageSerial.Controls.Add(this.textBoxSerialDataRecieved);
            this.tabPageSerial.Controls.Add(this.radioButtonConnectedStatus);
            this.tabPageSerial.Controls.Add(this.buttonRecieve);
            this.tabPageSerial.Controls.Add(this.buttonSend);
            this.tabPageSerial.Controls.Add(this.textBoxCommand);
            this.tabPageSerial.Controls.Add(this.buttonDisconnect);
            this.tabPageSerial.Controls.Add(this.buttonConnect);
            this.tabPageSerial.Controls.Add(this.comboBoxBitRate);
            this.tabPageSerial.Controls.Add(this.comboBoxComPort);
            this.tabPageSerial.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerial.Name = "tabPageSerial";
            this.tabPageSerial.Size = new System.Drawing.Size(792, 424);
            this.tabPageSerial.TabIndex = 3;
            this.tabPageSerial.Text = "Serial";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(212, 32);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(54, 13);
            this.labelCommand.TabIndex = 11;
            this.labelCommand.Text = "Command";
            // 
            // labelBitRate
            // 
            this.labelBitRate.AutoSize = true;
            this.labelBitRate.Location = new System.Drawing.Point(12, 68);
            this.labelBitRate.Name = "labelBitRate";
            this.labelBitRate.Size = new System.Drawing.Size(40, 13);
            this.labelBitRate.TabIndex = 10;
            this.labelBitRate.Text = "Bit rate";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(12, 32);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(49, 13);
            this.labelComPort.TabIndex = 9;
            this.labelComPort.Text = "Com port";
            // 
            // textBoxSerialDataRecieved
            // 
            this.textBoxSerialDataRecieved.Location = new System.Drawing.Point(446, 30);
            this.textBoxSerialDataRecieved.Multiline = true;
            this.textBoxSerialDataRecieved.Name = "textBoxSerialDataRecieved";
            this.textBoxSerialDataRecieved.ReadOnly = true;
            this.textBoxSerialDataRecieved.Size = new System.Drawing.Size(321, 300);
            this.textBoxSerialDataRecieved.TabIndex = 8;
            // 
            // radioButtonConnectedStatus
            // 
            this.radioButtonConnectedStatus.AutoSize = true;
            this.radioButtonConnectedStatus.Location = new System.Drawing.Point(148, 152);
            this.radioButtonConnectedStatus.Name = "radioButtonConnectedStatus";
            this.radioButtonConnectedStatus.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnectedStatus.TabIndex = 7;
            this.radioButtonConnectedStatus.TabStop = true;
            this.radioButtonConnectedStatus.UseVisualStyleBackColor = true;
            // 
            // buttonRecieve
            // 
            this.buttonRecieve.Location = new System.Drawing.Point(293, 179);
            this.buttonRecieve.Name = "buttonRecieve";
            this.buttonRecieve.Size = new System.Drawing.Size(75, 23);
            this.buttonRecieve.TabIndex = 6;
            this.buttonRecieve.Text = "Recieve";
            this.buttonRecieve.UseVisualStyleBackColor = true;
            this.buttonRecieve.Click += new System.EventHandler(this.buttonRecieve_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(293, 149);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(272, 29);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(147, 20);
            this.textBoxCommand.TabIndex = 4;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(67, 179);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(67, 149);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBitRate
            // 
            this.comboBoxBitRate.FormattingEnabled = true;
            this.comboBoxBitRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000",
            ""});
            this.comboBoxBitRate.Location = new System.Drawing.Point(67, 65);
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            this.comboBoxBitRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBitRate.TabIndex = 1;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(67, 29);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 0;
            this.comboBoxComPort.Enter += new System.EventHandler(this.comboBoxComPort_Enter);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Communication";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageString.ResumeLayout(false);
            this.tabPageString.PerformLayout();
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.tabPageSerial.ResumeLayout(false);
            this.tabPageSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageString;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TabPage tabPageLoop;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.TabPage tabPageSerial;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ComboBox comboBoxRemove;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.CheckBox checkBoxSorted;
        private System.Windows.Forms.Label labelBitRate;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.TextBox textBoxSerialDataRecieved;
        private System.Windows.Forms.RadioButton radioButtonConnectedStatus;
        private System.Windows.Forms.Button buttonRecieve;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBitRate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label labelCommand;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

