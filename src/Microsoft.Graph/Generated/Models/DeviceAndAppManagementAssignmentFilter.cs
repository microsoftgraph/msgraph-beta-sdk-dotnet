using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the properties used for Assignment Filter.</summary>
    public class DeviceAndAppManagementAssignmentFilter : Entity, IParsable {
        /// <summary>Creation time of the Assignment Filter.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Description of the Assignment Filter.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>DisplayName of the Assignment Filter.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Last modified time of the Assignment Filter.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Platform type of the devices on which the Assignment Filter will be applicable. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.</summary>
        public DevicePlatformType? Platform {
            get { return BackingStore?.Get<DevicePlatformType?>(nameof(Platform)); }
            set { BackingStore?.Set(nameof(Platform), value); }
        }
        /// <summary>RoleScopeTags of the Assignment Filter.</summary>
        public List<string> RoleScopeTags {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTags)); }
            set { BackingStore?.Set(nameof(RoleScopeTags), value); }
        }
        /// <summary>Rule definition of the Assignment Filter.</summary>
        public string Rule {
            get { return BackingStore?.Get<string>(nameof(Rule)); }
            set { BackingStore?.Set(nameof(Rule), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceAndAppManagementAssignmentFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.payloadCompatibleAssignmentFilter" => new PayloadCompatibleAssignmentFilter(),
                _ => new DeviceAndAppManagementAssignmentFilter(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rule", n => { Rule = n.GetStringValue(); } },
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
