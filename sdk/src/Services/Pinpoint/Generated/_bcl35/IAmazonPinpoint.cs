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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Pinpoint.Model;

namespace Amazon.Pinpoint
{
    /// <summary>
    /// Interface for accessing Pinpoint
    ///
    /// 
    /// </summary>
    public partial interface IAmazonPinpoint : IAmazonService, IDisposable
    {

        
        #region  CreateCampaign


        /// <summary>
        /// Creates or updates a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        CreateCampaignResponse CreateCampaign(CreateCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Pinpoint.</returns>
        CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImportJob


        /// <summary>
        /// Creates or updates an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        CreateImportJobResponse CreateImportJob(CreateImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImportJob
        ///         operation.</returns>
        IAsyncResult BeginCreateImportJob(CreateImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImportJob.</param>
        /// 
        /// <returns>Returns a  CreateImportJobResult from Pinpoint.</returns>
        CreateImportJobResponse EndCreateImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSegment


        /// <summary>
        /// Used to create or update a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment service method.</param>
        /// 
        /// <returns>The response from the CreateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        CreateSegmentResponse CreateSegment(CreateSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegment
        ///         operation.</returns>
        IAsyncResult BeginCreateSegment(CreateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegment.</param>
        /// 
        /// <returns>Returns a  CreateSegmentResult from Pinpoint.</returns>
        CreateSegmentResponse EndCreateSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApnsChannel


        /// <summary>
        /// Deletes the APNs channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteApnsChannelResponse DeleteApnsChannel(DeleteApnsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteApnsChannel(DeleteApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsChannelResult from Pinpoint.</returns>
        DeleteApnsChannelResponse EndDeleteApnsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApnsSandboxChannel


        /// <summary>
        /// Delete an APNS sandbox channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteApnsSandboxChannelResponse DeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsSandboxChannelResult from Pinpoint.</returns>
        DeleteApnsSandboxChannelResponse EndDeleteApnsSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaign


        /// <summary>
        /// Deletes a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Pinpoint.</returns>
        DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailChannel


        /// <summary>
        /// Delete an email channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteEmailChannelResponse DeleteEmailChannel(DeleteEmailChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteEmailChannel(DeleteEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailChannel.</param>
        /// 
        /// <returns>Returns a  DeleteEmailChannelResult from Pinpoint.</returns>
        DeleteEmailChannelResponse EndDeleteEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventStream


        /// <summary>
        /// Deletes the event stream for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventStream
        ///         operation.</returns>
        IAsyncResult BeginDeleteEventStream(DeleteEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventStream.</param>
        /// 
        /// <returns>Returns a  DeleteEventStreamResult from Pinpoint.</returns>
        DeleteEventStreamResponse EndDeleteEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGcmChannel


        /// <summary>
        /// Deletes the GCM channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteGcmChannelResponse DeleteGcmChannel(DeleteGcmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGcmChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteGcmChannel(DeleteGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGcmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteGcmChannelResult from Pinpoint.</returns>
        DeleteGcmChannelResponse EndDeleteGcmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSegment


        /// <summary>
        /// Deletes a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// 
        /// <returns>The response from the DeleteSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSegment
        ///         operation.</returns>
        IAsyncResult BeginDeleteSegment(DeleteSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegment.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentResult from Pinpoint.</returns>
        DeleteSegmentResponse EndDeleteSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSmsChannel


        /// <summary>
        /// Delete an SMS channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        DeleteSmsChannelResponse DeleteSmsChannel(DeleteSmsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSmsChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteSmsChannel(DeleteSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteSmsChannelResult from Pinpoint.</returns>
        DeleteSmsChannelResponse EndDeleteSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApnsChannel


        /// <summary>
        /// Returns information about the APNs channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetApnsChannelResponse GetApnsChannel(GetApnsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsChannel
        ///         operation.</returns>
        IAsyncResult BeginGetApnsChannel(GetApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsChannelResult from Pinpoint.</returns>
        GetApnsChannelResponse EndGetApnsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApnsSandboxChannel


        /// <summary>
        /// Get an APNS sandbox channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetApnsSandboxChannelResponse GetApnsSandboxChannel(GetApnsSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginGetApnsSandboxChannel(GetApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsSandboxChannelResult from Pinpoint.</returns>
        GetApnsSandboxChannelResponse EndGetApnsSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationSettings


        /// <summary>
        /// Used to request the settings for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the GetApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetApplicationSettingsResponse GetApplicationSettings(GetApplicationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationSettings
        ///         operation.</returns>
        IAsyncResult BeginGetApplicationSettings(GetApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSettings.</param>
        /// 
        /// <returns>Returns a  GetApplicationSettingsResult from Pinpoint.</returns>
        GetApplicationSettingsResponse EndGetApplicationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaign


        /// <summary>
        /// Returns information about a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetCampaignResponse GetCampaign(GetCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaign
        ///         operation.</returns>
        IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from Pinpoint.</returns>
        GetCampaignResponse EndGetCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignActivities


        /// <summary>
        /// Returns information about the activity performed by a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities service method.</param>
        /// 
        /// <returns>The response from the GetCampaignActivities service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetCampaignActivitiesResponse GetCampaignActivities(GetCampaignActivitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignActivities
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignActivities(GetCampaignActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignActivities.</param>
        /// 
        /// <returns>Returns a  GetCampaignActivitiesResult from Pinpoint.</returns>
        GetCampaignActivitiesResponse EndGetCampaignActivities(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaigns


        /// <summary>
        /// Returns information about your campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns service method.</param>
        /// 
        /// <returns>The response from the GetCampaigns service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetCampaignsResponse GetCampaigns(GetCampaignsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaigns
        ///         operation.</returns>
        IAsyncResult BeginGetCampaigns(GetCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaigns.</param>
        /// 
        /// <returns>Returns a  GetCampaignsResult from Pinpoint.</returns>
        GetCampaignsResponse EndGetCampaigns(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignVersion


        /// <summary>
        /// Returns information about a specific version of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetCampaignVersionResponse GetCampaignVersion(GetCampaignVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersion
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignVersion(GetCampaignVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersion.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionResult from Pinpoint.</returns>
        GetCampaignVersionResponse EndGetCampaignVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignVersions


        /// <summary>
        /// Returns information about your campaign versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetCampaignVersionsResponse GetCampaignVersions(GetCampaignVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersions
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignVersions(GetCampaignVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersions.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionsResult from Pinpoint.</returns>
        GetCampaignVersionsResponse EndGetCampaignVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailChannel


        /// <summary>
        /// Get an email channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel service method.</param>
        /// 
        /// <returns>The response from the GetEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetEmailChannelResponse GetEmailChannel(GetEmailChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailChannel
        ///         operation.</returns>
        IAsyncResult BeginGetEmailChannel(GetEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailChannel.</param>
        /// 
        /// <returns>Returns a  GetEmailChannelResult from Pinpoint.</returns>
        GetEmailChannelResponse EndGetEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEndpoint


        /// <summary>
        /// Returns information about an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetEndpointResponse GetEndpoint(GetEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpoint
        ///         operation.</returns>
        IAsyncResult BeginGetEndpoint(GetEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpoint.</param>
        /// 
        /// <returns>Returns a  GetEndpointResult from Pinpoint.</returns>
        GetEndpointResponse EndGetEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventStream


        /// <summary>
        /// Returns the event stream for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetEventStreamResponse GetEventStream(GetEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventStream
        ///         operation.</returns>
        IAsyncResult BeginGetEventStream(GetEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventStream.</param>
        /// 
        /// <returns>Returns a  GetEventStreamResult from Pinpoint.</returns>
        GetEventStreamResponse EndGetEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGcmChannel


        /// <summary>
        /// Returns information about the GCM channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel service method.</param>
        /// 
        /// <returns>The response from the GetGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetGcmChannelResponse GetGcmChannel(GetGcmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGcmChannel
        ///         operation.</returns>
        IAsyncResult BeginGetGcmChannel(GetGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGcmChannel.</param>
        /// 
        /// <returns>Returns a  GetGcmChannelResult from Pinpoint.</returns>
        GetGcmChannelResponse EndGetGcmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportJob


        /// <summary>
        /// Returns information about an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetImportJobResponse GetImportJob(GetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from Pinpoint.</returns>
        GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportJobs


        /// <summary>
        /// Returns information about your import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetImportJobsResponse GetImportJobs(GetImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJobs
        ///         operation.</returns>
        IAsyncResult BeginGetImportJobs(GetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJobs.</param>
        /// 
        /// <returns>Returns a  GetImportJobsResult from Pinpoint.</returns>
        GetImportJobsResponse EndGetImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegment


        /// <summary>
        /// Returns information about a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// 
        /// <returns>The response from the GetSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetSegmentResponse GetSegment(GetSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegment
        ///         operation.</returns>
        IAsyncResult BeginGetSegment(GetSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegment.</param>
        /// 
        /// <returns>Returns a  GetSegmentResult from Pinpoint.</returns>
        GetSegmentResponse EndGetSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentImportJobs


        /// <summary>
        /// Returns a list of import jobs for a specific segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetSegmentImportJobsResponse GetSegmentImportJobs(GetSegmentImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentImportJobs
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentImportJobs(GetSegmentImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentImportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentImportJobsResult from Pinpoint.</returns>
        GetSegmentImportJobsResponse EndGetSegmentImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegments


        /// <summary>
        /// Used to get information about your segments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegments service method.</param>
        /// 
        /// <returns>The response from the GetSegments service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetSegmentsResponse GetSegments(GetSegmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegments operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegments
        ///         operation.</returns>
        IAsyncResult BeginGetSegments(GetSegmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegments.</param>
        /// 
        /// <returns>Returns a  GetSegmentsResult from Pinpoint.</returns>
        GetSegmentsResponse EndGetSegments(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentVersion


        /// <summary>
        /// Returns information about a segment version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetSegmentVersionResponse GetSegmentVersion(GetSegmentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersion
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentVersion(GetSegmentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersion.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionResult from Pinpoint.</returns>
        GetSegmentVersionResponse EndGetSegmentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentVersions


        /// <summary>
        /// Returns information about your segment versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetSegmentVersionsResponse GetSegmentVersions(GetSegmentVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersions
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentVersions(GetSegmentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersions.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionsResult from Pinpoint.</returns>
        GetSegmentVersionsResponse EndGetSegmentVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSmsChannel


        /// <summary>
        /// Get an SMS channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel service method.</param>
        /// 
        /// <returns>The response from the GetSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        GetSmsChannelResponse GetSmsChannel(GetSmsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSmsChannel
        ///         operation.</returns>
        IAsyncResult BeginGetSmsChannel(GetSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsChannel.</param>
        /// 
        /// <returns>Returns a  GetSmsChannelResult from Pinpoint.</returns>
        GetSmsChannelResponse EndGetSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEventStream


        /// <summary>
        /// Use to create or update the event stream for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream service method.</param>
        /// 
        /// <returns>The response from the PutEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        PutEventStreamResponse PutEventStream(PutEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventStream
        ///         operation.</returns>
        IAsyncResult BeginPutEventStream(PutEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventStream.</param>
        /// 
        /// <returns>Returns a  PutEventStreamResult from Pinpoint.</returns>
        PutEventStreamResponse EndPutEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  SendMessages


        /// <summary>
        /// Send a batch of messages
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessages service method.</param>
        /// 
        /// <returns>The response from the SendMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        SendMessagesResponse SendMessages(SendMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessages
        ///         operation.</returns>
        IAsyncResult BeginSendMessages(SendMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessages.</param>
        /// 
        /// <returns>Returns a  SendMessagesResult from Pinpoint.</returns>
        SendMessagesResponse EndSendMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApnsChannel


        /// <summary>
        /// Use to update the APNs channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateApnsChannelResponse UpdateApnsChannel(UpdateApnsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateApnsChannel(UpdateApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsChannelResult from Pinpoint.</returns>
        UpdateApnsChannelResponse EndUpdateApnsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApnsSandboxChannel


        /// <summary>
        /// Update an APNS sandbox channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateApnsSandboxChannelResponse UpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsSandboxChannelResult from Pinpoint.</returns>
        UpdateApnsSandboxChannelResponse EndUpdateApnsSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplicationSettings


        /// <summary>
        /// Used to update the settings for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationSettings
        ///         operation.</returns>
        IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from Pinpoint.</returns>
        UpdateApplicationSettingsResponse EndUpdateApplicationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaign


        /// <summary>
        /// Use to update a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Pinpoint.</returns>
        UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEmailChannel


        /// <summary>
        /// Update an email channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateEmailChannelResponse UpdateEmailChannel(UpdateEmailChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateEmailChannel(UpdateEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailChannel.</param>
        /// 
        /// <returns>Returns a  UpdateEmailChannelResult from Pinpoint.</returns>
        UpdateEmailChannelResponse EndUpdateEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Use to update an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Pinpoint.</returns>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointsBatch


        /// <summary>
        /// Use to update a batch of endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointsBatch service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateEndpointsBatchResponse UpdateEndpointsBatch(UpdateEndpointsBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointsBatch
        ///         operation.</returns>
        IAsyncResult BeginUpdateEndpointsBatch(UpdateEndpointsBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointsBatch.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointsBatchResult from Pinpoint.</returns>
        UpdateEndpointsBatchResponse EndUpdateEndpointsBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGcmChannel


        /// <summary>
        /// Use to update the GCM channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateGcmChannelResponse UpdateGcmChannel(UpdateGcmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGcmChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateGcmChannel(UpdateGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGcmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateGcmChannelResult from Pinpoint.</returns>
        UpdateGcmChannelResponse EndUpdateGcmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSegment


        /// <summary>
        /// Use to update a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment service method.</param>
        /// 
        /// <returns>The response from the UpdateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSegment
        ///         operation.</returns>
        IAsyncResult BeginUpdateSegment(UpdateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSegment.</param>
        /// 
        /// <returns>Returns a  UpdateSegmentResult from Pinpoint.</returns>
        UpdateSegmentResponse EndUpdateSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSmsChannel


        /// <summary>
        /// Update an SMS channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        UpdateSmsChannelResponse UpdateSmsChannel(UpdateSmsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSmsChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateSmsChannel(UpdateSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateSmsChannelResult from Pinpoint.</returns>
        UpdateSmsChannelResponse EndUpdateSmsChannel(IAsyncResult asyncResult);

        #endregion
        
    }
}