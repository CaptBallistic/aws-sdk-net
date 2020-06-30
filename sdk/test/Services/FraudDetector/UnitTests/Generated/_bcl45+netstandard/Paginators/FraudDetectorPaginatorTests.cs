#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */

using Amazon.FraudDetector;
using Amazon.FraudDetector.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class FraudDetectorPaginatorTests
    {
        private static Mock<AmazonFraudDetectorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonFraudDetectorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void DescribeModelVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeModelVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeModelVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeModelVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeModelVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeModelVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeModelVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeModelVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeModelVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeModelVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeModelVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetDetectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDetectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDetectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDetectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDetectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDetectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDetectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDetectorsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDetectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDetectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDetectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetExternalModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetExternalModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetExternalModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetExternalModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetExternalModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetExternalModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetExternalModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetExternalModelsRequest>();

            var response = InstantiateClassGenerator.Execute<GetExternalModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetExternalModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetExternalModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();

            var response = InstantiateClassGenerator.Execute<GetModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetOutcomesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetOutcomesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetOutcomesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetOutcomesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetOutcomes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetOutcomes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetOutcomesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetOutcomesRequest>();

            var response = InstantiateClassGenerator.Execute<GetOutcomesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetOutcomes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetOutcomes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetRulesRequest>();

            var response = InstantiateClassGenerator.Execute<GetRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetVariablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetVariablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetVariablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetVariablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetVariables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetVariables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetVariablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetVariablesRequest>();

            var response = InstantiateClassGenerator.Execute<GetVariablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetVariables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetVariables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif