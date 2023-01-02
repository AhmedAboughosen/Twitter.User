using System;
using System.Threading.Tasks;
using Core.Application.Contracts.Repositories;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class FollowerRepository : AsyncRepository<Follower>, IFollowerRepository
    {
        private readonly AppDbContext _appDbContext;

        public FollowerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<bool> AnyAsync(Guid followerId, Guid followeeId)
            => _appDbContext.Followers.AnyAsync(x => x.FollowerId == followerId && x.FolloweeId == followeeId);

        public Task<Follower> FirstOrDefaultAsync(Guid followerId, Guid followeeId)
            => _appDbContext.Followers.FirstOrDefaultAsync(
                x => x.FollowerId == followerId && x.FolloweeId == followeeId);
    }
}