using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Synchronization : Entity, IParsable {
        /// <summary>Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.</summary>
        public List<SynchronizationJob> Jobs { get; set; }
        /// <summary>Represents a collection of credentials to access provisioned cloud applications.</summary>
        public List<SynchronizationSecretKeyStringValuePair> Secrets { get; set; }
        /// <summary>Pre-configured synchronization settings for a particular application.</summary>
        public List<SynchronizationTemplate> Templates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"jobs", (o,n) => { (o as Synchronization).Jobs = n.GetCollectionOfObjectValues<SynchronizationJob>().ToList(); } },
                {"secrets", (o,n) => { (o as Synchronization).Secrets = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>().ToList(); } },
                {"templates", (o,n) => { (o as Synchronization).Templates = n.GetCollectionOfObjectValues<SynchronizationTemplate>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SynchronizationJob>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("secrets", Secrets);
            writer.WriteCollectionOfObjectValues<SynchronizationTemplate>("templates", Templates);
        }
    }
}
