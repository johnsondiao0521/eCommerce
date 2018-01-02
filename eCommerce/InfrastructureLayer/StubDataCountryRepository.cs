using System;
using System.Collections.Generic;
using eCommerce.DomainModelLayer.Countries;
using eCommerce.Helpers.Repository;
using eCommerce.Helpers.Specification;

namespace eCommerce.InfrastructureLayer
{
    public class StubDataCountryRepository : IRepository<Country>
    {
        MemoryRepository<Country> memRepository;
        public StubDataCountryRepository(MemoryRepository<Country> memRepository)
        {
            this.memRepository = memRepository;

            memRepository.Add(Country.Create(new Guid("229074BD-2356-4B5A-8619-CDEBBA71CC21"), "United Kingdom"));
            memRepository.Add(Country.Create(new Guid("F3C78DD5-026F-4402-8A19-DAA956ACE593"), "United States"));
        }
        public void Add(Country entity)
        {
            memRepository.Add(entity);
        }

        public IEnumerable<Country> Find(ISpecification<Country> spec)
        {
            return memRepository.Find(spec);
        }

        public Country FindById(Guid id)
        {
            return memRepository.FindById(id);
        }

        public Country FindOne(ISpecification<Country> spec)
        {
            return memRepository.FindOne(spec);
        }

        public void Remove(Country entity)
        {
            memRepository.Remove(entity);
        }
    }
}
