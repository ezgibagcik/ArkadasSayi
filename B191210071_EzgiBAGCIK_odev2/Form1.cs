/**********************************************************************************************************************************************************
**                                       SAKARYA UNIVERSITESI BILGİISAYAR VE BILIŞIM BILIMLERI FAKULTESI
**				                                           BILGISAYAR MUHENDISLIĞI BOLUMU
**				                                           NESNEYE DAYALI PROGRAMLAMA DERSI
**					                                           2019-2020 BAHAR DÖNEMİ
* 
**                                                ÖDEV NUMARASI............: 2.ODEV
**                                                ÖĞRENCİ ADI..............: EZGI BAĞCIK
**                                                ÖĞRENCİ NUMARASI.........: B191210071
**                                                DERS GRUBU...............: 1. OĞRETIM C GRUBU
***********************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_odev2
{
    public partial class Form1 : Form
    {
        //Veriler girildikten sonra arkadas mi butonuna basildiginda cıkacak aracları olusturur
        ListBox lstBox = new ListBox();
        ListBox lstBox2 = new ListBox();
        Label lblX2 = new Label();
        Label lblY2 = new Label();
        Label lblToplamlar = new Label();
        TextBox txtToplamXinAlti = new TextBox();
        TextBox txtToplamYinAlti = new TextBox();
        
        private bool state = false; //Textboxların dolulugunu kontrol etmek icin tanimlanmistir.
        private int sayi1;
        private int sayi2;
        private int toplamX = 0;
        private int toplamY = 0;

        ErrorProvider provider = new ErrorProvider(); //Bos gecildiginde uyari vermeyi saglamak icin olusturulan nesne.
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnArkadas_Click(object sender, EventArgs e)
        {
            this.AutoSize = true; //form ekraninin boyutlarini otomatik ayarlanir.
            ArkadasMı(); //sayilari carpanlarina ayirip carpanlarini toplayan fonksiyon cagirilir
            if (state == false) //ArkadasMı() fonksiyonu calistiktan sonra arkadas olup olmadigini kontrol etmek icin kullanilan kosuldur.
            {
                if (txtToplamXinAlti.Text == txtY.Text && txtToplamYinAlti.Text == txtX.Text)  //arkadassalar ekranı olusturmasını saglayan kosuldur
                {
                    EkranOlustur(); //arkadas mi butonuna bastiktan sonraki ekrani olusturacak fonksiyon cagirilir.
                }
                else //arkadas degilseler ekrana arkadas degiller uyarisini cikartan kosuldur.
                {
                    MessageBox.Show(txtX.Text+" ve "+txtY.Text+" arkadaş sayı değiller.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSon_Click(null,null); //arkadas degilseler uyarı ekranı cikarildiktan sonra "btnson_click" olayında olacaklar yapilir.
                }
            }
          
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            Temizle(); //son butonuna basildiginda ekrani eski haline getirecek fonksiyon yazilir.
            btnArkadas.Enabled = true; //butona tekrar tiklanmasi engellenir.
            this.AutoSize = false; //form ekrani eski haline dondurulur.
        }

        private void EkranOlustur() //arkadas mi butonuna bastiktan sonraki ekrani olusturacak fonksiyondur.
        {
            //Olusturulacak araclarin konumunu yüksekligini genisligi atanir ve formun üzerine olusturulur.

            lstBox.Location = new Point(330, 50);
            lstBox.Width = 78;
            lstBox.Height = 170;
            this.Controls.Add(lstBox);


            lstBox2.Location = new Point(420, 50);
            lstBox2.Width = 78;
            lstBox2.Height = 170;
            this.Controls.Add(lstBox2);


            lblX2.Location = new Point(358, 33);
            lblX2.Width = 35;
            lblX2.Height = 13;
            lblX2.Text = "X";
            this.Controls.Add(lblX2);


            lblY2.Location = new Point(455, 33);
            lblY2.Width = 35;
            lblY2.Height = 13;
            lblY2.Text = "Y";
            this.Controls.Add(lblY2);


            lblToplamlar.Location = new Point(250, 223);
            lblToplamlar.Width = 78;
            lblToplamlar.Height = 16;
            lblToplamlar.Text = "TOPLAMLAR";
            this.Controls.Add(lblToplamlar);


            txtToplamXinAlti.Location = new Point(330, 220);
            txtToplamXinAlti.Width = 78;
            txtToplamXinAlti.Height = 16;
            this.Controls.Add(txtToplamXinAlti);

            txtToplamYinAlti.Location = new Point(420, 220);
            txtToplamYinAlti.Width = 78;
            txtToplamYinAlti.Height = 16;
            this.Controls.Add(txtToplamYinAlti);
        }

        private void ArkadasMı() //sayilari carpanlarina ayirip carpanlarini toplayan fonksiyondur.
        {
            provider.Clear(); //Ekran daha onceden uyari iconu var ise silinmesi saglandi.
            provider.BlinkRate = 0; //Uyarı iconunun hızını ayarlamak icin yazildi.

            if (txtX.Text == "" || txtY.Text == "") //textboxların herhangi birisine sayı girilip girilmedigini kontrol eden kosuldur.
            {
                if (txtX.Text == "" && txtY.Text == "") //testboxların ikisine de sayi girilmemisse bu kosula girer ve uyarı verir.
                {
                    MessageBox.Show("X ve Y alanı boş geçilemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    provider.SetError(txtX, "Bu alan boş geçilemez"); //uyarı iconlarini cagiririz.
                    provider.SetError(txtY, "Bu alan boş geçilemez"); //uyarı iconlarini cagiririz.
                }
                else if (txtX.Text == "") //textboxlardan x sayisi bossa bu kosula girer ve uyarı verir.
                {
                    MessageBox.Show("X alanı boş geçilemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    provider.SetError(txtX, "Bu alan boş geçilemez"); //uyarı iconlarini cagiririz.
                }
                else //textboxlardan y sayisi bossa bu kosula girer ve uyarı verir.
                {
                    MessageBox.Show("Y alanı boş geçilemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    provider.SetError(txtY, "Bu alan boş geçilemez"); //uyarı iconlarini cagiririz.
                }
                state = true;
            }
            else //sayi girilmisse buraya gelir.
            {
                sayi1 = int.Parse(txtX.Text);
                
                for (int i = 1; i < sayi1; i++) //x sayisini carpanlarina ayirmak icin kullanilan dongudur.
                {
                    if (sayi1 % i == 0) //x sayisini tam bolup bolmedigini sinayan kosuldur
                    {
                        lstBox.Items.Add(i); //tam bolerse listboxa ekler
                        toplamX += i; //tam bolen sayilarin tolamini bulur.
                    }
                }
                txtToplamXinAlti.Text = toplamX.ToString(); //tam bolen sayilarin toplamini textboxa yazdirir.

                sayi2 = int.Parse(txtY.Text);

                for (int i = 1; i < sayi2; i++)  //y sayisini carpanlarina ayirmak icin kullanilan dongudur.
                {
                    if (sayi2 % i == 0)  //y sayisini tam bolup bolmedigini sinayan kosuldur
                    {
                        lstBox2.Items.Add(i);//tam bolerse listboxa ekler
                        toplamY += i; //tam bolen sayilarin tolamini bulur.
                    }
                }
                txtToplamYinAlti.Text = toplamY.ToString(); //tam bolen sayilarin toplamini textboxa yazdirir.

                state = false; //arkadas mı olup olmadigini btnArkadas_click de kontrol etmek icin deger veriyoruz.
                btnArkadas.Enabled = false; // hesaplandiktan sonra tekrar arkadas mi butonuna basilmasini engelledik
            }
        }

        private void Temizle()
        {
            //EkranıYazdir fonksiyonu ile olusturulan araclari temizler.
            this.Controls.Remove(lstBox);
            this.Controls.Remove(lstBox2);
            this.Controls.Remove(lblX2);
            this.Controls.Remove(lblY2);
            this.Controls.Remove(lblToplamlar);
            this.Controls.Remove(txtToplamXinAlti);
            this.Controls.Remove(txtToplamYinAlti);

            foreach (Control item in this.Controls)  //textboxlarin icini temizleyen dongudur.
            {
                if (item is TextBox) // itemin textbox oldugunu sorgulayan kosuldur.
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            //listboxlarin ici temizlenir.İlk degerler sifirlanir.
            lstBox.Items.Clear();
            lstBox2.Items.Clear();
            txtToplamXinAlti.Clear();
            txtToplamYinAlti.Clear();
            toplamX = 0; 
            toplamY = 0;
            provider.Clear();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e) //X Textbox'ına sadece sayı girisi kontrolu yapildi.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e) //Y Textbox'ına sadece sayı girisi kontrolu yapildi.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtX_Validated(object sender, EventArgs e) //X textbox'i bos gecildiginde uyari verilmesi saglar.
        {
            provider.BlinkRate = 0;
            if (txtX.Text.Trim() == "") // txtX boş olup olmadigini kontrol ettiren kosuldur.
                provider.SetError(txtX, "X değerini girmelisiniz"); // ErrorProvider açılacak ve mesaj cikaracak
            else
                provider.SetError(txtX, "");  // ErrorProvider kapanacak

        }

        private void txtY_Validated(object sender, EventArgs e) //Y textbox'i bos gecildiginde uyari verilmesi saglar.
        {
            provider.BlinkRate = 0;
            if (txtY.Text.Trim() == "") // txtY boş olup olmadigini kontrol ettiren kosuldur.
                provider.SetError(txtY, "Y değerini girmelisiniz"); // ErrorProvider açılacak ve mesaj cikaracak.
            else
                provider.SetError(txtY, ""); // ErrorProvider kapanacak.
        }
    }
}
