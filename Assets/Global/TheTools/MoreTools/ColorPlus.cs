using UnityEngine;

namespace RookBirdTools.MoreTools
{
    public static class ColorPlus
    {
        public static Color Alpha (this Color c, float a)
        {
            Color co = c;
            co.a = a;        
            return co;
        }	
    }
}
