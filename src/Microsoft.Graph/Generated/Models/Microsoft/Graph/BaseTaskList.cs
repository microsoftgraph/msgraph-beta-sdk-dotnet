using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class BaseTaskList : Entity, IParsable {
        /// <summary>The name of the task list.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of open extensions defined for the task list. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The tasks in this task list. Read-only. Nullable.</summary>
        public List<BaseTask> Tasks { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as BaseTaskList).DisplayName = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as BaseTaskList).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"tasks", (o,n) => { (o as BaseTaskList).Tasks = n.GetCollectionOfObjectValues<BaseTask>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<BaseTask>("tasks", Tasks);
        }
    }
}
