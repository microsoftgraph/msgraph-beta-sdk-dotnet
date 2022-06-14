using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows 10 Associated Application definition.</summary>
    public class Windows10AssociatedApps : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Application type. Possible values are: desktop, universal.</summary>
        public Windows10AppType? AppType {
            get { return BackingStore?.Get<Windows10AppType?>(nameof(AppType)); }
            set { BackingStore?.Set(nameof(AppType), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identifier.</summary>
        public string Identifier {
            get { return BackingStore?.Get<string>(nameof(Identifier)); }
            set { BackingStore?.Set(nameof(Identifier), value); }
        }
        /// <summary>
        /// Instantiates a new windows10AssociatedApps and sets the default values.
        /// </summary>
        public Windows10AssociatedApps() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Windows10AssociatedApps CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10AssociatedApps();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appType", n => { AppType = n.GetEnumValue<Windows10AppType>(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Windows10AppType>("appType", AppType);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
