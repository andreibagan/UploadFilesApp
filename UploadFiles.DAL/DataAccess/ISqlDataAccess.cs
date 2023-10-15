using System.Threading.Tasks;

namespace UploadFiles.DAL.DataAccess
{
    public interface ISqlDataAccess
    {
        Task SaveDataAsync(string storedProcedure, object parameters);
    }
}