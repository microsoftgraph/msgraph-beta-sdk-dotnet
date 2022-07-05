using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class WorkbookNamedItem : Entity, IParsable {
        /// <summary>Represents the comment associated with this name.</summary>
        public string Comment {
            get { return BackingStore?.Get<string>(nameof(Comment)); }
            set { BackingStore?.Set(nameof(Comment), value); }
        }
        /// <summary>The name of the object. Read-only.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Indicates whether the name is scoped to the workbook or to a specific worksheet. Read-only.</summary>
        public string Scope {
            get { return BackingStore?.Get<string>(nameof(Scope)); }
            set { BackingStore?.Set(nameof(Scope), value); }
        }
        /// <summary>Indicates what type of reference is associated with the name. Possible values are: String, Integer, Double, Boolean, Range. Read-only.</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>Represents the formula that the name is defined to refer to. E.g. =Sheet14!$B$2:$H$12, =4.75, etc. Read-only.</summary>
        public Json Value {
            get { return BackingStore?.Get<Json>(nameof(Value)); }
            set { BackingStore?.Set(nameof(Value), value); }
        }
        /// <summary>Specifies whether the object is visible or not.</summary>
        public bool? Visible {
            get { return BackingStore?.Get<bool?>(nameof(Visible)); }
            set { BackingStore?.Set(nameof(Visible), value); }
        }
        /// <summary>Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.</summary>
        public WorkbookWorksheet Worksheet {
            get { return BackingStore?.Get<WorkbookWorksheet>(nameof(Worksheet)); }
            set { BackingStore?.Set(nameof(Worksheet), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookNamedItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookNamedItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"value", n => { Value = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"visible", n => { Visible = n.GetBoolValue(); } },
                {"worksheet", n => { Worksheet = n.GetObjectValue<WorkbookWorksheet>(WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<Json>("value", Value);
            writer.WriteBoolValue("visible", Visible);
            writer.WriteObjectValue<WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
