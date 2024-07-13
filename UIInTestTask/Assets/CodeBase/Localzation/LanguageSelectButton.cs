using CodeBase.Data;
using CodeBase.Services;
using CodeBase.Services.Localization;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Localization
{
    [RequireComponent(typeof(Button))]
    public class LanguageSelectButton : MonoBehaviour
    {
        private ILocalizationService _localization;
        private Button _button;

        [SerializeField] private LanuageId _id;

        private void Awake()
        {
            ButtonInit();

            _localization = AllServices.Container.Single<ILocalizationService>();
        }

        private void ButtonInit()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Select);
        }

        private void Select() => 
            _localization.Select(_id);
    }
}