using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class DeviceComplianceDeviceStatus : Entity, IParsable {
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ComplianceGracePeriodExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ComplianceGracePeriodExpirationDateTime), value); }
        }
        /// <summary>Device name of the DevicePolicyStatus.</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>(nameof(DeviceDisplayName)); }
            set { BackingStore?.Set(nameof(DeviceDisplayName), value); }
        }
        /// <summary>The device model that is being reported</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>(nameof(DeviceModel)); }
            set { BackingStore?.Set(nameof(DeviceModel), value); }
        }
        /// <summary>Last modified date time of the policy report.</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastReportedDateTime)); }
            set { BackingStore?.Set(nameof(LastReportedDateTime), value); }
        }
        /// <summary>Platform of the device that is being reported</summary>
        public int? Platform {
            get { return BackingStore?.Get<int?>(nameof(Platform)); }
            set { BackingStore?.Set(nameof(Platform), value); }
        }
        /// <summary>Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? Status {
            get { return BackingStore?.Get<ComplianceStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The User Name that is being reported</summary>
        public string UserName {
            get { return BackingStore?.Get<string>(nameof(UserName)); }
            set { BackingStore?.Set(nameof(UserName), value); }
        }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceDeviceStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceDeviceStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetIntValue(); } },
                {"status", n => { Status = n.GetEnumValue<ComplianceStatus>(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteIntValue("platform", Platform);
            writer.WriteEnumValue<ComplianceStatus>("status", Status);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
