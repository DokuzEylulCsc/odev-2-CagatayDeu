﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Ders selectedDers = null;

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
                    listbolumler.Items.Clear();
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
                    listdersler.Items.Clear();
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

            } else if(buttonsType == "ders")
            {
                if (listdersler.SelectedIndex != -1)
                {
                    selectedDers = selectedBolum.secilenDersiBul(listdersler.SelectedItem.ToString());
                    buttonsType = "ayrıntı";
                    listOgrenciler.Items.Clear();
                    listOgretimElemanlari.Items.Clear();
                    foreach (Ogrenci a in selectedDers.ogrenciler) //var olan öğrencileri yüklemek için.
                    {
                        listOgrenciler.Items.Add(a.Name);
                    }
                    foreach (OgretimElemani a in selectedDers.ogretimGorevlileri) //var olan öğretim görevlilerini yüklemek için.
                    {
                        listOgretimElemanlari.Items.Add(a.Name);
                    }
                    listdersler.Visible = false;
                    listOgrenciler.Visible = true;
                    listOgretimElemanlari.Visible = true;
                    labelogrenciler.Visible = true;
                    labelgorevliler.Visible = true;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    panelbuttons.Visible = true;
                    label1.Text = selectedDers.Name;
                }
                else
                {
                    MessageBox.Show("Ders seçiniz.");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(buttonsType == "ders")
            {
                if(listdersler.SelectedIndex != -1)
                {
                    selectedBolum.dersSil(listdersler.SelectedIndex);
                    listdersler.Items.RemoveAt(listdersler.SelectedIndex);
                } else
                {
                    MessageBox.Show("Ders seçiniz.");
                }
                
            }
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

                if (textBoxName.TextLength != 0)
                {
                    Bolum yeni = new Bolum(textBoxName.Text);
                    selectedFakulte.bolumEkle(yeni);
                    listbolumler.Items.Add(yeni.Name);
                    panel1.Visible = false;
                    textBoxName.Text = null;
                }
                else
                {
                    MessageBox.Show("Bölüm ismi zorunludur");
                }
            } else if(buttonsType == "ders")
            {
                if (textBoxName.TextLength != 0)
                {
                    Ders yeni = new Ders(textBoxName.Text);
                    selectedBolum.dersEkle(yeni);
                    listdersler.Items.Add(yeni.Name);
                    panel1.Visible = false;
                    textBoxName.Text = null;
                }
                else
                {
                    MessageBox.Show("Ders ismi zorunludur");
                }
            } 
            
            
        }

        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            panelkaydet.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            comboSube.Visible = true;
            comboOgrenciTip.Visible = true;
        }

        private void GorevliEkle_Click(object sender, EventArgs e)
        {
            panelkaydet.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            comboSube.Visible = false;
            comboOgrenciTip.Visible = false;
        }

        private void ogrenciKaldir_Click(object sender, EventArgs e)
        {
            if (listOgrenciler.SelectedIndex != -1)
            {
                selectedDers.ogrenciSil(listOgrenciler.SelectedIndex);
                listOgrenciler.Items.RemoveAt(listOgrenciler.SelectedIndex);
            } else
            {
                MessageBox.Show("Öğrenci seçiniz.");
            }
                
        }

        private void gorevliKaldir_Click(object sender, EventArgs e)
        {
            if (listOgretimElemanlari.SelectedIndex != -1)
            {
                selectedDers.ogretimGorevlisiSil(listOgretimElemanlari.SelectedIndex);
                listOgretimElemanlari.Items.RemoveAt(listOgretimElemanlari.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Öğretim görevlisi seçiniz.");
            }
            
        }

        private void ogrenciKaydet_Click(object sender, EventArgs e)
        {
            if(comboSube.Visible == true)
            {
                if(textBox1.TextLength != 0 & TcNo.TextLength != 0 & textBox2.TextLength != 0 & comboSube.SelectedIndex != -1 & comboOgrenciTip.SelectedIndex != -1)
                {
                    if(comboOgrenciTip.SelectedIndex == 0)
                    {
                        Lisans yeni = new Lisans(textBox1.Text, Convert.ToDouble(TcNo.Text),
                            Convert.ToInt32(textBox2.Text), new Sube(Convert.ToInt32(comboSube.SelectedItem)));
                        selectedDers.ogrenciEkle(yeni);
                        listOgrenciler.Items.Add(yeni.Name);
                        panelkaydet.Visible = false;
                        textBox1.Text = null;
                        TcNo.Text = null;
                        textBox2.Text = null;
                        comboSube.SelectedIndex = -1;
                        comboOgrenciTip.SelectedIndex = -1;

                    } else if(comboOgrenciTip.SelectedIndex == 1)
                    {
                        YuksekLisans yeni = new YuksekLisans(textBox1.Text,Convert.ToDouble(TcNo.Text),
                            Convert.ToInt32(textBox2.Text),new Sube(Convert.ToInt32(comboSube.SelectedItem)));
                        selectedDers.ogrenciEkle(yeni);
                        listOgrenciler.Items.Add(yeni.Name);
                        panelkaydet.Visible = false;
                        textBox1.Text = null;
                        TcNo.Text = null;
                        textBox2.Text = null;
                        comboSube.SelectedIndex = -1;
                        comboOgrenciTip.SelectedIndex = -1;
                    } else
                    {
                        Doktora yeni = new Doktora(textBox1.Text, Convert.ToDouble(TcNo.Text),
                            Convert.ToInt32(textBox2.Text), new Sube(Convert.ToInt32(comboSube.SelectedItem)));
                        selectedDers.ogrenciEkle(yeni);
                        listOgrenciler.Items.Add(yeni.Name);
                        panelkaydet.Visible = false;
                        textBox1.Text = null;
                        TcNo.Text = null;
                        textBox2.Text = null;
                        comboSube.SelectedIndex = -1;
                        comboOgrenciTip.SelectedIndex = -1;
                    }
                } else
                {
                    MessageBox.Show("Öğrenci bilgilerini doldurunuz.");
                }

            } else
            {
                if (textBox1.TextLength != 0 & TcNo.TextLength != 0 & textBox2.TextLength != 0)
                {
                    OgretimElemani yeni = new OgretimElemani(textBox1.Text, Convert.ToDouble(TcNo.Text),
                        Convert.ToInt32(textBox2.Text));
                    selectedDers.ogretimGorevlisiEkle(yeni);
                    listOgretimElemanlari.Items.Add(yeni.Name);
                    panelkaydet.Visible = false;
                    textBox1.Text = null;
                    TcNo.Text = null;
                    textBox2.Text = null;
                } else
                {
                    MessageBox.Show("Öğretim görevlisi bilgilerini doldurunuz.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(buttonsType == "bolum")
            {
                listfakulte.Visible = true;
                listbolumler.Visible = false;
                button1.Text = "Fakülte Aç";
                button2.Text = "Fakülteye git";
                label1.Text = "Deu";
                label2.Text = "Fakülte İsmi:";
                buttonsType = "fakulte";
                selectedFakulte = null;
            } else if(buttonsType == "ders")
            {
                listbolumler.Visible = true;
                listdersler.Visible = false;
                button3.Visible = false;
                button1.Text = "Bolum Aç";
                button2.Text = "Bölüm'e Git";
                button3.Text = "Bölüm Kapat";
                label1.Text = selectedFakulte.Name;
                label2.Text = "Bölüm İsmi:";
                buttonsType = "bolum";
                selectedBolum = null;
            } else if(buttonsType == "ayrıntı")
            {
                listdersler.Visible = true;
                listOgrenciler.Visible = false;
                listOgretimElemanlari.Visible = false;
                labelogrenciler.Visible = false;
                labelgorevliler.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                panelbuttons.Visible = false;
                label1.Text = selectedBolum.Name;
                buttonsType = "ders";
                selectedDers = null;
            }
        }

        private void dosyayaYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{selectedDers.Name}.txt.");
                string temp = null;
                foreach (Ogrenci a in selectedDers.ogrenciler)
                    temp += "İsim: " + a.Name + "Tc: " + a.Tc + "Yaş: " + a.Age + "Şube: " + a.getSube + "Öğrenci Tipi: " + a.GetType();
                foreach (OgretimElemani a in selectedDers.ogretimGorevlileri)
                    temp += "İsim: " + a.Name + "Tc: " + a.Tc + "Yaş: " + a.Age;

                temp = temp.ToString();
                sw.Write(temp);
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error file writing: "+ ex);
            }
        }

        private void hazırBilgiYukle_Click(object sender, EventArgs e)
        {
            Fakulte fakulte = new Fakulte("IBF");
            Fakulte fakulte2 = new Fakulte("Mühendislik Fakültesi");
            deu.fakulteEkle(fakulte);
            deu.fakulteEkle(fakulte2);

            Bolum bolum = new Bolum("İktisat");
            Bolum bolum2 = new Bolum("İşletme");
            Bolum bolum3 = new Bolum("Endüstri Mühendisliği");
            Bolum bolum4 = new Bolum("Bilgisayar Mühendisliği");

            Ders ders = new Ders("Matematik I");
            Ders ders2 = new Ders("Türk Dili I");

            fakulte.bolumEkle(bolum); 
            fakulte.bolumEkle(bolum2);
            fakulte2.bolumEkle(bolum3);
            fakulte2.bolumEkle(bolum4);

            bolum.dersEkle(ders);
            bolum.dersEkle(ders2);
            bolum2.dersEkle(ders);
            bolum2.dersEkle(ders2);
            bolum3.dersEkle(ders);
            bolum3.dersEkle(ders2);
            bolum4.dersEkle(ders);
            bolum4.dersEkle(ders2);

            ders.ogrenciEkle(new Doktora("Burak Yılmaz", 231925221, 15, new Sube(1))); 
            ders.ogrenciEkle(new YuksekLisans("Jale Koç", 931223221, 21, new Sube(1)));
            ders.ogretimGorevlisiEkle(new OgretimElemani("Neriman Selim", 123223322, 35)); 
            ders.ogretimGorevlisiEkle(new OgretimElemani("Fırat Kaplan", 531223221, 45));

            ders2.ogrenciEkle(new Doktora("Burak Yılmaz", 231925221, 15, new Sube(1)));
            ders2.ogrenciEkle(new YuksekLisans("Jale Koç", 931223221, 21, new Sube(1)));
            ders2.ogretimGorevlisiEkle(new OgretimElemani("Neriman Selim", 123223322, 35));
            ders2.ogretimGorevlisiEkle(new OgretimElemani("Fırat Kaplan", 531223221, 45));

            listfakulte.Items.Add(fakulte.Name);
            listfakulte.Items.Add(fakulte2.Name);
            listbolumler.Items.Add(bolum.Name);
            listbolumler.Items.Add(bolum2.Name);
            listbolumler.Items.Add(bolum3.Name);
            listbolumler.Items.Add(bolum4.Name);
            listdersler.Items.Add(ders.Name);
            listdersler.Items.Add(ders2.Name);


        }
    }
}
