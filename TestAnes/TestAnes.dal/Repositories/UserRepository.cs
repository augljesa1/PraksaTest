using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAnes.dal.DatabaseContext;
using TestAnes.dal.Domain;

namespace TestAnes.dal.Repositories
{
    public class UserRepostirory : IUserRepository
    {
        private TestDbContext dbcontext;
        private int id;

        //private object _dbcontext;

        public UserRepostirory(TestDbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }
        public async Task<IReadOnlyCollection<User>> GetUsers(int Id, CancellationToken cancellationToken = default)
        {
            return await dbcontext.Users.Take(15).Where(x => x.Id == id).ToListAsync(cancellationToken);

        }
    }
}
