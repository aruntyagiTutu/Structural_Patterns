namespace Adapter_Pattern
{
    class IOS_Client
    {
        void DoingSomething()
        {
            Manager manager = new Manager();
            IPlayerIOSAdapter player = manager.GetPlayer_IOS(10);
            // use data to display 
        }
    }

    class Android_Client
    {
        void DoingSomething()
        {
            Manager manager = new Manager();
            IPlayerAndroidAdapter player = manager.GetPlayer_Android(10);
            // use data to display 
        }
    }

    class Web_Client
    {
        void DoingSomething()
        {
            Manager manager = new Manager();
            IPlayerWebAdapter player = manager.GetPlayer_Web(10);
            // use data to display 
        }
    }
}