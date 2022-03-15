using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ManagedDeviceMobileAppConfigurationSettingState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Current value of setting on device</summary>
        public string CurrentValue { get; set; }
        /// <summary>Error code for the setting</summary>
        public int? ErrorCode { get; set; }
        /// <summary>Error description</summary>
        public string ErrorDescription { get; set; }
        /// <summary>Name of setting instance that is being reported.</summary>
        public string InstanceDisplayName { get; set; }
        /// <summary>The setting that is being reported</summary>
        public string Setting { get; set; }
        /// <summary>SettingInstanceId</summary>
        public string SettingInstanceId { get; set; }
        /// <summary>Localized/user friendly setting name that is being reported</summary>
        public string SettingName { get; set; }
        /// <summary>Contributing policies</summary>
        public List<SettingSource> Sources { get; set; }
        /// <summary>The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>UserEmail</summary>
        public string UserEmail { get; set; }
        /// <summary>UserId</summary>
        public string UserId { get; set; }
        /// <summary>UserName</summary>
        public string UserName { get; set; }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new managedDeviceMobileAppConfigurationSettingState and sets the default values.
        /// </summary>
        public ManagedDeviceMobileAppConfigurationSettingState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagedDeviceMobileAppConfigurationSettingState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceMobileAppConfigurationSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"currentValue", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).CurrentValue = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).ErrorCode = n.GetIntValue(); } },
                {"errorDescription", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).ErrorDescription = n.GetStringValue(); } },
                {"instanceDisplayName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).InstanceDisplayName = n.GetStringValue(); } },
                {"setting", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).Setting = n.GetStringValue(); } },
                {"settingInstanceId", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).SettingInstanceId = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).SettingName = n.GetStringValue(); } },
                {"sources", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).Sources = n.GetCollectionOfObjectValues<SettingSource>(SettingSource.CreateFromDiscriminatorValue).ToList(); } },
                {"state", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userEmail", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).UserEmail = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationSettingState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentValue", CurrentValue);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteStringValue("instanceDisplayName", InstanceDisplayName);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingInstanceId", SettingInstanceId);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteCollectionOfObjectValues<SettingSource>("sources", Sources);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
