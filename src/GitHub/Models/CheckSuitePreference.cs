// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Check suite configuration preferences for a repository.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CheckSuitePreference : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The preferences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.CheckSuitePreference_preferences? Preferences { get; set; }
#nullable restore
#else
        public global::GitHub.Models.CheckSuitePreference_preferences Preferences { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public global::GitHub.Models.MinimalRepository Repository { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.CheckSuitePreference"/> and sets the default values.
        /// </summary>
        public CheckSuitePreference()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CheckSuitePreference"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.CheckSuitePreference CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.CheckSuitePreference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "preferences", n => { Preferences = n.GetObjectValue<global::GitHub.Models.CheckSuitePreference_preferences>(global::GitHub.Models.CheckSuitePreference_preferences.CreateFromDiscriminatorValue); } },
                { "repository", n => { Repository = n.GetObjectValue<global::GitHub.Models.MinimalRepository>(global::GitHub.Models.MinimalRepository.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.CheckSuitePreference_preferences>("preferences", Preferences);
            writer.WriteObjectValue<global::GitHub.Models.MinimalRepository>("repository", Repository);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
