using System.Collections.Generic;
using System.Threading.Tasks;

namespace UploadFiles.DAL.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadDataAsync<T>(string storedProcedure, object parameters = null);
        Task SaveDataAsync(string storedProcedure, object parameters);
    }
}