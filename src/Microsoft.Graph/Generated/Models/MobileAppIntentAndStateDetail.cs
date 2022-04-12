using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Mobile App Intent and Install State for a given device.</summary>
    public class MobileAppIntentAndStateDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>MobieApp identifier.</summary>
        public string ApplicationId { get; set; }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName { get; set; }
        /// <summary>Human readable version of the application</summary>
        public string DisplayVersion { get; set; }
        /// <summary>The install state of the app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.</summary>
        public ResultantAppState? InstallState { get; set; }
        /// <summary>Mobile App Intent. Possible values are: available, notAvailable, requiredInstall, requiredUninstall, requiredAndAvailableInstall, availableInstallWithoutEnrollment, exclude.</summary>
        public Microsoft.Graph.Beta.Models.MobileAppIntent? MobileAppIntent { get; set; }
        /// <summary>The supported platforms for the app.</summary>
        public List<MobileAppSupportedDeviceType> SupportedDeviceTypes { get; set; }
        /// <summary>
        /// Instantiates a new mobileAppIntentAndStateDetail and sets the default values.
        /// </summary>
        public MobileAppIntentAndStateDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MobileAppIntentAndStateDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppIntentAndStateDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"displayVersion", n => { DisplayVersion = n.GetStringValue(); } },
                {"installState", n => { InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"mobileAppIntent", n => { MobileAppIntent = n.GetEnumValue<MobileAppIntent>(); } },
                {"supportedDeviceTypes", n => { SupportedDeviceTypes = n.GetCollectionOfObjectValues<MobileAppSupportedDeviceType>(MobileAppSupportedDeviceType.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteEnumValue<ResultantAppState>("installState", InstallState);
            writer.WriteEnumValue<MobileAppIntent>("mobileAppIntent", MobileAppIntent);
            writer.WriteCollectionOfObjectValues<MobileAppSupportedDeviceType>("supportedDeviceTypes", SupportedDeviceTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
