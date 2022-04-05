using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAssignmentResourceRole : Entity, IParsable {
        /// <summary>The access package assignments resulting in this role assignment. Read-only. Nullable.</summary>
        public List<AccessPackageAssignment> AccessPackageAssignments { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceRole AccessPackageResourceRole { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResourceScope AccessPackageResourceScope { get; set; }
        /// <summary>Read-only. Nullable. Supports $filter (eq) on objectId and $expand query parameters.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageSubject AccessPackageSubject { get; set; }
        /// <summary>A unique identifier relative to the origin system, corresponding to the originId property of the accessPackageResourceRole.</summary>
        public string OriginId { get; set; }
        /// <summary>The system where the role assignment is to be created or has been created for an access package assignment, such as SharePointOnline, AadGroup or AadApplication, corresponding to the originSystem property of the accessPackageResourceRole.</summary>
        public string OriginSystem { get; set; }
        /// <summary>The value is PendingFulfillment when the access package assignment has not yet been delivered to the origin system, and Fulfilled when the access package assignment has been delivered to the origin system.</summary>
        public string Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageAssignmentResourceRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentResourceRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignments", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageAssignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceRole", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageResourceRole = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>(Microsoft.Graph.Beta.Models.AccessPackageResourceRole.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceScope", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageResourceScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>(Microsoft.Graph.Beta.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue); } },
                {"accessPackageSubject", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageSubject = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageSubject>(Microsoft.Graph.Beta.Models.AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"originId", (o,n) => { (o as AccessPackageAssignmentResourceRole).OriginId = n.GetStringValue(); } },
                {"originSystem", (o,n) => { (o as AccessPackageAssignmentResourceRole).OriginSystem = n.GetStringValue(); } },
                {"status", (o,n) => { (o as AccessPackageAssignmentResourceRole).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
