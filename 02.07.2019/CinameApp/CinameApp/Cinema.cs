using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinameApp
{
    public class Cinema
    {
        private static int ID;

        public readonly int uniqueId;
        public string Name { get; set; }
        public string Address { get; set; }

        private Hall[] halls;

        public Cinema(string name,string address)
        {
            ID++;
            uniqueId = ID;
            Name = name;
            Address = address;
            halls = new Hall[0];
        }

        public void AddHall(Hall hall)
        {
            int arrLength = halls.Length;
            Array.Resize(ref halls, arrLength+1);
            halls[arrLength] = hall;
        }
    }
}
