namespace MyCalc
{
    public class CalcVoltage
    {
        // V = R * I
        public double GetVoltageByResistanceAndCurrent(double resistance, double current)
        {
            return resistance * current;
        }

        // V = P / I
        public double GetVoltageByPowerAndCurrent(double power, double current)
        {
            return power / current;
        }

        // V = √(P * R)
        public double GetVoltageByPowerAndResistance(double power, double resistance)
        {
            return Math.Sqrt(power * resistance);
        }

    }
}
