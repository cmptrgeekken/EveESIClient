﻿using System;

namespace EveESIClient.Models.Contracts
{
    public class GetCorporationContractBidsResponse
    {
        public Int64 Bid_id { get; set; }
        public Int64 Bidder_id { get; set; }
        public string Date_bid { get; set; }
        public float Amount { get; set; }
    }
}