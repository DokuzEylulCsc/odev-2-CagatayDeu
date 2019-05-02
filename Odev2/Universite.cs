using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{

    class Universite
    {
        public List<Fakulte> fakulteler = new List<Fakulte>(); //fakültelerin tutulduğu liste.

        public void fakulteEkle(Fakulte fakulte) //fakülte nesnesi alıp listeye ekleyen fonksiyon.
        {
            fakulteler.Add(fakulte);
        }

        public Fakulte secilenFakulteyiBul(string fakulteIsmi) //ders ismine göre ders bulunur.(Aynı isimde 2 ders olmamalı değil mi ???)
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
