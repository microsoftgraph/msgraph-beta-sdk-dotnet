using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class OutlookUser : Entity, IParsable {
        /// <summary>A list of categories defined for the user.</summary>
        public List<OutlookCategory> MasterCategories { get; set; }
        public List<OutlookTaskFolder> TaskFolders { get; set; }
        public List<OutlookTaskGroup> TaskGroups { get; set; }
        public List<OutlookTask> Tasks { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"masterCategories", (o,n) => { (o as OutlookUser).MasterCategories = n.GetCollectionOfObjectValues<OutlookCategory>(OutlookCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"taskFolders", (o,n) => { (o as OutlookUser).TaskFolders = n.GetCollectionOfObjectValues<OutlookTaskFolder>(OutlookTaskFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"taskGroups", (o,n) => { (o as OutlookUser).TaskGroups = n.GetCollectionOfObjectValues<OutlookTaskGroup>(OutlookTaskGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"tasks", (o,n) => { (o as OutlookUser).Tasks = n.GetCollectionOfObjectValues<OutlookTask>(OutlookTask.CreateFromDiscriminatorValue).ToList(); } },
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
