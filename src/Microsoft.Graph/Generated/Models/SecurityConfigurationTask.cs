using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SecurityConfigurationTask : DeviceAppManagementTask, IParsable {
        /// <summary>The applicable platform. Possible values are: unknown, macOS, windows10AndLater, windows10AndWindowsServer.</summary>
        public EndpointSecurityConfigurationApplicablePlatform? ApplicablePlatform {
            get { return BackingStore?.Get<EndpointSecurityConfigurationApplicablePlatform?>(nameof(ApplicablePlatform)); }
            set { BackingStore?.Set(nameof(ApplicablePlatform), value); }
        }
        /// <summary>The endpoint security policy type. Possible values are: unknown, antivirus, diskEncryption, firewall, endpointDetectionAndResponse, attackSurfaceReduction, accountProtection.</summary>
        public EndpointSecurityConfigurationType? EndpointSecurityPolicy {
            get { return BackingStore?.Get<EndpointSecurityConfigurationType?>(nameof(EndpointSecurityPolicy)); }
            set { BackingStore?.Set(nameof(EndpointSecurityPolicy), value); }
        }
        /// <summary>The endpoint security policy profile. Possible values are: unknown, antivirus, windowsSecurity, bitLocker, fileVault, firewall, firewallRules, endpointDetectionAndResponse, deviceControl, appAndBrowserIsolation, exploitProtection, webProtection, applicationControl, attackSurfaceReductionRules, accountProtection.</summary>
        public EndpointSecurityConfigurationProfileType? EndpointSecurityPolicyProfile {
            get { return BackingStore?.Get<EndpointSecurityConfigurationProfileType?>(nameof(EndpointSecurityPolicyProfile)); }
            set { BackingStore?.Set(nameof(EndpointSecurityPolicyProfile), value); }
        }
        /// <summary>Information about the mitigation.</summary>
        public string Insights {
            get { return BackingStore?.Get<string>(nameof(Insights)); }
            set { BackingStore?.Set(nameof(Insights), value); }
        }
        /// <summary>The intended settings and their values.</summary>
        public List<KeyValuePair> IntendedSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(IntendedSettings)); }
            set { BackingStore?.Set(nameof(IntendedSettings), value); }
        }
        /// <summary>The number of vulnerable devices.</summary>
        public int? ManagedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ManagedDeviceCount)); }
            set { BackingStore?.Set(nameof(ManagedDeviceCount), value); }
        }
        /// <summary>The vulnerable managed devices.</summary>
        public List<VulnerableManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<VulnerableManagedDevice>>(nameof(ManagedDevices)); }
            set { BackingStore?.Set(nameof(ManagedDevices), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecurityConfigurationTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityConfigurationTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicablePlatform", n => { ApplicablePlatform = n.GetEnumValue<EndpointSecurityConfigurationApplicablePlatform>(); } },
                {"endpointSecurityPolicy", n => { EndpointSecurityPolicy = n.GetEnumValue<EndpointSecurityConfigurationType>(); } },
                {"endpointSecurityPolicyProfile", n => { EndpointSecurityPolicyProfile = n.GetEnumValue<EndpointSecurityConfigurationProfileType>(); } },
                {"insights", n => { Insights = n.GetStringValue(); } },
                {"intendedSettings", n => { IntendedSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceCount", n => { ManagedDeviceCount = n.GetIntValue(); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<VulnerableManagedDevice>(VulnerableManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EndpointSecurityConfigurationApplicablePlatform>("applicablePlatform", ApplicablePlatform);
            writer.WriteEnumValue<EndpointSecurityConfigurationType>("endpointSecurityPolicy", EndpointSecurityPolicy);
            writer.WriteEnumValue<EndpointSecurityConfigurationProfileType>("endpointSecurityPolicyProfile", EndpointSecurityPolicyProfile);
            writer.WriteStringValue("insights", Insights);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("intendedSettings", IntendedSettings);
            writer.WriteIntValue("managedDeviceCount", ManagedDeviceCount);
            writer.WriteCollectionOfObjectValues<VulnerableManagedDevice>("managedDevices", ManagedDevices);
        }
    }
}
