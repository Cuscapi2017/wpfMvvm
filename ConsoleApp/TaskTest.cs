using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TaskTest
    {
        public void Test()
        {
            TaskScheduler.UnobservedTaskException += this.TaskScheduler_UnobservedTaskException;
            CancellationTokenSource cts = new CancellationTokenSource();
            Task<Int32> t = Task.Run(() => Sum(cts.Token,1000000000), cts.Token);
            cts.Cancel();
            try
            {
                //如果任务已取消，Result 会抛出一个AggregateException
                Console.WriteLine("The sum is: ");
            }
            catch (AggregateException x)
            {
                Console.WriteLine("sum was canceled");
            }
        }

        private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static Int32 Sum(CancellationToken ct, Int32 n)
        {
            Int32 sum1 = 0;
            for (; n > 0; n--)
            {
                ct.ThrowIfCancellationRequested();
                checked { sum1 += n; }
            }
            return sum1;
        }
    }
}
