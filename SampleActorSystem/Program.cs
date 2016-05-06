using Akka.Actor;

namespace SampleActorSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorSystem
                .Create("SampleActorSystem")
                .WhenTerminated
                .Wait();

        }
    }
}
