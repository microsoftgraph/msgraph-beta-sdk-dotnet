using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class EducationSynchronizationError : Entity, IParsable {
        /// <summary>Represents the sync entity (school, section, student, teacher).</summary>
        public string EntryType {
            get { return BackingStore?.Get<string>("entryType"); }
            set { BackingStore?.Set("entryType", value); }
        }
        /// <summary>Represents the error code for this error.</summary>
        public string ErrorCode {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Contains a description of the error.</summary>
        public string ErrorMessage {
            get { return BackingStore?.Get<string>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
        /// <summary>The unique identifier for the entry.</summary>
        public string JoiningValue {
            get { return BackingStore?.Get<string>("joiningValue"); }
            set { BackingStore?.Set("joiningValue", value); }
        }
        /// <summary>The time of occurrence of this error.</summary>
        public DateTimeOffset? RecordedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("recordedDateTime"); }
            set { BackingStore?.Set("recordedDateTime", value); }
        }
        /// <summary>The identifier of this error entry.</summary>
        public string ReportableIdentifier {
            get { return BackingStore?.Get<string>("reportableIdentifier"); }
            set { BackingStore?.Set("reportableIdentifier", value); }
        }
        /// <summary>
        /// Instantiates a new educationSynchronizationError and sets the default values.
        /// </summary>
        public EducationSynchronizationError() : base() {
            OdataType = "#microsoft.graph.educationSynchronizationError";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"entryType", n => { EntryType = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"joiningValue", n => { JoiningValue = n.GetStringValue(); } },
                {"recordedDateTime", n => { RecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reportableIdentifier", n => { ReportableIdentifier = n.GetStringValue(); } },
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
