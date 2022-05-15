namespace DesignPetternVisitor
{
    public class Mp4 : VideoFilecs
    {
        public override void Accept(IVideoPlayer visit)
        {
            visit.Visit(this);
        }
    }
}