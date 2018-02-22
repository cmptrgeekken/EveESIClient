﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Market
{
    public class GetCorporationOpenOrdersResponse
    {
        public long Order_id { get; set; }
        public int Type_id { get; set; }
        public int Region_id { get; set; }
        public long Location_id { get; set; }
        public string Range { get; set; }
        public bool Is_buy_order { get; set; }
        public double Price { get; set; }
        public int Volume_total { get; set; }
        public int Volume_remain { get; set; }
        public DateTime Issued { get; set; }
        public string State { get; set; }
        public int Min_volume { get; set; }
        public int Wallet_division { get; set; }
        public int Duration { get; set; }
        public double Escrow { get; set; }
    }
}
