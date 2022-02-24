using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Tasks : Entity, IParsable {
        /// <summary>All tasks in the users mailbox.</summary>
        public List<BaseTask> Alltasks { get; set; }
        /// <summary>The task lists in the users mailbox.</summary>
        public List<BaseTaskList> Lists { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"alltasks", (o,n) => { (o as Tasks).Alltasks = n.GetCollectionOfObjectValues<BaseTask>().ToList(); } },
                {"lists", (o,n) => { (o as Tasks).Lists = n.GetCollectionOfObjectValues<BaseTaskList>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<BaseTask>("alltasks", Alltasks);
            writer.WriteCollectionOfObjectValues<BaseTaskList>("lists", Lists);
        }
    }
}
