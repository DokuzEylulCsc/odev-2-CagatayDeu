using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Ders
    {
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public List<OgretimElemani> ogretimGorevlileri = new List<OgretimElemani>();

        private string name;

        public Ders(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public void ogrenciEkle(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
        }

        public void ogrenciSil(int index)
        {
            ogrenciler.RemoveAt(index);
        }

        public void ogretimGorevlisiEkle(OgretimElemani ogretimElemani)
        {
            ogretimGorevlileri.Add(ogretimElemani);
        }

        public void ogretimGorevlisiSil(int index)
        {
            ogretimGorevlileri.RemoveAt(index);
        }
    }
}
