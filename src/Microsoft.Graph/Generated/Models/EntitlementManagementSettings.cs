using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EntitlementManagementSettings : Entity, IParsable {
        /// <summary>If externalUserLifecycleAction is BlockSignInAndDelete, the number of days after an external user is blocked from sign in before their account is deleted.</summary>
        public int? DaysUntilExternalUserDeletedAfterBlocked { get; set; }
        /// <summary>One of None, BlockSignIn, or BlockSignInAndDelete.</summary>
        public string ExternalUserLifecycleAction { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EntitlementManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"daysUntilExternalUserDeletedAfterBlocked", n => { DaysUntilExternalUserDeletedAfterBlocked = n.GetIntValue(); } },
                {"externalUserLifecycleAction", n => { ExternalUserLifecycleAction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("daysUntilExternalUserDeletedAfterBlocked", DaysUntilExternalUserDeletedAfterBlocked);
            writer.WriteStringValue("externalUserLifecycleAction", ExternalUserLifecycleAction);
        }
    }
}
