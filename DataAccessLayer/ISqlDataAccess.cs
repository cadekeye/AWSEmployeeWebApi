using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ISqlDataAccess
    {
        //Task<T> Insert<T>(string sql, T data);
        Task<List<T>> LoadData<T, U>(string sql, U parameter);

        //Task Delete<T>(string sql, T data);

        Task<T> ProcessData<T>(string sql, T data);
    }
}