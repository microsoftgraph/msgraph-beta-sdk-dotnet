using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcOnPremisesConnection : Entity, IParsable {
        /// <summary>The fully qualified domain name (FQDN) of the Active Directory domain you want to join. Optional.</summary>
        public string AdDomainName {
            get { return BackingStore?.Get<string>("adDomainName"); }
            set { BackingStore?.Set("adDomainName", value); }
        }
        /// <summary>The password associated with adDomainUsername.</summary>
        public string AdDomainPassword {
            get { return BackingStore?.Get<string>("adDomainPassword"); }
            set { BackingStore?.Set("adDomainPassword", value); }
        }
        /// <summary>The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com. Optional.</summary>
        public string AdDomainUsername {
            get { return BackingStore?.Get<string>("adDomainUsername"); }
            set { BackingStore?.Set("adDomainUsername", value); }
        }
        /// <summary>The interface URL of the partner service&apos;s resource that links to this Azure network connection. Returned only on $select.</summary>
        public string AlternateResourceUrl {
            get { return BackingStore?.Get<string>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
        /// <summary>The display name for the Azure network connection.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The healthCheckStatus property</summary>
        public CloudPcOnPremisesConnectionStatus? HealthCheckStatus {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatus?>("healthCheckStatus"); }
            set { BackingStore?.Set("healthCheckStatus", value); }
        }
        /// <summary>The details of the connection&apos;s health checks and the corresponding results. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails. Read-only.</summary>
        public CloudPcOnPremisesConnectionStatusDetails HealthCheckStatusDetails {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatusDetails>("healthCheckStatusDetails"); }
            set { BackingStore?.Set("healthCheckStatusDetails", value); }
        }
        /// <summary>When true, the Azure network connection is in use. When false, the connection is not in use. You cannot delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails. Read-only.</summary>
        public bool? InUse {
            get { return BackingStore?.Get<bool?>("inUse"); }
            set { BackingStore?.Set("inUse", value); }
        }
        /// <summary>The managedBy property</summary>
        public CloudPcManagementService? ManagedBy {
            get { return BackingStore?.Get<CloudPcManagementService?>("managedBy"); }
            set { BackingStore?.Set("managedBy", value); }
        }
        /// <summary>The organizational unit (OU) in which the computer account is created. If left null, the OU that’s configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used. Optional.</summary>
        public string OrganizationalUnit {
            get { return BackingStore?.Get<string>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
        /// <summary>The ID of the target resource group. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}.</summary>
        public string ResourceGroupId {
            get { return BackingStore?.Get<string>("resourceGroupId"); }
            set { BackingStore?.Set("resourceGroupId", value); }
        }
        /// <summary>The ID of the target subnet. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}.</summary>
        public string SubnetId {
            get { return BackingStore?.Get<string>("subnetId"); }
            set { BackingStore?.Set("subnetId", value); }
        }
        /// <summary>The ID of the target Azure subscription that’s associated with your tenant.</summary>
        public string SubscriptionId {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
        /// <summary>The name of the target Azure subscription. Read-only.</summary>
        public string SubscriptionName {
            get { return BackingStore?.Get<string>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
        /// <summary>Specifies how the provisioned Cloud PC will be joined to Azure Active Directory. Default value is hybridAzureADJoin. Possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public CloudPcOnPremisesConnectionType? Type {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The ID of the target virtual network. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}.</summary>
        public string VirtualNetworkId {
            get { return BackingStore?.Get<string>("virtualNetworkId"); }
            set { BackingStore?.Set("virtualNetworkId", value); }
        }
        /// <summary>
        /// Instantiates a new CloudPcOnPremisesConnection and sets the default values.
        /// </summary>
        public CloudPcOnPremisesConnection() : base() {
            OdataType = "#microsoft.graph.cloudPcOnPremisesConnection";
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
