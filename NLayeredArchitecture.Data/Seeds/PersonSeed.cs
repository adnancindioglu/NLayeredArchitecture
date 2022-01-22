using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredArchitecture.Data.Seeds
{
    class PersonSeed : IEntityTypeConfiguration<Person>
    {
        public PersonSeed()
        {
        }

        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
               new Person
               {
                   Id = 1,
                   Name = "Adnan",
                   SurName = "Cin",
               },
               new Person
               {
                   Id = 2,
                   Name = "Mehmet",
                   SurName = "Can",
               }
           );
        }
    }
}
