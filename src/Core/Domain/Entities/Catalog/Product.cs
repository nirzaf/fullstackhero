using DN.WebApi.Domain.Contracts;
using DN.WebApi.Domain.Extensions;
using System;

namespace DN.WebApi.Domain.Entities.Catalog
{
    public class Product : AuditableEntity, IMustHaveTenant
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Rate { get; private set; }
        public string TenantKey { get; set; }
        public string ImagePath { get; set; }
        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public Product(string name, string description, decimal rate, Guid brandId, string imagePath)
        {
            Name = name;
            Description = description;
            Rate = rate;
            ImagePath = imagePath;
            BrandId = brandId;
        }

        protected Product()
        {
        }

        public Product Update(string name, string description, decimal rate, Guid brandId, string imagePath)
        {
            if (name != null && !Name.NullToString().Equals(name)) Name = name;
            if (description != null && !Description.NullToString().Equals(description)) Description = description;
            if (Rate != rate) Rate = rate;
            if (brandId != Guid.Empty && !BrandId.NullToString().Equals(brandId)) BrandId = brandId;
            if (imagePath != null && !ImagePath.NullToString().Equals(imagePath)) ImagePath = imagePath;
            return this;
        }
    }
}