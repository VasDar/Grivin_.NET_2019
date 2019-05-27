namespace Grivin_Vasiliy_Task14_15.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Relations
    {
        public int Id { get; set; }

        public int IDAwards { get; set; }

        public int IDUser { get; set; }

        public virtual Awards Awards { get; set; }

        public virtual Users Users { get; set; }
    }
}
