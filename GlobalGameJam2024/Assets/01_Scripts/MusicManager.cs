using System;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

namespace CeltaGames
{
    public class MusicManager : MonoBehaviour
    {
        [Header("Music")]
        [SerializeField] EventReference _mainTheme;
        [SerializeField] EventReference _goodEnding;
        [SerializeField] EventReference _badEnding;
        
        EventInstance _mainThemeInstance;
        EventInstance _goodEndingInstance;
        EventInstance _badEndingInstance;

        void Awake()
        {
            _mainThemeInstance = RuntimeManager.CreateInstance(_mainTheme);
            _goodEndingInstance = RuntimeManager.CreateInstance(_goodEnding);
            _badEndingInstance = RuntimeManager.CreateInstance(_badEnding);
        }

        void Start()
        {
            _mainThemeInstance.start();
        }
    }
}