using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace model
{
    public class DataManager
    {

        private List<Booking> bookings;
        private const string path = "Data/file.txt";

        public DataManager()
        {

            bookings = new List<Booking>();

        }

        public void writeInfo(string name, string code, string room, string startTime, string endTime)
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                }
            }


        }

        public void readInfo()
        {

            using (StreamReader sr = File.OpenText(path))
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
