﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        Universite deu = new Universite();

        Fakulte selectedFakulte = null;
        Bolum selectedBolum = null;

        private string buttonsType = "fakulte";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listfakulte.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(buttonsType == "fakulte")
            {
                if (listfakulte.SelectedIndex != -1)
                {
                    selectedFakulte = deu.secilenFakulteyiBul(listfakulte.SelectedItem.ToString());
                    buttonsType = "bolum";
                    Console.WriteLine(selectedFakulte.Name);// silinecek
                    selectedFakulte.bolumEkle(new Bolum("Endüstri Mühendisliği")); // silinecek
                    selectedFakulte.bolumEkle(new Bolum("Bilgisayar Mühendisliği")); // silinecek

                    foreach (Bolum a in selectedFakulte.bolumler) //var olan bölümleri yüklemek için.
                    {
                        listbolumler.Items.Add(a.Name);
                    }
                    listfakulte.Visible = false;
                    listbolumler.Visible = true;
                    button1.Text = "Bolum Ekle";
                    button2.Text = "Bölüm'e Git";
                    label1.Text = selectedFakulte.Name;
                    label2.Text = "Bölüm İsmi:";
                }
                else
                {
                    MessageBox.Show("Fakülte seçiniz.");
                }
            } else if (buttonsType == "bolum")
            {
                if(listbolumler.SelectedIndex != -1)
                {
                    selectedBolum = selectedFakulte.secilenBolumuBul(listbolumler.SelectedItem.ToString());
                    buttonsType = "ders";
                    selectedBolum.dersEkle(new Ders("Matematik")); // silinecek
                    selectedBolum.dersEkle(new Ders("Nesneye Yönelik Programlama")); // silinecek
                    foreach (Ders a in selectedBolum.dersler) //var olan dersleri yüklemek için.
                    {
                        listdersler.Items.Add(a.Name);
                    }
                    listbolumler.Visible = false;
                    listdersler.Visible = true;
                    button3.Visible = true;
                    button1.Text = "Ders Aç";
                    button2.Text = "Ders'e Git";
                    button3.Text = "Ders Kapat";
                    label1.Text = selectedBolum.Name;
                    label2.Text = "Ders İsmi:";
                }
                else
                {
                    MessageBox.Show("Bölüm seçiniz.");
                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fakulte yeni = new Fakulte("deneme");

            //deu.fakulteEkle(yeni);
            //listfakulte.Items.Add(yeni.Name);

            //yeni.bolumEkle(new Bolum("endüstri mühendisliğİ"));
            //yeni.bolumEkle(new Bolum("Bilgisayar mühendisliği"));

            //foreach(Bolum a in yeni.bolumler)
            //{
            //    listbolumler.Items.Add(a.Name);
            //}

            //listfakulte.Visible = false;
            //listbolumler.Visible = true;

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if(buttonsType == "fakulte")
            {
                if (textBoxName.TextLength != 0)
                {
                    Fakulte yeni = new Fakulte(textBoxName.Text);
                    deu.fakulteEkle(yeni);
                    listfakulte.Items.Add(yeni.Name);
                    panel1.Visible = false;
                    textBoxName.Text = null;
                }
                else
                {
                    MessageBox.Show("Fakülte ismi zorunludur");
                }
            } else if(buttonsType == "bolum")
            {
                Bolum yeni = new Bolum(textBoxName.Text);
                selectedFakulte.bolumEkle(yeni);
                listbolumler.Items.Add(yeni.Name);
                panel1.Visible = false;
                textBoxName.Text = null;
            }
            
            
        }

        
    }
}
