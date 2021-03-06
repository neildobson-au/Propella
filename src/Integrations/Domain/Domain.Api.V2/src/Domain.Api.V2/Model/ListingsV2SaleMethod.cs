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
    /// The method of sale for an advertised listing  * &#x60;NotStated&#x60; - When the sale method is not defined * &#x60;Auction&#x60; - For sale by auction, or sold by auction if the listing is sold * &#x60;PrivateTreaty&#x60; - For sale by private treaty, or sold by private treaty if the listing is sold * &#x60;Tender&#x60; - For sale by tender, or sold by tender if the listing is sold * &#x60;ExpressionOfInterest&#x60; - for sale by an expression of interest
    /// </summary>
    /// <value>The method of sale for an advertised listing  * &#x60;NotStated&#x60; - When the sale method is not defined * &#x60;Auction&#x60; - For sale by auction, or sold by auction if the listing is sold * &#x60;PrivateTreaty&#x60; - For sale by private treaty, or sold by private treaty if the listing is sold * &#x60;Tender&#x60; - For sale by tender, or sold by tender if the listing is sold * &#x60;ExpressionOfInterest&#x60; - for sale by an expression of interest</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV2SaleMethod
    {
        /// <summary>
        /// Enum NotStated for value: notStated
        /// </summary>
        [EnumMember(Value = "notStated")]
        NotStated = 1,

        /// <summary>
        /// Enum Auction for value: auction
        /// </summary>
        [EnumMember(Value = "auction")]
        Auction = 2,

        /// <summary>
        /// Enum PrivateTreaty for value: privateTreaty
        /// </summary>
        [EnumMember(Value = "privateTreaty")]
        PrivateTreaty = 3,

        /// <summary>
        /// Enum Tender for value: tender
        /// </summary>
        [EnumMember(Value = "tender")]
        Tender = 4,

        /// <summary>
        /// Enum ExpressionOfInterest for value: expressionOfInterest
        /// </summary>
        [EnumMember(Value = "expressionOfInterest")]
        ExpressionOfInterest = 5

    }

}
