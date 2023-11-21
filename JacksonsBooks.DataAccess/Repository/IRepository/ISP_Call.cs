using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonsBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        //eg first colum of first row in the result set 
        T Single<T>(String procedurename, DynamicParameters param = null);
        // execute something to the database  but not retrive anything 
        void Execute(string procedurename, DynamicParameters param = null);
        // retrives the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        // get all of the rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        //stored procedure that returns two tables 
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}