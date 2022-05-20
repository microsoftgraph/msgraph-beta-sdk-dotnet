using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class ItemFacet : Entity, IParsable {
        /// <summary>The audiences that are able to see the values contained within the associated entity. Possible values are: me, family, contacts, groupMembers, organization, federatedOrganizations, everyone, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.AllowedAudiences? AllowedAudiences {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AllowedAudiences?>(nameof(AllowedAudiences)); }
            set { BackingStore?.Set(nameof(AllowedAudiences), value); }
        }
        /// <summary>The createdBy property</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Contains inference detail if the entity is inferred by the creating or modifying application.</summary>
        public InferenceData Inference {
            get { return BackingStore?.Get<InferenceData>(nameof(Inference)); }
            set { BackingStore?.Set(nameof(Inference), value); }
        }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>(nameof(IsSearchable)); }
            set { BackingStore?.Set(nameof(IsSearchable), value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Where the values within an entity originated if synced from another service.</summary>
        public PersonDataSources Source {
            get { return BackingStore?.Get<PersonDataSources>(nameof(Source)); }
            set { BackingStore?.Set(nameof(Source), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemFacet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.itemFacet" => new ItemFacet(),
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
