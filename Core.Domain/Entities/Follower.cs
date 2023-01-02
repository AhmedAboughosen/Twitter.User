using System;
using Core.Domain.Model.DTO.RequestDTO;

namespace Core.Domain.Entities
{
    public class Follower
    {
        public Guid Id { get; private set; }

        public Guid FolloweeId { get; private set; }
        public User Followee { get; private set; }
        public Guid FollowerId { get; private set; }
        public User Followers { get; private set; }


        public Follower(AddFollowerRequestDto dto)
        {
            FolloweeId = dto.FolloweeId;
            FollowerId = dto.FollowerId;
        }

        public Follower()
        {
        }
    }
}