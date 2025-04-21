using System.Data;
using System.Data.SqlClient;

namespace CompInspeccion
{
    class SQLConnectionManager
    {
        public static void ConfiguraTimeOut (SqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 5000;
        }
    }
}
