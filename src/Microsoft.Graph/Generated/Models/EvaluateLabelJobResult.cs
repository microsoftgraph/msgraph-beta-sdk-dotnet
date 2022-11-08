using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EvaluateLabelJobResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The responsiblePolicy property</summary>
        public Microsoft.Graph.Beta.Models.ResponsiblePolicy ResponsiblePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResponsiblePolicy>("responsiblePolicy"); }
            set { BackingStore?.Set("responsiblePolicy", value); }
        }
        /// <summary>The responsibleSensitiveTypes property</summary>
        public List<ResponsibleSensitiveType> ResponsibleSensitiveTypes {
            get { return BackingStore?.Get<List<ResponsibleSensitiveType>>("responsibleSensitiveTypes"); }
            set { BackingStore?.Set("responsibleSensitiveTypes", value); }
        }
        /// <summary>The sensitivityLabel property</summary>
        public MatchingLabel SensitivityLabel {
            get { return BackingStore?.Get<MatchingLabel>("sensitivityLabel"); }
            set { BackingStore?.Set("sensitivityLabel", value); }
        }
        /// <summary>
        /// Instantiates a new evaluateLabelJobResult and sets the default values.
        /// </summary>
        public EvaluateLabelJobResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.evaluateLabelJobResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EvaluateLabelJobResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateLabelJobResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"responsiblePolicy", n => { ResponsiblePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResponsiblePolicy>(Microsoft.Graph.Beta.Models.ResponsiblePolicy.CreateFromDiscriminatorValue); } },
                {"responsibleSensitiveTypes", n => { ResponsibleSensitiveTypes = n.GetCollectionOfObjectValues<ResponsibleSensitiveType>(ResponsibleSensitiveType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sensitivityLabel", n => { SensitivityLabel = n.GetObjectValue<MatchingLabel>(MatchingLabel.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResponsiblePolicy>("responsiblePolicy", ResponsiblePolicy);
            writer.WriteCollectionOfObjectValues<ResponsibleSensitiveType>("responsibleSensitiveTypes", ResponsibleSensitiveTypes);
            writer.WriteObjectValue<MatchingLabel>("sensitivityLabel", SensitivityLabel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
