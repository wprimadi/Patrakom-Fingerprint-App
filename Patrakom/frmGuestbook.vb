Imports System
Imports System.Text
Imports System.IO
Imports System.Runtime.InteropServices
Imports MySql
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports WebCam

Public Class frmGuestbook

    Private intVisitorID As Integer = 0

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
        btnGuestbook.Appearance.BackColor = My.Settings.ButtonColor1
        btnGuestbook.Appearance.BackColor2 = My.Settings.ButtonColor2
        btnGuestbook.Appearance.BackColor = My.Settings.ButtonColor1
        btnGuestbook.Appearance.BackColor2 = My.Settings.ButtonColor2
    End Sub

    Private Sub LoadCompanyCollection()
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim objCollection As AutoCompleteStringCollection = New AutoCompleteStringCollection
        Dim intCounter As Integer = 0

        Try
            strSQL = "SELECT DISTINCT company FROM company_guestbook"
            objDataSet = getServerDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    For intCounter = 0 To (objDataSet.Tables(0).Rows.Count - 1)
                        objCollection.Add(objDataSet.Tables(0).Rows(intCounter).Item("company").ToString)
                    Next

                    txtCompany.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txtCompany.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txtCompany.MaskBox.AutoCompleteCustomSource = objCollection
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: Cannot load company collection list" & vbCrLf & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If

            If Not objCollection Is Nothing Then
                objCollection = Nothing
            End If
        End Try
    End Sub

    Private Function LoadEmployeeData() As Boolean
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim boolRetval As Boolean = False
        Dim objToken As DevExpress.XtraEditors.TokenEditToken
        Dim strFirstName As String = String.Empty
        Dim strMiddleName As String = String.Empty
        Dim strLastName As String = String.Empty
        Dim strValues As String = String.Empty
        Dim strID As String = String.Empty
        Dim intCounter As Integer = 0

        Try
            strSQL = "SELECT employee_id, first_name, middle_name, last_name FROM erp_employee ORDER BY first_name ASC"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    For intCounter = 0 To (objDataSet.Tables(0).Rows.Count - 1)
                        strValues = String.Empty
                        strFirstName = objDataSet.Tables(0).Rows(intCounter).Item("first_name").ToString.Trim
                        strMiddleName = objDataSet.Tables(0).Rows(intCounter).Item("middle_name").ToString.Trim
                        strLastName = objDataSet.Tables(0).Rows(intCounter).Item("last_name").ToString.Trim
                        strID = objDataSet.Tables(0).Rows(intCounter).Item("employee_id").ToString.Trim

                        If strFirstName.ToString.Trim <> "" Then
                            strValues &= strFirstName.ToString
                        End If

                        If strMiddleName.ToString.Trim <> "" Then
                            strValues &= " " & strMiddleName.ToString
                        End If

                        If strLastName.ToString.Trim <> "" Then
                            strValues &= " " & strLastName.ToString
                        End If

                        objToken = New DevExpress.XtraEditors.TokenEditToken(strValues.ToString.Trim, strID.ToString.Trim)
                        txtPerson.Properties.Tokens.Add(objToken)
                    Next

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

            If Not objToken Is Nothing Then
                objToken = Nothing
            End If
        End Try
    End Function

    Private Sub frmGuestbook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call StopPreview()
    End Sub

    Private Sub frmGuestbook_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadTheme()
        Call HideGuestbookForm()
        Call LoadCompanyCollection()
        Call LoadEmployeeData()
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

    Private Sub ShowGuestbookForm()
        Call StopPreview()

        pnlSearchVisitor.Visible = False
        WebCameraControl1.Visible = True
        pnlGuestbook.Visible = True

        Call StartPreview()
    End Sub

    Private Sub HideGuestbookForm()
        Call StopPreview()

        pnlSearchVisitor.Visible = True
        WebCameraControl1.Visible = False
        pnlGuestbook.Visible = False
    End Sub

    Private Sub StartPreview()
        Try
            Dim cameraDevices As New List(Of WebCameraId)(WebCameraControl1.GetVideoCaptureDevices())
            WebCameraControl1.StartCapture(cameraDevices(My.Settings.WebcamDriverIndex))
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

    Private Sub LoadVisitorID(ByVal intID As Integer)
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet

        Try
            strSQL = "SELECT * FROM company_guestbook WHERE id = " & intID.ToString
            objDataSet = getServerDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    lblName.Text = objDataSet.Tables(0).Rows(0).Item("name").ToString
                    lblID.Text = "[" & objDataSet.Tables(0).Rows(0).Item("identity_type").ToString.ToUpper & "] " & objDataSet.Tables(0).Rows(0).Item("identity_id").ToString
                    txtCompany.Text = objDataSet.Tables(0).Rows(0).Item("company").ToString
                    txtPhone.Text = objDataSet.Tables(0).Rows(0).Item("mobile_phone").ToString
                Else
                    MsgBox("Visitor not found", vbExclamation, Application.ProductName.ToString)
                End If
            Else
                MsgBox("Visitor not found", vbExclamation, Application.ProductName.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet

        Try
            If txtVisitorID.Text.ToString.Trim <> "" Then
                If IsNumeric(txtVisitorID.Text.ToString.Trim) Then
                    strSQL = "SELECT * FROM company_guestbook_logs WHERE DATE_FORMAT(date, '%Y%m%d') = '" & Format(Now(), "yyyyMMdd") & "' AND id = " & CInt(txtVisitorID.Text.ToString.Trim)
                    objDataSet = getServerDataSet(strSQL.ToString)

                    If objDataSet.Tables.Count > 0 Then
                        If objDataSet.Tables(0).Rows.Count > 0 Then
                            intVisitorID = CInt(objDataSet.Tables(0).Rows(0).Item("id").ToString)
                            Call LoadVisitorID(CInt(objDataSet.Tables(0).Rows(0).Item("guest_id").ToString))
                            Call ShowGuestbookForm()
                        Else
                            MsgBox("Error: Visitor ID not found", vbExclamation, Application.ProductName.ToString)
                            intVisitorID = 0
                            txtVisitorID.Focus()
                            txtVisitorID.SelectionStart = 0
                            txtVisitorID.SelectionLength = Len(txtVisitorID.Text)
                        End If
                    Else
                        MsgBox("Error: Visitor ID not found", vbExclamation, Application.ProductName.ToString)
                        intVisitorID = 0
                        txtVisitorID.Focus()
                        txtVisitorID.SelectionStart = 0
                        txtVisitorID.SelectionLength = Len(txtVisitorID.Text)
                    End If
                Else
                    MsgBox("Error: Invalid visitor ID", vbExclamation, Application.ProductName.ToString)
                    intVisitorID = 0
                    txtVisitorID.Focus()
                    txtVisitorID.SelectionStart = 0
                    txtVisitorID.SelectionLength = Len(txtVisitorID.Text)
                End If
            Else
                MsgBox("Please fill in the blanks", vbExclamation, Application.ProductName.ToString)
                intVisitorID = 0
                txtVisitorID.Focus()
                txtVisitorID.SelectionStart = 0
                txtVisitorID.SelectionLength = Len(txtVisitorID.Text)
            End If
        Catch ex As Exception
            intVisitorID = 0
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim boolCaptureSuccess As Boolean = False
        Dim objImageStream As IO.MemoryStream = Nothing
        Dim strSQL As String = String.Empty
        Dim objCommand As MySqlCommand = Nothing
        Dim arrPersons() As String
        Dim strTmpPersons As String = String.Empty
        Dim strPersons As String = String.Empty
        Dim intPersons As Integer = 0
        
        Try
            If txtPerson.Text.ToString.Trim <> "" Then
                strTmpPersons = txtPerson.Text.ToString.Replace(" ", "|")
                strTmpPersons = strTmpPersons.Replace("||", "#")
                strTmpPersons = strTmpPersons.Replace("|", " ")

                arrPersons = strTmpPersons.ToString.Split("#")
                strPersons = String.Empty

                For intPersons = 0 To arrPersons.Length - 1
                    If arrPersons(intPersons).ToString.Trim <> "" Then
                        If strPersons.ToString.Trim = "" Then
                            strPersons = arrPersons(intPersons).ToString.Trim
                        Else
                            strPersons &= "|" & arrPersons(intPersons).ToString.Trim
                        End If
                    End If
                Next
            Else
                strPersons = String.Empty
            End If

            objImageStream = New IO.MemoryStream
            WebCameraControl1.GetCurrentImage().Save(objImageStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = objImageStream.GetBuffer
            objImageStream.Close()

            strSQL = "UPDATE company_guestbook_logs SET employee_id = @p_empid, reason = @p_reason, duration = @p_duration, photo = @p_photo WHERE id = " & intVisitorID.ToString
            objCommand = New MySqlCommand(strSQL.ToString, objServerConnection)
            objCommand.Parameters.AddWithValue("@p_empid", strPersons)
            objCommand.Parameters.AddWithValue("@p_reason", txtReason.Text.ToString)
            objCommand.Parameters.AddWithValue("@p_duration", txtDuration.Text.ToString)
            objCommand.Parameters.AddWithValue("@p_photo", arrImage)
            objCommand.ExecuteNonQuery()

            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
        Finally
            If Not objCommand Is Nothing Then
                objCommand.Dispose()
                objCommand = Nothing
            End If

            If Not objImageStream Is Nothing Then
                objImageStream.Dispose()
                objImageStream = Nothing
            End If
        End Try
    End Sub

    Private Sub txtPerson_BeforeShowPopupPanel(sender As Object, e As DevExpress.XtraEditors.TokenEditBeforeShowPopupPanelEventArgs) Handles txtPerson.BeforeShowPopupPanel
        Dim strSQL As String = String.Empty
        Dim objDataSet As DataSet = New DataSet
        Dim strFirstName As String = String.Empty
        Dim strMiddleName As String = String.Empty
        Dim strLastName As String = String.Empty
        Dim strValues As String = String.Empty
        Dim strID As String = String.Empty

        Try
            strSQL = "SELECT employee_id, first_name, middle_name, last_name FROM erp_employee WHERE employee_id = '" & e.Value.ToString & "' LIMIT 1"
            objDataSet = getDataSet(strSQL.ToString)

            If objDataSet.Tables.Count > 0 Then
                If objDataSet.Tables(0).Rows.Count > 0 Then
                    strValues = String.Empty
                    strFirstName = objDataSet.Tables(0).Rows(0).Item("first_name").ToString.Trim
                    strMiddleName = objDataSet.Tables(0).Rows(0).Item("middle_name").ToString.Trim
                    strLastName = objDataSet.Tables(0).Rows(0).Item("last_name").ToString.Trim
                    strID = objDataSet.Tables(0).Rows(0).Item("employee_id").ToString.Trim

                    If strFirstName.ToString.Trim <> "" Then
                        strValues &= strFirstName.ToString
                    End If

                    If strMiddleName.ToString.Trim <> "" Then
                        strValues &= " " & strMiddleName.ToString
                    End If

                    If strLastName.ToString.Trim <> "" Then
                        strValues &= " " & strLastName.ToString
                    End If

                    lblPersonName.Text = strValues.ToString
                    lblID.Text = strID.ToString
                Else
                    lblPersonName.Text = "Unknown"
                    lblEmail.Text = "Unknown"
                    lblPhone.Text = "Unknown"
                    lblEmpID.Text = "Unknown"
                End If
            Else
                lblPersonName.Text = "Unknown"
                lblEmail.Text = "Unknown"
                lblPhone.Text = "Unknown"
                lblEmpID.Text = "Unknown"
            End If
        Catch ex As Exception
            lblPersonName.Text = "Unknown"
            lblEmail.Text = "Unknown"
            lblPhone.Text = "Unknown"
            lblEmpID.Text = "Unknown"

            MsgBox("Error: " & ex.Message.ToString, vbExclamation, Application.ProductName.ToString)
        Finally
            If Not objDataSet Is Nothing Then
                objDataSet.Dispose()
                objDataSet = Nothing
            End If
        End Try
    End Sub

    Private Sub btnGuestbook_Click(sender As Object, e As EventArgs) Handles btnGuestbook.Click
        Call HideGuestbookForm()
        WebCameraControl1.Visible = False
        Call StopPreview()
    End Sub
End Class