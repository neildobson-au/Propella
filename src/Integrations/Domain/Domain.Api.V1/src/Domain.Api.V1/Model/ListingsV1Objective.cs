/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v1
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
using OpenAPIDateConverter = Domain.Api.V1.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Model
{
    /// <summary>
    /// The advertisement&#39;s objective  * &#x60;Sale&#x60; - Residential Advertisement for Sale * &#x60;Rent&#x60; - Residential Advertisement for Rent
    /// </summary>
    /// <value>The advertisement&#39;s objective  * &#x60;Sale&#x60; - Residential Advertisement for Sale * &#x60;Rent&#x60; - Residential Advertisement for Rent</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV1Objective
    {
        /// <summary>
        /// Enum Sale for value: sale
        /// </summary>
        [EnumMember(Value = "sale")]
        Sale = 1,

        /// <summary>
        /// Enum Rent for value: rent
        /// </summary>
        [EnumMember(Value = "rent")]
        Rent = 2

    }

}
