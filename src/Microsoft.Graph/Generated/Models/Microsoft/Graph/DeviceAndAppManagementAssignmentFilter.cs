using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceAndAppManagementAssignmentFilter : Entity, IParsable {
        /// <summary>Creation time of the Assignment Filter.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the Assignment Filter.</summary>
        public string Description { get; set; }
        /// <summary>DisplayName of the Assignment Filter.</summary>
        public string DisplayName { get; set; }
        /// <summary>Last modified time of the Assignment Filter.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Platform type of the devices on which the Assignment Filter will be applicable. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.</summary>
        public DevicePlatformType? Platform { get; set; }
        /// <summary>RoleScopeTags of the Assignment Filter.</summary>
        public List<string> RoleScopeTags { get; set; }
        /// <summary>Rule definition of the Assignment Filter.</summary>
        public string Rule { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"roleScopeTags", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).RoleScopeTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rule", (o,n) => { (o as DeviceAndAppManagementAssignmentFilter).Rule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTags", RoleScopeTags);
            writer.WriteStringValue("rule", Rule);
        }
    }
}
