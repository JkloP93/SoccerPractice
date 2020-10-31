namespace SoccerPractice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Position { get; set; }

        public int Age { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
