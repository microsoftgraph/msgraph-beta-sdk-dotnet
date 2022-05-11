using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class RoleAssignment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignmentType property</summary>
        public DelegatedPrivilegeStatus? AssignmentType { get; set; }
        /// <summary>The roles property</summary>
        public List<RoleDefinition> Roles { get; set; }
        /// <summary>
        /// Instantiates a new roleAssignment and sets the default values.
        /// </summary>
        public RoleAssignment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentType", n => { AssignmentType = n.GetEnumValue<DelegatedPrivilegeStatus>(); } },
                {"roles", n => { Roles = n.GetCollectionOfObjectValues<RoleDefinition>(RoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DelegatedPrivilegeStatus>("assignmentType", AssignmentType);
            writer.WriteCollectionOfObjectValues<RoleDefinition>("roles", Roles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
