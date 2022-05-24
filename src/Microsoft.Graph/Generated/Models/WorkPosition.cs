using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class WorkPosition : ItemFacet, IParsable {
        /// <summary>Categories that the user has associated with this position.</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>(nameof(Categories)); }
            set { BackingStore?.Set(nameof(Categories), value); }
        }
        /// <summary>Colleagues that are associated with this position.</summary>
        public List<RelatedPerson> Colleagues {
            get { return BackingStore?.Get<List<RelatedPerson>>(nameof(Colleagues)); }
            set { BackingStore?.Set(nameof(Colleagues), value); }
        }
        /// <summary>The detail property</summary>
        public PositionDetail Detail {
            get { return BackingStore?.Get<PositionDetail>(nameof(Detail)); }
            set { BackingStore?.Set(nameof(Detail), value); }
        }
        /// <summary>Denotes whether or not the position is current.</summary>
        public bool? IsCurrent {
            get { return BackingStore?.Get<bool?>(nameof(IsCurrent)); }
            set { BackingStore?.Set(nameof(IsCurrent), value); }
        }
        /// <summary>Contains detail of the user&apos;s manager in this position.</summary>
        public RelatedPerson Manager {
            get { return BackingStore?.Get<RelatedPerson>(nameof(Manager)); }
            set { BackingStore?.Set(nameof(Manager), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkPosition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkPosition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"colleagues", n => { Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue).ToList(); } },
                {"detail", n => { Detail = n.GetObjectValue<PositionDetail>(PositionDetail.CreateFromDiscriminatorValue); } },
                {"isCurrent", n => { IsCurrent = n.GetBoolValue(); } },
                {"manager", n => { Manager = n.GetObjectValue<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<RelatedPerson>("colleagues", Colleagues);
            writer.WriteObjectValue<PositionDetail>("detail", Detail);
            writer.WriteBoolValue("isCurrent", IsCurrent);
            writer.WriteObjectValue<RelatedPerson>("manager", Manager);
        }
    }
}
