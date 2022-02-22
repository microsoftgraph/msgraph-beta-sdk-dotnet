using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class IpSecurityProfile : Entity, IParsable {
        public List<string> ActivityGroupNames { get; set; }
        public string Address { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string AzureTenantId { get; set; }
        public int? CountHits { get; set; }
        public int? CountHosts { get; set; }
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        public List<IpCategory> IpCategories { get; set; }
        public List<IpReferenceData> IpReferenceData { get; set; }
        public DateTimeOffset? LastSeenDateTime { get; set; }
        public string RiskScore { get; set; }
        public List<string> Tags { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityGroupNames", (o,n) => { (o as IpSecurityProfile).ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"address", (o,n) => { (o as IpSecurityProfile).Address = n.GetStringValue(); } },
                {"azureSubscriptionId", (o,n) => { (o as IpSecurityProfile).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as IpSecurityProfile).AzureTenantId = n.GetStringValue(); } },
                {"countHits", (o,n) => { (o as IpSecurityProfile).CountHits = n.GetIntValue(); } },
                {"countHosts", (o,n) => { (o as IpSecurityProfile).CountHosts = n.GetIntValue(); } },
                {"firstSeenDateTime", (o,n) => { (o as IpSecurityProfile).FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"ipCategories", (o,n) => { (o as IpSecurityProfile).IpCategories = n.GetCollectionOfObjectValues<IpCategory>().ToList(); } },
                {"ipReferenceData", (o,n) => { (o as IpSecurityProfile).IpReferenceData = n.GetCollectionOfObjectValues<IpReferenceData>().ToList(); } },
                {"lastSeenDateTime", (o,n) => { (o as IpSecurityProfile).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", (o,n) => { (o as IpSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as IpSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", (o,n) => { (o as IpSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteIntValue("countHits", CountHits);
            writer.WriteIntValue("countHosts", CountHosts);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteCollectionOfObjectValues<IpCategory>("ipCategories", IpCategories);
            writer.WriteCollectionOfObjectValues<IpReferenceData>("ipReferenceData", IpReferenceData);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
