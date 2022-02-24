using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SecurityBaselineContributingPolicy : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the policy</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique identifier of the policy</summary>
        public string SourceId { get; set; }
        /// <summary>Authoring source of the policy. Possible values are: deviceConfiguration, deviceIntent.</summary>
        public SecurityBaselinePolicySourceType? SourceType { get; set; }
        /// <summary>
        /// Instantiates a new securityBaselineContributingPolicy and sets the default values.
        /// </summary>
        public SecurityBaselineContributingPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as SecurityBaselineContributingPolicy).DisplayName = n.GetStringValue(); } },
                {"sourceId", (o,n) => { (o as SecurityBaselineContributingPolicy).SourceId = n.GetStringValue(); } },
                {"sourceType", (o,n) => { (o as SecurityBaselineContributingPolicy).SourceType = n.GetEnumValue<SecurityBaselinePolicySourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteEnumValue<SecurityBaselinePolicySourceType>("sourceType", SourceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
