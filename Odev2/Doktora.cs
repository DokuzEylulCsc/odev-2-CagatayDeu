using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Doktora : Ogrenci
    {
        private string fullname;
        private double tc;

        public Doktora(string fullname, double tc) : base(fullname, tc)
        {
            this.fullname = fullname;
            this.tc = tc;
        }
        
    }
}
