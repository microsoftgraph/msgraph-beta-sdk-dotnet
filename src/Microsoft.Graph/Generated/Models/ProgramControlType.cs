using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProgramControlType : Entity, IParsable {
        /// <summary>The controlTypeGroupId property</summary>
        public string ControlTypeGroupId {
            get { return BackingStore?.Get<string>("controlTypeGroupId"); }
            set { BackingStore?.Set("controlTypeGroupId", value); }
        }
        /// <summary>The name of the program control type</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>
        /// Instantiates a new ProgramControlType and sets the default values.
        /// </summary>
        public ProgramControlType() : base() {
            OdataType = "#microsoft.graph.programControlType";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProgramControlType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProgramControlType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"controlTypeGroupId", n => { ControlTypeGroupId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("controlTypeGroupId", ControlTypeGroupId);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
