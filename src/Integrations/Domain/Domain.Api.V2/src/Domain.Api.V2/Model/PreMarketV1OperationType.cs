/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v2
 * Contact: api@domain.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Domain.Api.V2.Client.OpenAPIDateConverter;

namespace Domain.Api.V2.Model
{
    /// <summary>
    /// Defines PreMarket.v1.OperationType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PreMarketV1OperationType
    {
        /// <summary>
        /// Enum Add for value: add
        /// </summary>
        [EnumMember(Value = "add")]
        Add = 1,

        /// <summary>
        /// Enum Remove for value: remove
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove = 2,

        /// <summary>
        /// Enum Replace for value: replace
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace = 3,

        /// <summary>
        /// Enum Move for value: move
        /// </summary>
        [EnumMember(Value = "move")]
        Move = 4,

        /// <summary>
        /// Enum Copy for value: copy
        /// </summary>
        [EnumMember(Value = "copy")]
        Copy = 5,

        /// <summary>
        /// Enum Test for value: test
        /// </summary>
        [EnumMember(Value = "test")]
        Test = 6,

        /// <summary>
        /// Enum Invalid for value: invalid
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid = 7

    }

}
