using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Admin.MongoDB
{
    [ConnectionStringName(AdminDbProperties.ConnectionStringName)]
    public class AdminMongoDbContext : AbpMongoDbContext, IAdminMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAdmin();
        }
    }
}