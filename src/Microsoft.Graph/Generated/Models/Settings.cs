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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies if the user&apos;s primary mailbox is hosted in the cloud and is enabled for Microsoft Graph.</summary>
        public bool? HasGraphMailbox {
            get { return BackingStore?.Get<bool?>(nameof(HasGraphMailbox)); }
            set { BackingStore?.Set(nameof(HasGraphMailbox), value); }
        }
        /// <summary>Specifies if the user has a MyAnalytics license assigned.</summary>
        public bool? HasLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasLicense)); }
            set { BackingStore?.Set(nameof(HasLicense), value); }
        }
        /// <summary>Specifies if the user opted out of MyAnalytics.</summary>
        public bool? HasOptedOut {
            get { return BackingStore?.Get<bool?>(nameof(HasOptedOut)); }
            set { BackingStore?.Set(nameof(HasOptedOut), value); }
        }
        /// <summary>
        /// Instantiates a new settings and sets the default values.
        /// </summary>
        public Settings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hasGraphMailbox", HasGraphMailbox);
            writer.WriteBoolValue("hasLicense", HasLicense);
            writer.WriteBoolValue("hasOptedOut", HasOptedOut);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
