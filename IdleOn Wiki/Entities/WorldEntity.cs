using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdleOn_Wiki.Entities
{
    public class WorldEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        // TODO: Fill in missing entities
    }
}
