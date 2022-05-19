using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
    public class Session : Entity, IParsable {
        /// <summary>Endpoint that answered the session.</summary>
        public Endpoint Callee {
            get { return BackingStore?.Get<Endpoint>(nameof(Callee)); }
            set { BackingStore?.Set(nameof(Callee), value); }
        }
        /// <summary>Endpoint that initiated the session.</summary>
        public Endpoint Caller {
            get { return BackingStore?.Get<Endpoint>(nameof(Caller)); }
            set { BackingStore?.Set(nameof(Caller), value); }
        }
        /// <summary>UTC time when the last user left the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>Failure information associated with the session if the session failed.</summary>
        public Microsoft.Graph.Beta.Models.CallRecords.FailureInfo FailureInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.FailureInfo>(nameof(FailureInfo)); }
            set { BackingStore?.Set(nameof(FailureInfo), value); }
        }
        /// <summary>List of modalities present in the session. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.</summary>
        public List<string> Modalities {
            get { return BackingStore?.Get<List<string>>(nameof(Modalities)); }
            set { BackingStore?.Set(nameof(Modalities), value); }
        }
        /// <summary>The list of segments involved in the session. Read-only. Nullable.</summary>
        public List<Segment> Segments {
            get { return BackingStore?.Get<List<Segment>>(nameof(Segments)); }
            set { BackingStore?.Set(nameof(Segments), value); }
        }
        /// <summary>UTC fime when the first user joined the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Session CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Session();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callee", n => { Callee = n.GetObjectValue<Endpoint>(Endpoint.CreateFromDiscriminatorValue); } },
                {"caller", n => { Caller = n.GetObjectValue<Endpoint>(Endpoint.CreateFromDiscriminatorValue); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureInfo", n => { FailureInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallRecords.FailureInfo>(Microsoft.Graph.Beta.Models.CallRecords.FailureInfo.CreateFromDiscriminatorValue); } },
                {"modalities", n => { Modalities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"segments", n => { Segments = n.GetCollectionOfObjectValues<Segment>(Segment.CreateFromDiscriminatorValue).ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Endpoint>("callee", Callee);
            writer.WriteObjectValue<Endpoint>("caller", Caller);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CallRecords.FailureInfo>("failureInfo", FailureInfo);
            writer.WriteCollectionOfPrimitiveValues<string>("modalities", Modalities);
            writer.WriteCollectionOfObjectValues<Segment>("segments", Segments);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
