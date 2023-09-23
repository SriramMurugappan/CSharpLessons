using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.DayThree
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent() 
        {
            Console.WriteLine("Start");
        }
        public void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        
    }
    internal class AudioContent : MediaContent// child class : parent class
    {
        public override sealed void StartPlayingContent() 
        {
            Console.WriteLine("Start from AudioContent");
        }
        public override string ToString()
        {
            Console.WriteLine("AudioContent ToString");
            return "Audio Content";
        }
    }
    internal class VideoContent : MediaContent 
    {

    }
    internal class MediaTester 
    {
        public static void TestOne() 
        {

        }
    }

}
