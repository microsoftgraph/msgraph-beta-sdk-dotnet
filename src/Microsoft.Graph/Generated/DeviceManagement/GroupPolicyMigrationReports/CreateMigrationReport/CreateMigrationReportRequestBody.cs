using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.GroupPolicyMigrationReports.CreateMigrationReport {
    public class CreateMigrationReportRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.GroupPolicyObjectFile GroupPolicyObjectFile { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupPolicyObjectFile", (o,n) => { (o as CreateMigrationReportRequestBody).GroupPolicyObjectFile = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.GroupPolicyObjectFile>(MicrosoftGraphSdk.Models.Microsoft.Graph.GroupPolicyObjectFile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.GroupPolicyObjectFile>("groupPolicyObjectFile", GroupPolicyObjectFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
