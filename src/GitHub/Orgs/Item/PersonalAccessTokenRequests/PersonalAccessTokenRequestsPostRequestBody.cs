// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.PersonalAccessTokenRequests {
    #pragma warning disable CS1591
    public class PersonalAccessTokenRequestsPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Action to apply to the requests.</summary>
        public PersonalAccessTokenRequestsPostRequestBody_action? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifiers of the requests for access via fine-grained personal access token. Must be formed of between 1 and 100 `pat_request_id` values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? PatRequestIds { get; set; }
#nullable restore
#else
        public List<int?> PatRequestIds { get; set; }
#endif
        /// <summary>Reason for approving or denying the requests. Max 1024 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PersonalAccessTokenRequestsPostRequestBody"/> and sets the default values.
        /// </summary>
        public PersonalAccessTokenRequestsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PersonalAccessTokenRequestsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PersonalAccessTokenRequestsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonalAccessTokenRequestsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetEnumValue<PersonalAccessTokenRequestsPostRequestBody_action>(); } },
                {"pat_request_ids", n => { PatRequestIds = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PersonalAccessTokenRequestsPostRequestBody_action>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<int?>("pat_request_ids", PatRequestIds);
            writer.WriteStringValue("reason", Reason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
