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
using OpenAPIDateConverter = Domain.Api.V2.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.V2.Client.Model
{
    /// <summary>
    /// Type of the median price type  * &#x60;House&#x60; - House * &#x60;ApartmentUnitFlat&#x60; - Apartment / unit / flat * &#x60;VacantLand&#x60; - Vacant Land
    /// </summary>
    /// <value>Type of the median price type  * &#x60;House&#x60; - House * &#x60;ApartmentUnitFlat&#x60; - Apartment / unit / flat * &#x60;VacantLand&#x60; - Vacant Land</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV2MedianPriceType
    {
        /// <summary>
        /// Enum House for value: house
        /// </summary>
        [EnumMember(Value = "house")]
        House = 1,

        /// <summary>
        /// Enum ApartmentUnitFlat for value: apartmentUnitFlat
        /// </summary>
        [EnumMember(Value = "apartmentUnitFlat")]
        ApartmentUnitFlat = 2,

        /// <summary>
        /// Enum VacantLand for value: vacantLand
        /// </summary>
        [EnumMember(Value = "vacantLand")]
        VacantLand = 3

    }

}