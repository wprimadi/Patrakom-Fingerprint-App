Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.lblDatetime = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAttendance = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuestbook = New DevExpress.XtraEditors.SimpleButton()
        Me.Clock1 = New AnalogClock.Clock()
        Me.companyLogo = New System.Windows.Forms.PictureBox()
        Me.lstImageFiles = New System.Windows.Forms.ListBox()
        Me.timerImages = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.ConnectionStatus)
        Me.PanelControl1.Controls.Add(Me.lblDatetime)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(955, 36)
        Me.PanelControl1.TabIndex = 0
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectionStatus.Image = CType(resources.GetObject("ConnectionStatus.Image"), System.Drawing.Image)
        Me.ConnectionStatus.Location = New System.Drawing.Point(920, 4)
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(31, 26)
        Me.ConnectionStatus.TabIndex = 1
        Me.ConnectionStatus.TabStop = False
        '
        'lblDatetime
        '
        Me.lblDatetime.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatetime.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblDatetime.Location = New System.Drawing.Point(12, 12)
        Me.lblDatetime.Name = "lblDatetime"
        Me.lblDatetime.Size = New System.Drawing.Size(66, 13)
        Me.lblDatetime.TabIndex = 0
        Me.lblDatetime.Text = "{datetime}"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnAttendance
        '
        Me.btnAttendance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAttendance.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnAttendance.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAttendance.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnAttendance.Appearance.Options.UseBackColor = True
        Me.btnAttendance.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAttendance.Image = CType(resources.GetObject("btnAttendance.Image"), System.Drawing.Image)
        Me.btnAttendance.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAttendance.Location = New System.Drawing.Point(12, 251)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(200, 200)
        Me.btnAttendance.TabIndex = 1
        Me.btnAttendance.Text = "Attendance"
        '
        'btnGuestbook
        '
        Me.btnGuestbook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuestbook.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnGuestbook.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuestbook.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnGuestbook.Appearance.Options.UseBackColor = True
        Me.btnGuestbook.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnGuestbook.Image = CType(resources.GetObject("btnGuestbook.Image"), System.Drawing.Image)
        Me.btnGuestbook.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuestbook.Location = New System.Drawing.Point(231, 251)
        Me.btnGuestbook.Name = "btnGuestbook"
        Me.btnGuestbook.Size = New System.Drawing.Size(200, 200)
        Me.btnGuestbook.TabIndex = 2
        Me.btnGuestbook.Text = "Attendance"
        '
        'Clock1
        '
        Me.Clock1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clock1.BackColor = System.Drawing.Color.Transparent
        Me.Clock1.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.Clock1.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.CenterPoint.RelativeRadius = 0.03!
        Me.Clock1.CenterPoint.Tag = Nothing
        Me.Clock1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clock1.ForeColor = System.Drawing.Color.White
        Me.Clock1.FrameColor = System.Drawing.Color.White
        Me.Clock1.HourHand.Color = System.Drawing.Color.White
        Me.Clock1.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.HourHand.RelativeRadius = 0.65!
        Me.Clock1.HourHand.Tag = Nothing
        Me.Clock1.HourHand.Width = 4.0!
        Me.Clock1.Location = New System.Drawing.Point(812, 51)
        Me.Clock1.MinuteHand.Color = System.Drawing.Color.White
        Me.Clock1.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.MinuteHand.RelativeRadius = 0.8!
        Me.Clock1.MinuteHand.Tag = Nothing
        Me.Clock1.MinuteHand.Width = 2.0!
        Me.Clock1.Name = "Clock1"
        Me.Clock1.SecondHand.Color = System.Drawing.Color.White
        Me.Clock1.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.SecondHand.RelativeRadius = 0.9!
        Me.Clock1.SecondHand.Tag = Nothing
        Me.Clock1.SecondHand.Width = 1.0!
        Me.Clock1.Size = New System.Drawing.Size(131, 127)
        Me.Clock1.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.White, AnalogClock.MarkerStyle.Regular, True, 63.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.Clock1.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 0, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 1, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 2, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 3, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 4, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 5, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 6, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 7, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 8, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 9, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 10, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 11, False, True, AnalogClock.SymbolStyle.Numeric, 63.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing)}
        Me.Clock1.TabIndex = 4
        '
        'companyLogo
        '
        Me.companyLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.companyLogo.BackColor = System.Drawing.Color.Transparent
        Me.companyLogo.Image = CType(resources.GetObject("companyLogo.Image"), System.Drawing.Image)
        Me.companyLogo.Location = New System.Drawing.Point(555, 301)
        Me.companyLogo.Name = "companyLogo"
        Me.companyLogo.Padding = New System.Windows.Forms.Padding(5)
        Me.companyLogo.Size = New System.Drawing.Size(400, 150)
        Me.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.companyLogo.TabIndex = 6
        Me.companyLogo.TabStop = False
        '
        'lstImageFiles
        '
        Me.lstImageFiles.FormattingEnabled = True
        Me.lstImageFiles.Location = New System.Drawing.Point(12, 69)
        Me.lstImageFiles.Name = "lstImageFiles"
        Me.lstImageFiles.Size = New System.Drawing.Size(419, 134)
        Me.lstImageFiles.TabIndex = 7
        Me.lstImageFiles.Visible = False
        '
        'timerImages
        '
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(955, 463)
        Me.Controls.Add(Me.lstImageFiles)
        Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.companyLogo)
        Me.Controls.Add(Me.btnGuestbook)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patrakom"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDatetime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAttendance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuestbook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents companyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ConnectionStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lstImageFiles As System.Windows.Forms.ListBox
    Friend WithEvents timerImages As System.Windows.Forms.Timer

#End Region

End Class
