using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignmentResourceRole : Entity, IParsable {
        /// <summary>The access package assignments resulting in this role assignment. Read-only. Nullable.</summary>
        public List<AccessPackageAssignment> AccessPackageAssignments { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole AccessPackageResourceRole { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope AccessPackageResourceScope { get; set; }
        /// <summary>Read-only. Nullable. Supports $filter (eq) on objectId and $expand query parameters.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageSubject AccessPackageSubject { get; set; }
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
                {"accessPackageResourceRole", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageResourceRole = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceScope", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageResourceScope = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope.CreateFromDiscriminatorValue); } },
                {"accessPackageSubject", (o,n) => { (o as AccessPackageAssignmentResourceRole).AccessPackageSubject = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageSubject>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageSubject.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceRole>("accessPackageResourceRole", AccessPackageResourceRole);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResourceScope>("accessPackageResourceScope", AccessPackageResourceScope);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageSubject>("accessPackageSubject", AccessPackageSubject);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("status", Status);
        }
    }
}
