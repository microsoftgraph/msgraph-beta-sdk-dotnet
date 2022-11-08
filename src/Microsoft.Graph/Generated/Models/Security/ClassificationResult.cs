using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ClassificationResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The confidence level, 0 to 100, of the result.</summary>
        public int? ConfidenceLevel {
            get { return BackingStore?.Get<int?>("confidenceLevel"); }
            set { BackingStore?.Set("confidenceLevel", value); }
        }
        /// <summary>The number of instances of the specific information type in the input.</summary>
        public int? Count {
            get { return BackingStore?.Get<int?>("count"); }
            set { BackingStore?.Set("count", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The GUID of the discovered sensitive information type.</summary>
        public string SensitiveTypeId {
            get { return BackingStore?.Get<string>("sensitiveTypeId"); }
            set { BackingStore?.Set("sensitiveTypeId", value); }
        }
        /// <summary>
        /// Instantiates a new classificationResult and sets the default values.
        /// </summary>
        public ClassificationResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.security.classificationResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClassificationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassificationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidenceLevel", n => { ConfidenceLevel = n.GetIntValue(); } },
                {"count", n => { Count = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sensitiveTypeId", n => { SensitiveTypeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidenceLevel", ConfidenceLevel);
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sensitiveTypeId", SensitiveTypeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
