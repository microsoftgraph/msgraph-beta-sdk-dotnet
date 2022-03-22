using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class LabelingOptions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Security.AssignmentMethod? AssignmentMethod { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Security.DowngradeJustification DowngradeJustification { get; set; }
        public List<KeyValuePair> ExtendedProperties { get; set; }
        public string LabelId { get; set; }
        /// <summary>
        /// Instantiates a new labelingOptions and sets the default values.
        /// </summary>
        public LabelingOptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LabelingOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LabelingOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentMethod", (o,n) => { (o as LabelingOptions).AssignmentMethod = n.GetEnumValue<AssignmentMethod>(); } },
                {"downgradeJustification", (o,n) => { (o as LabelingOptions).DowngradeJustification = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Security.DowngradeJustification>(MicrosoftGraphSdk.Models.Microsoft.Graph.Security.DowngradeJustification.CreateFromDiscriminatorValue); } },
                {"extendedProperties", (o,n) => { (o as LabelingOptions).ExtendedProperties = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Security.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("extendedProperties", ExtendedProperties);
            writer.WriteStringValue("labelId", LabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
