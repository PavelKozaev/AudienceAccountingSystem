﻿namespace BuildingService.Application.Contracts
{
    public class BuildingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Floors { get; set; }
    }
}