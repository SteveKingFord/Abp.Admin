using System;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using WeChatMiniProgram.EntityFrameworkCore;

namespace WeChatMiniProgram.Users
{
  
    public class UserRepository : EfCoreRepository<IWeChatMiniProgramDbContext, User, Guid>, IUserRepository
    {
        public UserRepository(IDbContextProvider<IWeChatMiniProgramDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
