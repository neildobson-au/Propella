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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Domain.Api.V1.Client;
using Domain.Api.V1.Api;
// uncomment below to import models
//using Domain.Api.V1.Model;

namespace Domain.Api.V1.Test.Api
{
    /// <summary>
    ///  Class for testing ProductRatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductRatesApiTests : IDisposable
    {
        private ProductRatesApi instance;

        public ProductRatesApiTests()
        {
            instance = new ProductRatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductRatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductRatesApi
            //Assert.IsType<ProductRatesApi>(instance);
        }

        /// <summary>
        /// Test ProductsRateForNewListing
        /// </summary>
        [Fact]
        public void ProductsRateForNewListingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BookingsV2RateForNewListingRequest bookingsV2RateForNewListingRequest = null;
            //var response = instance.ProductsRateForNewListing(bookingsV2RateForNewListingRequest);
            //Assert.IsType<BookingsV2RateForNewListing>(response);
        }
    }
}