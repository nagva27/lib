using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    abstract class Plot
    {
        public System.Drawing.Image draw(Func<int, int, double> F,int param) {      /*not so good plotting code*/
            int width = 500;  //canvas size
            int height = 500;

            int d2 = 10;
            int max = (int)F(d2, param);
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(width,height);
            using (System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bm))
            {
                for(int i=1;i<d2;i++)
                {
                    int x = (int)((width-1) * i / d2);
                    int y = (int)((height-1) * (F(i, param)) / max);
                    y = height - 1 - y;
                                       
                    bm.SetPixel(x, y, System.Drawing.Color.Black);
                    bm.SetPixel(x, y+1, System.Drawing.Color.Black);
                    bm.SetPixel(x+1, y, System.Drawing.Color.Black);
                    bm.SetPixel(x+1, y, System.Drawing.Color.Black);
                }

                
            }
            return bm;
           // bm.Dispose();

        }




    }
}
