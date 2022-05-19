using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IntegerRange : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The inclusive upper bound of the integer range.</summary>
        public long? End {
            get { return BackingStore?.Get<long?>(nameof(End)); }
            set { BackingStore?.Set(nameof(End), value); }
        }
        /// <summary>The maximum property</summary>
        public long? Maximum {
            get { return BackingStore?.Get<long?>(nameof(Maximum)); }
            set { BackingStore?.Set(nameof(Maximum), value); }
        }
        /// <summary>The minimum property</summary>
        public long? Minimum {
            get { return BackingStore?.Get<long?>(nameof(Minimum)); }
            set { BackingStore?.Set(nameof(Minimum), value); }
        }
        /// <summary>The inclusive lower bound of the integer range.</summary>
        public long? Start {
            get { return BackingStore?.Get<long?>(nameof(Start)); }
            set { BackingStore?.Set(nameof(Start), value); }
        }
        /// <summary>
        /// Instantiates a new integerRange and sets the default values.
        /// </summary>
        public IntegerRange() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IntegerRange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntegerRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"end", n => { End = n.GetLongValue(); } },
                {"maximum", n => { Maximum = n.GetLongValue(); } },
                {"minimum", n => { Minimum = n.GetLongValue(); } },
                {"start", n => { Start = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("end", End);
            writer.WriteLongValue("maximum", Maximum);
            writer.WriteLongValue("minimum", Minimum);
            writer.WriteLongValue("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
