using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Settings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies if the user&apos;s primary mailbox is hosted in the cloud and is enabled for Microsoft Graph.</summary>
        public bool? HasGraphMailbox {
            get { return BackingStore?.Get<bool?>("hasGraphMailbox"); }
            set { BackingStore?.Set("hasGraphMailbox", value); }
        }
        /// <summary>Specifies if the user has a MyAnalytics license assigned.</summary>
        public bool? HasLicense {
            get { return BackingStore?.Get<bool?>("hasLicense"); }
            set { BackingStore?.Set("hasLicense", value); }
        }
        /// <summary>Specifies if the user opted out of MyAnalytics.</summary>
        public bool? HasOptedOut {
            get { return BackingStore?.Get<bool?>("hasOptedOut"); }
            set { BackingStore?.Set("hasOptedOut", value); }
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
        /// Instantiates a new settings and sets the default values.
        /// </summary>
        public Settings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Settings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Settings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hasGraphMailbox", n => { HasGraphMailbox = n.GetBoolValue(); } },
                {"hasLicense", n => { HasLicense = n.GetBoolValue(); } },
                {"hasOptedOut", n => { HasOptedOut = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hasGraphMailbox", HasGraphMailbox);
            writer.WriteBoolValue("hasLicense", HasLicense);
            writer.WriteBoolValue("hasOptedOut", HasOptedOut);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
