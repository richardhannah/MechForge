using Newtonsoft.Json;

namespace MechForge.Domain
{

    public partial class Weapon
    {
        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("WeaponSubType")]
        public string WeaponSubType { get; set; }

        [JsonProperty("MinRange")]
        public long MinRange { get; set; }

        [JsonProperty("MaxRange")]
        public long MaxRange { get; set; }

        [JsonProperty("RangeSplit")]
        public long[] RangeSplit { get; set; }

        [JsonProperty("AmmoCategory")]
        public string AmmoCategory { get; set; }

        [JsonProperty("StartingAmmoCapacity")]
        public long StartingAmmoCapacity { get; set; }

        [JsonProperty("HeatGenerated")]
        public long HeatGenerated { get; set; }

        [JsonProperty("Damage")]
        public long Damage { get; set; }

        [JsonProperty("OverheatedDamageMultiplier")]
        public long OverheatedDamageMultiplier { get; set; }

        [JsonProperty("EvasiveDamageMultiplier")]
        public long EvasiveDamageMultiplier { get; set; }

        [JsonProperty("EvasivePipsIgnored")]
        public long EvasivePipsIgnored { get; set; }

        [JsonProperty("DamageVariance")]
        public long DamageVariance { get; set; }

        [JsonProperty("HeatDamage")]
        public long HeatDamage { get; set; }

        [JsonProperty("AccuracyModifier")]
        public long AccuracyModifier { get; set; }

        [JsonProperty("CriticalChanceMultiplier")]
        public long CriticalChanceMultiplier { get; set; }

        [JsonProperty("AOECapable")]
        public bool AoeCapable { get; set; }

        [JsonProperty("IndirectFireCapable")]
        public bool IndirectFireCapable { get; set; }

        [JsonProperty("RefireModifier")]
        public long RefireModifier { get; set; }

        [JsonProperty("ShotsWhenFired")]
        public long ShotsWhenFired { get; set; }

        [JsonProperty("ProjectilesPerShot")]
        public long ProjectilesPerShot { get; set; }

        [JsonProperty("AttackRecoil")]
        public long AttackRecoil { get; set; }

        [JsonProperty("Instability")]
        public long Instability { get; set; }

        [JsonProperty("WeaponEffectID")]
        public string WeaponEffectId { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("BonusValueA")]
        public string BonusValueA { get; set; }

        [JsonProperty("BonusValueB")]
        public string BonusValueB { get; set; }

        [JsonProperty("ComponentType")]
        public string ComponentType { get; set; }

        [JsonProperty("ComponentSubType")]
        public string ComponentSubType { get; set; }

        [JsonProperty("PrefabIdentifier")]
        public string PrefabIdentifier { get; set; }

        [JsonProperty("BattleValue")]
        public long BattleValue { get; set; }

        [JsonProperty("InventorySize")]
        public long InventorySize { get; set; }

        [JsonProperty("Tonnage")]
        public long Tonnage { get; set; }

        [JsonProperty("AllowedLocations")]
        public string AllowedLocations { get; set; }

        [JsonProperty("DisallowedLocations")]
        public string DisallowedLocations { get; set; }

        [JsonProperty("CriticalComponent")]
        public bool CriticalComponent { get; set; }

        [JsonProperty("statusEffects")]
        public object[] StatusEffects { get; set; }

        [JsonProperty("ComponentTags")]
        public ComponentTags ComponentTags { get; set; }
    }

    public partial class ComponentTags
    {
        [JsonProperty("items")]
        public string[] Items { get; set; }

        [JsonProperty("tagSetSourceFile")]
        public string TagSetSourceFile { get; set; }
    }

}
