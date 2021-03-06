﻿Imports System.IO
Imports System.Net
Imports System.Net.Http.Headers

Namespace ShanXingTech.Net2
    ''' <summary>
    ''' Http请求响应
    ''' </summary>
    Public Class HttpResponse
        ''' <summary>
        ''' 是否成功
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Success As Boolean

        ''' <summary>
        ''' 请求状态
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property StatusCode As HttpStatusCode
        ''' <summary>
        ''' 响应文本
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Message As String
        ''' <summary>
        ''' 响应头
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Header As HttpResponseHeaders

        Public Sub New()
        End Sub

        Public Sub New(success As Boolean, statusCode As HttpStatusCode, message As String)
            Me.Success = success
            Me.StatusCode = statusCode
            Me.Message = message
        End Sub

        Public Sub New(success As Boolean, statusCode As HttpStatusCode, header As HttpResponseHeaders)
            Me.Success = success
            Me.StatusCode = statusCode
            Me.Message = Message
            Me.Header = header
        End Sub

        Public Sub New(success As Boolean, statusCode As HttpStatusCode, message As String, header As HttpResponseHeaders)
            Me.Success = success
            Me.StatusCode = statusCode
            Me.Message = message
            Me.Header = header
        End Sub
    End Class

End Namespace
