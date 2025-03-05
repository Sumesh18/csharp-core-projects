using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsDemo
{
    internal class Person
    {
        private string _accNum = "31212";
        public string AccNum
        {
            get => _accNum;
            set => _accNum = value;
        }
    }
}
