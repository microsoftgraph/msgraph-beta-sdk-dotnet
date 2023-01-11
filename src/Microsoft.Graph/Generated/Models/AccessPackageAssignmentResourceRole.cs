using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAssignmentResourceRole : Entity, IParsable {
        /// <summary>The access package assignments resulting in this role assignment. Read-only. Nullable.</summary>
        public List<AccessPackageAssignment> AccessPackageAssignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>>("accessPackageAssignments"); }
            set { BackingStore?.Set("accessPackageAssignments", value); }
        }
        /// <summary>The accessPackageResourceRole property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceRole AccessPackageResourceRole {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>("accessPackageResourceRole"); }
            set { BackingStore?.Set("accessPackageResourceRole", value); }
        }
        /// <summary>The accessPackageResourceScope property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceScope AccessPackageResourceScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>("accessPackageResourceScope"); }
            set { BackingStore?.Set("accessPackageResourceScope", value); }
        }
        /// <summary>Read-only. Nullable. Supports $filter (eq) on objectId and $expand query parameters.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageSubject AccessPackageSubject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageSubject>("accessPackageSubject"); }
            set { BackingStore?.Set("accessPackageSubject", value); }
        }
        /// <summary>A unique identifier relative to the origin system, corresponding to the originId property of the accessPackageResourceRole.</summary>
        public string OriginId {
            get { return BackingStore?.Get<string>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
        /// <summary>The system where the role assignment is to be created or has been created for an access package assignment, such as SharePointOnline, AadGroup or AadApplication, corresponding to the originSystem property of the accessPackageResourceRole.</summary>
        public string OriginSystem {
            get { return BackingStore?.Get<string>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
        /// <summary>The value is PendingFulfillment when the access package assignment has not yet been delivered to the origin system, and Fulfilled when the access package assignment has been delivered to the origin system.</summary>
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentResourceRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentResourceRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignments", n => { AccessPackageAssignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResourceRole", n => { AccessPackageResourceRole = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>(Microsoft.Graph.Beta.Models.AccessPackageResourceRole.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceScope", n => { AccessPackageResourceScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>(Microsoft.Graph.Beta.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue); } },
                {"accessPackageSubject", n => { AccessPackageSubject = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageSubject>(Microsoft.Graph.Beta.Models.AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("accessPackageAssignments", AccessPackageAssignments);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>("accessPackageResourceRole", AccessPackageResourceRole);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>("accessPackageResourceScope", AccessPackageResourceScope);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageSubject>("accessPackageSubject", AccessPackageSubject);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("status", Status);
        }
    }
}
