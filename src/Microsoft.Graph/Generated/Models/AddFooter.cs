// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AddFooter : MarkContent, IParsable 
    {
        /// <summary>The alignment property</summary>
        public Microsoft.Graph.Beta.Models.Alignment? Alignment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Alignment?>("alignment"); }
            set { BackingStore?.Set("alignment", value); }
        }
        /// <summary>The margin property</summary>
        public int? Margin {
            get { return BackingStore?.Get<int?>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="AddFooter"/> and sets the default values.
        /// </summary>
        public AddFooter() : base()
        {
            OdataType = "#microsoft.graph.addFooter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AddFooter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AddFooter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddFooter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"alignment", n => { Alignment = n.GetEnumValue<Alignment>(); } },
                {"margin", n => { Margin = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Alignment>("alignment", Alignment);
            writer.WriteIntValue("margin", Margin);
        }
    }
}
