using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class OutlookUser : Entity, IParsable {
        /// <summary>A list of categories defined for the user.</summary>
        public List<OutlookCategory> MasterCategories {
            get { return BackingStore?.Get<List<OutlookCategory>>(nameof(MasterCategories)); }
            set { BackingStore?.Set(nameof(MasterCategories), value); }
        }
        /// <summary>The taskFolders property</summary>
        public List<OutlookTaskFolder> TaskFolders {
            get { return BackingStore?.Get<List<OutlookTaskFolder>>(nameof(TaskFolders)); }
            set { BackingStore?.Set(nameof(TaskFolders), value); }
        }
        /// <summary>The taskGroups property</summary>
        public List<OutlookTaskGroup> TaskGroups {
            get { return BackingStore?.Get<List<OutlookTaskGroup>>(nameof(TaskGroups)); }
            set { BackingStore?.Set(nameof(TaskGroups), value); }
        }
        /// <summary>The tasks property</summary>
        public List<OutlookTask> Tasks {
            get { return BackingStore?.Get<List<OutlookTask>>(nameof(Tasks)); }
            set { BackingStore?.Set(nameof(Tasks), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OutlookUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"masterCategories", n => { MasterCategories = n.GetCollectionOfObjectValues<OutlookCategory>(OutlookCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"taskFolders", n => { TaskFolders = n.GetCollectionOfObjectValues<OutlookTaskFolder>(OutlookTaskFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"taskGroups", n => { TaskGroups = n.GetCollectionOfObjectValues<OutlookTaskGroup>(OutlookTaskGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<OutlookTask>(OutlookTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OutlookCategory>("masterCategories", MasterCategories);
            writer.WriteCollectionOfObjectValues<OutlookTaskFolder>("taskFolders", TaskFolders);
            writer.WriteCollectionOfObjectValues<OutlookTaskGroup>("taskGroups", TaskGroups);
            writer.WriteCollectionOfObjectValues<OutlookTask>("tasks", Tasks);
        }
    }
}
