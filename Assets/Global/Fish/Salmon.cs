namespace Global
{
    public class Salmon: Fish
    {
        public Salmon()
        {
            _sprite = GameManager.Instance.salmonImg;
            _sprite.transform.position = GameManager.Instance.StartPoint.position;
        }
    }
}