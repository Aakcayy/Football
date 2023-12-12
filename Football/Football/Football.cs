using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public interface Irabona
    {
        void rabona1(string message);
    }
    public interface Itrivela
    {
        void trivela1(string message);
    }
    public class mesaj : Irabona,Itrivela
    {
        public void rabona1(string message)
        {
            MessageBox.Show("Rabona, tekme atan bacağın ayakta duran bacağın arkasından çaprazlandığı futbola tekme atma tekniğidir.");
        }
        public void trivela1(string message)
        {
            MessageBox.Show("Trivela, ayağın dışıyla yapılan bir futbol hareketi.");
        }
    }
    
}
