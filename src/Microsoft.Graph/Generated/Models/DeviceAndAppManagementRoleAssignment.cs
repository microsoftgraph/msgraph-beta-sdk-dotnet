using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceAndAppManagementRoleAssignment : RoleAssignment, IParsable {
        /// <summary>The list of ids of role member security groups. These are IDs from Azure Active Directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Members {
            get { return BackingStore?.Get<List<string>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<string> Members {
            get { return BackingStore?.Get<List<string>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The set of Role Scope Tags defined on the Role Assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleScopeTag>? RoleScopeTags {
            get { return BackingStore?.Get<List<RoleScopeTag>?>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
#nullable restore
#else
        public List<RoleScopeTag> RoleScopeTags {
            get { return BackingStore?.Get<List<RoleScopeTag>>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAndAppManagementRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAndAppManagementRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"members", n => { Members = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTag>(RoleScopeTag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("members", Members);
            writer.WriteCollectionOfObjectValues<RoleScopeTag>("roleScopeTags", RoleScopeTags);
        }
    }
}
