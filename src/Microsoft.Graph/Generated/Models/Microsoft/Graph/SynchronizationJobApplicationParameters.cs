using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the provisionOnDemand method.</summary>
    public class SynchronizationJobApplicationParameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier of a the synchronizationRule to be applied.</summary>
        public string RuleId { get; set; }
        /// <summary>The identifiers of one or more objects to which a synchronizationJob is to be applied.</summary>
        public List<SynchronizationJobSubject> Subjects { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationJobApplicationParameters and sets the default values.
        /// </summary>
        public SynchronizationJobApplicationParameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationJobApplicationParameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationJobApplicationParameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ruleId", (o,n) => { (o as SynchronizationJobApplicationParameters).RuleId = n.GetStringValue(); } },
                {"subjects", (o,n) => { (o as SynchronizationJobApplicationParameters).Subjects = n.GetCollectionOfObjectValues<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ruleId", RuleId);
            writer.WriteCollectionOfObjectValues<SynchronizationJobSubject>("subjects", Subjects);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
