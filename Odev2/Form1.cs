using System;
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
        Universite deu = new Universite(); //deu üniversitesi hazır olarak oluşturulur.

        Fakulte selectedFakulte = null;
        Bolum selectedBolum = null; //tasarımın düzenli ve hatasız ilerlemesi için listboxtan seçilen veriler alınır.
        Ders selectedDers = null;

        private bool justOne = false;

        private string buttonsType = "fakulte"; //butonların textleri visiblity leri için oluşturulmuş buttontype.
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listfakulte.Visible = true; //default olarak fakulteler gösterilir.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; //fakülte, bölüm, ders vb açma işlemlerinin gerçekleştiği panel1.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(buttonsType == "fakulte") //button tiplerine göre farklı işlemler yapılır.
            {
                if (listfakulte.SelectedIndex != -1)
                {
                    selectedFakulte = deu.secilenFakulteyiBul(listfakulte.SelectedItem.ToString()); //seçilen fakülte bulunur.
                    buttonsType = "bolum"; //button tipi değiştirilir.
                    listbolumler.Items.Clear(); //üstüste eklemeleri fixlemek için yüklemeden önce temizlenir.
                    foreach (Bolum a in selectedFakulte.bolumler) //var olan bölümleri yüklemek için.
                    {
                        listbolumler.Items.Add(a.Name);
                    }
                    listfakulte.Visible = false;
                    listbolumler.Visible = true; //tasarımsal düzenlemeler
                    button1.Text = "Bolum Ekle";
                    button2.Text = "Bölüm'e Git";
                    label1.Text = selectedFakulte.Name;
                    label2.Text = "Bölüm İsmi:";
                }
                else
                {
                    MessageBox.Show("Fakülte seçiniz."); //listboxtan item seçilmediği taktirde uyarı.
                }
            } else if (buttonsType == "bolum")
            {
                if(listbolumler.SelectedIndex != -1) //yukardaki işlemlerin benzeri işlemler.
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
                    button2.Text = "Ders'e Git"; //tasarımsal düzenlemeler
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
                if (listdersler.SelectedIndex != -1)  //yukardaki işlemlerin benzeri işlemler.
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
                    labelgorevliler.Visible = true; //tasarımsal düzenlemeler
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

        private void button3_Click(object sender, EventArgs e) //ders silme fonksiyonu
        {
            if(buttonsType == "ders")
            {
                if(listdersler.SelectedIndex != -1)
                {
                    selectedBolum.dersSil(listdersler.SelectedIndex); //seçili bölüm nesnesine index gönderir.
                    listdersler.Items.RemoveAt(listdersler.SelectedIndex);
                } else
                {
                    MessageBox.Show("Ders seçiniz.");
                }
                
            }
        }

        private void kaydet_Click(object sender, EventArgs e) //yeni fakülte bölüm ders ekleme işlemleri
        {
            if(buttonsType == "fakulte") //yukarıda söylendiği gibi buttontipine göre yapılır.
            {
                if (textBoxName.TextLength != 0)
                {
                    Fakulte yeni = new Fakulte(textBoxName.Text); //yeni nesne türetilir, üniversite sınıfındaki fonksiyona gönderilir.
                    deu.fakulteEkle(yeni); 
                    listfakulte.Items.Add(yeni.Name);
                    panel1.Visible = false; //tasarımsal
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
                    Bolum yeni = new Bolum(textBoxName.Text); //yukarıda ki işlemlerin farklı nesne tipleri.
                    selectedFakulte.bolumEkle(yeni);
                    listbolumler.Items.Add(yeni.Name); //tasarımsal
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
                    Ders yeni = new Ders(textBoxName.Text); //yukarıda ki işlemlerin farklı nesne tipleri.
                    selectedBolum.dersEkle(yeni);
                    listdersler.Items.Add(yeni.Name); //tasarımsal
                    panel1.Visible = false;
                    textBoxName.Text = null;
                }
                else
                {
                    MessageBox.Show("Ders ismi zorunludur");
                }
            } 
            
            
        }

        private void ogrenciEkle_Click(object sender, EventArgs e) //ogrenci eklemek için farklı panel ve buttonlar kullanıldı.
        {                                                         
            panelkaydet.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            comboSube.Visible = true;
            comboOgrenciTip.Visible = true;
        }

        private void GorevliEkle_Click(object sender, EventArgs e) //görevli eklemek için farklı panel ve buttonlar kullanıldı.
        {
            panelkaydet.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            comboSube.Visible = false;
            comboOgrenciTip.Visible = false;
        }

        private void ogrenciKaldir_Click(object sender, EventArgs e) //öğrenci silimini nesnedeki fonksiyona iletir.
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

        private void gorevliKaldir_Click(object sender, EventArgs e) //görevli silimini nesnedeki fonksiyona iletir.
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

        private void ogrenciKaydet_Click(object sender, EventArgs e) //tasarımsal bir veriden yararlanarak öğrenci ve görevli eklemeyi tamamlar.
        {
            if(comboSube.Visible == true)//bu veri sadece öğrenci eklemede olduğu için ayırt etmede kullanıldı.
            {
                if(textBox1.TextLength != 0 & TcNo.TextLength != 0 & textBox2.TextLength != 0 & comboSube.SelectedIndex != -1 & comboOgrenciTip.SelectedIndex != -1)
                { //verilerin dolu olmaso
                    if(comboOgrenciTip.SelectedIndex == 0) //lisans yüksek lisans vb öğrenci tiplerinin seçimine göre davranır.
                    {
                        Lisans yeni = new Lisans(textBox1.Text, Convert.ToDouble(TcNo.Text),
                            Convert.ToInt32(textBox2.Text), new Sube(Convert.ToInt32(comboSube.SelectedItem)));
                        selectedDers.ogrenciEkle(yeni); //gerekli bilgiler textboxlar vb araçlardan alınıp nesne yaratılır.
                        listOgrenciler.Items.Add(yeni.Name); //nesnedeki fonksiyona iletilerek eklenir
                        panelkaydet.Visible = false;
                        textBox1.Text = null;
                        TcNo.Text = null; //tasarımsal
                        textBox2.Text = null;
                        comboSube.SelectedIndex = -1;
                        comboOgrenciTip.SelectedIndex = -1;

                    } else if(comboOgrenciTip.SelectedIndex == 1)
                    {
                        YuksekLisans yeni = new YuksekLisans(textBox1.Text,Convert.ToDouble(TcNo.Text),
                            Convert.ToInt32(textBox2.Text),new Sube(Convert.ToInt32(comboSube.SelectedItem)));
                        selectedDers.ogrenciEkle(yeni); //yukarıdaki işlemlerin benzeri.
                        listOgrenciler.Items.Add(yeni.Name);
                        panelkaydet.Visible = false;
                        textBox1.Text = null;
                        TcNo.Text = null; //tasarımsal
                        textBox2.Text = null;
                        comboSube.SelectedIndex = -1;
                        comboOgrenciTip.SelectedIndex = -1;
                    } else
                    {
                        Doktora yeni = new Doktora(textBox1.Text, Convert.ToDouble(TcNo.Text),
                            Convert.ToInt32(textBox2.Text), new Sube(Convert.ToInt32(comboSube.SelectedItem)));
                        selectedDers.ogrenciEkle(yeni); //yukarıdaki işlemlerin benzeri.
                        listOgrenciler.Items.Add(yeni.Name);
                        panelkaydet.Visible = false;
                        textBox1.Text = null;
                        TcNo.Text = null; //tasarımsal
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
                        Convert.ToInt32(textBox2.Text)); //yukarıdaki işlemlerin benzeri şekilde görevli eklenir.
                    selectedDers.ogretimGorevlisiEkle(yeni);
                    listOgretimElemanlari.Items.Add(yeni.Name);
                    panelkaydet.Visible = false;
                    textBox1.Text = null; //tasarımsal
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
            if(buttonsType == "bolum")  //tasarımı kuvvetlendirmek ve kullanıcı deneyimini iyileştirmek(kullanırken sürekli kapatıp açmamak için :D)
            {                           //için bulunulan konuma göre geriye gitme işlemi. Neredeyse tamamen tasarımsaldır.
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

        private void dosyayaYazdir_Click(object sender, EventArgs e) //bulunulan dersin bilgilerini dosyaya yazdırma işlemi.
        {
            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{selectedDers.Name}.txt."); //ders ismine göre
                string temp = null;                                                                                                               //desktopta txt yaratır.
                foreach (Ogrenci a in selectedDers.ogrenciler)
                    temp += "İsim: " + a.Name + "Tc: " + a.Tc + "Yaş: " + a.Age + "Şube: " + a.getSube + "Öğrenci Tipi: " + a.GetType();//for döngüsü ile bilgiler alınır.
                foreach (OgretimElemani a in selectedDers.ogretimGorevlileri) //görevli bilgileri
                    temp += "İsim: " + a.Name + "Tc: " + a.Tc + "Yaş: " + a.Age;

                temp = temp.ToString(); //her ihtimale karşı string dönüşümü.
                sw.Write(temp); //dosya yazımı.
                sw.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error file writing: "+ ex);
            }
        }

        private void hazırBilgiYukle_Click(object sender, EventArgs e) //Ödevi okuyan hocalarımız için müthiş bir fonksiyon :D
        {                                                              //Hızlı bir şekilde test etmek istendiğinde hazır bilgiler girilir.
            if(justOne == false) //karışıklık olmasın :)
            {
                justOne = true;

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
            } else
            {
                MessageBox.Show("Hazıra Dağ dayanmaz.");
            }
        }
    }
}
