using System.Collections.Generic;
using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] PlayerGrid _playerGrid;
        [SerializeField] Transform _cellsParent;
        [Space, Header("Grid Setup")]
        [SerializeField] Vector2 _firstCellPosition = Vector2.zero;
        [SerializeField] float _spacing = 3f;
        [SerializeField] List<CellVisual> _cellVisuals = new ();
        [SerializeField] List<GameObject> _cellGameObjects;
        [SerializeField] Vector2 _visualOffset = Vector2.zero; 
        
        int _gridLength = 5;

        public List<CellVisual> CellVisuals => _cellVisuals;
        public List<GameObject> CellGameObjects => _cellGameObjects;


        void Awake() => InitializeGrid();

        void InitializeGrid()
        {
            _cellGameObjects = new List<GameObject>();
            _playerGrid.Setup(_firstCellPosition, _gridLength, _spacing);
            for (int i = 1; i <= _gridLength; i++)
            {
                var go = Instantiate(_cellVisuals[i - 1].Prefab,
                    _playerGrid.GetCellPosition(i) + (Vector3)_visualOffset,
                    Quaternion.identity, 
                    _cellsParent);
                _cellGameObjects.Add(go);
                
                var hitBoxType = go.AddComponent<HitBoxTypeComponent>();
                hitBoxType.Type = _cellVisuals[i - 1].Type;
                _playerGrid.GetCellAtPosition(i).Type = hitBoxType.Type;
                
                if (!go.TryGetComponent(out SpriteRenderer sr)) return;
                sr.sprite = _cellVisuals[i-1].CellSprite;
                sr.color = _cellVisuals[i-1].Color;
            }
        }

        void OnValidate()
        {
            _gridLength = CellVisuals.Count;
        }
    }
}