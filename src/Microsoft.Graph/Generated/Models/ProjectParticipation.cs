using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProjectParticipation : ItemFacet, IParsable {
        /// <summary>Contains categories a user has associated with the project (for example, digital transformation, oil rig).</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
        /// <summary>Contains detailed information about the client the project was for.</summary>
        public CompanyDetail Client {
            get { return BackingStore?.Get<CompanyDetail>("client"); }
            set { BackingStore?.Set("client", value); }
        }
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
        public List<string> CollaborationTags {
            get { return BackingStore?.Get<List<string>>("collaborationTags"); }
            set { BackingStore?.Set("collaborationTags", value); }
        }
        /// <summary>Lists people that also worked on the project.</summary>
        public List<RelatedPerson> Colleagues {
            get { return BackingStore?.Get<List<RelatedPerson>>("colleagues"); }
            set { BackingStore?.Set("colleagues", value); }
        }
        /// <summary>Contains detail about the user&apos;s role on the project.</summary>
        public PositionDetail Detail {
            get { return BackingStore?.Get<PositionDetail>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
        /// <summary>Contains a friendly name for the project.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The Person or people who sponsored the project.</summary>
        public List<RelatedPerson> Sponsors {
            get { return BackingStore?.Get<List<RelatedPerson>>("sponsors"); }
            set { BackingStore?.Set("sponsors", value); }
        }
        /// <summary>The thumbnailUrl property</summary>
        public string ThumbnailUrl {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
        /// <summary>
        /// Instantiates a new ProjectParticipation and sets the default values.
        /// </summary>
        public ProjectParticipation() : base() {
            OdataType = "#microsoft.graph.projectParticipation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProjectParticipation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectParticipation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"client", n => { Client = n.GetObjectValue<CompanyDetail>(CompanyDetail.CreateFromDiscriminatorValue); } },
                {"collaborationTags", n => { CollaborationTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"colleagues", n => { Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue).ToList(); } },
                {"detail", n => { Detail = n.GetObjectValue<PositionDetail>(PositionDetail.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"sponsors", n => { Sponsors = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue).ToList(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteObjectValue<CompanyDetail>("client", Client);
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteCollectionOfObjectValues<RelatedPerson>("colleagues", Colleagues);
            writer.WriteObjectValue<PositionDetail>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RelatedPerson>("sponsors", Sponsors);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
        }
    }
}
