using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace WeChatMiniProgram.MongoDB
{
    [ConnectionStringName(WeChatMiniProgramDbProperties.ConnectionStringName)]
    public class WeChatMiniProgramMongoDbContext : AbpMongoDbContext, IWeChatMiniProgramMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureWeChatMiniProgram();
        }
    }
}