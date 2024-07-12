using CodeBase.Data;
using CodeBase.Services;
using CodeBase.Services.PersistentProgress;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Localization
{
    [RequireComponent(typeof(Button))]
    public class LanguageSelectButton : MonoBehaviour
    {
        private IPersistentProgressService _progress;
        private ISaveLoadService _saveLoad;
        private int _currentValue;
        private Button _button;
        [SerializeField] private LanuageId _id;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Select);

            _progress = AllServices.Container.Single<IPersistentProgressService>();
            _saveLoad = AllServices.Container.Single<ISaveLoadService>();

            
        }

        private void Select()
        {
            switch (_id)
            {
                case LanuageId.Russian:
                    LanguageSave(1);
                    break;
                case LanuageId.English:
                    LanguageSave(2);
                    break;
            }
        }

        private void LanguageSave(int value)
        {
            _progress.Progress.Language.LangugeValue = value;
            _currentValue = value;
            _saveLoad.SaveProgress();
        }

        private void LoadLanguage()
        {
            //_progress.Progress.Language.LangugeValue
        }
    }
}