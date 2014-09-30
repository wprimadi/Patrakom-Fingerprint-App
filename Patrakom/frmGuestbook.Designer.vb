<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestbook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuestbook))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.lblDatetime = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Clock1 = New AnalogClock.Clock()
        Me.pnlSearchVisitor = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtVisitorID = New DevExpress.XtraEditors.TextEdit()
        Me.lblVisitorID = New DevExpress.XtraEditors.LabelControl()
        Me.timerImages = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGuestbook = New DevExpress.XtraEditors.PanelControl()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.lblEmpID = New DevExpress.XtraEditors.LabelControl()
        Me.lblPhone = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.lblPersonName = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txtPerson = New DevExpress.XtraEditors.TokenEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDuration = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReason = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblID = New DevExpress.XtraEditors.LabelControl()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.companyLogo = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuestbook = New DevExpress.XtraEditors.SimpleButton()
        Me.WebCameraControl1 = New WebCam.WebCameraControl()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompany = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlSearchVisitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchVisitor.SuspendLayout()
        CType(Me.txtVisitorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlGuestbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGuestbook.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 2
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        Me.Clock1.TabIndex = 16
        '
        'pnlSearchVisitor
        '
        Me.pnlSearchVisitor.Controls.Add(Me.btnSearch)
        Me.pnlSearchVisitor.Controls.Add(Me.txtVisitorID)
        Me.pnlSearchVisitor.Controls.Add(Me.lblVisitorID)
        Me.pnlSearchVisitor.Location = New System.Drawing.Point(12, 51)
        Me.pnlSearchVisitor.Name = "pnlSearchVisitor"
        Me.pnlSearchVisitor.Size = New System.Drawing.Size(273, 122)
        Me.pnlSearchVisitor.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(7, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(261, 46)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "&Search"
        '
        'txtVisitorID
        '
        Me.txtVisitorID.Location = New System.Drawing.Point(5, 36)
        Me.txtVisitorID.Name = "txtVisitorID"
        Me.txtVisitorID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitorID.Properties.Appearance.Options.UseFont = True
        Me.txtVisitorID.Properties.LookAndFeel.SkinName = "Metropolis"
        Me.txtVisitorID.Size = New System.Drawing.Size(261, 26)
        Me.txtVisitorID.TabIndex = 10
        '
        'lblVisitorID
        '
        Me.lblVisitorID.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorID.Location = New System.Drawing.Point(5, 5)
        Me.lblVisitorID.Name = "lblVisitorID"
        Me.lblVisitorID.Size = New System.Drawing.Size(87, 25)
        Me.lblVisitorID.TabIndex = 9
        Me.lblVisitorID.Text = "Visitor ID"
        '
        'timerImages
        '
        '
        'pnlGuestbook
        '
        Me.pnlGuestbook.Controls.Add(Me.LabelControl6)
        Me.pnlGuestbook.Controls.Add(Me.LabelControl5)
        Me.pnlGuestbook.Controls.Add(Me.txtPhone)
        Me.pnlGuestbook.Controls.Add(Me.FlyoutPanel1)
        Me.pnlGuestbook.Controls.Add(Me.txtPerson)
        Me.pnlGuestbook.Controls.Add(Me.LabelControl4)
        Me.pnlGuestbook.Controls.Add(Me.LabelControl3)
        Me.pnlGuestbook.Controls.Add(Me.txtDuration)
        Me.pnlGuestbook.Controls.Add(Me.LabelControl2)
        Me.pnlGuestbook.Controls.Add(Me.btnSave)
        Me.pnlGuestbook.Controls.Add(Me.txtReason)
        Me.pnlGuestbook.Controls.Add(Me.LabelControl1)
        Me.pnlGuestbook.Controls.Add(Me.lblID)
        Me.pnlGuestbook.Controls.Add(Me.lblName)
        Me.pnlGuestbook.Controls.Add(Me.txtCompany)
        Me.pnlGuestbook.Location = New System.Drawing.Point(207, 51)
        Me.pnlGuestbook.Name = "pnlGuestbook"
        Me.pnlGuestbook.Size = New System.Drawing.Size(540, 400)
        Me.pnlGuestbook.TabIndex = 19
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(123, 7)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Size = New System.Drawing.Size(406, 132)
        Me.FlyoutPanel1.TabIndex = 12
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FlyoutPanelControl1.Controls.Add(Me.lblEmpID)
        Me.FlyoutPanelControl1.Controls.Add(Me.lblPhone)
        Me.FlyoutPanelControl1.Controls.Add(Me.lblEmail)
        Me.FlyoutPanelControl1.Controls.Add(Me.lblPersonName)
        Me.FlyoutPanelControl1.Controls.Add(Me.PictureEdit1)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(406, 132)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'lblEmpID
        '
        Me.lblEmpID.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpID.Location = New System.Drawing.Point(133, 84)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(24, 19)
        Me.lblEmpID.TabIndex = 13
        Me.lblEmpID.Text = "xxx"
        '
        'lblPhone
        '
        Me.lblPhone.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(133, 59)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(24, 19)
        Me.lblPhone.TabIndex = 12
        Me.lblPhone.Text = "xxx"
        '
        'lblEmail
        '
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(133, 34)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(24, 19)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "xxx"
        '
        'lblPersonName
        '
        Me.lblPersonName.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonName.Location = New System.Drawing.Point(133, 5)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(28, 23)
        Me.lblPersonName.TabIndex = 10
        Me.lblPersonName.Text = "xxx"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImage = CType(resources.GetObject("PictureEdit1.BackgroundImage"), System.Drawing.Image)
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit1.Location = New System.Drawing.Point(5, 5)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Size = New System.Drawing.Size(122, 122)
        Me.PictureEdit1.TabIndex = 0
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(12, 218)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson.Properties.Appearance.Options.UseFont = True
        Me.txtPerson.Properties.MaxExpandLines = 1
        Me.txtPerson.Properties.PopupFilterMode = DevExpress.XtraEditors.TokenEditPopupFilterMode.Contains
        Me.txtPerson.Properties.PopupPanel = Me.FlyoutPanel1
        Me.txtPerson.Properties.Separators.AddRange(New String() {",", ";"})
        Me.txtPerson.Properties.ValidationRules = CType((DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnLostFocus Or DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnSeparatorInput), DevExpress.XtraEditors.TokenEditValidationRules)
        Me.txtPerson.Size = New System.Drawing.Size(517, 26)
        Me.txtPerson.TabIndex = 11
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 193)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Person to Meet"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(191, 360)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Minutes"
        '
        'txtDuration
        '
        Me.txtDuration.EditValue = "30"
        Me.txtDuration.Location = New System.Drawing.Point(85, 357)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Properties.Appearance.Options.UseFont = True
        Me.txtDuration.Size = New System.Drawing.Size(100, 22)
        Me.txtDuration.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 357)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Duration:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(351, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(178, 47)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(12, 272)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Properties.Appearance.Options.UseFont = True
        Me.txtReason.Size = New System.Drawing.Size(517, 70)
        Me.txtReason.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 247)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(195, 19)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Describe your requirements"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(12, 36)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(31, 25)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "xxx"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(31, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "xxx"
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
        Me.companyLogo.TabIndex = 15
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
        Me.btnDashboard.TabIndex = 14
        Me.btnDashboard.Text = "Attendance"
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
        Me.btnGuestbook.Location = New System.Drawing.Point(12, 331)
        Me.btnGuestbook.Name = "btnGuestbook"
        Me.btnGuestbook.Size = New System.Drawing.Size(120, 120)
        Me.btnGuestbook.TabIndex = 13
        Me.btnGuestbook.Text = "Attendance"
        '
        'WebCameraControl1
        '
        Me.WebCameraControl1.BackColor = System.Drawing.SystemColors.Control
        Me.WebCameraControl1.Location = New System.Drawing.Point(12, 51)
        Me.WebCameraControl1.Name = "WebCameraControl1"
        Me.WebCameraControl1.Size = New System.Drawing.Size(189, 202)
        Me.WebCameraControl1.TabIndex = 20
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(12, 161)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Properties.Appearance.Options.UseFont = True
        Me.txtPhone.Size = New System.Drawing.Size(517, 26)
        Me.txtPhone.TabIndex = 13
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 136)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(106, 19)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Phone Number"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 79)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Company"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(12, 104)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Size = New System.Drawing.Size(517, 26)
        Me.txtCompany.TabIndex = 16
        '
        'frmGuestbook
        '
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 463)
        Me.Controls.Add(Me.WebCameraControl1)
        Me.Controls.Add(Me.pnlGuestbook)
        Me.Controls.Add(Me.pnlSearchVisitor)
        Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.companyLogo)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnGuestbook)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGuestbook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGuestbook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlSearchVisitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchVisitor.ResumeLayout(False)
        Me.pnlSearchVisitor.PerformLayout()
        CType(Me.txtVisitorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlGuestbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGuestbook.ResumeLayout(False)
        Me.pnlGuestbook.PerformLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        Me.FlyoutPanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ConnectionStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblDatetime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents companyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnDashboard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuestbook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents pnlSearchVisitor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtVisitorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblVisitorID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents timerImages As System.Windows.Forms.Timer
    Friend WithEvents pnlGuestbook As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDuration As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPerson As DevExpress.XtraEditors.TokenEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblPersonName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPhone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmpID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WebCameraControl1 As WebCam.WebCameraControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCompany As DevExpress.XtraEditors.TextEdit
End Class
