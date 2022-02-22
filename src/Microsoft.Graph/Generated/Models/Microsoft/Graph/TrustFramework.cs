using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TrustFramework : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<TrustFrameworkKeySet> KeySets { get; set; }
        public List<TrustFrameworkPolicy> Policies { get; set; }
        /// <summary>
        /// Instantiates a new TrustFramework and sets the default values.
        /// </summary>
        public TrustFramework() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keySets", (o,n) => { (o as TrustFramework).KeySets = n.GetCollectionOfObjectValues<TrustFrameworkKeySet>().ToList(); } },
                {"policies", (o,n) => { (o as TrustFramework).Policies = n.GetCollectionOfObjectValues<TrustFrameworkPolicy>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TrustFrameworkKeySet>("keySets", KeySets);
            writer.WriteCollectionOfObjectValues<TrustFrameworkPolicy>("policies", Policies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
