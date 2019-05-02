using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class YuksekLisans : Ogrenci
    {
        private string name;
        private double tc;

        public YuksekLisans(string name, double tc) : base(name, tc)
        {
            this.name = name;
            this.tc = tc;
        }
       
    }
}
