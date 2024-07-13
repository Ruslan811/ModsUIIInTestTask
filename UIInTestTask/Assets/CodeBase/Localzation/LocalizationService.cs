using CodeBase.Data;
using CodeBase.Services;
using CodeBase.Services.PersistentProgress;

namespace CodeBase.Services.Localization
{
    public class LocalizationService : ILocalizationService
    {
        private ISaveLoadService _saveLoad;
        private IPersistentProgressService _progress;

        public LocalizationService(ISaveLoadService saveLoad, IPersistentProgressService progress)
        {
            _saveLoad = saveLoad;
            _progress = progress;
        }

        public void Select(LanuageId id)
        {
            switch (id)
            {
                case LanuageId.Russian:
                    SaveLanguage(0);
                    break;
                case LanuageId.English:
                    SaveLanguage(1);
                    break;
            }
        }

        private void SaveLanguage(int value)
        {
            _progress.Progress.Language.LangugeValue = value;
            _saveLoad.SaveProgress();
        }
    }
}