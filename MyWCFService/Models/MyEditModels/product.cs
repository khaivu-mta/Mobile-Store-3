namespace MyWCFService.Models.MyEditModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string sku { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string price { get; set; }

        [StringLength(255)]
        public string Ghz { get; set; }

        [StringLength(255)]
        public string color { get; set; }

        [StringLength(255)]
        public string sensor { get; set; }

        [StringLength(255)]
        public string cpu { get; set; }

        [StringLength(255)]
        public string ram { get; set; }

        [StringLength(255)]
        public string storage { get; set; }

        [StringLength(255)]
        public string camera_front { get; set; }

        [StringLength(255)]
        public string camera_rear { get; set; }

        [StringLength(255)]
        public string battery { get; set; }

        [StringLength(255)]
        public string display { get; set; }

        [StringLength(255)]
        public string sim { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public int? activate { get; set; }

        public int? product_cate_id { get; set; }

        public int? discount_id { get; set; }

        [StringLength(255)]
        public string image { get; set; }
    }
}
