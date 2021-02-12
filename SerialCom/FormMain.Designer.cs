
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
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
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSaveChartData = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDisableSensorData = new System.Windows.Forms.Button();
            this.buttonEnableSensorData = new System.Windows.Forms.Button();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerSerialSend = new System.Windows.Forms.Timer(this.components);
            this.timerSerialRecieve = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogChartPoints = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageString.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tabControlMain.Size = new System.Drawing.Size(976, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.buttonSaveFile);
            this.tabPageString.Controls.Add(this.buttonOpenFile);
            this.tabPageString.Controls.Add(this.buttonAbout);
            this.tabPageString.Controls.Add(this.buttonResult);
            this.tabPageString.Controls.Add(this.checkBoxCase);
            this.tabPageString.Controls.Add(this.textBoxResult);
            this.tabPageString.Controls.Add(this.textBoxInput2);
            this.tabPageString.Controls.Add(this.textBoxInput1);
            this.tabPageString.Location = new System.Drawing.Point(4, 22);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageString.Size = new System.Drawing.Size(968, 424);
            this.tabPageString.TabIndex = 0;
            this.tabPageString.Text = "String";
            this.tabPageString.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(310, 382);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(117, 23);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(168, 382);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(117, 23);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(26, 382);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(117, 23);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
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
            this.tabPageLoop.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageLoop.Size = new System.Drawing.Size(968, 424);
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
            this.tabPageList.Size = new System.Drawing.Size(968, 424);
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
            this.tabPageSerial.Controls.Add(this.labelAvg);
            this.tabPageSerial.Controls.Add(this.labelMax);
            this.tabPageSerial.Controls.Add(this.labelMin);
            this.tabPageSerial.Controls.Add(this.progressBar1);
            this.tabPageSerial.Controls.Add(this.buttonSaveChartData);
            this.tabPageSerial.Controls.Add(this.chart1);
            this.tabPageSerial.Controls.Add(this.buttonDisableSensorData);
            this.tabPageSerial.Controls.Add(this.buttonEnableSensorData);
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
            this.tabPageSerial.Size = new System.Drawing.Size(968, 424);
            this.tabPageSerial.TabIndex = 3;
            this.tabPageSerial.Text = "Serial";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(772, 204);
            this.labelAvg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(32, 13);
            this.labelAvg.TabIndex = 19;
            this.labelAvg.Text = "Avg: ";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(772, 177);
            this.labelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 13);
            this.labelMax.TabIndex = 18;
            this.labelMax.Text = "Max: ";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(772, 150);
            this.labelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(30, 13);
            this.labelMin.TabIndex = 17;
            this.labelMin.Text = "Min: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(424, 397);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 19);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // buttonSaveChartData
            // 
            this.buttonSaveChartData.Location = new System.Drawing.Point(293, 398);
            this.buttonSaveChartData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveChartData.Name = "buttonSaveChartData";
            this.buttonSaveChartData.Size = new System.Drawing.Size(125, 19);
            this.buttonSaveChartData.TabIndex = 15;
            this.buttonSaveChartData.Text = "Save Chart Data";
            this.buttonSaveChartData.UseVisualStyleBackColor = true;
            this.buttonSaveChartData.Click += new System.EventHandler(this.buttonSaveChartData_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(446, 115);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Va";
            series1.Name = "Va";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Vb";
            series2.Name = "Vb";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Vab";
            series3.Name = "Vab";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Avg";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(320, 277);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // buttonDisableSensorData
            // 
            this.buttonDisableSensorData.Location = new System.Drawing.Point(293, 374);
            this.buttonDisableSensorData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDisableSensorData.Name = "buttonDisableSensorData";
            this.buttonDisableSensorData.Size = new System.Drawing.Size(125, 19);
            this.buttonDisableSensorData.TabIndex = 13;
            this.buttonDisableSensorData.Text = "Disable Sensor Data";
            this.buttonDisableSensorData.UseVisualStyleBackColor = true;
            this.buttonDisableSensorData.Click += new System.EventHandler(this.buttonDisableSensorData_Click);
            // 
            // buttonEnableSensorData
            // 
            this.buttonEnableSensorData.Location = new System.Drawing.Point(293, 350);
            this.buttonEnableSensorData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnableSensorData.Name = "buttonEnableSensorData";
            this.buttonEnableSensorData.Size = new System.Drawing.Size(125, 19);
            this.buttonEnableSensorData.TabIndex = 12;
            this.buttonEnableSensorData.Text = "Enable Sensor Data";
            this.buttonEnableSensorData.UseVisualStyleBackColor = true;
            this.buttonEnableSensorData.Click += new System.EventHandler(this.buttonEnableSensorData_Click);
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
            this.textBoxSerialDataRecieved.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSerialDataRecieved.Size = new System.Drawing.Size(321, 80);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // timerSerialSend
            // 
            this.timerSerialSend.Interval = 1000;
            this.timerSerialSend.Tick += new System.EventHandler(this.timerSerialSend_Tick);
            // 
            // timerSerialRecieve
            // 
            this.timerSerialRecieve.Tick += new System.EventHandler(this.timerSerialRecieve_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonDisableSensorData;
        private System.Windows.Forms.Button buttonEnableSensorData;
        private System.Windows.Forms.Timer timerSerialSend;
        private System.Windows.Forms.Timer timerSerialRecieve;
        private System.Windows.Forms.Button buttonSaveChartData;
        private System.Windows.Forms.SaveFileDialog saveFileDialogChartPoints;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
    }
}

