using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class WorkbookTableSort : Entity, IParsable {
        /// <summary>Represents the current conditions used to last sort the table. Read-only.</summary>
        public List<WorkbookSortField> Fields {
            get { return BackingStore?.Get<List<WorkbookSortField>>(nameof(Fields)); }
            set { BackingStore?.Set(nameof(Fields), value); }
        }
        /// <summary>Represents whether the casing impacted the last sort of the table. Read-only.</summary>
        public bool? MatchCase {
            get { return BackingStore?.Get<bool?>(nameof(MatchCase)); }
            set { BackingStore?.Set(nameof(MatchCase), value); }
        }
        /// <summary>Represents Chinese character ordering method last used to sort the table. Possible values are: PinYin, StrokeCount. Read-only.</summary>
        public string Method {
            get { return BackingStore?.Get<string>(nameof(Method)); }
            set { BackingStore?.Set(nameof(Method), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookTableSort CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTableSort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fields", n => { Fields = n.GetCollectionOfObjectValues<WorkbookSortField>(WorkbookSortField.CreateFromDiscriminatorValue).ToList(); } },
                {"matchCase", n => { MatchCase = n.GetBoolValue(); } },
                {"method", n => { Method = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
        }
    }
}
