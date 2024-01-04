using Bboard.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    내용 : 데이터베이스 관리를 위한 규약
 */


namespace Bboard.Manager
{
    internal interface IDatabaseManager
    {
        void open(DatabaseInfo dbInfo);
        DataTable Select(string sql);
        int Insert(string sql);
        int Update(string sql);
        int Delete(string sql);
        void Close();
    }
}
