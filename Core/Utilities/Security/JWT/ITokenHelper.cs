using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        //veri tabanına kullanıcı bilgisiyle gidip kullanıcının claim lerini alıp token oluşturacağı için >> List<OperationClaim> operationClaims veriyoruz.
    }
}
