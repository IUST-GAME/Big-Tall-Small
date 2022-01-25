namespace Repository
{
    /*
     * Singleton classes for storing game data
     * Note: Not thread safe for now
     */
    public class GameRepository
    {
        private static GameRepository _instance = null;

        private GameRepository()
        {
        }

        public static GameRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameRepository();
                }
                return _instance;
            }
        }

        public int level = 2;

    }
}