using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the associatedTeams property of the microsoft.graph.userTeamwork entity.</summary>
    public class AssociatedTeamInfoCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<AssociatedTeamInfo> Value { get; set; }
        /// <summary>
        /// Instantiates a new AssociatedTeamInfoCollectionResponse and sets the default values.
        /// </summary>
        public AssociatedTeamInfoCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssociatedTeamInfoCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociatedTeamInfoCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as AssociatedTeamInfoCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as AssociatedTeamInfoCollectionResponse).Value = n.GetCollectionOfObjectValues<AssociatedTeamInfo>(AssociatedTeamInfo.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<AssociatedTeamInfo>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
