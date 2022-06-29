using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class DomainSecurityProfile : Entity, IParsable {
        /// <summary>The activityGroupNames property</summary>
        public List<string> ActivityGroupNames {
            get { return BackingStore?.Get<List<string>>(nameof(ActivityGroupNames)); }
            set { BackingStore?.Set(nameof(ActivityGroupNames), value); }
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
        /// <summary>The countInOrg property</summary>
        public int? CountInOrg {
            get { return BackingStore?.Get<int?>(nameof(CountInOrg)); }
            set { BackingStore?.Set(nameof(CountInOrg), value); }
        }
        /// <summary>The domainCategories property</summary>
        public List<ReputationCategory> DomainCategories {
            get { return BackingStore?.Get<List<ReputationCategory>>(nameof(DomainCategories)); }
            set { BackingStore?.Set(nameof(DomainCategories), value); }
        }
        /// <summary>The domainRegisteredDateTime property</summary>
        public DateTimeOffset? DomainRegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DomainRegisteredDateTime)); }
            set { BackingStore?.Set(nameof(DomainRegisteredDateTime), value); }
        }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FirstSeenDateTime)); }
            set { BackingStore?.Set(nameof(FirstSeenDateTime), value); }
        }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSeenDateTime)); }
            set { BackingStore?.Set(nameof(LastSeenDateTime), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The registrant property</summary>
        public DomainRegistrant Registrant {
            get { return BackingStore?.Get<DomainRegistrant>(nameof(Registrant)); }
            set { BackingStore?.Set(nameof(Registrant), value); }
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
        public static new DomainSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"countHits", n => { CountHits = n.GetIntValue(); } },
                {"countInOrg", n => { CountInOrg = n.GetIntValue(); } },
                {"domainCategories", n => { DomainCategories = n.GetCollectionOfObjectValues<ReputationCategory>(ReputationCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"domainRegisteredDateTime", n => { DomainRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"registrant", n => { Registrant = n.GetObjectValue<DomainRegistrant>(DomainRegistrant.CreateFromDiscriminatorValue); } },
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
