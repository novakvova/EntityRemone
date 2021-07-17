using System;
using System.Threading;

namespace CoffeeLib
{
    public delegate void CompletedCoffee(string message);
    public delegate void CoffeeProgresDelegate(int second);
    public class CoffeeService
    {
        public CompletedCoffee completedCoffee;
        public event CoffeeProgresDelegate progressCoffee;
        
        public void RunExpresso()
        {
            Thread thread = new Thread(threadRunMethod);
            thread.Start();
        }
        private void threadRunMethod()
        {
            Random rand = new Random();
            int sleep = rand.Next(1, 5);
            for (int i = 0; i < sleep; i++)
            {
                Thread.Sleep(1000);
                if(progressCoffee!=null)
                {
                    progressCoffee(i + 1);
                }
            }
            if (completedCoffee != null)
            {
                completedCoffee("Ваше експерсо готове!");
            }
        }
    }
}
