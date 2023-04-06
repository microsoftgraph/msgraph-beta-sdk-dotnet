using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamsAppSettings : Entity, IParsable {
        /// <summary>Indicates whether Teams users are allowed to request admins access to certain Teams apps.</summary>
        public bool? AllowUserRequestsForAppAccess {
            get { return BackingStore?.Get<bool?>("allowUserRequestsForAppAccess"); }
            set { BackingStore?.Set("allowUserRequestsForAppAccess", value); }
        }
        /// <summary>Indicates whether resource-specific consent for chats/meetings has been enabled for the tenant. If true, Teams apps that are allowed in the tenant and require resource-specific permissions can be installed inside chats and meetings. If false, the installation of any Teams app that requires resource-specific permissions in a chat or a meeting will be blocked.</summary>
        public bool? IsChatResourceSpecificConsentEnabled {
            get { return BackingStore?.Get<bool?>("isChatResourceSpecificConsentEnabled"); }
            set { BackingStore?.Set("isChatResourceSpecificConsentEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsAppSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowUserRequestsForAppAccess", n => { AllowUserRequestsForAppAccess = n.GetBoolValue(); } },
                {"isChatResourceSpecificConsentEnabled", n => { IsChatResourceSpecificConsentEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowUserRequestsForAppAccess", AllowUserRequestsForAppAccess);
            writer.WriteBoolValue("isChatResourceSpecificConsentEnabled", IsChatResourceSpecificConsentEnabled);
        }
    }
}
