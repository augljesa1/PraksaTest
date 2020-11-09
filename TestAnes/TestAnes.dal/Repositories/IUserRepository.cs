using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAnes.dal.Domain;

namespace TestAnes.dal.Repositories
{
    public interface IUserRepository
    {
        Task<IReadOnlyCollection<User>> GetUsers(int Id, CancellationToken cancellationToken = default);
    }
}
