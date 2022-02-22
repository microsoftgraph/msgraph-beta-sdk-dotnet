using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ServicePrincipalCreationConditionSet : Entity, IParsable {
        public List<string> ApplicationIds { get; set; }
        public List<string> ApplicationPublisherIds { get; set; }
        public bool? ApplicationsFromVerifiedPublisherOnly { get; set; }
        public List<string> ApplicationTenantIds { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationIds", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationPublisherIds", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationPublisherIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationsFromVerifiedPublisherOnly", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationsFromVerifiedPublisherOnly = n.GetBoolValue(); } },
                {"applicationTenantIds", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationTenantIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationIds", ApplicationIds);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationPublisherIds", ApplicationPublisherIds);
            writer.WriteBoolValue("applicationsFromVerifiedPublisherOnly", ApplicationsFromVerifiedPublisherOnly);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationTenantIds", ApplicationTenantIds);
        }
    }
}
