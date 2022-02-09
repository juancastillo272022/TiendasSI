using System;
using System.Collections.Generic;

namespace TiendasSI.Api.Models
{
    public partial class Production
    {
        public int IdProduction { get; set; }
        public string Title { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public string Producer { get; set; } = null!;
        public string Type { get; set; } = null!;
        public decimal Value { get; set; }
        public bool Status { get; set; }
    }
}
