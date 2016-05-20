using Akka.Actor;
using Shared.Domain;

namespace Shared
{
    public class Recommendation
    {
      public Video[] RecommendedVideos { get; }

      public Recommendation(Video[] recommendedVideos)
      {
         RecommendedVideos = recommendedVideos;
      }
   }

   public class LoginEvent
   {
      public int UserId { get; }

      public LoginEvent(int userId)
      {
         UserId = userId;
      }
   }

    public class VideoWatchedEvent
    {
        public int VideoId { get; }

        public int UserId { get; }

        public VideoWatchedEvent(int videoId, int userId)
        {
            VideoId = videoId;
            UserId = userId;
        }
    }

    public class RecommendationJob
    {
        public int UserId { get; }

        public IActorRef Client { get; }

        public RecommendationJob(int userId, IActorRef client)
        {
            UserId = userId;
            Client = client;
        }
    }
}
