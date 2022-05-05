using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Zebra FOTA deployment complex type that describes the settings required to create a FOTA deployment.</summary>
    public class ZebraFotaDeploymentSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Minimum battery level (%) required for both download and installation. Default: -1 (System defaults). Maximum is 100.</summary>
        public int? BatteryRuleMinimumBatteryLevelPercentage { get; set; }
        /// <summary>Flag indicating if charger is required. When set to false, the client can install updates whether the device is in or out of the charger. Applied only for installation. Defaults to false.</summary>
        public bool? BatteryRuleRequireCharger { get; set; }
        /// <summary>Deploy update for devices with this model only.</summary>
        public string DeviceModel { get; set; }
        /// <summary>Download network type as described in &apos;zebraFotaNetworkType&apos;. Default: any</summary>
        public ZebraFotaNetworkType? DownloadRuleNetworkType { get; set; }
        /// <summary>Date and time in the device time zone when the download will start (e.g., `2018-07-25T10:20:32`). The default value is UTC now and the maximum is 10 days from deployment creation.</summary>
        public DateTimeOffset? DownloadRuleStartDateTime { get; set; }
        /// <summary>Deployment&apos;s Board Support Package (BSP. E.g.: &apos;01.18.02.00&apos;). Required only for custom update type.</summary>
        public string FirmwareTargetBoardSupportPackageVersion { get; set; }
        /// <summary>Target OS Version (e.g.: &apos;8.1.0&apos;). Required only for custom update type.</summary>
        public string FirmwareTargetOsVersion { get; set; }
        /// <summary>Target patch name (e.g.: &apos;U06&apos;). Required only for custom update type.</summary>
        public string FirmwareTargetPatch { get; set; }
        /// <summary>Date and time in device time zone when the install will start. Default - download startDate if configured, otherwise defaults to NOW. Ignored when deployment update type was set to auto.</summary>
        public DateTimeOffset? InstallRuleStartDateTime { get; set; }
        /// <summary>Time of day after which the install cannot start. Possible range is 00:30:00 to 23:59:59. Should be greater than &apos;installRuleWindowStartTime&apos; by 30 mins. The time is expressed in a 24-hour format, as hh:mm, and is in the device time zone. Default - 23:59:59. Respected for all values of update type, including AUTO.</summary>
        public Time? InstallRuleWindowEndTime { get; set; }
        /// <summary>Time of day (00:00:00 - 23:30:00) when installation should begin. The time is expressed in a 24-hour format, as hh:mm, and is in the device time zone. Default - 00:00:00. Respected for all values of update type, including AUTO.</summary>
        public Time? InstallRuleWindowStartTime { get; set; }
        /// <summary>Maximum 28 days. Default is 28 days. Sequence of dates are: 1) Download start date. 2) Install start date. 3) Schedule end date. If any of the values are not provided, the date provided in the preceding step of the sequence is used. If no values are provided, the string value of the current UTC is used.</summary>
        public int? ScheduleDurationInDays { get; set; }
        /// <summary>Deployment installation schedule mode. Default is installNow. All scheduled deployments date and time are in the device’s timezone. For Install Now, the date and time are in UTC (same date and time anywhere in the world).</summary>
        public ZebraFotaScheduleMode? ScheduleMode { get; set; }
        /// <summary>This attribute indicates the deployment time offset (e.g.`180` represents an offset of `+03:00`, and `-270` represents an offset of `-04:30`). The time offset is the time timezone where the devices are located. The deployment start and end data uses this timezone</summary>
        public int? TimeZoneOffsetInMinutes { get; set; }
        /// <summary>The deployment&apos;s update type. Possible values are custom, latest, and auto. When custom mode is set, the request must provide artifact values. When latest type is set, the latest released update becomes the target OS. If latest is specified, the firmware target values are not required. Note: latest may update the device to a new Android version. When the value is set to auto, the device always looks for the latest package available and tries to update whenever a new package is available. This continues until the admin cancels the auto update. While other modes return an ID starting with FOTA-x, auto mode returns an ID starting with AUTO-x.</summary>
        public ZebraFotaUpdateType? UpdateType { get; set; }
        /// <summary>
        /// Instantiates a new zebraFotaDeploymentSettings and sets the default values.
        /// </summary>
        public ZebraFotaDeploymentSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ZebraFotaDeploymentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaDeploymentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"batteryRuleMinimumBatteryLevelPercentage", n => { BatteryRuleMinimumBatteryLevelPercentage = n.GetIntValue(); } },
                {"batteryRuleRequireCharger", n => { BatteryRuleRequireCharger = n.GetBoolValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"downloadRuleNetworkType", n => { DownloadRuleNetworkType = n.GetEnumValue<ZebraFotaNetworkType>(); } },
                {"downloadRuleStartDateTime", n => { DownloadRuleStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"firmwareTargetBoardSupportPackageVersion", n => { FirmwareTargetBoardSupportPackageVersion = n.GetStringValue(); } },
                {"firmwareTargetOsVersion", n => { FirmwareTargetOsVersion = n.GetStringValue(); } },
                {"firmwareTargetPatch", n => { FirmwareTargetPatch = n.GetStringValue(); } },
                {"installRuleStartDateTime", n => { InstallRuleStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"installRuleWindowEndTime", n => { InstallRuleWindowEndTime = n.GetTimeValue(); } },
                {"installRuleWindowStartTime", n => { InstallRuleWindowStartTime = n.GetTimeValue(); } },
                {"scheduleDurationInDays", n => { ScheduleDurationInDays = n.GetIntValue(); } },
                {"scheduleMode", n => { ScheduleMode = n.GetEnumValue<ZebraFotaScheduleMode>(); } },
                {"timeZoneOffsetInMinutes", n => { TimeZoneOffsetInMinutes = n.GetIntValue(); } },
                {"updateType", n => { UpdateType = n.GetEnumValue<ZebraFotaUpdateType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("batteryRuleMinimumBatteryLevelPercentage", BatteryRuleMinimumBatteryLevelPercentage);
            writer.WriteBoolValue("batteryRuleRequireCharger", BatteryRuleRequireCharger);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<ZebraFotaNetworkType>("downloadRuleNetworkType", DownloadRuleNetworkType);
            writer.WriteDateTimeOffsetValue("downloadRuleStartDateTime", DownloadRuleStartDateTime);
            writer.WriteStringValue("firmwareTargetBoardSupportPackageVersion", FirmwareTargetBoardSupportPackageVersion);
            writer.WriteStringValue("firmwareTargetOsVersion", FirmwareTargetOsVersion);
            writer.WriteStringValue("firmwareTargetPatch", FirmwareTargetPatch);
            writer.WriteDateTimeOffsetValue("installRuleStartDateTime", InstallRuleStartDateTime);
            writer.WriteTimeValue("installRuleWindowEndTime", InstallRuleWindowEndTime);
            writer.WriteTimeValue("installRuleWindowStartTime", InstallRuleWindowStartTime);
            writer.WriteIntValue("scheduleDurationInDays", ScheduleDurationInDays);
            writer.WriteEnumValue<ZebraFotaScheduleMode>("scheduleMode", ScheduleMode);
            writer.WriteIntValue("timeZoneOffsetInMinutes", TimeZoneOffsetInMinutes);
            writer.WriteEnumValue<ZebraFotaUpdateType>("updateType", UpdateType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
