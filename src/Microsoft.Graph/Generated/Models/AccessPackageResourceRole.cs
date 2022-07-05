using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class AccessPackageResourceRole : Entity, IParsable {
        /// <summary>The accessPackageResource property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource>(nameof(AccessPackageResource)); }
            set { BackingStore?.Set(nameof(AccessPackageResource), value); }
        }
        /// <summary>A description for the resource role.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of the resource role such as the role defined by the application.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.</summary>
        public string OriginId {
            get { return BackingStore?.Get<string>(nameof(OriginId)); }
            set { BackingStore?.Set(nameof(OriginId), value); }
        }
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.</summary>
        public string OriginSystem {
            get { return BackingStore?.Get<string>(nameof(OriginSystem)); }
            set { BackingStore?.Set(nameof(OriginSystem), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResourceRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResource", n => { AccessPackageResource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
        }
    }
}
