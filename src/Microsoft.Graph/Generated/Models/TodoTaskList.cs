using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class TodoTaskList : Entity, IParsable {
        /// <summary>The name of the task list.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The collection of open extensions defined for the task list. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>True if the user is owner of the given task list.</summary>
        public bool? IsOwner {
            get { return BackingStore?.Get<bool?>(nameof(IsOwner)); }
            set { BackingStore?.Set(nameof(IsOwner), value); }
        }
        /// <summary>True if the task list is shared with other users</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>(nameof(IsShared)); }
            set { BackingStore?.Set(nameof(IsShared), value); }
        }
        /// <summary>The tasks in this task list. Read-only. Nullable.</summary>
        public List<TodoTask> Tasks {
            get { return BackingStore?.Get<List<TodoTask>>(nameof(Tasks)); }
            set { BackingStore?.Set(nameof(Tasks), value); }
        }
        /// <summary>Property indicating the list name if the given list is a well-known list. Possible values are: none, defaultList, flaggedEmails, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.WellknownListName? WellknownListName {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WellknownListName?>(nameof(WellknownListName)); }
            set { BackingStore?.Set(nameof(WellknownListName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TodoTaskList CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TodoTaskList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"isOwner", n => { IsOwner = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<TodoTask>(TodoTask.CreateFromDiscriminatorValue).ToList(); } },
                {"wellknownListName", n => { WellknownListName = n.GetEnumValue<WellknownListName>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("isOwner", IsOwner);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteCollectionOfObjectValues<TodoTask>("tasks", Tasks);
            writer.WriteEnumValue<WellknownListName>("wellknownListName", WellknownListName);
        }
    }
}
