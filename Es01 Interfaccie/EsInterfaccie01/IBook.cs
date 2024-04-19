using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsInterfaccie01
{
    internal interface IBook
    {
        string Titolo { get; }
        string Autore { get; }
        double Prezzo { get; }
    }
}
