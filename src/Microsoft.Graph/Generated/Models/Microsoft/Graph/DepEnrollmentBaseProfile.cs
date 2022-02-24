using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DepEnrollmentBaseProfile : EnrollmentProfile, IParsable {
        /// <summary>Indicates if Apple id setup pane is disabled</summary>
        public bool? AppleIdDisabled { get; set; }
        /// <summary>Indicates if Apple pay setup pane is disabled</summary>
        public bool? ApplePayDisabled { get; set; }
        /// <summary>URL for setup assistant login</summary>
        public bool? ConfigurationWebUrl { get; set; }
        /// <summary>Sets a literal or name pattern.</summary>
        public string DeviceNameTemplate { get; set; }
        /// <summary>Indicates if diagnostics setup pane is disabled</summary>
        public bool? DiagnosticsDisabled { get; set; }
        /// <summary>Indicates if displaytone setup screen is disabled</summary>
        public bool? DisplayToneSetupDisabled { get; set; }
        /// <summary>Indicates if this is the default profile</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Indicates if the profile is mandatory</summary>
        public bool? IsMandatory { get; set; }
        /// <summary>Indicates if Location service setup pane is disabled</summary>
        public bool? LocationDisabled { get; set; }
        /// <summary>Indicates if privacy screen is disabled</summary>
        public bool? PrivacyPaneDisabled { get; set; }
        /// <summary>Indicates if the profile removal option is disabled</summary>
        public bool? ProfileRemovalDisabled { get; set; }
        /// <summary>Indicates if Restore setup pane is blocked</summary>
        public bool? RestoreBlocked { get; set; }
        /// <summary>Indicates if screen timeout setup is disabled</summary>
        public bool? ScreenTimeScreenDisabled { get; set; }
        /// <summary>Indicates if siri setup pane is disabled</summary>
        public bool? SiriDisabled { get; set; }
        /// <summary>Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.</summary>
        public bool? SupervisedModeEnabled { get; set; }
        /// <summary>Support department information</summary>
        public string SupportDepartment { get; set; }
        /// <summary>Support phone number</summary>
        public string SupportPhoneNumber { get; set; }
        /// <summary>Indicates if 'Terms and Conditions' setup pane is disabled</summary>
        public bool? TermsAndConditionsDisabled { get; set; }
        /// <summary>Indicates if touch id setup pane is disabled</summary>
        public bool? TouchIdDisabled { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appleIdDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).AppleIdDisabled = n.GetBoolValue(); } },
                {"applePayDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).ApplePayDisabled = n.GetBoolValue(); } },
                {"configurationWebUrl", (o,n) => { (o as DepEnrollmentBaseProfile).ConfigurationWebUrl = n.GetBoolValue(); } },
                {"deviceNameTemplate", (o,n) => { (o as DepEnrollmentBaseProfile).DeviceNameTemplate = n.GetStringValue(); } },
                {"diagnosticsDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).DiagnosticsDisabled = n.GetBoolValue(); } },
                {"displayToneSetupDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).DisplayToneSetupDisabled = n.GetBoolValue(); } },
                {"isDefault", (o,n) => { (o as DepEnrollmentBaseProfile).IsDefault = n.GetBoolValue(); } },
                {"isMandatory", (o,n) => { (o as DepEnrollmentBaseProfile).IsMandatory = n.GetBoolValue(); } },
                {"locationDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).LocationDisabled = n.GetBoolValue(); } },
                {"privacyPaneDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).PrivacyPaneDisabled = n.GetBoolValue(); } },
                {"profileRemovalDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).ProfileRemovalDisabled = n.GetBoolValue(); } },
                {"restoreBlocked", (o,n) => { (o as DepEnrollmentBaseProfile).RestoreBlocked = n.GetBoolValue(); } },
                {"screenTimeScreenDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).ScreenTimeScreenDisabled = n.GetBoolValue(); } },
                {"siriDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).SiriDisabled = n.GetBoolValue(); } },
                {"supervisedModeEnabled", (o,n) => { (o as DepEnrollmentBaseProfile).SupervisedModeEnabled = n.GetBoolValue(); } },
                {"supportDepartment", (o,n) => { (o as DepEnrollmentBaseProfile).SupportDepartment = n.GetStringValue(); } },
                {"supportPhoneNumber", (o,n) => { (o as DepEnrollmentBaseProfile).SupportPhoneNumber = n.GetStringValue(); } },
                {"termsAndConditionsDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).TermsAndConditionsDisabled = n.GetBoolValue(); } },
                {"touchIdDisabled", (o,n) => { (o as DepEnrollmentBaseProfile).TouchIdDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appleIdDisabled", AppleIdDisabled);
            writer.WriteBoolValue("applePayDisabled", ApplePayDisabled);
            writer.WriteBoolValue("configurationWebUrl", ConfigurationWebUrl);
            writer.WriteStringValue("deviceNameTemplate", DeviceNameTemplate);
            writer.WriteBoolValue("diagnosticsDisabled", DiagnosticsDisabled);
            writer.WriteBoolValue("displayToneSetupDisabled", DisplayToneSetupDisabled);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMandatory", IsMandatory);
            writer.WriteBoolValue("locationDisabled", LocationDisabled);
            writer.WriteBoolValue("privacyPaneDisabled", PrivacyPaneDisabled);
            writer.WriteBoolValue("profileRemovalDisabled", ProfileRemovalDisabled);
            writer.WriteBoolValue("restoreBlocked", RestoreBlocked);
            writer.WriteBoolValue("screenTimeScreenDisabled", ScreenTimeScreenDisabled);
            writer.WriteBoolValue("siriDisabled", SiriDisabled);
            writer.WriteBoolValue("supervisedModeEnabled", SupervisedModeEnabled);
            writer.WriteStringValue("supportDepartment", SupportDepartment);
            writer.WriteStringValue("supportPhoneNumber", SupportPhoneNumber);
            writer.WriteBoolValue("termsAndConditionsDisabled", TermsAndConditionsDisabled);
            writer.WriteBoolValue("touchIdDisabled", TouchIdDisabled);
        }
    }
}
