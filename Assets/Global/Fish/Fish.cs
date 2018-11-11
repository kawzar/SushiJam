using System;
using DG.Tweening;
using RookBirdTools.MoreTools;
using UnityEngine;

namespace Global
{
    public abstract class Fish
    {
        protected SpriteRenderer _sprite;
        protected float _speed=0.5f; 

        public void Move()
        {
            var moveToHit=_sprite.transform.DOMove(GameManager.Instance.HitPoint.position, _speed);
            moveToHit.OnComplete(() =>
            {
                TargetSelection.Instance._inPosition = true;
                    TimeStuff.DoAfter(
                        () =>
                        {
                            TargetSelection.Instance._inPosition = false;
                            var end=_sprite.transform.DOMove(GameManager.Instance.DestinyPoint.position, _speed);
                            end.OnComplete(()=>
                            {
                                _sprite.transform.position = GameManager.Instance.StartPoint.position;
                            
                            });
                        },_speed);
                });
        }

        public void SetNormalSpeed()
        {
            _speed = 0.5f;
        }
        
        public void SetFeverSpeed()
        {
            _speed = 0.2f;
        }

        public void Move(Action onCOmplete)
        {
            var moveToHit=_sprite.transform.DOMove(GameManager.Instance.HitPoint.position, _speed);
            moveToHit.OnComplete(() =>
            {
                TargetSelection.Instance._inPosition = true;
                TimeStuff.DoAfter(
                    () =>
                    {
                        TargetSelection.Instance._inPosition = false;
                        var end=_sprite.transform.DOMove(GameManager.Instance.DestinyPoint.position, _speed);
                        end.OnComplete(()=>
                        {
                            _sprite.transform.position = GameManager.Instance.StartPoint.position;
                            onCOmplete.Invoke();
                            
                        });

                    },_speed);
            });
        }
    }
}