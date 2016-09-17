using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Permission.Models.Mapping
{
    public class dtUserMap : EntityTypeConfiguration<dtUser>
    {
        public dtUserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.Iden)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("dtUser");
            this.Property(t => t.Iden).HasColumnName("Iden");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.GUID).HasColumnName("GUID");
            this.Property(t => t.CreatedByID).HasColumnName("CreatedByID");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.UpdatedByID).HasColumnName("UpdatedByID");
            this.Property(t => t.UpdatedTime).HasColumnName("UpdatedTime");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.dtStatu)
                .WithMany(t => t.dtUsers)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
