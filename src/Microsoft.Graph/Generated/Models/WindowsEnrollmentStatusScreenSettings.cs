using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Enrollment status screen setting</summary>
    public class WindowsEnrollmentStatusScreenSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Allow or block user to use device before profile and app installation complete</summary>
        public bool? AllowDeviceUseBeforeProfileAndAppInstallComplete { get; set; }
        /// <summary>Allow the user to continue using the device on installation failure</summary>
        public bool? AllowDeviceUseOnInstallFailure { get; set; }
        /// <summary>Allow or block log collection on installation failure</summary>
        public bool? AllowLogCollectionOnInstallFailure { get; set; }
        /// <summary>Allow the user to retry the setup on installation failure</summary>
        public bool? BlockDeviceSetupRetryByUser { get; set; }
        /// <summary>Set custom error message to show upon installation failure</summary>
        public string CustomErrorMessage { get; set; }
        /// <summary>Show or hide installation progress to user</summary>
        public bool? HideInstallationProgress { get; set; }
        /// <summary>Set installation progress timeout in minutes</summary>
        public int? InstallProgressTimeoutInMinutes { get; set; }
        /// <summary>
        /// Instantiates a new windowsEnrollmentStatusScreenSettings and sets the default values.
        /// </summary>
        public WindowsEnrollmentStatusScreenSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsEnrollmentStatusScreenSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsEnrollmentStatusScreenSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowDeviceUseBeforeProfileAndAppInstallComplete", n => { AllowDeviceUseBeforeProfileAndAppInstallComplete = n.GetBoolValue(); } },
                {"allowDeviceUseOnInstallFailure", n => { AllowDeviceUseOnInstallFailure = n.GetBoolValue(); } },
                {"allowLogCollectionOnInstallFailure", n => { AllowLogCollectionOnInstallFailure = n.GetBoolValue(); } },
                {"blockDeviceSetupRetryByUser", n => { BlockDeviceSetupRetryByUser = n.GetBoolValue(); } },
                {"customErrorMessage", n => { CustomErrorMessage = n.GetStringValue(); } },
                {"hideInstallationProgress", n => { HideInstallationProgress = n.GetBoolValue(); } },
                {"installProgressTimeoutInMinutes", n => { InstallProgressTimeoutInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowDeviceUseBeforeProfileAndAppInstallComplete", AllowDeviceUseBeforeProfileAndAppInstallComplete);
            writer.WriteBoolValue("allowDeviceUseOnInstallFailure", AllowDeviceUseOnInstallFailure);
            writer.WriteBoolValue("allowLogCollectionOnInstallFailure", AllowLogCollectionOnInstallFailure);
            writer.WriteBoolValue("blockDeviceSetupRetryByUser", BlockDeviceSetupRetryByUser);
            writer.WriteStringValue("customErrorMessage", CustomErrorMessage);
            writer.WriteBoolValue("hideInstallationProgress", HideInstallationProgress);
            writer.WriteIntValue("installProgressTimeoutInMinutes", InstallProgressTimeoutInMinutes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
