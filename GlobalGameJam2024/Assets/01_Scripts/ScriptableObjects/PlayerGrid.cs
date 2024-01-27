using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Grid", menuName = "ScriptableObjects/Grid", order = 0)]
    public class PlayerGrid : ScriptableObject
    {
        Cell[] _cells;
        int _numberOfCells;

        public int NumberOfCells => _numberOfCells;

        public void Setup(Vector2 position, int numberOfCells, float spacing)
        {
            _numberOfCells = numberOfCells;
            
            _cells = new Cell[numberOfCells];
            for (int i = 0; i < numberOfCells; i++)
            {
                var pos = new Vector3(position.x + spacing * i, position.y);
                _cells[i] = new Cell(pos);
            }
        }
        
        public Cell GetCellAtPosition(int cellNumber) => 
                cellNumber > NumberOfCells || cellNumber <= 0 ? null : _cells[cellNumber-1];
        
        public Vector3 GetCellPosition(int cellNumber) => GetCellAtPosition(cellNumber).Position;
    }
}