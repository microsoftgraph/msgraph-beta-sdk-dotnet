using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoleMembershipGovernanceCriteria : GovernanceCriteria, IParsable {
        /// <summary>The roleId property</summary>
        public string RoleId {
            get { return BackingStore?.Get<string>(nameof(RoleId)); }
            set { BackingStore?.Set(nameof(RoleId), value); }
        }
        /// <summary>The roleTemplateId property</summary>
        public string RoleTemplateId {
            get { return BackingStore?.Get<string>(nameof(RoleTemplateId)); }
            set { BackingStore?.Set(nameof(RoleTemplateId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RoleMembershipGovernanceCriteria CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleMembershipGovernanceCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
        }
    }
}
