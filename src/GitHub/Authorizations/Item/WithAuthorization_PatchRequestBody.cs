// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Authorizations.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class WithAuthorization_PatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of scopes to add to this authorization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AddScopes { get; set; }
#nullable restore
#else
        public List<string> AddScopes { get; set; }
#endif
        /// <summary>A unique string to distinguish an authorization from others created for the same client ID and user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint { get; set; }
#nullable restore
#else
        public string Fingerprint { get; set; }
#endif
        /// <summary>A note to remind you what the OAuth token is for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>A URL to remind you what app the OAuth token is for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NoteUrl { get; set; }
#nullable restore
#else
        public string NoteUrl { get; set; }
#endif
        /// <summary>A list of scopes to remove from this authorization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoveScopes { get; set; }
#nullable restore
#else
        public List<string> RemoveScopes { get; set; }
#endif
        /// <summary>A list of scopes that this authorization is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Scopes { get; set; }
#nullable restore
#else
        public List<string> Scopes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Authorizations.Item.WithAuthorization_PatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithAuthorization_PatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Authorizations.Item.WithAuthorization_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Authorizations.Item.WithAuthorization_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Authorizations.Item.WithAuthorization_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "add_scopes", n => { AddScopes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "note_url", n => { NoteUrl = n.GetStringValue(); } },
                { "remove_scopes", n => { RemoveScopes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "scopes", n => { Scopes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("add_scopes", AddScopes);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("note_url", NoteUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("remove_scopes", RemoveScopes);
            writer.WriteCollectionOfPrimitiveValues<string>("scopes", Scopes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
