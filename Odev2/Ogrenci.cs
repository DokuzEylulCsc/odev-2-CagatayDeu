using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    abstract class Ogrenci
    {
        private string fullname; //ogrenci base özellikler
        private double tc;
        private int age;
        private Sube sube;

        public Ogrenci(string fullname, double tc, int age, Sube sube) //nesne yaratılırken istenir.
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

        public double Tc            //gerektiğinde alınabilmesi için getler.
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
