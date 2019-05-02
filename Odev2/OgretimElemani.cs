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

        public OgretimElemani(string name, double tc)
        {
            this.name = name;
            this.tc = tc;
        }

        public string Name
        {
            get { return name; }
        }

        public double Tc
        {
            get { return tc; }
        }
    }
}
