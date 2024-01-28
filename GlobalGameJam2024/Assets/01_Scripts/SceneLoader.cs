using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace CeltaGames
{
    public class SceneLoader
    {
        public async Task LoadStartScene() => await LoadSceneAsync(0);
        public async Task LoadMainScene() => await LoadSceneAsync(1);
        public async Task LoadVictoryScene() => await LoadSceneAsync(2);
        public async Task LoadNeutralScene() => await LoadSceneAsync(3);
        public async Task LoadDefeatScene() => await LoadSceneAsync(4);

        
        async Task LoadSceneAsync(int sceneIndex)
        {
            var scene = SceneManager.LoadSceneAsync(sceneIndex);
            while (!scene.isDone)
            {
                await Task.Yield();
            }
        }
    }
}