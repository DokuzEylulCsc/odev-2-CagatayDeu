using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Sube
    {
        private int subes = 1;

        public Sube(int sube)   //2 adet şube için constructor.
        {
            this.subes = sube;
        }

        public int Subes
        {
            get { return subes; } //şubeyi veren get.
        }
    }
}
