using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SynchronizationJobSubject : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The links property</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationJobSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationJobSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"links", (o,n) => { (o as SynchronizationJobSubject).Links = n.GetObjectValue<SynchronizationLinkedObjects>(SynchronizationLinkedObjects.CreateFromDiscriminatorValue); } },
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
