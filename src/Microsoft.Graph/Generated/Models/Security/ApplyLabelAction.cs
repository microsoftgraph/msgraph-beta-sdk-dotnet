using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ApplyLabelAction : InformationProtectionAction, IParsable {
        /// <summary>The actions property</summary>
        public List<InformationProtectionAction> Actions {
            get { return BackingStore?.Get<List<InformationProtectionAction>>(nameof(Actions)); }
            set { BackingStore?.Set(nameof(Actions), value); }
        }
        /// <summary>The actionSource property</summary>
        public Microsoft.Graph.Beta.Models.Security.ActionSource? ActionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ActionSource?>(nameof(ActionSource)); }
            set { BackingStore?.Set(nameof(ActionSource), value); }
        }
        /// <summary>The responsibleSensitiveTypeIds property</summary>
        public List<string> ResponsibleSensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>(nameof(ResponsibleSensitiveTypeIds)); }
            set { BackingStore?.Set(nameof(ResponsibleSensitiveTypeIds), value); }
        }
        /// <summary>The sensitivityLabelId property</summary>
        public string SensitivityLabelId {
            get { return BackingStore?.Get<string>(nameof(SensitivityLabelId)); }
            set { BackingStore?.Set(nameof(SensitivityLabelId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApplyLabelAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<InformationProtectionAction>(InformationProtectionAction.CreateFromDiscriminatorValue).ToList(); } },
                {"actionSource", n => { ActionSource = n.GetEnumValue<ActionSource>(); } },
                {"responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sensitivityLabelId", n => { SensitivityLabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<InformationProtectionAction>("actions", Actions);
            writer.WriteEnumValue<ActionSource>("actionSource", ActionSource);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
        }
    }
}
