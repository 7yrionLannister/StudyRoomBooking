﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;


namespace ui
{
    public partial class UserInterface : Form
    {
        private DataManager dm;
        public UserInterface()
        {
            InitializeComponent();
            string[] items = new string[] {"101-1E", "101-2E", "101-3E", "101-4E", "101-5E", "101-6E", "101-7E", "101-8E"};
            roomComboBox.Items.AddRange(items);
            datePicker.MinDate = DateTime.Today;
            dm = new DataManager();
         
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
            string room = (string)roomComboBox.SelectedItem;
            int fHour = Convert.ToInt32(fromHour.Value);
            int tHour = Convert.ToInt32(toHour.Value);
            int fMin = Convert.ToInt32(fromMinute.Value);
            int tMin = Convert.ToInt32(toMinute.Value);
            if (name.Length > 0 && code.Length > 0 && room != null
                && ((fHour < tHour) || (fHour == tHour && fMin < tMin)))
            {
                DateTime dt = datePicker.Value;
                string date = string.Format("{0:D2}/{1:D2}/{2}", dt.Day, dt.Month, dt.Year);
                string startTime = date + ", " + string.Format("{0:D2}:{1:D2}", fHour, fMin);
                string endTime = date + ", " + string.Format("{0:D2}:{1:D2}", tHour, tMin);
                dm.writeInfo(name, code, room, startTime, endTime);

                nameTextBox.Text = "";
                codeTextBox.Text = "";
                roomComboBox.Text = "";
                fromHour.Value = 00;
                fromMinute.Value = 00;
                toHour.Value = 00;
                toMinute.Value = 00;


                MessageBox.Show("Reserva guardada");
            }
            else {
                //Ventana emergente pidiendo al usuario corregir los campos erroneos
                MessageBox.Show("Digite los campos vacios");
            }
        }

        private void loadButtonPressed(object sender, EventArgs e)
        {
            dm.readInfo();

            string message = "\t\t*****SALAS DE ESTUDIO RESERVADAS*****\n\n\n";
            message += "Room\tStudent\tCode\t\tFrom\t\tTo\n\n";

            for (int i = 0; i < dm.Bookings.Count; i++)
            {
                message += dm.Bookings[i].Room + "\t" + dm.Bookings[i].Name + "\t" + dm.Bookings[i].Code + "\t" 
                    + dm.Bookings[i].StartTime + "\t" + dm.Bookings[i].EndTime  + "\n";
            }


            MessageBox.Show(message,"RESERVAS REGISTRADAS");

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
