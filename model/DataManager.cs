using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace model
{
    public class DataManager
    {

        private List<Booking> bookings;
        private const string PATH = "..\\..\\..\\bookings.txt";

        public DataManager()
        {
            bookings = new List<Booking>();
        }

        public List<Booking> Bookings 
        {
            get {

                return bookings;
            
            }
        }

        public void writeInfo(string name, string code, string room, string startTime, string endTime)
        {
            StreamWriter sw = new StreamWriter(PATH, File.Exists(PATH));
            Booking newBook = new Booking(name, code, room, startTime, endTime);
            sw.WriteLine("{0};{1};{2};{3};{4}", name, code, room, startTime, endTime);
            bookings.Add(newBook);
            sw.Close();
        }

        public void readInfo()
        {
            StreamReader sr = new StreamReader(PATH);
            string line;

            bookings.Clear();
            while ((line = sr.ReadLine()) != null)
            {
                string[] args = line.Split(';');

                string name = args[0];
                string code = args[1];
                string room = args[2];
                string start = args[3];
                string end = args[4];
                Booking nb = new Booking(name, code, room, start, end);
                bookings.Add(nb);
            }

            sr.Close();
        }
    }
}
