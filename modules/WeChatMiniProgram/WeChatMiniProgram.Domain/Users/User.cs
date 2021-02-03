using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace WeChatMiniProgram.Users
{
    public class User : FullAuditedAggregateRoot<Guid>
    {
        public virtual Guid UserId { get; set; }

        public virtual string NickName { get; set; }

        public virtual GenderType Gender { get; set; }

        [NotNull]
        public virtual string OpenId { get; set; }



        protected User()
        {

        }

        public User(string nickName, string openId, Guid userId, GenderType gender)
        {
            UserId = userId;
            OpenId = openId;
            Gender = gender;
            NickName = nickName;
        }

    }
}
