using CodeBase.Factories;
using CodeBase.StaticData;

namespace CodeBase.Services.UI
{
    public class WindowService : IWindowService
    {
        private readonly IUIFactory _uiFactory;

        public WindowService(IUIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        public void Open(WindowId windowId)
        {
            switch (windowId)
            {
                case WindowId.None:
                    break;
                /*case WindowId.Clicker:
                    _uiFactory.CreateClicker();
                    break;
                case WindowId.Shop:
                    _uiFactory.CreateShop();
                    break;*/
                case WindowId.Main:
                    _uiFactory.CreateMain();
                    break;
                case WindowId.Politic:
                    _uiFactory.CreatePolitic();
                    break;
                case WindowId.ModesLook:
                    _uiFactory.CreateModesLook();
                    break;
                case WindowId.ModDescription:
                    _uiFactory.CreateModDescriptionLook();
                    break;
                case WindowId.Download:
                    _uiFactory.CreateDownloadLook();
                    break;
            }
        }
    }
}
