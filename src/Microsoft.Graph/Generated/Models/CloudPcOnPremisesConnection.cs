using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class CloudPcOnPremisesConnection : Entity, IParsable {
        /// <summary>The fully qualified domain name (FQDN) of the Active Directory domain you want to join. Optional.</summary>
        public string AdDomainName {
            get { return BackingStore?.Get<string>(nameof(AdDomainName)); }
            set { BackingStore?.Set(nameof(AdDomainName), value); }
        }
        /// <summary>The password associated with adDomainUsername.</summary>
        public string AdDomainPassword {
            get { return BackingStore?.Get<string>(nameof(AdDomainPassword)); }
            set { BackingStore?.Set(nameof(AdDomainPassword), value); }
        }
        /// <summary>The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com. Optional.</summary>
        public string AdDomainUsername {
            get { return BackingStore?.Get<string>(nameof(AdDomainUsername)); }
            set { BackingStore?.Set(nameof(AdDomainUsername), value); }
        }
        /// <summary>The interface URL of the partner service&apos;s resource that links to this Azure network connection. Returned only on $select.</summary>
        public string AlternateResourceUrl {
            get { return BackingStore?.Get<string>(nameof(AlternateResourceUrl)); }
            set { BackingStore?.Set(nameof(AlternateResourceUrl), value); }
        }
        /// <summary>The display name for the Azure network connection.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The status of the most recent health check done on the Azure network connection. For example, if status is passed, the Azure network connection has passed all checks run by the service. Possible values are: pending, running, passed, failed, unknownFutureValue. Read-only.</summary>
        public CloudPcOnPremisesConnectionStatus? HealthCheckStatus {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatus?>(nameof(HealthCheckStatus)); }
            set { BackingStore?.Set(nameof(HealthCheckStatus), value); }
        }
        /// <summary>The details of the connection&apos;s health checks and the corresponding results. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails. Read-only.</summary>
        public CloudPcOnPremisesConnectionStatusDetails HealthCheckStatusDetails {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatusDetails>(nameof(HealthCheckStatusDetails)); }
            set { BackingStore?.Set(nameof(HealthCheckStatusDetails), value); }
        }
        /// <summary>When true, the Azure network connection is in use. When false, the connection is not in use. You cannot delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails. Read-only.</summary>
        public bool? InUse {
            get { return BackingStore?.Get<bool?>(nameof(InUse)); }
            set { BackingStore?.Set(nameof(InUse), value); }
        }
        /// <summary>Specifies which services manage the Azure network connection. Possible values are: windows365, devBox, unknownFutureValue. Read-only.</summary>
        public CloudPcManagementService? ManagedBy {
            get { return BackingStore?.Get<CloudPcManagementService?>(nameof(ManagedBy)); }
            set { BackingStore?.Set(nameof(ManagedBy), value); }
        }
        /// <summary>The organizational unit (OU) in which the computer account is created. If left null, the OU that’s configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used. Optional.</summary>
        public string OrganizationalUnit {
            get { return BackingStore?.Get<string>(nameof(OrganizationalUnit)); }
            set { BackingStore?.Set(nameof(OrganizationalUnit), value); }
        }
        /// <summary>The ID of the target resource group. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}.</summary>
        public string ResourceGroupId {
            get { return BackingStore?.Get<string>(nameof(ResourceGroupId)); }
            set { BackingStore?.Set(nameof(ResourceGroupId), value); }
        }
        /// <summary>The ID of the target subnet. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}.</summary>
        public string SubnetId {
            get { return BackingStore?.Get<string>(nameof(SubnetId)); }
            set { BackingStore?.Set(nameof(SubnetId), value); }
        }
        /// <summary>The ID of the target Azure subscription that’s associated with your tenant.</summary>
        public string SubscriptionId {
            get { return BackingStore?.Get<string>(nameof(SubscriptionId)); }
            set { BackingStore?.Set(nameof(SubscriptionId), value); }
        }
        /// <summary>The name of the target Azure subscription. Read-only.</summary>
        public string SubscriptionName {
            get { return BackingStore?.Get<string>(nameof(SubscriptionName)); }
            set { BackingStore?.Set(nameof(SubscriptionName), value); }
        }
        /// <summary>Specifies how the provisioned Cloud PC will be joined to Azure Active Directory. Default value is hybridAzureADJoin. Possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public CloudPcOnPremisesConnectionType? Type {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>The ID of the target virtual network. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}.</summary>
        public string VirtualNetworkId {
            get { return BackingStore?.Get<string>(nameof(VirtualNetworkId)); }
            set { BackingStore?.Set(nameof(VirtualNetworkId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcOnPremisesConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOnPremisesConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"adDomainName", n => { AdDomainName = n.GetStringValue(); } },
                {"adDomainPassword", n => { AdDomainPassword = n.GetStringValue(); } },
                {"adDomainUsername", n => { AdDomainUsername = n.GetStringValue(); } },
                {"alternateResourceUrl", n => { AlternateResourceUrl = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"healthCheckStatus", n => { HealthCheckStatus = n.GetEnumValue<CloudPcOnPremisesConnectionStatus>(); } },
                {"healthCheckStatusDetails", n => { HealthCheckStatusDetails = n.GetObjectValue<CloudPcOnPremisesConnectionStatusDetails>(CloudPcOnPremisesConnectionStatusDetails.CreateFromDiscriminatorValue); } },
                {"inUse", n => { InUse = n.GetBoolValue(); } },
                {"managedBy", n => { ManagedBy = n.GetEnumValue<CloudPcManagementService>(); } },
                {"organizationalUnit", n => { OrganizationalUnit = n.GetStringValue(); } },
                {"resourceGroupId", n => { ResourceGroupId = n.GetStringValue(); } },
                {"subnetId", n => { SubnetId = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"subscriptionName", n => { SubscriptionName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<CloudPcOnPremisesConnectionType>(); } },
                {"virtualNetworkId", n => { VirtualNetworkId = n.GetStringValue(); } },
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
            writer.WriteStringValue("alternateResourceUrl", AlternateResourceUrl);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionStatus>("healthCheckStatus", HealthCheckStatus);
            writer.WriteObjectValue<CloudPcOnPremisesConnectionStatusDetails>("healthCheckStatusDetails", HealthCheckStatusDetails);
            writer.WriteBoolValue("inUse", InUse);
            writer.WriteEnumValue<CloudPcManagementService>("managedBy", ManagedBy);
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
