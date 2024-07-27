﻿namespace BuildingService.Domain
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Floors { get; set; }
        public bool IsDeleted { get; set; }
    }
}