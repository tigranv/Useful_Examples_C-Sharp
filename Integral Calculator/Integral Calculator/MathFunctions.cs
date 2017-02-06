namespace Integral_Calculator
{
    public static class MathFunctions
    {
        // Function for integral calculation , which takes delegate as argument
        public static double Integrate(MyDelegate f, double x1, double x2, Integration_Accuracy a)
        {
            int accuracy = 0;
            switch (a)
            {
                case Integration_Accuracy.Accuracy1:
                    accuracy = 10;
                    break;
                case Integration_Accuracy.Accuracy2:
                    accuracy = 100;
                    break;
                case Integration_Accuracy.Accuracy3:
                    accuracy = 10000;
                    break;
                case Integration_Accuracy.Accuracy4:
                    accuracy = 1000000;
                    break;
            }

            double h = (x2 - x1) / accuracy;
            double res = (f(x1) + f(x2)) / 2;
            for (int i = 1; i < accuracy; i++)
            {
                res += f(x1 + i * h);
            }
            return h * res;
        }
    }

    public enum Integration_Accuracy
    {
        Accuracy1,
        Accuracy2,
        Accuracy3,
        Accuracy4,
    }
}
