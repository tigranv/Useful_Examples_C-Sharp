namespace MVPCalculate
{
    class Model
    {
        #region Arithmetic operators
        public string Add(int a, int b)
       {
           return (a+b).ToString();
       }
        public string Sub(int a, int b)
        {
            return (a - b).ToString();
        }
        public string Multi(int a, int b)
        {
            return (a*b).ToString();
        }
        public string Div(int a, int b)
        {
            if (b != 0)
                return ((double) a/b).ToString();
            return "Null division exeption";
        }
        #endregion
    }
}
