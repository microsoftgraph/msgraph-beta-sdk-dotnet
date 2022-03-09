using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class WorkPosition : ItemFacet, IParsable {
        /// <summary>Categories that the user has associated with this position.</summary>
        public List<string> Categories { get; set; }
        /// <summary>Colleagues that are associated with this position.</summary>
        public List<RelatedPerson> Colleagues { get; set; }
        public PositionDetail Detail { get; set; }
        /// <summary>Denotes whether or not the position is current.</summary>
        public bool? IsCurrent { get; set; }
        /// <summary>Contains detail of the user's manager in this position.</summary>
        public RelatedPerson Manager { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as WorkPosition).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"colleagues", (o,n) => { (o as WorkPosition).Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue).ToList(); } },
                {"detail", (o,n) => { (o as WorkPosition).Detail = n.GetObjectValue<PositionDetail>(PositionDetail.CreateFromDiscriminatorValue); } },
                {"isCurrent", (o,n) => { (o as WorkPosition).IsCurrent = n.GetBoolValue(); } },
                {"manager", (o,n) => { (o as WorkPosition).Manager = n.GetObjectValue<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue); } },
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
