using CodeBase.Elements;
using DG.Tweening;
using UnityEngine;

namespace CodeBase.PopUps
{
    public class DownloadPopUp : MonoBehaviour
    {
        [SerializeField] private DownloadBar _bar;
        private float _current = 0f;
        private float _max = 100;

        private void OnEnable()
        {
            DOTween.To(SetMax, _current, _max, 3f);
        }

        private void SetMax(float current)
        {
            _bar.SetValue(current, _max);
            if (current >= _max)
                Destroy(gameObject);
        }
    }
}