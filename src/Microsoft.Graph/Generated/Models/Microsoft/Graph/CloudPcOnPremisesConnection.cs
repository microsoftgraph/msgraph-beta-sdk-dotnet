using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudPcOnPremisesConnection : Entity, IParsable {
        /// <summary>The fully qualified domain name (FQDN) of the Active Directory domain you want to join. Optional.</summary>
        public string AdDomainName { get; set; }
        /// <summary>The password associated with adDomainUsername.</summary>
        public string AdDomainPassword { get; set; }
        /// <summary>The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com. Optional.</summary>
        public string AdDomainUsername { get; set; }
        /// <summary>The display name for the on-premises connection.</summary>
        public string DisplayName { get; set; }
        /// <summary>The status of the most recent health check done on the on-premises connection. For example, if status is 'passed', the on-premises connection has passed all checks run by the service. Possible values are: pending, running, passed, failed, unknownFutureValue. Read-only.</summary>
        public CloudPcOnPremisesConnectionStatus? HealthCheckStatus { get; set; }
        /// <summary>The details of the connection's health checks and the corresponding results. Returned only on $select.For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an on-premises connection, including healthCheckStatusDetails. Read-only.</summary>
        public CloudPcOnPremisesConnectionStatusDetails HealthCheckStatusDetails { get; set; }
        /// <summary>When true, the on-premises connection is in use. When false, the connection is not in use. You cannot delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an on-premises connection, including healthCheckStatusDetails. Read-only.</summary>
        public bool? InUse { get; set; }
        /// <summary>The organizational unit (OU) in which the computer account is created. If left null, the OU that’s configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used. Optional.</summary>
        public string OrganizationalUnit { get; set; }
        /// <summary>The ID of the target resource group. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}'.</summary>
        public string ResourceGroupId { get; set; }
        /// <summary>The ID of the target subnet. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}'.</summary>
        public string SubnetId { get; set; }
        /// <summary>The ID of the target Azure subscription that’s associated with your tenant.</summary>
        public string SubscriptionId { get; set; }
        /// <summary>The name of the target Azure subscription. Read-only.</summary>
        public string SubscriptionName { get; set; }
        /// <summary>Specifies how the provisioned Cloud PC will be joined to Azure Active Directory. Default value is hybridAzureADJoin. Possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public CloudPcOnPremisesConnectionType? Type { get; set; }
        /// <summary>The ID of the target virtual network. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}'.</summary>
        public string VirtualNetworkId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"adDomainName", (o,n) => { (o as CloudPcOnPremisesConnection).AdDomainName = n.GetStringValue(); } },
                {"adDomainPassword", (o,n) => { (o as CloudPcOnPremisesConnection).AdDomainPassword = n.GetStringValue(); } },
                {"adDomainUsername", (o,n) => { (o as CloudPcOnPremisesConnection).AdDomainUsername = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CloudPcOnPremisesConnection).DisplayName = n.GetStringValue(); } },
                {"healthCheckStatus", (o,n) => { (o as CloudPcOnPremisesConnection).HealthCheckStatus = n.GetEnumValue<CloudPcOnPremisesConnectionStatus>(); } },
                {"healthCheckStatusDetails", (o,n) => { (o as CloudPcOnPremisesConnection).HealthCheckStatusDetails = n.GetObjectValue<CloudPcOnPremisesConnectionStatusDetails>(); } },
                {"inUse", (o,n) => { (o as CloudPcOnPremisesConnection).InUse = n.GetBoolValue(); } },
                {"organizationalUnit", (o,n) => { (o as CloudPcOnPremisesConnection).OrganizationalUnit = n.GetStringValue(); } },
                {"resourceGroupId", (o,n) => { (o as CloudPcOnPremisesConnection).ResourceGroupId = n.GetStringValue(); } },
                {"subnetId", (o,n) => { (o as CloudPcOnPremisesConnection).SubnetId = n.GetStringValue(); } },
                {"subscriptionId", (o,n) => { (o as CloudPcOnPremisesConnection).SubscriptionId = n.GetStringValue(); } },
                {"subscriptionName", (o,n) => { (o as CloudPcOnPremisesConnection).SubscriptionName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as CloudPcOnPremisesConnection).Type = n.GetEnumValue<CloudPcOnPremisesConnectionType>(); } },
                {"virtualNetworkId", (o,n) => { (o as CloudPcOnPremisesConnection).VirtualNetworkId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("adDomainName", AdDomainName);
            writer.WriteStringValue("adDomainPassword", AdDomainPassword);
            writer.WriteStringValue("adDomainUsername", AdDomainUsername);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionStatus>("healthCheckStatus", HealthCheckStatus);
            writer.WriteObjectValue<CloudPcOnPremisesConnectionStatusDetails>("healthCheckStatusDetails", HealthCheckStatusDetails);
            writer.WriteBoolValue("inUse", InUse);
            writer.WriteStringValue("organizationalUnit", OrganizationalUnit);
            writer.WriteStringValue("resourceGroupId", ResourceGroupId);
            writer.WriteStringValue("subnetId", SubnetId);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("subscriptionName", SubscriptionName);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionType>("type", Type);
            writer.WriteStringValue("virtualNetworkId", VirtualNetworkId);
        }
    }
}
