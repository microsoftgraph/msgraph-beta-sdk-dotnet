using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernanceRoleDefinition : Entity, IParsable {
        /// <summary>The display name of the role definition.</summary>
        public string DisplayName { get; set; }
        /// <summary>The external id of the role definition.</summary>
        public string ExternalId { get; set; }
        /// <summary>Read-only. The associated resource for the role definition.</summary>
        public GovernanceResource Resource { get; set; }
        /// <summary>Required. The id of the resource associated with the role definition.</summary>
        public string ResourceId { get; set; }
        /// <summary>The associated role setting for the role definition.</summary>
        public GovernanceRoleSetting RoleSetting { get; set; }
        public string TemplateId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernanceRoleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as GovernanceRoleDefinition).DisplayName = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as GovernanceRoleDefinition).ExternalId = n.GetStringValue(); } },
                {"resource", (o,n) => { (o as GovernanceRoleDefinition).Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"resourceId", (o,n) => { (o as GovernanceRoleDefinition).ResourceId = n.GetStringValue(); } },
                {"roleSetting", (o,n) => { (o as GovernanceRoleDefinition).RoleSetting = n.GetObjectValue<GovernanceRoleSetting>(GovernanceRoleSetting.CreateFromDiscriminatorValue); } },
                {"templateId", (o,n) => { (o as GovernanceRoleDefinition).TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleSetting>("roleSetting", RoleSetting);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}
