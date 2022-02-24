using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AssignmentFilterEvaluateRequest : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
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
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteStringValue("rule", Rule);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
