namespace Global
{
    public class GiverFIsh
    {
        private static GiverFIsh _instance;
        public static GiverFIsh Instance => _instance = _instance ?? new GiverFIsh();
        
        public Fish Salmon { get; private set; } = new Salmon();
        public Fish Crab { get; private set; } = new Crab();
        public Fish Shrimp { get; private set; } = new Shrimp();
        public Fish Tuna { get; private set; } = new Tuna();

        private readonly Fish[] _fishes;

        private GiverFIsh()
        {
            _fishes= new Fish[]{Salmon,Crab,Shrimp,Tuna};
        }

        public Fish Random()
        {
            var rand = UnityEngine.Random.Range(0, 4);
            return _fishes[rand];
        }
    }
}