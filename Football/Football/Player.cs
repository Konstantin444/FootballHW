using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Player : Person
    {
        public Player(string name, int age, int number, double height) 
            : base(name, age)
        {
            Number = number;
            Height = height;
        }

        public int Number { get; set; }
        public double Height { get; set; }
    }
}
