using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementActionTenantDeploymentStatus : Entity, IParsable {
        /// <summary>The collection of deployment status for each instance of a management action. Optional.</summary>
        public List<ManagementActionDeploymentStatus> Statuses { get; set; }
        /// <summary>The identifier for the tenant group that is associated with the management action. Required. Read-only.</summary>
        public string TenantGroupId { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"statuses", (o,n) => { (o as ManagementActionTenantDeploymentStatus).Statuses = n.GetCollectionOfObjectValues<ManagementActionDeploymentStatus>().ToList(); } },
                {"tenantGroupId", (o,n) => { (o as ManagementActionTenantDeploymentStatus).TenantGroupId = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as ManagementActionTenantDeploymentStatus).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagementActionDeploymentStatus>("statuses", Statuses);
            writer.WriteStringValue("tenantGroupId", TenantGroupId);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
