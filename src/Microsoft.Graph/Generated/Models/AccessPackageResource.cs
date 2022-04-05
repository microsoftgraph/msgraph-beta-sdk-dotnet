using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResource : Entity, IParsable {
        /// <summary>Contains the environment information for the resource. This can be set using either the @odata.bind annotation or the environment&apos;s originId.Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment AccessPackageResourceEnvironment { get; set; }
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackageResourceRole> AccessPackageResourceRoles { get; set; }
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackageResourceScope> AccessPackageResourceScopes { get; set; }
        /// <summary>The name of the user or application that first added this resource. Read-only.</summary>
        public string AddedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AddedOn { get; set; }
        /// <summary>Contains information about the attributes to be collected from the requestor and sent to the resource application.</summary>
        public List<AccessPackageResourceAttribute> Attributes { get; set; }
        /// <summary>A description for the resource.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the resource, such as the application name, group name or site name.</summary>
        public string DisplayName { get; set; }
        /// <summary>True if the resource is not yet available for assignment.</summary>
        public bool? IsPendingOnboarding { get; set; }
        /// <summary>The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.</summary>
        public string OriginId { get; set; }
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.</summary>
        public string OriginSystem { get; set; }
        /// <summary>The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.</summary>
        public string ResourceType { get; set; }
        /// <summary>A unique resource locator for the resource, such as the URL for signing a user into an application.</summary>
        public string Url { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResourceEnvironment", (o,n) => { (o as AccessPackageResource).AccessPackageResourceEnvironment = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>(Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceRoles", (o,n) => { (o as AccessPackageResource).AccessPackageResourceRoles = n.GetCollectionOfObjectValues<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceScopes", (o,n) => { (o as AccessPackageResource).AccessPackageResourceScopes = n.GetCollectionOfObjectValues<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue).ToList(); } },
                {"addedBy", (o,n) => { (o as AccessPackageResource).AddedBy = n.GetStringValue(); } },
                {"addedOn", (o,n) => { (o as AccessPackageResource).AddedOn = n.GetDateTimeOffsetValue(); } },
                {"attributes", (o,n) => { (o as AccessPackageResource).Attributes = n.GetCollectionOfObjectValues<AccessPackageResourceAttribute>(AccessPackageResourceAttribute.CreateFromDiscriminatorValue).ToList(); } },
                {"description", (o,n) => { (o as AccessPackageResource).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageResource).DisplayName = n.GetStringValue(); } },
                {"isPendingOnboarding", (o,n) => { (o as AccessPackageResource).IsPendingOnboarding = n.GetBoolValue(); } },
                {"originId", (o,n) => { (o as AccessPackageResource).OriginId = n.GetStringValue(); } },
                {"originSystem", (o,n) => { (o as AccessPackageResource).OriginSystem = n.GetStringValue(); } },
                {"resourceType", (o,n) => { (o as AccessPackageResource).ResourceType = n.GetStringValue(); } },
                {"url", (o,n) => { (o as AccessPackageResource).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
