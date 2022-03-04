using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.WindowsDriverUpdateProfiles.Item.ExecuteAction {
    public class ExecuteActionRequestBody : IParsable {
        public DriverApprovalAction? ActionName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeOffset? DeploymentDate { get; set; }
        public List<string> DriverIds { get; set; }
        /// <summary>
        /// Instantiates a new executeActionRequestBody and sets the default values.
        /// </summary>
        public ExecuteActionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExecuteActionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExecuteActionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionName", (o,n) => { (o as ExecuteActionRequestBody).ActionName = n.GetEnumValue<DriverApprovalAction>(); } },
                {"deploymentDate", (o,n) => { (o as ExecuteActionRequestBody).DeploymentDate = n.GetDateTimeOffsetValue(); } },
                {"driverIds", (o,n) => { (o as ExecuteActionRequestBody).DriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DriverApprovalAction>("actionName", ActionName);
            writer.WriteDateTimeOffsetValue("deploymentDate", DeploymentDate);
            writer.WriteCollectionOfPrimitiveValues<string>("driverIds", DriverIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
