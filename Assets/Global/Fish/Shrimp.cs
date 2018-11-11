namespace Global
{
    public class Shrimp : Fish
    {
        public Shrimp()
        {
            _sprite = GameManager.Instance.shrimpImg;
            _sprite.transform.position = GameManager.Instance.StartPoint.position;
        }
    }
}