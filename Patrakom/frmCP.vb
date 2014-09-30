Imports System
Imports System.Text
Imports System.IO

Public Class frmCP

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
        btnRegisterUser.Appearance.BackColor = My.Settings.ButtonColor1
        btnRegisterUser.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnAppSettings.Appearance.BackColor = My.Settings.ButtonColor1
        btnAppSettings.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnForceCloseApp.Appearance.BackColor = My.Settings.ButtonColor1
        btnForceCloseApp.Appearance.BackColor2 = My.Settings.ButtonColor2
    End Sub

    Private Sub btnDashboard_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

    Private Sub btnAppSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnAppSettings.Click
        frmSettings.ShowDialog()
        frmSettings.Dispose()
    End Sub

    Private Sub btnExitSetting_Click(sender As System.Object, e As System.EventArgs) Handles btnExitSetting.Click
        Me.Close()
    End Sub

    Private Sub btnRegisterUser_Click(sender As System.Object, e As System.EventArgs) Handles btnRegisterUser.Click
        frmRegUser.ShowDialog()
        frmRegUser.Dispose()
    End Sub

    Private Sub frmCP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadTheme()
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

    Private Sub btnForceCloseApp_Click(sender As System.Object, e As System.EventArgs) Handles btnForceCloseApp.Click
        Application.Exit()
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
End Class