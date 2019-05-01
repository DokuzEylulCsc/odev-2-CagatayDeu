using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Fakulte
    {
        public List<Bolum> bolumler = new List<Bolum>();
        private string name;

        public Fakulte(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public void bolumEkle(Bolum bolum)
        {
            bolumler.Add(bolum);
        }
    }
}
