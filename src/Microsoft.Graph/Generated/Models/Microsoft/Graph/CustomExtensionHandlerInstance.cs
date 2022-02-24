using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CustomExtensionHandlerInstance : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CustomExtensionId { get; set; }
        public string ExternalCorrelationId { get; set; }
        public AccessPackageCustomExtensionStage? Stage { get; set; }
        public AccessPackageCustomExtensionHandlerStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new customExtensionHandlerInstance and sets the default values.
        /// </summary>
        public CustomExtensionHandlerInstance() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"customExtensionId", (o,n) => { (o as CustomExtensionHandlerInstance).CustomExtensionId = n.GetStringValue(); } },
                {"externalCorrelationId", (o,n) => { (o as CustomExtensionHandlerInstance).ExternalCorrelationId = n.GetStringValue(); } },
                {"stage", (o,n) => { (o as CustomExtensionHandlerInstance).Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
                {"status", (o,n) => { (o as CustomExtensionHandlerInstance).Status = n.GetEnumValue<AccessPackageCustomExtensionHandlerStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customExtensionId", CustomExtensionId);
            writer.WriteStringValue("externalCorrelationId", ExternalCorrelationId);
            writer.WriteEnumValue<AccessPackageCustomExtensionStage>("stage", Stage);
            writer.WriteEnumValue<AccessPackageCustomExtensionHandlerStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
