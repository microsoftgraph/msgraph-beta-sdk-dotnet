using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftTunnelServer : Entity, IParsable {
        /// <summary>The digest of the current agent image running on this server</summary>
        public string AgentImageDigest { get; set; }
        /// <summary>The MicrosoftTunnelServer&apos;s display name</summary>
        public string DisplayName { get; set; }
        /// <summary>When the MicrosoftTunnelServer last checked in</summary>
        public DateTimeOffset? LastCheckinDateTime { get; set; }
        /// <summary>The digest of the current server image running on this server</summary>
        public string ServerImageDigest { get; set; }
        /// <summary>The MicrosoftTunnelServer&apos;s health status. Possible values are: unknown, healthy, unhealthy, warning, offline, upgradeInProgress, upgradeFailed.</summary>
        public MicrosoftTunnelServerHealthStatus? TunnelServerHealthStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftTunnelServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentImageDigest", n => { AgentImageDigest = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastCheckinDateTime", n => { LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"serverImageDigest", n => { ServerImageDigest = n.GetStringValue(); } },
                {"tunnelServerHealthStatus", n => { TunnelServerHealthStatus = n.GetEnumValue<MicrosoftTunnelServerHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("agentImageDigest", AgentImageDigest);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastCheckinDateTime", LastCheckinDateTime);
            writer.WriteStringValue("serverImageDigest", ServerImageDigest);
            writer.WriteEnumValue<MicrosoftTunnelServerHealthStatus>("tunnelServerHealthStatus", TunnelServerHealthStatus);
        }
    }
}
