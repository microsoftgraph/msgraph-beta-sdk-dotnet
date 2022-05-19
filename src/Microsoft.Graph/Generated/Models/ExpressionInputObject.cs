using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExpressionInputObject : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Definition of the test object.</summary>
        public ObjectDefinition Definition {
            get { return BackingStore?.Get<ObjectDefinition>(nameof(Definition)); }
            set { BackingStore?.Set(nameof(Definition), value); }
        }
        /// <summary>Property values of the test object.</summary>
        public List<StringKeyObjectValuePair> Properties {
            get { return BackingStore?.Get<List<StringKeyObjectValuePair>>(nameof(Properties)); }
            set { BackingStore?.Set(nameof(Properties), value); }
        }
        /// <summary>
        /// Instantiates a new expressionInputObject and sets the default values.
        /// </summary>
        public ExpressionInputObject() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExpressionInputObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpressionInputObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"definition", n => { Definition = n.GetObjectValue<ObjectDefinition>(ObjectDefinition.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetCollectionOfObjectValues<StringKeyObjectValuePair>(StringKeyObjectValuePair.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ObjectDefinition>("definition", Definition);
            writer.WriteCollectionOfObjectValues<StringKeyObjectValuePair>("properties", Properties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
