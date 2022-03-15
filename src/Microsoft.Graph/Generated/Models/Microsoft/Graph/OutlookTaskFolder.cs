using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class OutlookTaskFolder : Entity, IParsable {
        /// <summary>The version of the task folder.</summary>
        public string ChangeKey { get; set; }
        /// <summary>True if the folder is the default task folder.</summary>
        public bool? IsDefaultFolder { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the task folder. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The name of the task folder.</summary>
        public string Name { get; set; }
        /// <summary>The unique GUID identifier for the task folder's parent group.</summary>
        public string ParentGroupKey { get; set; }
        /// <summary>The collection of single-value extended properties defined for the task folder. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The tasks in this task folder. Read-only. Nullable.</summary>
        public List<OutlookTask> Tasks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OutlookTaskFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookTaskFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"changeKey", (o,n) => { (o as OutlookTaskFolder).ChangeKey = n.GetStringValue(); } },
                {"isDefaultFolder", (o,n) => { (o as OutlookTaskFolder).IsDefaultFolder = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as OutlookTaskFolder).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as OutlookTaskFolder).Name = n.GetStringValue(); } },
                {"parentGroupKey", (o,n) => { (o as OutlookTaskFolder).ParentGroupKey = n.GetStringValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as OutlookTaskFolder).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"tasks", (o,n) => { (o as OutlookTaskFolder).Tasks = n.GetCollectionOfObjectValues<OutlookTask>(OutlookTask.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteBoolValue("isDefaultFolder", IsDefaultFolder);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentGroupKey", ParentGroupKey);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<OutlookTask>("tasks", Tasks);
        }
    }
}
