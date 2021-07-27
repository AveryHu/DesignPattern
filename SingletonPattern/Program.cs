using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Singleton pattern to control that only one instance for the class.

            Console.WriteLine("------ Run Non-Thread-Safe Singleton Class ------");
            RunNonThreadSafeSingleton();

            Console.WriteLine("\n ------ Run Thread-Safe Singleton Class (Lock) ------");
            RunThreadSafeSingletonWithLock();

            Console.WriteLine("\n ------ Run Thread-Safe Singleton Class (Without Lock) ------");
            RunThreadSafeSingletonWithoutLock();

            Console.WriteLine("\n ------ Run Thread-Safe Singleton Class (Without Lock [Lazy]) ------");
            RunThreadSafeSingletonWithoutLock_SubClass();

            Console.WriteLine("\n ------ Run Thread-Safe Singleton Class (Without Lock [Net Lazy]) ------");
            RunThreadSafeSingletonWithoutLock_NetLazy();
        }

        private static void RunNonThreadSafeSingleton()
        {
            Task task1 = new Task(() => {
                NonThreadSafeSingletonClass singletonobj 
                    = NonThreadSafeSingletonClass.Instance;
                singletonobj.PrintMyId();
            });
            Task task2 = new Task(() => {
                NonThreadSafeSingletonClass singletonobj 
                    = NonThreadSafeSingletonClass.Instance;
                singletonobj.PrintMyId();
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            task2.Wait();
        }
        private static void RunThreadSafeSingletonWithLock()
        {
            Task task1 = new Task(() => {
                ThreadSafeSingletonClass_WithLock singletonobj 
                    = ThreadSafeSingletonClass_WithLock.Instance;
                singletonobj.PrintMyId();
            });
            Task task2 = new Task(() => {
                ThreadSafeSingletonClass_WithLock singletonobj 
                    = ThreadSafeSingletonClass_WithLock.Instance;
                singletonobj.PrintMyId();
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            task2.Wait();
        }
        private static void RunThreadSafeSingletonWithoutLock()
        {
            Task task1 = new Task(() => {
                ThreadSafeSingletonClass_WithoutLock singletonobj 
                    = ThreadSafeSingletonClass_WithoutLock.Instance;
                singletonobj.PrintMyId();
            });
            Task task2 = new Task(() => {
                ThreadSafeSingletonClass_WithoutLock singletonobj 
                    = ThreadSafeSingletonClass_WithoutLock.Instance;
                singletonobj.PrintMyId();
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            task2.Wait();
        }
        private static void RunThreadSafeSingletonWithoutLock_SubClass()
        {
            Task task1 = new Task(() => {
                ThreadSafeSingletonClass_WithoutLock_SubClass singletonobj 
                    = ThreadSafeSingletonClass_WithoutLock_SubClass.Instance;
                singletonobj.PrintMyId();
            });
            Task task2 = new Task(() => {
                ThreadSafeSingletonClass_WithoutLock_SubClass singletonobj 
                    = ThreadSafeSingletonClass_WithoutLock_SubClass.Instance;
                singletonobj.PrintMyId();
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            task2.Wait();
        }
        private static void RunThreadSafeSingletonWithoutLock_NetLazy()
        {
            Task task1 = new Task(() => {
                ThreadSafeSingletonClass_WithoutLock_NetLazy singletonobj 
                    = ThreadSafeSingletonClass_WithoutLock_NetLazy.Instance;
                singletonobj.PrintMyId();
            });
            Task task2 = new Task(() => {
                ThreadSafeSingletonClass_WithoutLock_NetLazy singletonobj 
                    = ThreadSafeSingletonClass_WithoutLock_NetLazy.Instance;
                singletonobj.PrintMyId();
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            task2.Wait();
        }
    }
}
