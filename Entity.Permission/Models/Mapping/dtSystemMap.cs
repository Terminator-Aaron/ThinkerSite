using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Permission.Models.Mapping
{
    public class dtSystemMap : EntityTypeConfiguration<dtSystem>
    {
        public dtSystemMap()
        {
            // Primary Key
            this.HasKey(t => t.SystemID);

            // Properties
            this.Property(t => t.Iden)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SystemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SystemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("dtSystem");
            this.Property(t => t.Iden).HasColumnName("Iden");
            this.Property(t => t.SystemID).HasColumnName("SystemID");
            this.Property(t => t.SystemName).HasColumnName("SystemName");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.CreatedByID).HasColumnName("CreatedByID");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.UpdatedByID).HasColumnName("UpdatedByID");
            this.Property(t => t.UpdatedTime).HasColumnName("UpdatedTime");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.dtStatu)
                .WithMany(t => t.dtSystems)
                .HasForeignKey(d => d.StatusID);

        }
    }
}
