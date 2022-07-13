using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationFeedbackResourceOutcome : EducationOutcome, IParsable {
        /// <summary>The actual feedback resource.</summary>
        public EducationResource FeedbackResource {
            get { return BackingStore?.Get<EducationResource>("feedbackResource"); }
            set { BackingStore?.Set("feedbackResource", value); }
        }
        /// <summary>The status of the feedback resource. The possible values are: notPublished, pendingPublish, published, failedPublish, and unknownFutureValue.</summary>
        public EducationFeedbackResourceOutcomeStatus? ResourceStatus {
            get { return BackingStore?.Get<EducationFeedbackResourceOutcomeStatus?>("resourceStatus"); }
            set { BackingStore?.Set("resourceStatus", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationFeedbackResourceOutcome CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationFeedbackResourceOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"feedbackResource", n => { FeedbackResource = n.GetObjectValue<EducationResource>(EducationResource.CreateFromDiscriminatorValue); } },
                {"resourceStatus", n => { ResourceStatus = n.GetEnumValue<EducationFeedbackResourceOutcomeStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationResource>("feedbackResource", FeedbackResource);
            writer.WriteEnumValue<EducationFeedbackResourceOutcomeStatus>("resourceStatus", ResourceStatus);
        }
    }
}
