using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{

    class Universite
    {
        public List<Fakulte> fakulteler = new List<Fakulte>();

        public void fakulteEkle(Fakulte fakulte)
        {
            fakulteler.Add(fakulte);
        }

        public Fakulte secilenFakulteyiBul(string fakulteIsmi)
        {
            foreach(Fakulte a in fakulteler)
            {
                if(a.Name == fakulteIsmi)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
