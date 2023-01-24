using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents a mapping between team identifiers for macOS system extensions and system extension types.
    /// </summary>
    public class MacOSSystemExtensionTypeMapping : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Flag enum representing the allowed macOS system extension types.</summary>
        public MacOSSystemExtensionType? AllowedTypes {
            get { return BackingStore?.Get<MacOSSystemExtensionType?>("allowedTypes"); }
            set { BackingStore?.Set("allowedTypes", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Gets or sets the team identifier used to sign the system extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamIdentifier {
            get { return BackingStore?.Get<string?>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
#nullable restore
#else
        public string TeamIdentifier {
            get { return BackingStore?.Get<string>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new macOSSystemExtensionTypeMapping and sets the default values.
        /// </summary>
        public MacOSSystemExtensionTypeMapping() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MacOSSystemExtensionTypeMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSystemExtensionTypeMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedTypes", n => { AllowedTypes = n.GetEnumValue<MacOSSystemExtensionType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MacOSSystemExtensionType>("allowedTypes", AllowedTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
