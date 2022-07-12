using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Zebra FOTA deployment complex type that describes the settings required to create a FOTA deployment.</summary>
    public class ZebraFotaDeploymentSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Minimum battery level (%) required for both download and installation. Default: -1 (System defaults). Maximum is 100.</summary>
        public int? BatteryRuleMinimumBatteryLevelPercentage {
            get { return BackingStore?.Get<int?>("batteryRuleMinimumBatteryLevelPercentage"); }
            set { BackingStore?.Set("batteryRuleMinimumBatteryLevelPercentage", value); }
        }
        /// <summary>Flag indicating if charger is required. When set to false, the client can install updates whether the device is in or out of the charger. Applied only for installation. Defaults to false.</summary>
        public bool? BatteryRuleRequireCharger {
            get { return BackingStore?.Get<bool?>("batteryRuleRequireCharger"); }
            set { BackingStore?.Set("batteryRuleRequireCharger", value); }
        }
        /// <summary>Deploy update for devices with this model only.</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
        /// <summary>Represents various network types for Zebra FOTA deployment.</summary>
        public ZebraFotaNetworkType? DownloadRuleNetworkType {
            get { return BackingStore?.Get<ZebraFotaNetworkType?>("downloadRuleNetworkType"); }
            set { BackingStore?.Set("downloadRuleNetworkType", value); }
        }
        /// <summary>Date and time in the device time zone when the download will start (e.g., 2018-07-25T10:20:32). The default value is UTC now and the maximum is 10 days from deployment creation.</summary>
        public DateTimeOffset? DownloadRuleStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("downloadRuleStartDateTime"); }
            set { BackingStore?.Set("downloadRuleStartDateTime", value); }
        }
        /// <summary>Deployment&apos;s Board Support Package (BSP. E.g.: &apos;01.18.02.00&apos;). Required only for custom update type.</summary>
        public string FirmwareTargetBoardSupportPackageVersion {
            get { return BackingStore?.Get<string>("firmwareTargetBoardSupportPackageVersion"); }
            set { BackingStore?.Set("firmwareTargetBoardSupportPackageVersion", value); }
        }
        /// <summary>Target OS Version (e.g.: &apos;8.1.0&apos;). Required only for custom update type.</summary>
        public string FirmwareTargetOsVersion {
            get { return BackingStore?.Get<string>("firmwareTargetOsVersion"); }
            set { BackingStore?.Set("firmwareTargetOsVersion", value); }
        }
        /// <summary>Target patch name (e.g.: &apos;U06&apos;). Required only for custom update type.</summary>
        public string FirmwareTargetPatch {
            get { return BackingStore?.Get<string>("firmwareTargetPatch"); }
            set { BackingStore?.Set("firmwareTargetPatch", value); }
        }
        /// <summary>Date and time in device time zone when the install will start. Default - download startDate if configured, otherwise defaults to NOW. Ignored when deployment update type was set to auto.</summary>
        public DateTimeOffset? InstallRuleStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("installRuleStartDateTime"); }
            set { BackingStore?.Set("installRuleStartDateTime", value); }
        }
        /// <summary>Time of day after which the install cannot start. Possible range is 00:30:00 to 23:59:59. Should be greater than &apos;installRuleWindowStartTime&apos; by 30 mins. The time is expressed in a 24-hour format, as hh:mm, and is in the device time zone. Default - 23:59:59. Respected for all values of update type, including AUTO.</summary>
        public Time? InstallRuleWindowEndTime {
            get { return BackingStore?.Get<Time?>("installRuleWindowEndTime"); }
            set { BackingStore?.Set("installRuleWindowEndTime", value); }
        }
        /// <summary>Time of day (00:00:00 - 23:30:00) when installation should begin. The time is expressed in a 24-hour format, as hh:mm, and is in the device time zone. Default - 00:00:00. Respected for all values of update type, including AUTO.</summary>
        public Time? InstallRuleWindowStartTime {
            get { return BackingStore?.Get<Time?>("installRuleWindowStartTime"); }
            set { BackingStore?.Set("installRuleWindowStartTime", value); }
        }
        /// <summary>Maximum 28 days. Default is 28 days. Sequence of dates are: 1) Download start date. 2) Install start date. 3) Schedule end date. If any of the values are not provided, the date provided in the preceding step of the sequence is used. If no values are provided, the string value of the current UTC is used.</summary>
        public int? ScheduleDurationInDays {
            get { return BackingStore?.Get<int?>("scheduleDurationInDays"); }
            set { BackingStore?.Set("scheduleDurationInDays", value); }
        }
        /// <summary>Represents various schedule modes for Zebra FOTA deployment.</summary>
        public ZebraFotaScheduleMode? ScheduleMode {
            get { return BackingStore?.Get<ZebraFotaScheduleMode?>("scheduleMode"); }
            set { BackingStore?.Set("scheduleMode", value); }
        }
        /// <summary>This attribute indicates the deployment time offset (e.g.180 represents an offset of +03:00, and -270 represents an offset of -04:30). The time offset is the time timezone where the devices are located. The deployment start and end data uses this timezone</summary>
        public int? TimeZoneOffsetInMinutes {
            get { return BackingStore?.Get<int?>("timeZoneOffsetInMinutes"); }
            set { BackingStore?.Set("timeZoneOffsetInMinutes", value); }
        }
        /// <summary>Represents various update types for Zebra FOTA deployment.</summary>
        public ZebraFotaUpdateType? UpdateType {
            get { return BackingStore?.Get<ZebraFotaUpdateType?>("updateType"); }
            set { BackingStore?.Set("updateType", value); }
        }
        /// <summary>
        /// Instantiates a new zebraFotaDeploymentSettings and sets the default values.
        /// </summary>
        public ZebraFotaDeploymentSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
