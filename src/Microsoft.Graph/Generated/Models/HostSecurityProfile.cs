using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class HostSecurityProfile : Entity, IParsable {
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The fqdn property</summary>
        public string Fqdn {
            get { return BackingStore?.Get<string>("fqdn"); }
            set { BackingStore?.Set("fqdn", value); }
        }
        /// <summary>The isAzureAdJoined property</summary>
        public bool? IsAzureAdJoined {
            get { return BackingStore?.Get<bool?>("isAzureAdJoined"); }
            set { BackingStore?.Set("isAzureAdJoined", value); }
        }
        /// <summary>The isAzureAdRegistered property</summary>
        public bool? IsAzureAdRegistered {
            get { return BackingStore?.Get<bool?>("isAzureAdRegistered"); }
            set { BackingStore?.Set("isAzureAdRegistered", value); }
        }
        /// <summary>The isHybridAzureDomainJoined property</summary>
        public bool? IsHybridAzureDomainJoined {
            get { return BackingStore?.Get<bool?>("isHybridAzureDomainJoined"); }
            set { BackingStore?.Set("isHybridAzureDomainJoined", value); }
        }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The logonUsers property</summary>
        public List<LogonUser> LogonUsers {
            get { return BackingStore?.Get<List<LogonUser>>("logonUsers"); }
            set { BackingStore?.Set("logonUsers", value); }
        }
        /// <summary>The netBiosName property</summary>
        public string NetBiosName {
            get { return BackingStore?.Get<string>("netBiosName"); }
            set { BackingStore?.Set("netBiosName", value); }
        }
        /// <summary>The networkInterfaces property</summary>
        public List<NetworkInterface> NetworkInterfaces {
            get { return BackingStore?.Get<List<NetworkInterface>>("networkInterfaces"); }
            set { BackingStore?.Set("networkInterfaces", value); }
        }
        /// <summary>The os property</summary>
        public string Os {
            get { return BackingStore?.Get<string>("os"); }
            set { BackingStore?.Set("os", value); }
        }
        /// <summary>The osVersion property</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>The parentHost property</summary>
        public string ParentHost {
            get { return BackingStore?.Get<string>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
        /// <summary>The relatedHostIds property</summary>
        public List<string> RelatedHostIds {
            get { return BackingStore?.Get<List<string>>("relatedHostIds"); }
            set { BackingStore?.Set("relatedHostIds", value); }
        }
        /// <summary>The riskScore property</summary>
        public string RiskScore {
            get { return BackingStore?.Get<string>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
        /// <summary>The tags property</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
        /// <summary>
        /// Instantiates a new hostSecurityProfile and sets the default values.
        /// </summary>
        public HostSecurityProfile() : base() {
            OdataType = "#microsoft.graph.hostSecurityProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new HostSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"fqdn", n => { Fqdn = n.GetStringValue(); } },
                {"isAzureAdJoined", n => { IsAzureAdJoined = n.GetBoolValue(); } },
                {"isAzureAdRegistered", n => { IsAzureAdRegistered = n.GetBoolValue(); } },
                {"isHybridAzureDomainJoined", n => { IsHybridAzureDomainJoined = n.GetBoolValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonUsers", n => { LogonUsers = n.GetCollectionOfObjectValues<LogonUser>(LogonUser.CreateFromDiscriminatorValue).ToList(); } },
                {"netBiosName", n => { NetBiosName = n.GetStringValue(); } },
                {"networkInterfaces", n => { NetworkInterfaces = n.GetCollectionOfObjectValues<NetworkInterface>(NetworkInterface.CreateFromDiscriminatorValue).ToList(); } },
                {"os", n => { Os = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"parentHost", n => { ParentHost = n.GetStringValue(); } },
                {"relatedHostIds", n => { RelatedHostIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteStringValue("fqdn", Fqdn);
            writer.WriteBoolValue("isAzureAdJoined", IsAzureAdJoined);
            writer.WriteBoolValue("isAzureAdRegistered", IsAzureAdRegistered);
            writer.WriteBoolValue("isHybridAzureDomainJoined", IsHybridAzureDomainJoined);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<LogonUser>("logonUsers", LogonUsers);
            writer.WriteStringValue("netBiosName", NetBiosName);
            writer.WriteCollectionOfObjectValues<NetworkInterface>("networkInterfaces", NetworkInterfaces);
            writer.WriteStringValue("os", Os);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("parentHost", ParentHost);
            writer.WriteCollectionOfPrimitiveValues<string>("relatedHostIds", RelatedHostIds);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
