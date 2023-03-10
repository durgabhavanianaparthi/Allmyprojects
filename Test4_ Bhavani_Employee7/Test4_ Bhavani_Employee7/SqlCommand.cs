namespace Test4__Bhavani_Employee7
{
    internal class SqlCommand
    {
        private string query;
        private SqlConnection sqlCon;

        public SqlCommand(string query, SqlConnection sqlCon)
        {
            this.query = query;
            this.sqlCon = sqlCon;
        }

        public object Parameters { get; internal set; }

        internal void Clone()
        {
            throw new NotImplementedException();
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}