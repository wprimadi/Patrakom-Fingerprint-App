Imports System
Imports System.Text
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.DateTime
Imports System.Data
Imports System.Data.DataSet
Imports System.Runtime.InteropServices
Imports System.Data.SQLite

Module modUtility
    Public isLogin As Boolean = False
    Public isDbConnected As Boolean = False

    'Background Image Index
    Public intBackgroundIndex As Integer = 0

    'Time parameters
    Public intWorkingDays As Integer = 0
    Public intWorkingHours As Integer = 0
    Public intBreakHours As Integer = 0
    Public strEarlyOfficeHour As String = String.Empty
    Public strStandardOfficeHour As String = String.Empty
    Public intLateMinutesTolerance As Integer = 0
    Public strLateHourTolerance As String = String.Empty
    Public intOverTimeStartHour As Integer = 0

    Const SW_HIDE As Integer = 0
    Const SW_RESTORE As Integer = 1
    Const SW_MINIMIZE As Integer = 2
    Const SW_MAXIMIZE As Integer = 3

    <DllImport("User32")> _
    Private Function ShowWindow(ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    End Function

    Public Sub ShowOSK()
        If Not IsProcessRunning("osk") Then
            Process.Start("osk.exe")
        Else
            ShowKeyboard("osk")
        End If
    End Sub

    Public Function IsProcessRunning(ByVal strProcessName As String) As Boolean
        Dim arrProcesses() As Process

        arrProcesses = Process.GetProcessesByName(strProcessName.ToString)
        If arrProcesses.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ShowKeyboard(ByVal strProcessName As String)
        
    End Sub

    Public Function MyPath() As String
        Dim ExePath As String
        Dim i As Integer
        Dim j As Integer
        Dim FolderPath As String

        ExePath = Application.ExecutablePath.ToString
        For i = 1 To Len(ExePath)
            If Mid(ExePath, i, 1) = "\" Then
                j = i
            End If
        Next

        FolderPath = Left(ExePath, j)
        If Right(FolderPath, 1) <> "\" Then
            FolderPath = FolderPath & "\"
        End If

        Return FolderPath
    End Function

    Public Function PopulateImages(ByVal strImagesPath As String) As Boolean
        Dim objDirectory As DirectoryInfo = Nothing
        Dim objFile As FileInfo = Nothing
        Dim boolRetval As Boolean = False

        Try
            Form1.lstImageFiles.Items.Clear()

            If strImagesPath.ToString.Trim <> "" Then
                objDirectory = New DirectoryInfo(strImagesPath.ToString)
                For Each objFile In objDirectory.GetFiles("*")
                    If objFile.Extension.ToString.ToUpper.Trim = ".JPG" Then
                        Form1.lstImageFiles.Items.Add(objFile.FullName.ToString)
                    ElseIf objFile.Extension.ToString.ToUpper.Trim = ".JPEG" Then
                        Form1.lstImageFiles.Items.Add(objFile.FullName.ToString)
                    ElseIf objFile.Extension.ToString.ToUpper.Trim = ".PNG" Then
                        Form1.lstImageFiles.Items.Add(objFile.FullName.ToString)
                    ElseIf objFile.Extension.ToString.ToUpper.Trim = ".GIF" Then
                        Form1.lstImageFiles.Items.Add(objFile.FullName.ToString)
                    ElseIf objFile.Extension.ToString.ToUpper.Trim = ".BMP" Then
                        Form1.lstImageFiles.Items.Add(objFile.FullName.ToString)
                    End If
                Next

                boolRetval = True
            Else
                boolRetval = False
            End If

            Return boolRetval
        Catch ex As Exception
            Return False
        Finally
            If Not objDirectory Is Nothing Then
                objDirectory = Nothing
            End If

            If Not objFile Is Nothing Then
                objFile = Nothing
            End If
        End Try
    End Function

    Public Function EncodeMD5(ByVal Source As String) As String
        Dim Bytes() As Byte
        Dim StringBuild As New StringBuilder()

        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If

        Bytes = Encoding.Default.GetBytes(Source)
        Bytes = MD5.Create().ComputeHash(Bytes)

        For x As Integer = 0 To Bytes.Length - 1
            StringBuild.Append(Bytes(x).ToString("x2"))
        Next

        Return StringBuild.ToString()
    End Function

    Public Function LoadFingerprintTemplate(ByRef objFpVer As FlexCodeSDK.FinFPVer) As Boolean
        Dim strSQL As String = String.Empty
        Dim objDataSet As New DataSet
        Dim intCounter As Integer = 0

        Try
            strSQL = "SELECT * FROM erp_employee_fingerprint"
            objDataSet = getDataSet(strSQL)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    For intCounter = 0 To (objDataSet.Tables(0).Rows.Count - 1)
                        With objDataSet.Tables(0).Rows(intCounter)
                            frmCheckin.lblMessage.Text = "Loading fingerprint database, please wait... (" & intCounter.ToString & " / " & objDataSet.Tables(0).Rows.Count.ToString & ")"
                            frmCheckin.lblMessage.Refresh()

                            objFpVer.FPLoad(.Item("employee_id").ToString, .Item("finger_id"), .Item("template"), My.Settings.SecureKey.ToString)
                        End With
                    Next
                End If
            End If

            Return True
        Catch ex As Exception
            Return False
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Function

    Public Function DatetimeUnixStyle(ByVal dtCurrentDatetime As Date) As String
        Return ((dtCurrentDatetime - New DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds).ToString
    End Function

    Public Function GetUnixTimestamp(ByVal currDate As DateTime) As Double
        'create Timespan by subtracting the value provided from the Unix Epoch
        Dim span As TimeSpan = (currDate - New DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime())
        'return the total seconds (which is a UNIX timestamp)
        Return span.TotalSeconds
    End Function

    Public Function GetDatetimeFromUnixTime(ByVal intUnixTimestamp As Double) As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(intUnixTimestamp).ToLocalTime
    End Function

    Public Function HourInSeconds(ByVal intSeconds As Double) As Double
        Return Math.Round(intSeconds / 3600, 0)
    End Function

    Public Function MinuteInSeconds(ByVal intSeconds As Double) As Double
        Return Math.Round((intSeconds - (HourInSeconds(intSeconds) * 3600)) / 60, 0)
    End Function
End Module
