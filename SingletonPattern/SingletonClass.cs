using System;
namespace SingletonPattern
{
    public sealed class NonThreadSafeSingletonClass
    {
        private Guid _instanceid;
        private static NonThreadSafeSingletonClass _instance = null;
        private NonThreadSafeSingletonClass()
        {
            Console.WriteLine("Creating NonThreadSafeSingletonClass...");
            _instanceid = Guid.NewGuid();
        }
        public static NonThreadSafeSingletonClass Instance
        {
            get 
            {
                if(_instance == null)
                    _instance = new NonThreadSafeSingletonClass();
                return _instance;
            }
        }
        public void PrintMyId()
        {
            Console.WriteLine("My GUID : " + _instanceid);
        }
    }

    public sealed class ThreadSafeSingletonClass_WithLock
    {
        private Guid _instanceid;
        private static readonly object locker = new object(); 
        private static ThreadSafeSingletonClass_WithLock _instance = null;
        private ThreadSafeSingletonClass_WithLock()
        {
            Console.WriteLine("Creating ThreadSafeSingletonClass_WithLock...");
            _instanceid = Guid.NewGuid();
        }
        public static ThreadSafeSingletonClass_WithLock Instance
        {
            get 
            {
                if(_instance == null)
                {
                    lock(locker)
                    {
                        if(_instance == null)
                        {
                            _instance = new ThreadSafeSingletonClass_WithLock();
                        }
                    }
                }

                return _instance;
            }
        }
        public void PrintMyId()
        {
            Console.WriteLine("My GUID : " + _instanceid);
        }
    }

    public sealed class ThreadSafeSingletonClass_WithoutLock
    {
        private Guid _instanceid;    
        private static ThreadSafeSingletonClass_WithoutLock _instance 
                                = new ThreadSafeSingletonClass_WithoutLock();
        private ThreadSafeSingletonClass_WithoutLock()
        {
            Console.WriteLine("Creating ThreadSafeSingletonClass_WithoutLock...");
            _instanceid = Guid.NewGuid();
        }
        public static ThreadSafeSingletonClass_WithoutLock Instance
        {
            get 
            {
                return _instance;
            }
        }
        public void PrintMyId()
        {
            Console.WriteLine("My GUID : " + _instanceid);
        }
    }

    public sealed class ThreadSafeSingletonClass_WithoutLock_SubClass
    {
        private Guid _instanceid;    
        private static ThreadSafeSingletonClass_WithoutLock_SubClass _instance 
                                = new ThreadSafeSingletonClass_WithoutLock_SubClass();
        private ThreadSafeSingletonClass_WithoutLock_SubClass()
        {
            Console.WriteLine("Creating ThreadSafeSingletonClass_WithoutLock_SubClass...");
            _instanceid = Guid.NewGuid();
        }
        public static ThreadSafeSingletonClass_WithoutLock_SubClass Instance
        {
            get 
            {
                return ForLazy.Instance;
            }
        }
        public void PrintMyId()
        {
            Console.WriteLine("My GUID : " + _instanceid);
        }
        private class ForLazy
        {
            private ForLazy(){}

            public static readonly ThreadSafeSingletonClass_WithoutLock_SubClass Instance
                        = new ThreadSafeSingletonClass_WithoutLock_SubClass();
        }
    }

    public sealed class ThreadSafeSingletonClass_WithoutLock_NetLazy
    {
        private Guid _instanceid;
        private static readonly Lazy<ThreadSafeSingletonClass_WithoutLock_NetLazy> _lazy
                                = new Lazy<ThreadSafeSingletonClass_WithoutLock_NetLazy>
                                (() => new ThreadSafeSingletonClass_WithoutLock_NetLazy());

        private ThreadSafeSingletonClass_WithoutLock_NetLazy()
        {
            Console.WriteLine("Creating ThreadSafeSingletonClass_WithoutLock_NetLazy...");
            _instanceid = Guid.NewGuid();
        }

        public static ThreadSafeSingletonClass_WithoutLock_NetLazy Instance 
        { 
            get 
            { 
                return _lazy.Value;
            }
        }
        public void PrintMyId()
        {
            Console.WriteLine("My GUID : " + _instanceid);
        }
    }
}