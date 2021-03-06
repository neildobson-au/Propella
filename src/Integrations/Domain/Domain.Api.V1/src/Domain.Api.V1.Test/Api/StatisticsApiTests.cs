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

namespace Domain.Api.V1.Test.Api
{
    /// <summary>
    ///  Class for testing StatisticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StatisticsApiTests : IDisposable
    {
        private StatisticsApi instance;

        public StatisticsApiTests()
        {
            instance = new StatisticsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StatisticsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StatisticsApi
            //Assert.IsType<StatisticsApi>(instance);
        }

        /// <summary>
        /// Test StatisticsPost
        /// </summary>
        [Fact]
        public void StatisticsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _event = null;
            //Object body = null;
            //instance.StatisticsPost(_event, body);
        }
    }
}
