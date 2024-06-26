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
    ///  Class for testing FileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FileApiTests : IDisposable
    {
        private FileApi instance;

        public FileApiTests()
        {
            instance = new FileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FileApi
            //Assert.IsType<FileApi>(instance);
        }

        /// <summary>
        /// Test DeleteFileHandler
        /// </summary>
        [Fact]
        public void DeleteFileHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tRDataset = null;
            //Guid fileId = null;
            //bool deleteChunks = null;
            //instance.DeleteFileHandler(tRDataset, fileId, deleteChunks);
        }

        /// <summary>
        /// Test GetDatasetFilesHandler
        /// </summary>
        [Fact]
        public void GetDatasetFilesHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tRDataset = null;
            //Guid datasetId = null;
            //long page = null;
            //var response = instance.GetDatasetFilesHandler(tRDataset, datasetId, page);
            //Assert.IsType<List<File>>(response);
        }

        /// <summary>
        /// Test GetFileHandler
        /// </summary>
        [Fact]
        public void GetFileHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tRDataset = null;
            //Guid fileId = null;
            //var response = instance.GetFileHandler(tRDataset, fileId);
            //Assert.IsType<FileDTO>(response);
        }

        /// <summary>
        /// Test UploadFileHandler
        /// </summary>
        [Fact]
        public void UploadFileHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tRDataset = null;
            //UploadFileData uploadFileData = null;
            //var response = instance.UploadFileHandler(tRDataset, uploadFileData);
            //Assert.IsType<UploadFileResult>(response);
        }
    }
}
