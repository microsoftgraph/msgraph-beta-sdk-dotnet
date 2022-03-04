using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceAndAppManagementAssignedRoleDetails : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Role Assignment IDs for the specifc Role Assignments assigned to a user. This property is read-only.</summary>
        public List<string> RoleAssignmentIds { get; set; }
        /// <summary>Role Definition IDs for the specifc Role Definitions assigned to a user. This property is read-only.</summary>
        public List<string> RoleDefinitionIds { get; set; }
        /// <summary>
        /// Instantiates a new deviceAndAppManagementAssignedRoleDetails and sets the default values.
        /// </summary>
        public DeviceAndAppManagementAssignedRoleDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceAndAppManagementAssignedRoleDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAndAppManagementAssignedRoleDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"roleAssignmentIds", (o,n) => { (o as DeviceAndAppManagementAssignedRoleDetails).RoleAssignmentIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"roleDefinitionIds", (o,n) => { (o as DeviceAndAppManagementAssignedRoleDetails).RoleDefinitionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("roleAssignmentIds", RoleAssignmentIds);
            writer.WriteCollectionOfPrimitiveValues<string>("roleDefinitionIds", RoleDefinitionIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
