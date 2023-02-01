using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        #region Radio Button Check - Group Box Visibility

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // girilen sayıların ortalaması
        {

            sayiOrtgbx.Visible = true;
            sayıAdediHesapgbx.Visible = false;
            metinIslemgbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sayıAdediHesapgbx.Visible = true;
            sayiOrtgbx.Visible = false;
            metinIslemgbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            metinIslemgbx.Visible = true;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ikilikSistemgbx.Visible = true;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            mukemmelSayigbx.Visible = true;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }


        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            toplamOtuzSayıAdedigbx.Visible = true;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;         
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            indirimliFiyatHesapgbx.Visible = true;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            koordinatSisgbx.Visible = false;;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            koordinatSisgbx.Visible = true;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            permutasyonKombinasyongbx.Visible = true;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            sıfırGirisigbx.Visible = true;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            sicaklikDonusumgbx.Visible = true;
            sıfırGirisigbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            sicaklikDonusumgbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            kdvHesapgbx.Visible = true;
            sicaklikDonusumgbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;

        }
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            geometrikSekilIslemgbx.Visible = true;
            sicaklikDonusumgbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            diziHarfNotugbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            diziHarfNotugbx.Visible=true;
            geometrikSekilIslemgbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            kdvHesapgbx.Visible = false;
            bolunebilmeKontrolugbx.Visible = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            bolunebilmeKontrolugbx.Visible = true;
            diziHarfNotugbx.Visible = false;
            geometrikSekilIslemgbx.Visible = false;
            sicaklikDonusumgbx.Visible = false;
            sıfırGirisigbx.Visible = false;
            permutasyonKombinasyongbx.Visible = false;
            koordinatSisgbx.Visible = false;
            indirimliFiyatHesapgbx.Visible = false;
            toplamOtuzSayıAdedigbx.Visible = false;
            mukemmelSayigbx.Visible = false;
            ikilikSistemgbx.Visible = false;
            metinIslemgbx.Visible = false;
            sayiOrtgbx.Visible = false;
            sayıAdediHesapgbx.Visible = false;
            kdvHesapgbx.Visible = false;
        }
        #endregion

        #region Öğrenci Adı ve Not Girilen Diziden Harf Notu Hesaplama

        int a = 0, b = 0, c = 0, d = 0, f = 0, harf = 0,sayac = 0 ,j = 0;
        int max, min;
        int val;

        public void diziElemanEkleme(string[] not)
        {
            for (int i = 0; i < not.Length; i += 2)
            {
                not[i] = diziHarfNotuDersAdıtxt.Text;
                not[i + 1] = diziHarfNotuDersNotutxt.Text;
            }
        }
        public void harfNotu(string[] not)
        {
            for (int i = 0; i < not.Length; i += 2)
            {
                if (Int32.TryParse(not[i + 1], out val))
                {
                    harf = Int32.Parse(not[i + 1]);
                    if (j == 0)
                    {
                        max = harf;
                        min = harf;
                    }
                    else
                    {
                        if (max < harf)
                            max = harf;
                        if (min > harf)
                            min = harf;
                    }

                    if (harf <= 100 || harf >= 0)
                    {
                        if (harf >= 85)
                            a++;
                        else if (harf >= 70)
                            b++;
                        else if (harf >= 60)
                            c++;
                        else if (harf >= 50)
                            d++;
                        else
                            f++;
                    }
                }
            }
            
        }
        
        public void harfNotuSayıYazdir()
        {
            diziHarfNotuAlbl.Text = a.ToString();
            diziHarfNotuBlbl.Text = b.ToString();
            diziHarfNotuClbl.Text = c.ToString();
            diziHarfNotuDlbl.Text = d.ToString();
            diziHarfNotuFlbl.Text = f.ToString();
        }
        private void diziHarfNotuMaxMincmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            String cevap = diziHarfNotuMaxMincmbx.Text;
            switch (cevap)
            {
                case "En yüksek":
                    diziHarfNotuSonuclbl.Text = max.ToString();
                    break;
                case "En düşük":
                    diziHarfNotuSonuclbl.Text = min.ToString();
                    break;
            }
        }
        private void diziHarfNotuGirisbtn_Click(object sender, EventArgs e)
        {
            int sayi = 3;
            int size = sayi * 2;
            string[] not = new string[size];

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                if (sayac < sayi)
                {
                    for (int i = 0; i < size; i += 2)
                    {
                        not[i] = diziHarfNotuDersAdıtxt.Text;
                        not[i + 1] = diziHarfNotuDersNotutxt.Text;

                        if (Int32.TryParse(not[i + 1], out val))
                        {
                            harf = Int32.Parse(not[i + 1]);
                            if (sayac == 0)
                            {
                                max = harf;
                                min = harf;
                            }
                            else
                            {
                                if (max < harf)
                                    max = harf;
                                if (min > harf)
                                    min = harf;
                            }

                            if (harf <= 100 || harf >= 0)
                            {
                                if (harf >= 85)
                                    a++;
                                else if (harf >= 70)
                                    b++;
                                else if (harf >= 60)
                                    c++;
                                else if (harf >= 50)
                                    d++;
                                else
                                    f++;
                            }
                        }
                        diziHarfNotuDersAdıtxt.Text = "";
                        diziHarfNotuDersNotutxt.Text = "";

                    }
                    sayac++;
                    diziHarfNotuDersAdıtxt.Select();
                    diziHarfNotuDersNotutxt.Select();
                }
                else
                {
                    diziHarfNotuAlbl.Text = a.ToString();
                    diziHarfNotuBlbl.Text = b.ToString();
                    diziHarfNotuClbl.Text = c.ToString();
                    diziHarfNotuDlbl.Text = d.ToString();
                    diziHarfNotuFlbl.Text = f.ToString();

                    diziHarfNotuMaxMinlbl.Visible = true;
                    diziHarfNotuMaxMincmbx.Visible = true;

                }
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                if (sayac < sayi)
                {
                    diziElemanEkleme(not);
                    diziHarfNotuDersAdıtxt.Text = "";
                    diziHarfNotuDersNotutxt.Text = "";
                    harfNotu(not);
                    sayac++;  
                }
                else
                {
                    harfNotuSayıYazdir();
                    diziHarfNotuMaxMinlbl.Visible = true;
                    diziHarfNotuMaxMincmbx.Visible = true;
                }
            }

            #endregion

            else
                diziHarfNotuAlbl.Text = "Seçim yapınız";



        }

        #endregion

        #region Seçilen Geometrik Şekil ve İşleme Göre Hesaplama

        private void geometrikSekilIslemSayitxt_KeyPress(object sender, KeyPressEventArgs e)
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
         
                }

                private void geometrikSekilIslemSayitxt_TextChanged(object sender, EventArgs e)
                {
                    if (geometrikSekilIslemSayitxt.Text == "")
                    {
                        geometrikSekilIslemHesaplabtn.Enabled = false;
                    }
                    geometrikSekilIslemHesaplabtn.Enabled = true;
                }

                int geometrikSekilIslemSayi = 0, geometrikSekilIslemSayi1 = 0, geometrikSekilIslemSayi2 = 0, geometrikSekilIslemSayac = 0, geometrikSekilIslemSonuc = 0, geometrikSekilIslemKenar = 0;
                String sekil, islem;
                String ucgen = "";

                private void geometrikSekilIslemSekilcmbx_SelectedIndexChanged(object sender, EventArgs e)
                {
                    sekil = geometrikSekilIslemSekilcmbx.Text;
                    islem = geometrikSekilIslemcmbdx.Text;
                    ucgen = geometrikSekilIslemUcgencmbx.Text;

                    if (sekil == "Üçgen")
                    {
                        geometrikSekilIslemSekilUcgenlbl.Visible = true;
                        geometrikSekilIslemUcgencmbx.Visible = true;
                    }
                    else
                    {
                        geometrikSekilIslemUcgencmbx.Visible = false;
                    }

                    if (sekil == "Daire")
                    {
                        geometrikSekilIslemlbl.Visible = false;
                        geometrikSekilIslemSayaclbl.Text = "";
                        geometrikSekilIslemUzunluklbl.Text = "Yarıçap uzunluğu: ";
                    }

                    if (sekil == "Kare")
                    {
                        geometrikSekilIslemlbl.Visible = false;
                        geometrikSekilIslemSayaclbl.Text = "";
                        geometrikSekilIslemUzunluklbl.Text = "Kenar uzunluğu: ";
                    }
                    if (sekil == "Dikdörtgen")
                    {
                        geometrikSekilIslemlbl.Visible = false;
                        geometrikSekilIslemSayaclbl.Text = (geometrikSekilIslemSayac+1)+".".ToString();
                        geometrikSekilIslemUzunluklbl.Text = "Kenar uzunluğu: ";
                    }

                    if (!(sekil == ""))
                    {
               
                        geometrikSekilIslemSecimlbl.Visible = true;
                        geometrikSekilIslemcmbdx.Visible = true;
                
                    }
                    else
                    {
                        geometrikSekilIslemcmbdx.Visible = false;
                    }
                }
                private void geometrikSekilIslemcmbdx_SelectedIndexChanged(object sender, EventArgs e)
                {
                    sekil = geometrikSekilIslemSekilcmbx.Text;
                    islem = geometrikSekilIslemcmbdx.Text;
                    ucgen = geometrikSekilIslemUcgencmbx.Text;
                    if (sekil == "Üçgen")
                    {
                        geometrikSekilIslemSekilUcgenlbl.Visible = true;
                        geometrikSekilIslemUcgencmbx.Visible = true;
                

                        switch (islem)
                        {
                            case "Alan":
                                geometrikSekilIslemlbl.Visible = false;
                                geometrikSekilIslemSayaclbl.Text = "";
                                geometrikSekilIslemSayaclbl.Text = "Taban Uzunluğu:";
                                break;
                            case "Çevre":
                                geometrikSekilIslemlbl.Visible = false;
                                geometrikSekilIslemSayaclbl.Text = "";
                                geometrikSekilIslemUzunluklbl.Text = "Kenar Uzunluğu:";
                                break;
                            default:
                                geometrikSekilIslemSonuclbl.Text = "İşlem seçiniz.";
                                break;
                        }

                    }
                }

                private void geometrikSekilIslemSayibtn_Click(object sender, EventArgs e)
                {
                    sekil = geometrikSekilIslemSekilcmbx.Text;
                    islem = geometrikSekilIslemcmbdx.Text;
                    switch (sekil)
                    {
                        case "Üçgen":
                            {
                        
                                switch (islem)
                                {

                                    case "Alan":
                                        {
                                    
                                            if (geometrikSekilIslemSayac < 2)
                                            {
                                                if (geometrikSekilIslemSayac == 0)
                                                {
                                                    geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
       
                                                }
                                                geometrikSekilIslemlbl.Visible = false;
                                                geometrikSekilIslemSayaclbl.Text = "";
                                                geometrikSekilIslemUzunluklbl.Text = "Yükseklik:";
                                                geometrikSekilIslemSayi1 = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSayac++;
                                                geometrikSekilIslemSonuc = (geometrikSekilIslemSayi * geometrikSekilIslemSayi1) / 2;
                                                geometrikSekilIslemSayitxt.Text = "";

                                            }
                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    case "Çevre":
                                        {
                                   
                                            if (geometrikSekilIslemSayac < 3)
                                            {
                                                if (geometrikSekilIslemSayac == 0)
                                                {
                                                    geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                }
                                                else if (geometrikSekilIslemSayac == 1)
                                                {
                                                    geometrikSekilIslemSayi1 = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                }
                                                else
                                                {
                                                    geometrikSekilIslemSayi2 = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                }

                                                geometrikSekilIslemSonuc = geometrikSekilIslemSayi + geometrikSekilIslemSayi1 + geometrikSekilIslemSayi2;
                                                geometrikSekilIslemSayac++;
                                                geometrikSekilIslemSayitxt.Text = "";
                                                geometrikSekilIslemSayaclbl.Text = (geometrikSekilIslemSayac + 1) + ".".ToString();
                                            }
                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                break;
                            }
                        case "Daire":
                            {
                                int pi = 3;
                                switch (islem)
                                {
                                    case "Alan":
                                        {
                                            if (geometrikSekilIslemSayac < 1)
                                            {
                                                geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSonuc = pi * geometrikSekilIslemSayi * geometrikSekilIslemSayi;
                                                geometrikSekilIslemSayac++;
                                            }

                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    case "Çevre":
                                        {
                                            if (geometrikSekilIslemSayac < 2)
                                            {
                                                geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSayac++;
                                                geometrikSekilIslemSonuc = 2 * pi * geometrikSekilIslemSayi;
                                            }
                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            break;
                        case "Kare":
                            {
                                switch (islem)
                                {
                                    case "Alan":
                                        {
                                            if (geometrikSekilIslemSayac < 1)
                                            {

                                                geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSonuc = geometrikSekilIslemSayi * geometrikSekilIslemSayi;
                                                geometrikSekilIslemSayac++;
                                            }

                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    case "Çevre":
                                        {
                                            if (geometrikSekilIslemSayac < 1)
                                            {
                                                geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSayac++;
                                                geometrikSekilIslemSonuc = 4 * geometrikSekilIslemSayi;
                                            }

                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case "Dikdörtgen":
                            {
                                switch (islem)
                                {
                                    case "Alan":
                                        {
                                            if (geometrikSekilIslemSayac < 2)
                                            {
                                                if (geometrikSekilIslemSayac == 0)
                                                {
                                                    geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                }
                                                int sayi1 = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSonuc = geometrikSekilIslemSayi * sayi1;
                                                geometrikSekilIslemSayac++;
                                                geometrikSekilIslemSayitxt.Text = "";
                                                geometrikSekilIslemSayaclbl.Text = (geometrikSekilIslemSayac + 1) + ".".ToString();
                                            }

                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    case "Çevre":
                                        {
                                            if (geometrikSekilIslemSayac < 2)
                                            {
                                                geometrikSekilIslemSayi = Int32.Parse(geometrikSekilIslemSayitxt.Text);
                                                geometrikSekilIslemSayac++;
                                                geometrikSekilIslemKenar += geometrikSekilIslemSayi;
                                                geometrikSekilIslemSonuc = 2 * geometrikSekilIslemKenar;
                                                geometrikSekilIslemSayitxt.Text = "";
                                                geometrikSekilIslemSayaclbl.Text = (geometrikSekilIslemSayac + 1) + ".".ToString();
                                            }

                                            geometrikSekilIslemSayitxt.Select();
                                        }
                                        break;
                                    default:
                                        break;

                                }
                            }
                            break;
                        default:
                            geometrikSekilIslemSonuclbl.Text = "Lütfen seçimlerinizi yapınız.";
                            geometrikSekilIslemSayitxt.Select();
                            break;

                    }
            
                }

                private void geometrikSekilIslemHesaplabtn_Click(object sender, EventArgs e)
                {
                    geometrikSekilIslemSonuclbl.Text = geometrikSekilIslemSonuc.ToString();
                    sekil = geometrikSekilIslemSekilcmbx.Text;
                    islem = geometrikSekilIslemcmbdx.Text;
                    ucgen = geometrikSekilIslemUcgencmbx.Text;

                    if (sekil == "Üçgen")
                    {
                        if (islem == "Alan")
                        {
                            if (geometrikSekilIslemSayac != 2)
                            {
                                geometrikSekilIslemSonuclbl.Text = "Eksik sayıda uzunluk girdiniz";
                            }
                            else
                            {
                                geometrikSekilIslemSonuclbl.Text = geometrikSekilIslemSonuc.ToString();
                            }
                        }
                        else if (islem == "Çevre")
                        {
                            if (geometrikSekilIslemSayac != 3)
                            {
                                geometrikSekilIslemSonuclbl.Text = "Eksik sayıda uzunluk girdiniz";
                            }
                            else
                            {
                                geometrikSekilIslemSonuclbl.Text = geometrikSekilIslemSonuc.ToString();
                            }
                        }
                        else
                        {
                            geometrikSekilIslemSonuclbl.Text = "İşlem seçiniz.";
                        }

                    }
                    if (sekil == "Dikdörtgen")
                    {

                        if (geometrikSekilIslemSayac != 2)
                        {
                            geometrikSekilIslemSonuclbl.Text = "Eksik sayıda uzunluk girdiniz";
                        }
                        else
                        {
                            geometrikSekilIslemSonuclbl.Text = geometrikSekilIslemSonuc.ToString();
                        }
                    }
                }


        #endregion

        #region Sıcaklık Birimi Dönüşümü

        static void sicaklikDonusum(byte c, Form1 form)
        {
            double kelvin;
            double fahrenheit;

            fahrenheit = (c * 9 / 5) + 32;
            kelvin = c + 273.15;

            form.sicaklikDonusumFahrenheitlbl.Text = fahrenheit.ToString() + " °F";
            form.sicaklikDonusumKelvinlbl.Text = kelvin.ToString() + " °K";

        }

        private void sicaklikDonusumHesaplabtn_Click(object sender, EventArgs e)
        {

            byte celsius = Byte.Parse(sicaklikDonusumCelsiustxt.Text);

            #region Normal
            double kelvin;
            double fahrenheit;

            if (normalRadioButton.Checked == true)
            {
                metotRadioButton.Checked = false;
                

                fahrenheit = (celsius * 9 / 5) + 32;
                kelvin = celsius + 273.15;

                sicaklikDonusumFahrenheitlbl.Text = fahrenheit.ToString() + " °F";
                sicaklikDonusumKelvinlbl.Text = kelvin.ToString() + " °K";
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                normalRadioButton.Checked = false;
               

                sicaklikDonusum(celsius, this);
            }

            #endregion

          
            else
                sicaklikDonusumFahrenheitlbl.Text = "Seçim yapınız";

        }
        private void sicaklikDonusumCelsiustxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
   
        }

        #endregion

        #region Sıfır Girilinceye Kadar Kullanıcıdan Sayı Alıp Negatif ve Pozitiflerle İşlemler

        int sıfırGirisiSayi, sıfırGirisiNegatif = 0, sıfırGirisiPozitif = 0, sıfırGirisiToplamN = 0, sıfırGirisiToplamP = 0;

        public void sıfırGirilme(Form1 form, params int[] sayi)
        {         
            foreach (int i in sayi)
            {
                if (i < 0)
                {
                    sıfırGirisiNegatif += 1;
                    sıfırGirisiToplamN += i;
                }
                else if (i > 0)
                {
                    sıfırGirisiPozitif += 1;
                    sıfırGirisiToplamP += i;
                }
            }

        }

        public void sıfırYazdir()
        {
            sıfırGirisiSayitxt.Select();
            sıfırGirisiNtoplamlbl.Text = sıfırGirisiToplamN.ToString();
            sıfırGirisiNadetlbl.Text = sıfırGirisiNegatif.ToString();
            sıfırGirisiNortllbl.Text = (sıfırGirisiToplamN / sıfırGirisiNegatif).ToString();
            sıfırGirisiPtoplamlbl.Text = sıfırGirisiToplamP.ToString();
            sıfırGirisiPadetlbl.Text = sıfırGirisiPozitif.ToString();
            sıfırGirisiPortlbl.Text = (sıfırGirisiToplamP / sıfırGirisiPozitif).ToString();
        }
        private void sıfırGirisiGirisbtn_Click(object sender, EventArgs e)
        {
            sıfırGirisiSayi = Int32.Parse(sıfırGirisiSayitxt.Text);

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                if (sıfırGirisiSayi != 0)
                {
                    sıfırGirisiSayi = Int32.Parse(sıfırGirisiSayitxt.Text);
                    if (sıfırGirisiSayi < 0)
                    {
                        sıfırGirisiNegatif += 1;
                        sıfırGirisiToplamN += sıfırGirisiSayi;
                    }
                    else if (sıfırGirisiSayi > 0)
                    {
                        sıfırGirisiPozitif += 1;
                        sıfırGirisiToplamP += sıfırGirisiSayi;
                    }
                    sıfırGirisiSayitxt.Text = "";
                }
                else
                {
                    sıfırGirisiSayitxt.Select();
                    sıfırGirisiNtoplamlbl.Text = sıfırGirisiToplamN.ToString();
                    sıfırGirisiNadetlbl.Text = sıfırGirisiNegatif.ToString();
                    sıfırGirisiNortllbl.Text = (sıfırGirisiToplamN / sıfırGirisiNegatif).ToString();
                    sıfırGirisiPtoplamlbl.Text = sıfırGirisiToplamP.ToString();
                    sıfırGirisiPadetlbl.Text = sıfırGirisiPozitif.ToString();
                    sıfırGirisiPortlbl.Text = (sıfırGirisiToplamP / sıfırGirisiPozitif).ToString();
                }
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                if (sıfırGirisiSayi != 0)
                {
                    sıfırGirisiSayi = Int32.Parse(sıfırGirisiSayitxt.Text);
                    sıfırGirilme(this, sıfırGirisiSayi);
                    sıfırGirisiSayitxt.Text = "";
                }
                else
                    sıfırYazdir();
            }

            #endregion

            #region OOP

            else if (metotRadioButton.Checked == true)
            {
              

            }

            #endregion

            else
                sıfırGirisiPortlbl.Text = "Seçim yapınız";



        }
        private void sıfırGirisiSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }


        #endregion

        #region Permütasyon / Kombinasyon

        int fak1 = 1, fak2 = 1, fak3 = 1;

        static void permKombHesap(string secim, int sayi1, int sayi2, Form1 form)
        {
            int fak1 = 1, fak2 = 1, fak3 = 1;
            int a = sayi1 - sayi2;

            if (secim == "Permütasyon")
            {
                int i = 1;
                while (i <= sayi1)
                {
                    fak1 *= i;
                    i++;
                }
                int j = 1;
                while (j <= a)
                {
                    fak2 *= j;
                    j++;
                }
                form.permutasyonKombinasyonSonuclbl.Text = (fak1 / fak2).ToString();
            }
            else if (secim == "Kombinasyon")
            {
                for (int i = 1; i <= sayi1; i++)
                    fak1 *= i;
                for (int j = 1; j <= sayi2; j++)
                    fak2 *= j;
                for (int k = 1; k <= a; k++)
                    fak3 *= k;
                form.permutasyonKombinasyonSonuclbl.Text = (fak1 / (fak2 * fak3)).ToString();
            }
            else
                form.permutasyonKombinasyonSonuclbl.Text = "Seçim yapınız";


        }

        private void permutasyonKombinasyonHesaplabtn_Click(object sender, EventArgs e)
        {           
            int n = Int32.Parse(permutasyonKombinasyonNtxt.Text);
            int r = Int32.Parse(permutasyonKombinasyonRtxt.Text);
            String secim = permutasyonKombinasyonSecimcmbx.Text;
            int a = n - r;

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                if (secim == "Permütasyon")
                {
                    int i = 1;
                    while (i <= n)
                    {
                        fak1 *= i;
                        i++;
                    }
                    int j = 1;
                    while (j <= a)
                    {
                        fak2 *= j;
                        j++;
                    }
                    permutasyonKombinasyonSonuclbl.Text = (fak1 / fak2).ToString();
                }
                else if (secim == "Kombinasyon")
                {

                    for (int i = 1; i <= n; i++)
                        fak1 *= i;
                    for (int j = 1; j <= r; j++)
                        fak2 *= j;
                    for (int k = 1; k <= a; k++)
                        fak3 *= k;

                    permutasyonKombinasyonSonuclbl.Text = (fak1 / (fak2 * fak3)).ToString();
                }
                else
                {
                    permutasyonKombinasyonSonuclbl.Text = "Yöntem Seçiniz";
                }
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                permKombHesap(secim, n, r, this);
            }

            #endregion

          

            else
                permutasyonKombinasyonSonuclbl.Text = "Seçim yapınız";

            
        }

        private void permutasyonKombinasyonRtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void permutasyonKombinasyonNtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        #endregion

        #region Koordinat Noktasının Bölgesini Bulma

        static void koordinat(int x,int y, Form1 form)
        {
            if (x > 0 && y > 0)
            {
                form.koordinatFirstlbl.Text = (x, y).ToString();
                form.koordinatSonuclbl.Text = (x, y).ToString() + " birinci bölgede yer alır";
            }
            else if (x < 0 && y > 0)
            {
                form.koordinatSecondlbl.Text = (x, y).ToString();
                form.koordinatSonuclbl.Text = (x, y).ToString() + " ikinci bölgede yer alır";
            }
            else if (x < 0 && y < 0)
            {
                form.koordinatThirdlbl.Text = (x, y).ToString();
                form.koordinatSonuclbl.Text = (x, y).ToString() + " üçüncü bölgede yer alır";
            }
            else if (x > 0 && y < 0)
            {
                form.koordinatFourthlbl.Text = (x, y).ToString();
                form.koordinatSonuclbl.Text = (x, y).ToString() + " dördüncü bölgede yer alır";
            }
            else if ((x > 0 && y == 0) || (x < 0 && y == 0))
                form.koordinatSonuclbl.Text = (x, y).ToString() + " noktası x eksenindedir";
            else if ((x == 0 && y > 0) || (x == 0 && y < 0))
                form.koordinatSonuclbl.Text = (x, y).ToString() + " noktası y eksenindedir";
            else
                form.koordinatSonuclbl.Text = (x, y).ToString() + " başlangıç noktasında yer alır";
        }
        private void koordinatHesaplabtn_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(koordinatXtxt.Text);
            int y = Int32.Parse(koordinatYtxt.Text);

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                if (x > 0 && y > 0)
                {
                    koordinatFirstlbl.Text = (x, y).ToString();
                    koordinatSonuclbl.Text = (x, y).ToString() + " birinci bölgede yer alır";
                }
                else if (x < 0 && y > 0)
                {
                    koordinatSecondlbl.Text = (x, y).ToString();
                    koordinatSonuclbl.Text = (x, y).ToString() + " ikinci bölgede yer alır";
                }
                else if (x < 0 && y < 0)
                {
                    koordinatThirdlbl.Text = (x, y).ToString();
                    koordinatSonuclbl.Text = (x, y).ToString() + " üçüncü bölgede yer alır";
                }
                else if (x > 0 && y < 0)
                {
                    koordinatFourthlbl.Text = (x, y).ToString();
                    koordinatSonuclbl.Text = (x, y).ToString() + " dördüncü bölgede yer alır";
                }
                else if ((x > 0 && y == 0) || (x < 0 && y == 0))
                {
                    koordinatSonuclbl.Text = (x, y).ToString() + " noktası x eksenindedir";
                }
                else if ((x == 0 && y > 0) || (x == 0 && y < 0))
                {
                    koordinatSonuclbl.Text = (x, y).ToString() + " noktası y eksenindedir";
                }
                else
                {
                    koordinatSonuclbl.Text = (x, y).ToString() + " başlangıç noktasında yer alır";
                }
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                koordinat(x, y, this);
            }

            #endregion

          

            else
                koordinatSonuclbl.Text = "Seçim yapınız";



        }
        private void koordinatXtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void koordinatYtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region Alışveriş Tutarına Göre İndirimli Yeni Fiyat Hesaplama
  

        static void fiyatHesap(int tutar, Form1 form)
        {
            int indirimli = 0;
            if (tutar > 0 && tutar < 200)
            {
                indirimli = (tutar - (tutar * 10 / 100));
                form.indirimliFiyatHesapİndirimlilbl.Text = indirimli.ToString() + " TL";
            }
            else if (tutar >= 200 && tutar <= 400)
            {
                indirimli = (tutar - (tutar * 15 / 100));
                form.indirimliFiyatHesapİndirimlilbl.Text = indirimli.ToString() + " TL";
            }
            else if (tutar > 400)
            {
                indirimli = (tutar - (tutar * 20 / 100));
                form.indirimliFiyatHesapİndirimlilbl.Text = indirimli.ToString() + " TL";
            }
            else
                form.indirimliFiyatHesapİndirimlilbl.Text = "Fiyat negatif olamaz.";
        }

        private void indirimliFiyatHesaplabtn_Click(object sender, EventArgs e)
        {
            int indirimli = 0;
            #region Normal
            int tutar = Int32.Parse(indirimliFiyatHesapTutartxt.Text);
            if (normalRadioButton.Checked == true)
            {
                if (tutar > 0 && tutar < 200)
                {
                    indirimli = (tutar - (tutar * 10 / 100));
                    indirimliFiyatHesapİndirimlilbl.Text = indirimli.ToString() + " TL";
                }
                else if (tutar >= 200 && tutar <= 400)
                {
                    indirimli = (tutar - (tutar * 15 / 100));
                    indirimliFiyatHesapİndirimlilbl.Text = indirimli.ToString() + " TL";
                }
                else if (tutar > 400)
                {
                    indirimli = (tutar - (tutar * 20 / 100));
                    indirimliFiyatHesapİndirimlilbl.Text = indirimli.ToString() + " TL";
                }
                else
                    indirimliFiyatHesapİndirimlilbl.Text = "Fiyat negatif olamaz.";
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                fiyatHesap(tutar, this);
            }

            #endregion

            else
                indirimliFiyatHesapİndirimlilbl.Text = "Seçim yapınız";


        }
        private void indirimliFiyatHesapTutartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }


        #endregion

        #region Girilen Sayıların Toplamı 30dan Fazla Olduğunda Sayı Adedi
        int toplamOtuzSayıAdediAdet = 0, toplamOtuzSayıAdediToplam = 0, toplamOtuzSayıAdediSayi, toplam30 = 0;

        public int sayiToplamOtuz(Form1 form, params int[] sayilar)
        {
            foreach (int i in sayilar)
            {
                toplamOtuzSayıAdediToplam += i;
                toplamOtuzSayıAdediAdet++;
            }
            return toplamOtuzSayıAdediToplam;
        }
        public void toplamOtuzYazdir()
        {
            toplamOtuzSayıAdediToplamlbl.Text = toplamOtuzSayıAdediToplam.ToString();
            toplamOtuzSayıAdediAdetlbl.Text = toplamOtuzSayıAdediAdet.ToString();
        }
        
        private void toplamOtuzSayıAdediGirisbtn_Click(object sender, EventArgs e)
        {            
            #region Normal

            if (normalRadioButton.Checked == true)
            {
                if (toplamOtuzSayıAdediToplam <= 30)
                {
                    toplamOtuzSayıAdediSayi = Int32.Parse(toplamOtuzSayıAdediSayitxt.Text);
                    toplamOtuzSayıAdediToplam += toplamOtuzSayıAdediSayi;
                    toplamOtuzSayıAdediAdet += 1;
                    toplamOtuzSayıAdediSayitxt.Text = "";
                }
                else
                {
                    toplamOtuzSayıAdediSayitxt.Select();
                    toplamOtuzSayıAdediToplamlbl.Text = toplamOtuzSayıAdediToplam.ToString();
                    toplamOtuzSayıAdediAdetlbl.Text = toplamOtuzSayıAdediAdet.ToString();
                }

            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                toplamOtuzSayıAdediSayi = Int32.Parse(toplamOtuzSayıAdediSayitxt.Text);
                if (sayiToplamOtuz(this, toplamOtuzSayıAdediSayi) <= 30)
                {
                    toplamOtuzSayıAdediSayi = Int32.Parse(toplamOtuzSayıAdediSayitxt.Text);
                    toplamOtuzSayıAdediSayitxt.Text = "";
                }
                else
                {
                    toplamOtuzSayıAdediSayitxt.Select();
                    toplamOtuzYazdir();
                }



            }

            #endregion


            else
                toplamOtuzSayıAdediAdetlbl.Text = "Seçim yapınız";



        }

        private void toplamOtuzSayıAdediSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        #endregion

        #region Mükemmel Sayı mı?

        int toplam = 0;
        int i = 1;
        public void mukemmelSayi(int sayi)
        {
            while (i < sayi)
            {
                if (sayi % i == 0)
                    toplam += i;
                i++;
            }
            if (toplam == sayi)
            {
                mukemmelSayiSonuclbl.Text = "Mükemmel sayıdır";
            }
            else
                mukemmelSayiSonuclbl.Text = "Mükemmel sayı değildir";
        }
        private void mukkemmelSayiHesaplabtn_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(mukemmelSayitxt.Text);

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                metotRadioButton.Checked = false;
                
                while (i < sayi)
                {
                    if (sayi % i == 0)
                        toplam += i;
                    i++;
                }
                if (toplam == sayi)
                {
                    mukemmelSayiSonuclbl.Text = "Mükemmel sayıdır";
                }
                else
                    mukemmelSayiSonuclbl.Text = "Mükemmel sayı değildir";

            }
            #endregion

            #region Metot
            else if (metotRadioButton.Checked == true)
            {
                normalRadioButton.Checked = false;

                mukemmelSayi(sayi);

            }

            #endregion

            #region OOP

            else
                return;

            #endregion


        }

        private void mukemmelSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region İkilik Sisteme Çevirme

        String sonuc = "";

        public void ikilikTabanaCevirme(int sayi)
        {
            while (sayi > 0)
            {
                sonuc = sayi % 2 + sonuc;
                sayi /= 2;
            }
            ikilikSistemSonuclbl.Text = sonuc;
        }
        private void ikilikSitemHesaplabtn_Click(object sender, EventArgs e)
        {

            int sayi = Int32.Parse(ikilikSistemSayitxt.Text);
            #region Normal

            if (normalRadioButton.Checked == true)
            {


                while (sayi > 0)
                {
                    sonuc = sayi % 2 + sonuc;
                    sayi /= 2;
                }
                ikilikSistemSonuclbl.Text = sonuc;
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {

                ikilikTabanaCevirme(sayi);

            }

            #endregion

          

            else
                ikilikSistemSonuclbl.Text = "Seçim yapınız";



        }
        private void ikilikSistemSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        #endregion

        #region Kdv Hesaplama

        float kdv = 0f, gida = 0.18f, hizmet = 0.08f, beyaz = 0.01f;
        float kdvHesapla(float fiyat, string cins)
        {
            switch (cins)
            {
                case "Gıda":
                    kdv = ((fiyat * (1 + gida)) - fiyat);
                    break;
                case "Hizmet":
                    kdv = ((fiyat * (1 + hizmet)) - fiyat);
                    break;
                case "Beyaz Eşya":
                    kdv = ((fiyat * (1 + beyaz)) - fiyat);
                    break;
                default:
                    break;
            }
            return kdv;
        }
        private void kdvHesaplabtn_Click_1(object sender, EventArgs e)
        {
            String cins = kdvHesapCinscmbx.Text;
            float fiyat = float.Parse(kdvHesapFiyattxt.Text);

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                switch (cins)
                {
                    case "Gıda":
                        kdv = ((fiyat * (1 + gida)) - fiyat);
                        break;
                    case "Hizmet":
                        kdv = ((fiyat * (1 + hizmet)) - fiyat);
                        break;
                    case "Beyaz Eşya":
                        kdv = ((fiyat * (1 + beyaz)) - fiyat);
                        break;
                    default:
                        break;
                }
                kdvHesapSonuclbl.Text = kdv.ToString() + " TL";

            }
            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                kdvHesapSonuclbl.Text = kdvHesapla(fiyat, cins).ToString() + " TL";
            }
            #endregion

            else kdvHesapSonuclbl.Text = "Seçim yapınız";
        }


        private void kdvHesapFiyattxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kdvHesapIsimtxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        #endregion

        #region Metin Sesli Harf Bulma ve Tersten Yazdırma

        int sesliHarfSay(string metin, string[] sesli)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                string c = metin.Substring(i, 1);
                foreach (string s in sesli)
                    if (c == s)
                        sayac++;
            }
            return sayac;
        }

        private void sesliharfbtn_Click(object sender, EventArgs e)
        {
            String metin = metinSesliHarfmetintxt.Text;
            string[] sesli = {"a", "e", "ı", "i", "o", "ö","u", "ü"};
            int sayac = 0;

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                for (int i = 0; i < metin.Length; i++)
                {
                    String c = metin.Substring(i, 1);
                    foreach (string s in sesli)
                        if (c == s)
                            sayac++;
                }
                metinSesliHarfSesliharflbl.Text = sayac.ToString();
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                metinSesliHarfSesliharflbl.Text = sesliHarfSay(metin, sesli).ToString();
            }

            #endregion

           
            else
                metinSesliHarfSesliharflbl.Text = "Seçim yapınız";
        }


        private void metinSesliHarfmetintxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        String ters = "";
        public void metinTerstenYazma(string metin)
        {
            int i = metin.Length;
            while (i > 0)
            {
                ters += metin.Substring(i - 1, 1);
                i--;
            }
            metinSesliHarfTerstenlbl.Text = ters.ToString();
        }

        private void metinSesliHarfTerstenbtn_Click(object sender, EventArgs e)
        {
            String metin = metinSesliHarfmetintxt.Text;
            int i = metin.Length;

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                while (i > 0)
                {
                    ters += metin.Substring(i - 1, 1);
                    i--;
                }
                metinSesliHarfTerstenlbl.Text = ters.ToString();
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                metinTerstenYazma(metin);
            }

            #endregion

          
            else
                metinSesliHarfSesliharflbl.Text = "Seçim yapınız";

        }


        #endregion

        #region Bölünebilme Kontrolü

        int three = 0, five = 0, seven = 0;

        public int bolunmeKontrol(int bas, int son, string secim)
        {        
            for (int i = bas; i < son; i++)
            {
                if (i % 3 == 0)
                {
                    three++;
                }
                if (i % 5 == 0)
                {
                    five++;
                }
                if (i % 7 == 0)
                {
                    seven++;
                }               
            }
            if (secim == "three")
                return three;
            else if (secim == "five")
                return five;
            else if (secim == "seven")
                return seven;    
            else 
                return 0;
        }



        private void bolunebilmeKontroluHesaplabtn_Click_1(object sender, EventArgs e)
        {
            int baslangic = Int32.Parse(bolunebilmeKontroluBasSayitxt.Text);
            int bitis = Int32.Parse(bolunebilmeKontroluBitSayitxt.Text);

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                metotRadioButton.Checked = false;
          

                for (int i = baslangic; i < bitis; i++)
                {
                    if (i % 3 == 0)
                    {
                        three++;
                    }
                    if (i % 5 == 0)
                    {
                        five++;
                    }
                    if (i % 7 == 0)
                    {
                        seven++;
                    }
                }

                bolunebilmeKontroluThreelbl.Text = three.ToString();
                bolunebilmeKontroluFivelbl.Text = five.ToString();
                bolunebilmeKontroluSevenlbl.Text = seven.ToString();

             
            }
            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                normalRadioButton.Checked = false;


                bolunebilmeKontroluThreelbl.Text = bolunmeKontrol(baslangic, bitis, "three").ToString();
                bolunebilmeKontroluFivelbl.Text = bolunmeKontrol(baslangic, bitis, "five").ToString();
                bolunebilmeKontroluSevenlbl.Text = bolunmeKontrol(baslangic, bitis, "seven").ToString();
               
            }
            #endregion


            else
                return;



        }

        private void bolunebilmeKontroluBasSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bolunebilmeKontroluBitSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region girilenSayıAdedineGöreHesaplama

        int girilenSayıAdedineGöreHesapAdet = 0, girilenSayıAdedineGöreHesaplamaPozitif = 0, girilenSayıAdedineGöreHesaplamaSayi = 0, girilenSayıAdedineGöreHesaplamaSayac = 1;

        

        private void girilenSayıAdedineGöreHesapAdetbtn_Click(object sender, EventArgs e)
        {
            girilenSayıAdedineGöreHesapAdet = Int32.Parse(girilenSayıAdedineGöreHesapAdettxt.Text);
        }

        public int sayıGiris(int adet)
        {
            if (girilenSayıAdedineGöreHesaplamaSayac <= girilenSayıAdedineGöreHesapAdet)
            {
                girilenSayıAdedineGöreHesaplamaSayi = Int32.Parse(girilenSayıAdedineGöreHesapSayitxt.Text);
                if (girilenSayıAdedineGöreHesaplamaSayi > 0)
                {
                    girilenSayıAdedineGöreHesaplamaPozitif += girilenSayıAdedineGöreHesaplamaSayi;
                }
                girilenSayıAdedineGöreHesaplamaSayac++;
                if (girilenSayıAdedineGöreHesaplamaSayac < girilenSayıAdedineGöreHesapAdet + 1)
                {
                    sayaclbl.Text = girilenSayıAdedineGöreHesaplamaSayac.ToString();
                    girilenSayıAdedineGöreHesapSayitxt.Text = "";
                }
            }
            girilenSayıAdedineGöreHesapSayitxt.Select();
            return girilenSayıAdedineGöreHesaplamaPozitif;
        }

        private void girilenSayıAdedineGöreHesapGirisbtn_Click(object sender, EventArgs e)
        {
            #region Normal

            if (normalRadioButton.Checked == true)
            {
                if (girilenSayıAdedineGöreHesaplamaSayac <= girilenSayıAdedineGöreHesapAdet)
                {
                    girilenSayıAdedineGöreHesaplamaSayi = Int32.Parse(girilenSayıAdedineGöreHesapSayitxt.Text);
                    if (girilenSayıAdedineGöreHesaplamaSayi > 0)
                    {
                        girilenSayıAdedineGöreHesaplamaPozitif += girilenSayıAdedineGöreHesaplamaSayi;
                    }
                    girilenSayıAdedineGöreHesaplamaSayac++;
                    if (girilenSayıAdedineGöreHesaplamaSayac < girilenSayıAdedineGöreHesapAdet + 1)
                    {
                        sayaclbl.Text = girilenSayıAdedineGöreHesaplamaSayac.ToString();
                        girilenSayıAdedineGöreHesapSayitxt.Text = "";
                    }
                }
                girilenSayıAdedineGöreHesapSayitxt.Select();

            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                sayıGiris(girilenSayıAdedineGöreHesapAdet);
            }

            #endregion

            else
                girilenSayıAdedineGöreHesapPozitiflbl.Text = "Seçim yapınız";


        }

        private void girilenSayıAdedineGöreHesaplabtn_Click(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked == true) 
                girilenSayıAdedineGöreHesapPozitiflbl.Text = girilenSayıAdedineGöreHesaplamaPozitif.ToString();
            else if (metotRadioButton.Checked == true)
                girilenSayıAdedineGöreHesapPozitiflbl.Text = sayıGiris(girilenSayıAdedineGöreHesapAdet).ToString();

        }
        private void girilenSayıAdedineGöreHesapAdettxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void girilenSayıAdedineGöreHesapSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }



        #endregion

        #region girilenSayılarınOrtalaması

        int girilenSayılarınOrtalamasıSayi = 0, girilenSayılarınOrtalamasıSayac = 0;
        int girilenSayılarınOrtalamasıToplam = 0, girilenSayılarınOrtalamasıEnbuyuk, girilenSayılarınOrtalamasıEnkucuk;
        float girilenSayılarınOrtalamasıOrt1 = 0f, girilenSayılarınOrtalamasıOrt2 = 0f;

        private void girilernSayılarınOrtalamasıgirisbtn_Click(object sender, EventArgs e)
        {
            girilenSayılarınOrtalamasıSayi = Int32.Parse(girilenSayılarınOrtalamasıSayitxt.Text);

            if (girilenSayılarınOrtalamasıSayac == 0)
            { 
                girilenSayılarınOrtalamasıEnkucuk = girilenSayılarınOrtalamasıSayi;
                girilenSayılarınOrtalamasıEnbuyuk = girilenSayılarınOrtalamasıSayi;
                girilenSayılarınOrtalamasıSayac++;
            }
            if (girilenSayılarınOrtalamasıSayac > 0 && girilenSayılarınOrtalamasıSayac <= 10)
            {
                if (girilenSayılarınOrtalamasıEnkucuk > girilenSayılarınOrtalamasıSayi)
                {
                    girilenSayılarınOrtalamasıEnkucuk = girilenSayılarınOrtalamasıSayi;
                }

                if (girilenSayılarınOrtalamasıEnbuyuk < girilenSayılarınOrtalamasıSayi)
                {
                    girilenSayılarınOrtalamasıEnbuyuk = girilenSayılarınOrtalamasıSayi;
                }

                girilenSayılarınOrtalamasıToplam += girilenSayılarınOrtalamasıSayi;

                girilenSayılarınOrtalamasıSayac++;
                if (girilenSayılarınOrtalamasıSayac < 11)
                {
                    girislbl.Text = girilenSayılarınOrtalamasıSayac.ToString() + ". Sayıyı giriniz: ";
                    girilenSayılarınOrtalamasıSayitxt.Text = "";
                    
                }
            }
            girilenSayılarınOrtalamasıSayitxt.Select();
        }

        public void ortalamaHesaplama()
        {
            girilenSayılarınOrtalamasıOrt1 = (girilenSayılarınOrtalamasıEnkucuk + girilenSayılarınOrtalamasıEnbuyuk) / 2;
            girilenSayılarınOrtalamasıOrt2 = girilenSayılarınOrtalamasıToplam / 10;
            buyuklbl.Text = girilenSayılarınOrtalamasıEnbuyuk.ToString();
            kucuklbl.Text = girilenSayılarınOrtalamasıEnkucuk.ToString();

            ortalamalbl.Text = girilenSayılarınOrtalamasıOrt2.ToString();
            bkortlbl.Text = girilenSayılarınOrtalamasıOrt1.ToString();
            farklbl.Text = (girilenSayılarınOrtalamasıOrt1 - girilenSayılarınOrtalamasıOrt2).ToString();
        }

        private void girilenSayılarınOrtalamasıHesaplbtn_Click(object sender, EventArgs e)
        {

            #region Normal

            if (normalRadioButton.Checked == true)
            {
                girilenSayılarınOrtalamasıOrt1 = (girilenSayılarınOrtalamasıEnkucuk + girilenSayılarınOrtalamasıEnbuyuk) / 2;
                girilenSayılarınOrtalamasıOrt2 = girilenSayılarınOrtalamasıToplam / 10;
                buyuklbl.Text = girilenSayılarınOrtalamasıEnbuyuk.ToString();
                kucuklbl.Text = girilenSayılarınOrtalamasıEnkucuk.ToString();

                ortalamalbl.Text = girilenSayılarınOrtalamasıOrt2.ToString();
                bkortlbl.Text = girilenSayılarınOrtalamasıOrt1.ToString();
                farklbl.Text = (girilenSayılarınOrtalamasıOrt1 - girilenSayılarınOrtalamasıOrt2).ToString();
            }

            #endregion

            #region Metot

            else if (metotRadioButton.Checked == true)
            {
                ortalamaHesaplama();
            }

            #endregion
    

            else
                ortalamalbl.Text = "Seçim yapınız";



        }


        private void girilenSayılarınOrtalamasıSayitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        #endregion.

        #region Ekstra

        private void dortgenIslemgbx_Enter(object sender, EventArgs e)
        {

        }
        private void metinIslemgbx_Enter(object sender, EventArgs e)
        {

        }

        private void girilenSayıAdedineGöreHesap(object sender, EventArgs e)
        {

        }

        private void negCiftSekizeEsitgbx_Enter(object sender, EventArgs e)
        {

        }
        private void kdvHesapSonuclbl_Click(object sender, EventArgs e)
        {

        }


        private void kdvHesapFiyattxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kdvHesapIsimtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void kdvHesaplabtn_Click(object sender, EventArgs e)
        {



        }


        private void bolunebilmeKontroluHesaplabtn_Click(object sender, EventArgs e)
        {

        }
        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metotRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
