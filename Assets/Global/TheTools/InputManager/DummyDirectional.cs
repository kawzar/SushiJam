using UnityEngine;

namespace RookBirdTools.InputManager
{
    public class DummyDirectional : AbstractDirectionalInput{
        private Vector2 dir = Vector2.zero;
        public override Vector2 Direction => Dir;

        public Vector2 Dir
        {
            get
            {
                return dir;
            }
            set
            {
                dir = value;
                if(dir.x!=0 || dir.y!=0)
                {
                    dir = dir.normalized;
                }
            }
        }
    }
}
