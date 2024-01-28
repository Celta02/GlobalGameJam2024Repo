using System;
using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameTime _timer;
        [SerializeField] CatMoodLevelBroadcaster _catMood;
    
        readonly SceneLoader _sceneLoader = new SceneLoader();
        
        void Update()
        {
            if (_timer.Time <= 0f) EndGame();
        }

        async void EndGame()
        {
            switch (_catMood.CurrentMood)
            {
                case CatMoodLevel.VeryAngry:
                    await _sceneLoader.LoadDefeatScene();
                        break;
                case CatMoodLevel.Angry:
                    await _sceneLoader.LoadDefeatScene();
                    break;
                case CatMoodLevel.Neutral:
                    await _sceneLoader.LoadNeutralScene();
                    break;
                case CatMoodLevel.Happy:
                    await _sceneLoader.LoadVictoryScene();
                    break;
                case CatMoodLevel.VeryHappy:
                    await _sceneLoader.LoadVictoryScene();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}