namespace DesignPetternVisitor
{
    public class AKV : VideoFilecs
    {
        public override void Accept(IVideoPlayer visit)
        {
            visit.Visit(this);
        }
    }
}