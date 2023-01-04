using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReview entities.
    /// </summary>
    public class CustomExtensionHandler : Entity, IParsable {
        /// <summary>Indicates which custom workflow extension will be executed at this stage. Nullable. Supports $expand.</summary>
        public CustomAccessPackageWorkflowExtension CustomExtension {
            get { return BackingStore?.Get<CustomAccessPackageWorkflowExtension>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
        /// <summary>Indicates the stage of the access package assignment request workflow when the access package custom extension runs. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionStage? Stage {
            get { return BackingStore?.Get<AccessPackageCustomExtensionStage?>("stage"); }
            set { BackingStore?.Set("stage", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customExtension", n => { CustomExtension = n.GetObjectValue<CustomAccessPackageWorkflowExtension>(CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue); } },
                {"stage", n => { Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomAccessPackageWorkflowExtension>("customExtension", CustomExtension);
            writer.WriteEnumValue<AccessPackageCustomExtensionStage>("stage", Stage);
        }
    }
}
