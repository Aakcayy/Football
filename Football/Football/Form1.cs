using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Football1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Football
{
    public partial class Form1 : Form
    {
        yetenek football1;
        Oyuncu oyuncu;
        public Form1()
        {
            InitializeComponent();
            football1 = new yetenek();
            oyuncu= new Oyuncu();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void btnKaleci_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.tutma("");
            }
            else
            {
                oyuncu.oyuncu("Fabri", "Fabri Agusto Ramirez", "Kaleci", "İspanya/Uruguay","100.000", 1.85);
            }


        }

        private void btnSolBek_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Adriano", "Adriano Correia Claro", "Sol Bek\nYan mevki:Sağ Bek/Orta saha sol", "Brezilya/İspanya","0", 1.80);
            }
        }

        private void btnSagBek_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Beck", "Andreas Beck", "Sağ Bek\nYan mevki:Sol Bek/Orta saha sağ", "Almanya/Rusya","0", 1.80);
            }
        }

        private void btnSolStoper_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Marcelo", "Marcelo Antônio Guedes Filho", "Stoper", "Breziya","800.000", 1.91);
            }
        }

        private void btnSagStoper_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Pepe", "Képler Laveran Lima Ferreira", "Stoper\nYan mevki:Ön Libero", "Portekiz/Brezilya","1.000.000", 1.91);
            }
        }

        private void btnÜÇ_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Atiba", "Atiba Hutchinson", "Ön Libero\nYan mevki:Merkez Orta Saha/Sağ Bek", "Kanada/Trinidad ve Tobago","0", 1.87);
            }
        }

        private void btn8numara_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Oğuzhan", "Oğuzhan Özyakup", "Merkez Orta Saha\nYan mevki:On Numara/Orta Saha Sol", "Türkiye/Hollanda","700.000", 1.80);
            }
        }

        private void btn10numara_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
                oyuncu.Sut("");
            }
            else
            {
                oyuncu.oyuncu("Talisca", "Anderson Souza Conceição", "On Numara\nYan mevki:Santrafor/Sağ Kanat", "Türkiye"," 15.000.000", 1.90);
            }
        }

        private void btnForvet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
                oyuncu.Sut("");
            }
            else
            {
                oyuncu.oyuncu("Gomez", "Mario Gómez García", "Santrafor\nYan mevki:-", "Almanya","0", 1.89);
            }
        }

        private void btnSolKanat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
                oyuncu.Sut("");
            }
            else
            {
                oyuncu.oyuncu("Cenk", "Cenk Tosun", "Santrafor\nYan mevki:Sağ Kanat/Sol Kanat", "Türkiye", "3.000.000", 1.83);
            }
        }

        private void btnSağKanat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.Kapma("");
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.trivela("");
                oyuncu.rabona("");
            }
            else
            {
                oyuncu.oyuncu("Quaresma", "Ricardo Andrade Quaresma Bernardo", "Sağ Kanat\nYan mevki:Forvet Arkası/Sol Kanat", "Portekiz","0", 1.75);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.tutma("");
                oyuncu.pas("");
            }
            else
            {
                oyuncu.oyuncu("Neuer", "Manuel Peter Neuer", "Kaleci", "Almanya","5.000.000", 1.93);
            }
         
        }

        private void btnForvet2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.rabona("");
            }
            else
            {
                oyuncu.oyuncu("Ronaldo", "Cristiano Ronaldo dos Santos Aveiro", "Santrafor\nYan mevki:Sağ Kanat/Sol Kanat", "Portekiz", "15.000.000", 1.87);
            }
        }

        private void btnSagKanat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.rabona("");
            }
            else
            {
                oyuncu.oyuncu("Mbappé", "Kylian Mbappé Lottin", "Sol Kanat\nYan mevki:Sağ Kanat/Santrafor", "Fransa/Kamerun", "180.000.000", 1.78);
            }
        }

        private void btnSolKanat2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.rabona("");
            }
            else
            {
                oyuncu.oyuncu("Neymar", "Neymar da Silva Santos Júnior", "Sol Kanat\nYan mevki:Forvet Arkası/On Numara", "Brezilya", "50.000.000", 1.78);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
            }
            else
            {
                oyuncu.oyuncu("Messi", "Lionel Andrés Messi Cuccitini", "Sağ Kanat\nYan mevki:Santrafor/Forvet Arkası", "Arjantin/İspanya", "35.000.000", 1.70);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.Kapma("");
            }
            else
            {
                oyuncu.oyuncu("De Bruyne", "Kevin De Bruyne", "On Numara\nYan mevki:Merkez Orta Saha", "Belçika", "70.000.000", 1.81);
            }
        }

        private void btn6Numara2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.Kapma("");
            }
            else
            {
                oyuncu.oyuncu("Casemiro", "Carlos Henrique Casimiro", "Ön Libero\nYan mevki:-", "Brezilya/İspanya", "40.000.000", 1.85);
            }
        }

        private void btnSagBek2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Sut("");
                oyuncu.Kapma("");
            }
            else
            {
                oyuncu.oyuncu("Arnold", "Trent Alexander Arnold", "Sağ Bek\nYan mevki:-", "İngiltere", "65.000.000", 1.80);
            }
        }

        private void btnSagStoper2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Kapma("");
            }
            else
            {
                oyuncu.oyuncu("Ramos", "Sergio Ramos García", "Stoper\nYan mevki:Sağ Bek", "İspanya", "4.000.000", 1.84);
            }
        }

        private void btnSolBek2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Kapma("");
            }
            else
            {
                oyuncu.oyuncu("Bonucci", " Leonardo Bonucci", "Stoper\nYan mevki:-", "İtalya", "1.500.000", 1.89);
            }
        }

        private void btnSolBek3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeteneğini görmek istiyor  musunuz?", "Oyuncu Profili", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                oyuncu.pas("");
                oyuncu.Kapma("");
            }
            else
            {
                oyuncu.oyuncu("Davies", "Alphonso Boyle Davies", "Sol Bek\nYan mevki:Sol Kanat/Orta Saha Sol", "Kanada/Liberya", "70.000.000", 1.83);
            }
        }
    }
}
