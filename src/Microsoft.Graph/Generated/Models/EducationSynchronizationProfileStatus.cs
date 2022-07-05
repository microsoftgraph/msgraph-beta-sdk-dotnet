using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class EducationSynchronizationProfileStatus : Entity, IParsable {
        /// <summary>Number of errors during synchronization.</summary>
        public long? ErrorCount {
            get { return BackingStore?.Get<long?>(nameof(ErrorCount)); }
            set { BackingStore?.Set(nameof(ErrorCount), value); }
        }
        /// <summary>Represents the time when most recent changes were observed in profile.</summary>
        public DateTimeOffset? LastActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastActivityDateTime)); }
            set { BackingStore?.Set(nameof(LastActivityDateTime), value); }
        }
        /// <summary>Represents the time of the most recent successful  synchronization.</summary>
        public DateTimeOffset? LastSynchronizationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSynchronizationDateTime)); }
            set { BackingStore?.Set(nameof(LastSynchronizationDateTime), value); }
        }
        /// <summary>The status of a sync. The possible values are: paused, inProgress, success, error, validationError, quarantined, unknownFutureValue, extracting, validating. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: extracting, validating.</summary>
        public EducationSynchronizationStatus? Status {
            get { return BackingStore?.Get<EducationSynchronizationStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Status message for the current profile&apos;s synchronization stage.</summary>
        public string StatusMessage {
            get { return BackingStore?.Get<string>(nameof(StatusMessage)); }
            set { BackingStore?.Set(nameof(StatusMessage), value); }
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
