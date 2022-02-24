using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DomainSecurityProfile : Entity, IParsable {
        public List<string> ActivityGroupNames { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string AzureTenantId { get; set; }
        public int? CountHits { get; set; }
        public int? CountInOrg { get; set; }
        public List<ReputationCategory> DomainCategories { get; set; }
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        public DateTimeOffset? LastSeenDateTime { get; set; }
        public string Name { get; set; }
        public DomainRegistrant Registrant { get; set; }
        public string RiskScore { get; set; }
        public List<string> Tags { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityGroupNames", (o,n) => { (o as DomainSecurityProfile).ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"azureSubscriptionId", (o,n) => { (o as DomainSecurityProfile).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as DomainSecurityProfile).AzureTenantId = n.GetStringValue(); } },
                {"countHits", (o,n) => { (o as DomainSecurityProfile).CountHits = n.GetIntValue(); } },
                {"countInOrg", (o,n) => { (o as DomainSecurityProfile).CountInOrg = n.GetIntValue(); } },
                {"domainCategories", (o,n) => { (o as DomainSecurityProfile).DomainCategories = n.GetCollectionOfObjectValues<ReputationCategory>().ToList(); } },
                {"domainRegisteredDateTime", (o,n) => { (o as DomainSecurityProfile).DomainRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"firstSeenDateTime", (o,n) => { (o as DomainSecurityProfile).FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", (o,n) => { (o as DomainSecurityProfile).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as DomainSecurityProfile).Name = n.GetStringValue(); } },
                {"registrant", (o,n) => { (o as DomainSecurityProfile).Registrant = n.GetObjectValue<DomainRegistrant>(); } },
                {"riskScore", (o,n) => { (o as DomainSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as DomainSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", (o,n) => { (o as DomainSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
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
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteIntValue("countHits", CountHits);
            writer.WriteIntValue("countInOrg", CountInOrg);
            writer.WriteCollectionOfObjectValues<ReputationCategory>("domainCategories", DomainCategories);
            writer.WriteDateTimeOffsetValue("domainRegisteredDateTime", DomainRegisteredDateTime);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<DomainRegistrant>("registrant", Registrant);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
