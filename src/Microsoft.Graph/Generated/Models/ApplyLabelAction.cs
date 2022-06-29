using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ApplyLabelAction : InformationProtectionAction, IParsable {
        /// <summary>The collection of specific actions that should be taken by the consuming application to label the document. See  informationProtectionAction for the full list.</summary>
        public List<InformationProtectionAction> Actions {
            get { return BackingStore?.Get<List<InformationProtectionAction>>(nameof(Actions)); }
            set { BackingStore?.Set(nameof(Actions), value); }
        }
        /// <summary>Possible values are: manual, automatic, recommended, default.</summary>
        public Microsoft.Graph.Beta.Models.ActionSource? ActionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionSource?>(nameof(ActionSource)); }
            set { BackingStore?.Set(nameof(ActionSource), value); }
        }
        /// <summary>Object that describes the details of the label to apply.</summary>
        public LabelDetails Label {
            get { return BackingStore?.Get<LabelDetails>(nameof(Label)); }
            set { BackingStore?.Set(nameof(Label), value); }
        }
        /// <summary>If the label was the result of an automatic classification, supply the list of sensitive info type GUIDs that resulted in the returned label.</summary>
        public List<string> ResponsibleSensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>(nameof(ResponsibleSensitiveTypeIds)); }
            set { BackingStore?.Set(nameof(ResponsibleSensitiveTypeIds), value); }
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
                {"label", n => { Label = n.GetObjectValue<LabelDetails>(LabelDetails.CreateFromDiscriminatorValue); } },
                {"responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteObjectValue<LabelDetails>("label", Label);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
        }
    }
}
