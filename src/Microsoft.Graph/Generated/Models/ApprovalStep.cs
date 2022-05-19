using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class ApprovalStep : Entity, IParsable {
        /// <summary>Indicates whether the step is assigned to the calling user to review. Read-only.</summary>
        public bool? AssignedToMe {
            get { return BackingStore?.Get<bool?>(nameof(AssignedToMe)); }
            set { BackingStore?.Set(nameof(AssignedToMe), value); }
        }
        /// <summary>The label provided by the policy creator to identify an approval step. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The justification associated with the approval step decision.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>(nameof(Justification)); }
            set { BackingStore?.Set(nameof(Justification), value); }
        }
        /// <summary>The identifier of the reviewer. Read-only.</summary>
        public Identity ReviewedBy {
            get { return BackingStore?.Get<Identity>(nameof(ReviewedBy)); }
            set { BackingStore?.Set(nameof(ReviewedBy), value); }
        }
        /// <summary>The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ReviewedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReviewedDateTime)); }
            set { BackingStore?.Set(nameof(ReviewedDateTime), value); }
        }
        /// <summary>The result of this approval record. Possible values include: NotReviewed, Approved, Denied.</summary>
        public string ReviewResult {
            get { return BackingStore?.Get<string>(nameof(ReviewResult)); }
            set { BackingStore?.Set(nameof(ReviewResult), value); }
        }
        /// <summary>The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApprovalStep CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedToMe", n => { AssignedToMe = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"reviewedBy", n => { ReviewedBy = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", n => { ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewResult", n => { ReviewResult = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("assignedToMe", AssignedToMe);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<Identity>("reviewedBy", ReviewedBy);
            writer.WriteDateTimeOffsetValue("reviewedDateTime", ReviewedDateTime);
            writer.WriteStringValue("reviewResult", ReviewResult);
            writer.WriteStringValue("status", Status);
        }
    }
}
