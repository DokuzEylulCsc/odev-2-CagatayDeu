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
        private int tc;

        public OgretimElemani(string name, int tc)
        {
            this.name = name;
            this.tc = tc;
        }

        public string Name
        {
            get { return name; }
        }

        public int Tc
        {
            get { return tc; }
        }
    }
}
