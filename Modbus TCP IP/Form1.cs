using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Modbus_TCP_IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Define the UpdateTable method in Form1
        public void UpdateTable(Dictionary<string, string> dataDict)
        {
            // Access the table in Form1
            TableLayoutPanel table = tableLayoutPanel_NameValue;

            // Create an array of TextBox controls for displaying values
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };

            int i = 0;
            foreach (var kvp in dataDict)
            {
                if (i >= textBoxes.Length)
                    break; // Exit if there are more items in dataDict than TextBoxes

                // Set the TextBox text to the corresponding value from dataDict
                textBoxes[i].Text = kvp.Value;
                i++;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 and pass the reference to Form1
            Form2 form2 = new Form2(this); // "this" refers to the current instance of Form1

            // Show Form2
            form2.Show();
        }
    }
}
