// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Contact information for domain registration. If 'Domain Privacy' option is not selected then the contact information is made publicly available through the Whois
    /// directories as per ICANN requirements.
    /// </summary>
    public partial class RegistrationContactInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RegistrationContactInfo"/>. </summary>
        /// <param name="email"> Email address. </param>
        /// <param name="nameFirst"> First name. </param>
        /// <param name="nameLast"> Last name. </param>
        /// <param name="phone"> Phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="email"/>, <paramref name="nameFirst"/>, <paramref name="nameLast"/> or <paramref name="phone"/> is null. </exception>
        public RegistrationContactInfo(string email, string nameFirst, string nameLast, string phone)
        {
            Argument.AssertNotNull(email, nameof(email));
            Argument.AssertNotNull(nameFirst, nameof(nameFirst));
            Argument.AssertNotNull(nameLast, nameof(nameLast));
            Argument.AssertNotNull(phone, nameof(phone));

            Email = email;
            NameFirst = nameFirst;
            NameLast = nameLast;
            Phone = phone;
        }

        /// <summary> Initializes a new instance of <see cref="RegistrationContactInfo"/>. </summary>
        /// <param name="addressMailing"> Mailing address. </param>
        /// <param name="email"> Email address. </param>
        /// <param name="fax"> Fax number. </param>
        /// <param name="jobTitle"> Job title. </param>
        /// <param name="nameFirst"> First name. </param>
        /// <param name="nameLast"> Last name. </param>
        /// <param name="nameMiddle"> Middle name. </param>
        /// <param name="organization"> Organization contact belongs to. </param>
        /// <param name="phone"> Phone number. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegistrationContactInfo(RegistrationAddressInfo addressMailing, string email, string fax, string jobTitle, string nameFirst, string nameLast, string nameMiddle, string organization, string phone, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AddressMailing = addressMailing;
            Email = email;
            Fax = fax;
            JobTitle = jobTitle;
            NameFirst = nameFirst;
            NameLast = nameLast;
            NameMiddle = nameMiddle;
            Organization = organization;
            Phone = phone;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RegistrationContactInfo"/> for deserialization. </summary>
        internal RegistrationContactInfo()
        {
        }

        /// <summary> Mailing address. </summary>
        public RegistrationAddressInfo AddressMailing { get; set; }
        /// <summary> Email address. </summary>
        public string Email { get; set; }
        /// <summary> Fax number. </summary>
        public string Fax { get; set; }
        /// <summary> Job title. </summary>
        public string JobTitle { get; set; }
        /// <summary> First name. </summary>
        public string NameFirst { get; set; }
        /// <summary> Last name. </summary>
        public string NameLast { get; set; }
        /// <summary> Middle name. </summary>
        public string NameMiddle { get; set; }
        /// <summary> Organization contact belongs to. </summary>
        public string Organization { get; set; }
        /// <summary> Phone number. </summary>
        public string Phone { get; set; }
    }
}
