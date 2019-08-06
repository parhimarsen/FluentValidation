using System;
using System.Data;

namespace FluentApi.Infrastructure.Models
{
    public class InfrastructureQuery
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string ActionDescriptor { get; set; }

        public string Result { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
