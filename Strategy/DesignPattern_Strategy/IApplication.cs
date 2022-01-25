namespace DesignPattern_Strategy
{
    public interface IApplication
    {
        void Init();
        void Idle();
        void CleanUp();
        bool Done();
    }
}
