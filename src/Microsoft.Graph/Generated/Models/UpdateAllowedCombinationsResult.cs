using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UpdateAllowedCombinationsResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The additionalInformation property</summary>
        public string AdditionalInformation {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The conditionalAccessReferences property</summary>
        public List<string> ConditionalAccessReferences {
            get { return BackingStore?.Get<List<string>>("conditionalAccessReferences"); }
            set { BackingStore?.Set("conditionalAccessReferences", value); }
        }
        /// <summary>The currentCombinations property</summary>
        public List<string> CurrentCombinations {
            get { return BackingStore?.Get<List<string>>("currentCombinations"); }
            set { BackingStore?.Set("currentCombinations", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The previousCombinations property</summary>
        public List<string> PreviousCombinations {
            get { return BackingStore?.Get<List<string>>("previousCombinations"); }
            set { BackingStore?.Set("previousCombinations", value); }
        }
        /// <summary>
        /// Instantiates a new updateAllowedCombinationsResult and sets the default values.
        /// </summary>
        public UpdateAllowedCombinationsResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.updateAllowedCombinationsResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateAllowedCombinationsResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAllowedCombinationsResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"conditionalAccessReferences", n => { ConditionalAccessReferences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"currentCombinations", n => { CurrentCombinations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"previousCombinations", n => { PreviousCombinations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteCollectionOfPrimitiveValues<string>("conditionalAccessReferences", ConditionalAccessReferences);
            writer.WriteCollectionOfPrimitiveValues<string>("currentCombinations", CurrentCombinations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("previousCombinations", PreviousCombinations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
