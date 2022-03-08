using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the hostSecurityProfiles property of the microsoft.graph.security entity.</summary>
    public class HostSecurityProfile : Entity, IParsable {
        public string AzureSubscriptionId { get; set; }
        public string AzureTenantId { get; set; }
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        public string Fqdn { get; set; }
        public bool? IsAzureAdJoined { get; set; }
        public bool? IsAzureAdRegistered { get; set; }
        public bool? IsHybridAzureDomainJoined { get; set; }
        public DateTimeOffset? LastSeenDateTime { get; set; }
        public List<LogonUser> LogonUsers { get; set; }
        public string NetBiosName { get; set; }
        public List<NetworkInterface> NetworkInterfaces { get; set; }
        public string Os { get; set; }
        public string OsVersion { get; set; }
        public string ParentHost { get; set; }
        public List<string> RelatedHostIds { get; set; }
        public string RiskScore { get; set; }
        public List<string> Tags { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"azureSubscriptionId", (o,n) => { (o as HostSecurityProfile).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as HostSecurityProfile).AzureTenantId = n.GetStringValue(); } },
                {"firstSeenDateTime", (o,n) => { (o as HostSecurityProfile).FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"fqdn", (o,n) => { (o as HostSecurityProfile).Fqdn = n.GetStringValue(); } },
                {"isAzureAdJoined", (o,n) => { (o as HostSecurityProfile).IsAzureAdJoined = n.GetBoolValue(); } },
                {"isAzureAdRegistered", (o,n) => { (o as HostSecurityProfile).IsAzureAdRegistered = n.GetBoolValue(); } },
                {"isHybridAzureDomainJoined", (o,n) => { (o as HostSecurityProfile).IsHybridAzureDomainJoined = n.GetBoolValue(); } },
                {"lastSeenDateTime", (o,n) => { (o as HostSecurityProfile).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonUsers", (o,n) => { (o as HostSecurityProfile).LogonUsers = n.GetCollectionOfObjectValues<LogonUser>(LogonUser.CreateFromDiscriminatorValue).ToList(); } },
                {"netBiosName", (o,n) => { (o as HostSecurityProfile).NetBiosName = n.GetStringValue(); } },
                {"networkInterfaces", (o,n) => { (o as HostSecurityProfile).NetworkInterfaces = n.GetCollectionOfObjectValues<NetworkInterface>(NetworkInterface.CreateFromDiscriminatorValue).ToList(); } },
                {"os", (o,n) => { (o as HostSecurityProfile).Os = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as HostSecurityProfile).OsVersion = n.GetStringValue(); } },
                {"parentHost", (o,n) => { (o as HostSecurityProfile).ParentHost = n.GetStringValue(); } },
                {"relatedHostIds", (o,n) => { (o as HostSecurityProfile).RelatedHostIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskScore", (o,n) => { (o as HostSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as HostSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", (o,n) => { (o as HostSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
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
