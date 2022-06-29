using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationWindowsSettingApplicability : DeviceManagementConfigurationSettingApplicability, IParsable {
        /// <summary>Version of CSP setting is a part of</summary>
        public string ConfigurationServiceProviderVersion {
            get { return BackingStore?.Get<string>(nameof(ConfigurationServiceProviderVersion)); }
            set { BackingStore?.Set(nameof(ConfigurationServiceProviderVersion), value); }
        }
        /// <summary>Maximum supported version of Windows</summary>
        public string MaximumSupportedVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumSupportedVersion)); }
            set { BackingStore?.Set(nameof(MaximumSupportedVersion), value); }
        }
        /// <summary>Minimum supported version of Windows</summary>
        public string MinimumSupportedVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumSupportedVersion)); }
            set { BackingStore?.Set(nameof(MinimumSupportedVersion), value); }
        }
        /// <summary>Required AzureAD trust type. Possible values are: none, azureAdJoined, addWorkAccount, mdmOnly.</summary>
        public DeviceManagementConfigurationAzureAdTrustType? RequiredAzureAdTrustType {
            get { return BackingStore?.Get<DeviceManagementConfigurationAzureAdTrustType?>(nameof(RequiredAzureAdTrustType)); }
            set { BackingStore?.Set(nameof(RequiredAzureAdTrustType), value); }
        }
        /// <summary>AzureAD setting requirement</summary>
        public bool? RequiresAzureAd {
            get { return BackingStore?.Get<bool?>(nameof(RequiresAzureAd)); }
            set { BackingStore?.Set(nameof(RequiresAzureAd), value); }
        }
        /// <summary>List of Windows SKUs that the setting is applicable for</summary>
        public List<string> WindowsSkus {
            get { return BackingStore?.Get<List<string>>(nameof(WindowsSkus)); }
            set { BackingStore?.Set(nameof(WindowsSkus), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationWindowsSettingApplicability CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationWindowsSettingApplicability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationServiceProviderVersion", n => { ConfigurationServiceProviderVersion = n.GetStringValue(); } },
                {"maximumSupportedVersion", n => { MaximumSupportedVersion = n.GetStringValue(); } },
                {"minimumSupportedVersion", n => { MinimumSupportedVersion = n.GetStringValue(); } },
                {"requiredAzureAdTrustType", n => { RequiredAzureAdTrustType = n.GetEnumValue<DeviceManagementConfigurationAzureAdTrustType>(); } },
                {"requiresAzureAd", n => { RequiresAzureAd = n.GetBoolValue(); } },
                {"windowsSkus", n => { WindowsSkus = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("configurationServiceProviderVersion", ConfigurationServiceProviderVersion);
            writer.WriteStringValue("maximumSupportedVersion", MaximumSupportedVersion);
            writer.WriteStringValue("minimumSupportedVersion", MinimumSupportedVersion);
            writer.WriteEnumValue<DeviceManagementConfigurationAzureAdTrustType>("requiredAzureAdTrustType", RequiredAzureAdTrustType);
            writer.WriteBoolValue("requiresAzureAd", RequiresAzureAd);
            writer.WriteCollectionOfPrimitiveValues<string>("windowsSkus", WindowsSkus);
        }
    }
}
