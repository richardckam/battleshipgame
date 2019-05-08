namespace BattleshipGame
{
    internal class PositionIndexToId
    {
        #region Public methods
        public static string ConvertRow(int rowIndex)
        {
            string returnValue = "";
            int remainder;
            int dividend = rowIndex + 1;
            while (dividend > 0)
            {
                remainder = rowIndex % 26;
                returnValue += CalculateRowChar(remainder);
                dividend = rowIndex / 26;
            }
            return returnValue;
        }
        public static int ConvertColumn(int columnIndex)
        {
            return (columnIndex + 1);
        }
        #endregion

        #region Private methods
        private static char CalculateRowChar(int charIndex)
        {
            return (char)(PositionData.AsciiBaseRowIndex + charIndex);
        }
        #endregion
    }
}
