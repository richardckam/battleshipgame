namespace BattleshipGame
{
    /// <summary>
    /// Handles the conversion between the game-playable ID position system ("A1") and the zero-based index position system ([0,0])
    /// </summary>
    internal struct Position
    {
        #region Private Variables
        private int _rowIndex;
        private int _columnIndex;
        #endregion

        #region Public Constructors
        public Position(int rowIndex, int columnIndex)
        {
            _rowIndex = rowIndex;
            _columnIndex = columnIndex;
        }
        public Position(string row, int column) : this(PositionIdToIndex.ConvertRow(row), PositionIdToIndex.ConvertColumn(column)) { }
        #endregion

        #region Public Methods
        internal int RowIndex { get { return _rowIndex; } }
        internal int ColumnIndex { get { return _columnIndex; } }

        public string RowId { get { return PositionIndexToId.ConvertRow(_rowIndex); } }
        public int ColumnId { get { return PositionIndexToId.ConvertColumn(_columnIndex); } }
        public string Id { get { return RowId + ColumnId.ToString(); } }
        #endregion
    }
}
