using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ManagedDeviceMobileAppConfigurationState : Entity, IParsable {
        /// <summary>The name of the policy for this policyBase</summary>
        public string DisplayName { get; set; }
        /// <summary>Platform type that the policy applies to</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount { get; set; }
        public List<ManagedDeviceMobileAppConfigurationSettingState> SettingStates { get; set; }
        /// <summary>The compliance state of the policy</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>User unique identifier, must be Guid</summary>
        public string UserId { get; set; }
        /// <summary>User Principal Name</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The version of the policy</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceMobileAppConfigurationState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceMobileAppConfigurationState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).DisplayName = n.GetStringValue(); } },
                {"platformType", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"settingCount", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).SettingCount = n.GetIntValue(); } },
                {"settingStates", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).SettingStates = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationSettingState>(ManagedDeviceMobileAppConfigurationSettingState.CreateFromDiscriminatorValue).ToList(); } },
                {"state", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userId", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).UserPrincipalName = n.GetStringValue(); } },
                {"version", (o,n) => { (o as ManagedDeviceMobileAppConfigurationState).Version = n.GetIntValue(); } },
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
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteIntValue("version", Version);
        }
    }
}
