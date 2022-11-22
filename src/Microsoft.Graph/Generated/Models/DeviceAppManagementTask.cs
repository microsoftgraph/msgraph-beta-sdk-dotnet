using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A device app management task.</summary>
    public class DeviceAppManagementTask : Entity, IParsable {
        /// <summary>The name or email of the admin this task is assigned to.</summary>
        public string AssignedTo {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
        /// <summary>Device app management task category.</summary>
        public DeviceAppManagementTaskCategory? Category {
            get { return BackingStore?.Get<DeviceAppManagementTaskCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The created date.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The email address of the creator.</summary>
        public string Creator {
            get { return BackingStore?.Get<string>("creator"); }
            set { BackingStore?.Set("creator", value); }
        }
        /// <summary>Notes from the creator.</summary>
        public string CreatorNotes {
            get { return BackingStore?.Get<string>("creatorNotes"); }
            set { BackingStore?.Set("creatorNotes", value); }
        }
        /// <summary>The description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The due date.</summary>
        public DateTimeOffset? DueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
        /// <summary>Device app management task priority.</summary>
        public DeviceAppManagementTaskPriority? Priority {
            get { return BackingStore?.Get<DeviceAppManagementTaskPriority?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Device app management task status.</summary>
        public DeviceAppManagementTaskStatus? Status {
            get { return BackingStore?.Get<DeviceAppManagementTaskStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAppManagementTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.appVulnerabilityTask" => new AppVulnerabilityTask(),
                "#microsoft.graph.securityConfigurationTask" => new SecurityConfigurationTask(),
                "#microsoft.graph.unmanagedDeviceDiscoveryTask" => new UnmanagedDeviceDiscoveryTask(),
                _ => new DeviceAppManagementTask(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"category", n => { Category = n.GetEnumValue<DeviceAppManagementTaskCategory>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creator", n => { Creator = n.GetStringValue(); } },
                {"creatorNotes", n => { CreatorNotes = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", n => { Priority = n.GetEnumValue<DeviceAppManagementTaskPriority>(); } },
                {"status", n => { Status = n.GetEnumValue<DeviceAppManagementTaskStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteEnumValue<DeviceAppManagementTaskCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("creator", Creator);
            writer.WriteStringValue("creatorNotes", CreatorNotes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteEnumValue<DeviceAppManagementTaskPriority>("priority", Priority);
            writer.WriteEnumValue<DeviceAppManagementTaskStatus>("status", Status);
        }
    }
}
