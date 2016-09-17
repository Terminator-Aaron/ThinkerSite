using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Permission.Models.Mapping
{
    public class dtSysDictMap : EntityTypeConfiguration<dtSysDict>
    {
        public dtSysDictMap()
        {
            // Primary Key
            this.HasKey(t => t.SysDictID);

            // Properties
            this.Property(t => t.Iden)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SysDictID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SysDictName)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("dtSysDict");
            this.Property(t => t.Iden).HasColumnName("Iden");
            this.Property(t => t.SysDictID).HasColumnName("SysDictID");
            this.Property(t => t.SysDictName).HasColumnName("SysDictName");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.CreatedByID).HasColumnName("CreatedByID");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.UpdatedByID).HasColumnName("UpdatedByID");
            this.Property(t => t.UpdatedTime).HasColumnName("UpdatedTime");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.dtStatu)
                .WithMany(t => t.dtSysDicts)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
