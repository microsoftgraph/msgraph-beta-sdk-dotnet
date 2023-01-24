using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents a process that can receive an Apple Event notification.
    /// </summary>
    public class MacOSAppleEventReceiver : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Allow or block this app from receiving Apple events.</summary>
        public bool? Allowed {
            get { return BackingStore?.Get<bool?>("allowed"); }
            set { BackingStore?.Set("allowed", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Code requirement for the app or binary that receives the Apple Event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CodeRequirement {
            get { return BackingStore?.Get<string?>("codeRequirement"); }
            set { BackingStore?.Set("codeRequirement", value); }
        }
#nullable restore
#else
        public string CodeRequirement {
            get { return BackingStore?.Get<string>("codeRequirement"); }
            set { BackingStore?.Set("codeRequirement", value); }
        }
#endif
        /// <summary>Bundle ID of the app or file path of the process or executable that receives the Apple Event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier {
            get { return BackingStore?.Get<string?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
#nullable restore
#else
        public string Identifier {
            get { return BackingStore?.Get<string>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
#endif
        /// <summary>Process identifier types for MacOS Privacy Preferences</summary>
        public MacOSProcessIdentifierType? IdentifierType {
            get { return BackingStore?.Get<MacOSProcessIdentifierType?>("identifierType"); }
            set { BackingStore?.Set("identifierType", value); }
        }
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
        /// <summary>
        /// Instantiates a new macOSAppleEventReceiver and sets the default values.
        /// </summary>
        public MacOSAppleEventReceiver() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MacOSAppleEventReceiver CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSAppleEventReceiver();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowed", n => { Allowed = n.GetBoolValue(); } },
                {"codeRequirement", n => { CodeRequirement = n.GetStringValue(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"identifierType", n => { IdentifierType = n.GetEnumValue<MacOSProcessIdentifierType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowed", Allowed);
            writer.WriteStringValue("codeRequirement", CodeRequirement);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteEnumValue<MacOSProcessIdentifierType>("identifierType", IdentifierType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
