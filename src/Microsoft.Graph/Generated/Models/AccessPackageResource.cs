using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReview entities.
    /// </summary>
    public class AccessPackageResource : Entity, IParsable {
        /// <summary>Contains the environment information for the resource. This can be set using either the @odata.bind annotation or the environment&apos;s originId.Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment AccessPackageResourceEnvironment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>("accessPackageResourceEnvironment"); }
            set { BackingStore?.Set("accessPackageResourceEnvironment", value); }
        }
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackageResourceRole> AccessPackageResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>>("accessPackageResourceRoles"); }
            set { BackingStore?.Set("accessPackageResourceRoles", value); }
        }
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackageResourceScope> AccessPackageResourceScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>>("accessPackageResourceScopes"); }
            set { BackingStore?.Set("accessPackageResourceScopes", value); }
        }
        /// <summary>The name of the user or application that first added this resource. Read-only.</summary>
        public string AddedBy {
            get { return BackingStore?.Get<string>("addedBy"); }
            set { BackingStore?.Set("addedBy", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? AddedOn {
            get { return BackingStore?.Get<DateTimeOffset?>("addedOn"); }
            set { BackingStore?.Set("addedOn", value); }
        }
        /// <summary>Contains information about the attributes to be collected from the requestor and sent to the resource application.</summary>
        public List<AccessPackageResourceAttribute> Attributes {
            get { return BackingStore?.Get<List<AccessPackageResourceAttribute>>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
        /// <summary>A description for the resource.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name of the resource, such as the application name, group name or site name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>True if the resource is not yet available for assignment. Read-only.</summary>
        public bool? IsPendingOnboarding {
            get { return BackingStore?.Get<bool?>("isPendingOnboarding"); }
            set { BackingStore?.Set("isPendingOnboarding", value); }
        }
        /// <summary>The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.</summary>
        public string OriginId {
            get { return BackingStore?.Get<string>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.</summary>
        public string OriginSystem {
            get { return BackingStore?.Get<string>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
        /// <summary>The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.</summary>
        public string ResourceType {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
        /// <summary>A unique resource locator for the resource, such as the URL for signing a user into an application.</summary>
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResourceEnvironment", n => { AccessPackageResourceEnvironment = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>(Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceRoles", n => { AccessPackageResourceRoles = n.GetCollectionOfObjectValues<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResourceScopes", n => { AccessPackageResourceScopes = n.GetCollectionOfObjectValues<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"addedBy", n => { AddedBy = n.GetStringValue(); } },
                {"addedOn", n => { AddedOn = n.GetDateTimeOffsetValue(); } },
                {"attributes", n => { Attributes = n.GetCollectionOfObjectValues<AccessPackageResourceAttribute>(AccessPackageResourceAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isPendingOnboarding", n => { IsPendingOnboarding = n.GetBoolValue(); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
                {"resourceType", n => { ResourceType = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>("accessPackageResourceEnvironment", AccessPackageResourceEnvironment);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRole>("accessPackageResourceRoles", AccessPackageResourceRoles);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceScope>("accessPackageResourceScopes", AccessPackageResourceScopes);
            writer.WriteStringValue("addedBy", AddedBy);
            writer.WriteDateTimeOffsetValue("addedOn", AddedOn);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceAttribute>("attributes", Attributes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isPendingOnboarding", IsPendingOnboarding);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteStringValue("url", Url);
        }
    }
}
