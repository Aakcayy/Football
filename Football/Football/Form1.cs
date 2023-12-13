using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Football1;

namespace Football
{
    public partial class Form1 : Form
    {
        yetenek football1;
        Kaleci kaleci;
        public Form1()
        {
            InitializeComponent();
            football1 = new yetenek();
            kaleci= new Kaleci();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void btnKaleci_Click(object sender, EventArgs e)
        {
            /* Console.WriteLine("1-Özellik\n2-Bilgiler");
             secim = Convert.ToInt16(Console.ReadLine());
             if (secim==1)
             {
                 football1.Kapma("");
             }
             else if (secim==2) 
             {
                 kaleci.oyuncu("Fabri", "Fabri Agusto Ramirez", "Kaleci", "İspanya", 100);
             }*/

            kaleci.oyuncu("Fabri", "Fabri Agusto Ramirez", "Kaleci", "İspanya", 100);



        }

    }
}
