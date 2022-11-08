using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RecommendLabelAction : InformationProtectionAction, IParsable {
        /// <summary>Actions to take if the label is accepted by the user.</summary>
        public List<InformationProtectionAction> Actions {
            get { return BackingStore?.Get<List<InformationProtectionAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
        /// <summary>The actionSource property</summary>
        public Microsoft.Graph.Beta.Models.ActionSource? ActionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionSource?>("actionSource"); }
            set { BackingStore?.Set("actionSource", value); }
        }
        /// <summary>The label that is being recommended.</summary>
        public LabelDetails Label {
            get { return BackingStore?.Get<LabelDetails>("label"); }
            set { BackingStore?.Set("label", value); }
        }
        /// <summary>The sensitive information type GUIDs that caused the recommendation to be given.</summary>
        public List<string> ResponsibleSensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
        /// <summary>
        /// Instantiates a new RecommendLabelAction and sets the default values.
        /// </summary>
        public RecommendLabelAction() : base() {
            OdataType = "#microsoft.graph.recommendLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RecommendLabelAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecommendLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<InformationProtectionAction>(InformationProtectionAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"actionSource", n => { ActionSource = n.GetEnumValue<ActionSource>(); } },
                {"label", n => { Label = n.GetObjectValue<LabelDetails>(LabelDetails.CreateFromDiscriminatorValue); } },
                {"responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
