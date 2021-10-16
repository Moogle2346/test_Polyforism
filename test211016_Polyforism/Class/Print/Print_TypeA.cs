using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test211016_Polyforism.Class.Print
{
    class Print_TypeA : IPrint
    {
        public string Print()
        {
            return "Type A";
        }
    }
}
