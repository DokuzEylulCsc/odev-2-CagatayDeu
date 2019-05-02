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

        public Ogrenci(string fullname, double tc)
        {
            this.fullname = tc + "-" + fullname;
            this.tc = tc;
        }

        public string Name
        {
            get { return fullname; }
        }

        public double Tc
        {
            get { return tc; }
        }

    }

}
