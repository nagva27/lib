using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class divide : IPlugin
    {
        Func<int, int, double> F = (int input1, int input2) => { 
            if (input2 == 0) { return double.NaN; }
            return input1 / input2; 
        };
        public string PluginName => "Division";
        public string Version => constants.libVersion;
        public System.Drawing.Image Image => null;
        public string Description => "Calculates the function A/B. Invoke Run(A,B)\nReturn value=[double, NaN]\nImage is always null";
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
