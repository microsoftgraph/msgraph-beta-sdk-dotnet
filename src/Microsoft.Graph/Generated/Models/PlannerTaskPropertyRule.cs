using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskPropertyRule : PlannerPropertyRule, IParsable {
        /// <summary>The appliedCategories property</summary>
        public PlannerFieldRules AppliedCategories {
            get { return BackingStore?.Get<PlannerFieldRules>("appliedCategories"); }
            set { BackingStore?.Set("appliedCategories", value); }
        }
        /// <summary>The assignments property</summary>
        public PlannerFieldRules Assignments {
            get { return BackingStore?.Get<PlannerFieldRules>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The checkLists property</summary>
        public PlannerFieldRules CheckLists {
            get { return BackingStore?.Get<PlannerFieldRules>("checkLists"); }
            set { BackingStore?.Set("checkLists", value); }
        }
        /// <summary>The delete property</summary>
        public List<string> Delete {
            get { return BackingStore?.Get<List<string>>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
        /// <summary>The dueDate property</summary>
        public List<string> DueDate {
            get { return BackingStore?.Get<List<string>>("dueDate"); }
            set { BackingStore?.Set("dueDate", value); }
        }
        /// <summary>The move property</summary>
        public List<string> Move {
            get { return BackingStore?.Get<List<string>>("move"); }
            set { BackingStore?.Set("move", value); }
        }
        /// <summary>The notes property</summary>
        public List<string> Notes {
            get { return BackingStore?.Get<List<string>>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
        /// <summary>The order property</summary>
        public List<string> Order {
            get { return BackingStore?.Get<List<string>>("order"); }
            set { BackingStore?.Set("order", value); }
        }
        /// <summary>The percentComplete property</summary>
        public List<string> PercentComplete {
            get { return BackingStore?.Get<List<string>>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
        /// <summary>The previewType property</summary>
        public List<string> PreviewType {
            get { return BackingStore?.Get<List<string>>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
        /// <summary>The priority property</summary>
        public List<string> Priority {
            get { return BackingStore?.Get<List<string>>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The references property</summary>
        public PlannerFieldRules References {
            get { return BackingStore?.Get<PlannerFieldRules>("references"); }
            set { BackingStore?.Set("references", value); }
        }
        /// <summary>The startDate property</summary>
        public List<string> StartDate {
            get { return BackingStore?.Get<List<string>>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
        /// <summary>The title property</summary>
        public List<string> Title {
            get { return BackingStore?.Get<List<string>>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>
        /// Instantiates a new PlannerTaskPropertyRule and sets the default values.
        /// </summary>
        public PlannerTaskPropertyRule() : base() {
            OdataType = "#microsoft.graph.plannerTaskPropertyRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTaskPropertyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskPropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliedCategories", n => { AppliedCategories = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"assignments", n => { Assignments = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"checkLists", n => { CheckLists = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"delete", n => { Delete = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"dueDate", n => { DueDate = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"move", n => { Move = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notes", n => { Notes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"order", n => { Order = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"percentComplete", n => { PercentComplete = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"previewType", n => { PreviewType = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"priority", n => { Priority = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"references", n => { References = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"startDate", n => { StartDate = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"title", n => { Title = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerFieldRules>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<PlannerFieldRules>("assignments", Assignments);
            writer.WriteObjectValue<PlannerFieldRules>("checkLists", CheckLists);
            writer.WriteCollectionOfPrimitiveValues<string>("delete", Delete);
            writer.WriteCollectionOfPrimitiveValues<string>("dueDate", DueDate);
            writer.WriteCollectionOfPrimitiveValues<string>("move", Move);
            writer.WriteCollectionOfPrimitiveValues<string>("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("order", Order);
            writer.WriteCollectionOfPrimitiveValues<string>("percentComplete", PercentComplete);
            writer.WriteCollectionOfPrimitiveValues<string>("previewType", PreviewType);
            writer.WriteCollectionOfPrimitiveValues<string>("priority", Priority);
            writer.WriteObjectValue<PlannerFieldRules>("references", References);
            writer.WriteCollectionOfPrimitiveValues<string>("startDate", StartDate);
            writer.WriteCollectionOfPrimitiveValues<string>("title", Title);
        }
    }
}
