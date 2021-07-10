namespace Adapter_Pattern
{
    class Manager
    {
        DataSource db = new DataSource();
        IPlayer GetPlayer(int id)
        {
            return db.GetPlayer(id);
        }

        public IPlayerWebAdapter GetPlayer_Web(int id)
        {
            return new PlayerWebAdapter(db.GetPlayer(id));
        }

        public IPlayerAndroidAdapter GetPlayer_Android(int id)
        {
            return new PlayerAndroidAdapter(db.GetPlayer(id));
        }

        public IPlayerIOSAdapter GetPlayer_IOS(int id)
        {
            return new PlayerIOSAdapter(db.GetPlayer(id));
        }
    }
}