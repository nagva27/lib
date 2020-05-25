using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class sin : Plot, IPlugin
    {
        Func<int, int, double> F = (int input1, int input2) => { return Math.Sin(input1); };
        public string PluginName => "Sin";
        public string Version => constants.libVersion;
        public System.Drawing.Image Image => base.draw(F,0);
        public string Description => "Calculates the function sin(x). Invoke Run(x,0)\nSecond parameter always ignorе\nReturn value=[double]\nImage = the plot on [0,pi]";
        public int Run(int input1, int input2)
        {
            return Convert.ToInt32(F(input1, input2));
        }

        public override string ToString()
        {
            return PluginName;
        }

    }
}
