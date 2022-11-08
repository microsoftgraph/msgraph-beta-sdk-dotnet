using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ApplyLabelAction : InformationProtectionAction, IParsable {
        /// <summary>The collection of actions that should be implemented by the caller.</summary>
        public List<InformationProtectionAction> Actions {
            get { return BackingStore?.Get<List<InformationProtectionAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
        /// <summary>The actionSource property</summary>
        public Microsoft.Graph.Beta.Models.Security.ActionSource? ActionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ActionSource?>("actionSource"); }
            set { BackingStore?.Set("actionSource", value); }
        }
        /// <summary>If the label was the result of an automatic classification, supply the list of sensitive info type GUIDs that resulted in the returned label.</summary>
        public List<string> ResponsibleSensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
        /// <summary>The sensitivityLabelId property</summary>
        public string SensitivityLabelId {
            get { return BackingStore?.Get<string>("sensitivityLabelId"); }
            set { BackingStore?.Set("sensitivityLabelId", value); }
        }
        /// <summary>
        /// Instantiates a new ApplyLabelAction and sets the default values.
        /// </summary>
        public ApplyLabelAction() : base() {
            OdataType = "#microsoft.graph.security.applyLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ApplyLabelAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<InformationProtectionAction>(InformationProtectionAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"actionSource", n => { ActionSource = n.GetEnumValue<ActionSource>(); } },
                {"responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sensitivityLabelId", n => { SensitivityLabelId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
        }
    }
}
