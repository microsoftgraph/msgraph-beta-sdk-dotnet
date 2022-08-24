using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class CustomerPaymentJournal : Entity, IParsable {
        /// <summary>The account property</summary>
        public Microsoft.Graph.Beta.Models.Account Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account>("account"); }
            set { BackingStore?.Set("account", value); }
        }
        /// <summary>The balancingAccountId property</summary>
        public string BalancingAccountId {
            get { return BackingStore?.Get<string>("balancingAccountId"); }
            set { BackingStore?.Set("balancingAccountId", value); }
        }
        /// <summary>The balancingAccountNumber property</summary>
        public string BalancingAccountNumber {
            get { return BackingStore?.Get<string>("balancingAccountNumber"); }
            set { BackingStore?.Set("balancingAccountNumber", value); }
        }
        /// <summary>The code property</summary>
        public string Code {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
        /// <summary>The customerPayments property</summary>
        public List<CustomerPayment> CustomerPayments {
            get { return BackingStore?.Get<List<CustomerPayment>>("customerPayments"); }
            set { BackingStore?.Set("customerPayments", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new customerPaymentJournal and sets the default values.
        /// </summary>
        public CustomerPaymentJournal() : base() {
            OdataType = "#microsoft.graph.customerPaymentJournal";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomerPaymentJournal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerPaymentJournal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"balancingAccountId", n => { BalancingAccountId = n.GetStringValue(); } },
                {"balancingAccountNumber", n => { BalancingAccountNumber = n.GetStringValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"customerPayments", n => { CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>(CustomerPayment.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Account>("account", Account);
            writer.WriteStringValue("balancingAccountId", BalancingAccountId);
            writer.WriteStringValue("balancingAccountNumber", BalancingAccountNumber);
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<CustomerPayment>("customerPayments", CustomerPayments);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
