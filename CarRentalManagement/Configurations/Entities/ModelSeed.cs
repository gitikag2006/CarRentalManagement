using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>

    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id=1,
                    Name="i4",
                    Datecreated = DateTime.Now,
                    DateUpdated=DateTime.Now,
                    CreatedBy="System",
                    UpdatedBy="System"

                },
                new Model
                {
                    Id = 2,
                    Name = "x5",
                    Datecreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Model
                {
                    Id = 3,
                    Name = "Prius",
                    Datecreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                }, new Model
                {
                    Id = 4,
                    Name = "C-HR",
                    Datecreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                });
        }
    }
}
