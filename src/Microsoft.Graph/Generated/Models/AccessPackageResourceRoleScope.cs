using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackageResourceRoleScope : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceRole AccessPackageResourceRole {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>(nameof(AccessPackageResourceRole)); }
            set { BackingStore?.Set(nameof(AccessPackageResourceRole), value); }
        }
        /// <summary>The accessPackageResourceScope property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceScope AccessPackageResourceScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>(nameof(AccessPackageResourceScope)); }
            set { BackingStore?.Set(nameof(AccessPackageResourceScope), value); }
        }
        /// <summary>The createdBy property</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The modifiedBy property</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>(nameof(ModifiedBy)); }
            set { BackingStore?.Set(nameof(ModifiedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ModifiedDateTime)); }
            set { BackingStore?.Set(nameof(ModifiedDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResourceRoleScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceRoleScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResourceRole", n => { AccessPackageResourceRole = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>(Microsoft.Graph.Beta.Models.AccessPackageResourceRole.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceScope", n => { AccessPackageResourceScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>(Microsoft.Graph.Beta.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>("accessPackageResourceRole", AccessPackageResourceRole);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>("accessPackageResourceScope", AccessPackageResourceScope);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
