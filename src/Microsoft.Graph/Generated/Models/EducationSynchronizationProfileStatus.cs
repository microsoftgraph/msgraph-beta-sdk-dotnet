using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationProfileStatus : Entity, IParsable {
        /// <summary>Number of errors during synchronization.</summary>
        public long? ErrorCount {
            get { return BackingStore?.Get<long?>("errorCount"); }
            set { BackingStore?.Set("errorCount", value); }
        }
        /// <summary>Date and time when most recent changes were observed in the profile.</summary>
        public DateTimeOffset? LastActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActivityDateTime"); }
            set { BackingStore?.Set("lastActivityDateTime", value); }
        }
        /// <summary>Date and time of the most recent successful synchronization.</summary>
        public DateTimeOffset? LastSynchronizationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSynchronizationDateTime"); }
            set { BackingStore?.Set("lastSynchronizationDateTime", value); }
        }
        /// <summary>The status of a sync. The possible values are: paused, inProgress, success, error, validationError, quarantined, unknownFutureValue, extracting, validating. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: extracting, validating.</summary>
        public EducationSynchronizationStatus? Status {
            get { return BackingStore?.Get<EducationSynchronizationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Status message for the synchronization stage of the current profile.</summary>
        public string StatusMessage {
            get { return BackingStore?.Get<string>("statusMessage"); }
            set { BackingStore?.Set("statusMessage", value); }
        }
        /// <summary>
        /// Instantiates a new educationSynchronizationProfileStatus and sets the default values.
        /// </summary>
        public EducationSynchronizationProfileStatus() : base() {
            OdataType = "#microsoft.graph.educationSynchronizationProfileStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSynchronizationProfileStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationProfileStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errorCount", n => { ErrorCount = n.GetLongValue(); } },
                {"lastActivityDateTime", n => { LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSynchronizationDateTime", n => { LastSynchronizationDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<EducationSynchronizationStatus>(); } },
                {"statusMessage", n => { StatusMessage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("errorCount", ErrorCount);
            writer.WriteDateTimeOffsetValue("lastActivityDateTime", LastActivityDateTime);
            writer.WriteDateTimeOffsetValue("lastSynchronizationDateTime", LastSynchronizationDateTime);
            writer.WriteEnumValue<EducationSynchronizationStatus>("status", Status);
            writer.WriteStringValue("statusMessage", StatusMessage);
        }
    }
}
