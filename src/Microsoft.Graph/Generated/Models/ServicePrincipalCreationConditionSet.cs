using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class ServicePrincipalCreationConditionSet : Entity, IParsable {
        /// <summary>The applicationIds property</summary>
        public List<string> ApplicationIds {
            get { return BackingStore?.Get<List<string>>(nameof(ApplicationIds)); }
            set { BackingStore?.Set(nameof(ApplicationIds), value); }
        }
        /// <summary>The applicationPublisherIds property</summary>
        public List<string> ApplicationPublisherIds {
            get { return BackingStore?.Get<List<string>>(nameof(ApplicationPublisherIds)); }
            set { BackingStore?.Set(nameof(ApplicationPublisherIds), value); }
        }
        /// <summary>The applicationsFromVerifiedPublisherOnly property</summary>
        public bool? ApplicationsFromVerifiedPublisherOnly {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationsFromVerifiedPublisherOnly)); }
            set { BackingStore?.Set(nameof(ApplicationsFromVerifiedPublisherOnly), value); }
        }
        /// <summary>The applicationTenantIds property</summary>
        public List<string> ApplicationTenantIds {
            get { return BackingStore?.Get<List<string>>(nameof(ApplicationTenantIds)); }
            set { BackingStore?.Set(nameof(ApplicationTenantIds), value); }
        }
        /// <summary>The certifiedApplicationsOnly property</summary>
        public bool? CertifiedApplicationsOnly {
            get { return BackingStore?.Get<bool?>(nameof(CertifiedApplicationsOnly)); }
            set { BackingStore?.Set(nameof(CertifiedApplicationsOnly), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationIds", n => { ApplicationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationPublisherIds", n => { ApplicationPublisherIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationsFromVerifiedPublisherOnly", n => { ApplicationsFromVerifiedPublisherOnly = n.GetBoolValue(); } },
                {"applicationTenantIds", n => { ApplicationTenantIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"certifiedApplicationsOnly", n => { CertifiedApplicationsOnly = n.GetBoolValue(); } },
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
