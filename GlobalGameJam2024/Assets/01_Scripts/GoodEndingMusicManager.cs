using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

namespace CeltaGames
{
    public class GoodEndingMusicManager : MonoBehaviour
    {
        [SerializeField] EventReference _goodEnding;

        EventInstance _goodEndingInstance;
        void Awake() => _goodEndingInstance = RuntimeManager.CreateInstance(_goodEnding);
        void Start() => _goodEndingInstance.start();
        void OnDestroy() => _goodEndingInstance.stop(STOP_MODE.ALLOWFADEOUT);
    }
}