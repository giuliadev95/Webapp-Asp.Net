﻿namespace WebappAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set;}
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LengthKm { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }

        // Navigation properties
        public required Difficulty Difficulty { get; set; }
        public required Region Region { get; set; }
    }
}
