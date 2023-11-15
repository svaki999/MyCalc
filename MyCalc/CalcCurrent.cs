namespace MyCalc
{
    public class CalcCurrent
    {
        // I = √(P / R)
        public double GetCurrentByPowerAndResistance(double power, double resistance)
        {
            return Math.Sqrt(power / resistance);
        }

        // I = P / V
        public double GetVoltageByPowerAndVoltage(double power, double voltage)
        {
            return power / voltage;
        }

        // I = V / R
        public double GetCurrentByVoltageAndResistance(double voltage, double resistance)
        {
            return voltage / resistance;
        }
    }
}
