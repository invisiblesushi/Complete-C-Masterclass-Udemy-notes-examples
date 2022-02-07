using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC 
{
    class VideoPost : Post
    {
        //Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //Properties
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }

    public VideoPost() { }

    public VideoPost(string title, string sendtByUsername, string videoURL, bool isPublic, int lenght)
    {
            //Inherit from Post
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendtByUsername;
            this.IsPublic = isPublic;

            //property member of ImagePost
            this.VideoUrl = videoURL;
            this.Length = lenght;
    }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", 
                this.ID, this.Title, this.VideoUrl, this.Length, this.SendByUsername);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playinh");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Vidoe at {0}s", currDuration);
                //Garbage collection
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
            Console.WriteLine("Stopped at {0}", currDuration);
            currDuration = 0;
            //Stops the timer or resets it
            timer.Dispose();
            }
        }

    }
}
