using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DepEnrollmentBaseProfile : EnrollmentProfile, IParsable {
        /// <summary>Indicates if Apple id setup pane is disabled</summary>
        public bool? AppleIdDisabled {
            get { return BackingStore?.Get<bool?>("appleIdDisabled"); }
            set { BackingStore?.Set("appleIdDisabled", value); }
        }
        /// <summary>Indicates if Apple pay setup pane is disabled</summary>
        public bool? ApplePayDisabled {
            get { return BackingStore?.Get<bool?>("applePayDisabled"); }
            set { BackingStore?.Set("applePayDisabled", value); }
        }
        /// <summary>URL for setup assistant login</summary>
        public bool? ConfigurationWebUrl {
            get { return BackingStore?.Get<bool?>("configurationWebUrl"); }
            set { BackingStore?.Set("configurationWebUrl", value); }
        }
        /// <summary>Sets a literal or name pattern.</summary>
        public string DeviceNameTemplate {
            get { return BackingStore?.Get<string>("deviceNameTemplate"); }
            set { BackingStore?.Set("deviceNameTemplate", value); }
        }
        /// <summary>Indicates if diagnostics setup pane is disabled</summary>
        public bool? DiagnosticsDisabled {
            get { return BackingStore?.Get<bool?>("diagnosticsDisabled"); }
            set { BackingStore?.Set("diagnosticsDisabled", value); }
        }
        /// <summary>Indicates if displaytone setup screen is disabled</summary>
        public bool? DisplayToneSetupDisabled {
            get { return BackingStore?.Get<bool?>("displayToneSetupDisabled"); }
            set { BackingStore?.Set("displayToneSetupDisabled", value); }
        }
        /// <summary>Indicates if this is the default profile</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>Indicates if the profile is mandatory</summary>
        public bool? IsMandatory {
            get { return BackingStore?.Get<bool?>("isMandatory"); }
            set { BackingStore?.Set("isMandatory", value); }
        }
        /// <summary>Indicates if Location service setup pane is disabled</summary>
        public bool? LocationDisabled {
            get { return BackingStore?.Get<bool?>("locationDisabled"); }
            set { BackingStore?.Set("locationDisabled", value); }
        }
        /// <summary>Indicates if privacy screen is disabled</summary>
        public bool? PrivacyPaneDisabled {
            get { return BackingStore?.Get<bool?>("privacyPaneDisabled"); }
            set { BackingStore?.Set("privacyPaneDisabled", value); }
        }
        /// <summary>Indicates if the profile removal option is disabled</summary>
        public bool? ProfileRemovalDisabled {
            get { return BackingStore?.Get<bool?>("profileRemovalDisabled"); }
            set { BackingStore?.Set("profileRemovalDisabled", value); }
        }
        /// <summary>Indicates if Restore setup pane is blocked</summary>
        public bool? RestoreBlocked {
            get { return BackingStore?.Get<bool?>("restoreBlocked"); }
            set { BackingStore?.Set("restoreBlocked", value); }
        }
        /// <summary>Indicates if screen timeout setup is disabled</summary>
        public bool? ScreenTimeScreenDisabled {
            get { return BackingStore?.Get<bool?>("screenTimeScreenDisabled"); }
            set { BackingStore?.Set("screenTimeScreenDisabled", value); }
        }
        /// <summary>Indicates if siri setup pane is disabled</summary>
        public bool? SiriDisabled {
            get { return BackingStore?.Get<bool?>("siriDisabled"); }
            set { BackingStore?.Set("siriDisabled", value); }
        }
        /// <summary>Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.</summary>
        public bool? SupervisedModeEnabled {
            get { return BackingStore?.Get<bool?>("supervisedModeEnabled"); }
            set { BackingStore?.Set("supervisedModeEnabled", value); }
        }
        /// <summary>Support department information</summary>
        public string SupportDepartment {
            get { return BackingStore?.Get<string>("supportDepartment"); }
            set { BackingStore?.Set("supportDepartment", value); }
        }
        /// <summary>Support phone number</summary>
        public string SupportPhoneNumber {
            get { return BackingStore?.Get<string>("supportPhoneNumber"); }
            set { BackingStore?.Set("supportPhoneNumber", value); }
        }
        /// <summary>Indicates if &apos;Terms and Conditions&apos; setup pane is disabled</summary>
        public bool? TermsAndConditionsDisabled {
            get { return BackingStore?.Get<bool?>("termsAndConditionsDisabled"); }
            set { BackingStore?.Set("termsAndConditionsDisabled", value); }
        }
        /// <summary>Indicates if touch id setup pane is disabled</summary>
        public bool? TouchIdDisabled {
            get { return BackingStore?.Get<bool?>("touchIdDisabled"); }
            set { BackingStore?.Set("touchIdDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new DepEnrollmentBaseProfile and sets the default values.
        /// </summary>
        public DepEnrollmentBaseProfile() : base() {
            Type = "#microsoft.graph.depEnrollmentBaseProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DepEnrollmentBaseProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.depIOSEnrollmentProfile" => new DepIOSEnrollmentProfile(),
                "#microsoft.graph.depMacOSEnrollmentProfile" => new DepMacOSEnrollmentProfile(),
                _ => new DepEnrollmentBaseProfile(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleIdDisabled", n => { AppleIdDisabled = n.GetBoolValue(); } },
                {"applePayDisabled", n => { ApplePayDisabled = n.GetBoolValue(); } },
                {"configurationWebUrl", n => { ConfigurationWebUrl = n.GetBoolValue(); } },
                {"deviceNameTemplate", n => { DeviceNameTemplate = n.GetStringValue(); } },
                {"diagnosticsDisabled", n => { DiagnosticsDisabled = n.GetBoolValue(); } },
                {"displayToneSetupDisabled", n => { DisplayToneSetupDisabled = n.GetBoolValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
                {"locationDisabled", n => { LocationDisabled = n.GetBoolValue(); } },
                {"privacyPaneDisabled", n => { PrivacyPaneDisabled = n.GetBoolValue(); } },
                {"profileRemovalDisabled", n => { ProfileRemovalDisabled = n.GetBoolValue(); } },
                {"restoreBlocked", n => { RestoreBlocked = n.GetBoolValue(); } },
                {"screenTimeScreenDisabled", n => { ScreenTimeScreenDisabled = n.GetBoolValue(); } },
                {"siriDisabled", n => { SiriDisabled = n.GetBoolValue(); } },
                {"supervisedModeEnabled", n => { SupervisedModeEnabled = n.GetBoolValue(); } },
                {"supportDepartment", n => { SupportDepartment = n.GetStringValue(); } },
                {"supportPhoneNumber", n => { SupportPhoneNumber = n.GetStringValue(); } },
                {"termsAndConditionsDisabled", n => { TermsAndConditionsDisabled = n.GetBoolValue(); } },
                {"touchIdDisabled", n => { TouchIdDisabled = n.GetBoolValue(); } },
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
