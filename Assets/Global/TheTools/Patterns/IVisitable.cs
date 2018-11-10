namespace RookBirdTools.Patterns
{
    public interface IVisitable <out TVisitableType> where TVisitableType : IVisitable<TVisitableType>
    {
        void accept(IVisitor<TVisitableType> visitor);

    }
}