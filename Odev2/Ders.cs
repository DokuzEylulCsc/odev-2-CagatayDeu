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
        public List<OgretimElemani> ogretimGorevlileri = new List<OgretimElemani>(); //ogrenci ve görevlilerin tutulduğu liste.

        private string name;

        public Ders(string name)
        {
            this.name = name;
        }

        public string Name          //getler.
        {
            get { return name; }
        }

        public void ogrenciEkle(Ogrenci ogrenci) //ogrenci ekleme.
        {
            ogrenciler.Add(ogrenci);
        }

        public void ogrenciSil(int index) //index e göre ogrenci silme.
        {
            ogrenciler.RemoveAt(index);
        }

        public void ogretimGorevlisiEkle(OgretimElemani ogretimElemani) //görevli ekleme.
        {
            ogretimGorevlileri.Add(ogretimElemani);
        }

        public void ogretimGorevlisiSil(int index) //index e göre görevli silme.
        {
            ogretimGorevlileri.RemoveAt(index);
        }
    }
}
