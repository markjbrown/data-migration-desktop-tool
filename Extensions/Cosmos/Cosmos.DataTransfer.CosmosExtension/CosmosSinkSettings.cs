﻿using System.ComponentModel.DataAnnotations;
using Cosmos.DataTransfer.Interfaces;
using Microsoft.Azure.Cosmos;

namespace Cosmos.DataTransfer.CosmosExtension
{
    public class CosmosSinkSettings : IDataExtensionSettings
    {
        [Required]
        public string? ConnectionString { get; set; }
        [Required]
        public string? Database { get; set; }
        [Required]
        public string? Container { get; set; }
        [Required]
        public string? PartitionKeyPath { get; set; }
        public bool RecreateContainer { get; set; }
        public int BatchSize { get; set; } = 100;
        public ConnectionMode ConnectionMode { get; set; } = ConnectionMode.Gateway;
        public int MaxRetryCount { get; set; } = 5;
        public int InitialRetryDurationMs { get; set; } = 200;
        public int? CreatedContainerMaxThroughput { get; set; }
        public bool UseAutoscaleForCreatedContainer { get; set; } = true;
        public bool IsServerlessAccount { get; set; } = false;
        public DataWriteMode WriteMode { get; set; } = DataWriteMode.InsertStream;
    }
}