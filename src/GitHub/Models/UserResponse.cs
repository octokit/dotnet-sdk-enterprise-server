// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class UserResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Whether the user active in the IdP.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable name for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The emails for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Users>? Emails { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Users> Emails { get; set; }
#endif
        /// <summary>A unique identifier for the resource as defined by the provisioning client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.UserNameResponse? Name { get; set; }
#nullable restore
#else
        public global::GitHub.Models.UserNameResponse Name { get; set; }
#endif
        /// <summary>The roles assigned to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Users>? Roles { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Users> Roles { get; set; }
#endif
        /// <summary>The URIs that are used to indicate the namespaces of the SCIM schemas.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.UserResponse_schemas?>? Schemas { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.UserResponse_schemas?> Schemas { get; set; }
#endif
        /// <summary>The username for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.UserResponse"/> and sets the default values.
        /// </summary>
        public UserResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.UserResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.UserResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.UserResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "emails", n => { Emails = n.GetCollectionOfObjectValues<global::GitHub.Models.Users>(global::GitHub.Models.Users.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetObjectValue<global::GitHub.Models.UserNameResponse>(global::GitHub.Models.UserNameResponse.CreateFromDiscriminatorValue); } },
                { "roles", n => { Roles = n.GetCollectionOfObjectValues<global::GitHub.Models.Users>(global::GitHub.Models.Users.CreateFromDiscriminatorValue)?.AsList(); } },
                { "schemas", n => { Schemas = n.GetCollectionOfEnumValues<global::GitHub.Models.UserResponse_schemas>()?.AsList(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Users>("emails", Emails);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<global::GitHub.Models.UserNameResponse>("name", Name);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Users>("roles", Roles);
            writer.WriteCollectionOfEnumValues<global::GitHub.Models.UserResponse_schemas>("schemas", Schemas);
            writer.WriteStringValue("userName", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
