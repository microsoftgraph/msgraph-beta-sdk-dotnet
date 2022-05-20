using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Location : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The street address of the location.</summary>
        public PhysicalAddress Address {
            get { return BackingStore?.Get<PhysicalAddress>(nameof(Address)); }
            set { BackingStore?.Set(nameof(Address), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The geographic coordinates and elevation of the location.</summary>
        public OutlookGeoCoordinates Coordinates {
            get { return BackingStore?.Get<OutlookGeoCoordinates>(nameof(Coordinates)); }
            set { BackingStore?.Set(nameof(Coordinates), value); }
        }
        /// <summary>The name associated with the location.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Optional email address of the location.</summary>
        public string LocationEmailAddress {
            get { return BackingStore?.Get<string>(nameof(LocationEmailAddress)); }
            set { BackingStore?.Set(nameof(LocationEmailAddress), value); }
        }
        /// <summary>The type of location. Possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.LocationType? LocationType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LocationType?>(nameof(LocationType)); }
            set { BackingStore?.Set(nameof(LocationType), value); }
        }
        /// <summary>Optional URI representing the location.</summary>
        public string LocationUri {
            get { return BackingStore?.Get<string>(nameof(LocationUri)); }
            set { BackingStore?.Set(nameof(LocationUri), value); }
        }
        /// <summary>For internal use only.</summary>
        public string UniqueId {
            get { return BackingStore?.Get<string>(nameof(UniqueId)); }
            set { BackingStore?.Set(nameof(UniqueId), value); }
        }
        /// <summary>For internal use only.</summary>
        public LocationUniqueIdType? UniqueIdType {
            get { return BackingStore?.Get<LocationUniqueIdType?>(nameof(UniqueIdType)); }
            set { BackingStore?.Set(nameof(UniqueIdType), value); }
        }
        /// <summary>
        /// Instantiates a new location and sets the default values.
        /// </summary>
        public Location() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Location CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Location();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"coordinates", n => { Coordinates = n.GetObjectValue<OutlookGeoCoordinates>(OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"locationEmailAddress", n => { LocationEmailAddress = n.GetStringValue(); } },
                {"locationType", n => { LocationType = n.GetEnumValue<LocationType>(); } },
                {"locationUri", n => { LocationUri = n.GetStringValue(); } },
                {"uniqueId", n => { UniqueId = n.GetStringValue(); } },
                {"uniqueIdType", n => { UniqueIdType = n.GetEnumValue<LocationUniqueIdType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteObjectValue<OutlookGeoCoordinates>("coordinates", Coordinates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("locationEmailAddress", LocationEmailAddress);
            writer.WriteEnumValue<LocationType>("locationType", LocationType);
            writer.WriteStringValue("locationUri", LocationUri);
            writer.WriteStringValue("uniqueId", UniqueId);
            writer.WriteEnumValue<LocationUniqueIdType>("uniqueIdType", UniqueIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
