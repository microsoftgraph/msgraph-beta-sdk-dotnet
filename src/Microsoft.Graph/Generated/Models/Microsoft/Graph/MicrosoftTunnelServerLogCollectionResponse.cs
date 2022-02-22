using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MicrosoftTunnelServerLogCollectionResponse : Entity, IParsable {
        /// <summary>The end time of the logs collected</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The time when the log collection is expired</summary>
        public DateTimeOffset? ExpiryDateTime { get; set; }
        /// <summary>The time when the log collection was requested</summary>
        public DateTimeOffset? RequestDateTime { get; set; }
        /// <summary>ID of the server the log collection is requested upon</summary>
        public string ServerId { get; set; }
        /// <summary>The size of the logs in bytes</summary>
        public long? SizeInBytes { get; set; }
        /// <summary>The start time of the logs collected</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The status of log collection. Possible values are: pending, completed, failed.</summary>
        public MicrosoftTunnelLogCollectionStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"endDateTime", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"expiryDateTime", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).ExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestDateTime", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).RequestDateTime = n.GetDateTimeOffsetValue(); } },
                {"serverId", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).ServerId = n.GetStringValue(); } },
                {"sizeInBytes", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).SizeInBytes = n.GetLongValue(); } },
                {"startDateTime", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as MicrosoftTunnelServerLogCollectionResponse).Status = n.GetEnumValue<MicrosoftTunnelLogCollectionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("expiryDateTime", ExpiryDateTime);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteStringValue("serverId", ServerId);
            writer.WriteLongValue("sizeInBytes", SizeInBytes);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<MicrosoftTunnelLogCollectionStatus>("status", Status);
        }
    }
}
