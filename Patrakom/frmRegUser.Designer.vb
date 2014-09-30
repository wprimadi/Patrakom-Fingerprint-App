<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegUser))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.lblDatetime = New DevExpress.XtraEditors.LabelControl()
        Me.Clock1 = New AnalogClock.Clock()
        Me.companyLogo = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExitSetting = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmployeeID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.FP1 = New System.Windows.Forms.PictureBox()
        Me.FP6 = New System.Windows.Forms.PictureBox()
        Me.FP2 = New System.Windows.Forms.PictureBox()
        Me.FP3 = New System.Windows.Forms.PictureBox()
        Me.FP4 = New System.Windows.Forms.PictureBox()
        Me.FP5 = New System.Windows.Forms.PictureBox()
        Me.FP7 = New System.Windows.Forms.PictureBox()
        Me.FP8 = New System.Windows.Forms.PictureBox()
        Me.FP9 = New System.Windows.Forms.PictureBox()
        Me.FP10 = New System.Windows.Forms.PictureBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.pbIdicator4 = New System.Windows.Forms.PictureBox()
        Me.pbIdicator3 = New System.Windows.Forms.PictureBox()
        Me.pbIdicator2 = New System.Windows.Forms.PictureBox()
        Me.pbIdicator1 = New System.Windows.Forms.PictureBox()
        Me.txtDept = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdNumber = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeName = New DevExpress.XtraEditors.LabelControl()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.picFingerprint = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerImages = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtEmployeeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FP10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.pbIdicator4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIdicator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIdicator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIdicator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.picFingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 18
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
        Me.Clock1.TabIndex = 22
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
        Me.companyLogo.TabIndex = 21
        Me.companyLogo.TabStop = False
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
        Me.btnDashboard.TabIndex = 24
        Me.btnDashboard.Text = "Attendance"
        '
        'btnExitSetting
        '
        Me.btnExitSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExitSetting.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnExitSetting.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExitSetting.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnExitSetting.Appearance.Options.UseBackColor = True
        Me.btnExitSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnExitSetting.Image = CType(resources.GetObject("btnExitSetting.Image"), System.Drawing.Image)
        Me.btnExitSetting.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExitSetting.Location = New System.Drawing.Point(12, 331)
        Me.btnExitSetting.Name = "btnExitSetting"
        Me.btnExitSetting.Size = New System.Drawing.Size(120, 120)
        Me.btnExitSetting.TabIndex = 23
        Me.btnExitSetting.Text = "Attendance"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Controls.Add(Me.txtEmployeeID)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 51)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(272, 127)
        Me.PanelControl2.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(14, 75)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(241, 43)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Search"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(14, 39)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Properties.Appearance.Options.UseFont = True
        Me.txtEmployeeID.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.txtEmployeeID.Size = New System.Drawing.Size(241, 30)
        Me.txtEmployeeID.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 23)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Employee ID"
        '
        'FP1
        '
        Me.FP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FP1.Image = CType(resources.GetObject("FP1.Image"), System.Drawing.Image)
        Me.FP1.Location = New System.Drawing.Point(290, 51)
        Me.FP1.Name = "FP1"
        Me.FP1.Size = New System.Drawing.Size(50, 60)
        Me.FP1.TabIndex = 26
        Me.FP1.TabStop = False
        '
        'FP6
        '
        Me.FP6.BackColor = System.Drawing.Color.Transparent
        Me.FP6.Image = CType(resources.GetObject("FP6.Image"), System.Drawing.Image)
        Me.FP6.Location = New System.Drawing.Point(290, 118)
        Me.FP6.Name = "FP6"
        Me.FP6.Size = New System.Drawing.Size(50, 60)
        Me.FP6.TabIndex = 27
        Me.FP6.TabStop = False
        '
        'FP2
        '
        Me.FP2.BackColor = System.Drawing.Color.Transparent
        Me.FP2.Image = CType(resources.GetObject("FP2.Image"), System.Drawing.Image)
        Me.FP2.Location = New System.Drawing.Point(346, 51)
        Me.FP2.Name = "FP2"
        Me.FP2.Size = New System.Drawing.Size(50, 60)
        Me.FP2.TabIndex = 28
        Me.FP2.TabStop = False
        '
        'FP3
        '
        Me.FP3.BackColor = System.Drawing.Color.Transparent
        Me.FP3.Image = CType(resources.GetObject("FP3.Image"), System.Drawing.Image)
        Me.FP3.Location = New System.Drawing.Point(402, 51)
        Me.FP3.Name = "FP3"
        Me.FP3.Size = New System.Drawing.Size(50, 60)
        Me.FP3.TabIndex = 29
        Me.FP3.TabStop = False
        '
        'FP4
        '
        Me.FP4.BackColor = System.Drawing.Color.Transparent
        Me.FP4.Image = CType(resources.GetObject("FP4.Image"), System.Drawing.Image)
        Me.FP4.Location = New System.Drawing.Point(458, 51)
        Me.FP4.Name = "FP4"
        Me.FP4.Size = New System.Drawing.Size(50, 60)
        Me.FP4.TabIndex = 30
        Me.FP4.TabStop = False
        '
        'FP5
        '
        Me.FP5.BackColor = System.Drawing.Color.Transparent
        Me.FP5.Image = CType(resources.GetObject("FP5.Image"), System.Drawing.Image)
        Me.FP5.Location = New System.Drawing.Point(514, 51)
        Me.FP5.Name = "FP5"
        Me.FP5.Size = New System.Drawing.Size(50, 60)
        Me.FP5.TabIndex = 31
        Me.FP5.TabStop = False
        '
        'FP7
        '
        Me.FP7.BackColor = System.Drawing.Color.Transparent
        Me.FP7.Image = CType(resources.GetObject("FP7.Image"), System.Drawing.Image)
        Me.FP7.Location = New System.Drawing.Point(346, 118)
        Me.FP7.Name = "FP7"
        Me.FP7.Size = New System.Drawing.Size(50, 60)
        Me.FP7.TabIndex = 32
        Me.FP7.TabStop = False
        '
        'FP8
        '
        Me.FP8.BackColor = System.Drawing.Color.Transparent
        Me.FP8.Image = CType(resources.GetObject("FP8.Image"), System.Drawing.Image)
        Me.FP8.Location = New System.Drawing.Point(402, 118)
        Me.FP8.Name = "FP8"
        Me.FP8.Size = New System.Drawing.Size(50, 60)
        Me.FP8.TabIndex = 33
        Me.FP8.TabStop = False
        '
        'FP9
        '
        Me.FP9.BackColor = System.Drawing.Color.Transparent
        Me.FP9.Image = CType(resources.GetObject("FP9.Image"), System.Drawing.Image)
        Me.FP9.Location = New System.Drawing.Point(458, 118)
        Me.FP9.Name = "FP9"
        Me.FP9.Size = New System.Drawing.Size(50, 60)
        Me.FP9.TabIndex = 34
        Me.FP9.TabStop = False
        '
        'FP10
        '
        Me.FP10.BackColor = System.Drawing.Color.Transparent
        Me.FP10.Image = CType(resources.GetObject("FP10.Image"), System.Drawing.Image)
        Me.FP10.Location = New System.Drawing.Point(514, 118)
        Me.FP10.Name = "FP10"
        Me.FP10.Size = New System.Drawing.Size(50, 60)
        Me.FP10.TabIndex = 35
        Me.FP10.TabStop = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.pbIdicator4)
        Me.PanelControl3.Controls.Add(Me.pbIdicator3)
        Me.PanelControl3.Controls.Add(Me.pbIdicator2)
        Me.PanelControl3.Controls.Add(Me.pbIdicator1)
        Me.PanelControl3.Controls.Add(Me.txtDept)
        Me.PanelControl3.Controls.Add(Me.txtIdNumber)
        Me.PanelControl3.Controls.Add(Me.txtEmployeeName)
        Me.PanelControl3.Controls.Add(Me.picPhoto)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 184)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(406, 140)
        Me.PanelControl3.TabIndex = 36
        '
        'pbIdicator4
        '
        Me.pbIdicator4.BackColor = System.Drawing.Color.DarkGreen
        Me.pbIdicator4.Location = New System.Drawing.Point(342, 114)
        Me.pbIdicator4.Name = "pbIdicator4"
        Me.pbIdicator4.Size = New System.Drawing.Size(60, 21)
        Me.pbIdicator4.TabIndex = 8
        Me.pbIdicator4.TabStop = False
        '
        'pbIdicator3
        '
        Me.pbIdicator3.BackColor = System.Drawing.Color.DarkGreen
        Me.pbIdicator3.Location = New System.Drawing.Point(276, 114)
        Me.pbIdicator3.Name = "pbIdicator3"
        Me.pbIdicator3.Size = New System.Drawing.Size(60, 21)
        Me.pbIdicator3.TabIndex = 7
        Me.pbIdicator3.TabStop = False
        '
        'pbIdicator2
        '
        Me.pbIdicator2.BackColor = System.Drawing.Color.DarkGreen
        Me.pbIdicator2.Location = New System.Drawing.Point(210, 114)
        Me.pbIdicator2.Name = "pbIdicator2"
        Me.pbIdicator2.Size = New System.Drawing.Size(60, 21)
        Me.pbIdicator2.TabIndex = 6
        Me.pbIdicator2.TabStop = False
        '
        'pbIdicator1
        '
        Me.pbIdicator1.BackColor = System.Drawing.Color.DarkGreen
        Me.pbIdicator1.Location = New System.Drawing.Point(144, 114)
        Me.pbIdicator1.Name = "pbIdicator1"
        Me.pbIdicator1.Size = New System.Drawing.Size(60, 21)
        Me.pbIdicator1.TabIndex = 5
        Me.pbIdicator1.TabStop = False
        '
        'txtDept
        '
        Me.txtDept.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.Location = New System.Drawing.Point(144, 66)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(24, 19)
        Me.txtDept.TabIndex = 4
        Me.txtDept.Text = "xxx"
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNumber.Location = New System.Drawing.Point(144, 42)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(29, 19)
        Me.txtIdNumber.TabIndex = 3
        Me.txtIdNumber.Text = "[ID]"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(144, 8)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(31, 25)
        Me.txtEmployeeName.TabIndex = 2
        Me.txtEmployeeName.Text = "xxx"
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhoto.Location = New System.Drawing.Point(2, 2)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(136, 136)
        Me.picPhoto.TabIndex = 1
        Me.picPhoto.TabStop = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.picFingerprint)
        Me.PanelControl4.Location = New System.Drawing.Point(424, 184)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(140, 140)
        Me.PanelControl4.TabIndex = 37
        '
        'picFingerprint
        '
        Me.picFingerprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFingerprint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFingerprint.Location = New System.Drawing.Point(2, 2)
        Me.picFingerprint.Name = "picFingerprint"
        Me.picFingerprint.Size = New System.Drawing.Size(136, 136)
        Me.picFingerprint.TabIndex = 0
        Me.picFingerprint.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'timerImages
        '
        '
        'frmRegUser
        '
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 463)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.FP10)
        Me.Controls.Add(Me.FP9)
        Me.Controls.Add(Me.FP8)
        Me.Controls.Add(Me.FP7)
        Me.Controls.Add(Me.FP5)
        Me.Controls.Add(Me.FP4)
        Me.Controls.Add(Me.FP3)
        Me.Controls.Add(Me.FP2)
        Me.Controls.Add(Me.FP6)
        Me.Controls.Add(Me.FP1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnExitSetting)
        Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.companyLogo)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtEmployeeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FP10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.pbIdicator4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIdicator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIdicator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIdicator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.picFingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ConnectionStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblDatetime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents companyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnDashboard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExitSetting As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmployeeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FP1 As System.Windows.Forms.PictureBox
    Friend WithEvents FP6 As System.Windows.Forms.PictureBox
    Friend WithEvents FP2 As System.Windows.Forms.PictureBox
    Friend WithEvents FP3 As System.Windows.Forms.PictureBox
    Friend WithEvents FP4 As System.Windows.Forms.PictureBox
    Friend WithEvents FP5 As System.Windows.Forms.PictureBox
    Friend WithEvents FP7 As System.Windows.Forms.PictureBox
    Friend WithEvents FP8 As System.Windows.Forms.PictureBox
    Friend WithEvents FP9 As System.Windows.Forms.PictureBox
    Friend WithEvents FP10 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents picFingerprint As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtEmployeeName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDept As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbIdicator4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbIdicator3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbIdicator2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbIdicator1 As System.Windows.Forms.PictureBox
    Friend WithEvents timerImages As System.Windows.Forms.Timer
End Class
