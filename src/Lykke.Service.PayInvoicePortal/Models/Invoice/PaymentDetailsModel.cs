﻿using System;
using System.Collections.Generic;
using Lykke.Service.PayInternal.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Lykke.Service.PayInvoicePortal.Models.Invoice
{
    public class PaymentDetailsModel
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public string Status { get; set; }

        public string MerchantId { get; set; }

        public string Merchant { get; set; }

        public double PaymentAmount { get; set; }

        public double SettlementAmount { get; set; }

        public string PaymentAssetId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public BlockchainType PaymentAssetNetwork { get; set; }

        public string PaymentAssetDisplay { get; set; }

        public string SettlementAssetId { get; set; }

        public string SettlementAssetDisplay { get; set; }

        public int PaymentAssetAccuracy { get; set; }

        public int SettlementAssetAccuracy { get; set; }

        public double ExchangeRate { get; set; }

        public bool DeltaSpread { get; set; }

        public double Percents { get; set; }

        public int Pips { get; set; }

        public double Fee { get; set; }

        public DateTime DueDate { get; set; }

        public string Note { get; set; }

        public string WalletAddress { get; set; }

        public string PaymentRequestId { get; set; }

        public int TotalSeconds { get; set; }

        public int RemainingSeconds { get; set; }

        public int ExtendedTotalSeconds { get; set; }

        public int ExtendedRemainingSeconds { get; set; }

        public DateTime? PaidDate { get; set; }

        public double PaidAmount { get; set; }

        public IReadOnlyList<FileModel> Files { get; set; }
    }
}
