using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComanagementAuthorityConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>CoManagement Authority configuration ConfigurationManagerAgentCommandLineArgument</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationManagerAgentCommandLineArgument {
            get { return BackingStore?.Get<string?>("configurationManagerAgentCommandLineArgument"); }
            set { BackingStore?.Set("configurationManagerAgentCommandLineArgument", value); }
        }
#nullable restore
#else
        public string ConfigurationManagerAgentCommandLineArgument {
            get { return BackingStore?.Get<string>("configurationManagerAgentCommandLineArgument"); }
            set { BackingStore?.Set("configurationManagerAgentCommandLineArgument", value); }
        }
#endif
        /// <summary>CoManagement Authority configuration InstallConfigurationManagerAgent</summary>
        public bool? InstallConfigurationManagerAgent {
            get { return BackingStore?.Get<bool?>("installConfigurationManagerAgent"); }
            set { BackingStore?.Set("installConfigurationManagerAgent", value); }
        }
        /// <summary>CoManagement Authority configuration ManagedDeviceAuthority</summary>
        public int? ManagedDeviceAuthority {
            get { return BackingStore?.Get<int?>("managedDeviceAuthority"); }
            set { BackingStore?.Set("managedDeviceAuthority", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceComanagementAuthorityConfiguration and sets the default values.
        /// </summary>
        public DeviceComanagementAuthorityConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceComanagementAuthorityConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceComanagementAuthorityConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComanagementAuthorityConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationManagerAgentCommandLineArgument", n => { ConfigurationManagerAgentCommandLineArgument = n.GetStringValue(); } },
                {"installConfigurationManagerAgent", n => { InstallConfigurationManagerAgent = n.GetBoolValue(); } },
                {"managedDeviceAuthority", n => { ManagedDeviceAuthority = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("configurationManagerAgentCommandLineArgument", ConfigurationManagerAgentCommandLineArgument);
            writer.WriteBoolValue("installConfigurationManagerAgent", InstallConfigurationManagerAgent);
            writer.WriteIntValue("managedDeviceAuthority", ManagedDeviceAuthority);
        }
    }
}
