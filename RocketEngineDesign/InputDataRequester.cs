using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketEngineDesign
{
    class InputDataRequester
    {
        internal void Request(InputDataSet inputDataSet)
        {
            inputDataSet.AreaAtNozzleExitToAreaAtThroatRatio = WhatIsTheValueOf(inputDataSet.AreaAtNozzleExitToAreaAtThroatRatio);
            inputDataSet.CombustionChamberTemperature = WhatIsTheValueOf(inputDataSet.CombustionChamberTemperature);
            inputDataSet.HalfAngleOfNozzleConvergence = WhatIsTheValueOf(inputDataSet.HalfAngleOfNozzleConvergence);
            inputDataSet.HalfAngleOfNozzleDivergence = WhatIsTheValueOf(inputDataSet.HalfAngleOfNozzleDivergence);
            inputDataSet.IsentropicExpansionFactorOfFuel = WhatIsTheValueOf(inputDataSet.IsentropicExpansionFactorOfFuel);
            inputDataSet.MaxWallStressOfCombustionChamber = WhatIsTheValueOf(inputDataSet.MaxWallStressOfCombustionChamber);
            inputDataSet.MolecularMassOfFuel = WhatIsTheValueOf(inputDataSet.MolecularMassOfFuel);
            inputDataSet.PressureAtNozzelExit = WhatIsTheValueOf(inputDataSet.PressureAtNozzelExit);
            inputDataSet.PressureInCombustionChamber = WhatIsTheValueOf(inputDataSet.PressureInCombustionChamber);
            inputDataSet.SpecificImpulseOfEngine = WhatIsTheValueOf(inputDataSet.SpecificImpulseOfEngine);
            inputDataSet.ThrustOfEngine = WhatIsTheValueOf(inputDataSet.ThrustOfEngine);
        }
        internal double WhatIsTheValueOf(Object obj)
        {
            Console.WriteLine("What is this value: {0}?", obj);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
