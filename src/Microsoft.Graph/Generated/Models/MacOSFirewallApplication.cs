using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents an app in the list of macOS firewall applications</summary>
    public class MacOSFirewallApplication : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Whether or not incoming connections are allowed.</summary>
        public bool? AllowsIncomingConnections {
            get { return BackingStore?.Get<bool?>(nameof(AllowsIncomingConnections)); }
            set { BackingStore?.Set(nameof(AllowsIncomingConnections), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>BundleId of the application.</summary>
        public string BundleId {
            get { return BackingStore?.Get<string>(nameof(BundleId)); }
            set { BackingStore?.Set(nameof(BundleId), value); }
        }
        /// <summary>
        /// Instantiates a new macOSFirewallApplication and sets the default values.
        /// </summary>
        public MacOSFirewallApplication() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSFirewallApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSFirewallApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowsIncomingConnections", n => { AllowsIncomingConnections = n.GetBoolValue(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowsIncomingConnections", AllowsIncomingConnections);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
