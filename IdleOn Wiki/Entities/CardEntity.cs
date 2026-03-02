using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IdleOn_Wiki.Entities;

namespace IdleOn_Wiki.Entities
{
    public class CardEntity
    {
        [Key]
        public int Id { get; set; }

        public int MonsterId { get; set; }
        public MonsterEntity? Monster { get; set; }
        public string? CardName { get; set; }
        public string? ImagePath { get; set; }
        public string? Effect { get; set; }
        public string? ScalingValues { get; set; }
        public string? Category { get; set; }
        public double DropChance { get; set; }
    }
}
