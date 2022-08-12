using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Attributes;

namespace AutoMapperBnechmark
{
    public class AutoMapperBenchmark
    {
        public Source20 Source20 { get; set; }
        public Source25 Source25 { get; set; }
        public AutoMapperBenchmark()
        {
            Fixture fixture = new Fixture();
            Source20 = fixture.Create<Source20>();
            Source25 = fixture.Create<Source25>();
        }

        [Benchmark]
        public void Map20PropertiesWithAutoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            var mapper = new Mapper(configuration);
            var result = mapper.Map<Destination20>(Source20);
        }

        [Benchmark]
        public void Map20FieldsManually()
        {
            var result = new Destination20
            {
                Code = Source20.Code,
                Contact = Source20.Contact,
                DateOfBirth = Source20.DateOfBirth,
                Email = Source20.Email,
                Email2 = Source20.Email2,
                ExternalId = Source20.ExternalId,
                ExternalId2 = Source20.ExternalId2,
                Fax = Source20.Fax,
                FirstName = Source20.FirstName,
                Gin = Source20.Gin,
                Initials = Source20.Initials,
                IsEmployee = Source20.IsEmployee,
                IsMainDriver = Source20.IsMainDriver,
                LastName = Source20.LastName,
                MiddleName = Source20.MiddleName,
                Name = Source20.Name,
                Phone = Source20.Phone,
                Phone2 = Source20.Phone2,
                PhoneNo = Source20.PhoneNo,
                Prefix = Source20.Prefix,
                Salut = Source20.Salut
            };
        }

        [Benchmark]
        public void Map25FieldWithAutomapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            var mapper = new Mapper(configuration);
            var result = mapper.Map<Destination25>(Source25);
        }
    }
}
