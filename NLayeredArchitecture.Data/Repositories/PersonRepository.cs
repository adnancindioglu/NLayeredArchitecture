using NLayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredArchitecture.Data.Repositories
{
    public class PersonRepository : Repository<Person>
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public PersonRepository(AppDbContext context) : base(context)
        {

        }
    }
}
