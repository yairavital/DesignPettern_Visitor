using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetternVisitor
{
    internal  class VideoPlayercs : IVideoPlayer
    {
        public void Visit(Mp4 video)
        {
            Console.WriteLine("Mp4 is playing now");
        }

        public void Visit(Avi video)
        {
            Console.WriteLine("Avi is playing now");
        }

        public void Visit(AKV video)
        {
            Console.WriteLine("Akv is playing now");
        }
    }
}
