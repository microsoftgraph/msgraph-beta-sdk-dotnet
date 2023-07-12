using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerExternalPlanSource : PlannerPlanCreation, IParsable {
        /// <summary>Nullable. An identifier for the scenario associated with this external source. This should be in reverse DNS format. For example, Contoso company owned application for customer support would have a value like &apos;com.constoso.customerSupport&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextScenarioId {
            get { return BackingStore?.Get<string?>("contextScenarioId"); }
            set { BackingStore?.Set("contextScenarioId", value); }
        }
#nullable restore
#else
        public string ContextScenarioId {
            get { return BackingStore?.Get<string>("contextScenarioId"); }
            set { BackingStore?.Set("contextScenarioId", value); }
        }
#endif
        /// <summary>Nullable. The id of the external entity&apos;s containing entity or context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalContextId {
            get { return BackingStore?.Get<string?>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
#nullable restore
#else
        public string ExternalContextId {
            get { return BackingStore?.Get<string>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
#endif
        /// <summary>Nullable. The id of the entity that an external service associates with a plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalObjectId {
            get { return BackingStore?.Get<string?>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
#nullable restore
#else
        public string ExternalObjectId {
            get { return BackingStore?.Get<string>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new plannerExternalPlanSource and sets the default values.
        /// </summary>
        public PlannerExternalPlanSource() : base() {
            OdataType = "#microsoft.graph.plannerExternalPlanSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerExternalPlanSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerExternalPlanSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contextScenarioId", n => { ContextScenarioId = n.GetStringValue(); } },
                {"externalContextId", n => { ExternalContextId = n.GetStringValue(); } },
                {"externalObjectId", n => { ExternalObjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contextScenarioId", ContextScenarioId);
            writer.WriteStringValue("externalContextId", ExternalContextId);
            writer.WriteStringValue("externalObjectId", ExternalObjectId);
        }
    }
}
