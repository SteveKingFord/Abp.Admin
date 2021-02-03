using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace WeChatOfficialAccount.MongoDB
{
    [ConnectionStringName(WeChatOfficialAccountDbProperties.ConnectionStringName)]
    public class WeChatOfficialAccountMongoDbContext : AbpMongoDbContext, IWeChatOfficialAccountMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureWeChatOfficialAccount();
        }
    }
}