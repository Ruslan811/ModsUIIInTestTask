using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Elements
{
    public class DownloadBar : MonoBehaviour
    {
        [SerializeField] private Image _imageCurrent;

        public void SetValue(float current, float max) => 
            _imageCurrent.fillAmount = current / max;
    }
}