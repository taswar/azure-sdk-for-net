// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class TieringCostRehydrationInfo : IUtf8JsonSerializable, IJsonModel<TieringCostRehydrationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TieringCostRehydrationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TieringCostRehydrationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TieringCostRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TieringCostRehydrationInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rehydrationSizeInBytes"u8);
            writer.WriteNumberValue(RehydrationSizeInBytes);
            writer.WritePropertyName("retailRehydrationCostPerGBPerMonth"u8);
            writer.WriteNumberValue(RetailRehydrationCostPerGBPerMonth);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        TieringCostRehydrationInfo IJsonModel<TieringCostRehydrationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TieringCostRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TieringCostRehydrationInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTieringCostRehydrationInfo(document.RootElement, options);
        }

        internal static TieringCostRehydrationInfo DeserializeTieringCostRehydrationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long rehydrationSizeInBytes = default;
            double retailRehydrationCostPerGBPerMonth = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rehydrationSizeInBytes"u8))
                {
                    rehydrationSizeInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retailRehydrationCostPerGBPerMonth"u8))
                {
                    retailRehydrationCostPerGBPerMonth = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TieringCostRehydrationInfo(objectType, serializedAdditionalRawData, rehydrationSizeInBytes, retailRehydrationCostPerGBPerMonth);
        }

        BinaryData IPersistableModel<TieringCostRehydrationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TieringCostRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TieringCostRehydrationInfo)} does not support '{options.Format}' format.");
            }
        }

        TieringCostRehydrationInfo IPersistableModel<TieringCostRehydrationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TieringCostRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTieringCostRehydrationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TieringCostRehydrationInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TieringCostRehydrationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
