Imports System
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Data
Imports System.Data.DataSet
Imports System.Data.SQLite
Imports MySql
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Entity
Imports MySql.Data.Types

Module modDatabase
    Public strServerConnectionString As String = String.Empty
    Public objServerConnection As MySqlConnection

    Public strDbServerIp As String = String.Empty
    Public strDbServerPort As String = String.Empty
    Public strDbName As String = String.Empty
    Public strDbUsername As String = String.Empty
    Public strDbPassword As String = String.Empty

    Public strConnectionString As String = String.Empty
    Public objConnection As SQLiteConnection

    Public Function openServerDatabaseConnection(ByVal strCurrentConnectionString As String) As Boolean
        Try
            objServerConnection = New MySqlConnection(strCurrentConnectionString.ToString)
            MySqlConnection.ClearAllPools()
            objServerConnection.Open()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function closeServerDatabaseConnection() As Boolean
        Try
            If objServerConnection.State = ConnectionState.Connecting Or objServerConnection.State = ConnectionState.Executing Or objServerConnection.State = ConnectionState.Fetching Or objServerConnection.State = ConnectionState.Open Then
                objServerConnection.Close()
                MySqlConnection.ClearAllPools()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function isServerDBConnected() As Boolean
        Try
            'If My.Computer.Network.Ping(strDbServerIp.ToString) Then
            '    If objServerConnection.State = ConnectionState.Open Then
            '        Return True
            '    Else
            '        Return False
            '    End If
            'Else
            '    Return False
            'End If

            If objServerConnection.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
        'Try
        '    If objServerConnection.State = ConnectionState.Broken Or objServerConnection.State = ConnectionState.Closed Then
        '        Return False
        '    Else
        '        Return True
        '    End If
        'Catch ex As Exception
        '    Return False
        'End Try
    End Function

    Public Function executeServerDatabaseQuery(ByVal strQuery As String) As Boolean
        Dim objCmd As New MySqlCommand
        Dim boolRetval As Boolean = False

        Try
            If strQuery.ToString.Trim <> "" Then
                objCmd.Connection = objServerConnection
                objCmd.CommandText = strQuery.ToString
                objCmd.CommandType = CommandType.Text
                objCmd.ExecuteNonQuery()

                boolRetval = True
            Else
                boolRetval = False
            End If

            Return boolRetval
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        Finally
            If Not objCmd Is Nothing Then
                objCmd.Dispose()
                objCmd = Nothing
            End If
        End Try
    End Function

    Public Function getServerDataSet(ByVal strQuery As String) As DataSet
        Dim objDataSet As New DataSet
        Dim objCmd As New MySqlCommand
        Dim objAdapter As New MySqlDataAdapter

        Try
            If strQuery.ToString.Trim <> "" Then
                objCmd.Connection = objServerConnection
                objCmd.CommandText = strQuery.ToString
                objCmd.CommandType = CommandType.Text
                objAdapter.SelectCommand = objCmd
                objAdapter.Fill(objDataSet)
            End If

            Return objDataSet
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
            Return objDataSet
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If

            If Not objCmd Is Nothing Then
                objCmd.Dispose()
                objCmd = Nothing
            End If

            If Not objAdapter Is Nothing Then
                objAdapter.Dispose()
                objAdapter = Nothing
            End If
        End Try
    End Function

    Public Function openDatabaseConnection(ByVal strCurrentConnectionString As String) As Boolean
        Try
            objConnection = New SQLiteConnection(strCurrentConnectionString.ToString)
            objConnection.Open()
            Return True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
            Return False
        End Try
    End Function

    Public Function closeDatabaseConnection() As Boolean
        Try
            If objConnection.State = ConnectionState.Connecting Or objConnection.State = ConnectionState.Executing Or objConnection.State = ConnectionState.Fetching Or objConnection.State = ConnectionState.Open Then
                objConnection.Clone()
                SQLiteConnection.ClearAllPools()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function executeDatabaseQuery(ByVal strQuery As String) As Boolean
        Dim objCmd As New SQLiteCommand
        Dim boolRetval As Boolean = False

        Try
            If strQuery.ToString.Trim <> "" Then
                objCmd.Connection = objConnection
                objCmd.CommandText = strQuery.ToString
                objCmd.CommandType = CommandType.Text
                objCmd.ExecuteNonQuery()

                boolRetval = True
            Else
                boolRetval = False
            End If

            Return boolRetval
        Catch ex As Exception
            MsgBox(ex.Message.ToString & vbCrLf & strQuery.ToString)
            Return False
        Finally
            If Not objCmd Is Nothing Then
                objCmd.Dispose()
                objCmd = Nothing
            End If
        End Try
    End Function

    Public Function getDataSet(ByVal strQuery As String) As DataSet
        Dim objDataSet As New DataSet
        Dim objCmd As New SQLiteCommand
        Dim objAdapter As New SQLiteDataAdapter

        Try
            If strQuery.ToString.Trim <> "" Then
                objCmd.Connection = objConnection
                objCmd.CommandText = strQuery.ToString
                objCmd.CommandType = CommandType.Text
                objAdapter.SelectCommand = objCmd
                objAdapter.Fill(objDataSet)
            End If

            Return objDataSet
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
            Return objDataSet
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If

            If Not objCmd Is Nothing Then
                objCmd.Dispose()
                objCmd = Nothing
            End If

            If Not objAdapter Is Nothing Then
                objAdapter.Dispose()
                objAdapter = Nothing
            End If
        End Try
    End Function
End Module
