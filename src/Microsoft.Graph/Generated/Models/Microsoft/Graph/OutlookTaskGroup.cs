using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class OutlookTaskGroup : Entity, IParsable {
        /// <summary>The version of the task group.</summary>
        public string ChangeKey { get; set; }
        /// <summary>The unique GUID identifier for the task group.</summary>
        public string GroupKey { get; set; }
        /// <summary>True if the task group is the default task group.</summary>
        public bool? IsDefaultGroup { get; set; }
        /// <summary>The name of the task group.</summary>
        public string Name { get; set; }
        /// <summary>The collection of task folders in the task group. Read-only. Nullable.</summary>
        public List<OutlookTaskFolder> TaskFolders { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"changeKey", (o,n) => { (o as OutlookTaskGroup).ChangeKey = n.GetStringValue(); } },
                {"groupKey", (o,n) => { (o as OutlookTaskGroup).GroupKey = n.GetStringValue(); } },
                {"isDefaultGroup", (o,n) => { (o as OutlookTaskGroup).IsDefaultGroup = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as OutlookTaskGroup).Name = n.GetStringValue(); } },
                {"taskFolders", (o,n) => { (o as OutlookTaskGroup).TaskFolders = n.GetCollectionOfObjectValues<OutlookTaskFolder>(OutlookTaskFolder.CreateFromDiscriminatorValue).ToList(); } },
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
