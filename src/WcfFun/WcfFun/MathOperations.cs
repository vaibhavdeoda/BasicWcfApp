namespace WcfFun
{
    using System.Linq;

    public class MathOperations : IMathOperations
    {
        public int Sum(Operator input)
        {
           return input.Operators.Sum();
        }

        public int Multiply(Operator input)
        {
            int result = 1;
            foreach (var item in input.Operators)
            {
                result = result * item;
            }

            return result;
        }
    }
}
