using CodeBase.Services;
using CodeBase.Services.PersistentProgress;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Localization
{
    [RequireComponent(typeof(Text))]
    public class LocalizationText : MonoBehaviour
    {
        private Text _text;
        private IPersistentProgressService _progress;
        [SerializeField] private string[] _textVariant;

        private void Awake()
        {
            _progress = AllServices.Container.Single<IPersistentProgressService>();
            _text = GetComponent<Text>();
            LanguageSelect(_progress.Progress.Language.LangugeValue);

        }

        private void LanguageSelect(int number) => 
            _text.text = _textVariant[number - 1];
    }
}