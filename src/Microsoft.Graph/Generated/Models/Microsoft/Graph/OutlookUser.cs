using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class OutlookUser : Entity, IParsable {
        /// <summary>A list of categories defined for the user.</summary>
        public List<OutlookCategory> MasterCategories { get; set; }
        public List<OutlookTaskFolder> TaskFolders { get; set; }
        public List<OutlookTaskGroup> TaskGroups { get; set; }
        public List<OutlookTask> Tasks { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"masterCategories", (o,n) => { (o as OutlookUser).MasterCategories = n.GetCollectionOfObjectValues<OutlookCategory>().ToList(); } },
                {"taskFolders", (o,n) => { (o as OutlookUser).TaskFolders = n.GetCollectionOfObjectValues<OutlookTaskFolder>().ToList(); } },
                {"taskGroups", (o,n) => { (o as OutlookUser).TaskGroups = n.GetCollectionOfObjectValues<OutlookTaskGroup>().ToList(); } },
                {"tasks", (o,n) => { (o as OutlookUser).Tasks = n.GetCollectionOfObjectValues<OutlookTask>().ToList(); } },
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
