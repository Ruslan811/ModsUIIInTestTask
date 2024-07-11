using CodeBase.Services;
using System.Threading.Tasks;
using UnityEngine;

namespace CodeBase.Factories
{
    public interface IUIFactory : IService
    {
        Task<GameObject> CreateHud();
        void CreateMain();
        void CreateModesLook();
        void CreatePolitic();
        Task CreateUIRoot();
        void CreateDownloadLook();
        void CreateModDescriptionLook();
    }
}