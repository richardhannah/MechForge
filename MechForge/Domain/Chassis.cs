namespace MechForge.Domain
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Chassis
    {
        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("MovementCapDefID")]
        public string MovementCapDefId { get; set; }

        [JsonProperty("PathingCapDefID")]
        public string PathingCapDefId { get; set; }

        [JsonProperty("HardpointDataDefID")]
        public string HardpointDataDefId { get; set; }

        [JsonProperty("PrefabIdentifier")]
        public string PrefabIdentifier { get; set; }

        [JsonProperty("PrefabBase")]
        public string PrefabBase { get; set; }

        [JsonProperty("Tonnage")]
        public long Tonnage { get; set; }

        [JsonProperty("InitialTonnage")]
        public long InitialTonnage { get; set; }

        [JsonProperty("weightClass")]
        public string WeightClass { get; set; }

        [JsonProperty("BattleValue")]
        public long BattleValue { get; set; }

        [JsonProperty("Heatsinks")]
        public long Heatsinks { get; set; }

        [JsonProperty("TopSpeed")]
        public long TopSpeed { get; set; }

        [JsonProperty("TurnRadius")]
        public long TurnRadius { get; set; }

        [JsonProperty("MaxJumpjets")]
        public long MaxJumpjets { get; set; }

        [JsonProperty("Stability")]
        public long Stability { get; set; }

        [JsonProperty("StabilityDefenses")]
        public long[] StabilityDefenses { get; set; }

        [JsonProperty("SpotterDistanceMultiplier")]
        public long SpotterDistanceMultiplier { get; set; }

        [JsonProperty("VisibilityMultiplier")]
        public long VisibilityMultiplier { get; set; }

        [JsonProperty("SensorRangeMultiplier")]
        public long SensorRangeMultiplier { get; set; }

        [JsonProperty("Signature")]
        public long Signature { get; set; }

        [JsonProperty("Radius")]
        public long Radius { get; set; }

        [JsonProperty("PunchesWithLeftArm")]
        public bool PunchesWithLeftArm { get; set; }

        [JsonProperty("MeleeDamage")]
        public long MeleeDamage { get; set; }

        [JsonProperty("MeleeInstability")]
        public long MeleeInstability { get; set; }

        [JsonProperty("MeleeToHitModifier")]
        public long MeleeToHitModifier { get; set; }

        [JsonProperty("DFADamage")]
        public long DfaDamage { get; set; }

        [JsonProperty("DFAToHitModifier")]
        public long DfaToHitModifier { get; set; }

        [JsonProperty("DFASelfDamage")]
        public long DfaSelfDamage { get; set; }

        [JsonProperty("DFAInstability")]
        public long DfaInstability { get; set; }

        [JsonProperty("Locations")]
        public Location[] Locations { get; set; }

        [JsonProperty("LOSSourcePositions")]
        public LosPosition[] LosSourcePositions { get; set; }

        [JsonProperty("LOSTargetPositions")]
        public LosPosition[] LosTargetPositions { get; set; }

        [JsonProperty("VariantName")]
        public string VariantName { get; set; }

        [JsonProperty("ChassisTags")]
        public ChassisTags ChassisTags { get; set; }

        [JsonProperty("StockRole")]
        public string StockRole { get; set; }

        [JsonProperty("YangsThoughts")]
        public string YangsThoughts { get; set; }
    }

    public partial class ChassisTags
    {
        [JsonProperty("items")]
        public object[] Items { get; set; }

        [JsonProperty("tagSetSourceFile")]
        public string TagSetSourceFile { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("Cost")]
        public long Cost { get; set; }

        [JsonProperty("Rarity")]
        public long Rarity { get; set; }

        [JsonProperty("Purchasable")]
        public bool Purchasable { get; set; }

        [JsonProperty("Manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("UIName")]
        public string UiName { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Details")]
        public string Details { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("Location")]
        public string LocationLocation { get; set; }

        [JsonProperty("Hardpoints")]
        public Hardpoint[] Hardpoints { get; set; }

        [JsonProperty("Tonnage")]
        public long Tonnage { get; set; }

        [JsonProperty("InventorySlots")]
        public long InventorySlots { get; set; }

        [JsonProperty("MaxArmor")]
        public long MaxArmor { get; set; }

        [JsonProperty("MaxRearArmor")]
        public long MaxRearArmor { get; set; }

        [JsonProperty("InternalStructure")]
        public long InternalStructure { get; set; }
    }

    public partial class Hardpoint
    {
        [JsonProperty("WeaponMount")]
        public string WeaponMount { get; set; }

        [JsonProperty("Omni")]
        public bool Omni { get; set; }
    }

    public partial class LosPosition
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public long Z { get; set; }
    }

    public partial class Chassis
    {
        public static Chassis FromJson(string json) => JsonConvert.DeserializeObject<Chassis>(json, Domain.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Chassis self) => JsonConvert.SerializeObject(self, Domain.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
