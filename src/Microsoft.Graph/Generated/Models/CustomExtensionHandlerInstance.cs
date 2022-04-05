using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CustomExtensionHandlerInstance : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifier of the customAccessPackageWorkflowExtension triggered at this instance.</summary>
        public string CustomExtensionId { get; set; }
        /// <summary>The unique run ID for the logic app.</summary>
        public string ExternalCorrelationId { get; set; }
        /// <summary>Indicates the stage of the request workflow when the access package custom extension runs. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionStage? Stage { get; set; }
        /// <summary>Status of the request to run the access package custom extension workflow that is associated with the logic app. The possible values are: requestSent, requestReceived, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionHandlerStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new customExtensionHandlerInstance and sets the default values.
        /// </summary>
        public CustomExtensionHandlerInstance() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CustomExtensionHandlerInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionHandlerInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"customExtensionId", (o,n) => { (o as CustomExtensionHandlerInstance).CustomExtensionId = n.GetStringValue(); } },
                {"externalCorrelationId", (o,n) => { (o as CustomExtensionHandlerInstance).ExternalCorrelationId = n.GetStringValue(); } },
                {"stage", (o,n) => { (o as CustomExtensionHandlerInstance).Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
                {"status", (o,n) => { (o as CustomExtensionHandlerInstance).Status = n.GetEnumValue<AccessPackageCustomExtensionHandlerStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customExtensionId", CustomExtensionId);
            writer.WriteStringValue("externalCorrelationId", ExternalCorrelationId);
            writer.WriteEnumValue<AccessPackageCustomExtensionStage>("stage", Stage);
            writer.WriteEnumValue<AccessPackageCustomExtensionHandlerStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
