using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ControlScore : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The controlCategory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ControlCategory {
            get { return BackingStore?.Get<string?>("controlCategory"); }
            set { BackingStore?.Set("controlCategory", value); }
        }
#else
        public string ControlCategory {
            get { return BackingStore?.Get<string>("controlCategory"); }
            set { BackingStore?.Set("controlCategory", value); }
        }
#endif
        /// <summary>The controlName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ControlName {
            get { return BackingStore?.Get<string?>("controlName"); }
            set { BackingStore?.Set("controlName", value); }
        }
#else
        public string ControlName {
            get { return BackingStore?.Get<string>("controlName"); }
            set { BackingStore?.Set("controlName", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
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
        /// <summary>The score property</summary>
        public double? Score {
            get { return BackingStore?.Get<double?>("score"); }
            set { BackingStore?.Set("score", value); }
        }
        /// <summary>
        /// Instantiates a new controlScore and sets the default values.
        /// </summary>
        public ControlScore() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ControlScore CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ControlScore();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"controlCategory", n => { ControlCategory = n.GetStringValue(); } },
                {"controlName", n => { ControlName = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"score", n => { Score = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("controlCategory", ControlCategory);
            writer.WriteStringValue("controlName", ControlName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("score", Score);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
