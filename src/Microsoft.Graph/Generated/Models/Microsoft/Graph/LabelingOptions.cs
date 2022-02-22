using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class LabelingOptions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values are: standard, privileged, auto.</summary>
        public AssignmentMethod? AssignmentMethod { get; set; }
        /// <summary>The downgrade justification object that indicates if downgrade was justified and, if so, the reason.</summary>
        public DowngradeJustification DowngradeJustification { get; set; }
        /// <summary>Extended properties will be parsed and returned in the standard MIP labeled metadata format as part of the label information.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.KeyValuePair> ExtendedProperties { get; set; }
        /// <summary>The GUID of the label that should be applied to the information.</summary>
        public string LabelId { get; set; }
        /// <summary>
        /// Instantiates a new labelingOptions and sets the default values.
        /// </summary>
        public LabelingOptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentMethod", (o,n) => { (o as LabelingOptions).AssignmentMethod = n.GetEnumValue<AssignmentMethod>(); } },
                {"downgradeJustification", (o,n) => { (o as LabelingOptions).DowngradeJustification = n.GetObjectValue<DowngradeJustification>(); } },
                {"extendedProperties", (o,n) => { (o as LabelingOptions).ExtendedProperties = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.KeyValuePair>().ToList(); } },
                {"labelId", (o,n) => { (o as LabelingOptions).LabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteObjectValue<DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.KeyValuePair>("extendedProperties", ExtendedProperties);
            writer.WriteStringValue("labelId", LabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
