namespace MyCalc
{
    public class CalcResistance
    {
        // R = V / I
        public double GetResistanceByVoltageAndCurrent(double voltage, double current)
        {
            return voltage / current;
        }

        // R = V^2 / P
        public double GetResistanceByVoltageAndPower(double voltage, double power)
        {
            return Math.Pow(voltage, 2) / power;
        }

        // R = P / I^2
        public double GetResistanceByPowerAndCurrent(double power, double current)
        {
            return power / Math.Pow(current, 2);
        }
    }
}
