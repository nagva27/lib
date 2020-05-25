using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class exp : Plot, IPlugin
    {
        Func<int, int, double> F = (int input1, int input2) => { return Math.Pow(input1, input2); };
        public string PluginName => "Pow";
        public string Version => constants.libVersion;
        public System.Drawing.Image Image => base.draw(F,2);
        public string Description => "Calculates the function A^X. Invoke Run(X,A)\nReturn value=[double, NaN, NegativeInfinity, PositiveInfinity]\nImage = the plot 2^x on [0,100] ";
        public int Run(int input1, int input2)
        {
            return Convert.ToInt32(F(input2, input1));
        }

        public override string ToString()
        {
            return PluginName;
        }
        
    }
}
