using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football1
{
    public interface Irabona
    {
        void rabona(string message);
    }
    public interface Itrivela
    {
        void trivela(string message);
    }
    public interface ISut
    {
        void Sut(string message);
    }
    public interface ITopTutma
    {
        void tutma(string message);
    }
    public interface ITopKapma
    {
        void Kapma(string message);
    }
    public class yetenek : Irabona,Itrivela,ITopTutma,ITopKapma,ISut
    {
        public void rabona(string message)
        {
            MessageBox.Show("Rabona, tekme atan bacağın ayakta duran bacağın arkasından çaprazlandığı futbola tekme atma tekniğidir.");
        }
        public void trivela(string message)
        {
            MessageBox.Show("Trivela, ayağın dışıyla yapılan bir futbol hareketi.");
        }
        public void tutma(string message)
        {
            MessageBox.Show("Top tutma,bir oyuncu tarafından topun çift elle alınarak kontrol altında tutulmasıdır.");
        }
        public void Sut(string message)
        {
            MessageBox.Show("Şut, futbolda topun kale çizgisini geçip kaleye girerek gol olmasını sağlamak için kullanılan topa vurma tekniği.");
        }
        public void Kapma(string message)
        {
            MessageBox.Show("Top kapma,top yerdeyken bir oyuncunun topu rakibinden almaya çalışması ve başarmasıdır.");
        }
        
    }
    abstract class Futbolcu:yetenek
    {
        public string isim, tamadi, mevki,uyruk;
        public double piyasadegeri;
       
        public  void oyuncu(string isim, string tamadi, string mevki, string uyruk, double piyasadegeri)
        {
            this.isim = isim;
            this.tamadi = tamadi;
            this.mevki = mevki;
            this.uyruk = uyruk;
            this.piyasadegeri = piyasadegeri;
           

            DialogResult result = MessageBox.Show("Kaleci özeliğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.oyuncu("Fabri", "Fabri Agusto Ramirez", "Kaleci", "İspanya", 100.000);
                string bilgi = $"Oyuncu Bilgileri:\n\nİsim: {isim}\nTam adı: {tamadi}\nMevki: {mevki}\nUyruk: {uyruk}\nPiyasa Değeri: {piyasadegeri}.000 €";
                MessageBox.Show(bilgi);
            }
            else
            {
                // Kullanıcı "Hayır" seçeneğini seçerse, isteğinize göre başka bir işlem yapabilirsiniz.
                Kapma("");
            }


         
           
        }
        
    }

    internal class Kaleci : Futbolcu //kaleci aynı zamanda bir futbolcudur
    {
       
        public Kaleci()
        {

          

        }
    }

}
