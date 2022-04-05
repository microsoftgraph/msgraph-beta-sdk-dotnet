using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResourceScope : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource { get; set; }
        /// <summary>The description of the scope.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the scope.</summary>
        public string DisplayName { get; set; }
        /// <summary>True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.</summary>
        public bool? IsRootScope { get; set; }
        /// <summary>The unique identifier for the scope in the resource as defined in the origin system.</summary>
        public string OriginId { get; set; }
        /// <summary>The origin system for the scope.</summary>
        public string OriginSystem { get; set; }
        /// <summary>The origin system for the role, if different.</summary>
        public string RoleOriginId { get; set; }
        /// <summary>A resource locator for the scope.</summary>
        public string Url { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResourceScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResource", (o,n) => { (o as AccessPackageResourceScope).AccessPackageResource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as AccessPackageResourceScope).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageResourceScope).DisplayName = n.GetStringValue(); } },
                {"isRootScope", (o,n) => { (o as AccessPackageResourceScope).IsRootScope = n.GetBoolValue(); } },
                {"originId", (o,n) => { (o as AccessPackageResourceScope).OriginId = n.GetStringValue(); } },
                {"originSystem", (o,n) => { (o as AccessPackageResourceScope).OriginSystem = n.GetStringValue(); } },
                {"roleOriginId", (o,n) => { (o as AccessPackageResourceScope).RoleOriginId = n.GetStringValue(); } },
                {"url", (o,n) => { (o as AccessPackageResourceScope).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isRootScope", IsRootScope);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("roleOriginId", RoleOriginId);
            writer.WriteStringValue("url", Url);
        }
    }
}
