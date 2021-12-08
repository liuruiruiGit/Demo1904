using Microsoft.EntityFrameworkCore;
using MyProject.Rbac;
using MyProject.Shopping;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace MyProject.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class MyProjectDbContext : 
        AbpDbContext<MyProjectDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {

        }

      
      
        public DbSet<GoodsModel> GoodsModels { get; set; }
        public DbSet<GoodsImgModel> GoodsImgModels { get; set; }
        public DbSet<GoodsSpecificationModel> GoodsSpecificationModels { get; set; }
        public DbSet<GoodsTypeModel> GoodsTypeModels { get; set; }
        public DbSet<ImgModel> ImgModels { get; set; }
        public DbSet<LogModel> LogModels { get; set; }
        public DbSet<SiteModel> SiteModels { get; set; }
        public DbSet<SpecificationModel> SpecificationModels { get; set; }
        public DbSet<IndentModel> IndentModels { get; set; }
        public DbSet<IndentDetailModel> IndentDetailModels { get; set; }
        public DbSet<UserImgModel> UserImgModels { get; set; }



        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<MenuModel> MenuModels { get; set; }
        public DbSet<OrganizationModel> OrganizationModels { get; set; }
        public DbSet<RoleMenuModel> RoleMenuModels { get; set; }
        public DbSet<RoleModel> RoleModels { get; set; }
        public DbSet<UserRoleModel> UserRoleModels { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MyProjectConsts.DbTablePrefix + "YourEntities", MyProjectConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
