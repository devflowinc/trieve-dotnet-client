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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test DeleteUserApiKey
        /// </summary>
        [Fact]
        public void DeleteUserApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteUserApiKeyRequest deleteUserApiKeyRequest = null;
            //var response = instance.DeleteUserApiKey(deleteUserApiKeyRequest);
            //Assert.IsType<List<ApiKeyDTO>>(response);
        }

        /// <summary>
        /// Test SetUserApiKey
        /// </summary>
        [Fact]
        public void SetUserApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetUserApiKeyRequest setUserApiKeyRequest = null;
            //var response = instance.SetUserApiKey(setUserApiKeyRequest);
            //Assert.IsType<SetUserApiKeyResponse>(response);
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateUserData updateUserData = null;
            //var response = instance.UpdateUser(updateUserData);
            //Assert.IsType<SlimUser>(response);
        }
    }
}