using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EducationSynchronizationProfileStatus : Entity, IParsable {
        /// <summary>Number of errors during synchronization.</summary>
        public long? ErrorCount { get; set; }
        /// <summary>Represents the time when most recent changes were observed in profile.</summary>
        public DateTimeOffset? LastActivityDateTime { get; set; }
        /// <summary>Represents the time of the most recent successful  synchronization.</summary>
        public DateTimeOffset? LastSynchronizationDateTime { get; set; }
        /// <summary>The status of a sync. The possible values are: paused, inProgress, success, error, validationError, quarantined, unknownFutureValue, extracting, validating. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: extracting, validating.</summary>
        public EducationSynchronizationStatus? Status { get; set; }
        /// <summary>Status message for the current profile&apos;s synchronization stage.</summary>
        public string StatusMessage { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"errorCount", (o,n) => { (o as EducationSynchronizationProfileStatus).ErrorCount = n.GetLongValue(); } },
                {"lastActivityDateTime", (o,n) => { (o as EducationSynchronizationProfileStatus).LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSynchronizationDateTime", (o,n) => { (o as EducationSynchronizationProfileStatus).LastSynchronizationDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as EducationSynchronizationProfileStatus).Status = n.GetEnumValue<EducationSynchronizationStatus>(); } },
                {"statusMessage", (o,n) => { (o as EducationSynchronizationProfileStatus).StatusMessage = n.GetStringValue(); } },
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
