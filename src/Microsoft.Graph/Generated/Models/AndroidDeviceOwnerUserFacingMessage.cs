using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents a user-facing message with locale information as well as a default message to be used if the user&apos;s locale doesn&apos;t match with any of the localized messages</summary>
    public class AndroidDeviceOwnerUserFacingMessage : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default message displayed if the user&apos;s locale doesn&apos;t match with any of the localized messages</summary>
        public string DefaultMessage {
            get { return BackingStore?.Get<string>("defaultMessage"); }
            set { BackingStore?.Set("defaultMessage", value); }
        }
        /// <summary>The list of &lt;locale, message&gt; pairs. This collection can contain a maximum of 500 elements.</summary>
        public List<KeyValuePair> LocalizedMessages {
            get { return BackingStore?.Get<List<KeyValuePair>>("localizedMessages"); }
            set { BackingStore?.Set("localizedMessages", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerUserFacingMessage and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerUserFacingMessage() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.androidDeviceOwnerUserFacingMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidDeviceOwnerUserFacingMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerUserFacingMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultMessage", n => { DefaultMessage = n.GetStringValue(); } },
                {"localizedMessages", n => { LocalizedMessages = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultMessage", DefaultMessage);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("localizedMessages", LocalizedMessages);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
