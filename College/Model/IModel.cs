using System.Data.SqlClient;

namespace College.Model
{
    internal interface IModel
    {
        SqlParameter[] GetSqlParameters();
        string GetColumnNames();
    }
}