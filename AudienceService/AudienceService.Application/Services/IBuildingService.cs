﻿using AudienceService.Application.Contracts;

namespace AudienceService.Application.Services
{
    public interface IBuildingService
    {
        Task<List<BuildingDto>> GetBuildingsAsync();
        Task<BuildingDto> GetBuildingByIdAsync(int id);
        Task<int> AddBuildingAsync(BuildingCreateDto buildingCreateDto);
        Task UpdateBuildingAsync(int id, BuildingUpdateDto buildingUpdateDto);
        Task DeleteBuildingAsync(int id);
    }
}