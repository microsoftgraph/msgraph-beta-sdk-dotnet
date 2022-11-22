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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>MobieApp identifier.</summary>
        public string ApplicationId {
            get { return BackingStore?.Get<string>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Human readable version of the application</summary>
        public string DisplayVersion {
            get { return BackingStore?.Get<string>("displayVersion"); }
            set { BackingStore?.Set("displayVersion", value); }
        }
        /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
        public ResultantAppState? InstallState {
            get { return BackingStore?.Get<ResultantAppState?>("installState"); }
            set { BackingStore?.Set("installState", value); }
        }
        /// <summary>Indicates the status of the mobile app on the device.</summary>
        public Microsoft.Graph.Beta.Models.MobileAppIntent? MobileAppIntent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppIntent?>("mobileAppIntent"); }
            set { BackingStore?.Set("mobileAppIntent", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The supported platforms for the app.</summary>
        public List<MobileAppSupportedDeviceType> SupportedDeviceTypes {
            get { return BackingStore?.Get<List<MobileAppSupportedDeviceType>>("supportedDeviceTypes"); }
            set { BackingStore?.Set("supportedDeviceTypes", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"supportedDeviceTypes", n => { SupportedDeviceTypes = n.GetCollectionOfObjectValues<MobileAppSupportedDeviceType>(MobileAppSupportedDeviceType.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteEnumValue<ResultantAppState>("installState", InstallState);
            writer.WriteEnumValue<MobileAppIntent>("mobileAppIntent", MobileAppIntent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<MobileAppSupportedDeviceType>("supportedDeviceTypes", SupportedDeviceTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
