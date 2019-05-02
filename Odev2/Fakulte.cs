using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Fakulte
    {
        public List<Bolum> bolumler = new List<Bolum>(); //bölümlerin tutulduğu Liste
        private string name;

        public Fakulte(string name) //isim alan constructor
        {
            this.name = name;
        }

        public string Name      //gerekli get.
        {
            get { return name; }
        }

        public void bolumEkle(Bolum bolum) //Bolum tipinde bölüm ekler.
        {
            bolumler.Add(bolum);
        }

        public Bolum secilenBolumuBul(string bolumIsmi) //fakülte ismine göre fakülte bulunur.(Aynı isimde 2 fakülte olmamalı değil mi ???)
        {
            foreach (Bolum a in bolumler)
            {
                if (a.Name == bolumIsmi)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
