using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class HorizontalSection : Entity, IParsable {
        /// <summary>The set of vertical columns in this section.</summary>
        public List<HorizontalSectionColumn> Columns {
            get { return BackingStore?.Get<List<HorizontalSectionColumn>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
        /// <summary>Enumeration value that indicates the emphasis of the section background. The possible values are: none, netural, soft, strong, unknownFutureValue.</summary>
        public SectionEmphasisType? Emphasis {
            get { return BackingStore?.Get<SectionEmphasisType?>("emphasis"); }
            set { BackingStore?.Set("emphasis", value); }
        }
        /// <summary>Layout type of the section. The possible values are: none, oneColumn, twoColumns, threeColumns, oneThirdLeftColumn, oneThirdRightColumn, fullWidth, unknownFutureValue.</summary>
        public HorizontalSectionLayoutType? Layout {
            get { return BackingStore?.Get<HorizontalSectionLayoutType?>("layout"); }
            set { BackingStore?.Set("layout", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HorizontalSection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HorizontalSection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<HorizontalSectionColumn>(HorizontalSectionColumn.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emphasis", n => { Emphasis = n.GetEnumValue<SectionEmphasisType>(); } },
                {"layout", n => { Layout = n.GetEnumValue<HorizontalSectionLayoutType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<HorizontalSectionColumn>("columns", Columns);
            writer.WriteEnumValue<SectionEmphasisType>("emphasis", Emphasis);
            writer.WriteEnumValue<HorizontalSectionLayoutType>("layout", Layout);
        }
    }
}
