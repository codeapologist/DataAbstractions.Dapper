using Dapper;

namespace DataAbstractions.Dapper
{
    public partial class GridAccessor : IGridAccessor
    {
        private readonly SqlMapper.GridReader _gridReader;

        public GridAccessor(SqlMapper.GridReader gridReader)
        {
            _gridReader = gridReader;
        }

        public void Dispose()
        {
            _gridReader.Dispose();
        }
    }
}