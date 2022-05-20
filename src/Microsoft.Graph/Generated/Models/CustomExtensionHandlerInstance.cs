using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CustomExtensionHandlerInstance : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identifier of the customAccessPackageWorkflowExtension triggered at this instance.</summary>
        public string CustomExtensionId {
            get { return BackingStore?.Get<string>(nameof(CustomExtensionId)); }
            set { BackingStore?.Set(nameof(CustomExtensionId), value); }
        }
        /// <summary>The unique run ID for the logic app.</summary>
        public string ExternalCorrelationId {
            get { return BackingStore?.Get<string>(nameof(ExternalCorrelationId)); }
            set { BackingStore?.Set(nameof(ExternalCorrelationId), value); }
        }
        /// <summary>Indicates the stage of the request workflow when the access package custom extension runs. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionStage? Stage {
            get { return BackingStore?.Get<AccessPackageCustomExtensionStage?>(nameof(Stage)); }
            set { BackingStore?.Set(nameof(Stage), value); }
        }
        /// <summary>Status of the request to run the access package custom extension workflow that is associated with the logic app. The possible values are: requestSent, requestReceived, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionHandlerStatus? Status {
            get { return BackingStore?.Get<AccessPackageCustomExtensionHandlerStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Instantiates a new customExtensionHandlerInstance and sets the default values.
        /// </summary>
        public CustomExtensionHandlerInstance() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"customExtensionId", n => { CustomExtensionId = n.GetStringValue(); } },
                {"externalCorrelationId", n => { ExternalCorrelationId = n.GetStringValue(); } },
                {"stage", n => { Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
                {"status", n => { Status = n.GetEnumValue<AccessPackageCustomExtensionHandlerStatus>(); } },
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
