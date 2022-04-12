using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class CaseOperation : Entity, IParsable {
        /// <summary>The type of action the operation represents. Possible values are: addToReviewSet,applyTags,contentExport,convertToPdf,estimateStatistics, purgeData</summary>
        public CaseAction? Action { get; set; }
        /// <summary>The date and time the operation was completed.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The user that created the operation.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time the operation was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The progress of the operation.</summary>
        public int? PercentProgress { get; set; }
        /// <summary>Contains success and failure-specific result information.</summary>
        public Microsoft.Graph.Beta.Models.ResultInfo ResultInfo { get; set; }
        /// <summary>The status of the case operation. Possible values are: notStarted, submissionFailed, running, succeeded, partiallySucceeded, failed.</summary>
        public CaseOperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CaseOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CaseOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<CaseAction>(); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"percentProgress", n => { PercentProgress = n.GetIntValue(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>(Microsoft.Graph.Beta.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<CaseOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CaseAction>("action", Action);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("percentProgress", PercentProgress);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteEnumValue<CaseOperationStatus>("status", Status);
        }
    }
}
