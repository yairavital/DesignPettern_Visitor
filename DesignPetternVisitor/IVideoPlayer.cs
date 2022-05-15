namespace DesignPetternVisitor
{
    public interface IVideoPlayer
    {
        void Visit(Mp4 video);
        void Visit(Avi video);
        void Visit(AKV video);
    }
}