using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SecurityConfigurationTask : DeviceAppManagementTask, IParsable {
        /// <summary>The endpoint security configuration applicable platform.</summary>
        public EndpointSecurityConfigurationApplicablePlatform? ApplicablePlatform {
            get { return BackingStore?.Get<EndpointSecurityConfigurationApplicablePlatform?>("applicablePlatform"); }
            set { BackingStore?.Set("applicablePlatform", value); }
        }
        /// <summary>The endpoint security policy type.</summary>
        public EndpointSecurityConfigurationType? EndpointSecurityPolicy {
            get { return BackingStore?.Get<EndpointSecurityConfigurationType?>("endpointSecurityPolicy"); }
            set { BackingStore?.Set("endpointSecurityPolicy", value); }
        }
        /// <summary>The endpoint security policy profile type.</summary>
        public EndpointSecurityConfigurationProfileType? EndpointSecurityPolicyProfile {
            get { return BackingStore?.Get<EndpointSecurityConfigurationProfileType?>("endpointSecurityPolicyProfile"); }
            set { BackingStore?.Set("endpointSecurityPolicyProfile", value); }
        }
        /// <summary>Information about the mitigation.</summary>
        public string Insights {
            get { return BackingStore?.Get<string>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
        /// <summary>The intended settings and their values.</summary>
        public List<KeyValuePair> IntendedSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>("intendedSettings"); }
            set { BackingStore?.Set("intendedSettings", value); }
        }
        /// <summary>The number of vulnerable devices.</summary>
        public int? ManagedDeviceCount {
            get { return BackingStore?.Get<int?>("managedDeviceCount"); }
            set { BackingStore?.Set("managedDeviceCount", value); }
        }
        /// <summary>The vulnerable managed devices.</summary>
        public List<VulnerableManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<VulnerableManagedDevice>>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
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
