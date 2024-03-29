/*
 * Trieve API
 *
 * Trieve OpenAPI Specification. This document describes all of the operations available through the Trieve API.
 *
 * The version of the OpenAPI document: 0.5.0
 * Contact: developers@trieve.ai
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

using trieve_dotnet_client.Client;
using trieve_dotnet_client.Api;
// uncomment below to import models
//using trieve_dotnet_client.Model;

namespace trieve_dotnet_client.Test.Api
{
    /// <summary>
    ///  Class for testing InvitationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvitationApiTests : IDisposable
    {
        private InvitationApi instance;

        public InvitationApiTests()
        {
            instance = new InvitationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvitationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvitationApi
            //Assert.IsType<InvitationApi>(instance);
        }

        /// <summary>
        /// Test PostInvitation
        /// </summary>
        [Fact]
        public void PostInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tROrganization = null;
            //InvitationData invitationData = null;
            //instance.PostInvitation(tROrganization, invitationData);
        }
    }
}
