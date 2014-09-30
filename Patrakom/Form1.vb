Imports System.ComponentModel
Imports System.Text
Imports System.IO
Imports Newtonsoft
Imports Newtonsoft.Json

Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

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

                If lstImageFiles.Items.Count > 0 Then
                    If intBackgroundIndex > (Me.lstImageFiles.Items.Count - 1) Then
                        intBackgroundIndex = 0
                    End If

                    Me.BackgroundImage = Image.FromFile(lstImageFiles.Items(intBackgroundIndex).ToString)
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
        btnGuestbook.Appearance.BackColor = My.Settings.ButtonColor1
        btnGuestbook.Appearance.BackColor2 = My.Settings.ButtonColor2
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadTheme()

        Dim x As DateTime
        x = CDate(Format(Now, "MM/dd/yyyy") & " " & Format(Convert.ToDateTime("08:00"), "HH:mm:ss"))
        MsgBox(Format(x.AddMinutes(-30), "yyyy/MM/dd hh:mm:ss").ToString)

        Me.Show()
        Me.Refresh()
        Application.DoEvents()

        strDbServerIp = My.Settings.DbIpAddress
        strDbServerPort = "3306"
        strDbName = My.Settings.DbName
        strDbUsername = My.Settings.DbUsername
        strDbPassword = My.Settings.DbPassword

        'strDbServerIp = "127.0.0.1"
        'strDbServerPort = "3306"
        'strDbName = "patrakom"
        'strDbUsername = "root"
        'strDbPassword = ""

        'Server database connection string
        strServerConnectionString = "Server=" & strDbServerIp.ToString & ";Port=" & strDbServerPort.ToString & ";Uid=" & strDbUsername.ToString & ";Pwd=" & strDbPassword.ToString & ";Database=" & strDbName.ToString & ";Treat Tiny As Boolean=false;Connection Timeout=5;UseAffectedRows=True"

        'Local database connection string
        'strConnectionString = "Data Source=D:\PROJECTS\Patrakom_v2\Database\data.db; Version=3; FailIfMissing=True; Compress=True; Legacy Format=True;"
        strConnectionString = "Data Source=" & MyPath() & "data.db; Version=3; FailIfMissing=True; Compress=True; Legacy Format=True;"

        If openDatabaseConnection(strConnectionString.ToString) Then
            If openServerDatabaseConnection(strServerConnectionString.ToString) Then
                ConnectionStatus.Image = My.Resources.connected
            Else
                ConnectionStatus.Image = My.Resources.disconnected
            End If

            'Load base parameters
            If Not LoadBaseParameters() Then
                MsgBox("Error: Cannot load application parameter", vbExclamation, Application.ProductName.ToString)
                Me.Close()
                Application.Exit()
            End If
        Else
            MsgBox("Error: Local storage was not found", vbCritical, Application.ProductName.ToString)
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Function LoadBaseParameters() As Boolean
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim strSettings As String = String.Empty
        Dim boolRetval As Boolean = False

        Try
            strSQL = "SELECT * FROM system_settings WHERE app = 'erp' AND parameter = 'human_resources'"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    strSettings = objDataSet.Tables(0).Rows(0).Item("settings").ToString

                    Dim objJsonSetting As clsSettings = JsonConvert.DeserializeObject(Of clsSettings)(strSettings)

                    'Working Days
                    If Trim(objJsonSetting.workingDays) <> "" Then
                        If IsNumeric(Trim(objJsonSetting.workingDays)) Then
                            intWorkingDays = CInt(Trim(objJsonSetting.workingDays))
                        Else
                            intWorkingDays = 5
                        End If
                    Else
                        intWorkingDays = 5
                    End If

                    'Working Hours
                    If Trim(objJsonSetting.workingHours) <> "" Then
                        If IsNumeric(Trim(objJsonSetting.workingHours)) Then
                            intWorkingHours = CInt(Trim(objJsonSetting.workingHours))
                        Else
                            intWorkingHours = 8
                        End If
                    Else
                        intWorkingHours = 8
                    End If

                    'Break Hours
                    If Trim(objJsonSetting.breakHours) <> "" Then
                        If IsNumeric(Trim(objJsonSetting.breakHours)) Then
                            intBreakHours = CInt(Trim(objJsonSetting.breakHours))
                        Else
                            intBreakHours = 1
                        End If
                    Else
                        intBreakHours = 1
                    End If

                    'Overtime Start Hour
                    If Trim(objJsonSetting.overTimeStartHour) <> "" Then
                        If IsNumeric(Trim(objJsonSetting.overTimeStartHour)) Then
                            intOverTimeStartHour = CInt(Trim(objJsonSetting.overTimeStartHour))
                        Else
                            intOverTimeStartHour = 1
                        End If
                    Else
                        intOverTimeStartHour = 1
                    End If

                    'Early Office Hour
                    If Trim(objJsonSetting.earlyOfficeHour) <> "" Then
                        strEarlyOfficeHour = Trim(objJsonSetting.earlyOfficeHour)
                    Else
                        strEarlyOfficeHour = "07:30"
                    End If

                    'Standard Office Hour
                    If Trim(objJsonSetting.standardOfficeHour) <> "" Then
                        strStandardOfficeHour = Trim(objJsonSetting.standardOfficeHour)
                    Else
                        strStandardOfficeHour = "08:00"
                    End If

                    'Late Minutes Tolerance
                    If Trim(objJsonSetting.lateMinutesTolerance) <> "" Then
                        If IsNumeric(Trim(objJsonSetting.lateMinutesTolerance)) Then
                            intLateMinutesTolerance = CInt(Trim(objJsonSetting.lateMinutesTolerance))
                        Else
                            intLateMinutesTolerance = 30
                        End If
                    Else
                        intLateMinutesTolerance = 30
                    End If

                    'Late Hour Tolerance
                    If Trim(objJsonSetting.lateHourTolerance) <> "" Then
                        strLateHourTolerance = Trim(objJsonSetting.lateHourTolerance)
                    Else
                        strLateHourTolerance = "12:00"
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

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDatetime.Text = Format(Now(), "dddd, dd MMM yyyy - HH:mm:ss tt")
        Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)

        'Check server database connection state
        If isServerDBConnected() Then
            isDbConnected = True
            ConnectionStatus.Image = My.Resources.connected
        Else
            isDbConnected = False
            ConnectionStatus.Image = My.Resources.disconnected
        End If
    End Sub

    Private Sub btnAttendance_Click(sender As System.Object, e As System.EventArgs) Handles btnAttendance.Click
        frmCheckin.ShowDialog()
        frmCheckin.Dispose()
    End Sub

    Private Sub companyLogo_Click(sender As System.Object, e As System.EventArgs) Handles companyLogo.Click
        frmLogin.ShowDialog()
        frmLogin.Dispose()

        If isLogin Then
            frmCP.ShowDialog()
            frmCP.Dispose()
        End If
    End Sub

    Private Sub btnGuestbook_Click(sender As System.Object, e As System.EventArgs) Handles btnGuestbook.Click
        frmGuestbook.ShowDialog()
        frmGuestbook.Dispose()
    End Sub

    Private Sub timerImages_Tick(sender As Object, e As EventArgs) Handles timerImages.Tick
        If Me.lstImageFiles.Items.Count > 0 Then
            If intBackgroundIndex > (Me.lstImageFiles.Items.Count - 1) Then
                intBackgroundIndex = 0
            End If

            Me.BackgroundImage = Image.FromFile(Me.lstImageFiles.Items(intBackgroundIndex).ToString)
            intBackgroundIndex += 1
        End If
    End Sub
End Class
