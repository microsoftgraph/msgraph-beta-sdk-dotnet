using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getAzureADApplicationSignInSummary method.</summary>
    public class ApplicationSignInSummary : Entity, IParsable {
        /// <summary>Name of the application that the user signed into.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>Count of failed sign-ins made by the application.</summary>
        public int? FailedSignInCount { get; set; }
        /// <summary>Count of successful sign-ins made by the application.</summary>
        public int? SuccessfulSignInCount { get; set; }
        /// <summary>Percentage of successful sign-ins made by the application.</summary>
        public double? SuccessPercentage { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApplicationSignInSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationSignInSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as ApplicationSignInSummary).AppDisplayName = n.GetStringValue(); } },
                {"failedSignInCount", (o,n) => { (o as ApplicationSignInSummary).FailedSignInCount = n.GetIntValue(); } },
                {"successfulSignInCount", (o,n) => { (o as ApplicationSignInSummary).SuccessfulSignInCount = n.GetIntValue(); } },
                {"successPercentage", (o,n) => { (o as ApplicationSignInSummary).SuccessPercentage = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteIntValue("failedSignInCount", FailedSignInCount);
            writer.WriteIntValue("successfulSignInCount", SuccessfulSignInCount);
            writer.WriteDoubleValue("successPercentage", SuccessPercentage);
        }
    }
}
