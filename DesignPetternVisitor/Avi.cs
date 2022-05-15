namespace DesignPetternVisitor
{
    public class Avi : VideoFilecs
    {
        public override void Accept(IVideoPlayer visit)
        {
            visit.Visit(this);
        }
    }
}