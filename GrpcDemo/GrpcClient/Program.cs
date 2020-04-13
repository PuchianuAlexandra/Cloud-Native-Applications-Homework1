using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
           // var input = new HelloRequest { Name = "Tim" };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);


          //  var reply = await client.SayHelloAsync(input);

           // Console.WriteLine(reply.Message);
           
            Console.WriteLine("Tape a name: ");

            //Console.ReadLine();
           
            string name = Console.ReadLine();
          
            var response = await client.SayHelloAsync(new HelloRequest { Name = name });
            Console.WriteLine("\n" + "Press any key to exit...");
            Console.ReadKey();
        }
    }
}
