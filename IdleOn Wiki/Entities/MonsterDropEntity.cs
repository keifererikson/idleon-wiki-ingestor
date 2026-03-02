using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IdleOn_Wiki.Entities;

namespace IdleOn_Wiki.Entities
{
    public class MonsterDropEntity
    {
        [Key]
        public int Id { get; set; }

        public int MonsterId { get; set; }
        public MonsterEntity? Monster { get; set; }

        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public double DropChance { get; set; }

        public string? RequirementContext { get; set; }
    }
}
