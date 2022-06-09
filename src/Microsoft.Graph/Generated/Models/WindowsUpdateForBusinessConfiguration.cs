using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsUpdateForBusinessConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Allow eligible Windows 10 devices to upgrade to the latest version of Windows 11.</summary>
        public bool? AllowWindows11Upgrade {
            get { return BackingStore?.Get<bool?>(nameof(AllowWindows11Upgrade)); }
            set { BackingStore?.Set(nameof(AllowWindows11Upgrade), value); }
        }
        /// <summary>Automatic update mode. Possible values are: userDefined, notifyDownload, autoInstallAtMaintenanceTime, autoInstallAndRebootAtMaintenanceTime, autoInstallAndRebootAtScheduledTime, autoInstallAndRebootWithoutEndUserControl, windowsDefault.</summary>
        public Microsoft.Graph.Beta.Models.AutomaticUpdateMode? AutomaticUpdateMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutomaticUpdateMode?>(nameof(AutomaticUpdateMode)); }
            set { BackingStore?.Set(nameof(AutomaticUpdateMode), value); }
        }
        /// <summary>Specify the method by which the auto-restart required notification is dismissed. Possible values are: notConfigured, automatic, user.</summary>
        public AutoRestartNotificationDismissalMethod? AutoRestartNotificationDismissal {
            get { return BackingStore?.Get<AutoRestartNotificationDismissalMethod?>(nameof(AutoRestartNotificationDismissal)); }
            set { BackingStore?.Set(nameof(AutoRestartNotificationDismissal), value); }
        }
        /// <summary>Determines which branch devices will receive their updates from. Possible values are: userDefined, all, businessReadyOnly, windowsInsiderBuildFast, windowsInsiderBuildSlow, windowsInsiderBuildRelease.</summary>
        public WindowsUpdateType? BusinessReadyUpdatesOnly {
            get { return BackingStore?.Get<WindowsUpdateType?>(nameof(BusinessReadyUpdatesOnly)); }
            set { BackingStore?.Set(nameof(BusinessReadyUpdatesOnly), value); }
        }
        /// <summary>Number of days before feature updates are installed automatically with valid range from 0 to 30 days</summary>
        public int? DeadlineForFeatureUpdatesInDays {
            get { return BackingStore?.Get<int?>(nameof(DeadlineForFeatureUpdatesInDays)); }
            set { BackingStore?.Set(nameof(DeadlineForFeatureUpdatesInDays), value); }
        }
        /// <summary>Number of days before quality updates are installed automatically with valid range from 0 to 30 days</summary>
        public int? DeadlineForQualityUpdatesInDays {
            get { return BackingStore?.Get<int?>(nameof(DeadlineForQualityUpdatesInDays)); }
            set { BackingStore?.Set(nameof(DeadlineForQualityUpdatesInDays), value); }
        }
        /// <summary>Number of days after deadline  until restarts occur automatically with valid range from 0 to 7 days</summary>
        public int? DeadlineGracePeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(DeadlineGracePeriodInDays)); }
            set { BackingStore?.Set(nameof(DeadlineGracePeriodInDays), value); }
        }
        /// <summary>Delivery Optimization Mode. Possible values are: userDefined, httpOnly, httpWithPeeringNat, httpWithPeeringPrivateGroup, httpWithInternetPeering, simpleDownload, bypassMode.</summary>
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode {
            get { return BackingStore?.Get<WindowsDeliveryOptimizationMode?>(nameof(DeliveryOptimizationMode)); }
            set { BackingStore?.Set(nameof(DeliveryOptimizationMode), value); }
        }
        /// <summary>Windows update for business configuration device states. This collection can contain a maximum of 500 elements.</summary>
        public List<WindowsUpdateState> DeviceUpdateStates {
            get { return BackingStore?.Get<List<WindowsUpdateState>>(nameof(DeviceUpdateStates)); }
            set { BackingStore?.Set(nameof(DeviceUpdateStates), value); }
        }
        /// <summary>Exclude Windows update Drivers</summary>
        public bool? DriversExcluded {
            get { return BackingStore?.Get<bool?>(nameof(DriversExcluded)); }
            set { BackingStore?.Set(nameof(DriversExcluded), value); }
        }
        /// <summary>Deadline in days before automatically scheduling and executing a pending restart outside of active hours, with valid range from 2 to 30 days</summary>
        public int? EngagedRestartDeadlineInDays {
            get { return BackingStore?.Get<int?>(nameof(EngagedRestartDeadlineInDays)); }
            set { BackingStore?.Set(nameof(EngagedRestartDeadlineInDays), value); }
        }
        /// <summary>Number of days a user can snooze Engaged Restart reminder notifications with valid range from 1 to 3 days</summary>
        public int? EngagedRestartSnoozeScheduleInDays {
            get { return BackingStore?.Get<int?>(nameof(EngagedRestartSnoozeScheduleInDays)); }
            set { BackingStore?.Set(nameof(EngagedRestartSnoozeScheduleInDays), value); }
        }
        /// <summary>Number of days before transitioning from Auto Restarts scheduled outside of active hours to Engaged Restart, which requires the user to schedule, with valid range from 0 to 30 days</summary>
        public int? EngagedRestartTransitionScheduleInDays {
            get { return BackingStore?.Get<int?>(nameof(EngagedRestartTransitionScheduleInDays)); }
            set { BackingStore?.Set(nameof(EngagedRestartTransitionScheduleInDays), value); }
        }
        /// <summary>Defer Feature Updates by these many days</summary>
        public int? FeatureUpdatesDeferralPeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(FeatureUpdatesDeferralPeriodInDays)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesDeferralPeriodInDays), value); }
        }
        /// <summary>Pause Feature Updates</summary>
        public bool? FeatureUpdatesPaused {
            get { return BackingStore?.Get<bool?>(nameof(FeatureUpdatesPaused)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesPaused), value); }
        }
        /// <summary>Feature Updates Pause Expiry datetime</summary>
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FeatureUpdatesPauseExpiryDateTime)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesPauseExpiryDateTime), value); }
        }
        /// <summary>Feature Updates Pause start date. This property is read-only.</summary>
        public Date? FeatureUpdatesPauseStartDate {
            get { return BackingStore?.Get<Date?>(nameof(FeatureUpdatesPauseStartDate)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesPauseStartDate), value); }
        }
        /// <summary>Feature Updates Rollback Start datetime</summary>
        public DateTimeOffset? FeatureUpdatesRollbackStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FeatureUpdatesRollbackStartDateTime)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesRollbackStartDateTime), value); }
        }
        /// <summary>The number of days after a Feature Update for which a rollback is valid</summary>
        public int? FeatureUpdatesRollbackWindowInDays {
            get { return BackingStore?.Get<int?>(nameof(FeatureUpdatesRollbackWindowInDays)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesRollbackWindowInDays), value); }
        }
        /// <summary>Specifies whether to rollback Feature Updates on the next device check in</summary>
        public bool? FeatureUpdatesWillBeRolledBack {
            get { return BackingStore?.Get<bool?>(nameof(FeatureUpdatesWillBeRolledBack)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesWillBeRolledBack), value); }
        }
        /// <summary>Installation schedule</summary>
        public WindowsUpdateInstallScheduleType InstallationSchedule {
            get { return BackingStore?.Get<WindowsUpdateInstallScheduleType>(nameof(InstallationSchedule)); }
            set { BackingStore?.Set(nameof(InstallationSchedule), value); }
        }
        /// <summary>Allow Microsoft Update Service</summary>
        public bool? MicrosoftUpdateServiceAllowed {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftUpdateServiceAllowed)); }
            set { BackingStore?.Set(nameof(MicrosoftUpdateServiceAllowed), value); }
        }
        /// <summary>Specifies if the device should wait until deadline for rebooting outside of active hours</summary>
        public bool? PostponeRebootUntilAfterDeadline {
            get { return BackingStore?.Get<bool?>(nameof(PostponeRebootUntilAfterDeadline)); }
            set { BackingStore?.Set(nameof(PostponeRebootUntilAfterDeadline), value); }
        }
        /// <summary>The pre-release features. Possible values are: userDefined, settingsOnly, settingsAndExperimentations, notAllowed.</summary>
        public Microsoft.Graph.Beta.Models.PrereleaseFeatures? PrereleaseFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrereleaseFeatures?>(nameof(PrereleaseFeatures)); }
            set { BackingStore?.Set(nameof(PrereleaseFeatures), value); }
        }
        /// <summary>Defer Quality Updates by these many days</summary>
        public int? QualityUpdatesDeferralPeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(QualityUpdatesDeferralPeriodInDays)); }
            set { BackingStore?.Set(nameof(QualityUpdatesDeferralPeriodInDays), value); }
        }
        /// <summary>Pause Quality Updates</summary>
        public bool? QualityUpdatesPaused {
            get { return BackingStore?.Get<bool?>(nameof(QualityUpdatesPaused)); }
            set { BackingStore?.Set(nameof(QualityUpdatesPaused), value); }
        }
        /// <summary>Quality Updates Pause Expiry datetime</summary>
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(QualityUpdatesPauseExpiryDateTime)); }
            set { BackingStore?.Set(nameof(QualityUpdatesPauseExpiryDateTime), value); }
        }
        /// <summary>Quality Updates Pause start date. This property is read-only.</summary>
        public Date? QualityUpdatesPauseStartDate {
            get { return BackingStore?.Get<Date?>(nameof(QualityUpdatesPauseStartDate)); }
            set { BackingStore?.Set(nameof(QualityUpdatesPauseStartDate), value); }
        }
        /// <summary>Quality Updates Rollback Start datetime</summary>
        public DateTimeOffset? QualityUpdatesRollbackStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(QualityUpdatesRollbackStartDateTime)); }
            set { BackingStore?.Set(nameof(QualityUpdatesRollbackStartDateTime), value); }
        }
        /// <summary>Specifies whether to rollback Quality Updates on the next device check in</summary>
        public bool? QualityUpdatesWillBeRolledBack {
            get { return BackingStore?.Get<bool?>(nameof(QualityUpdatesWillBeRolledBack)); }
            set { BackingStore?.Set(nameof(QualityUpdatesWillBeRolledBack), value); }
        }
        /// <summary>Specify the period for auto-restart imminent warning notifications. Supported values: 15, 30 or 60 (minutes).</summary>
        public int? ScheduleImminentRestartWarningInMinutes {
            get { return BackingStore?.Get<int?>(nameof(ScheduleImminentRestartWarningInMinutes)); }
            set { BackingStore?.Set(nameof(ScheduleImminentRestartWarningInMinutes), value); }
        }
        /// <summary>Specify the period for auto-restart warning reminder notifications. Supported values: 2, 4, 8, 12 or 24 (hours).</summary>
        public int? ScheduleRestartWarningInHours {
            get { return BackingStore?.Get<int?>(nameof(ScheduleRestartWarningInHours)); }
            set { BackingStore?.Set(nameof(ScheduleRestartWarningInHours), value); }
        }
        /// <summary>Set to skip all check before restart: Battery level = 40%, User presence, Display Needed, Presentation mode, Full screen mode, phone call state, game mode etc.</summary>
        public bool? SkipChecksBeforeRestart {
            get { return BackingStore?.Get<bool?>(nameof(SkipChecksBeforeRestart)); }
            set { BackingStore?.Set(nameof(SkipChecksBeforeRestart), value); }
        }
        /// <summary>Specifies what Windows Update notifications users see. Possible values are: notConfigured, defaultNotifications, restartWarningsOnly, disableAllNotifications.</summary>
        public WindowsUpdateNotificationDisplayOption? UpdateNotificationLevel {
            get { return BackingStore?.Get<WindowsUpdateNotificationDisplayOption?>(nameof(UpdateNotificationLevel)); }
            set { BackingStore?.Set(nameof(UpdateNotificationLevel), value); }
        }
        /// <summary>Scheduled the update installation on the weeks of the month. Possible values are: userDefined, firstWeek, secondWeek, thirdWeek, fourthWeek, everyWeek.</summary>
        public WindowsUpdateForBusinessUpdateWeeks? UpdateWeeks {
            get { return BackingStore?.Get<WindowsUpdateForBusinessUpdateWeeks?>(nameof(UpdateWeeks)); }
            set { BackingStore?.Set(nameof(UpdateWeeks), value); }
        }
        /// <summary>Specifies whether to enable end user’s access to pause software updates. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? UserPauseAccess {
            get { return BackingStore?.Get<Enablement?>(nameof(UserPauseAccess)); }
            set { BackingStore?.Set(nameof(UserPauseAccess), value); }
        }
        /// <summary>Specifies whether to disable user’s access to scan Windows Update. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? UserWindowsUpdateScanAccess {
            get { return BackingStore?.Get<Enablement?>(nameof(UserWindowsUpdateScanAccess)); }
            set { BackingStore?.Set(nameof(UserWindowsUpdateScanAccess), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUpdateForBusinessConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateForBusinessConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowWindows11Upgrade", n => { AllowWindows11Upgrade = n.GetBoolValue(); } },
                {"automaticUpdateMode", n => { AutomaticUpdateMode = n.GetEnumValue<AutomaticUpdateMode>(); } },
                {"autoRestartNotificationDismissal", n => { AutoRestartNotificationDismissal = n.GetEnumValue<AutoRestartNotificationDismissalMethod>(); } },
                {"businessReadyUpdatesOnly", n => { BusinessReadyUpdatesOnly = n.GetEnumValue<WindowsUpdateType>(); } },
                {"deadlineForFeatureUpdatesInDays", n => { DeadlineForFeatureUpdatesInDays = n.GetIntValue(); } },
                {"deadlineForQualityUpdatesInDays", n => { DeadlineForQualityUpdatesInDays = n.GetIntValue(); } },
                {"deadlineGracePeriodInDays", n => { DeadlineGracePeriodInDays = n.GetIntValue(); } },
                {"deliveryOptimizationMode", n => { DeliveryOptimizationMode = n.GetEnumValue<WindowsDeliveryOptimizationMode>(); } },
                {"deviceUpdateStates", n => { DeviceUpdateStates = n.GetCollectionOfObjectValues<WindowsUpdateState>(WindowsUpdateState.CreateFromDiscriminatorValue).ToList(); } },
                {"driversExcluded", n => { DriversExcluded = n.GetBoolValue(); } },
                {"engagedRestartDeadlineInDays", n => { EngagedRestartDeadlineInDays = n.GetIntValue(); } },
                {"engagedRestartSnoozeScheduleInDays", n => { EngagedRestartSnoozeScheduleInDays = n.GetIntValue(); } },
                {"engagedRestartTransitionScheduleInDays", n => { EngagedRestartTransitionScheduleInDays = n.GetIntValue(); } },
                {"featureUpdatesDeferralPeriodInDays", n => { FeatureUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"featureUpdatesPaused", n => { FeatureUpdatesPaused = n.GetBoolValue(); } },
                {"featureUpdatesPauseExpiryDateTime", n => { FeatureUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"featureUpdatesPauseStartDate", n => { FeatureUpdatesPauseStartDate = n.GetDateValue(); } },
                {"featureUpdatesRollbackStartDateTime", n => { FeatureUpdatesRollbackStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"featureUpdatesRollbackWindowInDays", n => { FeatureUpdatesRollbackWindowInDays = n.GetIntValue(); } },
                {"featureUpdatesWillBeRolledBack", n => { FeatureUpdatesWillBeRolledBack = n.GetBoolValue(); } },
                {"installationSchedule", n => { InstallationSchedule = n.GetObjectValue<WindowsUpdateInstallScheduleType>(WindowsUpdateInstallScheduleType.CreateFromDiscriminatorValue); } },
                {"microsoftUpdateServiceAllowed", n => { MicrosoftUpdateServiceAllowed = n.GetBoolValue(); } },
                {"postponeRebootUntilAfterDeadline", n => { PostponeRebootUntilAfterDeadline = n.GetBoolValue(); } },
                {"prereleaseFeatures", n => { PrereleaseFeatures = n.GetEnumValue<PrereleaseFeatures>(); } },
                {"qualityUpdatesDeferralPeriodInDays", n => { QualityUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"qualityUpdatesPaused", n => { QualityUpdatesPaused = n.GetBoolValue(); } },
                {"qualityUpdatesPauseExpiryDateTime", n => { QualityUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"qualityUpdatesPauseStartDate", n => { QualityUpdatesPauseStartDate = n.GetDateValue(); } },
                {"qualityUpdatesRollbackStartDateTime", n => { QualityUpdatesRollbackStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"qualityUpdatesWillBeRolledBack", n => { QualityUpdatesWillBeRolledBack = n.GetBoolValue(); } },
                {"scheduleImminentRestartWarningInMinutes", n => { ScheduleImminentRestartWarningInMinutes = n.GetIntValue(); } },
                {"scheduleRestartWarningInHours", n => { ScheduleRestartWarningInHours = n.GetIntValue(); } },
                {"skipChecksBeforeRestart", n => { SkipChecksBeforeRestart = n.GetBoolValue(); } },
                {"updateNotificationLevel", n => { UpdateNotificationLevel = n.GetEnumValue<WindowsUpdateNotificationDisplayOption>(); } },
                {"updateWeeks", n => { UpdateWeeks = n.GetEnumValue<WindowsUpdateForBusinessUpdateWeeks>(); } },
                {"userPauseAccess", n => { UserPauseAccess = n.GetEnumValue<Enablement>(); } },
                {"userWindowsUpdateScanAccess", n => { UserWindowsUpdateScanAccess = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowWindows11Upgrade", AllowWindows11Upgrade);
            writer.WriteEnumValue<AutomaticUpdateMode>("automaticUpdateMode", AutomaticUpdateMode);
            writer.WriteEnumValue<AutoRestartNotificationDismissalMethod>("autoRestartNotificationDismissal", AutoRestartNotificationDismissal);
            writer.WriteEnumValue<WindowsUpdateType>("businessReadyUpdatesOnly", BusinessReadyUpdatesOnly);
            writer.WriteIntValue("deadlineForFeatureUpdatesInDays", DeadlineForFeatureUpdatesInDays);
            writer.WriteIntValue("deadlineForQualityUpdatesInDays", DeadlineForQualityUpdatesInDays);
            writer.WriteIntValue("deadlineGracePeriodInDays", DeadlineGracePeriodInDays);
            writer.WriteEnumValue<WindowsDeliveryOptimizationMode>("deliveryOptimizationMode", DeliveryOptimizationMode);
            writer.WriteCollectionOfObjectValues<WindowsUpdateState>("deviceUpdateStates", DeviceUpdateStates);
            writer.WriteBoolValue("driversExcluded", DriversExcluded);
            writer.WriteIntValue("engagedRestartDeadlineInDays", EngagedRestartDeadlineInDays);
            writer.WriteIntValue("engagedRestartSnoozeScheduleInDays", EngagedRestartSnoozeScheduleInDays);
            writer.WriteIntValue("engagedRestartTransitionScheduleInDays", EngagedRestartTransitionScheduleInDays);
            writer.WriteIntValue("featureUpdatesDeferralPeriodInDays", FeatureUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("featureUpdatesPaused", FeatureUpdatesPaused);
            writer.WriteDateTimeOffsetValue("featureUpdatesPauseExpiryDateTime", FeatureUpdatesPauseExpiryDateTime);
            writer.WriteDateValue("featureUpdatesPauseStartDate", FeatureUpdatesPauseStartDate);
            writer.WriteDateTimeOffsetValue("featureUpdatesRollbackStartDateTime", FeatureUpdatesRollbackStartDateTime);
            writer.WriteIntValue("featureUpdatesRollbackWindowInDays", FeatureUpdatesRollbackWindowInDays);
            writer.WriteBoolValue("featureUpdatesWillBeRolledBack", FeatureUpdatesWillBeRolledBack);
            writer.WriteObjectValue<WindowsUpdateInstallScheduleType>("installationSchedule", InstallationSchedule);
            writer.WriteBoolValue("microsoftUpdateServiceAllowed", MicrosoftUpdateServiceAllowed);
            writer.WriteBoolValue("postponeRebootUntilAfterDeadline", PostponeRebootUntilAfterDeadline);
            writer.WriteEnumValue<PrereleaseFeatures>("prereleaseFeatures", PrereleaseFeatures);
            writer.WriteIntValue("qualityUpdatesDeferralPeriodInDays", QualityUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("qualityUpdatesPaused", QualityUpdatesPaused);
            writer.WriteDateTimeOffsetValue("qualityUpdatesPauseExpiryDateTime", QualityUpdatesPauseExpiryDateTime);
            writer.WriteDateValue("qualityUpdatesPauseStartDate", QualityUpdatesPauseStartDate);
            writer.WriteDateTimeOffsetValue("qualityUpdatesRollbackStartDateTime", QualityUpdatesRollbackStartDateTime);
            writer.WriteBoolValue("qualityUpdatesWillBeRolledBack", QualityUpdatesWillBeRolledBack);
            writer.WriteIntValue("scheduleImminentRestartWarningInMinutes", ScheduleImminentRestartWarningInMinutes);
            writer.WriteIntValue("scheduleRestartWarningInHours", ScheduleRestartWarningInHours);
            writer.WriteBoolValue("skipChecksBeforeRestart", SkipChecksBeforeRestart);
            writer.WriteEnumValue<WindowsUpdateNotificationDisplayOption>("updateNotificationLevel", UpdateNotificationLevel);
            writer.WriteEnumValue<WindowsUpdateForBusinessUpdateWeeks>("updateWeeks", UpdateWeeks);
            writer.WriteEnumValue<Enablement>("userPauseAccess", UserPauseAccess);
            writer.WriteEnumValue<Enablement>("userWindowsUpdateScanAccess", UserWindowsUpdateScanAccess);
        }
    }
}
