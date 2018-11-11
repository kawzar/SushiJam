namespace Global.Bear
{
    public class Bear
    {
        private StateBear _stateBear;
        private static Bear _instance;
        public static Bear Instance => _instance = _instance ?? new Bear();

        public Bear()
        {
        
        }

        public void NailsUp()
        {
            GameManager.Instance.nails.GetComponent<NailScript>().GrowNails();
        }

        public void NailToZero()
        {
            GameManager.Instance.nails.GetComponent<NailScript>().ToBorn();
        }
        
        


    }
}