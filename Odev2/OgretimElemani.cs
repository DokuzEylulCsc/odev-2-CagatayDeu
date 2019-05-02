using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class OgretimElemani
    {
        private string fullname;
        private double tc; //özellikler.
        private int age;

        public OgretimElemani(string fullname, double tc, int age) //constructor.
        {
            this.fullname = tc + "-" + fullname;
            this.tc = tc;
            this.age = age;
        }

        public string Name
        {
            get { return fullname; }
        }

        public double Tc        //gerekli getler.
        {
            get { return tc; }
        }

        public int Age
        {
            get { return age; }
        }
    }
}
