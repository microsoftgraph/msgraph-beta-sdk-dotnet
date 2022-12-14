using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskCreation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies what kind of creation source the task is created with. The possible values are: external, publication and unknownFutureValue.</summary>
        public PlannerCreationSourceKind? CreationSourceKind {
            get { return BackingStore?.Get<PlannerCreationSourceKind?>("creationSourceKind"); }
            set { BackingStore?.Set("creationSourceKind", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Information about the publication process that created this task. This field is deprecated and clients should move to using the new inheritance model.</summary>
        public PlannerTeamsPublicationInfo TeamsPublicationInfo {
            get { return BackingStore?.Get<PlannerTeamsPublicationInfo>("teamsPublicationInfo"); }
            set { BackingStore?.Set("teamsPublicationInfo", value); }
        }
        /// <summary>
        /// Instantiates a new plannerTaskCreation and sets the default values.
        /// </summary>
        public PlannerTaskCreation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerTaskCreation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.plannerExternalTaskSource" => new PlannerExternalTaskSource(),
                "#microsoft.graph.plannerTeamsPublicationInfo" => new PlannerTeamsPublicationInfo(),
                _ => new PlannerTaskCreation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"creationSourceKind", n => { CreationSourceKind = n.GetEnumValue<PlannerCreationSourceKind>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"teamsPublicationInfo", n => { TeamsPublicationInfo = n.GetObjectValue<PlannerTeamsPublicationInfo>(PlannerTeamsPublicationInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PlannerCreationSourceKind>("creationSourceKind", CreationSourceKind);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PlannerTeamsPublicationInfo>("teamsPublicationInfo", TeamsPublicationInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
