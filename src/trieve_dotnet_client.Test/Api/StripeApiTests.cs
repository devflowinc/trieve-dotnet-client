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
    ///  Class for testing StripeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StripeApiTests : IDisposable
    {
        private StripeApi instance;

        public StripeApiTests()
        {
            instance = new StripeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StripeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StripeApi
            //Assert.IsType<StripeApi>(instance);
        }

        /// <summary>
        /// Test CancelSubscription
        /// </summary>
        [Fact]
        public void CancelSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tROrganization = null;
            //Guid subscriptionId = null;
            //instance.CancelSubscription(tROrganization, subscriptionId);
        }

        /// <summary>
        /// Test DirectToPaymentLink
        /// </summary>
        [Fact]
        public void DirectToPaymentLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid planId = null;
            //Guid organizationId = null;
            //instance.DirectToPaymentLink(planId, organizationId);
        }

        /// <summary>
        /// Test GetAllPlans
        /// </summary>
        [Fact]
        public void GetAllPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllPlans();
            //Assert.IsType<List<StripePlan>>(response);
        }

        /// <summary>
        /// Test UpdateSubscriptionPlan
        /// </summary>
        [Fact]
        public void UpdateSubscriptionPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tROrganization = null;
            //Guid subscriptionId = null;
            //Guid planId = null;
            //instance.UpdateSubscriptionPlan(tROrganization, subscriptionId, planId);
        }
    }
}
