using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IdleOn_Wiki.Entities;

namespace IdleOn_Wiki.Entities
{
    public class AreaEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? WorldId { get; set; }
        public WorldEntity? World { get; set; }

        // TODO: Fill in missing entities
    }
}
