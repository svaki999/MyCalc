namespace MyCalc
{
    public class CalcPower
    {
        // P = I^2 * R
        public double GetPowerByResistanceAndCurrent(double resistance, double current)
        {
            return Math.Pow(current, 2) * resistance;
        }

        // P = V * I
        public double GetPowerByVoltageAndCurrent(double voltage, double current)
        {
            return voltage * current;
        }

        // P = (V^2) / R
        public double GetPowerByVoltageAndResistance(double voltage, double resistance)
        {
            return Math.Pow(voltage, 2) / resistance;
        }
    }
}
