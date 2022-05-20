using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationRoot : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The classes property</summary>
        public List<EducationClass> Classes {
            get { return BackingStore?.Get<List<EducationClass>>(nameof(Classes)); }
            set { BackingStore?.Set(nameof(Classes), value); }
        }
        /// <summary>The me property</summary>
        public EducationUser Me {
            get { return BackingStore?.Get<EducationUser>(nameof(Me)); }
            set { BackingStore?.Set(nameof(Me), value); }
        }
        /// <summary>The schools property</summary>
        public List<EducationSchool> Schools {
            get { return BackingStore?.Get<List<EducationSchool>>(nameof(Schools)); }
            set { BackingStore?.Set(nameof(Schools), value); }
        }
        /// <summary>The synchronizationProfiles property</summary>
        public List<EducationSynchronizationProfile> SynchronizationProfiles {
            get { return BackingStore?.Get<List<EducationSynchronizationProfile>>(nameof(SynchronizationProfiles)); }
            set { BackingStore?.Set(nameof(SynchronizationProfiles), value); }
        }
        /// <summary>The users property</summary>
        public List<EducationUser> Users {
            get { return BackingStore?.Get<List<EducationUser>>(nameof(Users)); }
            set { BackingStore?.Set(nameof(Users), value); }
        }
        /// <summary>
        /// Instantiates a new EducationRoot and sets the default values.
        /// </summary>
        public EducationRoot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"me", n => { Me = n.GetObjectValue<EducationUser>(EducationUser.CreateFromDiscriminatorValue); } },
                {"schools", n => { Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue).ToList(); } },
                {"synchronizationProfiles", n => { SynchronizationProfiles = n.GetCollectionOfObjectValues<EducationSynchronizationProfile>(EducationSynchronizationProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<EducationUser>("me", Me);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<EducationSynchronizationProfile>("synchronizationProfiles", SynchronizationProfiles);
            writer.WriteCollectionOfObjectValues<EducationUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
