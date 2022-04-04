using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DomainSecurityProfile : Entity, IParsable {
        /// <summary>The activityGroupNames property</summary>
        public List<string> ActivityGroupNames { get; set; }
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The countHits property</summary>
        public int? CountHits { get; set; }
        /// <summary>The countInOrg property</summary>
        public int? CountInOrg { get; set; }
        /// <summary>The domainCategories property</summary>
        public List<ReputationCategory> DomainCategories { get; set; }
        /// <summary>The domainRegisteredDateTime property</summary>
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The registrant property</summary>
        public DomainRegistrant Registrant { get; set; }
        /// <summary>The riskScore property</summary>
        public string RiskScore { get; set; }
        /// <summary>The tags property</summary>
        public List<string> Tags { get; set; }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DomainSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainSecurityProfile();
        }
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
                {"domainCategories", (o,n) => { (o as DomainSecurityProfile).DomainCategories = n.GetCollectionOfObjectValues<ReputationCategory>(ReputationCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"domainRegisteredDateTime", (o,n) => { (o as DomainSecurityProfile).DomainRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"firstSeenDateTime", (o,n) => { (o as DomainSecurityProfile).FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", (o,n) => { (o as DomainSecurityProfile).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as DomainSecurityProfile).Name = n.GetStringValue(); } },
                {"registrant", (o,n) => { (o as DomainSecurityProfile).Registrant = n.GetObjectValue<DomainRegistrant>(DomainRegistrant.CreateFromDiscriminatorValue); } },
                {"riskScore", (o,n) => { (o as DomainSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as DomainSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", (o,n) => { (o as DomainSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
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
