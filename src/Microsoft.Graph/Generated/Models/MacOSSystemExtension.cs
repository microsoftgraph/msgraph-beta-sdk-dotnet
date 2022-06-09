using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents a specific macOS system extension.</summary>
    public class MacOSSystemExtension : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Gets or sets the bundle identifier of the system extension.</summary>
        public string BundleId {
            get { return BackingStore?.Get<string>(nameof(BundleId)); }
            set { BackingStore?.Set(nameof(BundleId), value); }
        }
        /// <summary>Gets or sets the team identifier that was used to sign the system extension.</summary>
        public string TeamIdentifier {
            get { return BackingStore?.Get<string>(nameof(TeamIdentifier)); }
            set { BackingStore?.Set(nameof(TeamIdentifier), value); }
        }
        /// <summary>
        /// Instantiates a new macOSSystemExtension and sets the default values.
        /// </summary>
        public MacOSSystemExtension() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSSystemExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSystemExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
