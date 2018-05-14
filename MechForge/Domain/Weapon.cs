﻿using Newtonsoft.Json;

namespace MechForge.Domain
{
    public class Weapon
    {
        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "WeaponSubType")]
        public string WeaponSubType { get; set; }

        /*
         * {
    "Category" : "Ballistic",
    "Type" : "Autocannon",
    "WeaponSubType" : "AC2",
    "MinRange" : 120,
    "MaxRange" : 720,
    "RangeSplit" : [
        480,
        480,
        720
    ],
    "AmmoCategory" : "AC2",
    "StartingAmmoCapacity" : 0,
    "HeatGenerated" : 5,
    "Damage" : 25,
    "OverheatedDamageMultiplier" : 0,
    "EvasiveDamageMultiplier" : 0,
    "EvasivePipsIgnored" : 0,
    "DamageVariance" : 0,
    "HeatDamage" : 0,
    "AccuracyModifier" : 0,
    "CriticalChanceMultiplier" : 1.25,
    "AOECapable" : false,
    "IndirectFireCapable" : false,
    "RefireModifier" : 1,
    "ShotsWhenFired" : 1,
    "ProjectilesPerShot" : 3,
    "AttackRecoil" : 1,
    "Instability" : 5,
    "WeaponEffectID" : "WeaponEffect-Weapon_AC2",
    "Description" : {
        "Cost" : 60000,
        "Rarity" : 1,
        "Purchasable" : true,
        "Manufacturer" : "Federated",
        "Model" : "Sniper Autocannon",
        "UIName" : "AC/2 +",
        "Id" : "Weapon_Autocannon_AC2_1-Federated",
        "Name" : "AC/2 +",
        "Details" : "Intended for use as supporting fire at very long range, AC/2s deal moderate damage with low heat and a large ammunition count per ton. Like all Autocannon weaponry, AC/2s suffer from recoil effects from continuous fire.",
        "Icon" : "uixSvgIcon_weapon_Ballistic"
    },
    "BonusValueA" : "+ 25% Crit.",
    "BonusValueB" : "",
    "ComponentType" : "Weapon",
    "ComponentSubType" : "Weapon",
    "PrefabIdentifier" : "AC2",
    "BattleValue" : 0,
    "InventorySize" : 1,
    "Tonnage" : 6,
    "AllowedLocations" : "All",
    "DisallowedLocations" : "All",
    "CriticalComponent" : false,
    "statusEffects" : [
        
    ],
    "ComponentTags" : {
        "items" : [
            "component_type_variant",
            "component_type_variant1",
            "range_extreme"
        ],
        "tagSetSourceFile" : ""
    }
}

         */


    }
}