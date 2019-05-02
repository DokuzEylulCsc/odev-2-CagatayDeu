using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Bolum
    {
        public List<Ders> dersler = new List<Ders>(); //ders listesinin tutulduğu list.
        private string name;

        public Bolum(string name)
        {
            this.name = name;
        }

        public string Name          //gerekli getler.
        {
            get { return name; }
        }

        public void dersEkle(Ders ders)     //ders ekleme fonksiyonu.
        { 
            dersler.Add(ders);
        }

        public void dersSil(int index) //index e göre ders silinir.
        {
            dersler.RemoveAt(index);
        }

        public Ders secilenDersiBul(string dersIsmi) //ders ismine göre ders bulunur.(Aynı isimde 2 ders olmamalı değil mi ???)
        {
            foreach (Ders a in dersler)
            {
                if (a.Name == dersIsmi)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
