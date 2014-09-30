Imports System
Imports System.Drawing
Imports System.Drawing.Image
Imports System.IO
Imports System.Text
Imports Microsoft
Imports Microsoft.VisualBasic
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins

Public Class frmRegUser

    Dim WithEvents objFpReg As FlexCodeSDK.FinFPReg
    Dim WithEvents objFpVer As FlexCodeSDK.FinFPVer

    Private strTemplate As String = String.Empty
    Private intSamples As Integer = 0
    Private strFpScanID As String = String.Empty
    Private objFpScanFingerNumber As FlexCodeSDK.FingerNumber = FlexCodeSDK.FingerNumber.Fn_RightIndex
    Private intFingerID As Integer = 0

    Private strEmployeeID As String = String.Empty
    Private isScreenAssignedToEmployee As Boolean = False

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
        btnExitSetting.Appearance.BackColor = My.Settings.ButtonColor1
        btnExitSetting.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnDashboard.Appearance.BackColor = My.Settings.ButtonColor1
        btnDashboard.Appearance.BackColor2 = My.Settings.ButtonColor2
    End Sub

    Private Sub frmRegUser_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            objFpVer.FPVerificationStop()
        Catch ex As Exception

        End Try

        Try
            objFpReg.FPRegistrationStop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmRegUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadTheme()
        Call SetFingerActive(1)
        Call HideAll()

        pbIdicator1.BackColor = Color.DarkGreen
        pbIdicator2.BackColor = Color.DarkGreen
        pbIdicator3.BackColor = Color.DarkGreen
        pbIdicator4.BackColor = Color.DarkGreen
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Metropolis")
    End Sub

    Private Sub SetFingerActive(ByVal intFingerIndex As Integer)
        FP1.BackColor = Color.DarkGray
        FP2.BackColor = Color.DarkGray
        FP3.BackColor = Color.DarkGray
        FP4.BackColor = Color.DarkGray
        FP5.BackColor = Color.DarkGray
        FP6.BackColor = Color.DarkGray
        FP7.BackColor = Color.DarkGray
        FP8.BackColor = Color.DarkGray
        FP9.BackColor = Color.DarkGray
        FP10.BackColor = Color.DarkGray

        If intFingerIndex = 1 Then
            FP1.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_RightIndex
            intFingerID = 6
        ElseIf intFingerIndex = 2 Then
            FP2.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_RightMiddle
            intFingerID = 7
        ElseIf intFingerIndex = 3 Then
            FP3.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_RightRing
            intFingerID = 8
        ElseIf intFingerIndex = 4 Then
            FP4.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_RightPinkie
            intFingerID = 9
        ElseIf intFingerIndex = 5 Then
            FP5.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_RightThumb
            intFingerID = 5
        ElseIf intFingerIndex = 6 Then
            FP6.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_LeftThumb
            intFingerID = 4
        ElseIf intFingerIndex = 7 Then
            FP7.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_LeftPinkie
            intFingerID = 0
        ElseIf intFingerIndex = 8 Then
            FP8.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_LeftRing
            intFingerID = 1
        ElseIf intFingerIndex = 9 Then
            FP9.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_LeftMiddle
            intFingerID = 2
        ElseIf intFingerIndex = 10 Then
            FP10.BackColor = Color.Red
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_LeftIndex
            intFingerID = 3
        Else
            objFpScanFingerNumber = FlexCodeSDK.FingerNumber.Fn_None
            intFingerID = 10
        End If
    End Sub

    Private Sub FP1_Click(sender As System.Object, e As System.EventArgs) Handles FP1.Click
        Call SetFingerActive(1)
    End Sub

    Private Sub FP2_Click(sender As System.Object, e As System.EventArgs) Handles FP2.Click
        Call SetFingerActive(2)
    End Sub

    Private Sub FP3_Click(sender As System.Object, e As System.EventArgs) Handles FP3.Click
        Call SetFingerActive(3)
    End Sub

    Private Sub FP4_Click(sender As System.Object, e As System.EventArgs) Handles FP4.Click
        Call SetFingerActive(4)
    End Sub

    Private Sub FP5_Click(sender As System.Object, e As System.EventArgs) Handles FP5.Click
        Call SetFingerActive(5)
    End Sub

    Private Sub FP6_Click(sender As System.Object, e As System.EventArgs) Handles FP6.Click
        Call SetFingerActive(6)
    End Sub

    Private Sub FP7_Click(sender As System.Object, e As System.EventArgs) Handles FP7.Click
        Call SetFingerActive(7)
    End Sub

    Private Sub FP8_Click(sender As System.Object, e As System.EventArgs) Handles FP8.Click
        Call SetFingerActive(8)
    End Sub

    Private Sub FP9_Click(sender As System.Object, e As System.EventArgs) Handles FP9.Click
        Call SetFingerActive(9)
    End Sub

    Private Sub FP10_Click(sender As System.Object, e As System.EventArgs) Handles FP10.Click
        Call SetFingerActive(10)
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

    Private Sub HideAll()
        FP1.Visible = False
        FP2.Visible = False
        FP3.Visible = False
        FP4.Visible = False
        FP5.Visible = False
        FP6.Visible = False
        FP7.Visible = False
        FP8.Visible = False
        FP9.Visible = False
        FP10.Visible = False
        PanelControl3.Visible = False
        PanelControl4.Visible = False
    End Sub

    Private Sub ShowAll()
        FP1.Visible = True
        FP2.Visible = True
        FP3.Visible = True
        FP4.Visible = True
        FP5.Visible = True
        FP6.Visible = True
        FP7.Visible = True
        FP8.Visible = True
        FP9.Visible = True
        FP10.Visible = True
        PanelControl3.Visible = True
        PanelControl4.Visible = True
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet

        Dim strFirstName As String = String.Empty
        Dim strMiddleName As String = String.Empty
        Dim strLastName As String = String.Empty
        Dim strIdType As String = String.Empty
        Dim strIdNumber As String = String.Empty
        Dim strDeptName As String = String.Empty
        Dim strEmployeeFullname As String = String.Empty

        strEmployeeID = String.Empty
        isScreenAssignedToEmployee = False

        Try
            strSQL = "SELECT a.id, a.first_name, a.middle_name, a.last_name, b.`name` AS `department_name`, UPPER(a.identity_type) AS `identity_type`, a.identity_number FROM erp_employee a LEFT JOIN company_departments b ON b.id = a.department_id WHERE a.employee_id = '" & txtEmployeeID.Text.ToString.Trim & "' LIMIT 1"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    strEmployeeID = txtEmployeeID.Text.ToString.Trim
                    isScreenAssignedToEmployee = True

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

                    txtEmployeeName.Text = strEmployeeFullname.ToString
                    txtIdNumber.Text = "[" & strIdType & "] " & objDataSet.Tables(0).Rows(0).Item("identity_number").ToString
                    txtDept.Text = objDataSet.Tables(0).Rows(0).Item("department_name").ToString

                    objFpVer = New FlexCodeSDK.FinFPVer
                    objFpVer.AddDeviceInfo(My.Settings.DeviceSerial.ToString, My.Settings.VerificationCode.ToString, My.Settings.ActivationCode.ToString)

                    objFpReg = New FlexCodeSDK.FinFPReg
                    objFpReg.DeviceInfo(My.Settings.DeviceSerial.ToString, My.Settings.VerificationCode.ToString, My.Settings.ActivationCode.ToString)
                    objFpReg.PictureSamplePath = MyPath() & "tmp_finger_scan.bmp"
                    objFpReg.PictureSampleHeight = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(picFingerprint.Height)
                    objFpReg.PictureSampleWidth = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(picFingerprint.Width)
                    objFpReg.FPRegistrationStart(My.Settings.SecureKey.ToString)

                    Call ShowAll()
                Else
                    strEmployeeID = String.Empty
                    isScreenAssignedToEmployee = False

                    MsgBox("Employee ID was not found", vbExclamation, Application.ProductName.ToString)
                    txtEmployeeID.Focus()
                    txtEmployeeID.SelectionStart = 0
                    txtEmployeeID.SelectionLength = Len(txtEmployeeID.Text)

                    Call HideAll()
                End If
            Else
                strEmployeeID = String.Empty
                isScreenAssignedToEmployee = False

                MsgBox("Employee ID was not found", vbExclamation, Application.ProductName.ToString)
                txtEmployeeID.Focus()
                txtEmployeeID.SelectionStart = 0
                txtEmployeeID.SelectionLength = Len(txtEmployeeID.Text)

                Call HideAll()
            End If
        Catch ex As Exception
            strEmployeeID = String.Empty
            isScreenAssignedToEmployee = False

            Call HideAll()

            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Sub

    Private Sub objFpReg_FPRegistrationImage() Handles objFpReg.FPRegistrationImage
        If File.Exists(MyPath() & "tmp_finger_scan.bmp") Then
            'picFingerprint.BackgroundImage = Image.FromFile(MyPath() & "tmp_finger_scan.bmp")
            Dim imgFile As System.IO.FileStream = New System.IO.FileStream(MyPath() & "tmp_finger_scan.bmp", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite)
            Dim fileBytes(CInt(imgFile.Length)) As Byte
            imgFile.Read(fileBytes, 0, fileBytes.Length)
            imgFile.Close()
            Dim ms As System.IO.MemoryStream = New MemoryStream(fileBytes)
            picFingerprint.BackgroundImage = Image.FromStream(ms)
        End If
    End Sub

    Private Sub objFpReg_FPRegistrationStatus(Status As FlexCodeSDK.RegistrationStatus) Handles objFpReg.FPRegistrationStatus
        Dim strSQL As String = String.Empty

        If Status = FlexCodeSDK.RegistrationStatus.r_OK Then
            Try
                strSQL = "INSERT INTO " & My.Settings.FingerprintTable & " (employee_id, template, finger_id) VALUES ('" & strEmployeeID.ToString & "', '" & strTemplate.ToString & "'," & intFingerID.ToString & ")"
                If executeDatabaseQuery(strSQL.ToString) Then
                    MsgBox("Current fingerprint template saved sucessfully", vbInformation, Application.ProductName.ToString)
                    Me.Close()
                Else
                    MsgBox("Error: Cannot save current fingerprint template", vbExclamation, Application.ProductName.ToString)
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
            End Try
        End If
    End Sub

    Private Sub objFpReg_FPRegistrationTemplate(FPTemplate As String) Handles objFpReg.FPRegistrationTemplate
        strTemplate = FPTemplate.ToString
    End Sub

    Private Sub objFpReg_FPSamplesNeeded(Samples As Short) Handles objFpReg.FPSamplesNeeded
        intSamples = Samples

        If Samples = 4 Then
            pbIdicator1.BackColor = Color.DarkGreen
            pbIdicator2.BackColor = Color.DarkGreen
            pbIdicator3.BackColor = Color.DarkGreen
            pbIdicator4.BackColor = Color.DarkGreen
        ElseIf Samples = 3 Then
            pbIdicator1.BackColor = Color.Red
            pbIdicator2.BackColor = Color.DarkGreen
            pbIdicator3.BackColor = Color.DarkGreen
            pbIdicator4.BackColor = Color.DarkGreen
        ElseIf Samples = 2 Then
            pbIdicator1.BackColor = Color.Red
            pbIdicator2.BackColor = Color.Red
            pbIdicator3.BackColor = Color.DarkGreen
            pbIdicator4.BackColor = Color.DarkGreen
        ElseIf Samples = 1 Then
            pbIdicator1.BackColor = Color.Red
            pbIdicator2.BackColor = Color.Red
            pbIdicator3.BackColor = Color.Red
            pbIdicator4.BackColor = Color.DarkGreen
        ElseIf Samples = 0 Then
            pbIdicator1.BackColor = Color.Red
            pbIdicator2.BackColor = Color.Red
            pbIdicator3.BackColor = Color.Red
            pbIdicator4.BackColor = Color.Red
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

    Private Sub txtEmployeeID_Click(sender As Object, e As EventArgs) Handles txtEmployeeID.Click
        Call ShowOSK()
    End Sub
End Class