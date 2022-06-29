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
            get { return BackingStore?.Get<string>(nameof(City)); }
            set { BackingStore?.Set(nameof(City), value); }
        }
        /// <summary>The code for the country where the managed tenant is located. Optional. Read-only.</summary>
        public string CountryCode {
            get { return BackingStore?.Get<string>(nameof(CountryCode)); }
            set { BackingStore?.Set(nameof(CountryCode), value); }
        }
        /// <summary>The name for the country where the managed tenant is located. Optional. Read-only.</summary>
        public string CountryName {
            get { return BackingStore?.Get<string>(nameof(CountryName)); }
            set { BackingStore?.Set(nameof(CountryName), value); }
        }
        /// <summary>The default domain name for the managed tenant. Optional. Read-only.</summary>
        public string DefaultDomainName {
            get { return BackingStore?.Get<string>(nameof(DefaultDomainName)); }
            set { BackingStore?.Set(nameof(DefaultDomainName), value); }
        }
        /// <summary>The display name for the managed tenant.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The business industry associated with the managed tenant. Optional. Read-only.</summary>
        public string IndustryName {
            get { return BackingStore?.Get<string>(nameof(IndustryName)); }
            set { BackingStore?.Set(nameof(IndustryName), value); }
        }
        /// <summary>The region where the managed tenant is located. Optional. Read-only.</summary>
        public string Region {
            get { return BackingStore?.Get<string>(nameof(Region)); }
            set { BackingStore?.Set(nameof(Region), value); }
        }
        /// <summary>The business segment associated with the managed tenant. Optional. Read-only.</summary>
        public string SegmentName {
            get { return BackingStore?.Get<string>(nameof(SegmentName)); }
            set { BackingStore?.Set(nameof(SegmentName), value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The vertical associated with the managed tenant. Optional. Read-only.</summary>
        public string VerticalName {
            get { return BackingStore?.Get<string>(nameof(VerticalName)); }
            set { BackingStore?.Set(nameof(VerticalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
