using CodeBase.Data;
using CodeBase.Services.PersistentProgress;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Windows
{
    public abstract class WindowBase : MonoBehaviour
    { 
        protected IPersistentProgressService ProgressService;
        protected PlayerProgress Progress => ProgressService.Progress;

        public void Construct(IPersistentProgressService progressService) =>
          ProgressService = progressService;

        private void Awake() =>
          OnAwake();

        private void Start() =>
            Initialize();

        private void OnDestroy() =>
          Cleanup();

        protected virtual void OnAwake() { }

        protected virtual void Initialize() { }
        protected virtual void Cleanup() { }
    }
}