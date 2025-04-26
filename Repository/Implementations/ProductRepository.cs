using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Data.SqlClient;

public class ProductRepository : IProductRepository
{
    private IConfiguration configuration;

    public ProductRepository(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    public ResponseModel<UserModel> GetUserByID(int UserID)
    {
        try
        {
            return new ResponseModel<UserModel>() 
            {
                Result = new UserModel() 
                {
                    UserName = "Mathan Test User",
                    UserId = 123, 
                    Cby = 1,
                    CDate = DateTime.Now,
                    Uby = 2,
                    UDate = DateTime.Now
                },
                httpStatusCode = System.Net.HttpStatusCode.Accepted,
            };
            // using (SqlConnection SampleAPIConnection = new SqlConnection(configuration.GetConnectionString("SampleAPIConnection")))
            // {
            //     SampleAPIConnection.Open();
            //     string query = "SELECT * FROM tbl_User WHERE UserId = @UserID";

            //     using (SqlCommand sqlCommand = new SqlCommand(query, SampleAPIConnection))
            //     {
            //         sqlCommand.Parameters.AddWithValue("@UserID", UserID);

            //         using (SqlDataReader reader = sqlCommand.ExecuteReader())
            //         {
            //             if (reader.Read())
            //             {
            //                 UserModel user = new UserModel
            //                 {
            //                     UserId = Convert.ToInt32(reader["UserId"]),
            //                     UserName = reader["UserName"].ToString(),
            //                     Cby = Convert.ToInt32(reader["Cby"]),
            //                     CDate = Convert.ToDateTime(reader["CDate"]),
            //                 };
            //                 return new ResponseModel<UserModel>()
            //                 {
            //                     Result = user,
            //                     httpStatusCode = System.Net.HttpStatusCode.Accepted,
            //                 };
            //             }
            //             else
            //             {
            //                 return new ResponseModel<UserModel>()
            //                 {
            //                     ErrorMessage = "User not found"
            //                 };
            //             }
            //         }
            //     }
            // }
        }
        catch (Exception ex)
        {
            return new ResponseModel<UserModel>()
            {
                ErrorMessage = ex.Message
            };
        }

    }
}