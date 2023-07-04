using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcResizeValidationResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cloudPC id that corresponds to its unique identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcId {
            get { return BackingStore?.Get<string?>("cloudPcId"); }
            set { BackingStore?.Set("cloudPcId", value); }
        }
#nullable restore
#else
        public string CloudPcId {
            get { return BackingStore?.Get<string>("cloudPcId"); }
            set { BackingStore?.Set("cloudPcId", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Describes a list of the validation result for the Cloud PC resize action. The possible values are: success, cloudPcNotFound, operationCnflict, operationNotSupported, targetLicenseHasAssigned, internalServerError, and unknownFutureValue.</summary>
        public CloudPcResizeValidationCode? ValidationResult {
            get { return BackingStore?.Get<CloudPcResizeValidationCode?>("validationResult"); }
            set { BackingStore?.Set("validationResult", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcResizeValidationResult and sets the default values.
        /// </summary>
        public CloudPcResizeValidationResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcResizeValidationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcResizeValidationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cloudPcId", n => { CloudPcId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"validationResult", n => { ValidationResult = n.GetEnumValue<CloudPcResizeValidationCode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<CloudPcResizeValidationCode>("validationResult", ValidationResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
