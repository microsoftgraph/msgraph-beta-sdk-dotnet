using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DetectedSensitiveContentBase : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The confidence property</summary>
        public int? Confidence {
            get { return BackingStore?.Get<int?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The id property</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The recommendedConfidence property</summary>
        public int? RecommendedConfidence {
            get { return BackingStore?.Get<int?>("recommendedConfidence"); }
            set { BackingStore?.Set("recommendedConfidence", value); }
        }
        /// <summary>The uniqueCount property</summary>
        public int? UniqueCount {
            get { return BackingStore?.Get<int?>("uniqueCount"); }
            set { BackingStore?.Set("uniqueCount", value); }
        }
        /// <summary>
        /// Instantiates a new detectedSensitiveContentBase and sets the default values.
        /// </summary>
        public DetectedSensitiveContentBase() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.detectedSensitiveContentBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DetectedSensitiveContentBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.detectedSensitiveContent" => new DetectedSensitiveContent(),
                "#microsoft.graph.exactMatchDetectedSensitiveContent" => new ExactMatchDetectedSensitiveContent(),
                "#microsoft.graph.machineLearningDetectedSensitiveContent" => new MachineLearningDetectedSensitiveContent(),
                _ => new DetectedSensitiveContentBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recommendedConfidence", n => { RecommendedConfidence = n.GetIntValue(); } },
                {"uniqueCount", n => { UniqueCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("recommendedConfidence", RecommendedConfidence);
            writer.WriteIntValue("uniqueCount", UniqueCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
