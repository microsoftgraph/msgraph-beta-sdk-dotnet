using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The ManagedAppEntity is the base entity type for all other entity types under app management workflow.</summary>
    public class ManagedAppRegistration : Entity, IParsable {
        /// <summary>The app package Identifier</summary>
        public MobileAppIdentifier AppIdentifier {
            get { return BackingStore?.Get<MobileAppIdentifier>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
        /// <summary>App version</summary>
        public string ApplicationVersion {
            get { return BackingStore?.Get<string>("applicationVersion"); }
            set { BackingStore?.Set("applicationVersion", value); }
        }
        /// <summary>Zero or more policys already applied on the registered app when it last synchronized with managment service.</summary>
        public List<ManagedAppPolicy> AppliedPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
        /// <summary>The Azure Active Directory Device identifier of the host device. Value could be empty even when the host device is Azure Active Directory registered.</summary>
        public string AzureADDeviceId {
            get { return BackingStore?.Get<string>("azureADDeviceId"); }
            set { BackingStore?.Set("azureADDeviceId", value); }
        }
        /// <summary>Date and time of creation</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The device manufacturer for the current app registration</summary>
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
        /// <summary>The device model for the current app registration</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
        /// <summary>Host device name</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</summary>
        public string DeviceTag {
            get { return BackingStore?.Get<string>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
        /// <summary>Host device type</summary>
        public string DeviceType {
            get { return BackingStore?.Get<string>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>Zero or more reasons an app registration is flagged. E.g. app running on rooted device</summary>
        public List<ManagedAppFlaggedReason?> FlaggedReasons {
            get { return BackingStore?.Get<List<ManagedAppFlaggedReason?>>("flaggedReasons"); }
            set { BackingStore?.Set("flaggedReasons", value); }
        }
        /// <summary>Zero or more policies admin intended for the app as of now.</summary>
        public List<ManagedAppPolicy> IntendedPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("intendedPolicies"); }
            set { BackingStore?.Set("intendedPolicies", value); }
        }
        /// <summary>Date and time of last the app synced with management service.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The Managed Device identifier of the host device. Value could be empty even when the host device is managed.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>App management SDK version</summary>
        public string ManagementSdkVersion {
            get { return BackingStore?.Get<string>("managementSdkVersion"); }
            set { BackingStore?.Set("managementSdkVersion", value); }
        }
        /// <summary>Zero or more long running operations triggered on the app registration.</summary>
        public List<ManagedAppOperation> Operations {
            get { return BackingStore?.Get<List<ManagedAppOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>Operating System version</summary>
        public string PlatformVersion {
            get { return BackingStore?.Get<string>("platformVersion"); }
            set { BackingStore?.Set("platformVersion", value); }
        }
        /// <summary>The user Id to who this app registration belongs.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>Version of the entity.</summary>
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new managedAppRegistration and sets the default values.
        /// </summary>
        public ManagedAppRegistration() : base() {
            OdataType = "#microsoft.graph.managedAppRegistration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAppRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidManagedAppRegistration" => new AndroidManagedAppRegistration(),
                "#microsoft.graph.iosManagedAppRegistration" => new IosManagedAppRegistration(),
                _ => new ManagedAppRegistration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appIdentifier", n => { AppIdentifier = n.GetObjectValue<MobileAppIdentifier>(MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                {"applicationVersion", n => { ApplicationVersion = n.GetStringValue(); } },
                {"appliedPolicies", n => { AppliedPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetStringValue(); } },
                {"flaggedReasons", n => { FlaggedReasons = n.GetCollectionOfEnumValues<ManagedAppFlaggedReason>()?.ToList(); } },
                {"intendedPolicies", n => { IntendedPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managementSdkVersion", n => { ManagementSdkVersion = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<ManagedAppOperation>(ManagedAppOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"platformVersion", n => { PlatformVersion = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MobileAppIdentifier>("appIdentifier", AppIdentifier);
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("appliedPolicies", AppliedPolicies);
            writer.WriteStringValue("azureADDeviceId", AzureADDeviceId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteCollectionOfEnumValues<ManagedAppFlaggedReason>("flaggedReasons", FlaggedReasons);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("intendedPolicies", IntendedPolicies);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managementSdkVersion", ManagementSdkVersion);
            writer.WriteCollectionOfObjectValues<ManagedAppOperation>("operations", Operations);
            writer.WriteStringValue("platformVersion", PlatformVersion);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("version", Version);
        }
    }
}
