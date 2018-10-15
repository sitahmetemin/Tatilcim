using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Repository;
using Tatilcim.Core.Services.Abstract;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core.Services.Concrate
{
    public class ElasticSearchService : IElasticServices
    {
        public void CreateIndex()
        {
            var node = new Uri("http://localhost:9200");

            var settings = new ConnectionSettings(node)
                .DefaultIndex("newhotel");

            var client = new ElasticClient(settings);
            var del = client.DeleteIndex("newhotel");
            var newIndex = client.CreateIndex("newhotel", p => p
               .Settings(q => q
                    .NumberOfReplicas(0)
                    .NumberOfShards(1))
                .Mappings(m => m
                    .Map<ElasticDto>(k => k
                    .AutoMap())));
            var model = GetDto();
            foreach (var item in model)
            {
                var indexResponse = client.IndexDocument(item);
            }
        }

        public List<ElasticDto> Search(string key)
        {

            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(node)
                .DefaultIndex("newhotel");

            var client = new ElasticClient(settings);

            //Harf harf veri çekmek için
            var searchResponse = client.Search<ElasticDto>(s => s
              .Index("newhotel")
              .AllTypes()
              .Query(q => q
              .Prefix(p => p.Field(x => x.Name).Value(key))));

            //Tam isimde veri çekmek için
            //var searchResponse = client.Search<ElasticDto>(s => s
            //  .Query(m => m
            //  .Match(k => k
            //  .Field(f => f.HotelName)
            //  .Query(key))));

            return searchResponse.Documents.ToList();

        }

        public List<ElasticDto> GetDto()
        {
            using (BaseRepository<Otel> db = new BaseRepository<Otel>())
            {
                var model = db.Query<Otel>().Where(a => a.Status == true).Select(a => new ElasticDto
                {
                    Id = a.Id,
                    Name = a.Name

                }).ToList();

                return model;

            }
        }
    }
}
