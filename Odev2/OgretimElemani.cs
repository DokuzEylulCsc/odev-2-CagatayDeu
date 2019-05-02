using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class OgretimElemani
    {
        private string name;
        private double tc;
        private int age;

        public OgretimElemani(string name, double tc, int age)
        {
            this.name = name;
            this.tc = tc;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
        }

        public double Tc
        {
            get { return tc; }
        }

        public int Age
        {
            get { return age; }
        }
    }
}
