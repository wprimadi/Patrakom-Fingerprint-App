<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckin))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.lblDatetime = New DevExpress.XtraEditors.LabelControl()
        Me.btnAttendance = New DevExpress.XtraEditors.SimpleButton()
        Me.Clock1 = New AnalogClock.Clock()
        Me.btnDashboard = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCheckIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCheckOut = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.companyLogo = New System.Windows.Forms.PictureBox()
        Me.pnlMessage = New DevExpress.XtraEditors.PanelControl()
        Me.lblMessage = New DevExpress.XtraEditors.LabelControl()
        Me.pnlPhoto = New System.Windows.Forms.PictureBox()
        Me.pnlInfo = New DevExpress.XtraEditors.PanelControl()
        Me.txtDept = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdNumber = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeName = New DevExpress.XtraEditors.LabelControl()
        Me.btnShiftIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnShiftOut = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReplacementShift = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlInfo2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnReason = New DevExpress.XtraEditors.SimpleButton()
        Me.txtInfo = New DevExpress.XtraEditors.LabelControl()
        Me.txtReason = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDept2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdNumber2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeName2 = New DevExpress.XtraEditors.LabelControl()
        Me.timerImages = New System.Windows.Forms.Timer(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMessage.SuspendLayout()
        CType(Me.pnlPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        CType(Me.pnlInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo2.SuspendLayout()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 1
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectionStatus.Image = CType(resources.GetObject("ConnectionStatus.Image"), System.Drawing.Image)
        Me.ConnectionStatus.Location = New System.Drawing.Point(920, 4)
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(31, 26)
        Me.ConnectionStatus.TabIndex = 2
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
        Me.btnAttendance.Location = New System.Drawing.Point(12, 331)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(120, 120)
        Me.btnAttendance.TabIndex = 2
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.Visible = False
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
        Me.Clock1.TabIndex = 8
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnDashboard.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDashboard.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnDashboard.Appearance.Options.UseBackColor = True
        Me.btnDashboard.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDashboard.Location = New System.Drawing.Point(147, 331)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(120, 120)
        Me.btnDashboard.TabIndex = 9
        Me.btnDashboard.Text = "Attendance"
        Me.btnDashboard.Visible = False
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnCheckIn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckIn.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCheckIn.Appearance.Options.UseBackColor = True
        Me.btnCheckIn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCheckIn.Image = CType(resources.GetObject("btnCheckIn.Image"), System.Drawing.Image)
        Me.btnCheckIn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCheckIn.Location = New System.Drawing.Point(12, 51)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(120, 120)
        Me.btnCheckIn.TabIndex = 10
        Me.btnCheckIn.Text = "CheckIn"
        Me.btnCheckIn.Visible = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnCheckOut.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckOut.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCheckOut.Appearance.Options.UseBackColor = True
        Me.btnCheckOut.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCheckOut.Image = CType(resources.GetObject("btnCheckOut.Image"), System.Drawing.Image)
        Me.btnCheckOut.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCheckOut.Location = New System.Drawing.Point(147, 51)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(120, 120)
        Me.btnCheckOut.TabIndex = 11
        Me.btnCheckOut.Text = "CheckOut"
        Me.btnCheckOut.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        Me.companyLogo.TabIndex = 12
        Me.companyLogo.TabStop = False
        '
        'pnlMessage
        '
        Me.pnlMessage.Appearance.BackColor = System.Drawing.Color.Red
        Me.pnlMessage.Appearance.Options.UseBackColor = True
        Me.pnlMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlMessage.Controls.Add(Me.lblMessage)
        Me.pnlMessage.Location = New System.Drawing.Point(0, 51)
        Me.pnlMessage.Name = "pnlMessage"
        Me.pnlMessage.Size = New System.Drawing.Size(616, 48)
        Me.pnlMessage.TabIndex = 13
        Me.pnlMessage.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(12, 12)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(28, 23)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "xxx"
        '
        'pnlPhoto
        '
        Me.pnlPhoto.BackgroundImage = CType(resources.GetObject("pnlPhoto.BackgroundImage"), System.Drawing.Image)
        Me.pnlPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPhoto.Location = New System.Drawing.Point(12, 51)
        Me.pnlPhoto.Name = "pnlPhoto"
        Me.pnlPhoto.Size = New System.Drawing.Size(127, 127)
        Me.pnlPhoto.TabIndex = 14
        Me.pnlPhoto.TabStop = False
        Me.pnlPhoto.Visible = False
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.txtDept)
        Me.pnlInfo.Controls.Add(Me.txtIdNumber)
        Me.pnlInfo.Controls.Add(Me.txtEmployeeName)
        Me.pnlInfo.Location = New System.Drawing.Point(147, 51)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(469, 127)
        Me.pnlInfo.TabIndex = 15
        Me.pnlInfo.Visible = False
        '
        'txtDept
        '
        Me.txtDept.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.Location = New System.Drawing.Point(16, 78)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(24, 19)
        Me.txtDept.TabIndex = 7
        Me.txtDept.Text = "xxx"
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNumber.Location = New System.Drawing.Point(16, 54)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(29, 19)
        Me.txtIdNumber.TabIndex = 6
        Me.txtIdNumber.Text = "[ID]"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(16, 20)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(31, 25)
        Me.txtEmployeeName.TabIndex = 5
        Me.txtEmployeeName.Text = "xxx"
        '
        'btnShiftIn
        '
        Me.btnShiftIn.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnShiftIn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShiftIn.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnShiftIn.Appearance.Options.UseBackColor = True
        Me.btnShiftIn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnShiftIn.Image = CType(resources.GetObject("btnShiftIn.Image"), System.Drawing.Image)
        Me.btnShiftIn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnShiftIn.Location = New System.Drawing.Point(12, 177)
        Me.btnShiftIn.Name = "btnShiftIn"
        Me.btnShiftIn.Size = New System.Drawing.Size(120, 120)
        Me.btnShiftIn.TabIndex = 16
        Me.btnShiftIn.Text = "CheckIn"
        Me.btnShiftIn.Visible = False
        '
        'btnShiftOut
        '
        Me.btnShiftOut.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnShiftOut.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShiftOut.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnShiftOut.Appearance.Options.UseBackColor = True
        Me.btnShiftOut.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnShiftOut.Image = CType(resources.GetObject("btnShiftOut.Image"), System.Drawing.Image)
        Me.btnShiftOut.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnShiftOut.Location = New System.Drawing.Point(147, 177)
        Me.btnShiftOut.Name = "btnShiftOut"
        Me.btnShiftOut.Size = New System.Drawing.Size(120, 120)
        Me.btnShiftOut.TabIndex = 17
        Me.btnShiftOut.Text = "CheckIn"
        Me.btnShiftOut.Visible = False
        '
        'btnReplacementShift
        '
        Me.btnReplacementShift.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnReplacementShift.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReplacementShift.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnReplacementShift.Appearance.Options.UseBackColor = True
        Me.btnReplacementShift.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnReplacementShift.Image = CType(resources.GetObject("btnReplacementShift.Image"), System.Drawing.Image)
        Me.btnReplacementShift.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnReplacementShift.Location = New System.Drawing.Point(282, 177)
        Me.btnReplacementShift.Name = "btnReplacementShift"
        Me.btnReplacementShift.Size = New System.Drawing.Size(120, 120)
        Me.btnReplacementShift.TabIndex = 18
        Me.btnReplacementShift.Text = "CheckIn"
        Me.btnReplacementShift.Visible = False
        '
        'pnlInfo2
        '
        Me.pnlInfo2.Controls.Add(Me.btnReason)
        Me.pnlInfo2.Controls.Add(Me.txtInfo)
        Me.pnlInfo2.Controls.Add(Me.txtReason)
        Me.pnlInfo2.Controls.Add(Me.txtDept2)
        Me.pnlInfo2.Controls.Add(Me.txtIdNumber2)
        Me.pnlInfo2.Controls.Add(Me.txtEmployeeName2)
        Me.pnlInfo2.Location = New System.Drawing.Point(145, 51)
        Me.pnlInfo2.Name = "pnlInfo2"
        Me.pnlInfo2.Size = New System.Drawing.Size(469, 330)
        Me.pnlInfo2.TabIndex = 19
        Me.pnlInfo2.Visible = False
        '
        'btnReason
        '
        Me.btnReason.Location = New System.Drawing.Point(17, 259)
        Me.btnReason.Name = "btnReason"
        Me.btnReason.Size = New System.Drawing.Size(435, 58)
        Me.btnReason.TabIndex = 13
        Me.btnReason.Text = "&Submit Reason"
        '
        'txtInfo
        '
        Me.txtInfo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtInfo.Location = New System.Drawing.Point(17, 108)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(24, 19)
        Me.txtInfo.TabIndex = 12
        Me.txtInfo.Text = "xxx"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(17, 144)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(435, 109)
        Me.txtReason.TabIndex = 11
        '
        'txtDept2
        '
        Me.txtDept2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept2.Location = New System.Drawing.Point(17, 73)
        Me.txtDept2.Name = "txtDept2"
        Me.txtDept2.Size = New System.Drawing.Size(24, 19)
        Me.txtDept2.TabIndex = 10
        Me.txtDept2.Text = "xxx"
        '
        'txtIdNumber2
        '
        Me.txtIdNumber2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNumber2.Location = New System.Drawing.Point(17, 49)
        Me.txtIdNumber2.Name = "txtIdNumber2"
        Me.txtIdNumber2.Size = New System.Drawing.Size(29, 19)
        Me.txtIdNumber2.TabIndex = 9
        Me.txtIdNumber2.Text = "[ID]"
        '
        'txtEmployeeName2
        '
        Me.txtEmployeeName2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName2.Location = New System.Drawing.Point(17, 15)
        Me.txtEmployeeName2.Name = "txtEmployeeName2"
        Me.txtEmployeeName2.Size = New System.Drawing.Size(31, 25)
        Me.txtEmployeeName2.TabIndex = 8
        Me.txtEmployeeName2.Text = "xxx"
        '
        'timerImages
        '
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(398, 415)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 20
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'frmCheckin
        '
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 463)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.pnlInfo2)
        Me.Controls.Add(Me.btnReplacementShift)
        Me.Controls.Add(Me.btnShiftOut)
        Me.Controls.Add(Me.btnShiftIn)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlPhoto)
        Me.Controls.Add(Me.pnlMessage)
        Me.Controls.Add(Me.companyLogo)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Office 2013"
        Me.Name = "frmCheckin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMessage.ResumeLayout(False)
        Me.pnlMessage.PerformLayout()
        CType(Me.pnlPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        CType(Me.pnlInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo2.ResumeLayout(False)
        Me.pnlInfo2.PerformLayout()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDatetime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAttendance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents btnDashboard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCheckIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCheckOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ConnectionStatus As System.Windows.Forms.PictureBox
    Friend WithEvents companyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMessage As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents pnlInfo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDept As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployeeName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnShiftIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShiftOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReplacementShift As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlInfo2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnReason As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDept2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdNumber2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployeeName2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents timerImages As System.Windows.Forms.Timer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
