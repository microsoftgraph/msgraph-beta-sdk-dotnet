using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StatusDetails : StatusBase, IParsable {
        /// <summary>Additional details in case of error.</summary>
        public string AdditionalDetails {
            get { return BackingStore?.Get<string>(nameof(AdditionalDetails)); }
            set { BackingStore?.Set(nameof(AdditionalDetails), value); }
        }
        /// <summary>Categorizes the error code. Possible values are Failure, NonServiceFailure, Success.</summary>
        public ProvisioningStatusErrorCategory? ErrorCategory {
            get { return BackingStore?.Get<ProvisioningStatusErrorCategory?>(nameof(ErrorCategory)); }
            set { BackingStore?.Set(nameof(ErrorCategory), value); }
        }
        /// <summary>Unique error code if any occurred. Learn more</summary>
        public string ErrorCode {
            get { return BackingStore?.Get<string>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>Summarizes the status and describes why the status happened.</summary>
        public string Reason {
            get { return BackingStore?.Get<string>(nameof(Reason)); }
            set { BackingStore?.Set(nameof(Reason), value); }
        }
        /// <summary>Provides the resolution for the corresponding error.</summary>
        public string RecommendedAction {
            get { return BackingStore?.Get<string>(nameof(RecommendedAction)); }
            set { BackingStore?.Set(nameof(RecommendedAction), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new StatusDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StatusDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                {"errorCategory", n => { ErrorCategory = n.GetEnumValue<ProvisioningStatusErrorCategory>(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteEnumValue<ProvisioningStatusErrorCategory>("errorCategory", ErrorCategory);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
        }
    }
}
