using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceHealthAttestationState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.</summary>
        public string AttestationIdentityKey {
            get { return BackingStore?.Get<string>(nameof(AttestationIdentityKey)); }
            set { BackingStore?.Set(nameof(AttestationIdentityKey), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>On or Off of BitLocker Drive Encryption</summary>
        public string BitLockerStatus {
            get { return BackingStore?.Get<string>(nameof(BitLockerStatus)); }
            set { BackingStore?.Set(nameof(BitLockerStatus), value); }
        }
        /// <summary>The security version number of the Boot Application</summary>
        public string BootAppSecurityVersion {
            get { return BackingStore?.Get<string>(nameof(BootAppSecurityVersion)); }
            set { BackingStore?.Set(nameof(BootAppSecurityVersion), value); }
        }
        /// <summary>When bootDebugging is enabled, the device is used in development and testing</summary>
        public string BootDebugging {
            get { return BackingStore?.Get<string>(nameof(BootDebugging)); }
            set { BackingStore?.Set(nameof(BootDebugging), value); }
        }
        /// <summary>The security version number of the Boot Application</summary>
        public string BootManagerSecurityVersion {
            get { return BackingStore?.Get<string>(nameof(BootManagerSecurityVersion)); }
            set { BackingStore?.Set(nameof(BootManagerSecurityVersion), value); }
        }
        /// <summary>The version of the Boot Manager</summary>
        public string BootManagerVersion {
            get { return BackingStore?.Get<string>(nameof(BootManagerVersion)); }
            set { BackingStore?.Set(nameof(BootManagerVersion), value); }
        }
        /// <summary>The Boot Revision List that was loaded during initial boot on the attested device</summary>
        public string BootRevisionListInfo {
            get { return BackingStore?.Get<string>(nameof(BootRevisionListInfo)); }
            set { BackingStore?.Set(nameof(BootRevisionListInfo), value); }
        }
        /// <summary>When code integrity is enabled, code execution is restricted to integrity verified code</summary>
        public string CodeIntegrity {
            get { return BackingStore?.Get<string>(nameof(CodeIntegrity)); }
            set { BackingStore?.Set(nameof(CodeIntegrity), value); }
        }
        /// <summary>The version of the Boot Manager</summary>
        public string CodeIntegrityCheckVersion {
            get { return BackingStore?.Get<string>(nameof(CodeIntegrityCheckVersion)); }
            set { BackingStore?.Set(nameof(CodeIntegrityCheckVersion), value); }
        }
        /// <summary>The Code Integrity policy that is controlling the security of the boot environment</summary>
        public string CodeIntegrityPolicy {
            get { return BackingStore?.Get<string>(nameof(CodeIntegrityPolicy)); }
            set { BackingStore?.Set(nameof(CodeIntegrityPolicy), value); }
        }
        /// <summary>The DHA report version. (Namespace version)</summary>
        public string ContentNamespaceUrl {
            get { return BackingStore?.Get<string>(nameof(ContentNamespaceUrl)); }
            set { BackingStore?.Set(nameof(ContentNamespaceUrl), value); }
        }
        /// <summary>The HealthAttestation state schema version</summary>
        public string ContentVersion {
            get { return BackingStore?.Get<string>(nameof(ContentVersion)); }
            set { BackingStore?.Set(nameof(ContentVersion), value); }
        }
        /// <summary>DEP Policy defines a set of hardware and software technologies that perform additional checks on memory</summary>
        public string DataExcutionPolicy {
            get { return BackingStore?.Get<string>(nameof(DataExcutionPolicy)); }
            set { BackingStore?.Set(nameof(DataExcutionPolicy), value); }
        }
        /// <summary>The DHA report version. (Namespace version)</summary>
        public string DeviceHealthAttestationStatus {
            get { return BackingStore?.Get<string>(nameof(DeviceHealthAttestationStatus)); }
            set { BackingStore?.Set(nameof(DeviceHealthAttestationStatus), value); }
        }
        /// <summary>ELAM provides protection for the computers in your network when they start up</summary>
        public string EarlyLaunchAntiMalwareDriverProtection {
            get { return BackingStore?.Get<string>(nameof(EarlyLaunchAntiMalwareDriverProtection)); }
            set { BackingStore?.Set(nameof(EarlyLaunchAntiMalwareDriverProtection), value); }
        }
        /// <summary>This attribute indicates if DHA is supported for the device</summary>
        public string HealthAttestationSupportedStatus {
            get { return BackingStore?.Get<string>(nameof(HealthAttestationSupportedStatus)); }
            set { BackingStore?.Set(nameof(HealthAttestationSupportedStatus), value); }
        }
        /// <summary>This attribute appears if DHA-Service detects an integrity issue</summary>
        public string HealthStatusMismatchInfo {
            get { return BackingStore?.Get<string>(nameof(HealthStatusMismatchInfo)); }
            set { BackingStore?.Set(nameof(HealthStatusMismatchInfo), value); }
        }
        /// <summary>The DateTime when device was evaluated or issued to MDM</summary>
        public DateTimeOffset? IssuedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(IssuedDateTime)); }
            set { BackingStore?.Set(nameof(IssuedDateTime), value); }
        }
        /// <summary>The Timestamp of the last update.</summary>
        public string LastUpdateDateTime {
            get { return BackingStore?.Get<string>(nameof(LastUpdateDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdateDateTime), value); }
        }
        /// <summary>When operatingSystemKernelDebugging is enabled, the device is used in development and testing</summary>
        public string OperatingSystemKernelDebugging {
            get { return BackingStore?.Get<string>(nameof(OperatingSystemKernelDebugging)); }
            set { BackingStore?.Set(nameof(OperatingSystemKernelDebugging), value); }
        }
        /// <summary>The Operating System Revision List that was loaded during initial boot on the attested device</summary>
        public string OperatingSystemRevListInfo {
            get { return BackingStore?.Get<string>(nameof(OperatingSystemRevListInfo)); }
            set { BackingStore?.Set(nameof(OperatingSystemRevListInfo), value); }
        }
        /// <summary>The measurement that is captured in PCR[0]</summary>
        public string Pcr0 {
            get { return BackingStore?.Get<string>(nameof(Pcr0)); }
            set { BackingStore?.Set(nameof(Pcr0), value); }
        }
        /// <summary>Informational attribute that identifies the HASH algorithm that was used by TPM</summary>
        public string PcrHashAlgorithm {
            get { return BackingStore?.Get<string>(nameof(PcrHashAlgorithm)); }
            set { BackingStore?.Set(nameof(PcrHashAlgorithm), value); }
        }
        /// <summary>The number of times a PC device has hibernated or resumed</summary>
        public long? ResetCount {
            get { return BackingStore?.Get<long?>(nameof(ResetCount)); }
            set { BackingStore?.Set(nameof(ResetCount), value); }
        }
        /// <summary>The number of times a PC device has rebooted</summary>
        public long? RestartCount {
            get { return BackingStore?.Get<long?>(nameof(RestartCount)); }
            set { BackingStore?.Set(nameof(RestartCount), value); }
        }
        /// <summary>Safe mode is a troubleshooting option for Windows that starts your computer in a limited state</summary>
        public string SafeMode {
            get { return BackingStore?.Get<string>(nameof(SafeMode)); }
            set { BackingStore?.Set(nameof(SafeMode), value); }
        }
        /// <summary>When Secure Boot is enabled, the core components must have the correct cryptographic signatures</summary>
        public string SecureBoot {
            get { return BackingStore?.Get<string>(nameof(SecureBoot)); }
            set { BackingStore?.Set(nameof(SecureBoot), value); }
        }
        /// <summary>Fingerprint of the Custom Secure Boot Configuration Policy</summary>
        public string SecureBootConfigurationPolicyFingerPrint {
            get { return BackingStore?.Get<string>(nameof(SecureBootConfigurationPolicyFingerPrint)); }
            set { BackingStore?.Set(nameof(SecureBootConfigurationPolicyFingerPrint), value); }
        }
        /// <summary>When test signing is allowed, the device does not enforce signature validation during boot</summary>
        public string TestSigning {
            get { return BackingStore?.Get<string>(nameof(TestSigning)); }
            set { BackingStore?.Set(nameof(TestSigning), value); }
        }
        /// <summary>The security version number of the Boot Application</summary>
        public string TpmVersion {
            get { return BackingStore?.Get<string>(nameof(TpmVersion)); }
            set { BackingStore?.Set(nameof(TpmVersion), value); }
        }
        /// <summary>VSM is a container that protects high value assets from a compromised kernel</summary>
        public string VirtualSecureMode {
            get { return BackingStore?.Get<string>(nameof(VirtualSecureMode)); }
            set { BackingStore?.Set(nameof(VirtualSecureMode), value); }
        }
        /// <summary>Operating system running with limited services that is used to prepare a computer for Windows</summary>
        public string WindowsPE {
            get { return BackingStore?.Get<string>(nameof(WindowsPE)); }
            set { BackingStore?.Set(nameof(WindowsPE), value); }
        }
        /// <summary>
        /// Instantiates a new deviceHealthAttestationState and sets the default values.
        /// </summary>
        public DeviceHealthAttestationState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceHealthAttestationState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthAttestationState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attestationIdentityKey", n => { AttestationIdentityKey = n.GetStringValue(); } },
                {"bitLockerStatus", n => { BitLockerStatus = n.GetStringValue(); } },
                {"bootAppSecurityVersion", n => { BootAppSecurityVersion = n.GetStringValue(); } },
                {"bootDebugging", n => { BootDebugging = n.GetStringValue(); } },
                {"bootManagerSecurityVersion", n => { BootManagerSecurityVersion = n.GetStringValue(); } },
                {"bootManagerVersion", n => { BootManagerVersion = n.GetStringValue(); } },
                {"bootRevisionListInfo", n => { BootRevisionListInfo = n.GetStringValue(); } },
                {"codeIntegrity", n => { CodeIntegrity = n.GetStringValue(); } },
                {"codeIntegrityCheckVersion", n => { CodeIntegrityCheckVersion = n.GetStringValue(); } },
                {"codeIntegrityPolicy", n => { CodeIntegrityPolicy = n.GetStringValue(); } },
                {"contentNamespaceUrl", n => { ContentNamespaceUrl = n.GetStringValue(); } },
                {"contentVersion", n => { ContentVersion = n.GetStringValue(); } },
                {"dataExcutionPolicy", n => { DataExcutionPolicy = n.GetStringValue(); } },
                {"deviceHealthAttestationStatus", n => { DeviceHealthAttestationStatus = n.GetStringValue(); } },
                {"earlyLaunchAntiMalwareDriverProtection", n => { EarlyLaunchAntiMalwareDriverProtection = n.GetStringValue(); } },
                {"healthAttestationSupportedStatus", n => { HealthAttestationSupportedStatus = n.GetStringValue(); } },
                {"healthStatusMismatchInfo", n => { HealthStatusMismatchInfo = n.GetStringValue(); } },
                {"issuedDateTime", n => { IssuedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetStringValue(); } },
                {"operatingSystemKernelDebugging", n => { OperatingSystemKernelDebugging = n.GetStringValue(); } },
                {"operatingSystemRevListInfo", n => { OperatingSystemRevListInfo = n.GetStringValue(); } },
                {"pcr0", n => { Pcr0 = n.GetStringValue(); } },
                {"pcrHashAlgorithm", n => { PcrHashAlgorithm = n.GetStringValue(); } },
                {"resetCount", n => { ResetCount = n.GetLongValue(); } },
                {"restartCount", n => { RestartCount = n.GetLongValue(); } },
                {"safeMode", n => { SafeMode = n.GetStringValue(); } },
                {"secureBoot", n => { SecureBoot = n.GetStringValue(); } },
                {"secureBootConfigurationPolicyFingerPrint", n => { SecureBootConfigurationPolicyFingerPrint = n.GetStringValue(); } },
                {"testSigning", n => { TestSigning = n.GetStringValue(); } },
                {"tpmVersion", n => { TpmVersion = n.GetStringValue(); } },
                {"virtualSecureMode", n => { VirtualSecureMode = n.GetStringValue(); } },
                {"windowsPE", n => { WindowsPE = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("attestationIdentityKey", AttestationIdentityKey);
            writer.WriteStringValue("bitLockerStatus", BitLockerStatus);
            writer.WriteStringValue("bootAppSecurityVersion", BootAppSecurityVersion);
            writer.WriteStringValue("bootDebugging", BootDebugging);
            writer.WriteStringValue("bootManagerSecurityVersion", BootManagerSecurityVersion);
            writer.WriteStringValue("bootManagerVersion", BootManagerVersion);
            writer.WriteStringValue("bootRevisionListInfo", BootRevisionListInfo);
            writer.WriteStringValue("codeIntegrity", CodeIntegrity);
            writer.WriteStringValue("codeIntegrityCheckVersion", CodeIntegrityCheckVersion);
            writer.WriteStringValue("codeIntegrityPolicy", CodeIntegrityPolicy);
            writer.WriteStringValue("contentNamespaceUrl", ContentNamespaceUrl);
            writer.WriteStringValue("contentVersion", ContentVersion);
            writer.WriteStringValue("dataExcutionPolicy", DataExcutionPolicy);
            writer.WriteStringValue("deviceHealthAttestationStatus", DeviceHealthAttestationStatus);
            writer.WriteStringValue("earlyLaunchAntiMalwareDriverProtection", EarlyLaunchAntiMalwareDriverProtection);
            writer.WriteStringValue("healthAttestationSupportedStatus", HealthAttestationSupportedStatus);
            writer.WriteStringValue("healthStatusMismatchInfo", HealthStatusMismatchInfo);
            writer.WriteDateTimeOffsetValue("issuedDateTime", IssuedDateTime);
            writer.WriteStringValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteStringValue("operatingSystemKernelDebugging", OperatingSystemKernelDebugging);
            writer.WriteStringValue("operatingSystemRevListInfo", OperatingSystemRevListInfo);
            writer.WriteStringValue("pcr0", Pcr0);
            writer.WriteStringValue("pcrHashAlgorithm", PcrHashAlgorithm);
            writer.WriteLongValue("resetCount", ResetCount);
            writer.WriteLongValue("restartCount", RestartCount);
            writer.WriteStringValue("safeMode", SafeMode);
            writer.WriteStringValue("secureBoot", SecureBoot);
            writer.WriteStringValue("secureBootConfigurationPolicyFingerPrint", SecureBootConfigurationPolicyFingerPrint);
            writer.WriteStringValue("testSigning", TestSigning);
            writer.WriteStringValue("tpmVersion", TpmVersion);
            writer.WriteStringValue("virtualSecureMode", VirtualSecureMode);
            writer.WriteStringValue("windowsPE", WindowsPE);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
