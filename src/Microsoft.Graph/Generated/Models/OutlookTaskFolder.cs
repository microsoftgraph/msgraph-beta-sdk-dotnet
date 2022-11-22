using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class OutlookTaskFolder : Entity, IParsable {
        /// <summary>The version of the task folder.</summary>
        public string ChangeKey {
            get { return BackingStore?.Get<string>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
        /// <summary>True if the folder is the default task folder.</summary>
        public bool? IsDefaultFolder {
            get { return BackingStore?.Get<bool?>("isDefaultFolder"); }
            set { BackingStore?.Set("isDefaultFolder", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the task folder. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
        /// <summary>The name of the task folder.</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The unique GUID identifier for the task folder&apos;s parent group.</summary>
        public string ParentGroupKey {
            get { return BackingStore?.Get<string>("parentGroupKey"); }
            set { BackingStore?.Set("parentGroupKey", value); }
        }
        /// <summary>The collection of single-value extended properties defined for the task folder. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
        /// <summary>The tasks in this task folder. Read-only. Nullable.</summary>
        public List<OutlookTask> Tasks {
            get { return BackingStore?.Get<List<OutlookTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OutlookTaskFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookTaskFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"changeKey", n => { ChangeKey = n.GetStringValue(); } },
                {"isDefaultFolder", n => { IsDefaultFolder = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parentGroupKey", n => { ParentGroupKey = n.GetStringValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<OutlookTask>(OutlookTask.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteBoolValue("isDefaultFolder", IsDefaultFolder);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentGroupKey", ParentGroupKey);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<OutlookTask>("tasks", Tasks);
        }
    }
}
