using System;

namespace Module3HW4
{
    public class Task1
    {
        public Task1()
        {
            SumHandler += Sum;
            SumHandler += Sum;
        }

        public event Func<double, double, double> SumHandler;

        public double Sum(double x, double y) => x + y;

        public double SumOfSum()
        {
            var methodList = SumHandler.GetInvocationList();
            var result = 0d;
            foreach (var item in methodList)
            {
                TryCatchMethod(() =>
                {
                    result += (double)item.DynamicInvoke(5, 10);
                });
            }

            return result;
        }

        public void TryCatchMethod(Action func)
        {
            try
            {
                func.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
