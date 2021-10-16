using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test211016_Polyforism.Class.Print
{
    class Print_TypeB : IPrint
    {
        public string Print()
        {
            return "Type B" + Environment.NewLine;
        }
    }
}
