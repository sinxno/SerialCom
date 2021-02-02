﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class FormMain : Form
    {
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
    }
}