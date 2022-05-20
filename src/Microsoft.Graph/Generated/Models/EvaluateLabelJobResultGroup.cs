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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The automatic property</summary>
        public EvaluateLabelJobResult Automatic {
            get { return BackingStore?.Get<EvaluateLabelJobResult>(nameof(Automatic)); }
            set { BackingStore?.Set(nameof(Automatic), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The recommended property</summary>
        public EvaluateLabelJobResult Recommended {
            get { return BackingStore?.Get<EvaluateLabelJobResult>(nameof(Recommended)); }
            set { BackingStore?.Set(nameof(Recommended), value); }
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
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"recommended", n => { Recommended = n.GetObjectValue<EvaluateLabelJobResult>(EvaluateLabelJobResult.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<EvaluateLabelJobResult>("automatic", Automatic);
            writer.WriteObjectValue<EvaluateLabelJobResult>("recommended", Recommended);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
