using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.CreateMigrationReport {
    /// <summary>Provides operations to call the createMigrationReport method.</summary>
    public class CreateMigrationReportRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The groupPolicyObjectFile property</summary>
        public Microsoft.Graph.Beta.Models.GroupPolicyObjectFile GroupPolicyObjectFile { get; set; }
        /// <summary>
        /// Instantiates a new createMigrationReportRequestBody and sets the default values.
        /// </summary>
        public CreateMigrationReportRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateMigrationReportRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateMigrationReportRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groupPolicyObjectFile", n => { GroupPolicyObjectFile = n.GetObjectValue<Microsoft.Graph.Beta.Models.GroupPolicyObjectFile>(Microsoft.Graph.Beta.Models.GroupPolicyObjectFile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GroupPolicyObjectFile>("groupPolicyObjectFile", GroupPolicyObjectFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
