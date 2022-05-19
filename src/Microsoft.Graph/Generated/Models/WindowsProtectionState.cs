using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device protection status entity.</summary>
    public class WindowsProtectionState : Entity, IParsable {
        /// <summary>Current anti malware version</summary>
        public string AntiMalwareVersion {
            get { return BackingStore?.Get<string>(nameof(AntiMalwareVersion)); }
            set { BackingStore?.Set(nameof(AntiMalwareVersion), value); }
        }
        /// <summary>Device malware list</summary>
        public List<WindowsDeviceMalwareState> DetectedMalwareState {
            get { return BackingStore?.Get<List<WindowsDeviceMalwareState>>(nameof(DetectedMalwareState)); }
            set { BackingStore?.Set(nameof(DetectedMalwareState), value); }
        }
        /// <summary>Computer&apos;s state (like clean or pending full scan or pending reboot etc). Possible values are: clean, fullScanPending, rebootPending, manualStepsPending, offlineScanPending, critical.</summary>
        public WindowsDeviceHealthState? DeviceState {
            get { return BackingStore?.Get<WindowsDeviceHealthState?>(nameof(DeviceState)); }
            set { BackingStore?.Set(nameof(DeviceState), value); }
        }
        /// <summary>Current endpoint protection engine&apos;s version</summary>
        public string EngineVersion {
            get { return BackingStore?.Get<string>(nameof(EngineVersion)); }
            set { BackingStore?.Set(nameof(EngineVersion), value); }
        }
        /// <summary>Full scan overdue or not?</summary>
        public bool? FullScanOverdue {
            get { return BackingStore?.Get<bool?>(nameof(FullScanOverdue)); }
            set { BackingStore?.Set(nameof(FullScanOverdue), value); }
        }
        /// <summary>Full scan required or not?</summary>
        public bool? FullScanRequired {
            get { return BackingStore?.Get<bool?>(nameof(FullScanRequired)); }
            set { BackingStore?.Set(nameof(FullScanRequired), value); }
        }
        /// <summary>Indicates whether the device is a virtual machine.</summary>
        public bool? IsVirtualMachine {
            get { return BackingStore?.Get<bool?>(nameof(IsVirtualMachine)); }
            set { BackingStore?.Set(nameof(IsVirtualMachine), value); }
        }
        /// <summary>Last quick scan datetime</summary>
        public DateTimeOffset? LastFullScanDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastFullScanDateTime)); }
            set { BackingStore?.Set(nameof(LastFullScanDateTime), value); }
        }
        /// <summary>Last full scan signature version</summary>
        public string LastFullScanSignatureVersion {
            get { return BackingStore?.Get<string>(nameof(LastFullScanSignatureVersion)); }
            set { BackingStore?.Set(nameof(LastFullScanSignatureVersion), value); }
        }
        /// <summary>Last quick scan datetime</summary>
        public DateTimeOffset? LastQuickScanDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastQuickScanDateTime)); }
            set { BackingStore?.Set(nameof(LastQuickScanDateTime), value); }
        }
        /// <summary>Last quick scan signature version</summary>
        public string LastQuickScanSignatureVersion {
            get { return BackingStore?.Get<string>(nameof(LastQuickScanSignatureVersion)); }
            set { BackingStore?.Set(nameof(LastQuickScanSignatureVersion), value); }
        }
        /// <summary>Last device health status reported time</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastReportedDateTime)); }
            set { BackingStore?.Set(nameof(LastReportedDateTime), value); }
        }
        /// <summary>Anti malware is enabled or not</summary>
        public bool? MalwareProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MalwareProtectionEnabled)); }
            set { BackingStore?.Set(nameof(MalwareProtectionEnabled), value); }
        }
        /// <summary>Network inspection system enabled or not?</summary>
        public bool? NetworkInspectionSystemEnabled {
            get { return BackingStore?.Get<bool?>(nameof(NetworkInspectionSystemEnabled)); }
            set { BackingStore?.Set(nameof(NetworkInspectionSystemEnabled), value); }
        }
        /// <summary>Product Status of Windows Defender Antivirus. Possible values are: noStatus, serviceNotRunning, serviceStartedWithoutMalwareProtection, pendingFullScanDueToThreatAction, pendingRebootDueToThreatAction, pendingManualStepsDueToThreatAction, avSignaturesOutOfDate, asSignaturesOutOfDate, noQuickScanHappenedForSpecifiedPeriod, noFullScanHappenedForSpecifiedPeriod, systemInitiatedScanInProgress, systemInitiatedCleanInProgress, samplesPendingSubmission, productRunningInEvaluationMode, productRunningInNonGenuineMode, productExpired, offlineScanRequired, serviceShutdownAsPartOfSystemShutdown, threatRemediationFailedCritically, threatRemediationFailedNonCritically, noStatusFlagsSet, platformOutOfDate, platformUpdateInProgress, platformAboutToBeOutdated, signatureOrPlatformEndOfLifeIsPastOrIsImpending, windowsSModeSignaturesInUseOnNonWin10SInstall.</summary>
        public WindowsDefenderProductStatus? ProductStatus {
            get { return BackingStore?.Get<WindowsDefenderProductStatus?>(nameof(ProductStatus)); }
            set { BackingStore?.Set(nameof(ProductStatus), value); }
        }
        /// <summary>Quick scan overdue or not?</summary>
        public bool? QuickScanOverdue {
            get { return BackingStore?.Get<bool?>(nameof(QuickScanOverdue)); }
            set { BackingStore?.Set(nameof(QuickScanOverdue), value); }
        }
        /// <summary>Real time protection is enabled or not?</summary>
        public bool? RealTimeProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(RealTimeProtectionEnabled)); }
            set { BackingStore?.Set(nameof(RealTimeProtectionEnabled), value); }
        }
        /// <summary>Reboot required or not?</summary>
        public bool? RebootRequired {
            get { return BackingStore?.Get<bool?>(nameof(RebootRequired)); }
            set { BackingStore?.Set(nameof(RebootRequired), value); }
        }
        /// <summary>Signature out of date or not?</summary>
        public bool? SignatureUpdateOverdue {
            get { return BackingStore?.Get<bool?>(nameof(SignatureUpdateOverdue)); }
            set { BackingStore?.Set(nameof(SignatureUpdateOverdue), value); }
        }
        /// <summary>Current malware definitions version</summary>
        public string SignatureVersion {
            get { return BackingStore?.Get<string>(nameof(SignatureVersion)); }
            set { BackingStore?.Set(nameof(SignatureVersion), value); }
        }
        /// <summary>Indicates whether the Windows Defender tamper protection feature is enabled.</summary>
        public bool? TamperProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(TamperProtectionEnabled)); }
            set { BackingStore?.Set(nameof(TamperProtectionEnabled), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsProtectionState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsProtectionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"antiMalwareVersion", n => { AntiMalwareVersion = n.GetStringValue(); } },
                {"detectedMalwareState", n => { DetectedMalwareState = n.GetCollectionOfObjectValues<WindowsDeviceMalwareState>(WindowsDeviceMalwareState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceState", n => { DeviceState = n.GetEnumValue<WindowsDeviceHealthState>(); } },
                {"engineVersion", n => { EngineVersion = n.GetStringValue(); } },
                {"fullScanOverdue", n => { FullScanOverdue = n.GetBoolValue(); } },
                {"fullScanRequired", n => { FullScanRequired = n.GetBoolValue(); } },
                {"isVirtualMachine", n => { IsVirtualMachine = n.GetBoolValue(); } },
                {"lastFullScanDateTime", n => { LastFullScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastFullScanSignatureVersion", n => { LastFullScanSignatureVersion = n.GetStringValue(); } },
                {"lastQuickScanDateTime", n => { LastQuickScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastQuickScanSignatureVersion", n => { LastQuickScanSignatureVersion = n.GetStringValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareProtectionEnabled", n => { MalwareProtectionEnabled = n.GetBoolValue(); } },
                {"networkInspectionSystemEnabled", n => { NetworkInspectionSystemEnabled = n.GetBoolValue(); } },
                {"productStatus", n => { ProductStatus = n.GetEnumValue<WindowsDefenderProductStatus>(); } },
                {"quickScanOverdue", n => { QuickScanOverdue = n.GetBoolValue(); } },
                {"realTimeProtectionEnabled", n => { RealTimeProtectionEnabled = n.GetBoolValue(); } },
                {"rebootRequired", n => { RebootRequired = n.GetBoolValue(); } },
                {"signatureUpdateOverdue", n => { SignatureUpdateOverdue = n.GetBoolValue(); } },
                {"signatureVersion", n => { SignatureVersion = n.GetStringValue(); } },
                {"tamperProtectionEnabled", n => { TamperProtectionEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("antiMalwareVersion", AntiMalwareVersion);
            writer.WriteCollectionOfObjectValues<WindowsDeviceMalwareState>("detectedMalwareState", DetectedMalwareState);
            writer.WriteEnumValue<WindowsDeviceHealthState>("deviceState", DeviceState);
            writer.WriteStringValue("engineVersion", EngineVersion);
            writer.WriteBoolValue("fullScanOverdue", FullScanOverdue);
            writer.WriteBoolValue("fullScanRequired", FullScanRequired);
            writer.WriteBoolValue("isVirtualMachine", IsVirtualMachine);
            writer.WriteDateTimeOffsetValue("lastFullScanDateTime", LastFullScanDateTime);
            writer.WriteStringValue("lastFullScanSignatureVersion", LastFullScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastQuickScanDateTime", LastQuickScanDateTime);
            writer.WriteStringValue("lastQuickScanSignatureVersion", LastQuickScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteBoolValue("malwareProtectionEnabled", MalwareProtectionEnabled);
            writer.WriteBoolValue("networkInspectionSystemEnabled", NetworkInspectionSystemEnabled);
            writer.WriteEnumValue<WindowsDefenderProductStatus>("productStatus", ProductStatus);
            writer.WriteBoolValue("quickScanOverdue", QuickScanOverdue);
            writer.WriteBoolValue("realTimeProtectionEnabled", RealTimeProtectionEnabled);
            writer.WriteBoolValue("rebootRequired", RebootRequired);
            writer.WriteBoolValue("signatureUpdateOverdue", SignatureUpdateOverdue);
            writer.WriteStringValue("signatureVersion", SignatureVersion);
            writer.WriteBoolValue("tamperProtectionEnabled", TamperProtectionEnabled);
        }
    }
}
