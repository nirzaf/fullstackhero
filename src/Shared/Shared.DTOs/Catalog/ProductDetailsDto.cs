using System;

namespace DN.WebApi.Shared.DTOs.Catalog
{
    public class ProductDetailsDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public string ImagePath { get; set; }
        public BrandDto Brand { get; set; }
    }
}