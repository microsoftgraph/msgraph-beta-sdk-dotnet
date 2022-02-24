using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class TenantDetailedInformation : Entity, IParsable {
        /// <summary>The city where the managed tenant is located. Optional. Read-only.</summary>
        public string City { get; set; }
        /// <summary>The code for the country where the managed tenant is located. Optional. Read-only.</summary>
        public string CountryCode { get; set; }
        /// <summary>The name for the country where the managed tenant is located. Optional. Read-only.</summary>
        public string CountryName { get; set; }
        /// <summary>The default domain name for the managed tenant. Optional. Read-only.</summary>
        public string DefaultDomainName { get; set; }
        /// <summary>The display name for the managed tenant.</summary>
        public string DisplayName { get; set; }
        /// <summary>The business industry associated with the managed tenant. Optional. Read-only.</summary>
        public string IndustryName { get; set; }
        /// <summary>The region where the managed tenant is located. Optional. Read-only.</summary>
        public string Region { get; set; }
        /// <summary>The business segment associated with the managed tenant. Optional. Read-only.</summary>
        public string SegmentName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant.</summary>
        public string TenantId { get; set; }
        /// <summary>The vertical associated with the managed tenant. Optional. Read-only.</summary>
        public string VerticalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"city", (o,n) => { (o as TenantDetailedInformation).City = n.GetStringValue(); } },
                {"countryCode", (o,n) => { (o as TenantDetailedInformation).CountryCode = n.GetStringValue(); } },
                {"countryName", (o,n) => { (o as TenantDetailedInformation).CountryName = n.GetStringValue(); } },
                {"defaultDomainName", (o,n) => { (o as TenantDetailedInformation).DefaultDomainName = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TenantDetailedInformation).DisplayName = n.GetStringValue(); } },
                {"industryName", (o,n) => { (o as TenantDetailedInformation).IndustryName = n.GetStringValue(); } },
                {"region", (o,n) => { (o as TenantDetailedInformation).Region = n.GetStringValue(); } },
                {"segmentName", (o,n) => { (o as TenantDetailedInformation).SegmentName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as TenantDetailedInformation).TenantId = n.GetStringValue(); } },
                {"verticalName", (o,n) => { (o as TenantDetailedInformation).VerticalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteStringValue("countryName", CountryName);
            writer.WriteStringValue("defaultDomainName", DefaultDomainName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("industryName", IndustryName);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("segmentName", SegmentName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("verticalName", VerticalName);
        }
    }
}
