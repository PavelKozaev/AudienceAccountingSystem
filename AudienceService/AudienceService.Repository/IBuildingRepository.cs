﻿using AudienceService.Domain;

namespace AudienceService.Repository
{
    public interface IBuildingRepository
    {
        Task<List<Building>> GetBuildingsAsync();
        Task<Building> GetBuildingByIdAsync(int id);
        Task AddBuildingAsync(Building building);
        Task UpdateBuildingAsync(Building building);
        Task DeleteBuildingAsync(Building building);
    }
}