public interface IProductRepository
{
    ResponseModel<UserModel> GetUserByID(int UserID);  
}