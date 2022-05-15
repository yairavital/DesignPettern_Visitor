using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetternVisitor
{
   public abstract class VideoFilecs : IVideoFile
    {
        public abstract void Accept(IVideoPlayer visit);
     
    }
}
