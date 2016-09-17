using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Permission.Models.Mapping
{
    public class dtStatuMap : EntityTypeConfiguration<dtStatu>
    {
        public dtStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusID);

            // Properties
            this.Property(t => t.Iden)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.StatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StatusName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("dtStatus");
            this.Property(t => t.Iden).HasColumnName("Iden");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.StatusName).HasColumnName("StatusName");
            this.Property(t => t.SelfStatusID).HasColumnName("SelfStatusID");
            this.Property(t => t.SysDictID).HasColumnName("SysDictID");
            this.Property(t => t.CreatedByID).HasColumnName("CreatedByID");
            this.Property(t => t.CreatedByTime).HasColumnName("CreatedByTime");
            this.Property(t => t.UpdatedByID).HasColumnName("UpdatedByID");
            this.Property(t => t.UpdatedTime).HasColumnName("UpdatedTime");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
