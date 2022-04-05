using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementIntentUserState : Entity, IParsable {
        /// <summary>Count of Devices that belongs to a user for an intent</summary>
        public int? DeviceCount { get; set; }
        /// <summary>Last modified date time of an intent report</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>User state for an intent. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>The user name that is being reported on a device</summary>
        public string UserName { get; set; }
        /// <summary>The user principal name that is being reported on a device</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementIntentUserState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentUserState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceCount", (o,n) => { (o as DeviceManagementIntentUserState).DeviceCount = n.GetIntValue(); } },
                {"lastReportedDateTime", (o,n) => { (o as DeviceManagementIntentUserState).LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as DeviceManagementIntentUserState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userName", (o,n) => { (o as DeviceManagementIntentUserState).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceManagementIntentUserState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
