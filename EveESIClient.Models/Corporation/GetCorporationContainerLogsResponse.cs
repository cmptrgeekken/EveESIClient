﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Corporation
{
    public class GetCorporationContainerLogsResponse
    {
        public DateTime Logget_at { get; set; }
        public Int64 Container_id { get; set; }
        public Int64 Container_type_id { get; set; }
        public Int64 Character_id { get; set; }
        public Int64 Location_id { get; set; }

        /// <summary>
        /// [ AssetSafety, AutoFit, Bonus, Booster, BoosterBay, Capsule, Cargo, 
        /// CorpDeliveries, CorpSAG1, CorpSAG2, CorpSAG3, CorpSAG4, CorpSAG5, 
        /// CorpSAG6, CorpSAG7, CrateLoot, Deliveries, DroneBay, DustBattle, 
        /// DustDatabank, FighterBay, FighterTube0, FighterTube1, 
        /// FighterTube2, FighterTube3, FighterTube4, FleetHangar, 
        /// Hangar, HangarAll, HiSlot0, HiSlot1, HiSlot2, HiSlot3, 
        /// HiSlot4, HiSlot5, HiSlot6, HiSlot7, HiddenModifers, Implant, 
        /// Impounded, JunkyardReprocessed, JunkyardTrashed, LoSlot0, 
        /// LoSlot1, LoSlot2, LoSlot3, LoSlot4, LoSlot5, LoSlot6, LoSlot7, 
        /// Locked, MedSlot0, MedSlot1, MedSlot2, MedSlot3, MedSlot4, MedSlot5, 
        /// MedSlot6, MedSlot7, OfficeFolder, Pilot, PlanetSurface, QuafeBay, Reward, 
        /// RigSlot0, RigSlot1, RigSlot2, RigSlot3, RigSlot4, RigSlot5, RigSlot6, RigSlot7, 
        /// SecondaryStorage, ServiceSlot0, ServiceSlot1, ServiceSlot2, ServiceSlot3, 
        /// ServiceSlot4, ServiceSlot5, ServiceSlot6, ServiceSlot7, ShipHangar, ShipOffline, 
        /// Skill, SkillInTraining, SpecializedAmmoHold, SpecializedCommandCenterHold, SpecializedFuelBay, 
        /// SpecializedGasHold, SpecializedIndustrialShipHold, SpecializedLargeShipHold, 
        /// SpecializedMaterialBay, SpecializedMediumShipHold, SpecializedMineralHold, SpecializedOreHold, 
        /// SpecializedPlanetaryCommoditiesHold, SpecializedSalvageHold, SpecializedShipHold, 
        /// SpecializedSmallShipHold, StructureActive, StructureFuel, StructureInactive, StructureOffline, 
        /// SubSystemSlot0, SubSystemSlot1, SubSystemSlot2, SubSystemSlot3, SubSystemSlot4, SubSystemSlot5, 
        /// SubSystemSlot6, SubSystemSlot7, SubsystemBay, Unlocked, Wallet, Wardrobe ]
        /// </summary>
        public string Location_flag { get; set; }

        /// <summary>
        /// [ add, assemble, configure, enter_password, lock, move, repackage, set_name, set_password, unlock ]
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// [ config, general ]
        /// </summary>
        public string Password_type { get; set; }
        public Int64? Type_id { get; set; }
        public int? Quantity { get; set; }
        public int? Old_config_bitmask { get; set; }
        public int? New_config_bitmask { get; set; }
    }
}
