using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class TenantDetailedInformation : Entity, IParsable {
        /// <summary>The city where the managed tenant is located. Optional. Read-only.</summary>
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
        /// <summary>The code for the country where the managed tenant is located. Optional. Read-only.</summary>
        public string CountryCode {
            get { return BackingStore?.Get<string>("countryCode"); }
            set { BackingStore?.Set("countryCode", value); }
        }
        /// <summary>The name for the country where the managed tenant is located. Optional. Read-only.</summary>
        public string CountryName {
            get { return BackingStore?.Get<string>("countryName"); }
            set { BackingStore?.Set("countryName", value); }
        }
        /// <summary>The default domain name for the managed tenant. Optional. Read-only.</summary>
        public string DefaultDomainName {
            get { return BackingStore?.Get<string>("defaultDomainName"); }
            set { BackingStore?.Set("defaultDomainName", value); }
        }
        /// <summary>The display name for the managed tenant.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The business industry associated with the managed tenant. Optional. Read-only.</summary>
        public string IndustryName {
            get { return BackingStore?.Get<string>("industryName"); }
            set { BackingStore?.Set("industryName", value); }
        }
        /// <summary>The region where the managed tenant is located. Optional. Read-only.</summary>
        public string Region {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
        /// <summary>The business segment associated with the managed tenant. Optional. Read-only.</summary>
        public string SegmentName {
            get { return BackingStore?.Get<string>("segmentName"); }
            set { BackingStore?.Set("segmentName", value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The vertical associated with the managed tenant. Optional. Read-only.</summary>
        public string VerticalName {
            get { return BackingStore?.Get<string>("verticalName"); }
            set { BackingStore?.Set("verticalName", value); }
        }
        /// <summary>
        /// Instantiates a new tenantDetailedInformation and sets the default values.
        /// </summary>
        public TenantDetailedInformation() : base() {
            OdataType = "#microsoft.graph.managedTenants.tenantDetailedInformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantDetailedInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantDetailedInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"city", n => { City = n.GetStringValue(); } },
                {"countryCode", n => { CountryCode = n.GetStringValue(); } },
                {"countryName", n => { CountryName = n.GetStringValue(); } },
                {"defaultDomainName", n => { DefaultDomainName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"industryName", n => { IndustryName = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
                {"segmentName", n => { SegmentName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"verticalName", n => { VerticalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteStringValue("countryName", CountryName);
            writer.WriteStringValue("defaultDomainName", DefaultDomainName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("industryName", IndustryName);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("segmentName", SegmentName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("verticalName", VerticalName);
        }
    }
}
