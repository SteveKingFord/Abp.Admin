using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using WeChatMiniProgram.Users;

namespace WeChatMiniProgram.EntityFrameworkCore
{
    public static class WeChatMiniProgramDbContextModelCreatingExtensions
    {
        public static void ConfigureWeChatMiniProgram(
            this ModelBuilder builder,
            Action<WeChatMiniProgramModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WeChatMiniProgramModelBuilderConfigurationOptions(
                WeChatMiniProgramDbProperties.DbTablePrefix,
                WeChatMiniProgramDbProperties.DbSchema
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
            builder.Entity<User>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Users", options.Schema);

                b.ConfigureByConvention();

            });
        }
    }
}