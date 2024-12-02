using AMCMANAGMENT.DataContext;
using AMCMANAGMENT.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AMCMANAGMENT.Service.AssetCategories
{
    public class AssetCategoryService : IAssetCategoryService
    {
        private readonly AMCContext _context;
        private readonly IDbConnection _dbConnection;
        public AssetCategoryService(AMCContext context_, IDbConnection dbConnection)
        {
            _context = context_;
            _dbConnection = dbConnection;
        }

        public Task<int> Delete(int Id)
        {
            //throw new NotImplementedException();
            var r = Get(Id);
            SqlCommand cmd = new SqlCommand("sp_AssetCategory", (SqlConnection)_dbConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Operation", "DELETE");
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@DeletedId", "5c8ab08e-5dc4-4905-95b9-d2981414c810");
            cmd.Parameters.AddWithValue("@IsDeleted", true);
            cmd.Parameters.AddWithValue("@DeletedTime", r.Result.DeletedTime);
            cmd.Parameters.AddWithValue("@CreatedId", "");
            cmd.Parameters.AddWithValue("@CreatedTime", "");
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@NewID", "");
            _dbConnection.Open();
            cmd.ExecuteNonQuery();
            _dbConnection.Close();
            return Task.FromResult(r.Result.Id);
        }

        public Task<AssetCategory> Get(int Id)
        {
            AssetCategory AssetCatModal = new AssetCategory();
            SqlCommand cmd = new SqlCommand("sp_AssetCategory", (SqlConnection)_dbConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Operation", "GetId");
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@CreatedId", "");
            cmd.Parameters.AddWithValue("@CreatedTime", "");
            cmd.Parameters.AddWithValue("@DeletedId", "");
            cmd.Parameters.AddWithValue("@IsDeleted", "");
            cmd.Parameters.AddWithValue("@DeletedTime", "");
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@NewID", "");
            _dbConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            AssetCatModal.Id = Convert.ToInt32(reader["Id"]);
            AssetCatModal.CreatedId = Convert.ToString(reader["CreatedId"]);
            AssetCatModal.CreatedTime = Convert.ToDateTime(reader["CreatedTime"]);
            AssetCatModal.DeletedId = Convert.ToString(reader["DeletedId"]);
            AssetCatModal.IsDeleted = Convert.ToBoolean(reader["IsDeleted"]);
            AssetCatModal.DeletedTime = Convert.ToDateTime(reader["DeletedTime"]);
            AssetCatModal.Name = Convert.ToString(reader["Name"]);
            _dbConnection.Close();
            return Task.FromResult(AssetCatModal);

        }

        public Task<List<AssetCategory>> GetAll()
        {
            SqlCommand cmd = new SqlCommand("sp_AssetCategory", (SqlConnection)_dbConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Operation", "GetAll");
            cmd.Parameters.AddWithValue("@Id", 0);
            cmd.Parameters.AddWithValue("@CreatedId", "");
            cmd.Parameters.AddWithValue("@CreatedTime", "");
            cmd.Parameters.AddWithValue("@DeletedId", "");
            cmd.Parameters.AddWithValue("@IsDeleted", "");
            cmd.Parameters.AddWithValue("@DeletedTime", "");
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@NewID", "");
            _dbConnection.Open();
            SqlDataReader Reader = cmd.ExecuteReader();
            var Items = new List<AssetCategory>();
            if (Reader.Read())
            {
                do
                {
                    try
                    {
                        AssetCategory AssetCatModal = new AssetCategory();
                        AssetCatModal.Id = Convert.ToInt32(Reader["Id"]);
                        AssetCatModal.CreatedId = Convert.ToString(Reader["CreatedId"]);
                        AssetCatModal.CreatedTime = Convert.ToDateTime(Reader["CreatedTime"]);
                        AssetCatModal.DeletedId = Convert.ToString(Reader["DeletedId"]);
                        AssetCatModal.IsDeleted = Convert.ToBoolean(Reader["IsDeleted"]);
                        AssetCatModal.DeletedTime = Convert.ToDateTime(Reader["DeletedTime"]);
                        AssetCatModal.Name = Convert.ToString(Reader["Name"]);
                        Items.Add(AssetCatModal);
                    }
                    catch
                    {

                    }
                } while (Reader.Read());
            }
            _dbConnection.Close();
            return Task.FromResult(Items);
        }

        public async Task<int> Save(AssetCategory assetCategory)
        {
            //var result = await _context.AssetCategory.Exec
            assetCategory.CreatedId = "5c8ab08e-5dc4-4905-95b9-d2981414c810";
            SqlCommand cmd = new SqlCommand("sp_AssetCategory", (SqlConnection)_dbConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Operation", "INSERT");
            cmd.Parameters.AddWithValue("@Id", assetCategory.Id);
            cmd.Parameters.AddWithValue("@CreatedId", assetCategory.CreatedId);
            cmd.Parameters.AddWithValue("@CreatedTime", assetCategory.CreatedTime);
            cmd.Parameters.AddWithValue("@DeletedId", assetCategory.DeletedId);
            cmd.Parameters.AddWithValue("@IsDeleted", assetCategory.IsDeleted);
            cmd.Parameters.AddWithValue("@DeletedTime", assetCategory.DeletedTime);
            cmd.Parameters.AddWithValue("@Name", assetCategory.Name);
            cmd.Parameters.AddWithValue("@NewID", assetCategory.Id);
            _dbConnection.Open();
            int i = cmd.ExecuteNonQuery();
            _dbConnection.Close();
            return i;
        }
    }
}
