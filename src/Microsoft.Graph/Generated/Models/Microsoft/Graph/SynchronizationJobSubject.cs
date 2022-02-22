using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SynchronizationJobSubject : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public SynchronizationLinkedObjects Links { get; set; }
        /// <summary>The identifier of an object to which a synchronizationJob  is to be applied.</summary>
        public string ObjectId { get; set; }
        /// <summary>The type of the object to which a synchronizationJob  is to be applied.</summary>
        public string ObjectTypeName { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationJobSubject and sets the default values.
        /// </summary>
        public SynchronizationJobSubject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"links", (o,n) => { (o as SynchronizationJobSubject).Links = n.GetObjectValue<SynchronizationLinkedObjects>(); } },
                {"objectId", (o,n) => { (o as SynchronizationJobSubject).ObjectId = n.GetStringValue(); } },
                {"objectTypeName", (o,n) => { (o as SynchronizationJobSubject).ObjectTypeName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SynchronizationLinkedObjects>("links", Links);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("objectTypeName", ObjectTypeName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
