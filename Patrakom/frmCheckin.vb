Imports System
Imports System.Text
Imports System.IO

Public Class frmCheckin
    Dim WithEvents objFpReg As FlexCodeSDK.FinFPReg
    Dim WithEvents objFpVer As FlexCodeSDK.FinFPVer

    Private strTemplate As String = String.Empty
    Private intSamples As Integer = 0
    Private strFpScanID As String = String.Empty
    Private objFpScanFingerNumber As FlexCodeSDK.FingerNumber = FlexCodeSDK.FingerNumber.Fn_LeftIndex

    Private Enum CheckModeEnum
        CheckIn
        CheckOut
        ShiftIn
        ShiftOut
        ReplacementShift
    End Enum

    Private Enum CheckStatusEnum
        Early
        OnTime
        Late
    End Enum

    Private Enum CheckInCodeEnum As Integer
        Absent = 0
        Working = 1
        Permit = 2
        Indisposed = 3
        Travel = 4
        Training = 5
        Training_Travel = 6
        Vacation = 7
        Holiday = 8
    End Enum

    Private Enum CheckOutCodeEnum As Integer
        Early = 0
        Overtime = 1
        Normal = 2
        ForgotCheckIn = 3
    End Enum

    Private CheckMode As CheckModeEnum = CheckModeEnum.CheckIn
    Private CheckStatus As CheckStatusEnum = CheckStatusEnum.OnTime
    Private CheckInCode As CheckInCodeEnum = CheckInCodeEnum.Absent
    Public strReason As String = String.Empty

    Private dtCurrentDateTime As DateTime = Now()
    Private dtNormalWorkTime As DateTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(strStandardOfficeHour), "HH:mm:ss"))
    Private dtEarlyWorkTime As DateTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(strEarlyOfficeHour), "HH:mm:ss"))
    Private dtActionTime As DateTime = Now
    Private dblTotalWorkHours As Double = 0
    Private dblTotalWorkDuration As Double = 0
    Private dblUnixActionDate As Double = 0
    Private dblUnixActionDatetime As Double = 0
    Private dblAdditionalDatetime As Double = 0
    Private dblLessTime As Double = 0
    Private dblOverTime As Double = 0
    Private strLastCheckInID As String = String.Empty
    Private strAdditionalInfo As String = String.Empty
    Private boolSyncStatus As Boolean = False
    Private enCheckInStatus As CheckInCodeEnum = CheckInCodeEnum.Absent
    Private enCheckOutStatus As CheckOutCodeEnum = CheckOutCodeEnum.Normal

    Private shiftWorkTime As String = String.Empty
    Private shiftWorkShift As String = String.Empty
    Private shiftWorkHours As Integer = 0


    Private Sub LoadTheme()
        If My.Settings.BackgroundMode.ToString.ToUpper.Trim = "NONE" Then
            Me.BackgroundImageLayout = ImageLayout.None
        ElseIf My.Settings.BackgroundMode.ToString.ToUpper.Trim = "TILE" Then
            Me.BackgroundImageLayout = ImageLayout.Tile
        ElseIf My.Settings.BackgroundMode.ToString.ToUpper.Trim = "CENTER" Then
            Me.BackgroundImageLayout = ImageLayout.Center
        ElseIf My.Settings.BackgroundMode.ToString.ToUpper.Trim = "STRETCH" Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf My.Settings.BackgroundMode.ToString.ToUpper.Trim = "ZOOM" Then
            Me.BackgroundImageLayout = ImageLayout.Zoom
        Else
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If

        If My.Settings.BackgroundImage.ToString.Trim <> "" Then
            If CInt(My.Settings.BackgroundImageType) = 0 Then
                timerImages.Interval = 0
                timerImages.Enabled = False

                If File.Exists(My.Settings.BackgroundImage.ToString) Then
                    Me.BackgroundImage = New Bitmap(My.Settings.BackgroundImage.ToString)
                End If
            ElseIf CInt(My.Settings.BackgroundImageType) = 1 Then
                Call PopulateImages(My.Settings.BackgroundImage.ToString)

                If Form1.lstImageFiles.Items.Count > 0 Then
                    If intBackgroundIndex > (Form1.lstImageFiles.Items.Count - 1) Then
                        intBackgroundIndex = 0
                    End If

                    Me.BackgroundImage = Image.FromFile(Form1.lstImageFiles.Items(intBackgroundIndex).ToString)
                    intBackgroundIndex += 1
                End If

                timerImages.Interval = (CInt(My.Settings.BackgroundImageSlideShowDuration) * 1000)
                timerImages.Enabled = True
            End If
        End If

        If My.Settings.ApplicationLogo.ToString.Trim <> "" Then
            companyLogo.Image = New Bitmap(My.Settings.ApplicationLogo.ToString)
        End If

        companyLogo.BackColor = My.Settings.ApplicationLogoColor1
        lblDatetime.Font = My.Settings.FontFace
        PanelControl1.BackColor = My.Settings.HeaderColor
        btnAttendance.Appearance.BackColor = My.Settings.ButtonColor1
        btnAttendance.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnDashboard.Appearance.BackColor = My.Settings.ButtonColor1
        btnDashboard.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnCheckIn.Appearance.BackColor = My.Settings.ButtonColor1
        btnCheckIn.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnCheckOut.Appearance.BackColor = My.Settings.ButtonColor1
        btnCheckOut.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnShiftIn.Appearance.BackColor = My.Settings.ButtonColor1
        btnShiftIn.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnShiftOut.Appearance.BackColor = My.Settings.ButtonColor1
        btnShiftOut.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnReplacementShift.Appearance.BackColor = My.Settings.ButtonColor1
        btnReplacementShift.Appearance.BackColor2 = My.Settings.ButtonColor2
    End Sub

    Private Sub frmCheckin_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            objFpVer.FPVerificationStop()
        Catch ex As Exception

        End Try

        Try
            objFpReg.FPRegistrationStop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StartInitForm()
        Me.Show()
        Me.Refresh()

        btnCheckIn.Visible = False
        btnCheckOut.Visible = False
        btnShiftIn.Visible = False
        btnShiftOut.Visible = False
        btnReplacementShift.Visible = False
        btnAttendance.Visible = False
        btnDashboard.Visible = False

        lblMessage.Text = "Loading fingerprint database, please wait..."
        pnlMessage.Visible = True
        pnlMessage.Refresh()
    End Sub

    Private Sub EndInitForm()
        pnlMessage.Visible = False

        btnCheckIn.Visible = True
        btnCheckOut.Visible = True
        btnShiftIn.Visible = True
        btnShiftOut.Visible = True
        btnReplacementShift.Visible = True
        btnAttendance.Visible = True
        btnDashboard.Visible = True
    End Sub

    Private Sub frmCheckin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadTheme()

        Me.Show()
        Me.Refresh()
        Application.DoEvents()

        Call StartInitForm()

        objFpVer = New FlexCodeSDK.FinFPVer
        objFpVer.AddDeviceInfo(My.Settings.DeviceSerial.ToString, My.Settings.VerificationCode.ToString, My.Settings.ActivationCode.ToString)
        'objFpVer.AddDeviceInfo("DZ00J001341", "4AK-VE2-5A1-B1R-M12", "L82B-BB66-240B-9523-6255-852Q")

        objFpReg = New FlexCodeSDK.FinFPReg
        objFpReg.FPRegistrationStart(My.Settings.SecureKey.ToString)
        'objFpReg.FPRegistrationStart("P4tr4k0m")

        If Not LoadFingerprintTemplate(objFpVer) Then
            MsgBox("Error: Unable to load fingerprint template", vbExclamation, Application.ProductName.ToString)
        End If

        Call EndInitForm()
    End Sub

    Private Function LoadNormalUserInfo(ByVal strID As String, Optional ByVal intTemplate As Integer = 0) As Boolean
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet

        Dim strEmployeeID As String = String.Empty
        Dim strFirstName As String = String.Empty
        Dim strMiddleName As String = String.Empty
        Dim strLastName As String = String.Empty
        Dim strIdType As String = String.Empty
        Dim strIdNumber As String = String.Empty
        Dim strDeptName As String = String.Empty
        Dim strEmployeeFullname As String = String.Empty

        Try
            strSQL = "SELECT a.id, a.first_name, a.middle_name, a.last_name, b.`name` AS `department_name`, UPPER(a.identity_type) AS `identity_type`, a.identity_number FROM erp_employee a LEFT JOIN company_departments b ON b.id = a.department_id WHERE a.employee_id = '" & strID.ToString.Trim & "' LIMIT 1"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    strEmployeeID = strID.ToString.Trim

                    strFirstName = objDataSet.Tables(0).Rows(0).Item("first_name").ToString
                    strMiddleName = objDataSet.Tables(0).Rows(0).Item("middle_name").ToString
                    strLastName = objDataSet.Tables(0).Rows(0).Item("last_name").ToString
                    strIdType = objDataSet.Tables(0).Rows(0).Item("identity_type").ToString.ToUpper
                    strIdNumber = objDataSet.Tables(0).Rows(0).Item("identity_number").ToString
                    strDeptName = objDataSet.Tables(0).Rows(0).Item("department_name").ToString

                    If strFirstName.ToString.Trim <> "" Then
                        strEmployeeFullname = strFirstName.ToString
                    End If

                    If strEmployeeFullname.ToString.Trim <> "" Then
                        If strMiddleName.ToString.Trim <> "" Then
                            strEmployeeFullname &= " " & strMiddleName.ToString
                        End If
                    End If

                    If strEmployeeFullname.ToString.Trim <> "" Then
                        If strLastName.ToString.Trim <> "" Then
                            strEmployeeFullname &= " " & strLastName.ToString.Trim
                        End If
                    End If

                    If intTemplate = 0 Then
                        txtEmployeeName.Text = strEmployeeFullname.ToString
                        txtIdNumber.Text = "[" & strIdType & "] " & objDataSet.Tables(0).Rows(0).Item("identity_number").ToString
                        txtDept.Text = objDataSet.Tables(0).Rows(0).Item("department_name").ToString

                        pnlMessage.Visible = False
                        pnlPhoto.Visible = True
                        pnlInfo.Visible = True
                    ElseIf intTemplate = 1 Then
                        txtEmployeeName2.Text = strEmployeeFullname.ToString
                        txtIdNumber2.Text = "[" & strIdType & "] " & objDataSet.Tables(0).Rows(0).Item("identity_number").ToString
                        txtDept2.Text = objDataSet.Tables(0).Rows(0).Item("department_name").ToString
                        txtInfo.Text = strAdditionalInfo.ToString

                        pnlMessage.Visible = False
                        pnlPhoto.Visible = True
                        pnlInfo2.Visible = True
                        txtReason.Focus()
                    End If
                Else
                    lblMessage.Text = "Error: Employee data was not found"
                End If
            Else
                lblMessage.Text = "Error: Employee data was not found"
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

    Private Sub objFpReg_FPRegistrationStatus(Status As FlexCodeSDK.RegistrationStatus) Handles objFpReg.FPRegistrationStatus
        If Status = FlexCodeSDK.RegistrationStatus.r_OK Then

        End If
    End Sub

    Private Sub objFpReg_FPRegistrationTemplate(FPTemplate As String) Handles objFpReg.FPRegistrationTemplate
        strTemplate = FPTemplate.ToString
    End Sub

    Private Sub objFpReg_FPSamplesNeeded(Samples As Short) Handles objFpReg.FPSamplesNeeded
        intSamples = Samples
    End Sub

    Private Function ProcessShiftIn(ByVal strUserScanID As String) As Boolean
        Dim strSQL As String = String.Empty

        Try
            boolSyncStatus = False

            Try
                If isServerDBConnected() Then
                    strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblAdditionalDatetime.ToString.Replace("-", "") & "', '" & enCheckInStatus & "', '" & strReason.ToString & "')"
                    If executeServerDatabaseQuery(strSQL.ToString) Then
                        boolSyncStatus = True
                    Else
                        boolSyncStatus = False
                    End If
                Else
                    boolSyncStatus = False
                End If
            Catch ex As Exception
                boolSyncStatus = False
            End Try

            If boolSyncStatus Then
                strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in, sync_status_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblAdditionalDatetime.ToString.Replace("-", "") & "', '" & enCheckInStatus & "', '" & strReason.ToString & "', 1)"
            Else
                strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in, sync_status_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblAdditionalDatetime.ToString.Replace("-", "") & "', '" & enCheckInStatus & "', '" & strReason.ToString & "', 0)"
            End If

            If executeDatabaseQuery(strSQL.ToString) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ProcessCheckIn(ByVal strUserScanID As String) As Boolean
        Dim strSQL As String = String.Empty

        Try
            boolSyncStatus = False

            Try
                If isServerDBConnected() Then
                    strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblAdditionalDatetime.ToString.Replace("-", "") & "', '" & enCheckInStatus & "', '" & strReason.ToString & "')"
                    If executeServerDatabaseQuery(strSQL.ToString) Then
                        boolSyncStatus = True
                    Else
                        boolSyncStatus = False
                    End If
                Else
                    boolSyncStatus = False
                End If
            Catch exServer As Exception
                boolSyncStatus = False
            End Try

            'strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblTotalLate.ToString & "', '" & enCheckInStatus.ToString & "', '" & strReason.ToString & "')"

            If boolSyncStatus Then
                strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in, sync_status_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblAdditionalDatetime.ToString.Replace("-", "") & "', '" & enCheckInStatus & "', '" & strReason.ToString & "', 1)"
            Else
                strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_in, late, status_in, reason_in, sync_status_in) VALUES ('" & dblUnixActionDate.ToString & "', '" & strUserScanID.ToString & "', '" & dblUnixActionDatetime.ToString & "', '" & dblAdditionalDatetime.ToString.Replace("-", "") & "', '" & enCheckInStatus & "', '" & strReason.ToString & "', 0)"
            End If

            If executeDatabaseQuery(strSQL.ToString) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function checkIsShiftExists(ByVal strEmployeeID As String, Optional ByVal strDate As String = "") As Boolean
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim boolRetval As Boolean = False

        Try
            If strDate.ToString.Trim <> "" Then
                strSQL = "SELECT work_date, work_time, work_shift, work_hours FROM erp_employee_shifts WHERE employee_id = (SELECT DISTINCT id FROM erp_employee WHERE employee_id = '" & strEmployeeID.ToString & "') AND work_date = '" & strDate.ToString & "'"
            Else
                strSQL = "SELECT work_date, work_time, work_shift, work_hours FROM erp_employee_shifts WHERE employee_id = (SELECT DISTINCT id FROM erp_employee WHERE employee_id = '" & strEmployeeID.ToString & "') AND work_date = '" & Format(Now(), "yyyy-MM-dd").ToString & "'"
            End If

            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    shiftWorkTime = objDataSet.Tables(0).Rows(0).Item("work_time").ToString
                    shiftWorkShift = objDataSet.Tables(0).Rows(0).Item("work_shift").ToString

                    If objDataSet.Tables(0).Rows(0).Item("work_hours").ToString.Trim <> "" Then
                        If IsNumeric(objDataSet.Tables(0).Rows(0).Item("work_hours").ToString) Then
                            shiftWorkHours = CInt(objDataSet.Tables(0).Rows(0).Item("work_hours").ToString)
                        Else
                            shiftWorkHours = 0
                        End If
                    Else
                        shiftWorkHours = 0
                    End If

                    boolRetval = True
                Else
                    boolRetval = False
                End If
            Else
                boolRetval = False
            End If

            Return boolRetval
        Catch ex As Exception
            Return False
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Function

    Private Function getShiftInInformation() As Boolean
        strAdditionalInfo = String.Empty

        Try
            dtNormalWorkTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(shiftWorkTime), "HH:mm:ss"))
            dtEarlyWorkTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(shiftWorkTime), "HH:mm:ss")).AddMinutes(-30)

            dblUnixActionDate = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd")))
            dblUnixActionDatetime = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd HH:mm:ss")))

            If Now.Hour < dtEarlyWorkTime.Hour Then
                dblAdditionalDatetime = 0
                dtActionTime = dtEarlyWorkTime

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Early
            ElseIf Now.Hour < dtNormalWorkTime.Hour Then
                dblAdditionalDatetime = 0
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Early
            ElseIf Now.Hour = dtNormalWorkTime.Hour And Now.Minute < dtNormalWorkTime.Minute Then
                dblAdditionalDatetime = 0
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Early
            ElseIf Now.Hour = dtNormalWorkTime.Hour And Now.Minute = dtNormalWorkTime.Minute Then
                dblAdditionalDatetime = 0
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.OnTime
            ElseIf Now.Hour = dtNormalWorkTime.Hour And Now.Minute > dtNormalWorkTime.Minute And Now.Minute < intLateMinutesTolerance Then
                dblAdditionalDatetime = CDbl(DateDiff(DateInterval.Second, Now, dtNormalWorkTime).ToString.Replace("-", ""))
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.OnTime
            ElseIf Now.Hour <= 12 Then
                dblAdditionalDatetime = CDbl(DateDiff(DateInterval.Second, Now, dtNormalWorkTime).ToString.Replace("-", ""))
                dtActionTime = Now

                strAdditionalInfo = "Late, " & DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "") & " hours " & (CInt(DateDiff(DateInterval.Minute, Now, dtNormalWorkTime).ToString.Replace("-", "")) - (CInt(DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "")) * 60)) & " minutes"

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Late
            ElseIf Now.Hour > 12 Then
                dblAdditionalDatetime = CDbl(DateDiff(DateInterval.Second, Now, dtNormalWorkTime).ToString.Replace("-", ""))
                dtActionTime = Now

                strAdditionalInfo = "Late, " & DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "") & " hours " & (CInt(DateDiff(DateInterval.Minute, Now, dtNormalWorkTime).ToString.Replace("-", "")) - (CInt(DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "")) * 60)) & " minutes"

                enCheckInStatus = CheckInCodeEnum.Absent
                CheckStatus = CheckStatusEnum.Late
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function getCheckInInformation() As Boolean
        strAdditionalInfo = String.Empty

        Try
            dtNormalWorkTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(strStandardOfficeHour), "HH:mm:ss"))
            dtEarlyWorkTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(strEarlyOfficeHour), "HH:mm:ss"))

            dblUnixActionDate = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd")))
            dblUnixActionDatetime = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd HH:mm:ss")))

            If Now.Hour < dtEarlyWorkTime.Hour Then
                dblAdditionalDatetime = 0
                dtActionTime = dtEarlyWorkTime

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Early
            ElseIf Now.Hour < dtNormalWorkTime.Hour Then
                dblAdditionalDatetime = 0
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Early
            ElseIf Now.Hour = dtNormalWorkTime.Hour And Now.Minute < dtNormalWorkTime.Minute Then
                dblAdditionalDatetime = 0
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Early
            ElseIf Now.Hour = dtNormalWorkTime.Hour And Now.Minute = dtNormalWorkTime.Minute Then
                dblAdditionalDatetime = 0
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.OnTime
            ElseIf Now.Hour = dtNormalWorkTime.Hour And Now.Minute > dtNormalWorkTime.Minute And Now.Minute < intLateMinutesTolerance Then
                dblAdditionalDatetime = CDbl(DateDiff(DateInterval.Second, Now, dtNormalWorkTime).ToString.Replace("-", ""))
                dtActionTime = Now

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.OnTime
            ElseIf Now.Hour <= 12 Then
                dblAdditionalDatetime = CDbl(DateDiff(DateInterval.Second, Now, dtNormalWorkTime).ToString.Replace("-", ""))
                dtActionTime = Now

                strAdditionalInfo = "Late, " & DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "") & " hours " & (CInt(DateDiff(DateInterval.Minute, Now, dtNormalWorkTime).ToString.Replace("-", "")) - (CInt(DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "")) * 60)) & " minutes"

                enCheckInStatus = CheckInCodeEnum.Working
                CheckStatus = CheckStatusEnum.Late
            ElseIf Now.Hour > 12 Then
                dblAdditionalDatetime = CDbl(DateDiff(DateInterval.Second, Now, dtNormalWorkTime).ToString.Replace("-", ""))
                dtActionTime = Now

                strAdditionalInfo = "Late, " & DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "") & " hours " & (CInt(DateDiff(DateInterval.Minute, Now, dtNormalWorkTime).ToString.Replace("-", "")) - (CInt(DateDiff(DateInterval.Hour, Now, dtNormalWorkTime).ToString.Replace("-", "")) * 60)) & " minutes"

                enCheckInStatus = CheckInCodeEnum.Absent
                CheckStatus = CheckStatusEnum.Late
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function getLastCheckInID(ByVal strEmployeeID As String) As String
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim strRetval As String = String.Empty

        Try
            strSQL = "SELECT * FROM " & My.Settings.AttendanceTable.ToString & " WHERE employee_id = '" & strEmployeeID.ToString & "' AND punch_in NOT NULL AND punch_out IS NULL ORDER BY id LIMIT 1"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    strRetval = objDataSet.Tables(0).Rows(0).Item("id").ToString
                Else
                    strRetval = String.Empty
                End If
            Else
                strRetval = String.Empty
            End If

            Return strRetval.ToString
        Catch ex As Exception
            Return String.Empty
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Function

    Private Function getLastCheckInTime(ByVal strRecID As String, ByVal strEmployeeID As String) As Double
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim intRetval As Double = 0

        Try
            strSQL = "SELECT punch_in FROM " & My.Settings.AttendanceTable.ToString & " WHERE id = '" & strRecID.ToString & "' AND employee_id = '" & strEmployeeID.ToString & "'"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    If objDataSet.Tables(0).Rows(0).Item("punch_in").ToString.Trim <> "" Then
                        If IsNumeric(objDataSet.Tables(0).Rows(0).Item("punch_in").ToString.Trim) Then
                            intRetval = CDbl(objDataSet.Tables(0).Rows(0).Item("punch_in").ToString.Trim)
                        Else
                            intRetval = 0
                        End If
                    Else
                        intRetval = 0
                    End If
                Else
                    intRetval = 0
                End If
            Else
                intRetval = 0
            End If

            Return intRetval
        Catch ex As Exception
            Return 0
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Function

    Private Function getShiftOutInformation() As Boolean
        strAdditionalInfo = String.Empty
        strLastCheckInID = String.Empty

        Try
            dblUnixActionDate = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd HH:mm:ss")))
            dblUnixActionDatetime = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd HH:mm:ss")))

            strLastCheckInID = getLastCheckInID(strFpScanID.ToString)

            If strLastCheckInID.ToString.Trim <> "" Then
                dblTotalWorkHours = DateDiff(DateInterval.Second, GetDatetimeFromUnixTime(getLastCheckInTime(strLastCheckInID, strFpScanID.ToString)), Now())
                dblTotalWorkDuration = (dblTotalWorkHours - (intBreakHours * 3600))
            Else

            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function getCheckOutInformation() As Boolean
        strAdditionalInfo = String.Empty
        strLastCheckInID = String.Empty

        Try
            dblUnixActionDate = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd HH:mm:ss")))
            dblUnixActionDatetime = GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd HH:mm:ss")))

            strLastCheckInID = getLastCheckInID(strFpScanID.ToString)

            If strLastCheckInID.ToString.Trim <> "" Then
                dblTotalWorkHours = DateDiff(DateInterval.Second, GetDatetimeFromUnixTime(getLastCheckInTime(strLastCheckInID, strFpScanID.ToString)), Now())
                dblTotalWorkDuration = (dblTotalWorkHours - (intBreakHours * 3600))
                'MsgBox(dblTotalWorkHours.ToString)
                'MsgBox(intWorkingHours.ToString)
                'MsgBox(dblTotalWorkDuration.ToString)

                If dblTotalWorkDuration < (intWorkingHours * 3600) Then
                    dblLessTime = ((intWorkingHours * 3600) - dblTotalWorkDuration)
                    dblOverTime = 0
                    dtActionTime = Now

                    'strAdditionalInfo = "Home Early, " & DateDiff(DateInterval.Hour, GetDatetimeFromUnixTime(dblTotalWorkHours), GetDatetimeFromUnixTime(dblTotalWorkDuration)).ToString.Replace("-", "") & " hours " & DateDiff(DateInterval.Minute, GetDatetimeFromUnixTime(dblTotalWorkHours), GetDatetimeFromUnixTime(dblTotalWorkDuration)).ToString.Replace("-", "") & " minutes"
                    strAdditionalInfo = "Home Early, " & HourInSeconds(dblLessTime).ToString.Replace("-", "") & " hours " & MinuteInSeconds(dblLessTime).ToString.Replace("-", "") & " minutes"

                    enCheckOutStatus = CheckOutCodeEnum.Early
                    CheckStatus = CheckStatusEnum.Early
                ElseIf dblTotalWorkDuration >= ((intWorkingHours + intOverTimeStartHour) * 3600) Then
                    dblLessTime = 0
                    dblOverTime = (dblTotalWorkDuration - ((intWorkingHours + intOverTimeStartHour) * 3600))
                    dtActionTime = Now

                    'strAdditionalInfo = "Home Overtime, " & DateDiff(DateInterval.Hour, GetDatetimeFromUnixTime(dblOverTime), GetDatetimeFromUnixTime(dblOverTime)).ToString.Replace("-", "") & " hours " & DateDiff(DateInterval.Minute, GetDatetimeFromUnixTime(dblTotalWorkHours), GetDatetimeFromUnixTime(dblTotalWorkDuration)).ToString.Replace("-", "") & " minutes"
                    strAdditionalInfo = "Home Overtime, " & HourInSeconds(dblOverTime).ToString.Replace("-", "") & " hours " & MinuteInSeconds(dblOverTime).ToString.Replace("-", "") & " minutes"

                    enCheckOutStatus = CheckOutCodeEnum.Overtime
                    CheckStatus = CheckStatusEnum.Late
                Else
                    dblLessTime = 0
                    dblOverTime = 0
                    dtActionTime = Now

                    strAdditionalInfo = "On Time"
                    enCheckOutStatus = CheckOutCodeEnum.Normal
                    CheckStatus = CheckStatusEnum.OnTime
                End If
            Else
                dblTotalWorkHours = DateDiff(DateInterval.Second, GetDatetimeFromUnixTime(GetUnixTimestamp(Convert.ToDateTime(Format(Now, "yyyy-MM-dd " & strStandardOfficeHour.ToString & ":00")))), Now())
                dblTotalWorkDuration = (dblTotalWorkHours - (intBreakHours * 3600))

                If dblTotalWorkDuration < (intWorkingHours * 3600) Then
                    dblLessTime = ((intWorkingHours * 3600) - dblTotalWorkDuration)
                    dblOverTime = 0
                    dtActionTime = Now

                    strAdditionalInfo = "Home Early, " & HourInSeconds(dblLessTime).ToString.Replace("-", "") & " hours " & MinuteInSeconds(dblLessTime).ToString.Replace("-", "") & " minutes"

                    enCheckOutStatus = CheckOutCodeEnum.ForgotCheckIn
                    CheckStatus = CheckStatusEnum.Early
                ElseIf dblTotalWorkDuration >= ((intWorkingHours + intOverTimeStartHour) * 3600) Then
                    dblLessTime = 0
                    dblOverTime = (dblTotalWorkDuration - ((intWorkingHours + intOverTimeStartHour) * 3600))
                    dtActionTime = Now

                    strAdditionalInfo = "Home Overtime, " & HourInSeconds(dblOverTime).ToString.Replace("-", "") & " hours " & MinuteInSeconds(dblOverTime).ToString.Replace("-", "") & " minutes"

                    enCheckOutStatus = CheckOutCodeEnum.ForgotCheckIn
                    CheckStatus = CheckStatusEnum.Late
                Else
                    dblLessTime = 0
                    dblOverTime = 0
                    dtActionTime = Now

                    strAdditionalInfo = "On Time"
                    enCheckOutStatus = CheckOutCodeEnum.ForgotCheckIn
                    CheckStatus = CheckStatusEnum.OnTime
                End If
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub objFpVer_FPVerificationID(ID As String, FingerNr As FlexCodeSDK.FingerNumber) Handles objFpVer.FPVerificationID
        strFpScanID = ID
        objFpScanFingerNumber = FingerNr
    End Sub

    Private Sub btnReason_Click(sender As System.Object, e As System.EventArgs) Handles btnReason.Click
        If txtReason.Text.ToString.Trim <> "" Then
            strReason = txtReason.Text

            If CheckMode = CheckModeEnum.CheckIn Then
                If ProcessCheckIn(strFpScanID) Then
                    Call HideAndResetAll()
                Else
                    MsgBox("Error: Cannot perform check-in operation", vbExclamation, Application.ProductName.ToString)
                End If
            ElseIf CheckMode = CheckModeEnum.CheckOut Then
                If CheckStatus = CheckStatusEnum.Early Or CheckStatus = CheckStatusEnum.Late Then
                    If strLastCheckInID.ToString.Trim <> "" Then
                        If ProcessCheckOut(strFpScanID.ToString, strLastCheckInID.ToString, 0) Then
                            Call HideAndResetAll()
                        Else
                            MsgBox("Error: Cannot perform check-out operation", vbExclamation, Application.ProductName.ToString)
                        End If
                    Else
                        If ProcessCheckOut(strFpScanID.ToString, strLastCheckInID.ToString, 1) Then
                            Call HideAndResetAll()
                        Else
                            MsgBox("Error: Cannot perform check-out operation", vbExclamation, Application.ProductName.ToString)
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Please fill in the blanks", vbExclamation, Application.ProductName.ToString)
        End If
    End Sub

    Private Function ProcessCheckOut(ByVal strEmployeeID As String, Optional ByVal strRecID As String = "", Optional ByVal intSaveMethod As Integer = 0) As Boolean
        Dim strSQL As String = String.Empty
        Dim boolRetval As Boolean = False
        Dim intSyncStatus As Integer = 0

        Try
            Try
                If isServerDBConnected() Then
                    If intSaveMethod = 0 Then
                        strSQL = "UPDATE " & My.Settings.AttendanceTable & " SET punch_out = '" & dblUnixActionDate.ToString & "', duration = '" & dblTotalWorkDuration.ToString & "', lesstime = '" & dblLessTime.ToString & "', overtime = '" & dblOverTime.ToString & "', status_out = '" & enCheckOutStatus & "', reason_out = '" & strReason.ToString & "' WHERE id = '" & strRecID.ToString & "' AND employee_id = '" & strEmployeeID.ToString & "'"
                    Else
                        strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_out, duration, lesstime, overtime, status_out, reason_out) VALUES ('" & dblUnixActionDate.ToString & "', '" & strEmployeeID.ToString & "', '" & dblUnixActionDate.ToString & "', 0, 0, 0, '" & enCheckOutStatus & "', '" & strReason.ToString & "')"
                    End If

                    If executeServerDatabaseQuery(strSQL.ToString) Then
                        intSyncStatus = 1
                    Else
                        intSyncStatus = 0
                    End If
                Else
                    intSyncStatus = 0
                End If
            Catch exServer As Exception
                intSyncStatus = 0
            End Try

            If intSaveMethod = 0 Then
                strSQL = "UPDATE " & My.Settings.AttendanceTable & " SET punch_out = '" & dblUnixActionDate.ToString & "', duration = '" & dblTotalWorkDuration.ToString & "', lesstime = '" & dblLessTime.ToString & "', overtime = '" & dblOverTime.ToString & "', status_out = '" & enCheckOutStatus & "', reason_out = '" & strReason.ToString & "', sync_status_out = " & intSyncStatus.ToString & " WHERE id = '" & strRecID.ToString & "' AND employee_id = '" & strEmployeeID.ToString & "'"
            Else
                enCheckOutStatus = CheckOutCodeEnum.ForgotCheckIn
                strSQL = "INSERT INTO " & My.Settings.AttendanceTable & " (id, employee_id, punch_out, duration, lesstime, overtime, status_out, reason_out, sync_status_out) VALUES ('" & dblUnixActionDate.ToString & "', '" & strEmployeeID.ToString & "', '" & dblUnixActionDate.ToString & "', 0, 0, 0, '" & enCheckOutStatus & "', '" & strReason.ToString & "', " & intSyncStatus.ToString & ")"
            End If

            If executeDatabaseQuery(strSQL.ToString) Then
                boolRetval = True
            Else
                boolRetval = False
            End If

            Return boolRetval
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub objFpVer_FPVerificationStatus(Status As FlexCodeSDK.VerificationStatus) Handles objFpVer.FPVerificationStatus
        If Status = FlexCodeSDK.VerificationStatus.v_OK Then
            lblMessage.Text = "OK"

            'Set to initial default value
            strReason = String.Empty
            dtCurrentDateTime = Now()
            dtNormalWorkTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(strStandardOfficeHour), "HH:mm:ss"))
            dtEarlyWorkTime = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime(strEarlyOfficeHour), "HH:mm:ss"))
            dtActionTime = Now()
            dblUnixActionDate = 0
            dblUnixActionDatetime = 0
            dblAdditionalDatetime = 0
            strAdditionalInfo = String.Empty
            boolSyncStatus = False
            enCheckInStatus = CheckInCodeEnum.Absent

            If CheckMode = CheckModeEnum.CheckIn Then '====> Check In
                If getCheckInInformation() Then
                    If CheckStatus = CheckStatusEnum.Early Or CheckStatus = CheckStatusEnum.OnTime Then
                        If LoadNormalUserInfo(strFpScanID.ToString.Trim) Then
                            If Not ProcessCheckIn(strFpScanID.ToString) Then
                                MsgBox("Error: Cannot perform check-in operation", vbExclamation, Application.ProductName.ToString)
                            End If
                        Else
                            MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                            pnlMessage.Text = "Error: Cannot reading user information"
                        End If
                    ElseIf CheckStatus = CheckStatusEnum.Late Then
                        If Not LoadNormalUserInfo(strFpScanID.ToString.Trim, 1) Then
                            MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                            pnlMessage.Text = "Error: Cannot reading user information"
                        End If
                    End If
                Else
                    MsgBox("Error: Cannot get check-in information", vbExclamation, Application.ProductName.ToString)
                End If
            ElseIf CheckMode = CheckModeEnum.CheckOut Then '====> Check Out
                If getCheckOutInformation() Then
                    If CheckStatus = CheckStatusEnum.Early Then
                        If Not LoadNormalUserInfo(strFpScanID.ToString.Trim, 1) Then
                            MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                            pnlMessage.Text = "Error: Cannot reading user information"
                        End If
                    ElseIf CheckStatus = CheckStatusEnum.Late Then
                        If Not LoadNormalUserInfo(strFpScanID.ToString.Trim, 1) Then
                            MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                            pnlMessage.Text = "Error: Cannot reading user information"
                        End If
                    ElseIf CheckStatus = CheckStatusEnum.OnTime Then
                        If LoadNormalUserInfo(strFpScanID.ToString.Trim) Then
                            If strLastCheckInID.ToString.Trim <> "" Then
                                If Not ProcessCheckOut(strFpScanID.ToString, strLastCheckInID.ToString, 0) Then
                                    MsgBox("Error: Cannot perform check-out operation", vbExclamation, Application.ProductName.ToString)
                                End If
                            Else
                                If Not ProcessCheckOut(strFpScanID.ToString, strLastCheckInID.ToString, 1) Then
                                    MsgBox("Error: Cannot perform check-out operation", vbExclamation, Application.ProductName.ToString)
                                End If
                            End If
                        Else
                            MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                            pnlMessage.Text = "Error: Cannot reading user information"
                        End If
                    End If
                Else
                    MsgBox("Error: Cannot get check-out information", vbExclamation, Application.ProductName.ToString)
                End If
            ElseIf CheckMode = CheckModeEnum.ShiftIn Then '====> Shift In
                If checkIsShiftExists(strFpScanID.ToString) Then
                    If getShiftInInformation() Then
                        If CheckStatus = CheckStatusEnum.Early Or CheckStatus = CheckStatusEnum.OnTime Then
                            If LoadNormalUserInfo(strFpScanID.ToString.Trim) Then
                                If Not ProcessShiftIn(strFpScanID.ToString) Then
                                    MsgBox("Error: Cannot perform shift-in operation", vbExclamation, Application.ProductName.ToString)
                                End If
                            Else
                                MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                                pnlMessage.Text = "Error: Cannot reading user information"
                            End If
                        ElseIf CheckStatus = CheckStatusEnum.Late Then
                            If Not LoadNormalUserInfo(strFpScanID.ToString.Trim, 1) Then
                                MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                                pnlMessage.Text = "Error: Cannot reading user information"
                            End If
                        End If
                    Else
                        MsgBox("Error: Cannot get shift-in information", vbExclamation, Application.ProductName.ToString)
                    End If
                Else
                    lblMessage.Text = "Shift schedul does not found!"
                    MsgBox("Shift schedule does not found!", vbExclamation, Application.ProductName.ToString)
                End If
            ElseIf CheckMode = CheckModeEnum.ShiftOut Then '====> Shift Out

            ElseIf CheckMode = CheckModeEnum.ReplacementShift Then

            End If
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Then
            lblMessage.Text = "Fingerprint do not match!"
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
            lblMessage.Text = "Verifying fingerprint, please wait..."
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDatetime.Text = Format(Now(), "dddd, dd MMM yyyy - HH:mm:ss tt")
        Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)

        'Check server database connection state
        If isDbConnected Then
            ConnectionStatus.Image = My.Resources.connected
        Else
            ConnectionStatus.Image = My.Resources.disconnected
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

    Private Sub StartCheck()
        btnCheckIn.Visible = False
        btnCheckOut.Visible = False
        btnShiftIn.Visible = False
        btnShiftOut.Visible = False
        btnReplacementShift.Visible = False

        lblMessage.Text = "Please put your finger to scanner"
        pnlMessage.Visible = True
        pnlMessage.Refresh()
    End Sub

    Private Sub btnCheckIn_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckIn.Click
        CheckMode = CheckModeEnum.CheckIn
        Call StartCheck()
        objFpVer.FPVerificationStart()
    End Sub

    Private Sub btnCheckOut_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckOut.Click
        CheckMode = CheckModeEnum.CheckOut
        Call StartCheck()
        objFpVer.FPVerificationStart()
    End Sub

    Private Sub HideAndResetAll()
        Try
            pnlPhoto.Visible = False
            pnlInfo.Visible = False
            pnlInfo2.Visible = False
            pnlMessage.Visible = True
            btnAttendance.Visible = True
            btnDashboard.Visible = True
            Application.DoEvents()

            If Not LoadFingerprintTemplate(objFpVer) Then
                MsgBox("Error: Unable to load fingerprint template", vbExclamation, Application.ProductName.ToString)
            End If

            Call EndInitForm()
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAttendance_Click(sender As System.Object, e As System.EventArgs) Handles btnAttendance.Click
        Call HideAndResetAll()
    End Sub

    Private Sub companyLogo_Click(sender As System.Object, e As System.EventArgs) Handles companyLogo.Click
        Try
            objFpVer.FPVerificationStop()
        Catch ex As Exception

        End Try

        frmLogin.ShowDialog()
        frmLogin.Dispose()

        If isLogin Then
            frmCP.ShowDialog()
            frmCP.Dispose()
        End If
    End Sub

    Private Sub timerImages_Tick(sender As Object, e As EventArgs) Handles timerImages.Tick
        If Form1.lstImageFiles.Items.Count > 0 Then
            If intBackgroundIndex > (Form1.lstImageFiles.Items.Count - 1) Then
                intBackgroundIndex = 0
            End If

            Me.BackgroundImage = Image.FromFile(Form1.lstImageFiles.Items(intBackgroundIndex).ToString)
            intBackgroundIndex += 1
        End If
    End Sub

    Private Sub txtReason_Click(sender As Object, e As EventArgs) Handles txtReason.Click
        Call ShowOSK()
    End Sub

    Private Sub btnShiftIn_Click(sender As Object, e As EventArgs) Handles btnShiftIn.Click
        CheckMode = CheckModeEnum.ShiftIn
        Call StartCheck()
        objFpVer.FPVerificationStart()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        strFpScanID = "666"

        If checkIsShiftExists(strFpScanID.ToString) Then
            If getShiftInInformation() Then
                If CheckStatus = CheckStatusEnum.Early Or CheckStatus = CheckStatusEnum.OnTime Then
                    If LoadNormalUserInfo(strFpScanID.ToString.Trim) Then
                        If Not ProcessShiftIn(strFpScanID.ToString) Then
                            MsgBox("Error: Cannot perform shift-in operation", vbExclamation, Application.ProductName.ToString)
                        End If
                    Else
                        MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                        pnlMessage.Text = "Error: Cannot reading user information"
                    End If
                ElseIf CheckStatus = CheckStatusEnum.Late Then
                    If Not LoadNormalUserInfo(strFpScanID.ToString.Trim, 1) Then
                        MsgBox("Error: Cannot reading user information", vbExclamation, Application.ProductName.ToString)
                        pnlMessage.Text = "Error: Cannot reading user information"
                    End If
                End If
            Else
                MsgBox("Error: Cannot get shift-in information", vbExclamation, Application.ProductName.ToString)
            End If
        Else
            lblMessage.Text = "Shift schedul does not found!"
            MsgBox("Shift schedule does not found!", vbExclamation, Application.ProductName.ToString)
        End If
    End Sub
End Class