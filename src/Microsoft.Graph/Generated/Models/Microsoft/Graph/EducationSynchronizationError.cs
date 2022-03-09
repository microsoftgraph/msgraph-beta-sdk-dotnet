using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the educationRoot singleton.</summary>
    public class EducationSynchronizationError : Entity, IParsable {
        /// <summary>Represents the sync entity (school, section, student, teacher).</summary>
        public string EntryType { get; set; }
        /// <summary>Represents the error code for this error.</summary>
        public string ErrorCode { get; set; }
        /// <summary>Contains a description of the error.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>The unique identifier for the entry.</summary>
        public string JoiningValue { get; set; }
        /// <summary>The time of occurrence of this error.</summary>
        public DateTimeOffset? RecordedDateTime { get; set; }
        /// <summary>The identifier of this error entry.</summary>
        public string ReportableIdentifier { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSynchronizationError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"entryType", (o,n) => { (o as EducationSynchronizationError).EntryType = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as EducationSynchronizationError).ErrorCode = n.GetStringValue(); } },
                {"errorMessage", (o,n) => { (o as EducationSynchronizationError).ErrorMessage = n.GetStringValue(); } },
                {"joiningValue", (o,n) => { (o as EducationSynchronizationError).JoiningValue = n.GetStringValue(); } },
                {"recordedDateTime", (o,n) => { (o as EducationSynchronizationError).RecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reportableIdentifier", (o,n) => { (o as EducationSynchronizationError).ReportableIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("entryType", EntryType);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteStringValue("joiningValue", JoiningValue);
            writer.WriteDateTimeOffsetValue("recordedDateTime", RecordedDateTime);
            writer.WriteStringValue("reportableIdentifier", ReportableIdentifier);
        }
    }
}
