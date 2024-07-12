using System;

namespace CodeBase.Data
{
    [Serializable]
    public class PlayerProgress
    {
        public LanguageData Language;

        public PlayerProgress()
        {
            Language = new LanguageData();
        }
    }
}