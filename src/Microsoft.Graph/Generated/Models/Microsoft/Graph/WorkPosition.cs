using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as WorkPosition).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"colleagues", (o,n) => { (o as WorkPosition).Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>().ToList(); } },
                {"detail", (o,n) => { (o as WorkPosition).Detail = n.GetObjectValue<PositionDetail>(); } },
                {"isCurrent", (o,n) => { (o as WorkPosition).IsCurrent = n.GetBoolValue(); } },
                {"manager", (o,n) => { (o as WorkPosition).Manager = n.GetObjectValue<RelatedPerson>(); } },
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
