using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftTunnelSite : Entity, IParsable {
        /// <summary>The MicrosoftTunnelSite&apos;s description</summary>
        public string Description { get; set; }
        /// <summary>The MicrosoftTunnelSite&apos;s display name</summary>
        public string DisplayName { get; set; }
        /// <summary>The MicrosoftTunnelSite&apos;s Internal Network Access Probe URL</summary>
        public string InternalNetworkProbeUrl { get; set; }
        /// <summary>The MicrosoftTunnelConfiguration that has been applied to this MicrosoftTunnelSite</summary>
        public Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration MicrosoftTunnelConfiguration { get; set; }
        /// <summary>A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite</summary>
        public List<MicrosoftTunnelServer> MicrosoftTunnelServers { get; set; }
        /// <summary>The MicrosoftTunnelSite&apos;s public domain name or IP address</summary>
        public string PublicAddress { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The site&apos;s automatic upgrade setting. True for automatic upgrades, false for manual control</summary>
        public bool? UpgradeAutomatically { get; set; }
        /// <summary>True if an upgrade is available</summary>
        public bool? UpgradeAvailable { get; set; }
        /// <summary>The site&apos;s upgrade window end time of day</summary>
        public Time? UpgradeWindowEndTime { get; set; }
        /// <summary>The site&apos;s upgrade window start time of day</summary>
        public Time? UpgradeWindowStartTime { get; set; }
        /// <summary>The site&apos;s timezone represented as a minute offset from UTC</summary>
        public int? UpgradeWindowUtcOffsetInMinutes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftTunnelSite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as MicrosoftTunnelSite).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MicrosoftTunnelSite).DisplayName = n.GetStringValue(); } },
                {"internalNetworkProbeUrl", (o,n) => { (o as MicrosoftTunnelSite).InternalNetworkProbeUrl = n.GetStringValue(); } },
                {"microsoftTunnelConfiguration", (o,n) => { (o as MicrosoftTunnelSite).MicrosoftTunnelConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>(Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelServers", (o,n) => { (o as MicrosoftTunnelSite).MicrosoftTunnelServers = n.GetCollectionOfObjectValues<MicrosoftTunnelServer>(MicrosoftTunnelServer.CreateFromDiscriminatorValue).ToList(); } },
                {"publicAddress", (o,n) => { (o as MicrosoftTunnelSite).PublicAddress = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as MicrosoftTunnelSite).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"upgradeAutomatically", (o,n) => { (o as MicrosoftTunnelSite).UpgradeAutomatically = n.GetBoolValue(); } },
                {"upgradeAvailable", (o,n) => { (o as MicrosoftTunnelSite).UpgradeAvailable = n.GetBoolValue(); } },
                {"upgradeWindowEndTime", (o,n) => { (o as MicrosoftTunnelSite).UpgradeWindowEndTime = n.GetTimeValue(); } },
                {"upgradeWindowStartTime", (o,n) => { (o as MicrosoftTunnelSite).UpgradeWindowStartTime = n.GetTimeValue(); } },
                {"upgradeWindowUtcOffsetInMinutes", (o,n) => { (o as MicrosoftTunnelSite).UpgradeWindowUtcOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("internalNetworkProbeUrl", InternalNetworkProbeUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>("microsoftTunnelConfiguration", MicrosoftTunnelConfiguration);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelServer>("microsoftTunnelServers", MicrosoftTunnelServers);
            writer.WriteStringValue("publicAddress", PublicAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("upgradeAutomatically", UpgradeAutomatically);
            writer.WriteBoolValue("upgradeAvailable", UpgradeAvailable);
            writer.WriteTimeValue("upgradeWindowEndTime", UpgradeWindowEndTime);
            writer.WriteTimeValue("upgradeWindowStartTime", UpgradeWindowStartTime);
            writer.WriteIntValue("upgradeWindowUtcOffsetInMinutes", UpgradeWindowUtcOffsetInMinutes);
        }
    }
}
