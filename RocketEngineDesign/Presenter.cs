using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketEngineDesign
{
    class Presenter
    {
        internal void PresentData(Introducer introduction, InputDataRequester request, InputDataSet inputDataSet)
        {
            introduction.Introduce();
            request.Request(inputDataSet);
        }
    }
}
