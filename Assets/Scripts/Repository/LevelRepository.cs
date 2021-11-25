namespace Repository
{
    public class LevelRepository
    {
        private static LevelRepository _instance = null;

        private LevelRepository()
        {
        }

        public static LevelRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LevelRepository();
                }
                return _instance;
            }
        }

        public void ResetRepositoryData()
        {
            
        }
    }
}