using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that stores the server log collection status.</summary>
    public class MicrosoftTunnelServerLogCollectionResponse : Entity, IParsable {
        /// <summary>The end time of the logs collected</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The time when the log collection is expired</summary>
        public DateTimeOffset? ExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expiryDateTime"); }
            set { BackingStore?.Set("expiryDateTime", value); }
        }
        /// <summary>The time when the log collection was requested</summary>
        public DateTimeOffset? RequestDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("requestDateTime"); }
            set { BackingStore?.Set("requestDateTime", value); }
        }
        /// <summary>ID of the server the log collection is requested upon</summary>
        public string ServerId {
            get { return BackingStore?.Get<string>("serverId"); }
            set { BackingStore?.Set("serverId", value); }
        }
        /// <summary>The size of the logs in bytes</summary>
        public long? SizeInBytes {
            get { return BackingStore?.Get<long?>("sizeInBytes"); }
            set { BackingStore?.Set("sizeInBytes", value); }
        }
        /// <summary>The start time of the logs collected</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Enum type that represent the status of log collection.</summary>
        public MicrosoftTunnelLogCollectionStatus? Status {
            get { return BackingStore?.Get<MicrosoftTunnelLogCollectionStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftTunnelServerLogCollectionResponse and sets the default values.
        /// </summary>
        public MicrosoftTunnelServerLogCollectionResponse() : base() {
            OdataType = "#microsoft.graph.microsoftTunnelServerLogCollectionResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftTunnelServerLogCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelServerLogCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"expiryDateTime", n => { ExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                {"serverId", n => { ServerId = n.GetStringValue(); } },
                {"sizeInBytes", n => { SizeInBytes = n.GetLongValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<MicrosoftTunnelLogCollectionStatus>(); } },
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
