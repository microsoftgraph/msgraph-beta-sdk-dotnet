using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationRedirectSettingDefinition : DeviceManagementConfigurationSettingDefinition, IParsable {
        /// <summary>A deep link that points to the specific location in the Intune console where feature support must be managed from.</summary>
        public string DeepLink {
            get { return BackingStore?.Get<string>("deepLink"); }
            set { BackingStore?.Set("deepLink", value); }
        }
        /// <summary>A message that explains that clicking the link will redirect the user to a supported page to manage the settings.</summary>
        public string RedirectMessage {
            get { return BackingStore?.Get<string>("redirectMessage"); }
            set { BackingStore?.Set("redirectMessage", value); }
        }
        /// <summary>Indicates the reason for redirecting the user to an alternative location in the console.  For example: WiFi profiles are not supported in the settings catalog and must be created with a template policy.</summary>
        public string RedirectReason {
            get { return BackingStore?.Get<string>("redirectReason"); }
            set { BackingStore?.Set("redirectReason", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationRedirectSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationRedirectSettingDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deepLink", n => { DeepLink = n.GetStringValue(); } },
                {"redirectMessage", n => { RedirectMessage = n.GetStringValue(); } },
                {"redirectReason", n => { RedirectReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deepLink", DeepLink);
            writer.WriteStringValue("redirectMessage", RedirectMessage);
            writer.WriteStringValue("redirectReason", RedirectReason);
        }
    }
}
