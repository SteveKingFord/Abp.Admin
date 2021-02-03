using System;
using Volo.Abp.Domain.Repositories;

namespace WeChatMiniProgram.Users
{
   public interface IUserRepository : IRepository<User, Guid>
   {

   }
}
