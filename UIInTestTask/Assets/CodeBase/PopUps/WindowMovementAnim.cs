using DG.Tweening;
using UnityEngine;

namespace CodeBase.PopUps
{
    public class WindowMovementAnim : MonoBehaviour
    {
        private const float _inaccuracy = 1.28f;
        private const int _duration = 2;
        [SerializeField] private int _startPositionCount;

        private void OnEnable()
        {
            ResetToStartPosition();
            transform.DOLocalMoveX(transform.position.x - _startPositionCount * _inaccuracy, _duration);
        }

        private void ResetToStartPosition() => 
            transform.position = new Vector3(transform.position.x + _startPositionCount, transform.position.y, transform.position.z);
    }
}