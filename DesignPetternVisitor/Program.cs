using DesignPetternVisitor;

IVideoPlayer player = new VideoPlayercs();
IVideoFile akv = new AKV();
akv.Accept(player);