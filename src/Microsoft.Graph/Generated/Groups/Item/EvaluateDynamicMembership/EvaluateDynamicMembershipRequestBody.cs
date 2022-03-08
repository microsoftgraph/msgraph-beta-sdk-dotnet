using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Groups.Item.EvaluateDynamicMembership {
    /// <summary>Provides operations to call the evaluateDynamicMembership method.</summary>
    public class EvaluateDynamicMembershipRequestBody : IParsable, IAdditionalDataHolder {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateDynamicMembershipRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateDynamicMembershipRequestBody();
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
