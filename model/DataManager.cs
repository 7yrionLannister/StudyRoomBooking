using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    class DataManager{

        private List<Booking> bookings;
        private const string path = "Data/file.txt";

        public DataManager() {

            bookings = new List<Booking>();
        
        }

        public void writeInfo(string name, string code, string room, string startTime, string endTime) { 
            

        
        }

        public void readInfo() { 
        

        
        }

    }
}
