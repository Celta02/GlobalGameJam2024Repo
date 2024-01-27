using UnityEngine;

namespace CeltaGames
{
    public class HitBox : MonoBehaviour
    {
        public delegate void OnDisableCallBack(HitBox instance);
        public OnDisableCallBack disable;


        public void GotHit() => disable.Invoke(this);
    }
}