
namespace Demo.DAL.Data.Configurations
{
    public class DepartmentCofigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("Varchar(20)");
            builder.Property(d => d.Code).HasColumnType("Varchar(20)");
            builder.Property(d => d.Description).HasColumnType("Varchar(200)");

            builder.Property(d => d.CreateOn).HasDefaultValueSql("GetDate()");
            builder.Property(d => d.LastModifiedOn).HasComputedColumnSql("GetDate()");

        }
    }


}
