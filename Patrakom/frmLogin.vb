Imports System
Imports System.Text
Imports System.IO

Public Class frmLogin

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

        lblDatetime.Font = My.Settings.FontFace
        PanelControl1.BackColor = My.Settings.HeaderColor
        btnSetting.Appearance.BackColor = My.Settings.ButtonColor1
        btnSetting.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnDashboard.Appearance.BackColor = My.Settings.ButtonColor1
        btnDashboard.Appearance.BackColor2 = My.Settings.ButtonColor2
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

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadTheme()

        txtUsername.Focus()
    End Sub

    Private Sub btnDashboard_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

    Private Sub btnSetting_Click(sender As System.Object, e As System.EventArgs) Handles btnSetting.Click
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim strHash As String = String.Empty

        isLogin = False

        Try
            If txtUsername.Text.ToString.Trim <> "" Then
                If txtPassword.Text.ToString.Trim <> "" Then
                    strSQL = "SELECT * FROM erp_users_accounts WHERE username = '" & txtUsername.Text.ToString.Trim & "' AND privileges IN('100','999') LIMIT 1"
                    objDataSet = getDataSet(strSQL.ToString)

                    If objDataSet.Tables.Count > 0 Then
                        If objDataSet.Tables(0).Rows.Count > 0 Then
                            strHash = EncodeMD5(txtPassword.Text.ToString.Trim & objDataSet.Tables(0).Rows(0).Item("password_code").ToString).ToString
                            If strHash.ToString = objDataSet.Tables(0).Rows(0).Item("password").ToString Then
                                isLogin = True
                                Me.Close()
                            Else
                                isLogin = False
                                MsgBox("Error: Invalid username or password", vbExclamation, Application.ProductName.ToString)

                                txtUsername.Focus()
                                txtUsername.SelectionStart = 0
                                txtUsername.SelectionLength = Len(txtUsername.Text)
                            End If
                        Else
                            isLogin = False
                            MsgBox("Error: Invalid username or password", vbExclamation, Application.ProductName.ToString)

                            txtUsername.Focus()
                            txtUsername.SelectionStart = 0
                            txtUsername.SelectionLength = Len(txtUsername.Text)
                        End If
                    Else
                        isLogin = False
                        MsgBox("Error: Invalid username or password", vbExclamation, Application.ProductName.ToString)

                        txtUsername.Focus()
                        txtUsername.SelectionStart = 0
                        txtUsername.SelectionLength = Len(txtUsername.Text)
                    End If
                Else
                    isLogin = False
                    MsgBox("Please fill in the blanks", vbExclamation, Application.ProductName.ToString)

                    txtPassword.Focus()
                End If
            Else
                isLogin = False
                MsgBox("Please fill in the blanks", vbExclamation, Application.ProductName.ToString)

                txtUsername.Focus()
            End If
        Catch ex As Exception
            isLogin = False
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)

            txtUsername.Focus()
            txtUsername.SelectionStart = 0
            txtUsername.SelectionLength = Len(txtUsername.Text)
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
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

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        Call ShowOSK()
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        Call ShowOSK()
    End Sub
End Class