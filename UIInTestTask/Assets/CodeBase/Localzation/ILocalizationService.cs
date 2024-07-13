using CodeBase.Data;

namespace CodeBase.Services.Localization
{
    public interface ILocalizationService : IService
    {
        void Select(LanuageId id);
    }
}