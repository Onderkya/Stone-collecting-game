using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> buttonlar = new List<Button>();


        void ButonOlustur()
        {
            for (int i = 1; i <= 49; i++)
            {
                Button btn = new Button();
                btn.Name = "btn_" + i.ToString();
                btn.Height = 50;
                btn.Width = 50;
                btn.Font = new Font("arial", 25, FontStyle.Bold);

                if (i % 2 == 0)
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.Black;
                }
                // btn.UseVisualStyleBackColor = true;
                btn.Click += Btn_Click;
                buttonlar.Insert(i, btn);
                flowLayoutPanel1.Controls.Add(btn);
                btn_basla.Enabled = false;
            }
        }
        int BasarılıToplama = 1;
        int basarısız_toplama = 1;
        private void btn_basla_Click(object sender, EventArgs e)
        {
            
            btn_TekrarOyna.Enabled = true;
            Button btn123 = new Button();
            buttonlar.Insert(0, btn123);

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                ButonlarınDegerleri.Clear();
                flowLayoutPanel1.Controls.Clear();
                LabelTemizle();
                ButonOlustur();
                sayac = 0;
            }
            else {
                LabelTemizle();
                ButonOlustur();
            }


        }
        int sayac = 0;
        int butonsayac = 0;
        List<int> ButonlarınDegerleri = new List<int>();
        Button btn_Kırmızı = new Button();
        Button btn = new Button();
        Button butonson = new Button();
        private void Btn_Click(object sender, EventArgs e)
        {
            Button newbutton = new Button();
            newbutton = (Button)sender;


            //Oyun ilk Başladığında

            if (sayac == 0)
            {
                Random rnd = new Random();
                ButonlarınDegerleri.Clear();
                Button btn_Kırmızı = (Button)sender;
                butonson = btn_Kırmızı;
                btn_Kırmızı.BackColor = Color.Red;
                string butonisim = btn_Kırmızı.Name;
                sayac++;
                int Butonun_Yeri = Convert.ToInt32(butonisim.Substring(4));
                int butondeger = Butonun_Yeri;
                MessageBox.Show("Oyun Başladı");
                ButonlarınDegerleri.Add(butondeger);


                for (int i = 1; i <= 6; i++)
                {

                    Butonun_Yeri = butondeger;
                    int RastgeleYeri = rnd.Next(0, 49);
                   

                    while (ButonlarınDegerleri.Contains(RastgeleYeri))
                    {
                        RastgeleYeri = rnd.Next(1, 49);
                        while (Butonun_Yeri == RastgeleYeri)
                        {
                            RastgeleYeri = rnd.Next(1, 49);
                        }
                    }
                   
                    ButonlarınDegerleri.Add(RastgeleYeri);


                    Button yenibutton = new Button();
                    yenibutton = (Button)buttonlar[RastgeleYeri];
                    yenibutton.Name = "btn_" + RastgeleYeri.ToString();
                    int Adım_Sayısı = 0;

                    // Aynı sutun ve 7'nin katı demektir..
                    bool Yediye_bolunuyormu = Butonun_Yeri % 7 == 0 && RastgeleYeri % 7 == 0;
                    // Aynı sutun ama 7'nin katı değiller.
                    bool Aynı_sutunlarmı = Butonun_Yeri % 7 == RastgeleYeri % 7;


                    

                    if (Aynı_sutunlarmı)
                    {
                        int sonuc = 0;
                        int deger1 = 0;
                        int deger2 = 0;
                        if (Yediye_bolunuyormu)
                        {
                            sonuc = (Butonun_Yeri / 7) - (RastgeleYeri / 7);
                            if (sonuc < 0)
                            {
                                sonuc *= -1;

                                Adım_Sayısı = sonuc - 1;
                            }
                            else if (sonuc == 0)
                            {
                                sonuc++;
                                Adım_Sayısı = sonuc;
                            }
                            else
                            {
                                Adım_Sayısı = sonuc;
                            }

                        }
                        else
                        {
                            deger1 = Butonun_Yeri / 7;
                            if (deger1 < 0)
                            {
                                deger1 *= -1;
                            }
                            deger2 = RastgeleYeri / 7;
                            if (deger2 < 0)
                            {
                                deger2 *= -1;
                            }

                            sonuc = deger1 - deger2;
                            if (sonuc < 0)
                            {
                                sonuc *= -1;
                                Adım_Sayısı = sonuc;
                            }
                            else Adım_Sayısı = sonuc;

                        }
                    }

                    //Farklı sütünlarmı
                    else if (!Aynı_sutunlarmı)
                    {
                        int sonuc = 0;
                        int deger1 = 0;
                        int deger2 = 0;




                        int say1 = 0;
                        bool kontrolbutonilk = Butonun_Yeri % 7 == 0;
                        bool kontrolbutonson = RastgeleYeri % 7 == 0;
                        deger1 = (Butonun_Yeri / 7);
                        if (!kontrolbutonilk)
                        {
                            for (int x = 0; x < 6; x++)
                            {

                                Butonun_Yeri += 1;
                                say1++;
                                if (Butonun_Yeri % 7 == 0)
                                {
                                    break;
                                }



                            }

                        }
                        else
                        {
                            deger1--;
                        }


                        int say2 = 0;
                        deger2 = (RastgeleYeri / 7);
                        if (!kontrolbutonson)
                        {
                            for (int x = 0; x < 6; x++)
                            {

                                RastgeleYeri += 1;
                                say2++;
                                if (RastgeleYeri % 7 == 0)
                                {
                                    break;

                                }



                            }
                        }
                        else { deger2--; }


                        int Artıadim = deger1 - deger2;
                        if (Artıadim < 0)
                        {
                            Artıadim *= -1;
                            sonuc += Artıadim;
                        }
                        else { sonuc += Artıadim; }



                        int gecicisonuc = (say1 - say2);
                        if (gecicisonuc < 0)
                        {
                            gecicisonuc *= -1;
                            Adım_Sayısı = sonuc + gecicisonuc;
                        }



                        Adım_Sayısı = sonuc + gecicisonuc;


                    }

                    yenibutton.Text = Adım_Sayısı.ToString();
                    yenibutton.ForeColor = Color.Red;
                    yenibutton.Font = new Font("arial", 25, FontStyle.Bold);
                }

            }


            else if (!String.IsNullOrEmpty(newbutton.Text) && butonsayac == 0)
            {

                //Seçilen butonum
                btn = newbutton;
                lbl_SecilenTas.Text = btn.Text;
                butonsayac = 1;

                // Demekki tıklanması gereken butona tıklanmıs demektir..
                // burada bir kontrol daha yapılmalı ve ilk buton ile diğer buton karşılatırılacağı için 
                // ilk butonu bir dizide veya nesnede tutmalı, sonra eğer diğer tıklanan butonun text'i boş ise demekki kullanıcı
                //doğru şeye tıklamış demektir ve ilk butonun text değeri 1 azaltırıp diğer butona aktarılır böylede hareket etmiş
                //olur...



            }
            else if (!String.IsNullOrEmpty(newbutton.Text) && butonsayac == 1)
            {
                MessageBox.Show("Lütfen Boş Bir Yeri Seçiniz Hareket için Boş Biryer Gerekli");

            }


            //int bir_x = btn.Location.X;
            //int bir_y = btn.Location.Y;
            //int iki_x =  newbutton.Location.X;
            //int iki_y = newbutton.Location.Y;









            else if (String.IsNullOrEmpty(newbutton.Text) && butonsayac == 1)
            {
                int tıklanan = Convert.ToInt32(btn.Name.Substring(4));
                int yenitıklanan = Convert.ToInt32(newbutton.Name.Substring(4));

                if (tıklanan + 1 == yenitıklanan || tıklanan - 1 == yenitıklanan || tıklanan + 7 == yenitıklanan || tıklanan - 7 == yenitıklanan)
                {
                    string deger = btn.Text;
                    btn.Text = "";
                    butonsayac = 0;
                    //butonu bulduk demektir yani hareket edebiliriz....
                    bool kontrol = newbutton.Location == butonson.Location;
                    if (Convert.ToInt32(deger) > 0)
                    {
                        deger = (Convert.ToInt32(deger) - 1).ToString();
                        newbutton.Text = deger;
                        newbutton.ForeColor = Color.Red;



                        if (Convert.ToInt32(newbutton.Text) == 0 && kontrol)
                        {

                            btn.Text = "";
                            newbutton.Text = "";
                            lbl_Basarılıtoplama.Text = BasarılıToplama.ToString();

                            lbl_Skor.Text = (Convert.ToInt32(lbl_Skor.Text) + 1).ToString();
                            MessageBox.Show("Tebrikler taş başarıyla toplandı");
                            OyunBittimi();
                            BasarılıToplama++;


                        }

                        else if (Convert.ToInt32(newbutton.Text) == 0 && !kontrol)
                        {
                            newbutton.Text = "";

                            lbl_Basarısıztoplama.Text = basarısız_toplama.ToString();
                            lbl_Skor.Text = (Convert.ToInt32(lbl_Skor.Text) - 1).ToString();
                            MessageBox.Show("Malesef Taş Toplanamadı.");
                            OyunBittimi();
                            basarısız_toplama++;
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Yeniden Taş Seçin");

                        }

                    }
                    else if ((Convert.ToInt32(newbutton.Text) == 0 && !kontrol))
                    {
                        btn.Text = "";
                        newbutton.Text = "";
                        MessageBox.Show("Malesef Olmadı.");
                        OyunBittimi();

                    }
                    else
                    {
                        newbutton.Text = (Convert.ToInt32(btn.Text) - 1).ToString();
                        newbutton.ForeColor = Color.Red;
                        btn.Text = "";
                        MessageBox.Show("Lütfen Yeniden Taş Seçin");

                    }

                }
                else
                {

                    MessageBox.Show("Bir Hamlede Tek Kare İlerleyebilirisiniz.");
                }





            }
            else
            {

            }



                }
                void OyunBittimi()
                {

                    int sonuc = Convert.ToInt32(lbl_Basarılıtoplama.Text) + Convert.ToInt32(lbl_Basarısıztoplama.Text);
                    if (sonuc == 6)
                    {
                        DialogResult dg = new DialogResult();
                        dg = MessageBox.Show("Oyun bitti", "Oyun Sona Erdi !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.OK)
                        {
                            Application.Restart();
                        }
                        else
                        {
                            Application.Restart();

                        }




                    }
                }

                void LabelTemizle()
                {

                    lbl_Basarılıtoplama.Text = 0.ToString();
                    lbl_Basarısıztoplama.Text = 0.ToString();
                    lbl_SecilenTas.Text = 0.ToString();
                    lbl_Skor.Text = 0.ToString();
                }


            }
        }
    

        



       
    




