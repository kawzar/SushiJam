using UnityEngine;
using DG.Tweening;

public class HandMovement : MonoBehaviour
{
    [SerializeField]
    GameObject waypoint1;

    [SerializeField]
    GameObject waypoint2;

    [SerializeField]
    GameObject waypoint3;

    private bool isMovingHand;

    private void Awake()
    {
        SwipeManager.OnSwipeHappened += MoveHand;
    }

    public void MoveHand(InputAction direction)
    {
        if (!isMovingHand && (direction == InputAction.Down || direction == InputAction.Up))
        {
            isMovingHand = true;

            var sequence = DOTween.Sequence()
                .Append(transform.DOMove(waypoint1.transform.position, 0.25f).SetEase(Ease.Linear))
                .Append(transform.DOMove(waypoint2.transform.position, 0.25f).SetEase(Ease.Linear))
                .Append(transform.DOMove(waypoint3.transform.position, 0.25f).SetEase(Ease.Linear));

            sequence.Play();

            sequence.OnComplete(() => isMovingHand = false);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
