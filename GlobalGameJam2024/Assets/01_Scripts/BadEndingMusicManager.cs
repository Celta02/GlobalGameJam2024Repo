using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

namespace CeltaGames
{
    public class BadEndingMusicManager : MonoBehaviour
    {
        [SerializeField] EventReference _badEnding;

        EventInstance _badEndingInstance;
        void Awake() => _badEndingInstance = RuntimeManager.CreateInstance(_badEnding);
        void Start() => _badEndingInstance.start();
        void OnDestroy() => _badEndingInstance.stop(STOP_MODE.ALLOWFADEOUT);
    }
}