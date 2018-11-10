using RookBirdTools.MoreTools;
using UnityEngine;

namespace RookBirdTools.InputManager
{
    public class DirectionalMouse : AbstractDirectionalInput
    {
        public override Vector2 Direction
        {
            get
            {
                Camera cam = Camera.main;
                if (!cam)
                {
                    cam = Object.FindObjectOfType<Camera>();
                }
                Vector2 refInCanvas = Reference!=null? cam.WorldToScreenPoint(Reference.position) : Vector3.zero;
                var rawDirection = refInCanvas.GoTo(Input.mousePosition) * 0.05f;
                return rawDirection.magnitude > 1 ? rawDirection.normalized : rawDirection;
                
            }
        }
        public Transform Reference { get; set; }

        public Vector2 ParseMouse()
        {
            Camera cam = Camera.main;
            if (!cam)
            {
                cam = Object.FindObjectOfType<Camera>();
            }
            Vector2 refInCanvas = Reference!=null? cam.WorldToScreenPoint(Reference.position) : Vector3.zero;
            return refInCanvas;
        }
        
        public DirectionalMouse (Transform reference)
        {
            Reference = reference;
        }

    }
}
