namespace RookBirdTools.MoreTools
{
    public abstract class NullAutocheck{

        public static implicit operator bool (NullAutocheck n)
        {
            return n != null;
        }

    }
}
