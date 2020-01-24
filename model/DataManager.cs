using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace model
{
    public class DataManager
    {

        private List<Booking> bookings;
        private const string PATH = "..\\..\\data\bookings.txt";

        public DataManager()
        {
            bookings = new List<Booking>();
        }

        public void writeInfo(string name, string code, string room, string startTime, string endTime)
        {
            StreamWriter sw = new StreamWriter(PATH, !File.Exists(PATH));
            Booking newBook = new Booking(name, code, room, startTime, endTime);
            sw.WriteLine("{0};{1};{2};{3};{4}", name, code, room, startTime, endTime);
            bookings.Add(newBook);
            sw.Close();

        }

        public void readInfo()
        {
            StreamReader sr = File.OpenText(PATH);
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
