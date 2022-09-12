using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WorkPosition : ItemFacet, IParsable {
        /// <summary>Categories that the user has associated with this position.</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
        /// <summary>Colleagues that are associated with this position.</summary>
        public List<RelatedPerson> Colleagues {
            get { return BackingStore?.Get<List<RelatedPerson>>("colleagues"); }
            set { BackingStore?.Set("colleagues", value); }
        }
        /// <summary>The detail property</summary>
        public PositionDetail Detail {
            get { return BackingStore?.Get<PositionDetail>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
        /// <summary>Denotes whether or not the position is current.</summary>
        public bool? IsCurrent {
            get { return BackingStore?.Get<bool?>("isCurrent"); }
            set { BackingStore?.Set("isCurrent", value); }
        }
        /// <summary>Contains detail of the user&apos;s manager in this position.</summary>
        public RelatedPerson Manager {
            get { return BackingStore?.Get<RelatedPerson>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
        /// <summary>
        /// Instantiates a new WorkPosition and sets the default values.
        /// </summary>
        public WorkPosition() : base() {
            OdataType = "#microsoft.graph.workPosition";
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
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"colleagues", n => { Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue)?.ToList(); } },
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
