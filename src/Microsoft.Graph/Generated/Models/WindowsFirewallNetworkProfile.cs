using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows Firewall Profile Policies.</summary>
    public class WindowsFirewallNetworkProfile : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Configures the firewall to merge authorized application rules from group policy with those from local store instead of ignoring the local store rules. When AuthorizedApplicationRulesFromGroupPolicyNotMerged and AuthorizedApplicationRulesFromGroupPolicyMerged are both true, AuthorizedApplicationRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? AuthorizedApplicationRulesFromGroupPolicyMerged {
            get { return BackingStore?.Get<bool?>(nameof(AuthorizedApplicationRulesFromGroupPolicyMerged)); }
            set { BackingStore?.Set(nameof(AuthorizedApplicationRulesFromGroupPolicyMerged), value); }
        }
        /// <summary>Configures the firewall to prevent merging authorized application rules from group policy with those from local store instead of ignoring the local store rules. When AuthorizedApplicationRulesFromGroupPolicyNotMerged and AuthorizedApplicationRulesFromGroupPolicyMerged are both true, AuthorizedApplicationRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? AuthorizedApplicationRulesFromGroupPolicyNotMerged {
            get { return BackingStore?.Get<bool?>(nameof(AuthorizedApplicationRulesFromGroupPolicyNotMerged)); }
            set { BackingStore?.Set(nameof(AuthorizedApplicationRulesFromGroupPolicyNotMerged), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Configures the firewall to merge connection security rules from group policy with those from local store instead of ignoring the local store rules. When ConnectionSecurityRulesFromGroupPolicyNotMerged and ConnectionSecurityRulesFromGroupPolicyMerged are both true, ConnectionSecurityRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? ConnectionSecurityRulesFromGroupPolicyMerged {
            get { return BackingStore?.Get<bool?>(nameof(ConnectionSecurityRulesFromGroupPolicyMerged)); }
            set { BackingStore?.Set(nameof(ConnectionSecurityRulesFromGroupPolicyMerged), value); }
        }
        /// <summary>Configures the firewall to prevent merging connection security rules from group policy with those from local store instead of ignoring the local store rules. When ConnectionSecurityRulesFromGroupPolicyNotMerged and ConnectionSecurityRulesFromGroupPolicyMerged are both true, ConnectionSecurityRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? ConnectionSecurityRulesFromGroupPolicyNotMerged {
            get { return BackingStore?.Get<bool?>(nameof(ConnectionSecurityRulesFromGroupPolicyNotMerged)); }
            set { BackingStore?.Set(nameof(ConnectionSecurityRulesFromGroupPolicyNotMerged), value); }
        }
        /// <summary>Configures the host device to allow or block the firewall and advanced security enforcement for the network profile. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? FirewallEnabled {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(FirewallEnabled)); }
            set { BackingStore?.Set(nameof(FirewallEnabled), value); }
        }
        /// <summary>Configures the firewall to merge global port rules from group policy with those from local store instead of ignoring the local store rules. When GlobalPortRulesFromGroupPolicyNotMerged and GlobalPortRulesFromGroupPolicyMerged are both true, GlobalPortRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? GlobalPortRulesFromGroupPolicyMerged {
            get { return BackingStore?.Get<bool?>(nameof(GlobalPortRulesFromGroupPolicyMerged)); }
            set { BackingStore?.Set(nameof(GlobalPortRulesFromGroupPolicyMerged), value); }
        }
        /// <summary>Configures the firewall to prevent merging global port rules from group policy with those from local store instead of ignoring the local store rules. When GlobalPortRulesFromGroupPolicyNotMerged and GlobalPortRulesFromGroupPolicyMerged are both true, GlobalPortRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? GlobalPortRulesFromGroupPolicyNotMerged {
            get { return BackingStore?.Get<bool?>(nameof(GlobalPortRulesFromGroupPolicyNotMerged)); }
            set { BackingStore?.Set(nameof(GlobalPortRulesFromGroupPolicyNotMerged), value); }
        }
        /// <summary>Configures the firewall to block all incoming connections by default. When InboundConnectionsRequired and InboundConnectionsBlocked are both true, InboundConnectionsBlocked takes priority.</summary>
        public bool? InboundConnectionsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(InboundConnectionsBlocked)); }
            set { BackingStore?.Set(nameof(InboundConnectionsBlocked), value); }
        }
        /// <summary>Configures the firewall to allow all incoming connections by default. When InboundConnectionsRequired and InboundConnectionsBlocked are both true, InboundConnectionsBlocked takes priority.</summary>
        public bool? InboundConnectionsRequired {
            get { return BackingStore?.Get<bool?>(nameof(InboundConnectionsRequired)); }
            set { BackingStore?.Set(nameof(InboundConnectionsRequired), value); }
        }
        /// <summary>Prevents the firewall from displaying notifications when an application is blocked from listening on a port. When InboundNotificationsRequired and InboundNotificationsBlocked are both true, InboundNotificationsBlocked takes priority.</summary>
        public bool? InboundNotificationsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(InboundNotificationsBlocked)); }
            set { BackingStore?.Set(nameof(InboundNotificationsBlocked), value); }
        }
        /// <summary>Allows the firewall to display notifications when an application is blocked from listening on a port. When InboundNotificationsRequired and InboundNotificationsBlocked are both true, InboundNotificationsBlocked takes priority.</summary>
        public bool? InboundNotificationsRequired {
            get { return BackingStore?.Get<bool?>(nameof(InboundNotificationsRequired)); }
            set { BackingStore?.Set(nameof(InboundNotificationsRequired), value); }
        }
        /// <summary>Configures the firewall to block all incoming traffic regardless of other policy settings. When IncomingTrafficRequired and IncomingTrafficBlocked are both true, IncomingTrafficBlocked takes priority.</summary>
        public bool? IncomingTrafficBlocked {
            get { return BackingStore?.Get<bool?>(nameof(IncomingTrafficBlocked)); }
            set { BackingStore?.Set(nameof(IncomingTrafficBlocked), value); }
        }
        /// <summary>Configures the firewall to allow incoming traffic pursuant to other policy settings. When IncomingTrafficRequired and IncomingTrafficBlocked are both true, IncomingTrafficBlocked takes priority.</summary>
        public bool? IncomingTrafficRequired {
            get { return BackingStore?.Get<bool?>(nameof(IncomingTrafficRequired)); }
            set { BackingStore?.Set(nameof(IncomingTrafficRequired), value); }
        }
        /// <summary>Configures the firewall to block all outgoing connections by default. When OutboundConnectionsRequired and OutboundConnectionsBlocked are both true, OutboundConnectionsBlocked takes priority. This setting will get applied to Windows releases version 1809 and above.</summary>
        public bool? OutboundConnectionsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(OutboundConnectionsBlocked)); }
            set { BackingStore?.Set(nameof(OutboundConnectionsBlocked), value); }
        }
        /// <summary>Configures the firewall to allow all outgoing connections by default. When OutboundConnectionsRequired and OutboundConnectionsBlocked are both true, OutboundConnectionsBlocked takes priority. This setting will get applied to Windows releases version 1809 and above.</summary>
        public bool? OutboundConnectionsRequired {
            get { return BackingStore?.Get<bool?>(nameof(OutboundConnectionsRequired)); }
            set { BackingStore?.Set(nameof(OutboundConnectionsRequired), value); }
        }
        /// <summary>Configures the firewall to merge Firewall Rule policies from group policy with those from local store instead of ignoring the local store rules. When PolicyRulesFromGroupPolicyNotMerged and PolicyRulesFromGroupPolicyMerged are both true, PolicyRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? PolicyRulesFromGroupPolicyMerged {
            get { return BackingStore?.Get<bool?>(nameof(PolicyRulesFromGroupPolicyMerged)); }
            set { BackingStore?.Set(nameof(PolicyRulesFromGroupPolicyMerged), value); }
        }
        /// <summary>Configures the firewall to prevent merging Firewall Rule policies from group policy with those from local store instead of ignoring the local store rules. When PolicyRulesFromGroupPolicyNotMerged and PolicyRulesFromGroupPolicyMerged are both true, PolicyRulesFromGroupPolicyMerged takes priority.</summary>
        public bool? PolicyRulesFromGroupPolicyNotMerged {
            get { return BackingStore?.Get<bool?>(nameof(PolicyRulesFromGroupPolicyNotMerged)); }
            set { BackingStore?.Set(nameof(PolicyRulesFromGroupPolicyNotMerged), value); }
        }
        /// <summary>Configures the firewall to allow the host computer to respond to unsolicited network traffic of that traffic is secured by IPSec even when stealthModeBlocked is set to true. When SecuredPacketExemptionBlocked and SecuredPacketExemptionAllowed are both true, SecuredPacketExemptionAllowed takes priority.</summary>
        public bool? SecuredPacketExemptionAllowed {
            get { return BackingStore?.Get<bool?>(nameof(SecuredPacketExemptionAllowed)); }
            set { BackingStore?.Set(nameof(SecuredPacketExemptionAllowed), value); }
        }
        /// <summary>Configures the firewall to block the host computer to respond to unsolicited network traffic of that traffic is secured by IPSec even when stealthModeBlocked is set to true. When SecuredPacketExemptionBlocked and SecuredPacketExemptionAllowed are both true, SecuredPacketExemptionAllowed takes priority.</summary>
        public bool? SecuredPacketExemptionBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SecuredPacketExemptionBlocked)); }
            set { BackingStore?.Set(nameof(SecuredPacketExemptionBlocked), value); }
        }
        /// <summary>Prevent the server from operating in stealth mode. When StealthModeRequired and StealthModeBlocked are both true, StealthModeBlocked takes priority.</summary>
        public bool? StealthModeBlocked {
            get { return BackingStore?.Get<bool?>(nameof(StealthModeBlocked)); }
            set { BackingStore?.Set(nameof(StealthModeBlocked), value); }
        }
        /// <summary>Allow the server to operate in stealth mode. When StealthModeRequired and StealthModeBlocked are both true, StealthModeBlocked takes priority.</summary>
        public bool? StealthModeRequired {
            get { return BackingStore?.Get<bool?>(nameof(StealthModeRequired)); }
            set { BackingStore?.Set(nameof(StealthModeRequired), value); }
        }
        /// <summary>Configures the firewall to block unicast responses to multicast broadcast traffic. When UnicastResponsesToMulticastBroadcastsRequired and UnicastResponsesToMulticastBroadcastsBlocked are both true, UnicastResponsesToMulticastBroadcastsBlocked takes priority.</summary>
        public bool? UnicastResponsesToMulticastBroadcastsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(UnicastResponsesToMulticastBroadcastsBlocked)); }
            set { BackingStore?.Set(nameof(UnicastResponsesToMulticastBroadcastsBlocked), value); }
        }
        /// <summary>Configures the firewall to allow unicast responses to multicast broadcast traffic. When UnicastResponsesToMulticastBroadcastsRequired and UnicastResponsesToMulticastBroadcastsBlocked are both true, UnicastResponsesToMulticastBroadcastsBlocked takes priority.</summary>
        public bool? UnicastResponsesToMulticastBroadcastsRequired {
            get { return BackingStore?.Get<bool?>(nameof(UnicastResponsesToMulticastBroadcastsRequired)); }
            set { BackingStore?.Set(nameof(UnicastResponsesToMulticastBroadcastsRequired), value); }
        }
        /// <summary>
        /// Instantiates a new windowsFirewallNetworkProfile and sets the default values.
        /// </summary>
        public WindowsFirewallNetworkProfile() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsFirewallNetworkProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsFirewallNetworkProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authorizedApplicationRulesFromGroupPolicyMerged", n => { AuthorizedApplicationRulesFromGroupPolicyMerged = n.GetBoolValue(); } },
                {"authorizedApplicationRulesFromGroupPolicyNotMerged", n => { AuthorizedApplicationRulesFromGroupPolicyNotMerged = n.GetBoolValue(); } },
                {"connectionSecurityRulesFromGroupPolicyMerged", n => { ConnectionSecurityRulesFromGroupPolicyMerged = n.GetBoolValue(); } },
                {"connectionSecurityRulesFromGroupPolicyNotMerged", n => { ConnectionSecurityRulesFromGroupPolicyNotMerged = n.GetBoolValue(); } },
                {"firewallEnabled", n => { FirewallEnabled = n.GetEnumValue<StateManagementSetting>(); } },
                {"globalPortRulesFromGroupPolicyMerged", n => { GlobalPortRulesFromGroupPolicyMerged = n.GetBoolValue(); } },
                {"globalPortRulesFromGroupPolicyNotMerged", n => { GlobalPortRulesFromGroupPolicyNotMerged = n.GetBoolValue(); } },
                {"inboundConnectionsBlocked", n => { InboundConnectionsBlocked = n.GetBoolValue(); } },
                {"inboundConnectionsRequired", n => { InboundConnectionsRequired = n.GetBoolValue(); } },
                {"inboundNotificationsBlocked", n => { InboundNotificationsBlocked = n.GetBoolValue(); } },
                {"inboundNotificationsRequired", n => { InboundNotificationsRequired = n.GetBoolValue(); } },
                {"incomingTrafficBlocked", n => { IncomingTrafficBlocked = n.GetBoolValue(); } },
                {"incomingTrafficRequired", n => { IncomingTrafficRequired = n.GetBoolValue(); } },
                {"outboundConnectionsBlocked", n => { OutboundConnectionsBlocked = n.GetBoolValue(); } },
                {"outboundConnectionsRequired", n => { OutboundConnectionsRequired = n.GetBoolValue(); } },
                {"policyRulesFromGroupPolicyMerged", n => { PolicyRulesFromGroupPolicyMerged = n.GetBoolValue(); } },
                {"policyRulesFromGroupPolicyNotMerged", n => { PolicyRulesFromGroupPolicyNotMerged = n.GetBoolValue(); } },
                {"securedPacketExemptionAllowed", n => { SecuredPacketExemptionAllowed = n.GetBoolValue(); } },
                {"securedPacketExemptionBlocked", n => { SecuredPacketExemptionBlocked = n.GetBoolValue(); } },
                {"stealthModeBlocked", n => { StealthModeBlocked = n.GetBoolValue(); } },
                {"stealthModeRequired", n => { StealthModeRequired = n.GetBoolValue(); } },
                {"unicastResponsesToMulticastBroadcastsBlocked", n => { UnicastResponsesToMulticastBroadcastsBlocked = n.GetBoolValue(); } },
                {"unicastResponsesToMulticastBroadcastsRequired", n => { UnicastResponsesToMulticastBroadcastsRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("authorizedApplicationRulesFromGroupPolicyMerged", AuthorizedApplicationRulesFromGroupPolicyMerged);
            writer.WriteBoolValue("authorizedApplicationRulesFromGroupPolicyNotMerged", AuthorizedApplicationRulesFromGroupPolicyNotMerged);
            writer.WriteBoolValue("connectionSecurityRulesFromGroupPolicyMerged", ConnectionSecurityRulesFromGroupPolicyMerged);
            writer.WriteBoolValue("connectionSecurityRulesFromGroupPolicyNotMerged", ConnectionSecurityRulesFromGroupPolicyNotMerged);
            writer.WriteEnumValue<StateManagementSetting>("firewallEnabled", FirewallEnabled);
            writer.WriteBoolValue("globalPortRulesFromGroupPolicyMerged", GlobalPortRulesFromGroupPolicyMerged);
            writer.WriteBoolValue("globalPortRulesFromGroupPolicyNotMerged", GlobalPortRulesFromGroupPolicyNotMerged);
            writer.WriteBoolValue("inboundConnectionsBlocked", InboundConnectionsBlocked);
            writer.WriteBoolValue("inboundConnectionsRequired", InboundConnectionsRequired);
            writer.WriteBoolValue("inboundNotificationsBlocked", InboundNotificationsBlocked);
            writer.WriteBoolValue("inboundNotificationsRequired", InboundNotificationsRequired);
            writer.WriteBoolValue("incomingTrafficBlocked", IncomingTrafficBlocked);
            writer.WriteBoolValue("incomingTrafficRequired", IncomingTrafficRequired);
            writer.WriteBoolValue("outboundConnectionsBlocked", OutboundConnectionsBlocked);
            writer.WriteBoolValue("outboundConnectionsRequired", OutboundConnectionsRequired);
            writer.WriteBoolValue("policyRulesFromGroupPolicyMerged", PolicyRulesFromGroupPolicyMerged);
            writer.WriteBoolValue("policyRulesFromGroupPolicyNotMerged", PolicyRulesFromGroupPolicyNotMerged);
            writer.WriteBoolValue("securedPacketExemptionAllowed", SecuredPacketExemptionAllowed);
            writer.WriteBoolValue("securedPacketExemptionBlocked", SecuredPacketExemptionBlocked);
            writer.WriteBoolValue("stealthModeBlocked", StealthModeBlocked);
            writer.WriteBoolValue("stealthModeRequired", StealthModeRequired);
            writer.WriteBoolValue("unicastResponsesToMulticastBroadcastsBlocked", UnicastResponsesToMulticastBroadcastsBlocked);
            writer.WriteBoolValue("unicastResponsesToMulticastBroadcastsRequired", UnicastResponsesToMulticastBroadcastsRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
