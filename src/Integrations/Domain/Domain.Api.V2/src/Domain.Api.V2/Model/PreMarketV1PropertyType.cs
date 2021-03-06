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
    /// Defines PreMarket.v1.PropertyType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PreMarketV1PropertyType
    {
        /// <summary>
        /// Enum House for value: house
        /// </summary>
        [EnumMember(Value = "house")]
        House = 1,

        /// <summary>
        /// Enum Townhouse for value: townhouse
        /// </summary>
        [EnumMember(Value = "townhouse")]
        Townhouse = 2,

        /// <summary>
        /// Enum ApartmentUnitFlat for value: apartmentUnitFlat
        /// </summary>
        [EnumMember(Value = "apartmentUnitFlat")]
        ApartmentUnitFlat = 3,

        /// <summary>
        /// Enum VacantLand for value: vacantLand
        /// </summary>
        [EnumMember(Value = "vacantLand")]
        VacantLand = 4

    }

}
