using UnityEngine;

namespace CeltaGames
{
    public class HitBox : MonoBehaviour
    {
        HitBoxTypeComponent _typeComponent;
        public delegate void OnDisableCallBack(HitBox instance);
        public OnDisableCallBack disable;

        public HitBoxTypeComponent Type
        {
            get => _typeComponent;
            set => _typeComponent = value;
        }


        public void GotHit() => disable.Invoke(this);
    }
}