using CodeBase.AssetManagement;
using CodeBase.Services;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Elements
{
    [RequireComponent(typeof(Button))]
    public class DownloadButton : MonoBehaviour
    {     
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private GameObject _window;

        private IAssetProvider _assets;
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            InitAssets();
            _button.onClick.AddListener(InstantiatePopUp);
        }

        private void InstantiatePopUp() => 
            _assets.Instantiate(AssetAddress.AddMoneyPopUpPath, _spawnPoint.position, _window.transform);

        private void InitAssets() => 
            _assets = AllServices.Container.Single<IAssetProvider>();
    }
}