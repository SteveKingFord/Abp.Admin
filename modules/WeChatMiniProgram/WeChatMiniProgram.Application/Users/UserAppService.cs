using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using WeChatMiniProgram.Users.Dtos;

namespace WeChatMiniProgram.Users
{
    public class UserAppService : CrudAppService<User, UserDto, Guid, GetListUserInput, CreateUserDto, UpdateUserDto>,
        IUserAppService
    {

        private readonly IUserRepository _repository;

        public UserAppService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override async Task<PagedResultDto<UserDto>> GetListAsync(GetListUserInput input)
        {
            var queryable = await _repository.GetQueryableAsync();

            var query = queryable.WhereIf(!input.Filter.IsNullOrEmpty(), x => x.NickName.Contains(input.Filter));

            var results = await AsyncExecuter.ToListAsync(query);
            var count = await AsyncExecuter.LongCountAsync(query);

            return new PagedResultDto<UserDto>(
                count,
                ObjectMapper.Map<List<User>, List<UserDto>>(results)
                );
        }
    }
}
