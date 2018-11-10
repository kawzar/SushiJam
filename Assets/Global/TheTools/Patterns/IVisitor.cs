namespace RookBirdTools.Patterns
{
    public interface IVisitor<in TVisitableType> where TVisitableType : IVisitable<TVisitableType>
    {
        void visit(TVisitableType type);
    }
}