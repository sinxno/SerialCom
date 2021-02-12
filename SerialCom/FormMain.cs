using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SerialCom
{
    public partial class FormMain : Form
    {

        bool aboutFormOpen = false;
        
        float avg = 0;
        int avgSum = 0;
        int minIndex = 0;
        int maxIndex = 0;

        List<MeasurementPoint> measurmentList = new List<MeasurementPoint>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            String string1 = textBoxInput1.Text;
            String string2 = textBoxInput2.Text;
            /*
            if (checkBoxCase.Checked)
            {
                textBoxResult.AppendText("Is \"" + string1 + "\" equal \"" + string2 + "\" with case sensitivity?: " + string1.Equals(string2) + "\r\n");
            }
            else
            {
                textBoxResult.AppendText("Is \"" + string1 + "\" equal \"" + string2 + "\" without case sensitivity?: " + string1.Equals(string2,StringComparison.CurrentCultureIgnoreCase) + "\r\n");
            }

            switch (String.Compare(string1,string2,!checkBoxCase.Checked))
            {
                case -1:
                    textBoxResult.AppendText(String.Format("{0} is before {1}\r\n", textBoxInput1.Text, textBoxInput2.Text));
                    break;
                case 0:
                    textBoxResult.AppendText(String.Format("{0} is equal to {1}\r\n", textBoxInput1.Text, textBoxInput2.Text));
                    break;
                case 1:
                    textBoxResult.AppendText(String.Format("{0} is after {1}\r\n", textBoxInput1.Text, textBoxInput2.Text));
                    break;
                default:
                    break;
            }
            */

            /*
            int indexOfSubstring = -1;
            if (checkBoxCase.Checked)
            {
                indexOfSubstring = string1.IndexOf(string2);
                textBoxResult.AppendText(indexOfSubstring + "\r\n");
            }
            else
            {
                indexOfSubstring = string1.ToLower().IndexOf(string2.ToLower());
                textBoxResult.AppendText(indexOfSubstring + "\r\n");
            }
            
            */

            string[] stringList = string1.Split(';');

            for (int i = 0; i < stringList.Length; i++)
            {
                textBoxResult.AppendText(stringList[i] + "\r\n");
            }

            foreach (string text in stringList)
            {
                textBoxResult.AppendText(text + "\r\n");
            }
           
            


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Add(textBoxAdd.Text);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxResult.Items.RemoveAt(comboBoxRemove.SelectedIndex);
            }
            catch (Exception)
            {

                MessageBox.Show("Index does not exist");
            }
            comboBoxRemove.SelectedIndex = -1;
            
        }

        private void comboBoxRemove_Enter(object sender, EventArgs e)
        {
            comboBoxRemove.Items.Clear();
            foreach (var item in listBoxResult.Items)
            {
                comboBoxRemove.Items.Add(item);
            }
        }

        private void checkBoxSorted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSorted.Checked)
            {
                listBoxResult.Sorted = true;
            }
            else
            {
                listBoxResult.Sorted = false;
            }
        }

        private void comboBoxComPort_Enter(object sender, EventArgs e)
        {
            string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();

            foreach (var comPort in comPorts)
            {
                comboBoxComPort.Items.Add(comPort);
            }

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxComPort.SelectedIndex > -1 && comboBoxBitRate.SelectedIndex > -1 && !serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBoxComPort.SelectedItem.ToString();
                serialPort1.BaudRate = int.Parse(comboBoxBitRate.SelectedItem.ToString());
                serialPort1.Open();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(textBoxCommand.Text);
            }
            
        }

        private void buttonRecieve_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBoxSerialDataRecieved.AppendText(serialPort1.ReadExisting().ToString());
                serialPort1.DiscardInBuffer();
            }
            
        }

        delegate void UpdateTextInSerialBoxCallback(string data);
        private void UpdateTextInSerialBox(string data)
        {
            if (this.textBoxSerialDataRecieved.InvokeRequired)
            {
                UpdateTextInSerialBoxCallback d = new UpdateTextInSerialBoxCallback(UpdateTextInSerialBox);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                this.textBoxSerialDataRecieved.AppendText(data);
            }
        }



        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort sp = (System.IO.Ports.SerialPort)sender;
            string indata = sp.ReadExisting();

            UpdateTextInSerialBox(indata);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                radioButtonConnectedStatus.Checked = true;
                buttonSend.Enabled = true;
                buttonRecieve.Enabled = true;
                buttonEnableSensorData.Enabled = true;
                buttonDisableSensorData.Enabled = true;
            }
            else
            {
                radioButtonConnectedStatus.Checked = false;
                buttonSend.Enabled = false;
                buttonRecieve.Enabled = false;
                buttonEnableSensorData.Enabled = false;
                buttonDisableSensorData.Enabled = false;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if (!aboutFormOpen)
            {
                AboutBox1 aboutBox1 = new AboutBox1();
                aboutBox1.Show();
                aboutFormOpen = true;
                this.Visible = false;
                aboutBox1.FormClosed += new FormClosedEventHandler(aboutFormClosed);
            }
            
        }

        private void aboutFormClosed(object sender, FormClosedEventArgs e)
        {
            aboutFormOpen = false;
            this.Visible = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            var filename = String.Empty;

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                MessageBox.Show(filename);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            string[] textFileContent = { "Hello", "World"};
            saveFileDialog1.FileName = "SerialConfiguration.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                File.WriteAllLines(filename, textFileContent);

                if (File.Exists(filename))
                {
                    MessageBox.Show("Data saved to " + filename);
                }
                else
                {
                    MessageBox.Show("An error occured");
                }
            }
        }

        private void buttonEnableSensorData_Click(object sender, EventArgs e)
        {
            timerSerialSend.Enabled = true;
            buttonSend.Enabled = false;
            buttonRecieve.Enabled = false;
            buttonSaveChartData.Enabled = false;
        }

        private void buttonDisableSensorData_Click(object sender, EventArgs e)
        {
            timerSerialSend.Enabled = false;
            timerSerialRecieve.Enabled = false;
            buttonSend.Enabled = true;
            buttonRecieve.Enabled = true;
            buttonSaveChartData.Enabled = true;
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
        }

        private void timerSerialSend_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("ReadSensor");
                timerSerialRecieve.Enabled = true;
                timerSerialSend.Enabled = false;

            }
        }

        private void timerSerialRecieve_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    String sensorData;
                    sensorData = serialPort1.ReadExisting().ToString();
                    textBoxSerialDataRecieved.AppendText(sensorData);

                    String[] sensorDataSplitted = sensorData.Split(';');
                    MeasurementPoint measurementPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), int.Parse(sensorDataSplitted[0]), int.Parse(sensorDataSplitted[1]), int.Parse(sensorDataSplitted[2]));
                    measurmentList.Add(measurementPoint);

                    chart1.Series[0].Points.AddXY(measurmentList.Last<MeasurementPoint>().time, measurmentList.Last<MeasurementPoint>().va);
                    chart1.Series[1].Points.AddXY(measurmentList.Last<MeasurementPoint>().time, measurmentList.Last<MeasurementPoint>().vb);
                    chart1.Series[2].Points.AddXY(measurmentList.Last<MeasurementPoint>().time, measurmentList.Last<MeasurementPoint>().vab);

                    if(measurmentList.Last<MeasurementPoint>().vab <= measurmentList[minIndex].vab)
                    {

                        minIndex = measurmentList.Count - 1;
                    }

                    if (measurmentList.Last<MeasurementPoint>().vab >= measurmentList[maxIndex].vab)
                    {
                        maxIndex = measurmentList.Count - 1;
                    }

                    avgSum += measurmentList.Last<MeasurementPoint>().vab;
                    avg = (float)avgSum / measurmentList.Count;
                    chart1.Series[3].Points.AddXY(DateTime.Now.ToLongTimeString(), avg);

                    labelMin.Text = "Min: " + measurmentList[minIndex].vab;
                    labelMax.Text = "Max: " + measurmentList[maxIndex].vab;
                    labelAvg.Text = "Avg: " + avg;


                    serialPort1.DiscardInBuffer();

                    timerSerialSend.Enabled = true;
                    timerSerialRecieve.Enabled = false;
                }
                
            }


            
        }

        private void buttonSaveChartData_Click(object sender, EventArgs e)
        {
            saveFileDialogChartPoints.FileName = "MeasurmentData.csv";

            if (saveFileDialogChartPoints.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;
                progressBar1.Maximum = measurmentList.Count;
                string filename = saveFileDialogChartPoints.FileName;

                try
                {
                    StreamWriter outputFile = new StreamWriter(filename);
                    outputFile.WriteLine("index;va;vb;vab");

                    foreach (MeasurementPoint measurment in measurmentList)
                    {
                        outputFile.WriteLine(measurment.ToString());
                        progressBar1.Increment(1);
                    }
                    outputFile.Close();

                    if (File.Exists(filename))
                    {
                        MessageBox.Show("Data saved to " + filename);
                    }
                    else
                    {
                        MessageBox.Show("An error occured");
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }

        }
    }

    public class MeasurementPoint
    {
        //The objects variables
        //{get; set;} makes it possible to both change the variable(set) and read the variable(get)
        //It is possible to remove either get and set or both to make the object more rigid.
        public String time { get; set; }
        public int va { get; set; }
        public int vb { get; set; }
        public int vab { get; set; }

        //The constructor of the object Needs to be called when you want to create a new object of this type
        public MeasurementPoint(String time, int va, int vb, int vab)
        {
            //"this" referes to the objects variable. It is needed because the variables sent to the constructor and the objects variables are named the same. 
            this.time = time;
            this.va = va;
            this.vb = vb;
            this.vab = vab;
        }

        //overrides the base object ToString(). makes it possible to decide what is printed when ToString is called.
        public override string ToString()
        {
            return time + ";" + va + ";" + vb + ";" + vab;
        }

    }

}
