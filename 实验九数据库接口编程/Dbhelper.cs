using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;

namespace emp
{
    class Dbhelper
    {
        public static string connectionstring = "user id =system;data source =ORCL;password =di986334";
        public static OracleConnection connection = new OracleConnection(connectionstring);
    }
}
