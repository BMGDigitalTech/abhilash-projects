using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inherit
{
    class VideoPost:Post
    {
        // Members
        private bool isPlaying = false;
        private int curDuration = 0;
        Timer timer;
        // Properties
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }

        public VideoPost(string title, string videoUrl, int length, string uname):base(title, uname)
        {
            this.ID = getCurrentId();
            this.VideoUrl = videoUrl;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4}", this.ID, this.Title, this.VideoUrl, this.Length, this.UserName);
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        }
        

        private void TimerCallBack(Object o)
        {
            if(curDuration < Length)
            {
                curDuration++;
                Console.WriteLine("Video at {0}s", curDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", curDuration);
                curDuration = 0;
                timer.Dispose();
            }
        }
    }
}
