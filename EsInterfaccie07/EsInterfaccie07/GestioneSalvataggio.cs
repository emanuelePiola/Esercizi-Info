using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsInterfaccie07
{
    public delegate void salvataggioEseguitoEventHandler(int id);
    internal class GestioneSalvataggio
    {
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");
            salvataggioEseguito(id);    
        }
    }
}
