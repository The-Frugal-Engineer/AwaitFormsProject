using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitFormsProject
{
    internal class Operations
    {
        public async Task<int> sumWithDelayAsync(int value1, int value2, int delaySeconds, Boolean isAsyncExecution)
        {
            if (isAsyncExecution)
            {
                await Task.Delay(delaySeconds * 1000); //asynchronous wait
                
            }
            else
            {
                Task.Delay(delaySeconds * 1000).Wait(); //blocking wait
            }
         
            
            return value1+ value2;
        }

    }
}
