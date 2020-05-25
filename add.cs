using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class add:IPlugin
    {
        Func<int, int, double> F = (int input1, int input2) => { return input1 + input2; };
        public string PluginName => "Add";
        public string Version => constants.libVersion;
        public System.Drawing.Image Image => null;
        public string Description => "Calculates the function A+B. Invoke Run(A,B)\nReturn value=[int]\nImage is always null";
                                     
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
