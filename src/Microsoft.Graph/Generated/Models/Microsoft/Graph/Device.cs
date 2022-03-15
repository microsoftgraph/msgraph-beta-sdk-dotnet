using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class Device : DirectoryObject, IParsable {
        /// <summary>true if the account is enabled; otherwise, false. Required. Default is true.  Supports $filter (eq, ne, not, in). Only callers in Global Administrator and Cloud Device Administrator roles can set this property.</summary>
        public bool? AccountEnabled { get; set; }
        /// <summary>For internal use only. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<AlternativeSecurityId> AlternativeSecurityIds { get; set; }
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, not, ge, le, and eq on null values) and $orderBy.</summary>
        public DateTimeOffset? ApproximateLastSignInDateTime { get; set; }
        /// <summary>Set of commands sent to this device.</summary>
        public List<Command> Commands { get; set; }
        /// <summary>The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ComplianceExpirationDateTime { get; set; }
        /// <summary>User-defined property set by Intune to automatically add devices to groups and simplify managing devices.</summary>
        public string DeviceCategory { get; set; }
        /// <summary>Unique identifier set by Azure Device Registration Service at the time of registration. Supports $filter (eq, ne, not, startsWith).</summary>
        public string DeviceId { get; set; }
        /// <summary>For internal use only. Set to null.</summary>
        public string DeviceMetadata { get; set; }
        /// <summary>Ownership of the device. This property is set by Intune. Possible values are: unknown, company, personal.</summary>
        public string DeviceOwnership { get; set; }
        /// <summary>For internal use only.</summary>
        public int? DeviceVersion { get; set; }
        /// <summary>The display name for the device. Required. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName { get; set; }
        /// <summary>The on-premises domain name of Hybrid Azure AD joined devices. This property is set by Intune.</summary>
        public string DomainName { get; set; }
        /// <summary>Enrollment profile applied to the device. For example, Apple Device Enrollment Profile, Device enrollment - Corporate device identifiers, or Windows Autopilot profile name. This property is set by Intune.</summary>
        public string EnrollmentProfileName { get; set; }
        /// <summary>Enrollment type of the device. This property is set by Intune. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement.</summary>
        public string EnrollmentType { get; set; }
        /// <summary>Contains extension attributes 1-15 for the device. The individual extension attributes are not selectable. These properties are mastered in cloud and can be set during creation or update of a device object in Azure AD. Supports $filter (eq, not, startsWith, and eq on null values).</summary>
        public OnPremisesExtensionAttributes ExtensionAttributes { get; set; }
        /// <summary>The collection of open extensions defined for the device. Read-only. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>List of hostNames for the device.</summary>
        public List<string> Hostnames { get; set; }
        /// <summary>true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).</summary>
        public bool? IsCompliant { get; set; }
        /// <summary>true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).</summary>
        public bool? IsManaged { get; set; }
        /// <summary>true if device is rooted; false if device is jail-broken. This can only be updated by Intune.</summary>
        public bool? IsRooted { get; set; }
        /// <summary>Form factor of device. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
        public string Kind { get; set; }
        /// <summary>Management channel of the device.  This property is set by Intune. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController.</summary>
        public string ManagementType { get; set; }
        /// <summary>Manufacturer of the device. Read-only.</summary>
        public string Manufacturer { get; set; }
        /// <summary>Application identifier used to register device into MDM. Read-only. Supports $filter (eq, ne, not, startsWith).</summary>
        public string MdmAppId { get; set; }
        /// <summary>Groups that this device is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf { get; set; }
        /// <summary>Model of the device. Read-only.</summary>
        public string Model { get; set; }
        /// <summary>Friendly name of a device. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
        public string Name { get; set; }
        /// <summary>The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>The type of operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).</summary>
        public string OperatingSystem { get; set; }
        /// <summary>The version of the operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).</summary>
        public string OperatingSystemVersion { get; set; }
        /// <summary>For internal use only. Not nullable. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> PhysicalIds { get; set; }
        /// <summary>Platform of device. Only returned if user signs in with a Microsoft account as part of Project Rome. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
        public string Platform { get; set; }
        /// <summary>The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.</summary>
        public string ProfileType { get; set; }
        /// <summary>The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> RegisteredOwners { get; set; }
        /// <summary>Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> RegisteredUsers { get; set; }
        /// <summary>Date and time of when the device was registered. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? RegistrationDateTime { get; set; }
        /// <summary>Device is online or offline. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
        public string Status { get; set; }
        /// <summary>List of labels applied to the device by the system.</summary>
        public List<string> SystemLabels { get; set; }
        /// <summary>Groups that the device is a member of. This operation is transitive. Supports $expand.</summary>
        public List<DirectoryObject> TransitiveMemberOf { get; set; }
        /// <summary>Type of trust for the joined device. Read-only. Possible values:  Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory</summary>
        public string TrustType { get; set; }
        /// <summary>Represents the usage rights a device has been granted.</summary>
        public List<UsageRight> UsageRights { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Device CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Device();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountEnabled", (o,n) => { (o as Device).AccountEnabled = n.GetBoolValue(); } },
                {"alternativeSecurityIds", (o,n) => { (o as Device).AlternativeSecurityIds = n.GetCollectionOfObjectValues<AlternativeSecurityId>(AlternativeSecurityId.CreateFromDiscriminatorValue).ToList(); } },
                {"approximateLastSignInDateTime", (o,n) => { (o as Device).ApproximateLastSignInDateTime = n.GetDateTimeOffsetValue(); } },
                {"commands", (o,n) => { (o as Device).Commands = n.GetCollectionOfObjectValues<Command>(Command.CreateFromDiscriminatorValue).ToList(); } },
                {"complianceExpirationDateTime", (o,n) => { (o as Device).ComplianceExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceCategory", (o,n) => { (o as Device).DeviceCategory = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as Device).DeviceId = n.GetStringValue(); } },
                {"deviceMetadata", (o,n) => { (o as Device).DeviceMetadata = n.GetStringValue(); } },
                {"deviceOwnership", (o,n) => { (o as Device).DeviceOwnership = n.GetStringValue(); } },
                {"deviceVersion", (o,n) => { (o as Device).DeviceVersion = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as Device).DisplayName = n.GetStringValue(); } },
                {"domainName", (o,n) => { (o as Device).DomainName = n.GetStringValue(); } },
                {"enrollmentProfileName", (o,n) => { (o as Device).EnrollmentProfileName = n.GetStringValue(); } },
                {"enrollmentType", (o,n) => { (o as Device).EnrollmentType = n.GetStringValue(); } },
                {"extensionAttributes", (o,n) => { (o as Device).ExtensionAttributes = n.GetObjectValue<OnPremisesExtensionAttributes>(OnPremisesExtensionAttributes.CreateFromDiscriminatorValue); } },
                {"extensions", (o,n) => { (o as Device).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"hostnames", (o,n) => { (o as Device).Hostnames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isCompliant", (o,n) => { (o as Device).IsCompliant = n.GetBoolValue(); } },
                {"isManaged", (o,n) => { (o as Device).IsManaged = n.GetBoolValue(); } },
                {"isRooted", (o,n) => { (o as Device).IsRooted = n.GetBoolValue(); } },
                {"kind", (o,n) => { (o as Device).Kind = n.GetStringValue(); } },
                {"managementType", (o,n) => { (o as Device).ManagementType = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as Device).Manufacturer = n.GetStringValue(); } },
                {"mdmAppId", (o,n) => { (o as Device).MdmAppId = n.GetStringValue(); } },
                {"memberOf", (o,n) => { (o as Device).MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"model", (o,n) => { (o as Device).Model = n.GetStringValue(); } },
                {"name", (o,n) => { (o as Device).Name = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", (o,n) => { (o as Device).OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", (o,n) => { (o as Device).OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"operatingSystem", (o,n) => { (o as Device).OperatingSystem = n.GetStringValue(); } },
                {"operatingSystemVersion", (o,n) => { (o as Device).OperatingSystemVersion = n.GetStringValue(); } },
                {"physicalIds", (o,n) => { (o as Device).PhysicalIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platform", (o,n) => { (o as Device).Platform = n.GetStringValue(); } },
                {"profileType", (o,n) => { (o as Device).ProfileType = n.GetStringValue(); } },
                {"registeredOwners", (o,n) => { (o as Device).RegisteredOwners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"registeredUsers", (o,n) => { (o as Device).RegisteredUsers = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"registrationDateTime", (o,n) => { (o as Device).RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as Device).Status = n.GetStringValue(); } },
                {"systemLabels", (o,n) => { (o as Device).SystemLabels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"transitiveMemberOf", (o,n) => { (o as Device).TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"trustType", (o,n) => { (o as Device).TrustType = n.GetStringValue(); } },
                {"usageRights", (o,n) => { (o as Device).UsageRights = n.GetCollectionOfObjectValues<UsageRight>(UsageRight.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AlternativeSecurityId>("alternativeSecurityIds", AlternativeSecurityIds);
            writer.WriteDateTimeOffsetValue("approximateLastSignInDateTime", ApproximateLastSignInDateTime);
            writer.WriteCollectionOfObjectValues<Command>("commands", Commands);
            writer.WriteDateTimeOffsetValue("complianceExpirationDateTime", ComplianceExpirationDateTime);
            writer.WriteStringValue("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceMetadata", DeviceMetadata);
            writer.WriteStringValue("deviceOwnership", DeviceOwnership);
            writer.WriteIntValue("deviceVersion", DeviceVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("enrollmentProfileName", EnrollmentProfileName);
            writer.WriteStringValue("enrollmentType", EnrollmentType);
            writer.WriteObjectValue<OnPremisesExtensionAttributes>("extensionAttributes", ExtensionAttributes);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfPrimitiveValues<string>("hostnames", Hostnames);
            writer.WriteBoolValue("isCompliant", IsCompliant);
            writer.WriteBoolValue("isManaged", IsManaged);
            writer.WriteBoolValue("isRooted", IsRooted);
            writer.WriteStringValue("kind", Kind);
            writer.WriteStringValue("managementType", ManagementType);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("mdmAppId", MdmAppId);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("physicalIds", PhysicalIds);
            writer.WriteStringValue("platform", Platform);
            writer.WriteStringValue("profileType", ProfileType);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredOwners", RegisteredOwners);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredUsers", RegisteredUsers);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("systemLabels", SystemLabels);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteStringValue("trustType", TrustType);
            writer.WriteCollectionOfObjectValues<UsageRight>("usageRights", UsageRights);
        }
    }
}
