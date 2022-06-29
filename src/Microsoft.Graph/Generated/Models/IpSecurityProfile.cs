using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class IpSecurityProfile : Entity, IParsable {
        /// <summary>The activityGroupNames property</summary>
        public List<string> ActivityGroupNames {
            get { return BackingStore?.Get<List<string>>(nameof(ActivityGroupNames)); }
            set { BackingStore?.Set(nameof(ActivityGroupNames), value); }
        }
        /// <summary>The address property</summary>
        public string Address {
            get { return BackingStore?.Get<string>(nameof(Address)); }
            set { BackingStore?.Set(nameof(Address), value); }
        }
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>(nameof(AzureSubscriptionId)); }
            set { BackingStore?.Set(nameof(AzureSubscriptionId), value); }
        }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>(nameof(AzureTenantId)); }
            set { BackingStore?.Set(nameof(AzureTenantId), value); }
        }
        /// <summary>The countHits property</summary>
        public int? CountHits {
            get { return BackingStore?.Get<int?>(nameof(CountHits)); }
            set { BackingStore?.Set(nameof(CountHits), value); }
        }
        /// <summary>The countHosts property</summary>
        public int? CountHosts {
            get { return BackingStore?.Get<int?>(nameof(CountHosts)); }
            set { BackingStore?.Set(nameof(CountHosts), value); }
        }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FirstSeenDateTime)); }
            set { BackingStore?.Set(nameof(FirstSeenDateTime), value); }
        }
        /// <summary>The ipCategories property</summary>
        public List<IpCategory> IpCategories {
            get { return BackingStore?.Get<List<IpCategory>>(nameof(IpCategories)); }
            set { BackingStore?.Set(nameof(IpCategories), value); }
        }
        /// <summary>The ipReferenceData property</summary>
        public List<Microsoft.Graph.Beta.Models.IpReferenceData> IpReferenceData {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IpReferenceData>>(nameof(IpReferenceData)); }
            set { BackingStore?.Set(nameof(IpReferenceData), value); }
        }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSeenDateTime)); }
            set { BackingStore?.Set(nameof(LastSeenDateTime), value); }
        }
        /// <summary>The riskScore property</summary>
        public string RiskScore {
            get { return BackingStore?.Get<string>(nameof(RiskScore)); }
            set { BackingStore?.Set(nameof(RiskScore), value); }
        }
        /// <summary>The tags property</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>(nameof(VendorInformation)); }
            set { BackingStore?.Set(nameof(VendorInformation), value); }
        }
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
