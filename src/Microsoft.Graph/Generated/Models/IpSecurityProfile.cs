using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IpSecurityProfile : Entity, IParsable {
        /// <summary>The activityGroupNames property</summary>
        public List<string> ActivityGroupNames { get; set; }
        /// <summary>The address property</summary>
        public string Address { get; set; }
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The countHits property</summary>
        public int? CountHits { get; set; }
        /// <summary>The countHosts property</summary>
        public int? CountHosts { get; set; }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The ipCategories property</summary>
        public List<IpCategory> IpCategories { get; set; }
        /// <summary>The ipReferenceData property</summary>
        public List<Microsoft.Graph.Beta.Models.IpReferenceData> IpReferenceData { get; set; }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
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
        public static new IpSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"address", n => { Address = n.GetStringValue(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"countHits", n => { CountHits = n.GetIntValue(); } },
                {"countHosts", n => { CountHosts = n.GetIntValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"ipCategories", n => { IpCategories = n.GetCollectionOfObjectValues<IpCategory>(IpCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"ipReferenceData", n => { IpReferenceData = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IpReferenceData>(Microsoft.Graph.Beta.Models.IpReferenceData.CreateFromDiscriminatorValue).ToList(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IpReferenceData>("ipReferenceData", IpReferenceData);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
