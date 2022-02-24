using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Filter : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>*Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
        public List<FilterGroup> CategoryFilterGroups { get; set; }
        /// <summary>Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
        public List<FilterGroup> Groups { get; set; }
        /// <summary>*Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
        public List<FilterGroup> InputFilterGroups { get; set; }
        /// <summary>
        /// Instantiates a new filter and sets the default values.
        /// </summary>
        public Filter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"categoryFilterGroups", (o,n) => { (o as Filter).CategoryFilterGroups = n.GetCollectionOfObjectValues<FilterGroup>().ToList(); } },
                {"groups", (o,n) => { (o as Filter).Groups = n.GetCollectionOfObjectValues<FilterGroup>().ToList(); } },
                {"inputFilterGroups", (o,n) => { (o as Filter).InputFilterGroups = n.GetCollectionOfObjectValues<FilterGroup>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<FilterGroup>("categoryFilterGroups", CategoryFilterGroups);
            writer.WriteCollectionOfObjectValues<FilterGroup>("groups", Groups);
            writer.WriteCollectionOfObjectValues<FilterGroup>("inputFilterGroups", InputFilterGroups);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
