// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using ClientModel.Tests.ClientShared;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace System.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ResourceTypeAliasPattern : IJsonModel<ResourceTypeAliasPattern>
    {
        internal static ResourceTypeAliasPattern DeserializeResourceTypeAliasPattern(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> phrase = default;
            OptionalProperty<string> variable = default;
            OptionalProperty<ResourceTypeAliasPatternType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phrase"u8))
                {
                    phrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasPatternType();
                    continue;
                }
            }
            return new ResourceTypeAliasPattern(phrase.Value, variable.Value, OptionalProperty.ToNullable(type));
        }

        void IJsonModel<ResourceTypeAliasPattern>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Phrase))
            {
                writer.WritePropertyName("phrase"u8);
                writer.WriteStringValue(Phrase);
            }
            if (OptionalProperty.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
            }
            if (OptionalProperty.IsDefined(PatternType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PatternType.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasPatternProperites
        {
            public OptionalProperty<string> Phrase { get; set; }
            public OptionalProperty<string> Variable { get; set; }
            public OptionalProperty<ResourceTypeAliasPatternType> PatternType { get; set; }
        }

        ResourceTypeAliasPattern IJsonModel<ResourceTypeAliasPattern>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPattern(doc.RootElement, options);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ResourceTypeAliasPatternProperites properties, ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            if (propertyName.SequenceEqual("phrase"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Phrase = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("variable"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Variable = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("type"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.PatternType = reader.GetString().ToResourceTypeAliasPatternType();
                return;
            }
            reader.Skip();
        }

        ResourceTypeAliasPattern IPersistableModel<ResourceTypeAliasPattern>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPattern(doc.RootElement, options);
        }

        BinaryData IPersistableModel<ResourceTypeAliasPattern>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<ResourceTypeAliasPattern>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
