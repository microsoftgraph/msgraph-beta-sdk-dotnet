using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class AccessPackageResourceRoleScope : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceRole AccessPackageResourceRole {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>("accessPackageResourceRole"); }
            set { BackingStore?.Set("accessPackageResourceRole", value); }
        }
        /// <summary>The accessPackageResourceScope property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceScope AccessPackageResourceScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>("accessPackageResourceScope"); }
            set { BackingStore?.Set("accessPackageResourceScope", value); }
        }
        /// <summary>The createdBy property</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The modifiedBy property</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageResourceRoleScope and sets the default values.
        /// </summary>
        public AccessPackageResourceRoleScope() : base() {
            OdataType = "#microsoft.graph.accessPackageResourceRoleScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
