using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProvisioningErrorInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Additional details in case of error.</summary>
        public string AdditionalDetails {
            get { return BackingStore?.Get<string>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Categorizes the error code. Possible values are failure, nonServiceFailure, success, unknownFutureValue</summary>
        public ProvisioningStatusErrorCategory? ErrorCategory {
            get { return BackingStore?.Get<ProvisioningStatusErrorCategory?>("errorCategory"); }
            set { BackingStore?.Set("errorCategory", value); }
        }
        /// <summary>Unique error code if any occurred. Learn more</summary>
        public string ErrorCode {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Summarizes the status and describes why the status happened.</summary>
        public string Reason {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
        /// <summary>Provides the resolution for the corresponding error.</summary>
        public string RecommendedAction {
            get { return BackingStore?.Get<string>("recommendedAction"); }
            set { BackingStore?.Set("recommendedAction", value); }
        }
        /// <summary>
        /// Instantiates a new provisioningErrorInfo and sets the default values.
        /// </summary>
        public ProvisioningErrorInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProvisioningErrorInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningErrorInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                {"errorCategory", n => { ErrorCategory = n.GetEnumValue<ProvisioningStatusErrorCategory>(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteEnumValue<ProvisioningStatusErrorCategory>("errorCategory", ErrorCategory);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
