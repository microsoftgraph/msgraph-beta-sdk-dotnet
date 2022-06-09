using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EnrollmentTroubleshootingEvent : DeviceManagementTroubleshootingEvent, IParsable {
        /// <summary>Azure AD device identifier.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>Type of the enrollment. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount, azureAdJoinUsingAzureVmExtension, androidEnterpriseDedicatedDevice, androidEnterpriseFullyManaged, androidEnterpriseCorporateWorkProfile.</summary>
        public DeviceEnrollmentType? EnrollmentType {
            get { return BackingStore?.Get<DeviceEnrollmentType?>(nameof(EnrollmentType)); }
            set { BackingStore?.Set(nameof(EnrollmentType), value); }
        }
        /// <summary>Highlevel failure category. Possible values are: unknown, authentication, authorization, accountValidation, userValidation, deviceNotSupported, inMaintenance, badRequest, featureNotSupported, enrollmentRestrictionsEnforced, clientDisconnected, userAbandonment.</summary>
        public DeviceEnrollmentFailureReason? FailureCategory {
            get { return BackingStore?.Get<DeviceEnrollmentFailureReason?>(nameof(FailureCategory)); }
            set { BackingStore?.Set(nameof(FailureCategory), value); }
        }
        /// <summary>Detailed failure reason.</summary>
        public string FailureReason {
            get { return BackingStore?.Get<string>(nameof(FailureReason)); }
            set { BackingStore?.Set(nameof(FailureReason), value); }
        }
        /// <summary>Device identifier created or collected by Intune.</summary>
        public string ManagedDeviceIdentifier {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceIdentifier)); }
            set { BackingStore?.Set(nameof(ManagedDeviceIdentifier), value); }
        }
        /// <summary>Operating System.</summary>
        public string OperatingSystem {
            get { return BackingStore?.Get<string>(nameof(OperatingSystem)); }
            set { BackingStore?.Set(nameof(OperatingSystem), value); }
        }
        /// <summary>OS Version.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EnrollmentTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnrollmentTroubleshootingEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"enrollmentType", n => { EnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"failureCategory", n => { FailureCategory = n.GetEnumValue<DeviceEnrollmentFailureReason>(); } },
                {"failureReason", n => { FailureReason = n.GetStringValue(); } },
                {"managedDeviceIdentifier", n => { ManagedDeviceIdentifier = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteEnumValue<DeviceEnrollmentType>("enrollmentType", EnrollmentType);
            writer.WriteEnumValue<DeviceEnrollmentFailureReason>("failureCategory", FailureCategory);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteStringValue("managedDeviceIdentifier", ManagedDeviceIdentifier);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
