namespace Global
{
    public class Tuna : Fish
    {
        public Tuna()
        {
            _sprite = GameManager.Instance.tunaImg;
            _sprite.transform.position = GameManager.Instance.StartPoint.position;
        }
    }
}