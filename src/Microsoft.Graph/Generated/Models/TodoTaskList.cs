using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class TodoTaskList : Entity, IParsable {
        /// <summary>The name of the task list.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The collection of open extensions defined for the task list. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
        /// <summary>True if the user is owner of the given task list.</summary>
        public bool? IsOwner {
            get { return BackingStore?.Get<bool?>("isOwner"); }
            set { BackingStore?.Set("isOwner", value); }
        }
        /// <summary>True if the task list is shared with other users</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>("isShared"); }
            set { BackingStore?.Set("isShared", value); }
        }
        /// <summary>The tasks in this task list. Read-only. Nullable.</summary>
        public List<TodoTask> Tasks {
            get { return BackingStore?.Get<List<TodoTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
        /// <summary>The wellknownListName property</summary>
        public Microsoft.Graph.Beta.Models.WellknownListName? WellknownListName {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WellknownListName?>("wellknownListName"); }
            set { BackingStore?.Set("wellknownListName", value); }
        }
        /// <summary>
        /// Instantiates a new todoTaskList and sets the default values.
        /// </summary>
        public TodoTaskList() : base() {
            OdataType = "#microsoft.graph.todoTaskList";
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
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isOwner", n => { IsOwner = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<TodoTask>(TodoTask.CreateFromDiscriminatorValue)?.ToList(); } },
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
