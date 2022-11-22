using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ContentClassification : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>The matches property</summary>
        public List<MatchLocation> Matches {
            get { return BackingStore?.Get<List<MatchLocation>>("matches"); }
            set { BackingStore?.Set("matches", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The sensitiveTypeId property</summary>
        public string SensitiveTypeId {
            get { return BackingStore?.Get<string>("sensitiveTypeId"); }
            set { BackingStore?.Set("sensitiveTypeId", value); }
        }
        /// <summary>The uniqueCount property</summary>
        public int? UniqueCount {
            get { return BackingStore?.Get<int?>("uniqueCount"); }
            set { BackingStore?.Set("uniqueCount", value); }
        }
        /// <summary>
        /// Instantiates a new contentClassification and sets the default values.
        /// </summary>
        public ContentClassification() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ContentClassification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentClassification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"matches", n => { Matches = n.GetCollectionOfObjectValues<MatchLocation>(MatchLocation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sensitiveTypeId", n => { SensitiveTypeId = n.GetStringValue(); } },
                {"uniqueCount", n => { UniqueCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<MatchLocation>("matches", Matches);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sensitiveTypeId", SensitiveTypeId);
            writer.WriteIntValue("uniqueCount", UniqueCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
