
namespace DesignPattern_Strategy
{
    class ApplicationRunner
    {
        private IApplication _itsApplication = null;
        public ApplicationRunner(IApplication app)
        {
            _itsApplication = app;
        }
        public void run()
        {
            _itsApplication.Init();
            while (!_itsApplication.Done())
            {
                _itsApplication.Idle();
            }
            _itsApplication.CleanUp();
        }
    }
}
