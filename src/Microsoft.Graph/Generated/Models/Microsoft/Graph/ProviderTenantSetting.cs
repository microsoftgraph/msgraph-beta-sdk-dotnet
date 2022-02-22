using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ProviderTenantSetting : Entity, IParsable {
        public string AzureTenantId { get; set; }
        public bool? Enabled { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Provider { get; set; }
        public string Vendor { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"azureTenantId", (o,n) => { (o as ProviderTenantSetting).AzureTenantId = n.GetStringValue(); } },
                {"enabled", (o,n) => { (o as ProviderTenantSetting).Enabled = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ProviderTenantSetting).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"provider", (o,n) => { (o as ProviderTenantSetting).Provider = n.GetStringValue(); } },
                {"vendor", (o,n) => { (o as ProviderTenantSetting).Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("vendor", Vendor);
        }
    }
}
