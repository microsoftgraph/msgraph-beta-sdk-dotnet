using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class AccessPackageResourceEnvironment : Entity, IParsable {
        /// <summary>Read-only. Required.</summary>
        public List<AccessPackageResource> AccessPackageResources {
            get { return BackingStore?.Get<List<AccessPackageResource>>(nameof(AccessPackageResources)); }
            set { BackingStore?.Set(nameof(AccessPackageResources), value); }
        }
        /// <summary>Connection information of an environment used to connect to a resource.</summary>
        public Microsoft.Graph.Beta.Models.ConnectionInfo ConnectionInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectionInfo>(nameof(ConnectionInfo)); }
            set { BackingStore?.Set(nameof(ConnectionInfo), value); }
        }
        /// <summary>The display name of the user that created this object.</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The description of this object.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of this object.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.</summary>
        public bool? IsDefaultEnvironment {
            get { return BackingStore?.Get<bool?>(nameof(IsDefaultEnvironment)); }
            set { BackingStore?.Set(nameof(IsDefaultEnvironment), value); }
        }
        /// <summary>The display name of the entity that last modified this object.</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>(nameof(ModifiedBy)); }
            set { BackingStore?.Set(nameof(ModifiedBy), value); }
        }
        /// <summary>The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ModifiedDateTime)); }
            set { BackingStore?.Set(nameof(ModifiedDateTime), value); }
        }
        /// <summary>The unique identifier of this environment in the origin system.</summary>
        public string OriginId {
            get { return BackingStore?.Get<string>(nameof(OriginId)); }
            set { BackingStore?.Set(nameof(OriginId), value); }
        }
        /// <summary>The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).</summary>
        public string OriginSystem {
            get { return BackingStore?.Get<string>(nameof(OriginSystem)); }
            set { BackingStore?.Set(nameof(OriginSystem), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue).ToList(); } },
                {"connectionInfo", n => { ConnectionInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConnectionInfo>(Microsoft.Graph.Beta.Models.ConnectionInfo.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isDefaultEnvironment", n => { IsDefaultEnvironment = n.GetBoolValue(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConnectionInfo>("connectionInfo", ConnectionInfo);
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
