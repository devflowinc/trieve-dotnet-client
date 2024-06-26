/*
 * Trieve API
 *
 * Trieve OpenAPI Specification. This document describes all of the operations available through the Trieve API.
 *
 * The version of the OpenAPI document: 0.5.0
 * Contact: developers@trieve.ai
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using trieve_dotnet_client.Model;
using trieve_dotnet_client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace trieve_dotnet_client.Test.Model
{
    /// <summary>
    ///  Class for testing RecommendChunksRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RecommendChunksRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RecommendChunksRequest
        //private RecommendChunksRequest instance;

        public RecommendChunksRequestTests()
        {
            // TODO uncomment below to create an instance of RecommendChunksRequest
            //instance = new RecommendChunksRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecommendChunksRequest
        /// </summary>
        [Fact]
        public void RecommendChunksRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RecommendChunksRequest
            //Assert.IsType<RecommendChunksRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Filters'
        /// </summary>
        [Fact]
        public void FiltersTest()
        {
            // TODO unit test for the property 'Filters'
        }

        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

        /// <summary>
        /// Test the property 'NegativeChunkIds'
        /// </summary>
        [Fact]
        public void NegativeChunkIdsTest()
        {
            // TODO unit test for the property 'NegativeChunkIds'
        }

        /// <summary>
        /// Test the property 'NegativeTrackingIds'
        /// </summary>
        [Fact]
        public void NegativeTrackingIdsTest()
        {
            // TODO unit test for the property 'NegativeTrackingIds'
        }

        /// <summary>
        /// Test the property 'PositiveChunkIds'
        /// </summary>
        [Fact]
        public void PositiveChunkIdsTest()
        {
            // TODO unit test for the property 'PositiveChunkIds'
        }

        /// <summary>
        /// Test the property 'PositiveTrackingIds'
        /// </summary>
        [Fact]
        public void PositiveTrackingIdsTest()
        {
            // TODO unit test for the property 'PositiveTrackingIds'
        }
    }
}
