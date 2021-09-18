using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzSample
{
    class NumberGeneratorJob:IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"Your # is: {RandomNumber(1000, 9999)}");
            await Task.CompletedTask;
        }

        private int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }
    }
}
