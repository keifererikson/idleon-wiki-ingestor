using IdleOn_Wiki.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IdleOn_Wiki.Entities
{
    public class MonsterEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Attack { get; set; }
        public long Health { get; set; }
        public int Accuracy5 { get; set; }
        public int Accuracy100 { get; set; }
        public long Experience { get; set; }
        public int DefenceForZero { get; set; }
        public int RespawnTime { get; set; }
        public string? Weakness { get; set; }

        public int? CrystalVariantId { get; set; }
        [ForeignKey("CrystalVariantId")]
        public MonsterEntity? CrystalVariant { get; set; }
        public string? ParsedCrystalName { get; set; }

        [NotMapped]
        public int CrystalAttack => (int)(Attack * GameConstants.CrystalAttackMultiplier);
        [NotMapped]
        public long CrystalHealth => Health * GameConstants.CrystalHealthMultiplier;
        [NotMapped]
        public int CrystalAccuracy5 => (int)(Accuracy5 * GameConstants.CrystalAccuracyMultiplier);
        [NotMapped]
        public int CrystalAccuracy100 => (int)(Accuracy100 * GameConstants.CrystalAccuracyMultiplier);
        [NotMapped]
        public long CrystalExperience => Experience * GameConstants.CrystalExpMultiplier;

        public string? IdleAnimationPath { get; set; }
        public string? WalkingAnimationPath { get; set; }
        public string? DeathAnimationPath { get; set; }

        public CardEntity? Card { get; set; }
        public List<MonsterDropEntity>? Drops { get; set; }

        public string? ParsedWorldName { get; set; }
        public string? ParsedAreaNames { get; set; }

        public int? WorldId { get; set; }
        public WorldEntity? World { get; set; }

        public int? AreaId { get; set; }
        public List<AreaEntity>? Areas { get; set; }
    }
}
