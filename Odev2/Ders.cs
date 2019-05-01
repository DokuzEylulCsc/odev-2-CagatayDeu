using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Ders
    {
        private string name;

        public Ders(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
