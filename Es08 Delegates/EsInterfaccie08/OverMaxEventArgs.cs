using System;

namespace EsInterfaccie08
{
    public class OverMaxEventArgs:EventArgs
    {
        public int ValoreSoglia { get; set; }

        public OverMaxEventArgs(int valoreSoglia)
        {
            ValoreSoglia = valoreSoglia;
        }
    }
}