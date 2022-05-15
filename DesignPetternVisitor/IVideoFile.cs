using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetternVisitor
{
    internal interface IVideoFile
    {
        void Accept(IVideoPlayer visit);
    }
}
