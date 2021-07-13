namespace Bridge_Pattern
{
    //abstraction 
    interface IRemoteControl
    {
        int CurrentStation{get;set;}
        void On();
        void Off();
        void SetStation();
    }

    //concrete implementation
    class SonyRemoteControl : IRemoteControl
    {
        public int CurrentStation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Off()
        {
            throw new System.NotImplementedException();
        }

        public void On()
        {
            throw new System.NotImplementedException();
        }

        public void SetStation()
        {
            throw new System.NotImplementedException();
        }
    }
    
    // concrete implementation 
    class SamsungRemoteControl : IRemoteControl
    {
        public int CurrentStation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Off()
        {
            throw new System.NotImplementedException();
        }

        public void On()
        {
            throw new System.NotImplementedException();
        }

        public void SetStation()
        {
            throw new System.NotImplementedException();
        }
    }

    // bridge 
    abstract class RemoteImplementation
    {
        protected IRemoteControl remoteControl;
        protected RemoteImplementation(IRemoteControl remoteControl)
        {
            this.remoteControl = remoteControl;
        }

        public abstract void NextSTation();
        public abstract void SetNetflix();
    // some other features...

    }

    class SamsungRemoteControlImplementation : RemoteImplementation
    {
        public SamsungRemoteControlImplementation(IRemoteControl remoteControl): base(remoteControl)
        {

        }

        public override void NextSTation()
        {
            remoteControl.CurrentStation += 1;
        }
        public override void SetNetflix()
        {
            remoteControl.CurrentStation = 26;
        }
    }

    class Client
    {
        // using implementation 
        void Run()
        {
            RemoteImplementation remoteImplementation = new SamsungRemoteControlImplementation(new SonyRemoteControl());
            remoteImplementation.SetNetflix();
        }
    }

}

