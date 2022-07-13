using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExternalIdentitiesPolicy : PolicyBase, IParsable {
        /// <summary>Notifies Azure AD whether to clean up the user information about the external identity, from the guest tenant, when the user is deleted in their home tenant.</summary>
        public bool? AllowDeletedIdentitiesDataRemoval {
            get { return BackingStore?.Get<bool?>("allowDeletedIdentitiesDataRemoval"); }
            set { BackingStore?.Set("allowDeletedIdentitiesDataRemoval", value); }
        }
        /// <summary>Defines whether external users can leave the guest tenant. If set to false, self-service controls are not enabled, and the admin of the guest tenant must manually remove the external user from the guest tenant.</summary>
        public bool? AllowExternalIdentitiesToLeave {
            get { return BackingStore?.Get<bool?>("allowExternalIdentitiesToLeave"); }
            set { BackingStore?.Set("allowExternalIdentitiesToLeave", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExternalIdentitiesPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalIdentitiesPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDeletedIdentitiesDataRemoval", n => { AllowDeletedIdentitiesDataRemoval = n.GetBoolValue(); } },
                {"allowExternalIdentitiesToLeave", n => { AllowExternalIdentitiesToLeave = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDeletedIdentitiesDataRemoval", AllowDeletedIdentitiesDataRemoval);
            writer.WriteBoolValue("allowExternalIdentitiesToLeave", AllowExternalIdentitiesToLeave);
        }
    }
}
