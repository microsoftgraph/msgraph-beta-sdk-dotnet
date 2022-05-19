using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class HostSecurityProfile : Entity, IParsable {
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
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FirstSeenDateTime)); }
            set { BackingStore?.Set(nameof(FirstSeenDateTime), value); }
        }
        /// <summary>The fqdn property</summary>
        public string Fqdn {
            get { return BackingStore?.Get<string>(nameof(Fqdn)); }
            set { BackingStore?.Set(nameof(Fqdn), value); }
        }
        /// <summary>The isAzureAdJoined property</summary>
        public bool? IsAzureAdJoined {
            get { return BackingStore?.Get<bool?>(nameof(IsAzureAdJoined)); }
            set { BackingStore?.Set(nameof(IsAzureAdJoined), value); }
        }
        /// <summary>The isAzureAdRegistered property</summary>
        public bool? IsAzureAdRegistered {
            get { return BackingStore?.Get<bool?>(nameof(IsAzureAdRegistered)); }
            set { BackingStore?.Set(nameof(IsAzureAdRegistered), value); }
        }
        /// <summary>The isHybridAzureDomainJoined property</summary>
        public bool? IsHybridAzureDomainJoined {
            get { return BackingStore?.Get<bool?>(nameof(IsHybridAzureDomainJoined)); }
            set { BackingStore?.Set(nameof(IsHybridAzureDomainJoined), value); }
        }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSeenDateTime)); }
            set { BackingStore?.Set(nameof(LastSeenDateTime), value); }
        }
        /// <summary>The logonUsers property</summary>
        public List<LogonUser> LogonUsers {
            get { return BackingStore?.Get<List<LogonUser>>(nameof(LogonUsers)); }
            set { BackingStore?.Set(nameof(LogonUsers), value); }
        }
        /// <summary>The netBiosName property</summary>
        public string NetBiosName {
            get { return BackingStore?.Get<string>(nameof(NetBiosName)); }
            set { BackingStore?.Set(nameof(NetBiosName), value); }
        }
        /// <summary>The networkInterfaces property</summary>
        public List<NetworkInterface> NetworkInterfaces {
            get { return BackingStore?.Get<List<NetworkInterface>>(nameof(NetworkInterfaces)); }
            set { BackingStore?.Set(nameof(NetworkInterfaces), value); }
        }
        /// <summary>The os property</summary>
        public string Os {
            get { return BackingStore?.Get<string>(nameof(Os)); }
            set { BackingStore?.Set(nameof(Os), value); }
        }
        /// <summary>The osVersion property</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>The parentHost property</summary>
        public string ParentHost {
            get { return BackingStore?.Get<string>(nameof(ParentHost)); }
            set { BackingStore?.Set(nameof(ParentHost), value); }
        }
        /// <summary>The relatedHostIds property</summary>
        public List<string> RelatedHostIds {
            get { return BackingStore?.Get<List<string>>(nameof(RelatedHostIds)); }
            set { BackingStore?.Set(nameof(RelatedHostIds), value); }
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
