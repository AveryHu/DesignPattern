using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proxy pattern is more like some different kind of applications.
            // Virtual proxy : Like lazy Initialization
            // Protection proxy : Portect the access right of real subect
            // Remote proxy : To execute a remote service
            // However, a proxy might influence the performance and complicate the system.
            RunProxy();
        }

        private static void RunProxy()
        {
            Guild guild = new Guild();
            Console.WriteLine(" ===== Help me to kill dragon ! ===== ");
            guild.MissionRequest("kill the dragon");            
        }
    }
}
