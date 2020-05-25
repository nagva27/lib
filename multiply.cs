using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class multiply:IPlugin
    {
        Func<int, int, double> F = (int input1, int input2) => { return input1*input2; };
        public string PluginName => "Multiply";
        public string Version => constants.libVersion;
        public System.Drawing.Image Image => null; //base.draw(F);
        public string Description => "Calculates the function A*B. Invoke Run(A,B)\nReturn value=[int]\nImage=plot on [0,1]";
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
