using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkSystemConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time configurations for a device.</summary>
        public TeamworkDateTimeConfiguration DateTimeConfiguration { get; set; }
        /// <summary>The default password for the device. Write-Only.</summary>
        public string DefaultPassword { get; set; }
        /// <summary>The device lock timeout in seconds.</summary>
        public TimeSpan? DeviceLockTimeout { get; set; }
        /// <summary>True if the device lock is enabled.</summary>
        public bool? IsDeviceLockEnabled { get; set; }
        /// <summary>True if logging is enabled.</summary>
        public bool? IsLoggingEnabled { get; set; }
        /// <summary>True if power saving is enabled.</summary>
        public bool? IsPowerSavingEnabled { get; set; }
        /// <summary>True if screen capture is enabled.</summary>
        public bool? IsScreenCaptureEnabled { get; set; }
        /// <summary>True if silent mode is enabled.</summary>
        public bool? IsSilentModeEnabled { get; set; }
        /// <summary>The language option for the device.</summary>
        public string Language { get; set; }
        /// <summary>The pin that unlocks the device. Write-Only.</summary>
        public string LockPin { get; set; }
        /// <summary>The logging level for the device.</summary>
        public string LoggingLevel { get; set; }
        /// <summary>The network configuration for the device.</summary>
        public TeamworkNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary>
        /// Instantiates a new teamworkSystemConfiguration and sets the default values.
        /// </summary>
        public TeamworkSystemConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkSystemConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSystemConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dateTimeConfiguration", n => { DateTimeConfiguration = n.GetObjectValue<TeamworkDateTimeConfiguration>(TeamworkDateTimeConfiguration.CreateFromDiscriminatorValue); } },
                {"defaultPassword", n => { DefaultPassword = n.GetStringValue(); } },
                {"deviceLockTimeout", n => { DeviceLockTimeout = n.GetTimeSpanValue(); } },
                {"isDeviceLockEnabled", n => { IsDeviceLockEnabled = n.GetBoolValue(); } },
                {"isLoggingEnabled", n => { IsLoggingEnabled = n.GetBoolValue(); } },
                {"isPowerSavingEnabled", n => { IsPowerSavingEnabled = n.GetBoolValue(); } },
                {"isScreenCaptureEnabled", n => { IsScreenCaptureEnabled = n.GetBoolValue(); } },
                {"isSilentModeEnabled", n => { IsSilentModeEnabled = n.GetBoolValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"lockPin", n => { LockPin = n.GetStringValue(); } },
                {"loggingLevel", n => { LoggingLevel = n.GetStringValue(); } },
                {"networkConfiguration", n => { NetworkConfiguration = n.GetObjectValue<TeamworkNetworkConfiguration>(TeamworkNetworkConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkDateTimeConfiguration>("dateTimeConfiguration", DateTimeConfiguration);
            writer.WriteStringValue("defaultPassword", DefaultPassword);
            writer.WriteTimeSpanValue("deviceLockTimeout", DeviceLockTimeout);
            writer.WriteBoolValue("isDeviceLockEnabled", IsDeviceLockEnabled);
            writer.WriteBoolValue("isLoggingEnabled", IsLoggingEnabled);
            writer.WriteBoolValue("isPowerSavingEnabled", IsPowerSavingEnabled);
            writer.WriteBoolValue("isScreenCaptureEnabled", IsScreenCaptureEnabled);
            writer.WriteBoolValue("isSilentModeEnabled", IsSilentModeEnabled);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("lockPin", LockPin);
            writer.WriteStringValue("loggingLevel", LoggingLevel);
            writer.WriteObjectValue<TeamworkNetworkConfiguration>("networkConfiguration", NetworkConfiguration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
