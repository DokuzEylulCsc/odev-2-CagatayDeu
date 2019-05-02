using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Doktora : Ogrenci
    {
        private string fullname; //Ogrenciden türetilmiş doktora sınıfı. Ogrencinin özelliklerini barındırır.
        private double tc;
        private int age;
        private Sube sube;

        public Doktora(string fullname, double tc, int age, Sube sube) : base(fullname, tc, age, sube)
        {
            this.fullname = tc + "-" + fullname;
            this.tc = tc;
            this.age = age;
            this.sube = sube;
        }

    }
}
