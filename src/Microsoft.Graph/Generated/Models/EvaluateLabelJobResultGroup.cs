using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EvaluateLabelJobResultGroup : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The automatic property</summary>
        public EvaluateLabelJobResult Automatic {
            get { return BackingStore?.Get<EvaluateLabelJobResult>("automatic"); }
            set { BackingStore?.Set("automatic", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The recommended property</summary>
        public EvaluateLabelJobResult Recommended {
            get { return BackingStore?.Get<EvaluateLabelJobResult>("recommended"); }
            set { BackingStore?.Set("recommended", value); }
        }
        /// <summary>
        /// Instantiates a new evaluateLabelJobResultGroup and sets the default values.
        /// </summary>
        public EvaluateLabelJobResultGroup() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EvaluateLabelJobResultGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateLabelJobResultGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"automatic", n => { Automatic = n.GetObjectValue<EvaluateLabelJobResult>(EvaluateLabelJobResult.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recommended", n => { Recommended = n.GetObjectValue<EvaluateLabelJobResult>(EvaluateLabelJobResult.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<EvaluateLabelJobResult>("automatic", Automatic);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<EvaluateLabelJobResult>("recommended", Recommended);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
