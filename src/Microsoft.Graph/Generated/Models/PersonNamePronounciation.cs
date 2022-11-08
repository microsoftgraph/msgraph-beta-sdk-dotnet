using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PersonNamePronounciation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The first property</summary>
        public string First {
            get { return BackingStore?.Get<string>("first"); }
            set { BackingStore?.Set("first", value); }
        }
        /// <summary>The last property</summary>
        public string Last {
            get { return BackingStore?.Get<string>("last"); }
            set { BackingStore?.Set("last", value); }
        }
        /// <summary>The maiden property</summary>
        public string Maiden {
            get { return BackingStore?.Get<string>("maiden"); }
            set { BackingStore?.Set("maiden", value); }
        }
        /// <summary>The middle property</summary>
        public string Middle {
            get { return BackingStore?.Get<string>("middle"); }
            set { BackingStore?.Set("middle", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new personNamePronounciation and sets the default values.
        /// </summary>
        public PersonNamePronounciation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.personNamePronounciation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PersonNamePronounciation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonNamePronounciation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"first", n => { First = n.GetStringValue(); } },
                {"last", n => { Last = n.GetStringValue(); } },
                {"maiden", n => { Maiden = n.GetStringValue(); } },
                {"middle", n => { Middle = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("first", First);
            writer.WriteStringValue("last", Last);
            writer.WriteStringValue("maiden", Maiden);
            writer.WriteStringValue("middle", Middle);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
