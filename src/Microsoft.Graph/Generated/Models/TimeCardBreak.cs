using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TimeCardBreak : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>ID of the timeCardBreak.</summary>
        public string BreakId {
            get { return BackingStore?.Get<string>("breakId"); }
            set { BackingStore?.Set("breakId", value); }
        }
        /// <summary>The start event of the timeCardBreak.</summary>
        public TimeCardEvent End {
            get { return BackingStore?.Get<TimeCardEvent>("end"); }
            set { BackingStore?.Set("end", value); }
        }
        /// <summary>Notes about the timeCardBreak.</summary>
        public ItemBody Notes {
            get { return BackingStore?.Get<ItemBody>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The start property</summary>
        public TimeCardEvent Start {
            get { return BackingStore?.Get<TimeCardEvent>("start"); }
            set { BackingStore?.Set("start", value); }
        }
        /// <summary>
        /// Instantiates a new timeCardBreak and sets the default values.
        /// </summary>
        public TimeCardBreak() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeCardBreak CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCardBreak();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"breakId", n => { BreakId = n.GetStringValue(); } },
                {"end", n => { End = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"start", n => { Start = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("breakId", BreakId);
            writer.WriteObjectValue<TimeCardEvent>("end", End);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TimeCardEvent>("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
