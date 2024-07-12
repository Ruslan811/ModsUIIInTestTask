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
                case WindowId.Main:
                    _uiFactory.CreateMain();
                    break;
                case WindowId.Politic:
                    _uiFactory.CreatePolitic();
                    break;
                case WindowId.ModesLook:
                    _uiFactory.CreateModesLook();
                    break;
                case WindowId.ModArkDescription:
                    _uiFactory.CreateModDescriptionLook();
                    break;
                case WindowId.ModMascaradDescription:
                    _uiFactory.CreateModMascaraddDescriptionLook();
                    break;
                case WindowId.Download:
                    _uiFactory.CreateDownloadLook();
                    break;
                case WindowId.Tutorial:
                    _uiFactory.CreateTutorial();
                    break;
            }
        }
    }
}
