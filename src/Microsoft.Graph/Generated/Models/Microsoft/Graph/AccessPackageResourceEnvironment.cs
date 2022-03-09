using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackageResourceEnvironment : Entity, IParsable {
        /// <summary>Read-only. Required.</summary>
        public List<AccessPackageResource> AccessPackageResources { get; set; }
        /// <summary>Connection information of an environment used to connect to a resource.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectionInfo ConnectionInfo { get; set; }
        /// <summary>The display name of the user that created this object.</summary>
        public string CreatedBy { get; set; }
        /// <summary>The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of this object.</summary>
        public string Description { get; set; }
        /// <summary>The display name of this object.</summary>
        public string DisplayName { get; set; }
        /// <summary>Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.</summary>
        public bool? IsDefaultEnvironment { get; set; }
        /// <summary>The display name of the entity that last modified this object.</summary>
        public string ModifiedBy { get; set; }
        /// <summary>The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>The unique identifier of this environment in the origin system.</summary>
        public string OriginId { get; set; }
        /// <summary>The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).</summary>
        public string OriginSystem { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResourceEnvironment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceEnvironment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResources", (o,n) => { (o as AccessPackageResourceEnvironment).AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue).ToList(); } },
                {"connectionInfo", (o,n) => { (o as AccessPackageResourceEnvironment).ConnectionInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectionInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectionInfo.CreateFromDiscriminatorValue); } },
                {"createdBy", (o,n) => { (o as AccessPackageResourceEnvironment).CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageResourceEnvironment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AccessPackageResourceEnvironment).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageResourceEnvironment).DisplayName = n.GetStringValue(); } },
                {"isDefaultEnvironment", (o,n) => { (o as AccessPackageResourceEnvironment).IsDefaultEnvironment = n.GetBoolValue(); } },
                {"modifiedBy", (o,n) => { (o as AccessPackageResourceEnvironment).ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackageResourceEnvironment).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"originId", (o,n) => { (o as AccessPackageResourceEnvironment).OriginId = n.GetStringValue(); } },
                {"originSystem", (o,n) => { (o as AccessPackageResourceEnvironment).OriginSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectionInfo>("connectionInfo", ConnectionInfo);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDefaultEnvironment", IsDefaultEnvironment);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
        }
    }
}
