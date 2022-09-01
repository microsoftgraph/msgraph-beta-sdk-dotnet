using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RequestSignatureVerification : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Specifies whether this application accepts weak algorithms.  The possible values are: rsaSha1, unknownFutureValue.</summary>
        public WeakAlgorithms? AllowedWeakAlgorithms {
            get { return BackingStore?.Get<WeakAlgorithms?>("allowedWeakAlgorithms"); }
            set { BackingStore?.Set("allowedWeakAlgorithms", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies whether signed authentication requests for this application should be required.</summary>
        public bool? IsSignedRequestRequired {
            get { return BackingStore?.Get<bool?>("isSignedRequestRequired"); }
            set { BackingStore?.Set("isSignedRequestRequired", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new requestSignatureVerification and sets the default values.
        /// </summary>
        public RequestSignatureVerification() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.requestSignatureVerification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RequestSignatureVerification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequestSignatureVerification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedWeakAlgorithms", n => { AllowedWeakAlgorithms = n.GetEnumValue<WeakAlgorithms>(); } },
                {"isSignedRequestRequired", n => { IsSignedRequestRequired = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WeakAlgorithms>("allowedWeakAlgorithms", AllowedWeakAlgorithms);
            writer.WriteBoolValue("isSignedRequestRequired", IsSignedRequestRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
