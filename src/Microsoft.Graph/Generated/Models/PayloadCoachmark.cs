using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PayloadCoachmark : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The coachmarkLocation property</summary>
        public Microsoft.Graph.Beta.Models.CoachmarkLocation CoachmarkLocation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CoachmarkLocation>("coachmarkLocation"); }
            set { BackingStore?.Set("coachmarkLocation", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The indicator property</summary>
        public string Indicator {
            get { return BackingStore?.Get<string>("indicator"); }
            set { BackingStore?.Set("indicator", value); }
        }
        /// <summary>The isValid property</summary>
        public bool? IsValid {
            get { return BackingStore?.Get<bool?>("isValid"); }
            set { BackingStore?.Set("isValid", value); }
        }
        /// <summary>The language property</summary>
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The order property</summary>
        public string Order {
            get { return BackingStore?.Get<string>("order"); }
            set { BackingStore?.Set("order", value); }
        }
        /// <summary>
        /// Instantiates a new payloadCoachmark and sets the default values.
        /// </summary>
        public PayloadCoachmark() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayloadCoachmark CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayloadCoachmark();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"coachmarkLocation", n => { CoachmarkLocation = n.GetObjectValue<Microsoft.Graph.Beta.Models.CoachmarkLocation>(Microsoft.Graph.Beta.Models.CoachmarkLocation.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"indicator", n => { Indicator = n.GetStringValue(); } },
                {"isValid", n => { IsValid = n.GetBoolValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"order", n => { Order = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CoachmarkLocation>("coachmarkLocation", CoachmarkLocation);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("indicator", Indicator);
            writer.WriteBoolValue("isValid", IsValid);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("order", Order);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
