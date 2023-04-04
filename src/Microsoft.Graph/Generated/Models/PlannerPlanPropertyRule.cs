using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerPlanPropertyRule : PlannerPropertyRule, IParsable {
        /// <summary>The buckets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Buckets {
            get { return BackingStore?.Get<List<string>?>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#nullable restore
#else
        public List<string> Buckets {
            get { return BackingStore?.Get<List<string>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#endif
        /// <summary>The categoryDescriptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? CategoryDescriptions {
            get { return BackingStore?.Get<PlannerFieldRules?>("categoryDescriptions"); }
            set { BackingStore?.Set("categoryDescriptions", value); }
        }
#nullable restore
#else
        public PlannerFieldRules CategoryDescriptions {
            get { return BackingStore?.Get<PlannerFieldRules>("categoryDescriptions"); }
            set { BackingStore?.Set("categoryDescriptions", value); }
        }
#endif
        /// <summary>The tasks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tasks {
            get { return BackingStore?.Get<List<string>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#nullable restore
#else
        public List<string> Tasks {
            get { return BackingStore?.Get<List<string>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? Title {
            get { return BackingStore?.Get<PlannerFieldRules?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public PlannerFieldRules Title {
            get { return BackingStore?.Get<PlannerFieldRules>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new PlannerPlanPropertyRule and sets the default values.
        /// </summary>
        public PlannerPlanPropertyRule() : base() {
            OdataType = "#microsoft.graph.plannerPlanPropertyRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerPlanPropertyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlanPropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buckets", n => { Buckets = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"categoryDescriptions", n => { CategoryDescriptions = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"tasks", n => { Tasks = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"title", n => { Title = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("buckets", Buckets);
            writer.WriteObjectValue<PlannerFieldRules>("categoryDescriptions", CategoryDescriptions);
            writer.WriteCollectionOfPrimitiveValues<string>("tasks", Tasks);
            writer.WriteObjectValue<PlannerFieldRules>("title", Title);
        }
    }
}
