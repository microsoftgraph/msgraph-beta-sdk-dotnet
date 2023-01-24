using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OutlookTaskGroup : Entity, IParsable {
        /// <summary>The version of the task group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey {
            get { return BackingStore?.Get<string?>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#nullable restore
#else
        public string ChangeKey {
            get { return BackingStore?.Get<string>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#endif
        /// <summary>The unique GUID identifier for the task group.</summary>
        public Guid? GroupKey {
            get { return BackingStore?.Get<Guid?>("groupKey"); }
            set { BackingStore?.Set("groupKey", value); }
        }
        /// <summary>True if the task group is the default task group.</summary>
        public bool? IsDefaultGroup {
            get { return BackingStore?.Get<bool?>("isDefaultGroup"); }
            set { BackingStore?.Set("isDefaultGroup", value); }
        }
        /// <summary>The name of the task group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The collection of task folders in the task group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OutlookTaskFolder>? TaskFolders {
            get { return BackingStore?.Get<List<OutlookTaskFolder>?>("taskFolders"); }
            set { BackingStore?.Set("taskFolders", value); }
        }
#nullable restore
#else
        public List<OutlookTaskFolder> TaskFolders {
            get { return BackingStore?.Get<List<OutlookTaskFolder>>("taskFolders"); }
            set { BackingStore?.Set("taskFolders", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"groupKey", n => { GroupKey = n.GetGuidValue(); } },
                {"isDefaultGroup", n => { IsDefaultGroup = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"taskFolders", n => { TaskFolders = n.GetCollectionOfObjectValues<OutlookTaskFolder>(OutlookTaskFolder.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteGuidValue("groupKey", GroupKey);
            writer.WriteBoolValue("isDefaultGroup", IsDefaultGroup);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<OutlookTaskFolder>("taskFolders", TaskFolders);
        }
    }
}
