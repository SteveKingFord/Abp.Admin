using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using WeChatOfficialAccount.MpAccessTokens;

namespace WeChatOfficialAccount.EntityFrameworkCore
{
    public static class WeChatOfficialAccountDbContextModelCreatingExtensions
    {
        public static void ConfigureWeChatOfficialAccount(
            this ModelBuilder builder,
            Action<WeChatOfficialAccountModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WeChatOfficialAccountModelBuilderConfigurationOptions(
                WeChatOfficialAccountDbProperties.DbTablePrefix,
                WeChatOfficialAccountDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<MpAccessToken>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "MpAccessTokens", options.Schema);
                b.ConfigureByConvention();

                //Properties
                b.Property(q => q.AccessToken).IsRequired().HasComment("公众号授权token");
                b.Property(q => q.AppId).IsRequired().HasMaxLength(MpAccessTokenConsts.MaxAppIdLength).HasComment("公众号AppId");
                b.Property(q => q.Secret).IsRequired().HasMaxLength(MpAccessTokenConsts.MaxSecretLength).HasComment("公众号Secret");

            });
        }
    }
}
