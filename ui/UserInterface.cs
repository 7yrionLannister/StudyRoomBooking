using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;


namespace ui
{
    public partial class UserInterface : Form
    {

        public UserInterface()
        {
  
            InitializeComponent();
            string[] items = new string[] {"101-1E", "101-2E", "101-3E", "101-4E", "101-5E" };
            roomComboBox.Items.AddRange(items);
            datePicker.MinDate = DateTime.Today;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string code = codeTextBox.Text;
            string room = (string)roomComboBox.SelectedValue;
            int fHour = Convert.ToInt32(fromHour.Value);
            int tHour = Convert.ToInt32(toHour.Value);
            int fMin = Convert.ToInt32(fromMinute.Value);
            int tMin = Convert.ToInt32(toMinute.Value);
            if (name.Length > 0 && code.Length > 0 && room != null
                && ((fHour < tHour) || (fHour == tHour && fMin < tMin))) { 

                

            }
        }
    }
}
