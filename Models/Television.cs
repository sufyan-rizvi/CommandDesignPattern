using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class Television
    {
        public void ON()
        {
            Console.WriteLine("TV swtiched ON");
        }

        public void OFF()
        {
            Console.WriteLine("TV switched OFF");
        }
    }
}
