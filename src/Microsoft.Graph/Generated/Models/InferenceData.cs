using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InferenceData : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Confidence score reflecting the accuracy of the data inferred about the user.</summary>
        public double? ConfidenceScore {
            get { return BackingStore?.Get<double?>(nameof(ConfidenceScore)); }
            set { BackingStore?.Set(nameof(ConfidenceScore), value); }
        }
        /// <summary>Records if the user has confirmed this inference as being True or False.</summary>
        public bool? UserHasVerifiedAccuracy {
            get { return BackingStore?.Get<bool?>(nameof(UserHasVerifiedAccuracy)); }
            set { BackingStore?.Set(nameof(UserHasVerifiedAccuracy), value); }
        }
        /// <summary>
        /// Instantiates a new inferenceData and sets the default values.
        /// </summary>
        public InferenceData() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InferenceData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InferenceData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidenceScore", n => { ConfidenceScore = n.GetDoubleValue(); } },
                {"userHasVerifiedAccuracy", n => { UserHasVerifiedAccuracy = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("confidenceScore", ConfidenceScore);
            writer.WriteBoolValue("userHasVerifiedAccuracy", UserHasVerifiedAccuracy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
