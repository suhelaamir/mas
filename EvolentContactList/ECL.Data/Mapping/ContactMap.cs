using System.Data.Entity.ModelConfiguration;
using ECL.Common.Data;

namespace ECL.DataAccess.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            //key
            HasKey(t => t.ID).HasEntitySetName("ID");
            //properties
            Property(t => t.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.LastName).HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.Email).HasColumnType("nvarchar");
            Property(t => t.Phone).HasColumnType("nvarchar");
            Property(t => t.Status);
            //table
            ToTable("Contact");
        }
    }
}
