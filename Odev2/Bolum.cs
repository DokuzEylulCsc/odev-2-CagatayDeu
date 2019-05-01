using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Bolum
    {
        public List<Ders> dersler = new List<Ders>();
        private string name;

        public Bolum(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public void dersEkle(Ders ders)
        {
            dersler.Add(ders);
        }

        public void dersSil(int index)
        {
            dersler.RemoveAt(index);

            foreach (Ders i in dersler)
                Console.WriteLine(i.Name);
        }

        public Ders secilenDersiBul(string dersIsmi)
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
