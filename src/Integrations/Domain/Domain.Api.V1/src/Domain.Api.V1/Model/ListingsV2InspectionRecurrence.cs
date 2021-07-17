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
    /// Indicates how often an inspection recurs.  * &#x60;None&#x60; - Once-off inspection * &#x60;Weekly&#x60; - Weekly inspection
    /// </summary>
    /// <value>Indicates how often an inspection recurs.  * &#x60;None&#x60; - Once-off inspection * &#x60;Weekly&#x60; - Weekly inspection</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV2InspectionRecurrence
    {
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 1,

        /// <summary>
        /// Enum Weekly for value: weekly
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly = 2

    }

}