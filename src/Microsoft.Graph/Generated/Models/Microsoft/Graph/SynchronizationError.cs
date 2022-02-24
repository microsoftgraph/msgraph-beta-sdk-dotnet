using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SynchronizationError : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public bool? TenantActionable { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationError and sets the default values.
        /// </summary>
        public SynchronizationError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as SynchronizationError).Code = n.GetStringValue(); } },
                {"message", (o,n) => { (o as SynchronizationError).Message = n.GetStringValue(); } },
                {"tenantActionable", (o,n) => { (o as SynchronizationError).TenantActionable = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("message", Message);
            writer.WriteBoolValue("tenantActionable", TenantActionable);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
