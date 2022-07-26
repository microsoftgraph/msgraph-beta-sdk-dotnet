using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that represents a Microsoft Tunnel site</summary>
    public class MicrosoftTunnelSite : Entity, IParsable {
        /// <summary>The MicrosoftTunnelSite&apos;s description</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The MicrosoftTunnelSite&apos;s display name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The MicrosoftTunnelSite&apos;s Internal Network Access Probe URL</summary>
        public string InternalNetworkProbeUrl {
            get { return BackingStore?.Get<string>("internalNetworkProbeUrl"); }
            set { BackingStore?.Set("internalNetworkProbeUrl", value); }
        }
        /// <summary>The MicrosoftTunnelConfiguration that has been applied to this MicrosoftTunnelSite</summary>
        public Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration MicrosoftTunnelConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>("microsoftTunnelConfiguration"); }
            set { BackingStore?.Set("microsoftTunnelConfiguration", value); }
        }
        /// <summary>A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite</summary>
        public List<MicrosoftTunnelServer> MicrosoftTunnelServers {
            get { return BackingStore?.Get<List<MicrosoftTunnelServer>>("microsoftTunnelServers"); }
            set { BackingStore?.Set("microsoftTunnelServers", value); }
        }
        /// <summary>The MicrosoftTunnelSite&apos;s public domain name or IP address</summary>
        public string PublicAddress {
            get { return BackingStore?.Get<string>("publicAddress"); }
            set { BackingStore?.Set("publicAddress", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The site&apos;s automatic upgrade setting. True for automatic upgrades, false for manual control</summary>
        public bool? UpgradeAutomatically {
            get { return BackingStore?.Get<bool?>("upgradeAutomatically"); }
            set { BackingStore?.Set("upgradeAutomatically", value); }
        }
        /// <summary>True if an upgrade is available</summary>
        public bool? UpgradeAvailable {
            get { return BackingStore?.Get<bool?>("upgradeAvailable"); }
            set { BackingStore?.Set("upgradeAvailable", value); }
        }
        /// <summary>The site&apos;s upgrade window end time of day</summary>
        public Time? UpgradeWindowEndTime {
            get { return BackingStore?.Get<Time?>("upgradeWindowEndTime"); }
            set { BackingStore?.Set("upgradeWindowEndTime", value); }
        }
        /// <summary>The site&apos;s upgrade window start time of day</summary>
        public Time? UpgradeWindowStartTime {
            get { return BackingStore?.Get<Time?>("upgradeWindowStartTime"); }
            set { BackingStore?.Set("upgradeWindowStartTime", value); }
        }
        /// <summary>The site&apos;s timezone represented as a minute offset from UTC</summary>
        public int? UpgradeWindowUtcOffsetInMinutes {
            get { return BackingStore?.Get<int?>("upgradeWindowUtcOffsetInMinutes"); }
            set { BackingStore?.Set("upgradeWindowUtcOffsetInMinutes", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftTunnelSite and sets the default values.
        /// </summary>
        public MicrosoftTunnelSite() : base() {
            OdataType = "#microsoft.graph.microsoftTunnelSite";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"internalNetworkProbeUrl", n => { InternalNetworkProbeUrl = n.GetStringValue(); } },
                {"microsoftTunnelConfiguration", n => { MicrosoftTunnelConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>(Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelServers", n => { MicrosoftTunnelServers = n.GetCollectionOfObjectValues<MicrosoftTunnelServer>(MicrosoftTunnelServer.CreateFromDiscriminatorValue).ToList(); } },
                {"publicAddress", n => { PublicAddress = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"upgradeAutomatically", n => { UpgradeAutomatically = n.GetBoolValue(); } },
                {"upgradeAvailable", n => { UpgradeAvailable = n.GetBoolValue(); } },
                {"upgradeWindowEndTime", n => { UpgradeWindowEndTime = n.GetTimeValue(); } },
                {"upgradeWindowStartTime", n => { UpgradeWindowStartTime = n.GetTimeValue(); } },
                {"upgradeWindowUtcOffsetInMinutes", n => { UpgradeWindowUtcOffsetInMinutes = n.GetIntValue(); } },
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
