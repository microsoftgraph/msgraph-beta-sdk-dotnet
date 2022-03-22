using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ServicePrincipalCreationConditionSet : Entity, IParsable {
        public List<string> ApplicationIds { get; set; }
        public List<string> ApplicationPublisherIds { get; set; }
        public bool? ApplicationsFromVerifiedPublisherOnly { get; set; }
        public List<string> ApplicationTenantIds { get; set; }
        public bool? CertifiedApplicationsOnly { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ServicePrincipalCreationConditionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalCreationConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationIds", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationPublisherIds", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationPublisherIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationsFromVerifiedPublisherOnly", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationsFromVerifiedPublisherOnly = n.GetBoolValue(); } },
                {"applicationTenantIds", (o,n) => { (o as ServicePrincipalCreationConditionSet).ApplicationTenantIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"certifiedApplicationsOnly", (o,n) => { (o as ServicePrincipalCreationConditionSet).CertifiedApplicationsOnly = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("certifiedApplicationsOnly", CertifiedApplicationsOnly);
        }
    }
}
