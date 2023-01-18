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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The inclusive upper bound of the integer range.</summary>
        public long? End {
            get { return BackingStore?.Get<long?>("end"); }
            set { BackingStore?.Set("end", value); }
        }
        /// <summary>The maximum property</summary>
        public long? Maximum {
            get { return BackingStore?.Get<long?>("maximum"); }
            set { BackingStore?.Set("maximum", value); }
        }
        /// <summary>The minimum property</summary>
        public long? Minimum {
            get { return BackingStore?.Get<long?>("minimum"); }
            set { BackingStore?.Set("minimum", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The inclusive lower bound of the integer range.</summary>
        public long? Start {
            get { return BackingStore?.Get<long?>("start"); }
            set { BackingStore?.Set("start", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"start", n => { Start = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("end", End);
            writer.WriteLongValue("maximum", Maximum);
            writer.WriteLongValue("minimum", Minimum);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
