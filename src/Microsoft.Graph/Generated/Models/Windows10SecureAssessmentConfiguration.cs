using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10SecureAssessmentConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to allow the app from printing during the test.</summary>
        public bool? AllowPrinting {
            get { return BackingStore?.Get<bool?>(nameof(AllowPrinting)); }
            set { BackingStore?.Set(nameof(AllowPrinting), value); }
        }
        /// <summary>Indicates whether or not to allow screen capture capability during a test.</summary>
        public bool? AllowScreenCapture {
            get { return BackingStore?.Get<bool?>(nameof(AllowScreenCapture)); }
            set { BackingStore?.Set(nameof(AllowScreenCapture), value); }
        }
        /// <summary>Indicates whether or not to allow text suggestions during the test.</summary>
        public bool? AllowTextSuggestion {
            get { return BackingStore?.Get<bool?>(nameof(AllowTextSuggestion)); }
            set { BackingStore?.Set(nameof(AllowTextSuggestion), value); }
        }
        /// <summary>Specifies the application user model ID of the assessment app launched when a user signs in to a secure assessment with a local guest account. Important notice: this property must be set with localGuestAccountName in order to make the local guest account sign-in experience work properly for secure assessments.</summary>
        public string AssessmentAppUserModelId {
            get { return BackingStore?.Get<string>(nameof(AssessmentAppUserModelId)); }
            set { BackingStore?.Set(nameof(AssessmentAppUserModelId), value); }
        }
        /// <summary>The account used to configure the Windows device for taking the test. The user can be a domain account (domain/user), an AAD account (username@tenant.com) or a local account (username).</summary>
        public string ConfigurationAccount {
            get { return BackingStore?.Get<string>(nameof(ConfigurationAccount)); }
            set { BackingStore?.Set(nameof(ConfigurationAccount), value); }
        }
        /// <summary>The account type used to by ConfigurationAccount. Possible values are: azureADAccount, domainAccount, localAccount, localGuestAccount.</summary>
        public SecureAssessmentAccountType? ConfigurationAccountType {
            get { return BackingStore?.Get<SecureAssessmentAccountType?>(nameof(ConfigurationAccountType)); }
            set { BackingStore?.Set(nameof(ConfigurationAccountType), value); }
        }
        /// <summary>Url link to an assessment that&apos;s automatically loaded when the secure assessment browser is launched. It has to be a valid Url (http[s]://msdn.microsoft.com/).</summary>
        public string LaunchUri {
            get { return BackingStore?.Get<string>(nameof(LaunchUri)); }
            set { BackingStore?.Set(nameof(LaunchUri), value); }
        }
        /// <summary>Specifies the display text for the local guest account shown on the sign-in screen. Typically is the name of an assessment. When the user clicks the local guest account on the sign-in screen, an assessment app is launched with a specified assessment URL. Secure assessments can only be configured with local guest account sign-in on devices running Windows 10, version 1903 or later. Important notice: this property must be set with assessmentAppUserModelID in order to make the local guest account sign-in experience work properly for secure assessments.</summary>
        public string LocalGuestAccountName {
            get { return BackingStore?.Get<string>(nameof(LocalGuestAccountName)); }
            set { BackingStore?.Set(nameof(LocalGuestAccountName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10SecureAssessmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10SecureAssessmentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowPrinting", n => { AllowPrinting = n.GetBoolValue(); } },
                {"allowScreenCapture", n => { AllowScreenCapture = n.GetBoolValue(); } },
                {"allowTextSuggestion", n => { AllowTextSuggestion = n.GetBoolValue(); } },
                {"assessmentAppUserModelId", n => { AssessmentAppUserModelId = n.GetStringValue(); } },
                {"configurationAccount", n => { ConfigurationAccount = n.GetStringValue(); } },
                {"configurationAccountType", n => { ConfigurationAccountType = n.GetEnumValue<SecureAssessmentAccountType>(); } },
                {"launchUri", n => { LaunchUri = n.GetStringValue(); } },
                {"localGuestAccountName", n => { LocalGuestAccountName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowPrinting", AllowPrinting);
            writer.WriteBoolValue("allowScreenCapture", AllowScreenCapture);
            writer.WriteBoolValue("allowTextSuggestion", AllowTextSuggestion);
            writer.WriteStringValue("assessmentAppUserModelId", AssessmentAppUserModelId);
            writer.WriteStringValue("configurationAccount", ConfigurationAccount);
            writer.WriteEnumValue<SecureAssessmentAccountType>("configurationAccountType", ConfigurationAccountType);
            writer.WriteStringValue("launchUri", LaunchUri);
            writer.WriteStringValue("localGuestAccountName", LocalGuestAccountName);
        }
    }
}
