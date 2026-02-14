using Cysharp.Threading.Tasks;
using Helpers;
using VContainer;
using VContainer.Unity;

namespace _Game.Scripts.Helpers.DI
{
    public class MainEntryPoint : IInitializable
    {
        private readonly SceneLoader _sceneLoader;
        private readonly InputHandler _inputHandler;
        
        [Inject]
        public MainEntryPoint(SceneLoader sceneLoader, InputHandler inputHandler)
        {
            _sceneLoader = sceneLoader;
            _inputHandler = inputHandler;
        }

        public async void Initialize()
        {
            await InitAsync();
            Init();
            
            //Пока нету меню
            _sceneLoader.LoadScene(1).Forget();

        }

        public async UniTask InitAsync()
        {
            
        }

        public void Init()
        {
            _inputHandler.Init();
        }
    }
}