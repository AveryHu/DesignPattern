using System;

namespace ProxyPattern
{
    public class Guild : Subject
    {
        private Hero _hero;

        public void MissionRequest(string request)
        {
            if(_hero == null)
                _hero = new Hero();

            PreRequest(request);
            _hero.MissionRequest(request);
            PostRequest();
        }

        public void PreRequest(string request)
        {
            Console.WriteLine(" ---- Guild accept the request (Proxy) ---- ");
            Console.WriteLine("Ask hero to handle request : " + request);
        } 

        public void PostRequest()
        {
            Console.WriteLine("Guild report to the client that his request was finished.. ");
        }
    }
}
