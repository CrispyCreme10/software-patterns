namespace Strategy
{
    public class Duck
    {
        public IFlyStrategy fly;
        public IQuackStrategy quack;
        public ISwimStrategy swim;

        public void Execute()
        {
            fly.Run();
            quack.Run();
            swim.Run();
        }
    }
}