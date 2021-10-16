using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test211016_Polyforism.Class.Print;

namespace test211016_Polyforism.Class
{
    class TextControl
    {
        private IPrint print;

        public TextControl(IPrint print)
        {
            this.print = print;
        }

        public string GetText()
        {
            return print.Print();
        }
    }
}
