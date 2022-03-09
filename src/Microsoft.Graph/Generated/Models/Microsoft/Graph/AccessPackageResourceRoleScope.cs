using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackageResourceRoleScope : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole AccessPackageResourceRole { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope AccessPackageResourceScope { get; set; }
        /// <summary>Read-only.</summary>
        public string CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only.</summary>
        public string ModifiedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResourceRole", (o,n) => { (o as AccessPackageResourceRoleScope).AccessPackageResourceRole = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceScope", (o,n) => { (o as AccessPackageResourceRoleScope).AccessPackageResourceScope = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope.CreateFromDiscriminatorValue); } },
                {"createdBy", (o,n) => { (o as AccessPackageResourceRoleScope).CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageResourceRoleScope).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedBy", (o,n) => { (o as AccessPackageResourceRoleScope).ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackageResourceRoleScope).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole>("accessPackageResourceRole", AccessPackageResourceRole);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope>("accessPackageResourceScope", AccessPackageResourceScope);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
