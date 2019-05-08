using System.Text;

namespace BattleshipGame
{
    /// <summary>
    /// Convert PositionID values (e.g. "A1") to zero-based index values (e.g. [0,0]) for Rows and Columns
    /// </summary>
    internal class PositionIdToIndex
    {
        #region Public methods
        public static int ConvertRow(string rowId)
        {
            int resultValue = 0;
            byte[] letters = ASCIIEncoding.ASCII.GetBytes(rowId);
            int maxLetterIndex = letters.Length - 1;
            for (int i = 0; i <= maxLetterIndex; i++)
            {
                int letterValue = letters[maxLetterIndex - i];
                int letterIndex = letterValue - PositionData.AsciiBaseRowIndex;
                resultValue += letterIndex * Power(26, i);
            }
            return resultValue;
        }
        public static int ConvertColumn(int columnId)
        {
            return (columnId - 1);
        }
        #endregion

        #region Private methods
        private static int Power(int number, int exponent)
        {
            if (exponent == 0)
                return 1;
            else if (exponent == 1)
                return number;
            else
                return number * Power(number, --exponent);
        }
        #endregion
    }
}
