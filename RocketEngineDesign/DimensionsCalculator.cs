using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketEngineDesign
{
    class DimensionsCalculator
    {
        internal double CalculateExhaustVelocity(InputDataSet inputDataSet)
        {
            return inputDataSet.SpecificImpulseOfEngine * 9.81;
        }
        internal double CalculateMassFlowRate(InputDataSet inputDataSet)
        {
            return inputDataSet.ThrustOfEngine / CalculateExhaustVelocity(inputDataSet);
        }
        internal double CalculateCrossSectionalAreaOfNozzleExit(InputDataSet inputDataSet)
        {
            var expFactor = inputDataSet.IsentropicExpansionFactorOfFuel;
            var molecMass = inputDataSet.MolecularMassOfFuel;
            var combTemp = inputDataSet.CombustionChamberTemperature;
            var combPress = inputDataSet.PressureInCombustionChamber;
            var exitPress = inputDataSet.PressureAtNozzelExit;
            var idealGasConst = 8.3144598;

            var nonSqrtComponent = CalculateMassFlowRate(inputDataSet) / inputDataSet.PressureInCombustionChamber;
            var linearDenomTerm = 2 * expFactor / (expFactor - 1) * molecMass / (idealGasConst * combTemp);
            var nonLinearDenomTerm1 = Math.Pow(exitPress/combPress, 2/expFactor);
            var nonLinearDenomTerm2 = 1 - Math.Pow(exitPress / combPress, (expFactor - 1) / expFactor);
            var sqrtComponent = Math.Pow(linearDenomTerm * nonLinearDenomTerm1 * nonLinearDenomTerm2, .5);
            var finalTerm = nonSqrtComponent * Math.Pow(sqrtComponent, -1);
            return finalTerm;
        }
        internal double CalculateCrossSectionalAreaOfThroat(InputDataSet inputDataSet)
        {
            return CalculateCrossSectionalAreaOfNozzleExit(inputDataSet) / inputDataSet.AreaAtNozzleExitToAreaAtThroatRatio;
        }
        internal double CalculateRadiusOfNozzleExit(InputDataSet inputDataSet)
        {
            return Math.Sqrt(CalculateCrossSectionalAreaOfNozzleExit(inputDataSet) / Math.PI);
        }
        internal double CalculateRadiusOfThroat(InputDataSet inputDataSet)
        {
            return Math.Sqrt(CalculateCrossSectionalAreaOfThroat(inputDataSet) / Math.PI);
        }
    }
}
