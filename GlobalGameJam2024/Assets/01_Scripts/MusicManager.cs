using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

namespace CeltaGames
{
    public class MusicManager : MonoBehaviour
    {
        [SerializeField] EventReference _mainTheme;
        
        EventInstance _mainThemeInstance;
        
        void Awake() => _mainThemeInstance = RuntimeManager.CreateInstance(_mainTheme);
        void Start() => _mainThemeInstance.start();
        void OnDestroy() => _mainThemeInstance.stop(STOP_MODE.ALLOWFADEOUT);
    }
}