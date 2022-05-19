using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Mobile App Intent and Install State for a given device.</summary>
    public class MobileAppIntentAndStateDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>MobieApp identifier.</summary>
        public string ApplicationId {
            get { return BackingStore?.Get<string>(nameof(ApplicationId)); }
            set { BackingStore?.Set(nameof(ApplicationId), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Human readable version of the application</summary>
        public string DisplayVersion {
            get { return BackingStore?.Get<string>(nameof(DisplayVersion)); }
            set { BackingStore?.Set(nameof(DisplayVersion), value); }
        }
        /// <summary>The install state of the app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.</summary>
        public ResultantAppState? InstallState {
            get { return BackingStore?.Get<ResultantAppState?>(nameof(InstallState)); }
            set { BackingStore?.Set(nameof(InstallState), value); }
        }
        /// <summary>Mobile App Intent. Possible values are: available, notAvailable, requiredInstall, requiredUninstall, requiredAndAvailableInstall, availableInstallWithoutEnrollment, exclude.</summary>
        public Microsoft.Graph.Beta.Models.MobileAppIntent? MobileAppIntent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppIntent?>(nameof(MobileAppIntent)); }
            set { BackingStore?.Set(nameof(MobileAppIntent), value); }
        }
        /// <summary>The supported platforms for the app.</summary>
        public List<MobileAppSupportedDeviceType> SupportedDeviceTypes {
            get { return BackingStore?.Get<List<MobileAppSupportedDeviceType>>(nameof(SupportedDeviceTypes)); }
            set { BackingStore?.Set(nameof(SupportedDeviceTypes), value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppIntentAndStateDetail and sets the default values.
        /// </summary>
        public MobileAppIntentAndStateDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
