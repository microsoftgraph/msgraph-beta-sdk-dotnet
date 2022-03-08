using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the evaluateAssignmentFilter method.</summary>
    public class AssignmentFilterEvaluateRequest : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Order the devices should be sorted in. Default is ascending on device name.</summary>
        public List<string> OrderBy { get; set; }
        /// <summary>Platform type of the devices on which the Assignment Filter will be applicable. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.</summary>
        public DevicePlatformType? Platform { get; set; }
        /// <summary>Rule definition of the Assignment Filter.</summary>
        public string Rule { get; set; }
        /// <summary>Number of records to skip. Default value is 0</summary>
        public int? Skip { get; set; }
        /// <summary>Limit of records per request. Default value is 100, if provided less than 0 or greater than 100</summary>
        public int? Top { get; set; }
        /// <summary>
        /// Instantiates a new assignmentFilterEvaluateRequest and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluateRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignmentFilterEvaluateRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterEvaluateRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"orderBy", (o,n) => { (o as AssignmentFilterEvaluateRequest).OrderBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platform", (o,n) => { (o as AssignmentFilterEvaluateRequest).Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"rule", (o,n) => { (o as AssignmentFilterEvaluateRequest).Rule = n.GetStringValue(); } },
                {"skip", (o,n) => { (o as AssignmentFilterEvaluateRequest).Skip = n.GetIntValue(); } },
                {"top", (o,n) => { (o as AssignmentFilterEvaluateRequest).Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteStringValue("rule", Rule);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
