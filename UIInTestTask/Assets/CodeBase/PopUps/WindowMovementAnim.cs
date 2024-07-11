using DG.Tweening;
using UnityEngine;

namespace CodeBase.PopUps
{
    public class WindowMovementAnim : MonoBehaviour
    {
        [SerializeField] private int _startPositionCount;
        private float _startPosition;

        private void OnEnable()
        {
            ResetToStartPosition();
            transform.DOLocalMoveX(transform.position.x - _startPositionCount * 1.3f, 2);
        }

        private void ResetToStartPosition()
        {
            transform.position = new Vector3(transform.position.x + _startPositionCount, transform.position.y, transform.position.z);
        }
    }
}