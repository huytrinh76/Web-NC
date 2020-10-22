namespace Modell.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductViewModel")]
    public partial class ProductViewModel
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Images { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        [StringLength(250)]
        public string CateName { get; set; }

        [StringLength(250)]
        public string CateMetaTitle { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
