using System;
namespace SocialMed
{
  class Program
  {
    public static void Main(string[] args)
    {
      Post post1 = new Post("balsal", "bodi alom", true);
      System.Console.WriteLine(post1.ToString());

      ImagePost imagePost1 = new ImagePost("shoes", "bodi", true, "https://google.com/images");
      System.Console.WriteLine(imagePost1.ToString());

      ImagePost videoPost1 = new ImagePost("cats", "bodi", true, "https://google.com/videos");
      System.Console.WriteLine(videoPost1.ToString());
      


    }
  }
}