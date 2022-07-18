﻿namespace NZWalks.API.Models.Domain
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId{ get; set; }
    }
}
