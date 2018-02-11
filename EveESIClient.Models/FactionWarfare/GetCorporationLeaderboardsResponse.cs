﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.FactionWarfare
{
    public class GetCorporationLeaderboardsResponse
    {
        public LeaderBoardKills Kills { get; set; }
        public LeaderboardVictoryPoints Victory_points { get; set; }


        public class LeaderBoardKills
        {
            public List<LeaderBoardKillAmount> Yesterday { get; set; }
            public List<LeaderBoardKillAmount> Last_week { get; set; }
            public List<LeaderBoardKillAmount> Active_total { get; set; }
        }

        public class LeaderBoardKillAmount
        {
            public Int64 Corporation_id { get; set; }
            public int Amount { get; set; }
        }

        public class LeaderboardVictoryPoints
        {
            public List<LeaderBoardKillAmount> Yesterday { get; set; }
            public List<LeaderBoardKillAmount> Last_week { get; set; }
            public List<LeaderBoardKillAmount> Active_total { get; set; }
        }
    }
}
