using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Reports.GetOffice365ActiveUserDetailWithDate {
    /// <summary>Provides operations to call the getOffice365ActiveUserDetail method.</summary>
    public class GetOffice365ActiveUserDetailWithDateResponse : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<Office365ActiveUserDetail> Value { get; set; }
        /// <summary>
        /// Instantiates a new getOffice365ActiveUserDetailWithDateResponse and sets the default values.
        /// </summary>
        public GetOffice365ActiveUserDetailWithDateResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetOffice365ActiveUserDetailWithDateResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetOffice365ActiveUserDetailWithDateResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as GetOffice365ActiveUserDetailWithDateResponse).Value = n.GetCollectionOfObjectValues<Office365ActiveUserDetail>(Office365ActiveUserDetail.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Office365ActiveUserDetail>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
