using System;
using UnityEngine;

namespace CeltaGames
{
    public class PlayButton : MonoBehaviour
    {
        SceneLoader _sceneLoader = new SceneLoader();

        public void OnPlayButtonClicked() => _sceneLoader.LoadMainScene();
    }
}