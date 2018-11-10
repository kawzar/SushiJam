using System.Collections.Generic;
using System.Linq;

namespace RookBirdTools.InputManager
{
    public class ContinueSet : AbstractContinueInput
    {
        public HashSet<AbstractContinueInput> set;

        public override bool Happens => set.All((item)=>item.Happens);

        public ContinueSet()
        {
            set = new HashSet<AbstractContinueInput>();
        }

        public void Add(AbstractContinueInput c)
        {
            set.Add(c);
        }

        public ContinueSet(IEnumerable<AbstractContinueInput> collection) :this ()
        {
            set = new HashSet<AbstractContinueInput>(set.Union(collection));
        }
    }
}
