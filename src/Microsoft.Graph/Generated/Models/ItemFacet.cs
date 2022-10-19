using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ItemFacet : Entity, IParsable {
        /// <summary>The audiences that are able to see the values contained within the associated entity. Possible values are: me, family, contacts, groupMembers, organization, federatedOrganizations, everyone, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.AllowedAudiences? AllowedAudiences {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AllowedAudiences?>("allowedAudiences"); }
            set { BackingStore?.Set("allowedAudiences", value); }
        }
        /// <summary>The createdBy property</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Contains inference detail if the entity is inferred by the creating or modifying application.</summary>
        public InferenceData Inference {
            get { return BackingStore?.Get<InferenceData>("inference"); }
            set { BackingStore?.Set("inference", value); }
        }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>("isSearchable"); }
            set { BackingStore?.Set("isSearchable", value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Where the values within an entity originated if synced from another service.</summary>
        public PersonDataSources Source {
            get { return BackingStore?.Get<PersonDataSources>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>
        /// Instantiates a new itemFacet and sets the default values.
        /// </summary>
        public ItemFacet() : base() {
            OdataType = "#microsoft.graph.itemFacet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemFacet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.educationalActivity" => new EducationalActivity(),
                "#microsoft.graph.itemAddress" => new ItemAddress(),
                "#microsoft.graph.itemEmail" => new ItemEmail(),
                "#microsoft.graph.itemPatent" => new ItemPatent(),
                "#microsoft.graph.itemPhone" => new ItemPhone(),
                "#microsoft.graph.itemPublication" => new ItemPublication(),
                "#microsoft.graph.languageProficiency" => new LanguageProficiency(),
                "#microsoft.graph.personAnnotation" => new PersonAnnotation(),
                "#microsoft.graph.personAnnualEvent" => new PersonAnnualEvent(),
                "#microsoft.graph.personAward" => new PersonAward(),
                "#microsoft.graph.personCertification" => new PersonCertification(),
                "#microsoft.graph.personInterest" => new PersonInterest(),
                "#microsoft.graph.personName" => new PersonName(),
                "#microsoft.graph.personResponsibility" => new PersonResponsibility(),
                "#microsoft.graph.personWebsite" => new PersonWebsite(),
                "#microsoft.graph.projectParticipation" => new ProjectParticipation(),
                "#microsoft.graph.skillProficiency" => new SkillProficiency(),
                "#microsoft.graph.userAccountInformation" => new UserAccountInformation(),
                "#microsoft.graph.webAccount" => new WebAccount(),
                "#microsoft.graph.workPosition" => new WorkPosition(),
                _ => new ItemFacet(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAudiences", n => { AllowedAudiences = n.GetEnumValue<AllowedAudiences>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inference", n => { Inference = n.GetObjectValue<InferenceData>(InferenceData.CreateFromDiscriminatorValue); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"source", n => { Source = n.GetObjectValue<PersonDataSources>(PersonDataSources.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AllowedAudiences>("allowedAudiences", AllowedAudiences);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<InferenceData>("inference", Inference);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<PersonDataSources>("source", Source);
        }
    }
}
