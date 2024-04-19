using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03Interfaccie
{
    internal interface IUtente
    {
        void PrendiInPrestitoItem(ILibreriaItem item);
        void RestituisciItem(ILibreriaItem item);
    }
}
