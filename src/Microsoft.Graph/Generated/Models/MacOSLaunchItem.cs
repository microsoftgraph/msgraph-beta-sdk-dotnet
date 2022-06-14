using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents an app in the list of macOS launch items</summary>
    public class MacOSLaunchItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Whether or not to hide the item from the Users and Groups List.</summary>
        public bool? Hide {
            get { return BackingStore?.Get<bool?>(nameof(Hide)); }
            set { BackingStore?.Set(nameof(Hide), value); }
        }
        /// <summary>Path to the launch item.</summary>
        public string PathObject {
            get { return BackingStore?.Get<string>(nameof(PathObject)); }
            set { BackingStore?.Set(nameof(PathObject), value); }
        }
        /// <summary>
        /// Instantiates a new macOSLaunchItem and sets the default values.
        /// </summary>
        public MacOSLaunchItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSLaunchItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSLaunchItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hide", n => { Hide = n.GetBoolValue(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hide", Hide);
            writer.WriteStringValue("path", PathObject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
