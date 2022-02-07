using System;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Dennis");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Dennis", "https://iamges/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("FailVideo", "Dennis", "Https://video.com/failvideo", true, 10);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop video");
            Console.ReadKey();
            videoPost1.Stop();



        }
    }
}
