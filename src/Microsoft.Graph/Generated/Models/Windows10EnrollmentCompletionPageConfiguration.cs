using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10EnrollmentCompletionPageConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Allow or block device reset on installation failure</summary>
        public bool? AllowDeviceResetOnInstallFailure {
            get { return BackingStore?.Get<bool?>(nameof(AllowDeviceResetOnInstallFailure)); }
            set { BackingStore?.Set(nameof(AllowDeviceResetOnInstallFailure), value); }
        }
        /// <summary>Allow the user to continue using the device on installation failure</summary>
        public bool? AllowDeviceUseOnInstallFailure {
            get { return BackingStore?.Get<bool?>(nameof(AllowDeviceUseOnInstallFailure)); }
            set { BackingStore?.Set(nameof(AllowDeviceUseOnInstallFailure), value); }
        }
        /// <summary>Allow or block log collection on installation failure</summary>
        public bool? AllowLogCollectionOnInstallFailure {
            get { return BackingStore?.Get<bool?>(nameof(AllowLogCollectionOnInstallFailure)); }
            set { BackingStore?.Set(nameof(AllowLogCollectionOnInstallFailure), value); }
        }
        /// <summary>Allow the user to retry the setup on installation failure</summary>
        public bool? BlockDeviceSetupRetryByUser {
            get { return BackingStore?.Get<bool?>(nameof(BlockDeviceSetupRetryByUser)); }
            set { BackingStore?.Set(nameof(BlockDeviceSetupRetryByUser), value); }
        }
        /// <summary>Set custom error message to show upon installation failure</summary>
        public string CustomErrorMessage {
            get { return BackingStore?.Get<string>(nameof(CustomErrorMessage)); }
            set { BackingStore?.Set(nameof(CustomErrorMessage), value); }
        }
        /// <summary>Only show installation progress for first user post enrollment</summary>
        public bool? DisableUserStatusTrackingAfterFirstUser {
            get { return BackingStore?.Get<bool?>(nameof(DisableUserStatusTrackingAfterFirstUser)); }
            set { BackingStore?.Set(nameof(DisableUserStatusTrackingAfterFirstUser), value); }
        }
        /// <summary>Set installation progress timeout in minutes</summary>
        public int? InstallProgressTimeoutInMinutes {
            get { return BackingStore?.Get<int?>(nameof(InstallProgressTimeoutInMinutes)); }
            set { BackingStore?.Set(nameof(InstallProgressTimeoutInMinutes), value); }
        }
        /// <summary>Selected applications to track the installation status</summary>
        public List<string> SelectedMobileAppIds {
            get { return BackingStore?.Get<List<string>>(nameof(SelectedMobileAppIds)); }
            set { BackingStore?.Set(nameof(SelectedMobileAppIds), value); }
        }
        /// <summary>Show or hide installation progress to user</summary>
        public bool? ShowInstallationProgress {
            get { return BackingStore?.Get<bool?>(nameof(ShowInstallationProgress)); }
            set { BackingStore?.Set(nameof(ShowInstallationProgress), value); }
        }
        /// <summary>Only show installation progress for Autopilot enrollment scenarios</summary>
        public bool? TrackInstallProgressForAutopilotOnly {
            get { return BackingStore?.Get<bool?>(nameof(TrackInstallProgressForAutopilotOnly)); }
            set { BackingStore?.Set(nameof(TrackInstallProgressForAutopilotOnly), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10EnrollmentCompletionPageConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EnrollmentCompletionPageConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDeviceResetOnInstallFailure", n => { AllowDeviceResetOnInstallFailure = n.GetBoolValue(); } },
                {"allowDeviceUseOnInstallFailure", n => { AllowDeviceUseOnInstallFailure = n.GetBoolValue(); } },
                {"allowLogCollectionOnInstallFailure", n => { AllowLogCollectionOnInstallFailure = n.GetBoolValue(); } },
                {"blockDeviceSetupRetryByUser", n => { BlockDeviceSetupRetryByUser = n.GetBoolValue(); } },
                {"customErrorMessage", n => { CustomErrorMessage = n.GetStringValue(); } },
                {"disableUserStatusTrackingAfterFirstUser", n => { DisableUserStatusTrackingAfterFirstUser = n.GetBoolValue(); } },
                {"installProgressTimeoutInMinutes", n => { InstallProgressTimeoutInMinutes = n.GetIntValue(); } },
                {"selectedMobileAppIds", n => { SelectedMobileAppIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"showInstallationProgress", n => { ShowInstallationProgress = n.GetBoolValue(); } },
                {"trackInstallProgressForAutopilotOnly", n => { TrackInstallProgressForAutopilotOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDeviceResetOnInstallFailure", AllowDeviceResetOnInstallFailure);
            writer.WriteBoolValue("allowDeviceUseOnInstallFailure", AllowDeviceUseOnInstallFailure);
            writer.WriteBoolValue("allowLogCollectionOnInstallFailure", AllowLogCollectionOnInstallFailure);
            writer.WriteBoolValue("blockDeviceSetupRetryByUser", BlockDeviceSetupRetryByUser);
            writer.WriteStringValue("customErrorMessage", CustomErrorMessage);
            writer.WriteBoolValue("disableUserStatusTrackingAfterFirstUser", DisableUserStatusTrackingAfterFirstUser);
            writer.WriteIntValue("installProgressTimeoutInMinutes", InstallProgressTimeoutInMinutes);
            writer.WriteCollectionOfPrimitiveValues<string>("selectedMobileAppIds", SelectedMobileAppIds);
            writer.WriteBoolValue("showInstallationProgress", ShowInstallationProgress);
            writer.WriteBoolValue("trackInstallProgressForAutopilotOnly", TrackInstallProgressForAutopilotOnly);
        }
    }
}
