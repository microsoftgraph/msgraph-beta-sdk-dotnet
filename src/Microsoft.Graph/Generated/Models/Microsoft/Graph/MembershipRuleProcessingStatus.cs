using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MembershipRuleProcessingStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Detailed error message if dynamic group processing ran into an error.  Optional. Read-only.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Most recent date and time when membership of a dynamic group was updated.  Optional. Read-only.</summary>
        public DateTimeOffset? LastMembershipUpdated { get; set; }
        /// <summary>Current status of a dynamic group processing. Possible values are: NotStarted, Running, Succeeded, Failed, and UnknownFutureValue.   Required. Read-only.</summary>
        public MembershipRuleProcessingStatusDetails? Status { get; set; }
        /// <summary>
        /// Instantiates a new membershipRuleProcessingStatus and sets the default values.
        /// </summary>
        public MembershipRuleProcessingStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MembershipRuleProcessingStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembershipRuleProcessingStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"errorMessage", (o,n) => { (o as MembershipRuleProcessingStatus).ErrorMessage = n.GetStringValue(); } },
                {"lastMembershipUpdated", (o,n) => { (o as MembershipRuleProcessingStatus).LastMembershipUpdated = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as MembershipRuleProcessingStatus).Status = n.GetEnumValue<MembershipRuleProcessingStatusDetails>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteDateTimeOffsetValue("lastMembershipUpdated", LastMembershipUpdated);
            writer.WriteEnumValue<MembershipRuleProcessingStatusDetails>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
