using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Groups.Item.EvaluateDynamicMembership {
    public class EvaluateDynamicMembershipRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string MemberId { get; set; }
        /// <summary>
        /// Instantiates a new evaluateDynamicMembershipRequestBody and sets the default values.
        /// </summary>
        public EvaluateDynamicMembershipRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"memberId", (o,n) => { (o as EvaluateDynamicMembershipRequestBody).MemberId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("memberId", MemberId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
