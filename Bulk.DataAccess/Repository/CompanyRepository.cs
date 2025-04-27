using Bulk.DataAccess.Repository.IRepository;
using Bulk.DataAccess.Repository;
using BulkyBook.DataAccess.Data;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkBook.DataAccess.Repository.IRepository;

namespace BulkBook.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }

    }
}
