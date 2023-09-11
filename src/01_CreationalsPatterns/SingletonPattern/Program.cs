using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton Pattern!");

            ConfigManagerTest();

            // LoadBalancerTest();

            Console.ReadKey();
        }

        private static void ConfigManagerTest()
        {
            ConfigManager manager = new ConfigManager();
            manager.Set("name", "Marcin");

            ConfigManager other = new ConfigManager();
            object result = other.Get("name");
            Console.WriteLine(result);

        }

        private static void LoadBalancerTest()
        {
            Task.Run(() => LoadBalanceRequestTest(15));
            Task.Run(() => LoadBalanceRequestTest(15));
        }

        private static void LoadBalanceRequestTest(int numberOfRequests)
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            for (int i = 0; i < numberOfRequests; i++)
            {
                Server server = loadBalancer.NextServer;
                Console.WriteLine($"Send request to: {server.Name} {server.IP}");
            }
        }

        

        
    }




  
}
