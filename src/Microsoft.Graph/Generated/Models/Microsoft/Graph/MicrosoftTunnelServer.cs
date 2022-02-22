using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MicrosoftTunnelServer : Entity, IParsable {
        /// <summary>The digest of the current agent image running on this server</summary>
        public string AgentImageDigest { get; set; }
        /// <summary>The MicrosoftTunnelServer's display name</summary>
        public string DisplayName { get; set; }
        /// <summary>When the MicrosoftTunnelServer last checked in</summary>
        public DateTimeOffset? LastCheckinDateTime { get; set; }
        /// <summary>The digest of the current server image running on this server</summary>
        public string ServerImageDigest { get; set; }
        /// <summary>The MicrosoftTunnelServer's health status. Possible values are: unknown, healthy, unhealthy, warning, offline, upgradeInProgress, upgradeFailed.</summary>
        public MicrosoftTunnelServerHealthStatus? TunnelServerHealthStatus { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agentImageDigest", (o,n) => { (o as MicrosoftTunnelServer).AgentImageDigest = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MicrosoftTunnelServer).DisplayName = n.GetStringValue(); } },
                {"lastCheckinDateTime", (o,n) => { (o as MicrosoftTunnelServer).LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"serverImageDigest", (o,n) => { (o as MicrosoftTunnelServer).ServerImageDigest = n.GetStringValue(); } },
                {"tunnelServerHealthStatus", (o,n) => { (o as MicrosoftTunnelServer).TunnelServerHealthStatus = n.GetEnumValue<MicrosoftTunnelServerHealthStatus>(); } },
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
