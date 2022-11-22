using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerExternalTaskSource : PlannerTaskCreation, IParsable {
        /// <summary>The contextScenarioId property</summary>
        public string ContextScenarioId {
            get { return BackingStore?.Get<string>("contextScenarioId"); }
            set { BackingStore?.Set("contextScenarioId", value); }
        }
        /// <summary>The displayLinkType property</summary>
        public PlannerExternalTaskSourceDisplayType? DisplayLinkType {
            get { return BackingStore?.Get<PlannerExternalTaskSourceDisplayType?>("displayLinkType"); }
            set { BackingStore?.Set("displayLinkType", value); }
        }
        /// <summary>The displayNameSegments property</summary>
        public List<string> DisplayNameSegments {
            get { return BackingStore?.Get<List<string>>("displayNameSegments"); }
            set { BackingStore?.Set("displayNameSegments", value); }
        }
        /// <summary>The externalContextId property</summary>
        public string ExternalContextId {
            get { return BackingStore?.Get<string>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
        /// <summary>The externalObjectId property</summary>
        public string ExternalObjectId {
            get { return BackingStore?.Get<string>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
        /// <summary>The externalObjectVersion property</summary>
        public string ExternalObjectVersion {
            get { return BackingStore?.Get<string>("externalObjectVersion"); }
            set { BackingStore?.Set("externalObjectVersion", value); }
        }
        /// <summary>The webUrl property</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
        /// <summary>
        /// Instantiates a new PlannerExternalTaskSource and sets the default values.
        /// </summary>
        public PlannerExternalTaskSource() : base() {
            OdataType = "#microsoft.graph.plannerExternalTaskSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerExternalTaskSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerExternalTaskSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contextScenarioId", n => { ContextScenarioId = n.GetStringValue(); } },
                {"displayLinkType", n => { DisplayLinkType = n.GetEnumValue<PlannerExternalTaskSourceDisplayType>(); } },
                {"displayNameSegments", n => { DisplayNameSegments = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"externalContextId", n => { ExternalContextId = n.GetStringValue(); } },
                {"externalObjectId", n => { ExternalObjectId = n.GetStringValue(); } },
                {"externalObjectVersion", n => { ExternalObjectVersion = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteEnumValue<PlannerExternalTaskSourceDisplayType>("displayLinkType", DisplayLinkType);
            writer.WriteCollectionOfPrimitiveValues<string>("displayNameSegments", DisplayNameSegments);
            writer.WriteStringValue("externalContextId", ExternalContextId);
            writer.WriteStringValue("externalObjectId", ExternalObjectId);
            writer.WriteStringValue("externalObjectVersion", ExternalObjectVersion);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
