
namespace CICD_Core
{
    public class Calculator
    {
        public static double Divide(int v1, int v2)
        {
            int a = 3;
            if (v2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)v1/v2;
        }
    }
}
