using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    abstract class Ogrenci
    {
        private string fullname;
        private double tc;
        private int age;
        private Sube sube;

        public Ogrenci(string fullname, double tc, int age, Sube sube)
        {
            this.fullname = tc + "-" + fullname;
            this.tc = tc;
            this.age = age;
            this.sube = sube;
        }

        public string Name
        {
            get { return fullname; }
        }

        public double Tc
        {
            get { return tc; }
        }

        public int Age
        {
            get { return age; }
        }

        public Sube getSube
        {
            get { return sube; }
        }

    }

}
