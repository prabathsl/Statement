using Stock.Model;
using Stock.Model.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository
{
    internal class UserRepository:RepositoryBase
    {
        internal async Task<OperationResult> UserLoginAsync(LoginModel loginDetails)
        {
            try
            {
                Task <User> userTask = Task.Run(()=> {
                    return _dbContect.Users.SingleOrDefault(x => x.UserName == loginDetails.UserName &&
                                    x.PasswordHash == loginDetails.PasswordHash);
                });
                
                if (await userTask != null)
                {
                    return new OperationResult(true, "");
                }
                return new OperationResult(false, DbMessage.User_Name_And_Password_Not_Match);
            }
            catch (Exception)
            {
                return new OperationResult(false, DbMessage.Connetion_failed);
            }
        }
    }
}
