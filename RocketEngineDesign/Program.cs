using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketEngineDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter presentation = new Presenter();
            Introducer introduction = new Introducer();
            presentation.PresentData(introduction);
        }
        

    }
}
