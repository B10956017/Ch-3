using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_3
{
    class car
    {
        string color = "blue";
        int cc = 3000;
        string brand = "BMW";

    public void showinfo()
        {
            Console.WriteLine("顏色:" + color);
            Console.WriteLine("cc數:" + cc);
            Console.WriteLine("品牌:" + brand);
        }
    public void changecolor()
        {
            this.color = "black";
        }
    }
}
