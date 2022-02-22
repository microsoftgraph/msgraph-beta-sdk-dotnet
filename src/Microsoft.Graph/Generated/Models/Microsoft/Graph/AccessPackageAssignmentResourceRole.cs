using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageAssignmentResourceRole : Entity, IParsable {
        /// <summary>The access package assignments resulting in this role assignment. Read-only. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment> AccessPackageAssignments { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceRole AccessPackageResourceRole { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceScope AccessPackageResourceScope { get; set; }
        /// <summary>Read-only. Nullable. Supports $filter (eq) on objectId and $expand query parameters.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject AccessPackageSubject { get; set; }
        /// <summary>A unique identifier relative to the origin system, corresponding to the originId property of the accessPackageResourceRole.</summary>
        public string OriginId { get; set; }
        /// <summary>The system where the role assignment is to be created or has been created for an access package assignment, such as SharePointOnline, AadGroup or AadApplication, corresponding to the originSystem property of the accessPackageResourceRole.</summary>
        public string OriginSystem { get; set; }
        /// <summary>The value is PendingFulfillment when the access package assignment has not yet been delivered to the origin system, and Fulfilled when the access package assignment has been delivered to the origin system.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignments", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageAssignments = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment>().ToList(); } },
                {"accessPackageResourceRole", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageResourceRole = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceRole>(); } },
                {"accessPackageResourceScope", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageResourceScope = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceScope>(); } },
                {"accessPackageSubject", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageSubject = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject>(); } },
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
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment>("accessPackageAssignments", AccessPackageAssignments);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceRole>("accessPackageResourceRole", AccessPackageResourceRole);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceScope>("accessPackageResourceScope", AccessPackageResourceScope);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageSubject>("accessPackageSubject", AccessPackageSubject);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("status", Status);
        }
    }
}
