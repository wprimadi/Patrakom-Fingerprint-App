Imports System
Imports System.Text
Imports System.IO
Imports System.Runtime
Imports System.Runtime.InteropServices
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports WebCam

Public Class frmSettings

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Metropolis")
    End Sub

    Private Sub generateBackgroundMode()
        cboBackgroundMode.Properties.Items.Clear()
        cboBackgroundMode.Properties.Items.Add("None")
        cboBackgroundMode.Properties.Items.Add("Tile")
        cboBackgroundMode.Properties.Items.Add("Center")
        cboBackgroundMode.Properties.Items.Add("Stretch")
        cboBackgroundMode.Properties.Items.Add("Zoom")
    End Sub

    Private Sub frmSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If WebCameraControl1.IsCapturing Then
                WebCameraControl1.StopCapture()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call generateBackgroundMode()
        Call ListWebcamSource()

        txtCompanyName.Text = My.Settings.CompanyName
        txtApplicationName.Text = My.Settings.ApplicationName
        txtGreetingsMessage.Text = My.Settings.GreetingsMessage
        txtClientID.Text = My.Settings.ClientID
        txtHardwareID.Text = My.Settings.HardwareID
        txtSerialNumber.Text = My.Settings.SerialNumber
        txtDbIpAddress.Text = My.Settings.DbIpAddress
        txtDbUsername.Text = My.Settings.DbUsername
        txtDbPassword.Text = My.Settings.DbPassword
        txtDatabase.Text = My.Settings.DbName
        txtFingerprintTable.Text = My.Settings.FingerprintTable
        txtAttendanceTable.Text = My.Settings.AttendanceTable
        txtDeviceSerial.Text = My.Settings.DeviceSerial
        txtVerivicationCode.Text = My.Settings.VerificationCode
        txtActivationCode.Text = My.Settings.ActivationCode
        txtBackgroundImage.Text = My.Settings.BackgroundImage
        cboButtonColor1.Color = My.Settings.ButtonColor1
        cboButtonColor2.Color = My.Settings.ButtonColor2
        cboButtonGradientMode.Text = My.Settings.ButtonGradientMode
        txtApplicationLogo.Text = My.Settings.ApplicationLogo
        cboApplicationColor1.Color = My.Settings.ApplicationLogoColor1
        cboApplicationGradientMode.Text = My.Settings.ApplicationLogoGradientMode
        cboHeaderColor.Color = My.Settings.HeaderColor
        cboFont.Font = My.Settings.FontFace
        cboFontColor.Color = My.Settings.FontColor

        If My.Settings.WebcamDriverIndex.ToString.Trim <> "" Then
            If IsNumeric(My.Settings.WebcamDriverIndex.ToString.Trim) Then
                WebcamSource.SelectedIndex = My.Settings.WebcamDriverIndex
            Else
                WebcamSource.SelectedIndex = 0
            End If
        Else
            WebcamSource.SelectedIndex = 0
        End If

        WebcamSource.Text = My.Settings.WebcamDriverName

        If My.Settings.BackgroundImageType = 0 Then
            chkImage1.Checked = True
            chkImage2.Checked = False
        ElseIf My.Settings.BackgroundImageType = 1 Then
            chkImage2.Checked = True
            chkImage1.Checked = False
        Else
            chkImage1.Checked = True
            chkImage2.Checked = False
        End If

        txtDuration.Text = My.Settings.BackgroundImageSlideShowDuration.ToString
        txtDuration.Value = My.Settings.BackgroundImageSlideShowDuration

        If My.Settings.BackgroundMode.ToString.Trim <> "" Then
            cboBackgroundMode.Text = My.Settings.BackgroundMode.ToString
        Else
            cboBackgroundMode.Text = "Stretch"
        End If

        btnStopPreview.Enabled = False
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        My.Settings.CompanyName = txtCompanyName.Text.ToString
        My.Settings.ApplicationName = txtApplicationName.Text.ToString
        My.Settings.GreetingsMessage = txtGreetingsMessage.Text.ToString
        My.Settings.ClientID = txtClientID.Text.ToString
        My.Settings.HardwareID = txtHardwareID.Text.ToString
        My.Settings.SerialNumber = txtSerialNumber.Text.ToString
        My.Settings.DbIpAddress = txtDbIpAddress.Text.ToString
        My.Settings.DbUsername = txtDbUsername.Text.ToString
        My.Settings.DbPassword = txtDbPassword.Text.ToString
        My.Settings.DbName = txtDatabase.Text.ToString
        My.Settings.FingerprintTable = txtFingerprintTable.Text.ToString
        My.Settings.AttendanceTable = txtAttendanceTable.Text.ToString
        My.Settings.DeviceSerial = txtDeviceSerial.Text.ToString
        My.Settings.VerificationCode = txtVerivicationCode.Text.ToString
        My.Settings.ActivationCode = txtActivationCode.Text.ToString
        My.Settings.BackgroundImage = txtBackgroundImage.Text.ToString
        My.Settings.ButtonColor1 = cboButtonColor1.Color
        My.Settings.ButtonColor2 = cboButtonColor2.Color
        My.Settings.ButtonGradientMode = cboButtonGradientMode.Text.ToString
        My.Settings.ApplicationLogo = txtApplicationLogo.Text.ToString
        My.Settings.ApplicationLogoColor1 = cboApplicationColor1.Color
        My.Settings.ApplicationLogoGradientMode = cboApplicationGradientMode.Text.ToString
        My.Settings.HeaderColor = cboHeaderColor.Color
        My.Settings.FontFace = cboFont.Font
        My.Settings.FontColor = cboFontColor.Color
        My.Settings.WebcamDriverIndex = WebcamSource.SelectedIndex
        My.Settings.WebcamDriverName = WebcamSource.Text

        If chkImage1.Checked Then
            My.Settings.BackgroundImageType = 0
        ElseIf chkImage2.Checked Then
            My.Settings.BackgroundImageType = 1
        Else
            My.Settings.BackgroundImageType = 0
        End If

        My.Settings.BackgroundImageSlideShowDuration = CInt(txtDuration.Text.ToString.Trim)
        My.Settings.BackgroundMode = cboBackgroundMode.Text.ToString
        My.Settings.Save()

        Me.Close()
    End Sub

    Private Sub txtBackgroundImage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtBackgroundImage.ButtonClick
        If chkImage1.Checked Then
            With OpenFileDialog1
                .Title = "Select image file"
                .Filter = "Bitmap File (*.bmp)|*.bmp|JPG File (*.jpg)|*.jpg|JPEG File (*.jpeg)|*.jpeg|PNG File (*.png)|*.png|GIF File (*.gif)|*.gif"
                .CheckFileExists = True
                .CheckPathExists = True
                .ReadOnlyChecked = True
                .Multiselect = False
                .FileName = ""
                .ShowDialog()
            End With

            If OpenFileDialog1.FileName.ToString.Trim <> "" Then
                txtBackgroundImage.Text = OpenFileDialog1.FileName.ToString
            End If
        ElseIf chkImage2.Checked Then
            With FolderBrowserDialog1
                .SelectedPath = MyPath()
                .ShowDialog()
            End With

            If FolderBrowserDialog1.SelectedPath.ToString.Trim <> "" Then
                txtBackgroundImage.Text = FolderBrowserDialog1.SelectedPath.ToString
            End If
        End If
    End Sub

    Private Sub txtApplicationLogo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtApplicationLogo.ButtonClick
        With OpenFileDialog1
            .Title = "Select image file"
            .Filter = "Bitmap File (*.bmp)|*.bmp|JPG File (*.jpg)|*.jpg|JPEG File (*.jpeg)|*.jpeg|PNG File (*.png)|*.png|GIF File (*.gif)|*.gif"
            .CheckFileExists = True
            .CheckPathExists = True
            .ReadOnlyChecked = True
            .Multiselect = False
            .FileName = ""
            .ShowDialog()
        End With

        If OpenFileDialog1.FileName.ToString.Trim <> "" Then
            txtApplicationLogo.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub ListWebcamSource()
        Dim intCounter As Integer = 0

        WebcamSource.Properties.Items.Clear()

        Try
            Dim cameraDevices As New List(Of WebCameraId)(WebCameraControl1.GetVideoCaptureDevices())
            For intCounter = 0 To (cameraDevices.Count - 1)
                WebcamSource.Properties.Items.Add(cameraDevices(intCounter).Name.ToString)
            Next
        Catch ex As Exception
            MsgBox("Error: Cannot read installed webcam devices", vbExclamation, Application.ProductName.ToString)
        End Try
    End Sub

    Private Sub StartPreview()
        Try
            Dim cameraDevices As New List(Of WebCameraId)(WebCameraControl1.GetVideoCaptureDevices())
            WebCameraControl1.StartCapture(cameraDevices(WebcamSource.SelectedIndex))
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName.ToString)
        End Try
    End Sub

    Private Sub StopPreview()
        Try
            If WebCameraControl1.IsCapturing Then
                WebCameraControl1.StopCapture()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefreshList_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshList.Click
        Call ListWebcamSource()
    End Sub

    Private Sub btnStartPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnStartPreview.Click
        
        If WebcamSource.Text.ToString.Trim <> "" Then
            Call StopPreview()
            Call StartPreview()

            btnStopPreview.Enabled = True
            btnStartPreview.Enabled = False
        End If
    End Sub

    Private Sub btnStopPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnStopPreview.Click
        'Call StopPreview(WebcamSource.SelectedIndex)
        WebCameraControl1.StopCapture()

        btnStopPreview.Enabled = False
        btnStartPreview.Enabled = True
    End Sub

    Private Sub txtCompanyName_Click(sender As Object, e As EventArgs) Handles txtCompanyName.Click
        Call ShowOSK()
    End Sub

    Private Sub txtApplicationName_Click(sender As Object, e As EventArgs) Handles txtApplicationName.Click
        Call ShowOSK()
    End Sub

    Private Sub txtGreetingsMessage_Click(sender As Object, e As EventArgs) Handles txtGreetingsMessage.Click
        Call ShowOSK()
    End Sub

    Private Sub txtClientID_Click(sender As Object, e As EventArgs) Handles txtClientID.Click
        Call ShowOSK()
    End Sub

    Private Sub txtHardwareID_Click(sender As Object, e As EventArgs) Handles txtHardwareID.Click
        Call ShowOSK()
    End Sub

    Private Sub txtSerialNumber_Click(sender As Object, e As EventArgs) Handles txtSerialNumber.Click
        Call ShowOSK()
    End Sub

    Private Sub txtDbIpAddress_Click(sender As Object, e As EventArgs) Handles txtDbIpAddress.Click
        Call ShowOSK()
    End Sub

    Private Sub txtDbUsername_Click(sender As Object, e As EventArgs) Handles txtDbUsername.Click
        Call ShowOSK()
    End Sub

    Private Sub txtDbPassword_Click(sender As Object, e As EventArgs) Handles txtDbPassword.Click
        Call ShowOSK()
    End Sub

    Private Sub txtDatabase_Click(sender As Object, e As EventArgs) Handles txtDatabase.Click
        Call ShowOSK()
    End Sub

    Private Sub txtFingerprintTable_Click(sender As Object, e As EventArgs) Handles txtFingerprintTable.Click
        Call ShowOSK()
    End Sub

    Private Sub txtAttendanceTable_Click(sender As Object, e As EventArgs) Handles txtAttendanceTable.Click
        Call ShowOSK()
    End Sub

    Private Sub txtDeviceSerial_Click(sender As Object, e As EventArgs) Handles txtDeviceSerial.Click
        Call ShowOSK()
    End Sub

    Private Sub txtVerivicationCode_Click(sender As Object, e As EventArgs) Handles txtVerivicationCode.Click
        Call ShowOSK()
    End Sub

    Private Sub txtActivationCode_Click(sender As Object, e As EventArgs) Handles txtActivationCode.Click
        Call ShowOSK()
    End Sub
End Class