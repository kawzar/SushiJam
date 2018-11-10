using JetBrains.Annotations;
using UnityEngine;

namespace RookBirdTools.InputManager
{
    public class DirectionalTarget : AbstractDirectionalInput
    {
        private Transform target;
        private Transform reference;

        public DirectionalTarget([NotNull] Transform referenceTransform, [NotNull] Transform targetTransform)
        {
            reference = referenceTransform;
            target = targetTransform;
        }

        public override Vector2 Direction => ((Vector2) (target.position - reference.position)).normalized;
    }
}