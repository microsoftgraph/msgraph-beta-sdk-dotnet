using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class OutlookTaskGroup : Entity, IParsable {
        /// <summary>The version of the task group.</summary>
        public string ChangeKey {
            get { return BackingStore?.Get<string>(nameof(ChangeKey)); }
            set { BackingStore?.Set(nameof(ChangeKey), value); }
        }
        /// <summary>The unique GUID identifier for the task group.</summary>
        public string GroupKey {
            get { return BackingStore?.Get<string>(nameof(GroupKey)); }
            set { BackingStore?.Set(nameof(GroupKey), value); }
        }
        /// <summary>True if the task group is the default task group.</summary>
        public bool? IsDefaultGroup {
            get { return BackingStore?.Get<bool?>(nameof(IsDefaultGroup)); }
            set { BackingStore?.Set(nameof(IsDefaultGroup), value); }
        }
        /// <summary>The name of the task group.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The collection of task folders in the task group. Read-only. Nullable.</summary>
        public List<OutlookTaskFolder> TaskFolders {
            get { return BackingStore?.Get<List<OutlookTaskFolder>>(nameof(TaskFolders)); }
            set { BackingStore?.Set(nameof(TaskFolders), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OutlookTaskGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookTaskGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"changeKey", n => { ChangeKey = n.GetStringValue(); } },
                {"groupKey", n => { GroupKey = n.GetStringValue(); } },
                {"isDefaultGroup", n => { IsDefaultGroup = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"taskFolders", n => { TaskFolders = n.GetCollectionOfObjectValues<OutlookTaskFolder>(OutlookTaskFolder.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteStringValue("groupKey", GroupKey);
            writer.WriteBoolValue("isDefaultGroup", IsDefaultGroup);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<OutlookTaskFolder>("taskFolders", TaskFolders);
        }
    }
}
