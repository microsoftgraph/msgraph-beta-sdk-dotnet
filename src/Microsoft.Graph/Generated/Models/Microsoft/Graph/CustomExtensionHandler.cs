using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CustomExtensionHandler : Entity, IParsable {
        /// <summary>Indicates which custom workflow extension will be executed at this stage. Nullable. Supports $expand.</summary>
        public CustomAccessPackageWorkflowExtension CustomExtension { get; set; }
        /// <summary>Indicates the stage of the access package assignment request workflow when the access package custom extension runs. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionStage? Stage { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"customExtension", (o,n) => { (o as CustomExtensionHandler).CustomExtension = n.GetObjectValue<CustomAccessPackageWorkflowExtension>(CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue); } },
                {"stage", (o,n) => { (o as CustomExtensionHandler).Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomAccessPackageWorkflowExtension>("customExtension", CustomExtension);
            writer.WriteEnumValue<AccessPackageCustomExtensionStage>("stage", Stage);
        }
    }
}
