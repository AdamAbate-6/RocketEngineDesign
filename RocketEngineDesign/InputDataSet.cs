namespace RocketEngineDesign
{
    internal class InputDataSet
    {
        internal double IsentropicExpansionFactorOfFuel { get; set; }
        internal double CombustionChamberTemperature { get; set; }
        internal double MolecularMassOfFuel { get; set; }
        internal double PressureInCombustionChamber { get; set; }
        internal double PressureAtNozzelExit { get; set; }
        internal double AreaAtNozzleExitToAreaAtThroatRatio { get; set; }
        internal double SpecificImpulseOfEngine { get; set; }
        internal double ThrustOfEngine { get; set; }
        internal double HalfAngleOfNozzleDivergence { get; set; }
        internal double HalfAngleOfNozzleConvergence { get; set; }
        internal double MaxWallStressOfCombustionChamber { get; set; }
    }
}