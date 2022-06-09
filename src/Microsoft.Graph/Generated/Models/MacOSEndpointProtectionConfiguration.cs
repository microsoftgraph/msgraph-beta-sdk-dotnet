using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSEndpointProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Determines whether or not to enable automatic file sample submission for Microsoft Defender Advanced Threat Protection on macOS. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AdvancedThreatProtectionAutomaticSampleSubmission {
            get { return BackingStore?.Get<Enablement?>(nameof(AdvancedThreatProtectionAutomaticSampleSubmission)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionAutomaticSampleSubmission), value); }
        }
        /// <summary>Determines whether or not to enable cloud-delivered protection for Microsoft Defender Advanced Threat Protection on macOS. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AdvancedThreatProtectionCloudDelivered {
            get { return BackingStore?.Get<Enablement?>(nameof(AdvancedThreatProtectionCloudDelivered)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionCloudDelivered), value); }
        }
        /// <summary>Determines whether or not to enable diagnostic and usage data collection for Microsoft Defender Advanced Threat Protection on macOS. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AdvancedThreatProtectionDiagnosticDataCollection {
            get { return BackingStore?.Get<Enablement?>(nameof(AdvancedThreatProtectionDiagnosticDataCollection)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionDiagnosticDataCollection), value); }
        }
        /// <summary>A list of file extensions to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
        public List<string> AdvancedThreatProtectionExcludedExtensions {
            get { return BackingStore?.Get<List<string>>(nameof(AdvancedThreatProtectionExcludedExtensions)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionExcludedExtensions), value); }
        }
        /// <summary>A list of paths to files to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
        public List<string> AdvancedThreatProtectionExcludedFiles {
            get { return BackingStore?.Get<List<string>>(nameof(AdvancedThreatProtectionExcludedFiles)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionExcludedFiles), value); }
        }
        /// <summary>A list of paths to folders to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
        public List<string> AdvancedThreatProtectionExcludedFolders {
            get { return BackingStore?.Get<List<string>>(nameof(AdvancedThreatProtectionExcludedFolders)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionExcludedFolders), value); }
        }
        /// <summary>A list of process names to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
        public List<string> AdvancedThreatProtectionExcludedProcesses {
            get { return BackingStore?.Get<List<string>>(nameof(AdvancedThreatProtectionExcludedProcesses)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionExcludedProcesses), value); }
        }
        /// <summary>Determines whether or not to enable real-time protection for Microsoft Defender Advanced Threat Protection on macOS. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AdvancedThreatProtectionRealTime {
            get { return BackingStore?.Get<Enablement?>(nameof(AdvancedThreatProtectionRealTime)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionRealTime), value); }
        }
        /// <summary>Optional. If set to true, the user can defer the enabling of FileVault until they sign out.</summary>
        public bool? FileVaultAllowDeferralUntilSignOut {
            get { return BackingStore?.Get<bool?>(nameof(FileVaultAllowDeferralUntilSignOut)); }
            set { BackingStore?.Set(nameof(FileVaultAllowDeferralUntilSignOut), value); }
        }
        /// <summary>Optional. When using the Defer option, if set to true, the user is not prompted to enable FileVault at sign-out.</summary>
        public bool? FileVaultDisablePromptAtSignOut {
            get { return BackingStore?.Get<bool?>(nameof(FileVaultDisablePromptAtSignOut)); }
            set { BackingStore?.Set(nameof(FileVaultDisablePromptAtSignOut), value); }
        }
        /// <summary>Whether FileVault should be enabled or not.</summary>
        public bool? FileVaultEnabled {
            get { return BackingStore?.Get<bool?>(nameof(FileVaultEnabled)); }
            set { BackingStore?.Set(nameof(FileVaultEnabled), value); }
        }
        /// <summary>Optional. A hidden personal recovery key does not appear on the user&apos;s screen during FileVault encryption, reducing the risk of it ending up in the wrong hands.</summary>
        public bool? FileVaultHidePersonalRecoveryKey {
            get { return BackingStore?.Get<bool?>(nameof(FileVaultHidePersonalRecoveryKey)); }
            set { BackingStore?.Set(nameof(FileVaultHidePersonalRecoveryKey), value); }
        }
        /// <summary>Required if selected recovery key type(s) include InstitutionalRecoveryKey. The DER Encoded certificate file used to set an institutional recovery key.</summary>
        public byte[] FileVaultInstitutionalRecoveryKeyCertificate {
            get { return BackingStore?.Get<byte[]>(nameof(FileVaultInstitutionalRecoveryKeyCertificate)); }
            set { BackingStore?.Set(nameof(FileVaultInstitutionalRecoveryKeyCertificate), value); }
        }
        /// <summary>File name of the institutional recovery key certificate to display in UI. (.der).</summary>
        public string FileVaultInstitutionalRecoveryKeyCertificateFileName {
            get { return BackingStore?.Get<string>(nameof(FileVaultInstitutionalRecoveryKeyCertificateFileName)); }
            set { BackingStore?.Set(nameof(FileVaultInstitutionalRecoveryKeyCertificateFileName), value); }
        }
        /// <summary>Optional. When using the Defer option, this is the maximum number of times the user can ignore prompts to enable FileVault before FileVault will be required for the user to sign in. If set to -1, it will always prompt to enable FileVault until FileVault is enabled, though it will allow the user to bypass enabling FileVault. Setting this to 0 will disable the feature.</summary>
        public int? FileVaultNumberOfTimesUserCanIgnore {
            get { return BackingStore?.Get<int?>(nameof(FileVaultNumberOfTimesUserCanIgnore)); }
            set { BackingStore?.Set(nameof(FileVaultNumberOfTimesUserCanIgnore), value); }
        }
        /// <summary>Required if selected recovery key type(s) include PersonalRecoveryKey. A short message displayed to the user that explains how they can retrieve their personal recovery key.</summary>
        public string FileVaultPersonalRecoveryKeyHelpMessage {
            get { return BackingStore?.Get<string>(nameof(FileVaultPersonalRecoveryKeyHelpMessage)); }
            set { BackingStore?.Set(nameof(FileVaultPersonalRecoveryKeyHelpMessage), value); }
        }
        /// <summary>Optional. If selected recovery key type(s) include PersonalRecoveryKey, the frequency to rotate that key, in months.</summary>
        public int? FileVaultPersonalRecoveryKeyRotationInMonths {
            get { return BackingStore?.Get<int?>(nameof(FileVaultPersonalRecoveryKeyRotationInMonths)); }
            set { BackingStore?.Set(nameof(FileVaultPersonalRecoveryKeyRotationInMonths), value); }
        }
        /// <summary>Required if FileVault is enabled, determines the type(s) of recovery key to use. . Possible values are: notConfigured, institutionalRecoveryKey, personalRecoveryKey.</summary>
        public MacOSFileVaultRecoveryKeyTypes? FileVaultSelectedRecoveryKeyTypes {
            get { return BackingStore?.Get<MacOSFileVaultRecoveryKeyTypes?>(nameof(FileVaultSelectedRecoveryKeyTypes)); }
            set { BackingStore?.Set(nameof(FileVaultSelectedRecoveryKeyTypes), value); }
        }
        /// <summary>List of applications with firewall settings. Firewall settings for applications not on this list are determined by the user. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSFirewallApplication> FirewallApplications {
            get { return BackingStore?.Get<List<MacOSFirewallApplication>>(nameof(FirewallApplications)); }
            set { BackingStore?.Set(nameof(FirewallApplications), value); }
        }
        /// <summary>Corresponds to the &apos;Block all incoming connections&apos; option.</summary>
        public bool? FirewallBlockAllIncoming {
            get { return BackingStore?.Get<bool?>(nameof(FirewallBlockAllIncoming)); }
            set { BackingStore?.Set(nameof(FirewallBlockAllIncoming), value); }
        }
        /// <summary>Whether the firewall should be enabled or not.</summary>
        public bool? FirewallEnabled {
            get { return BackingStore?.Get<bool?>(nameof(FirewallEnabled)); }
            set { BackingStore?.Set(nameof(FirewallEnabled), value); }
        }
        /// <summary>Corresponds to &apos;Enable stealth mode.&apos;</summary>
        public bool? FirewallEnableStealthMode {
            get { return BackingStore?.Get<bool?>(nameof(FirewallEnableStealthMode)); }
            set { BackingStore?.Set(nameof(FirewallEnableStealthMode), value); }
        }
        /// <summary>System and Privacy setting that determines which download locations apps can be run from on a macOS device. Possible values are: notConfigured, macAppStore, macAppStoreAndIdentifiedDevelopers, anywhere.</summary>
        public MacOSGatekeeperAppSources? GatekeeperAllowedAppSource {
            get { return BackingStore?.Get<MacOSGatekeeperAppSources?>(nameof(GatekeeperAllowedAppSource)); }
            set { BackingStore?.Set(nameof(GatekeeperAllowedAppSource), value); }
        }
        /// <summary>If set to true, the user override for Gatekeeper will be disabled.</summary>
        public bool? GatekeeperBlockOverride {
            get { return BackingStore?.Get<bool?>(nameof(GatekeeperBlockOverride)); }
            set { BackingStore?.Set(nameof(GatekeeperBlockOverride), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSEndpointProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSEndpointProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionAutomaticSampleSubmission", n => { AdvancedThreatProtectionAutomaticSampleSubmission = n.GetEnumValue<Enablement>(); } },
                {"advancedThreatProtectionCloudDelivered", n => { AdvancedThreatProtectionCloudDelivered = n.GetEnumValue<Enablement>(); } },
                {"advancedThreatProtectionDiagnosticDataCollection", n => { AdvancedThreatProtectionDiagnosticDataCollection = n.GetEnumValue<Enablement>(); } },
                {"advancedThreatProtectionExcludedExtensions", n => { AdvancedThreatProtectionExcludedExtensions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"advancedThreatProtectionExcludedFiles", n => { AdvancedThreatProtectionExcludedFiles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"advancedThreatProtectionExcludedFolders", n => { AdvancedThreatProtectionExcludedFolders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"advancedThreatProtectionExcludedProcesses", n => { AdvancedThreatProtectionExcludedProcesses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"advancedThreatProtectionRealTime", n => { AdvancedThreatProtectionRealTime = n.GetEnumValue<Enablement>(); } },
                {"fileVaultAllowDeferralUntilSignOut", n => { FileVaultAllowDeferralUntilSignOut = n.GetBoolValue(); } },
                {"fileVaultDisablePromptAtSignOut", n => { FileVaultDisablePromptAtSignOut = n.GetBoolValue(); } },
                {"fileVaultEnabled", n => { FileVaultEnabled = n.GetBoolValue(); } },
                {"fileVaultHidePersonalRecoveryKey", n => { FileVaultHidePersonalRecoveryKey = n.GetBoolValue(); } },
                {"fileVaultInstitutionalRecoveryKeyCertificate", n => { FileVaultInstitutionalRecoveryKeyCertificate = n.GetByteArrayValue(); } },
                {"fileVaultInstitutionalRecoveryKeyCertificateFileName", n => { FileVaultInstitutionalRecoveryKeyCertificateFileName = n.GetStringValue(); } },
                {"fileVaultNumberOfTimesUserCanIgnore", n => { FileVaultNumberOfTimesUserCanIgnore = n.GetIntValue(); } },
                {"fileVaultPersonalRecoveryKeyHelpMessage", n => { FileVaultPersonalRecoveryKeyHelpMessage = n.GetStringValue(); } },
                {"fileVaultPersonalRecoveryKeyRotationInMonths", n => { FileVaultPersonalRecoveryKeyRotationInMonths = n.GetIntValue(); } },
                {"fileVaultSelectedRecoveryKeyTypes", n => { FileVaultSelectedRecoveryKeyTypes = n.GetEnumValue<MacOSFileVaultRecoveryKeyTypes>(); } },
                {"firewallApplications", n => { FirewallApplications = n.GetCollectionOfObjectValues<MacOSFirewallApplication>(MacOSFirewallApplication.CreateFromDiscriminatorValue).ToList(); } },
                {"firewallBlockAllIncoming", n => { FirewallBlockAllIncoming = n.GetBoolValue(); } },
                {"firewallEnabled", n => { FirewallEnabled = n.GetBoolValue(); } },
                {"firewallEnableStealthMode", n => { FirewallEnableStealthMode = n.GetBoolValue(); } },
                {"gatekeeperAllowedAppSource", n => { GatekeeperAllowedAppSource = n.GetEnumValue<MacOSGatekeeperAppSources>(); } },
                {"gatekeeperBlockOverride", n => { GatekeeperBlockOverride = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Enablement>("advancedThreatProtectionAutomaticSampleSubmission", AdvancedThreatProtectionAutomaticSampleSubmission);
            writer.WriteEnumValue<Enablement>("advancedThreatProtectionCloudDelivered", AdvancedThreatProtectionCloudDelivered);
            writer.WriteEnumValue<Enablement>("advancedThreatProtectionDiagnosticDataCollection", AdvancedThreatProtectionDiagnosticDataCollection);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedExtensions", AdvancedThreatProtectionExcludedExtensions);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedFiles", AdvancedThreatProtectionExcludedFiles);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedFolders", AdvancedThreatProtectionExcludedFolders);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedProcesses", AdvancedThreatProtectionExcludedProcesses);
            writer.WriteEnumValue<Enablement>("advancedThreatProtectionRealTime", AdvancedThreatProtectionRealTime);
            writer.WriteBoolValue("fileVaultAllowDeferralUntilSignOut", FileVaultAllowDeferralUntilSignOut);
            writer.WriteBoolValue("fileVaultDisablePromptAtSignOut", FileVaultDisablePromptAtSignOut);
            writer.WriteBoolValue("fileVaultEnabled", FileVaultEnabled);
            writer.WriteBoolValue("fileVaultHidePersonalRecoveryKey", FileVaultHidePersonalRecoveryKey);
            writer.WriteByteArrayValue("fileVaultInstitutionalRecoveryKeyCertificate", FileVaultInstitutionalRecoveryKeyCertificate);
            writer.WriteStringValue("fileVaultInstitutionalRecoveryKeyCertificateFileName", FileVaultInstitutionalRecoveryKeyCertificateFileName);
            writer.WriteIntValue("fileVaultNumberOfTimesUserCanIgnore", FileVaultNumberOfTimesUserCanIgnore);
            writer.WriteStringValue("fileVaultPersonalRecoveryKeyHelpMessage", FileVaultPersonalRecoveryKeyHelpMessage);
            writer.WriteIntValue("fileVaultPersonalRecoveryKeyRotationInMonths", FileVaultPersonalRecoveryKeyRotationInMonths);
            writer.WriteEnumValue<MacOSFileVaultRecoveryKeyTypes>("fileVaultSelectedRecoveryKeyTypes", FileVaultSelectedRecoveryKeyTypes);
            writer.WriteCollectionOfObjectValues<MacOSFirewallApplication>("firewallApplications", FirewallApplications);
            writer.WriteBoolValue("firewallBlockAllIncoming", FirewallBlockAllIncoming);
            writer.WriteBoolValue("firewallEnabled", FirewallEnabled);
            writer.WriteBoolValue("firewallEnableStealthMode", FirewallEnableStealthMode);
            writer.WriteEnumValue<MacOSGatekeeperAppSources>("gatekeeperAllowedAppSource", GatekeeperAllowedAppSource);
            writer.WriteBoolValue("gatekeeperBlockOverride", GatekeeperBlockOverride);
        }
    }
}
