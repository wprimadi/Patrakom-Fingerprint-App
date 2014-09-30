
Partial Public Class frm4RowKeyboard
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
        Me.keyButtonUp = New KeyButton()
        Me.keyButtonRControl = New KeyButton()
        Me.keyButtonProcess = New KeyButton()
        Me.keyButtonOpenBrackets = New KeyButton()
        Me.keyButtonF10 = New KeyButton()
        Me.keyButtonD0 = New KeyButton()
        Me.keyButtonRight = New KeyButton()
        Me.keyButtonRShift = New KeyButton()
        Me.keyButtonReturn = New KeyButton()
        Me.keyButtonDelete = New KeyButton()
        Me.keyButtonScrollLock = New KeyButton()
        Me.keyButtonPause = New KeyButton()
        Me.keyButtonPageDown = New KeyButton()
        Me.keyButtonPageUp = New KeyButton()
        Me.keyButtonPrintScreen = New KeyButton()
        Me.keyButtonInsert = New KeyButton()
        Me.keyButtonEnd = New KeyButton()
        Me.keyButtonHome = New KeyButton()
        Me.keyButtonBack = New KeyButton()
        Me.keyButtonDown = New KeyButton()
        Me.keyButtonOemPipe = New KeyButton()
        Me.keyButtonPlus = New KeyButton()
        Me.keyButtonLeft = New KeyButton()
        Me.keyButtonCloseBrackets = New KeyButton()
        Me.keyButtonMinus = New KeyButton()
        Me.keyButtonApps = New KeyButton()
        Me.keyButtonQuestion = New KeyButton()
        Me.keyButtonSemicolon = New KeyButton()
        Me.keyButtonP = New KeyButton()
        Me.keyButtonF9 = New KeyButton()
        Me.keyButtonD9 = New KeyButton()
        Me.keyButtonRAlt = New KeyButton()
        Me.keyButtonPeriod = New KeyButton()
        Me.keyButtonL = New KeyButton()
        Me.keyButtonO = New KeyButton()
        Me.keyButtonSubtract = New KeyButton()
        Me.keyButtonMultiply = New KeyButton()
        Me.keyButtonDivide = New KeyButton()
        Me.keyButtonF8 = New KeyButton()
        Me.keyButtonD8 = New KeyButton()
        Me.keyButtonComma = New KeyButton()
        Me.keyButtonK = New KeyButton()
        Me.keyButtonI = New KeyButton()
        Me.keyButtonAdd = New KeyButton()
        Me.keyButtonNumberPad3 = New KeyButton()
        Me.keyButtonNumberPad6 = New KeyButton()
        Me.keyButtonNumberPad9 = New KeyButton()
        Me.keyButtonF7 = New KeyButton()
        Me.keyButtonD7 = New KeyButton()
        Me.keyButtonM = New KeyButton()
        Me.keyButtonJ = New KeyButton()
        Me.keyButtonU = New KeyButton()
        Me.keyButtonNumLock = New KeyButton()
        Me.keyButtonDecimal = New KeyButton()
        Me.keyButtonNumberPad2 = New KeyButton()
        Me.keyButtonNumberPad5 = New KeyButton()
        Me.keyButtonNumberPad8 = New KeyButton()
        Me.keyButtonF6 = New KeyButton()
        Me.keyButtonD6 = New KeyButton()
        Me.keyButtonN = New KeyButton()
        Me.keyButtonH = New KeyButton()
        Me.keyButtonY = New KeyButton()
        Me.keyButtonNumReturn = New KeyButton()
        Me.keyButtonNumberPad0 = New KeyButton()
        Me.keyButtonNumberPad1 = New KeyButton()
        Me.keyButtonNumberPad4 = New KeyButton()
        Me.keyButtonNumberPad7 = New KeyButton()
        Me.keyButtonF5 = New KeyButton()
        Me.keyButtonD5 = New KeyButton()
        Me.keyButtonB = New KeyButton()
        Me.keyButtonG = New KeyButton()
        Me.keyButtonT = New KeyButton()
        Me.keyButtonF4 = New KeyButton()
        Me.keyButtonD4 = New KeyButton()
        Me.keyButtonV = New KeyButton()
        Me.keyButtonF = New KeyButton()
        Me.keyButtonR = New KeyButton()
        Me.keyButtonF3 = New KeyButton()
        Me.keyButtonD3 = New KeyButton()
        Me.keyButtonSpace = New KeyButton()
        Me.keyButtonC = New KeyButton()
        Me.keyButtonD = New KeyButton()
        Me.keyButtonE = New KeyButton()
        Me.keyButtonF12 = New KeyButton()
        Me.keyButtonF2 = New KeyButton()
        Me.keyButtonD2 = New KeyButton()
        Me.keyButtonLAlt = New KeyButton()
        Me.keyButtonX = New KeyButton()
        Me.keyButtonS = New KeyButton()
        Me.keyButtonW = New KeyButton()
        Me.keyButtonF11 = New KeyButton()
        Me.keyButtonF1 = New KeyButton()
        Me.keyButtonD1 = New KeyButton()
        Me.keyButtonWin = New KeyButton()
        Me.keyButtonZ = New KeyButton()
        Me.keyButtonA = New KeyButton()
        Me.keyButtonQ = New KeyButton()
        Me.keyButtonTilde = New KeyButton()
        Me.keyButtonLControl = New KeyButton()
        Me.keyButtonLShift = New KeyButton()
        Me.keyButtonCapsLock = New KeyButton()
        Me.keyButtonTab = New KeyButton()
        Me.keyButtonEscape = New KeyButton()
        Me.KeyButton1 = New KeyButton()
        Me.KeyButton2 = New KeyButton()
        Me.KeyButton3 = New KeyButton()
        Me.KeyButton5 = New KeyButton()
        Me.KeyButton6 = New KeyButton()
        Me.KeyButton7 = New KeyButton()
        Me.KeyButton8 = New KeyButton()
        Me.KeyButton14 = New KeyButton()
        Me.KeyButton15 = New KeyButton()
        Me.KeyButton16 = New KeyButton()
        Me.KeyButton17 = New KeyButton()
        Me.KeyButton18 = New KeyButton()
        Me.KeyButton19 = New KeyButton()
        Me.KeyButton20 = New KeyButton()
        Me.KeyButton21 = New KeyButton()
        Me.KeyButton22 = New KeyButton()
        Me.KeyButton23 = New KeyButton()
        Me.KeyButton24 = New KeyButton()
        Me.KeyButton25 = New KeyButton()
        Me.KeyButton26 = New KeyButton()
        Me.KeyButton27 = New KeyButton()
        Me.KeyButton28 = New KeyButton()
        Me.KeyButton29 = New KeyButton()
        Me.KeyButton30 = New KeyButton()
        Me.KeyButton31 = New KeyButton()
        Me.KeyButton32 = New KeyButton()
        Me.KeyButton35 = New KeyButton()
        Me.KeyButton9 = New KeyButton()
        Me.KeyButton11 = New KeyButton()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'keyButtonUp
        '
        Me.keyButtonUp.BackColor = System.Drawing.Color.Black
        Me.keyButtonUp.FlatAppearance.BorderSize = 0
        Me.keyButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonUp.ForeColor = System.Drawing.Color.White
        Me.keyButtonUp.IsPressed = False
        Me.keyButtonUp.KeyCode = 38
        Me.keyButtonUp.Location = New System.Drawing.Point(847, 188)
        Me.keyButtonUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonUp.Name = "keyButtonUp"
        Me.keyButtonUp.NormalText = Nothing
        Me.keyButtonUp.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonUp.ShiftText = Nothing
        Me.keyButtonUp.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonUp.TabIndex = 2
        Me.keyButtonUp.Text = "↑"
        Me.keyButtonUp.UnNumLockKeyCode = 0
        Me.keyButtonUp.UnNumLockText = Nothing
        Me.keyButtonUp.UseMnemonic = False
        Me.keyButtonUp.UseVisualStyleBackColor = False
        '
        'keyButtonRControl
        '
        Me.keyButtonRControl.BackColor = System.Drawing.Color.Black
        Me.keyButtonRControl.FlatAppearance.BorderSize = 0
        Me.keyButtonRControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonRControl.ForeColor = System.Drawing.Color.White
        Me.keyButtonRControl.IsPressed = False
        Me.keyButtonRControl.KeyCode = 17
        Me.keyButtonRControl.Location = New System.Drawing.Point(428, 153)
        Me.keyButtonRControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonRControl.Name = "keyButtonRControl"
        Me.keyButtonRControl.NormalText = Nothing
        Me.keyButtonRControl.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonRControl.ShiftText = Nothing
        Me.keyButtonRControl.Size = New System.Drawing.Size(55, 30)
        Me.keyButtonRControl.TabIndex = 0
        Me.keyButtonRControl.Text = "Ctrl"
        Me.keyButtonRControl.UnNumLockKeyCode = 0
        Me.keyButtonRControl.UnNumLockText = Nothing
        Me.keyButtonRControl.UseMnemonic = False
        Me.keyButtonRControl.UseVisualStyleBackColor = False
        '
        'keyButtonProcess
        '
        Me.keyButtonProcess.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonProcess.FlatAppearance.BorderSize = 0
        Me.keyButtonProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonProcess.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonProcess.ForeColor = System.Drawing.Color.White
        Me.keyButtonProcess.IsPressed = False
        Me.keyButtonProcess.KeyCode = 222
        Me.keyButtonProcess.Location = New System.Drawing.Point(734, 64)
        Me.keyButtonProcess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonProcess.Name = "keyButtonProcess"
        Me.keyButtonProcess.NormalText = Nothing
        Me.keyButtonProcess.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonProcess.ShiftText = Nothing
        Me.keyButtonProcess.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonProcess.TabIndex = 0
        Me.keyButtonProcess.Text = "'"
        Me.keyButtonProcess.UnNumLockKeyCode = 0
        Me.keyButtonProcess.UnNumLockText = Nothing
        Me.keyButtonProcess.UseMnemonic = False
        Me.keyButtonProcess.UseVisualStyleBackColor = False
        '
        'keyButtonOpenBrackets
        '
        Me.keyButtonOpenBrackets.BackColor = System.Drawing.Color.Black
        Me.keyButtonOpenBrackets.FlatAppearance.BorderSize = 0
        Me.keyButtonOpenBrackets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonOpenBrackets.ForeColor = System.Drawing.Color.White
        Me.keyButtonOpenBrackets.IsPressed = False
        Me.keyButtonOpenBrackets.KeyCode = 219
        Me.keyButtonOpenBrackets.Location = New System.Drawing.Point(490, 340)
        Me.keyButtonOpenBrackets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonOpenBrackets.Name = "keyButtonOpenBrackets"
        Me.keyButtonOpenBrackets.NormalText = Nothing
        Me.keyButtonOpenBrackets.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonOpenBrackets.ShiftText = Nothing
        Me.keyButtonOpenBrackets.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonOpenBrackets.TabIndex = 0
        Me.keyButtonOpenBrackets.Text = "["
        Me.keyButtonOpenBrackets.UnNumLockKeyCode = 0
        Me.keyButtonOpenBrackets.UnNumLockText = Nothing
        Me.keyButtonOpenBrackets.UseMnemonic = False
        Me.keyButtonOpenBrackets.UseVisualStyleBackColor = False
        '
        'keyButtonF10
        '
        Me.keyButtonF10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF10.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF10.FlatAppearance.BorderSize = 0
        Me.keyButtonF10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF10.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF10.ForeColor = System.Drawing.Color.White
        Me.keyButtonF10.IsPressed = False
        Me.keyButtonF10.KeyCode = 121
        Me.keyButtonF10.Location = New System.Drawing.Point(716, 15)
        Me.keyButtonF10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF10.Name = "keyButtonF10"
        Me.keyButtonF10.NormalText = Nothing
        Me.keyButtonF10.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF10.ShiftText = Nothing
        Me.keyButtonF10.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF10.TabIndex = 0
        Me.keyButtonF10.Text = "F10"
        Me.keyButtonF10.UnNumLockKeyCode = 0
        Me.keyButtonF10.UnNumLockText = Nothing
        Me.keyButtonF10.UseMnemonic = False
        Me.keyButtonF10.UseVisualStyleBackColor = False
        '
        'keyButtonD0
        '
        Me.keyButtonD0.BackColor = System.Drawing.Color.Black
        Me.keyButtonD0.FlatAppearance.BorderSize = 0
        Me.keyButtonD0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD0.ForeColor = System.Drawing.Color.White
        Me.keyButtonD0.IsPressed = False
        Me.keyButtonD0.KeyCode = 48
        Me.keyButtonD0.Location = New System.Drawing.Point(378, 340)
        Me.keyButtonD0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD0.Name = "keyButtonD0"
        Me.keyButtonD0.NormalText = Nothing
        Me.keyButtonD0.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD0.ShiftText = Nothing
        Me.keyButtonD0.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD0.TabIndex = 0
        Me.keyButtonD0.Text = "0"
        Me.keyButtonD0.UnNumLockKeyCode = 0
        Me.keyButtonD0.UnNumLockText = Nothing
        Me.keyButtonD0.UseMnemonic = False
        Me.keyButtonD0.UseVisualStyleBackColor = False
        '
        'keyButtonRight
        '
        Me.keyButtonRight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonRight.FlatAppearance.BorderSize = 0
        Me.keyButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonRight.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyButtonRight.ForeColor = System.Drawing.Color.White
        Me.keyButtonRight.IsPressed = False
        Me.keyButtonRight.KeyCode = 39
        Me.keyButtonRight.Location = New System.Drawing.Point(788, 184)
        Me.keyButtonRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonRight.Name = "keyButtonRight"
        Me.keyButtonRight.NormalText = Nothing
        Me.keyButtonRight.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonRight.ShiftText = Nothing
        Me.keyButtonRight.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonRight.TabIndex = 0
        Me.keyButtonRight.Text = "→"
        Me.keyButtonRight.UnNumLockKeyCode = 0
        Me.keyButtonRight.UnNumLockText = Nothing
        Me.keyButtonRight.UseMnemonic = False
        Me.keyButtonRight.UseVisualStyleBackColor = False
        '
        'keyButtonRShift
        '
        Me.keyButtonRShift.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonRShift.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonRShift.FlatAppearance.BorderSize = 0
        Me.keyButtonRShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonRShift.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyButtonRShift.ForeColor = System.Drawing.Color.White
        Me.keyButtonRShift.IsPressed = False
        Me.keyButtonRShift.KeyCode = 16
        Me.keyButtonRShift.Location = New System.Drawing.Point(866, 124)
        Me.keyButtonRShift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonRShift.Name = "keyButtonRShift"
        Me.keyButtonRShift.NormalText = Nothing
        Me.keyButtonRShift.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonRShift.ShiftText = Nothing
        Me.keyButtonRShift.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonRShift.TabIndex = 0
        Me.keyButtonRShift.Text = "↑"
        Me.keyButtonRShift.UnNumLockKeyCode = 0
        Me.keyButtonRShift.UnNumLockText = Nothing
        Me.keyButtonRShift.UseMnemonic = False
        Me.keyButtonRShift.UseVisualStyleBackColor = False
        '
        'keyButtonReturn
        '
        Me.keyButtonReturn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonReturn.FlatAppearance.BorderSize = 0
        Me.keyButtonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonReturn.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonReturn.ForeColor = System.Drawing.Color.White
        Me.keyButtonReturn.IsPressed = False
        Me.keyButtonReturn.KeyCode = 13
        Me.keyButtonReturn.Location = New System.Drawing.Point(812, 64)
        Me.keyButtonReturn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonReturn.Name = "keyButtonReturn"
        Me.keyButtonReturn.NormalText = Nothing
        Me.keyButtonReturn.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonReturn.ShiftText = Nothing
        Me.keyButtonReturn.Size = New System.Drawing.Size(126, 55)
        Me.keyButtonReturn.TabIndex = 0
        Me.keyButtonReturn.Text = "Enter"
        Me.keyButtonReturn.UnNumLockKeyCode = 0
        Me.keyButtonReturn.UnNumLockText = Nothing
        Me.keyButtonReturn.UseMnemonic = False
        Me.keyButtonReturn.UseVisualStyleBackColor = False
        '
        'keyButtonDelete
        '
        Me.keyButtonDelete.BackColor = System.Drawing.Color.Black
        Me.keyButtonDelete.FlatAppearance.BorderSize = 0
        Me.keyButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonDelete.ForeColor = System.Drawing.Color.White
        Me.keyButtonDelete.IsPressed = False
        Me.keyButtonDelete.KeyCode = 46
        Me.keyButtonDelete.Location = New System.Drawing.Point(536, 22)
        Me.keyButtonDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonDelete.Name = "keyButtonDelete"
        Me.keyButtonDelete.NormalText = Nothing
        Me.keyButtonDelete.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonDelete.ShiftText = Nothing
        Me.keyButtonDelete.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonDelete.TabIndex = 0
        Me.keyButtonDelete.Text = "Del"
        Me.keyButtonDelete.UnNumLockKeyCode = 0
        Me.keyButtonDelete.UnNumLockText = Nothing
        Me.keyButtonDelete.UseMnemonic = False
        Me.keyButtonDelete.UseVisualStyleBackColor = False
        '
        'keyButtonScrollLock
        '
        Me.keyButtonScrollLock.BackColor = System.Drawing.Color.Black
        Me.keyButtonScrollLock.FlatAppearance.BorderSize = 0
        Me.keyButtonScrollLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonScrollLock.ForeColor = System.Drawing.Color.White
        Me.keyButtonScrollLock.IsPressed = False
        Me.keyButtonScrollLock.KeyCode = 145
        Me.keyButtonScrollLock.Location = New System.Drawing.Point(608, 63)
        Me.keyButtonScrollLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonScrollLock.Name = "keyButtonScrollLock"
        Me.keyButtonScrollLock.NormalText = Nothing
        Me.keyButtonScrollLock.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonScrollLock.ShiftText = Nothing
        Me.keyButtonScrollLock.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonScrollLock.TabIndex = 0
        Me.keyButtonScrollLock.Text = "ScrLk"
        Me.keyButtonScrollLock.UnNumLockKeyCode = 0
        Me.keyButtonScrollLock.UnNumLockText = Nothing
        Me.keyButtonScrollLock.UseMnemonic = False
        Me.keyButtonScrollLock.UseVisualStyleBackColor = False
        '
        'keyButtonPause
        '
        Me.keyButtonPause.BackColor = System.Drawing.Color.Black
        Me.keyButtonPause.FlatAppearance.BorderSize = 0
        Me.keyButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonPause.ForeColor = System.Drawing.Color.White
        Me.keyButtonPause.IsPressed = False
        Me.keyButtonPause.KeyCode = 19
        Me.keyButtonPause.Location = New System.Drawing.Point(312, 22)
        Me.keyButtonPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonPause.Name = "keyButtonPause"
        Me.keyButtonPause.NormalText = Nothing
        Me.keyButtonPause.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonPause.ShiftText = Nothing
        Me.keyButtonPause.Size = New System.Drawing.Size(66, 30)
        Me.keyButtonPause.TabIndex = 0
        Me.keyButtonPause.Text = "Pause"
        Me.keyButtonPause.UnNumLockKeyCode = 0
        Me.keyButtonPause.UnNumLockText = Nothing
        Me.keyButtonPause.UseMnemonic = False
        Me.keyButtonPause.UseVisualStyleBackColor = False
        '
        'keyButtonPageDown
        '
        Me.keyButtonPageDown.BackColor = System.Drawing.Color.Black
        Me.keyButtonPageDown.FlatAppearance.BorderSize = 0
        Me.keyButtonPageDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonPageDown.ForeColor = System.Drawing.Color.White
        Me.keyButtonPageDown.IsPressed = False
        Me.keyButtonPageDown.KeyCode = 34
        Me.keyButtonPageDown.Location = New System.Drawing.Point(536, 82)
        Me.keyButtonPageDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonPageDown.Name = "keyButtonPageDown"
        Me.keyButtonPageDown.NormalText = Nothing
        Me.keyButtonPageDown.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonPageDown.ShiftText = Nothing
        Me.keyButtonPageDown.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonPageDown.TabIndex = 0
        Me.keyButtonPageDown.Text = "PgDn"
        Me.keyButtonPageDown.UnNumLockKeyCode = 0
        Me.keyButtonPageDown.UnNumLockText = Nothing
        Me.keyButtonPageDown.UseMnemonic = False
        Me.keyButtonPageDown.UseVisualStyleBackColor = False
        '
        'keyButtonPageUp
        '
        Me.keyButtonPageUp.BackColor = System.Drawing.Color.Black
        Me.keyButtonPageUp.FlatAppearance.BorderSize = 0
        Me.keyButtonPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonPageUp.ForeColor = System.Drawing.Color.White
        Me.keyButtonPageUp.IsPressed = False
        Me.keyButtonPageUp.KeyCode = 33
        Me.keyButtonPageUp.Location = New System.Drawing.Point(392, 66)
        Me.keyButtonPageUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonPageUp.Name = "keyButtonPageUp"
        Me.keyButtonPageUp.NormalText = Nothing
        Me.keyButtonPageUp.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonPageUp.ShiftText = Nothing
        Me.keyButtonPageUp.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonPageUp.TabIndex = 0
        Me.keyButtonPageUp.Text = "PgUp"
        Me.keyButtonPageUp.UnNumLockKeyCode = 0
        Me.keyButtonPageUp.UnNumLockText = Nothing
        Me.keyButtonPageUp.UseMnemonic = False
        Me.keyButtonPageUp.UseVisualStyleBackColor = False
        '
        'keyButtonPrintScreen
        '
        Me.keyButtonPrintScreen.BackColor = System.Drawing.Color.Black
        Me.keyButtonPrintScreen.FlatAppearance.BorderSize = 0
        Me.keyButtonPrintScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonPrintScreen.ForeColor = System.Drawing.Color.White
        Me.keyButtonPrintScreen.IsPressed = False
        Me.keyButtonPrintScreen.KeyCode = 44
        Me.keyButtonPrintScreen.Location = New System.Drawing.Point(536, 112)
        Me.keyButtonPrintScreen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonPrintScreen.Name = "keyButtonPrintScreen"
        Me.keyButtonPrintScreen.NormalText = Nothing
        Me.keyButtonPrintScreen.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonPrintScreen.ShiftText = Nothing
        Me.keyButtonPrintScreen.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonPrintScreen.TabIndex = 0
        Me.keyButtonPrintScreen.Text = "PrtScn"
        Me.keyButtonPrintScreen.UnNumLockKeyCode = 0
        Me.keyButtonPrintScreen.UnNumLockText = Nothing
        Me.keyButtonPrintScreen.UseMnemonic = False
        Me.keyButtonPrintScreen.UseVisualStyleBackColor = False
        '
        'keyButtonInsert
        '
        Me.keyButtonInsert.BackColor = System.Drawing.Color.Black
        Me.keyButtonInsert.FlatAppearance.BorderSize = 0
        Me.keyButtonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonInsert.ForeColor = System.Drawing.Color.White
        Me.keyButtonInsert.IsPressed = False
        Me.keyButtonInsert.KeyCode = 45
        Me.keyButtonInsert.Location = New System.Drawing.Point(608, 136)
        Me.keyButtonInsert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonInsert.Name = "keyButtonInsert"
        Me.keyButtonInsert.NormalText = Nothing
        Me.keyButtonInsert.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonInsert.ShiftText = Nothing
        Me.keyButtonInsert.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonInsert.TabIndex = 0
        Me.keyButtonInsert.Text = "Insert"
        Me.keyButtonInsert.UnNumLockKeyCode = 0
        Me.keyButtonInsert.UnNumLockText = Nothing
        Me.keyButtonInsert.UseMnemonic = False
        Me.keyButtonInsert.UseVisualStyleBackColor = False
        '
        'keyButtonEnd
        '
        Me.keyButtonEnd.BackColor = System.Drawing.Color.Black
        Me.keyButtonEnd.FlatAppearance.BorderSize = 0
        Me.keyButtonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonEnd.ForeColor = System.Drawing.Color.White
        Me.keyButtonEnd.IsPressed = False
        Me.keyButtonEnd.KeyCode = 35
        Me.keyButtonEnd.Location = New System.Drawing.Point(536, 52)
        Me.keyButtonEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonEnd.Name = "keyButtonEnd"
        Me.keyButtonEnd.NormalText = Nothing
        Me.keyButtonEnd.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonEnd.ShiftText = Nothing
        Me.keyButtonEnd.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonEnd.TabIndex = 0
        Me.keyButtonEnd.Text = "End"
        Me.keyButtonEnd.UnNumLockKeyCode = 0
        Me.keyButtonEnd.UnNumLockText = Nothing
        Me.keyButtonEnd.UseMnemonic = False
        Me.keyButtonEnd.UseVisualStyleBackColor = False
        '
        'keyButtonHome
        '
        Me.keyButtonHome.BackColor = System.Drawing.Color.Black
        Me.keyButtonHome.FlatAppearance.BorderSize = 0
        Me.keyButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonHome.ForeColor = System.Drawing.Color.White
        Me.keyButtonHome.IsPressed = False
        Me.keyButtonHome.KeyCode = 36
        Me.keyButtonHome.Location = New System.Drawing.Point(654, 63)
        Me.keyButtonHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonHome.Name = "keyButtonHome"
        Me.keyButtonHome.NormalText = Nothing
        Me.keyButtonHome.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonHome.ShiftText = Nothing
        Me.keyButtonHome.Size = New System.Drawing.Size(60, 30)
        Me.keyButtonHome.TabIndex = 0
        Me.keyButtonHome.Text = "Home"
        Me.keyButtonHome.UnNumLockKeyCode = 0
        Me.keyButtonHome.UnNumLockText = Nothing
        Me.keyButtonHome.UseMnemonic = False
        Me.keyButtonHome.UseVisualStyleBackColor = False
        '
        'keyButtonBack
        '
        Me.keyButtonBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonBack.FlatAppearance.BorderSize = 0
        Me.keyButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonBack.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.keyButtonBack.ForeColor = System.Drawing.Color.White
        Me.keyButtonBack.IsPressed = False
        Me.keyButtonBack.KeyCode = 8
        Me.keyButtonBack.Location = New System.Drawing.Point(788, 4)
        Me.keyButtonBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonBack.Name = "keyButtonBack"
        Me.keyButtonBack.NormalText = Nothing
        Me.keyButtonBack.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonBack.ShiftText = Nothing
        Me.keyButtonBack.Size = New System.Drawing.Size(150, 55)
        Me.keyButtonBack.TabIndex = 0
        Me.keyButtonBack.Text = "<<"
        Me.keyButtonBack.UnNumLockKeyCode = 0
        Me.keyButtonBack.UnNumLockText = Nothing
        Me.keyButtonBack.UseMnemonic = False
        Me.keyButtonBack.UseVisualStyleBackColor = False
        '
        'keyButtonDown
        '
        Me.keyButtonDown.BackColor = System.Drawing.Color.Black
        Me.keyButtonDown.FlatAppearance.BorderSize = 0
        Me.keyButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonDown.ForeColor = System.Drawing.Color.White
        Me.keyButtonDown.IsPressed = False
        Me.keyButtonDown.KeyCode = 40
        Me.keyButtonDown.Location = New System.Drawing.Point(847, 150)
        Me.keyButtonDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonDown.Name = "keyButtonDown"
        Me.keyButtonDown.NormalText = Nothing
        Me.keyButtonDown.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonDown.ShiftText = Nothing
        Me.keyButtonDown.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonDown.TabIndex = 0
        Me.keyButtonDown.Text = "↓"
        Me.keyButtonDown.UnNumLockKeyCode = 0
        Me.keyButtonDown.UnNumLockText = Nothing
        Me.keyButtonDown.UseMnemonic = False
        Me.keyButtonDown.UseVisualStyleBackColor = False
        '
        'keyButtonOemPipe
        '
        Me.keyButtonOemPipe.BackColor = System.Drawing.Color.Black
        Me.keyButtonOemPipe.FlatAppearance.BorderSize = 0
        Me.keyButtonOemPipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonOemPipe.ForeColor = System.Drawing.Color.White
        Me.keyButtonOemPipe.IsPressed = False
        Me.keyButtonOemPipe.KeyCode = 220
        Me.keyButtonOemPipe.Location = New System.Drawing.Point(756, 325)
        Me.keyButtonOemPipe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonOemPipe.Name = "keyButtonOemPipe"
        Me.keyButtonOemPipe.NormalText = Nothing
        Me.keyButtonOemPipe.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonOemPipe.ShiftText = Nothing
        Me.keyButtonOemPipe.Size = New System.Drawing.Size(65, 30)
        Me.keyButtonOemPipe.TabIndex = 0
        Me.keyButtonOemPipe.Text = "\"
        Me.keyButtonOemPipe.UnNumLockKeyCode = 0
        Me.keyButtonOemPipe.UnNumLockText = Nothing
        Me.keyButtonOemPipe.UseMnemonic = False
        Me.keyButtonOemPipe.UseVisualStyleBackColor = False
        '
        'keyButtonPlus
        '
        Me.keyButtonPlus.BackColor = System.Drawing.Color.Black
        Me.keyButtonPlus.FlatAppearance.BorderSize = 0
        Me.keyButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonPlus.ForeColor = System.Drawing.Color.White
        Me.keyButtonPlus.IsPressed = False
        Me.keyButtonPlus.KeyCode = 187
        Me.keyButtonPlus.Location = New System.Drawing.Point(450, 340)
        Me.keyButtonPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonPlus.Name = "keyButtonPlus"
        Me.keyButtonPlus.NormalText = Nothing
        Me.keyButtonPlus.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonPlus.ShiftText = Nothing
        Me.keyButtonPlus.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonPlus.TabIndex = 0
        Me.keyButtonPlus.Text = "="
        Me.keyButtonPlus.UnNumLockKeyCode = 0
        Me.keyButtonPlus.UnNumLockText = Nothing
        Me.keyButtonPlus.UseMnemonic = False
        Me.keyButtonPlus.UseVisualStyleBackColor = False
        '
        'keyButtonLeft
        '
        Me.keyButtonLeft.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonLeft.FlatAppearance.BorderSize = 0
        Me.keyButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonLeft.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyButtonLeft.ForeColor = System.Drawing.Color.White
        Me.keyButtonLeft.IsPressed = False
        Me.keyButtonLeft.KeyCode = 37
        Me.keyButtonLeft.Location = New System.Drawing.Point(710, 184)
        Me.keyButtonLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonLeft.Name = "keyButtonLeft"
        Me.keyButtonLeft.NormalText = Nothing
        Me.keyButtonLeft.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonLeft.ShiftText = Nothing
        Me.keyButtonLeft.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonLeft.TabIndex = 0
        Me.keyButtonLeft.Text = "←"
        Me.keyButtonLeft.UnNumLockKeyCode = 0
        Me.keyButtonLeft.UnNumLockText = Nothing
        Me.keyButtonLeft.UseMnemonic = False
        Me.keyButtonLeft.UseVisualStyleBackColor = False
        '
        'keyButtonCloseBrackets
        '
        Me.keyButtonCloseBrackets.BackColor = System.Drawing.Color.Black
        Me.keyButtonCloseBrackets.FlatAppearance.BorderSize = 0
        Me.keyButtonCloseBrackets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonCloseBrackets.ForeColor = System.Drawing.Color.White
        Me.keyButtonCloseBrackets.IsPressed = False
        Me.keyButtonCloseBrackets.KeyCode = 221
        Me.keyButtonCloseBrackets.Location = New System.Drawing.Point(526, 340)
        Me.keyButtonCloseBrackets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonCloseBrackets.Name = "keyButtonCloseBrackets"
        Me.keyButtonCloseBrackets.NormalText = Nothing
        Me.keyButtonCloseBrackets.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonCloseBrackets.ShiftText = Nothing
        Me.keyButtonCloseBrackets.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonCloseBrackets.TabIndex = 0
        Me.keyButtonCloseBrackets.Text = "]"
        Me.keyButtonCloseBrackets.UnNumLockKeyCode = 0
        Me.keyButtonCloseBrackets.UnNumLockText = Nothing
        Me.keyButtonCloseBrackets.UseMnemonic = False
        Me.keyButtonCloseBrackets.UseVisualStyleBackColor = False
        '
        'keyButtonMinus
        '
        Me.keyButtonMinus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonMinus.FlatAppearance.BorderSize = 0
        Me.keyButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonMinus.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonMinus.ForeColor = System.Drawing.Color.White
        Me.keyButtonMinus.IsPressed = False
        Me.keyButtonMinus.KeyCode = 189
        Me.keyButtonMinus.Location = New System.Drawing.Point(788, 124)
        Me.keyButtonMinus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonMinus.Name = "keyButtonMinus"
        Me.keyButtonMinus.NormalText = Nothing
        Me.keyButtonMinus.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonMinus.ShiftText = Nothing
        Me.keyButtonMinus.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonMinus.TabIndex = 0
        Me.keyButtonMinus.Text = "-"
        Me.keyButtonMinus.UnNumLockKeyCode = 0
        Me.keyButtonMinus.UnNumLockText = Nothing
        Me.keyButtonMinus.UseMnemonic = False
        Me.keyButtonMinus.UseVisualStyleBackColor = False
        '
        'keyButtonApps
        '
        Me.keyButtonApps.BackColor = System.Drawing.Color.Black
        Me.keyButtonApps.FlatAppearance.BorderSize = 0
        Me.keyButtonApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonApps.ForeColor = System.Drawing.Color.White
        Me.keyButtonApps.IsPressed = False
        Me.keyButtonApps.KeyCode = 93
        Me.keyButtonApps.Location = New System.Drawing.Point(215, 150)
        Me.keyButtonApps.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonApps.Name = "keyButtonApps"
        Me.keyButtonApps.NormalText = Nothing
        Me.keyButtonApps.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonApps.ShiftText = Nothing
        Me.keyButtonApps.Size = New System.Drawing.Size(45, 30)
        Me.keyButtonApps.TabIndex = 0
        Me.keyButtonApps.Text = "App"
        Me.keyButtonApps.UnNumLockKeyCode = 0
        Me.keyButtonApps.UnNumLockText = Nothing
        Me.keyButtonApps.UseMnemonic = False
        Me.keyButtonApps.UseVisualStyleBackColor = False
        '
        'keyButtonQuestion
        '
        Me.keyButtonQuestion.BackColor = System.Drawing.Color.Black
        Me.keyButtonQuestion.FlatAppearance.BorderSize = 0
        Me.keyButtonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonQuestion.ForeColor = System.Drawing.Color.White
        Me.keyButtonQuestion.IsPressed = False
        Me.keyButtonQuestion.KeyCode = 191
        Me.keyButtonQuestion.Location = New System.Drawing.Point(573, 340)
        Me.keyButtonQuestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonQuestion.Name = "keyButtonQuestion"
        Me.keyButtonQuestion.NormalText = Nothing
        Me.keyButtonQuestion.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonQuestion.ShiftText = Nothing
        Me.keyButtonQuestion.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonQuestion.TabIndex = 0
        Me.keyButtonQuestion.Text = "/"
        Me.keyButtonQuestion.UnNumLockKeyCode = 0
        Me.keyButtonQuestion.UnNumLockText = Nothing
        Me.keyButtonQuestion.UseMnemonic = False
        Me.keyButtonQuestion.UseVisualStyleBackColor = False
        '
        'keyButtonSemicolon
        '
        Me.keyButtonSemicolon.BackColor = System.Drawing.Color.Black
        Me.keyButtonSemicolon.FlatAppearance.BorderSize = 0
        Me.keyButtonSemicolon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonSemicolon.ForeColor = System.Drawing.Color.White
        Me.keyButtonSemicolon.IsPressed = False
        Me.keyButtonSemicolon.KeyCode = 186
        Me.keyButtonSemicolon.Location = New System.Drawing.Point(609, 340)
        Me.keyButtonSemicolon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonSemicolon.Name = "keyButtonSemicolon"
        Me.keyButtonSemicolon.NormalText = Nothing
        Me.keyButtonSemicolon.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonSemicolon.ShiftText = Nothing
        Me.keyButtonSemicolon.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonSemicolon.TabIndex = 0
        Me.keyButtonSemicolon.Text = ";"
        Me.keyButtonSemicolon.UnNumLockKeyCode = 0
        Me.keyButtonSemicolon.UnNumLockText = Nothing
        Me.keyButtonSemicolon.UseMnemonic = False
        Me.keyButtonSemicolon.UseVisualStyleBackColor = False
        '
        'keyButtonP
        '
        Me.keyButtonP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonP.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonP.FlatAppearance.BorderSize = 0
        Me.keyButtonP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonP.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonP.ForeColor = System.Drawing.Color.White
        Me.keyButtonP.IsPressed = False
        Me.keyButtonP.KeyCode = 80
        Me.keyButtonP.Location = New System.Drawing.Point(710, 4)
        Me.keyButtonP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonP.Name = "keyButtonP"
        Me.keyButtonP.NormalText = Nothing
        Me.keyButtonP.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonP.ShiftText = Nothing
        Me.keyButtonP.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonP.TabIndex = 0
        Me.keyButtonP.Text = "p"
        Me.keyButtonP.UnNumLockKeyCode = 0
        Me.keyButtonP.UnNumLockText = Nothing
        Me.keyButtonP.UseMnemonic = False
        Me.keyButtonP.UseVisualStyleBackColor = False
        '
        'keyButtonF9
        '
        Me.keyButtonF9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF9.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF9.FlatAppearance.BorderSize = 0
        Me.keyButtonF9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF9.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF9.ForeColor = System.Drawing.Color.White
        Me.keyButtonF9.IsPressed = False
        Me.keyButtonF9.KeyCode = 120
        Me.keyButtonF9.Location = New System.Drawing.Point(637, 15)
        Me.keyButtonF9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF9.Name = "keyButtonF9"
        Me.keyButtonF9.NormalText = Nothing
        Me.keyButtonF9.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF9.ShiftText = Nothing
        Me.keyButtonF9.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF9.TabIndex = 0
        Me.keyButtonF9.Text = "F9"
        Me.keyButtonF9.UnNumLockKeyCode = 0
        Me.keyButtonF9.UnNumLockText = Nothing
        Me.keyButtonF9.UseMnemonic = False
        Me.keyButtonF9.UseVisualStyleBackColor = False
        '
        'keyButtonD9
        '
        Me.keyButtonD9.BackColor = System.Drawing.Color.Black
        Me.keyButtonD9.FlatAppearance.BorderSize = 0
        Me.keyButtonD9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD9.ForeColor = System.Drawing.Color.White
        Me.keyButtonD9.IsPressed = False
        Me.keyButtonD9.KeyCode = 57
        Me.keyButtonD9.Location = New System.Drawing.Point(342, 340)
        Me.keyButtonD9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD9.Name = "keyButtonD9"
        Me.keyButtonD9.NormalText = Nothing
        Me.keyButtonD9.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD9.ShiftText = Nothing
        Me.keyButtonD9.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD9.TabIndex = 0
        Me.keyButtonD9.Text = "9"
        Me.keyButtonD9.UnNumLockKeyCode = 0
        Me.keyButtonD9.UnNumLockText = Nothing
        Me.keyButtonD9.UseMnemonic = False
        Me.keyButtonD9.UseVisualStyleBackColor = False
        '
        'keyButtonRAlt
        '
        Me.keyButtonRAlt.BackColor = System.Drawing.Color.Black
        Me.keyButtonRAlt.FlatAppearance.BorderSize = 0
        Me.keyButtonRAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonRAlt.ForeColor = System.Drawing.Color.White
        Me.keyButtonRAlt.IsPressed = False
        Me.keyButtonRAlt.KeyCode = 18
        Me.keyButtonRAlt.Location = New System.Drawing.Point(276, 153)
        Me.keyButtonRAlt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonRAlt.Name = "keyButtonRAlt"
        Me.keyButtonRAlt.NormalText = Nothing
        Me.keyButtonRAlt.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonRAlt.ShiftText = Nothing
        Me.keyButtonRAlt.Size = New System.Drawing.Size(53, 30)
        Me.keyButtonRAlt.TabIndex = 0
        Me.keyButtonRAlt.Text = "Alt"
        Me.keyButtonRAlt.UnNumLockKeyCode = 0
        Me.keyButtonRAlt.UnNumLockText = Nothing
        Me.keyButtonRAlt.UseMnemonic = False
        Me.keyButtonRAlt.UseVisualStyleBackColor = False
        '
        'keyButtonPeriod
        '
        Me.keyButtonPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonPeriod.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonPeriod.FlatAppearance.BorderSize = 0
        Me.keyButtonPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonPeriod.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonPeriod.ForeColor = System.Drawing.Color.White
        Me.keyButtonPeriod.IsPressed = False
        Me.keyButtonPeriod.KeyCode = 190
        Me.keyButtonPeriod.Location = New System.Drawing.Point(710, 124)
        Me.keyButtonPeriod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonPeriod.Name = "keyButtonPeriod"
        Me.keyButtonPeriod.NormalText = Nothing
        Me.keyButtonPeriod.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonPeriod.ShiftText = Nothing
        Me.keyButtonPeriod.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonPeriod.TabIndex = 0
        Me.keyButtonPeriod.Text = "."
        Me.keyButtonPeriod.UnNumLockKeyCode = 0
        Me.keyButtonPeriod.UnNumLockText = Nothing
        Me.keyButtonPeriod.UseMnemonic = False
        Me.keyButtonPeriod.UseVisualStyleBackColor = False
        '
        'keyButtonL
        '
        Me.keyButtonL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonL.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonL.FlatAppearance.BorderSize = 0
        Me.keyButtonL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonL.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonL.ForeColor = System.Drawing.Color.White
        Me.keyButtonL.IsPressed = False
        Me.keyButtonL.KeyCode = 76
        Me.keyButtonL.Location = New System.Drawing.Point(656, 64)
        Me.keyButtonL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonL.Name = "keyButtonL"
        Me.keyButtonL.NormalText = Nothing
        Me.keyButtonL.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonL.ShiftText = Nothing
        Me.keyButtonL.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonL.TabIndex = 0
        Me.keyButtonL.Text = "l"
        Me.keyButtonL.UnNumLockKeyCode = 0
        Me.keyButtonL.UnNumLockText = Nothing
        Me.keyButtonL.UseMnemonic = False
        Me.keyButtonL.UseVisualStyleBackColor = False
        '
        'keyButtonO
        '
        Me.keyButtonO.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonO.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonO.FlatAppearance.BorderSize = 0
        Me.keyButtonO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonO.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonO.ForeColor = System.Drawing.Color.White
        Me.keyButtonO.IsPressed = False
        Me.keyButtonO.KeyCode = 79
        Me.keyButtonO.Location = New System.Drawing.Point(632, 4)
        Me.keyButtonO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonO.Name = "keyButtonO"
        Me.keyButtonO.NormalText = Nothing
        Me.keyButtonO.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonO.ShiftText = Nothing
        Me.keyButtonO.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonO.TabIndex = 0
        Me.keyButtonO.Text = "o"
        Me.keyButtonO.UnNumLockKeyCode = 0
        Me.keyButtonO.UnNumLockText = Nothing
        Me.keyButtonO.UseMnemonic = False
        Me.keyButtonO.UseVisualStyleBackColor = False
        '
        'keyButtonSubtract
        '
        Me.keyButtonSubtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonSubtract.FlatAppearance.BorderSize = 0
        Me.keyButtonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonSubtract.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonSubtract.ForeColor = System.Drawing.Color.White
        Me.keyButtonSubtract.IsPressed = False
        Me.keyButtonSubtract.KeyCode = 109
        Me.keyButtonSubtract.Location = New System.Drawing.Point(954, 150)
        Me.keyButtonSubtract.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonSubtract.Name = "keyButtonSubtract"
        Me.keyButtonSubtract.NormalText = Nothing
        Me.keyButtonSubtract.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonSubtract.ShiftText = Nothing
        Me.keyButtonSubtract.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonSubtract.TabIndex = 0
        Me.keyButtonSubtract.Text = "-"
        Me.keyButtonSubtract.UnNumLockKeyCode = 0
        Me.keyButtonSubtract.UnNumLockText = Nothing
        Me.keyButtonSubtract.UseMnemonic = False
        Me.keyButtonSubtract.UseVisualStyleBackColor = False
        '
        'keyButtonMultiply
        '
        Me.keyButtonMultiply.BackColor = System.Drawing.Color.Black
        Me.keyButtonMultiply.FlatAppearance.BorderSize = 0
        Me.keyButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonMultiply.ForeColor = System.Drawing.Color.White
        Me.keyButtonMultiply.IsPressed = False
        Me.keyButtonMultiply.KeyCode = 106
        Me.keyButtonMultiply.Location = New System.Drawing.Point(684, 246)
        Me.keyButtonMultiply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonMultiply.Name = "keyButtonMultiply"
        Me.keyButtonMultiply.NormalText = Nothing
        Me.keyButtonMultiply.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonMultiply.ShiftText = Nothing
        Me.keyButtonMultiply.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonMultiply.TabIndex = 0
        Me.keyButtonMultiply.Text = "*"
        Me.keyButtonMultiply.UnNumLockKeyCode = 0
        Me.keyButtonMultiply.UnNumLockText = Nothing
        Me.keyButtonMultiply.UseMnemonic = False
        Me.keyButtonMultiply.UseVisualStyleBackColor = False
        '
        'keyButtonDivide
        '
        Me.keyButtonDivide.BackColor = System.Drawing.Color.Black
        Me.keyButtonDivide.FlatAppearance.BorderSize = 0
        Me.keyButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonDivide.ForeColor = System.Drawing.Color.White
        Me.keyButtonDivide.IsPressed = False
        Me.keyButtonDivide.KeyCode = 111
        Me.keyButtonDivide.Location = New System.Drawing.Point(837, 323)
        Me.keyButtonDivide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonDivide.Name = "keyButtonDivide"
        Me.keyButtonDivide.NormalText = Nothing
        Me.keyButtonDivide.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonDivide.ShiftText = Nothing
        Me.keyButtonDivide.Size = New System.Drawing.Size(66, 30)
        Me.keyButtonDivide.TabIndex = 0
        Me.keyButtonDivide.Text = "/"
        Me.keyButtonDivide.UnNumLockKeyCode = 0
        Me.keyButtonDivide.UnNumLockText = Nothing
        Me.keyButtonDivide.UseMnemonic = False
        Me.keyButtonDivide.UseVisualStyleBackColor = False
        '
        'keyButtonF8
        '
        Me.keyButtonF8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF8.FlatAppearance.BorderSize = 0
        Me.keyButtonF8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF8.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF8.ForeColor = System.Drawing.Color.White
        Me.keyButtonF8.IsPressed = False
        Me.keyButtonF8.KeyCode = 119
        Me.keyButtonF8.Location = New System.Drawing.Point(242, 184)
        Me.keyButtonF8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF8.Name = "keyButtonF8"
        Me.keyButtonF8.NormalText = Nothing
        Me.keyButtonF8.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF8.ShiftText = Nothing
        Me.keyButtonF8.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF8.TabIndex = 0
        Me.keyButtonF8.Text = "F8"
        Me.keyButtonF8.UnNumLockKeyCode = 0
        Me.keyButtonF8.UnNumLockText = Nothing
        Me.keyButtonF8.UseMnemonic = False
        Me.keyButtonF8.UseVisualStyleBackColor = False
        '
        'keyButtonD8
        '
        Me.keyButtonD8.BackColor = System.Drawing.Color.Black
        Me.keyButtonD8.FlatAppearance.BorderSize = 0
        Me.keyButtonD8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD8.ForeColor = System.Drawing.Color.White
        Me.keyButtonD8.IsPressed = False
        Me.keyButtonD8.KeyCode = 56
        Me.keyButtonD8.Location = New System.Drawing.Point(306, 340)
        Me.keyButtonD8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD8.Name = "keyButtonD8"
        Me.keyButtonD8.NormalText = Nothing
        Me.keyButtonD8.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD8.ShiftText = Nothing
        Me.keyButtonD8.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD8.TabIndex = 0
        Me.keyButtonD8.Text = "8"
        Me.keyButtonD8.UnNumLockKeyCode = 0
        Me.keyButtonD8.UnNumLockText = Nothing
        Me.keyButtonD8.UseMnemonic = False
        Me.keyButtonD8.UseVisualStyleBackColor = False
        '
        'keyButtonComma
        '
        Me.keyButtonComma.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonComma.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonComma.FlatAppearance.BorderSize = 0
        Me.keyButtonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonComma.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonComma.ForeColor = System.Drawing.Color.White
        Me.keyButtonComma.IsPressed = False
        Me.keyButtonComma.KeyCode = 188
        Me.keyButtonComma.Location = New System.Drawing.Point(632, 124)
        Me.keyButtonComma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonComma.Name = "keyButtonComma"
        Me.keyButtonComma.NormalText = Nothing
        Me.keyButtonComma.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonComma.ShiftText = Nothing
        Me.keyButtonComma.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonComma.TabIndex = 0
        Me.keyButtonComma.Text = ","
        Me.keyButtonComma.UnNumLockKeyCode = 0
        Me.keyButtonComma.UnNumLockText = Nothing
        Me.keyButtonComma.UseMnemonic = False
        Me.keyButtonComma.UseVisualStyleBackColor = False
        '
        'keyButtonK
        '
        Me.keyButtonK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonK.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonK.FlatAppearance.BorderSize = 0
        Me.keyButtonK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonK.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonK.ForeColor = System.Drawing.Color.White
        Me.keyButtonK.IsPressed = False
        Me.keyButtonK.KeyCode = 75
        Me.keyButtonK.Location = New System.Drawing.Point(578, 64)
        Me.keyButtonK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonK.Name = "keyButtonK"
        Me.keyButtonK.NormalText = Nothing
        Me.keyButtonK.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonK.ShiftText = Nothing
        Me.keyButtonK.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonK.TabIndex = 0
        Me.keyButtonK.Text = "k"
        Me.keyButtonK.UnNumLockKeyCode = 0
        Me.keyButtonK.UnNumLockText = Nothing
        Me.keyButtonK.UseMnemonic = False
        Me.keyButtonK.UseVisualStyleBackColor = False
        '
        'keyButtonI
        '
        Me.keyButtonI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonI.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonI.FlatAppearance.BorderSize = 0
        Me.keyButtonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonI.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonI.ForeColor = System.Drawing.Color.White
        Me.keyButtonI.IsPressed = False
        Me.keyButtonI.KeyCode = 73
        Me.keyButtonI.Location = New System.Drawing.Point(554, 4)
        Me.keyButtonI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonI.Name = "keyButtonI"
        Me.keyButtonI.NormalText = Nothing
        Me.keyButtonI.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonI.ShiftText = Nothing
        Me.keyButtonI.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonI.TabIndex = 0
        Me.keyButtonI.Text = "i"
        Me.keyButtonI.UnNumLockKeyCode = 0
        Me.keyButtonI.UnNumLockText = Nothing
        Me.keyButtonI.UseMnemonic = False
        Me.keyButtonI.UseVisualStyleBackColor = False
        '
        'keyButtonAdd
        '
        Me.keyButtonAdd.BackColor = System.Drawing.Color.Black
        Me.keyButtonAdd.FlatAppearance.BorderSize = 0
        Me.keyButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonAdd.ForeColor = System.Drawing.Color.White
        Me.keyButtonAdd.IsPressed = False
        Me.keyButtonAdd.KeyCode = 107
        Me.keyButtonAdd.Location = New System.Drawing.Point(829, 283)
        Me.keyButtonAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonAdd.Name = "keyButtonAdd"
        Me.keyButtonAdd.NormalText = Nothing
        Me.keyButtonAdd.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonAdd.ShiftText = Nothing
        Me.keyButtonAdd.Size = New System.Drawing.Size(58, 50)
        Me.keyButtonAdd.TabIndex = 0
        Me.keyButtonAdd.Text = "+"
        Me.keyButtonAdd.UnNumLockKeyCode = 0
        Me.keyButtonAdd.UnNumLockText = Nothing
        Me.keyButtonAdd.UseMnemonic = False
        Me.keyButtonAdd.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad3
        '
        Me.keyButtonNumberPad3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad3.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad3.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad3.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad3.IsPressed = False
        Me.keyButtonNumberPad3.KeyCode = 99
        Me.keyButtonNumberPad3.Location = New System.Drawing.Point(554, 364)
        Me.keyButtonNumberPad3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad3.Name = "keyButtonNumberPad3"
        Me.keyButtonNumberPad3.NormalText = Nothing
        Me.keyButtonNumberPad3.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad3.ShiftText = Nothing
        Me.keyButtonNumberPad3.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad3.TabIndex = 0
        Me.keyButtonNumberPad3.Text = "3"
        Me.keyButtonNumberPad3.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad3.UnNumLockText = Nothing
        Me.keyButtonNumberPad3.UseMnemonic = False
        Me.keyButtonNumberPad3.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad6
        '
        Me.keyButtonNumberPad6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad6.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad6.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad6.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad6.IsPressed = False
        Me.keyButtonNumberPad6.KeyCode = 102
        Me.keyButtonNumberPad6.Location = New System.Drawing.Point(554, 304)
        Me.keyButtonNumberPad6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad6.Name = "keyButtonNumberPad6"
        Me.keyButtonNumberPad6.NormalText = Nothing
        Me.keyButtonNumberPad6.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad6.ShiftText = Nothing
        Me.keyButtonNumberPad6.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad6.TabIndex = 0
        Me.keyButtonNumberPad6.Text = "6"
        Me.keyButtonNumberPad6.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad6.UnNumLockText = Nothing
        Me.keyButtonNumberPad6.UseMnemonic = False
        Me.keyButtonNumberPad6.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad9
        '
        Me.keyButtonNumberPad9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad9.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad9.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad9.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad9.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad9.IsPressed = False
        Me.keyButtonNumberPad9.KeyCode = 105
        Me.keyButtonNumberPad9.Location = New System.Drawing.Point(554, 244)
        Me.keyButtonNumberPad9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad9.Name = "keyButtonNumberPad9"
        Me.keyButtonNumberPad9.NormalText = Nothing
        Me.keyButtonNumberPad9.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad9.ShiftText = Nothing
        Me.keyButtonNumberPad9.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad9.TabIndex = 0
        Me.keyButtonNumberPad9.Text = "9"
        Me.keyButtonNumberPad9.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad9.UnNumLockText = Nothing
        Me.keyButtonNumberPad9.UseMnemonic = False
        Me.keyButtonNumberPad9.UseVisualStyleBackColor = False
        '
        'keyButtonF7
        '
        Me.keyButtonF7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF7.FlatAppearance.BorderSize = 0
        Me.keyButtonF7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF7.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF7.ForeColor = System.Drawing.Color.White
        Me.keyButtonF7.IsPressed = False
        Me.keyButtonF7.KeyCode = 118
        Me.keyButtonF7.Location = New System.Drawing.Point(164, 184)
        Me.keyButtonF7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF7.Name = "keyButtonF7"
        Me.keyButtonF7.NormalText = Nothing
        Me.keyButtonF7.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF7.ShiftText = Nothing
        Me.keyButtonF7.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF7.TabIndex = 0
        Me.keyButtonF7.Text = "F7"
        Me.keyButtonF7.UnNumLockKeyCode = 0
        Me.keyButtonF7.UnNumLockText = Nothing
        Me.keyButtonF7.UseMnemonic = False
        Me.keyButtonF7.UseVisualStyleBackColor = False
        '
        'keyButtonD7
        '
        Me.keyButtonD7.BackColor = System.Drawing.Color.Black
        Me.keyButtonD7.FlatAppearance.BorderSize = 0
        Me.keyButtonD7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD7.ForeColor = System.Drawing.Color.White
        Me.keyButtonD7.IsPressed = False
        Me.keyButtonD7.KeyCode = 55
        Me.keyButtonD7.Location = New System.Drawing.Point(270, 340)
        Me.keyButtonD7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD7.Name = "keyButtonD7"
        Me.keyButtonD7.NormalText = Nothing
        Me.keyButtonD7.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD7.ShiftText = Nothing
        Me.keyButtonD7.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD7.TabIndex = 0
        Me.keyButtonD7.Text = "7"
        Me.keyButtonD7.UnNumLockKeyCode = 0
        Me.keyButtonD7.UnNumLockText = Nothing
        Me.keyButtonD7.UseMnemonic = False
        Me.keyButtonD7.UseVisualStyleBackColor = False
        '
        'keyButtonM
        '
        Me.keyButtonM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonM.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonM.FlatAppearance.BorderSize = 0
        Me.keyButtonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonM.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonM.ForeColor = System.Drawing.Color.White
        Me.keyButtonM.IsPressed = False
        Me.keyButtonM.KeyCode = 77
        Me.keyButtonM.Location = New System.Drawing.Point(554, 124)
        Me.keyButtonM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonM.Name = "keyButtonM"
        Me.keyButtonM.NormalText = Nothing
        Me.keyButtonM.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonM.ShiftText = Nothing
        Me.keyButtonM.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonM.TabIndex = 0
        Me.keyButtonM.Text = "m"
        Me.keyButtonM.UnNumLockKeyCode = 0
        Me.keyButtonM.UnNumLockText = Nothing
        Me.keyButtonM.UseMnemonic = False
        Me.keyButtonM.UseVisualStyleBackColor = False
        '
        'keyButtonJ
        '
        Me.keyButtonJ.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonJ.FlatAppearance.BorderSize = 0
        Me.keyButtonJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonJ.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonJ.ForeColor = System.Drawing.Color.White
        Me.keyButtonJ.IsPressed = False
        Me.keyButtonJ.KeyCode = 74
        Me.keyButtonJ.Location = New System.Drawing.Point(500, 64)
        Me.keyButtonJ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonJ.Name = "keyButtonJ"
        Me.keyButtonJ.NormalText = Nothing
        Me.keyButtonJ.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonJ.ShiftText = Nothing
        Me.keyButtonJ.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonJ.TabIndex = 0
        Me.keyButtonJ.Text = "j"
        Me.keyButtonJ.UnNumLockKeyCode = 0
        Me.keyButtonJ.UnNumLockText = Nothing
        Me.keyButtonJ.UseMnemonic = False
        Me.keyButtonJ.UseVisualStyleBackColor = False
        '
        'keyButtonU
        '
        Me.keyButtonU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonU.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonU.FlatAppearance.BorderSize = 0
        Me.keyButtonU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonU.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonU.ForeColor = System.Drawing.Color.White
        Me.keyButtonU.IsPressed = False
        Me.keyButtonU.KeyCode = 85
        Me.keyButtonU.Location = New System.Drawing.Point(476, 4)
        Me.keyButtonU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonU.Name = "keyButtonU"
        Me.keyButtonU.NormalText = Nothing
        Me.keyButtonU.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonU.ShiftText = Nothing
        Me.keyButtonU.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonU.TabIndex = 0
        Me.keyButtonU.Text = "u"
        Me.keyButtonU.UnNumLockKeyCode = 0
        Me.keyButtonU.UnNumLockText = Nothing
        Me.keyButtonU.UseMnemonic = False
        Me.keyButtonU.UseVisualStyleBackColor = False
        '
        'keyButtonNumLock
        '
        Me.keyButtonNumLock.BackColor = System.Drawing.Color.Black
        Me.keyButtonNumLock.FlatAppearance.BorderSize = 0
        Me.keyButtonNumLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumLock.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumLock.IsPressed = False
        Me.keyButtonNumLock.KeyCode = 144
        Me.keyButtonNumLock.Location = New System.Drawing.Point(608, 22)
        Me.keyButtonNumLock.Margin = New System.Windows.Forms.Padding(0)
        Me.keyButtonNumLock.Name = "keyButtonNumLock"
        Me.keyButtonNumLock.NormalText = Nothing
        Me.keyButtonNumLock.ShiftText = Nothing
        Me.keyButtonNumLock.Size = New System.Drawing.Size(66, 30)
        Me.keyButtonNumLock.TabIndex = 0
        Me.keyButtonNumLock.Text = "Num"
        Me.keyButtonNumLock.UnNumLockKeyCode = 0
        Me.keyButtonNumLock.UnNumLockText = Nothing
        Me.keyButtonNumLock.UseMnemonic = False
        Me.keyButtonNumLock.UseVisualStyleBackColor = False
        '
        'keyButtonDecimal
        '
        Me.keyButtonDecimal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonDecimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonDecimal.FlatAppearance.BorderSize = 0
        Me.keyButtonDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonDecimal.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonDecimal.ForeColor = System.Drawing.Color.White
        Me.keyButtonDecimal.IsPressed = False
        Me.keyButtonDecimal.KeyCode = 110
        Me.keyButtonDecimal.Location = New System.Drawing.Point(554, 424)
        Me.keyButtonDecimal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonDecimal.Name = "keyButtonDecimal"
        Me.keyButtonDecimal.NormalText = Nothing
        Me.keyButtonDecimal.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonDecimal.ShiftText = Nothing
        Me.keyButtonDecimal.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonDecimal.TabIndex = 0
        Me.keyButtonDecimal.Text = "."
        Me.keyButtonDecimal.UnNumLockKeyCode = 0
        Me.keyButtonDecimal.UnNumLockText = Nothing
        Me.keyButtonDecimal.UseMnemonic = False
        Me.keyButtonDecimal.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad2
        '
        Me.keyButtonNumberPad2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad2.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad2.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad2.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad2.IsPressed = False
        Me.keyButtonNumberPad2.KeyCode = 98
        Me.keyButtonNumberPad2.Location = New System.Drawing.Point(476, 364)
        Me.keyButtonNumberPad2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad2.Name = "keyButtonNumberPad2"
        Me.keyButtonNumberPad2.NormalText = Nothing
        Me.keyButtonNumberPad2.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad2.ShiftText = Nothing
        Me.keyButtonNumberPad2.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad2.TabIndex = 0
        Me.keyButtonNumberPad2.Text = "2"
        Me.keyButtonNumberPad2.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad2.UnNumLockText = Nothing
        Me.keyButtonNumberPad2.UseMnemonic = False
        Me.keyButtonNumberPad2.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad5
        '
        Me.keyButtonNumberPad5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad5.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad5.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad5.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad5.IsPressed = False
        Me.keyButtonNumberPad5.KeyCode = 101
        Me.keyButtonNumberPad5.Location = New System.Drawing.Point(476, 304)
        Me.keyButtonNumberPad5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad5.Name = "keyButtonNumberPad5"
        Me.keyButtonNumberPad5.NormalText = Nothing
        Me.keyButtonNumberPad5.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad5.ShiftText = Nothing
        Me.keyButtonNumberPad5.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad5.TabIndex = 0
        Me.keyButtonNumberPad5.Text = "5"
        Me.keyButtonNumberPad5.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad5.UnNumLockText = Nothing
        Me.keyButtonNumberPad5.UseMnemonic = False
        Me.keyButtonNumberPad5.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad8
        '
        Me.keyButtonNumberPad8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad8.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad8.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad8.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad8.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad8.IsPressed = False
        Me.keyButtonNumberPad8.KeyCode = 104
        Me.keyButtonNumberPad8.Location = New System.Drawing.Point(476, 244)
        Me.keyButtonNumberPad8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad8.Name = "keyButtonNumberPad8"
        Me.keyButtonNumberPad8.NormalText = Nothing
        Me.keyButtonNumberPad8.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad8.ShiftText = Nothing
        Me.keyButtonNumberPad8.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad8.TabIndex = 0
        Me.keyButtonNumberPad8.Text = "8"
        Me.keyButtonNumberPad8.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad8.UnNumLockText = Nothing
        Me.keyButtonNumberPad8.UseMnemonic = False
        Me.keyButtonNumberPad8.UseVisualStyleBackColor = False
        '
        'keyButtonF6
        '
        Me.keyButtonF6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF6.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF6.FlatAppearance.BorderSize = 0
        Me.keyButtonF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF6.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF6.ForeColor = System.Drawing.Color.White
        Me.keyButtonF6.IsPressed = False
        Me.keyButtonF6.KeyCode = 117
        Me.keyButtonF6.Location = New System.Drawing.Point(86, 184)
        Me.keyButtonF6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF6.Name = "keyButtonF6"
        Me.keyButtonF6.NormalText = Nothing
        Me.keyButtonF6.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF6.ShiftText = Nothing
        Me.keyButtonF6.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF6.TabIndex = 0
        Me.keyButtonF6.Text = "F6"
        Me.keyButtonF6.UnNumLockKeyCode = 0
        Me.keyButtonF6.UnNumLockText = Nothing
        Me.keyButtonF6.UseMnemonic = False
        Me.keyButtonF6.UseVisualStyleBackColor = False
        '
        'keyButtonD6
        '
        Me.keyButtonD6.BackColor = System.Drawing.Color.Black
        Me.keyButtonD6.FlatAppearance.BorderSize = 0
        Me.keyButtonD6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD6.ForeColor = System.Drawing.Color.White
        Me.keyButtonD6.IsPressed = False
        Me.keyButtonD6.KeyCode = 54
        Me.keyButtonD6.Location = New System.Drawing.Point(234, 340)
        Me.keyButtonD6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD6.Name = "keyButtonD6"
        Me.keyButtonD6.NormalText = Nothing
        Me.keyButtonD6.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD6.ShiftText = Nothing
        Me.keyButtonD6.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD6.TabIndex = 0
        Me.keyButtonD6.Text = "6"
        Me.keyButtonD6.UnNumLockKeyCode = 0
        Me.keyButtonD6.UnNumLockText = Nothing
        Me.keyButtonD6.UseMnemonic = False
        Me.keyButtonD6.UseVisualStyleBackColor = False
        '
        'keyButtonN
        '
        Me.keyButtonN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonN.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonN.FlatAppearance.BorderSize = 0
        Me.keyButtonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonN.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonN.ForeColor = System.Drawing.Color.White
        Me.keyButtonN.IsPressed = False
        Me.keyButtonN.KeyCode = 78
        Me.keyButtonN.Location = New System.Drawing.Point(476, 124)
        Me.keyButtonN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonN.Name = "keyButtonN"
        Me.keyButtonN.NormalText = Nothing
        Me.keyButtonN.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonN.ShiftText = Nothing
        Me.keyButtonN.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonN.TabIndex = 0
        Me.keyButtonN.Text = "n"
        Me.keyButtonN.UnNumLockKeyCode = 0
        Me.keyButtonN.UnNumLockText = Nothing
        Me.keyButtonN.UseMnemonic = False
        Me.keyButtonN.UseVisualStyleBackColor = False
        '
        'keyButtonH
        '
        Me.keyButtonH.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonH.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonH.FlatAppearance.BorderSize = 0
        Me.keyButtonH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonH.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonH.ForeColor = System.Drawing.Color.White
        Me.keyButtonH.IsPressed = False
        Me.keyButtonH.KeyCode = 72
        Me.keyButtonH.Location = New System.Drawing.Point(422, 64)
        Me.keyButtonH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonH.Name = "keyButtonH"
        Me.keyButtonH.NormalText = Nothing
        Me.keyButtonH.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonH.ShiftText = Nothing
        Me.keyButtonH.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonH.TabIndex = 0
        Me.keyButtonH.Text = "h"
        Me.keyButtonH.UnNumLockKeyCode = 0
        Me.keyButtonH.UnNumLockText = Nothing
        Me.keyButtonH.UseMnemonic = False
        Me.keyButtonH.UseVisualStyleBackColor = False
        '
        'keyButtonY
        '
        Me.keyButtonY.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonY.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonY.FlatAppearance.BorderSize = 0
        Me.keyButtonY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonY.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonY.ForeColor = System.Drawing.Color.White
        Me.keyButtonY.IsPressed = False
        Me.keyButtonY.KeyCode = 89
        Me.keyButtonY.Location = New System.Drawing.Point(398, 4)
        Me.keyButtonY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonY.Name = "keyButtonY"
        Me.keyButtonY.NormalText = Nothing
        Me.keyButtonY.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonY.ShiftText = Nothing
        Me.keyButtonY.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonY.TabIndex = 0
        Me.keyButtonY.Text = "y"
        Me.keyButtonY.UnNumLockKeyCode = 0
        Me.keyButtonY.UnNumLockText = Nothing
        Me.keyButtonY.UseMnemonic = False
        Me.keyButtonY.UseVisualStyleBackColor = False
        '
        'keyButtonNumReturn
        '
        Me.keyButtonNumReturn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonNumReturn.FlatAppearance.BorderSize = 0
        Me.keyButtonNumReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumReturn.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonNumReturn.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumReturn.IsPressed = False
        Me.keyButtonNumReturn.KeyCode = 13
        Me.keyButtonNumReturn.Location = New System.Drawing.Point(812, 304)
        Me.keyButtonNumReturn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumReturn.Name = "keyButtonNumReturn"
        Me.keyButtonNumReturn.NormalText = Nothing
        Me.keyButtonNumReturn.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumReturn.ShiftText = Nothing
        Me.keyButtonNumReturn.Size = New System.Drawing.Size(126, 55)
        Me.keyButtonNumReturn.TabIndex = 0
        Me.keyButtonNumReturn.Text = "Enter"
        Me.keyButtonNumReturn.UnNumLockKeyCode = 0
        Me.keyButtonNumReturn.UnNumLockText = Nothing
        Me.keyButtonNumReturn.UseMnemonic = False
        Me.keyButtonNumReturn.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad0
        '
        Me.keyButtonNumberPad0.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad0.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad0.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad0.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad0.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad0.IsPressed = False
        Me.keyButtonNumberPad0.KeyCode = 96
        Me.keyButtonNumberPad0.Location = New System.Drawing.Point(398, 424)
        Me.keyButtonNumberPad0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad0.Name = "keyButtonNumberPad0"
        Me.keyButtonNumberPad0.NormalText = Nothing
        Me.keyButtonNumberPad0.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad0.ShiftText = Nothing
        Me.keyButtonNumberPad0.Size = New System.Drawing.Size(150, 55)
        Me.keyButtonNumberPad0.TabIndex = 0
        Me.keyButtonNumberPad0.Text = "0"
        Me.keyButtonNumberPad0.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad0.UnNumLockText = Nothing
        Me.keyButtonNumberPad0.UseMnemonic = False
        Me.keyButtonNumberPad0.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad1
        '
        Me.keyButtonNumberPad1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad1.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad1.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad1.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad1.IsPressed = False
        Me.keyButtonNumberPad1.KeyCode = 97
        Me.keyButtonNumberPad1.Location = New System.Drawing.Point(398, 364)
        Me.keyButtonNumberPad1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad1.Name = "keyButtonNumberPad1"
        Me.keyButtonNumberPad1.NormalText = Nothing
        Me.keyButtonNumberPad1.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad1.ShiftText = Nothing
        Me.keyButtonNumberPad1.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad1.TabIndex = 0
        Me.keyButtonNumberPad1.Text = "1"
        Me.keyButtonNumberPad1.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad1.UnNumLockText = Nothing
        Me.keyButtonNumberPad1.UseMnemonic = False
        Me.keyButtonNumberPad1.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad4
        '
        Me.keyButtonNumberPad4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad4.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad4.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad4.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad4.IsPressed = False
        Me.keyButtonNumberPad4.KeyCode = 100
        Me.keyButtonNumberPad4.Location = New System.Drawing.Point(398, 304)
        Me.keyButtonNumberPad4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad4.Name = "keyButtonNumberPad4"
        Me.keyButtonNumberPad4.NormalText = Nothing
        Me.keyButtonNumberPad4.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad4.ShiftText = Nothing
        Me.keyButtonNumberPad4.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad4.TabIndex = 0
        Me.keyButtonNumberPad4.Text = "4"
        Me.keyButtonNumberPad4.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad4.UnNumLockText = Nothing
        Me.keyButtonNumberPad4.UseMnemonic = False
        Me.keyButtonNumberPad4.UseVisualStyleBackColor = False
        '
        'keyButtonNumberPad7
        '
        Me.keyButtonNumberPad7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonNumberPad7.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonNumberPad7.FlatAppearance.BorderSize = 0
        Me.keyButtonNumberPad7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonNumberPad7.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonNumberPad7.ForeColor = System.Drawing.Color.White
        Me.keyButtonNumberPad7.IsPressed = False
        Me.keyButtonNumberPad7.KeyCode = 103
        Me.keyButtonNumberPad7.Location = New System.Drawing.Point(398, 244)
        Me.keyButtonNumberPad7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonNumberPad7.Name = "keyButtonNumberPad7"
        Me.keyButtonNumberPad7.NormalText = Nothing
        Me.keyButtonNumberPad7.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonNumberPad7.ShiftText = Nothing
        Me.keyButtonNumberPad7.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonNumberPad7.TabIndex = 0
        Me.keyButtonNumberPad7.Text = "7"
        Me.keyButtonNumberPad7.UnNumLockKeyCode = 0
        Me.keyButtonNumberPad7.UnNumLockText = Nothing
        Me.keyButtonNumberPad7.UseMnemonic = False
        Me.keyButtonNumberPad7.UseVisualStyleBackColor = False
        '
        'keyButtonF5
        '
        Me.keyButtonF5.BackColor = System.Drawing.Color.Black
        Me.keyButtonF5.FlatAppearance.BorderSize = 0
        Me.keyButtonF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF5.ForeColor = System.Drawing.Color.White
        Me.keyButtonF5.IsPressed = False
        Me.keyButtonF5.KeyCode = 116
        Me.keyButtonF5.Location = New System.Drawing.Point(244, 96)
        Me.keyButtonF5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF5.Name = "keyButtonF5"
        Me.keyButtonF5.NormalText = Nothing
        Me.keyButtonF5.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF5.ShiftText = Nothing
        Me.keyButtonF5.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonF5.TabIndex = 0
        Me.keyButtonF5.Text = "F5"
        Me.keyButtonF5.UnNumLockKeyCode = 0
        Me.keyButtonF5.UnNumLockText = Nothing
        Me.keyButtonF5.UseMnemonic = False
        Me.keyButtonF5.UseVisualStyleBackColor = False
        '
        'keyButtonD5
        '
        Me.keyButtonD5.BackColor = System.Drawing.Color.Black
        Me.keyButtonD5.FlatAppearance.BorderSize = 0
        Me.keyButtonD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD5.ForeColor = System.Drawing.Color.White
        Me.keyButtonD5.IsPressed = False
        Me.keyButtonD5.KeyCode = 53
        Me.keyButtonD5.Location = New System.Drawing.Point(198, 340)
        Me.keyButtonD5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD5.Name = "keyButtonD5"
        Me.keyButtonD5.NormalText = Nothing
        Me.keyButtonD5.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD5.ShiftText = Nothing
        Me.keyButtonD5.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD5.TabIndex = 0
        Me.keyButtonD5.Text = "5"
        Me.keyButtonD5.UnNumLockKeyCode = 0
        Me.keyButtonD5.UnNumLockText = Nothing
        Me.keyButtonD5.UseMnemonic = False
        Me.keyButtonD5.UseVisualStyleBackColor = False
        '
        'keyButtonB
        '
        Me.keyButtonB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonB.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonB.FlatAppearance.BorderSize = 0
        Me.keyButtonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonB.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonB.ForeColor = System.Drawing.Color.White
        Me.keyButtonB.IsPressed = False
        Me.keyButtonB.KeyCode = 66
        Me.keyButtonB.Location = New System.Drawing.Point(398, 124)
        Me.keyButtonB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonB.Name = "keyButtonB"
        Me.keyButtonB.NormalText = Nothing
        Me.keyButtonB.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonB.ShiftText = Nothing
        Me.keyButtonB.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonB.TabIndex = 0
        Me.keyButtonB.Text = "b"
        Me.keyButtonB.UnNumLockKeyCode = 0
        Me.keyButtonB.UnNumLockText = Nothing
        Me.keyButtonB.UseMnemonic = False
        Me.keyButtonB.UseVisualStyleBackColor = False
        '
        'keyButtonG
        '
        Me.keyButtonG.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonG.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonG.FlatAppearance.BorderSize = 0
        Me.keyButtonG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonG.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonG.ForeColor = System.Drawing.Color.White
        Me.keyButtonG.IsPressed = False
        Me.keyButtonG.KeyCode = 71
        Me.keyButtonG.Location = New System.Drawing.Point(344, 64)
        Me.keyButtonG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonG.Name = "keyButtonG"
        Me.keyButtonG.NormalText = Nothing
        Me.keyButtonG.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonG.ShiftText = Nothing
        Me.keyButtonG.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonG.TabIndex = 0
        Me.keyButtonG.Text = "g"
        Me.keyButtonG.UnNumLockKeyCode = 0
        Me.keyButtonG.UnNumLockText = Nothing
        Me.keyButtonG.UseMnemonic = False
        Me.keyButtonG.UseVisualStyleBackColor = False
        '
        'keyButtonT
        '
        Me.keyButtonT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonT.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonT.FlatAppearance.BorderSize = 0
        Me.keyButtonT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonT.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonT.ForeColor = System.Drawing.Color.White
        Me.keyButtonT.IsPressed = False
        Me.keyButtonT.KeyCode = 84
        Me.keyButtonT.Location = New System.Drawing.Point(320, 4)
        Me.keyButtonT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonT.Name = "keyButtonT"
        Me.keyButtonT.NormalText = Nothing
        Me.keyButtonT.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonT.ShiftText = Nothing
        Me.keyButtonT.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonT.TabIndex = 0
        Me.keyButtonT.Text = "t"
        Me.keyButtonT.UnNumLockKeyCode = 0
        Me.keyButtonT.UnNumLockText = Nothing
        Me.keyButtonT.UseMnemonic = False
        Me.keyButtonT.UseVisualStyleBackColor = False
        '
        'keyButtonF4
        '
        Me.keyButtonF4.BackColor = System.Drawing.Color.Black
        Me.keyButtonF4.FlatAppearance.BorderSize = 0
        Me.keyButtonF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF4.ForeColor = System.Drawing.Color.White
        Me.keyButtonF4.IsPressed = False
        Me.keyButtonF4.KeyCode = 115
        Me.keyButtonF4.Location = New System.Drawing.Point(201, 96)
        Me.keyButtonF4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF4.Name = "keyButtonF4"
        Me.keyButtonF4.NormalText = Nothing
        Me.keyButtonF4.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF4.ShiftText = Nothing
        Me.keyButtonF4.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonF4.TabIndex = 0
        Me.keyButtonF4.Text = "F4"
        Me.keyButtonF4.UnNumLockKeyCode = 0
        Me.keyButtonF4.UnNumLockText = Nothing
        Me.keyButtonF4.UseMnemonic = False
        Me.keyButtonF4.UseVisualStyleBackColor = False
        '
        'keyButtonD4
        '
        Me.keyButtonD4.BackColor = System.Drawing.Color.Black
        Me.keyButtonD4.FlatAppearance.BorderSize = 0
        Me.keyButtonD4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD4.ForeColor = System.Drawing.Color.White
        Me.keyButtonD4.IsPressed = False
        Me.keyButtonD4.KeyCode = 52
        Me.keyButtonD4.Location = New System.Drawing.Point(162, 340)
        Me.keyButtonD4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD4.Name = "keyButtonD4"
        Me.keyButtonD4.NormalText = Nothing
        Me.keyButtonD4.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD4.ShiftText = Nothing
        Me.keyButtonD4.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD4.TabIndex = 0
        Me.keyButtonD4.Text = "4"
        Me.keyButtonD4.UnNumLockKeyCode = 0
        Me.keyButtonD4.UnNumLockText = Nothing
        Me.keyButtonD4.UseMnemonic = False
        Me.keyButtonD4.UseVisualStyleBackColor = False
        '
        'keyButtonV
        '
        Me.keyButtonV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonV.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonV.FlatAppearance.BorderSize = 0
        Me.keyButtonV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonV.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonV.ForeColor = System.Drawing.Color.White
        Me.keyButtonV.IsPressed = False
        Me.keyButtonV.KeyCode = 86
        Me.keyButtonV.Location = New System.Drawing.Point(320, 124)
        Me.keyButtonV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonV.Name = "keyButtonV"
        Me.keyButtonV.NormalText = Nothing
        Me.keyButtonV.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonV.ShiftText = Nothing
        Me.keyButtonV.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonV.TabIndex = 0
        Me.keyButtonV.Text = "v"
        Me.keyButtonV.UnNumLockKeyCode = 0
        Me.keyButtonV.UnNumLockText = Nothing
        Me.keyButtonV.UseMnemonic = False
        Me.keyButtonV.UseVisualStyleBackColor = False
        '
        'keyButtonF
        '
        Me.keyButtonF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonF.FlatAppearance.BorderSize = 0
        Me.keyButtonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonF.ForeColor = System.Drawing.Color.White
        Me.keyButtonF.IsPressed = False
        Me.keyButtonF.KeyCode = 70
        Me.keyButtonF.Location = New System.Drawing.Point(266, 64)
        Me.keyButtonF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF.Name = "keyButtonF"
        Me.keyButtonF.NormalText = Nothing
        Me.keyButtonF.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF.ShiftText = Nothing
        Me.keyButtonF.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF.TabIndex = 0
        Me.keyButtonF.Text = "f"
        Me.keyButtonF.UnNumLockKeyCode = 0
        Me.keyButtonF.UnNumLockText = Nothing
        Me.keyButtonF.UseMnemonic = False
        Me.keyButtonF.UseVisualStyleBackColor = False
        '
        'keyButtonR
        '
        Me.keyButtonR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonR.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonR.FlatAppearance.BorderSize = 0
        Me.keyButtonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonR.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonR.ForeColor = System.Drawing.Color.White
        Me.keyButtonR.IsPressed = False
        Me.keyButtonR.KeyCode = 82
        Me.keyButtonR.Location = New System.Drawing.Point(242, 4)
        Me.keyButtonR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonR.Name = "keyButtonR"
        Me.keyButtonR.NormalText = Nothing
        Me.keyButtonR.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonR.ShiftText = Nothing
        Me.keyButtonR.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonR.TabIndex = 0
        Me.keyButtonR.Text = "r"
        Me.keyButtonR.UnNumLockKeyCode = 0
        Me.keyButtonR.UnNumLockText = Nothing
        Me.keyButtonR.UseMnemonic = False
        Me.keyButtonR.UseVisualStyleBackColor = False
        '
        'keyButtonF3
        '
        Me.keyButtonF3.BackColor = System.Drawing.Color.Black
        Me.keyButtonF3.FlatAppearance.BorderSize = 0
        Me.keyButtonF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF3.ForeColor = System.Drawing.Color.White
        Me.keyButtonF3.IsPressed = False
        Me.keyButtonF3.KeyCode = 114
        Me.keyButtonF3.Location = New System.Drawing.Point(158, 96)
        Me.keyButtonF3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF3.Name = "keyButtonF3"
        Me.keyButtonF3.NormalText = Nothing
        Me.keyButtonF3.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF3.ShiftText = Nothing
        Me.keyButtonF3.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonF3.TabIndex = 0
        Me.keyButtonF3.Text = "F3"
        Me.keyButtonF3.UnNumLockKeyCode = 0
        Me.keyButtonF3.UnNumLockText = Nothing
        Me.keyButtonF3.UseMnemonic = False
        Me.keyButtonF3.UseVisualStyleBackColor = False
        '
        'keyButtonD3
        '
        Me.keyButtonD3.BackColor = System.Drawing.Color.Black
        Me.keyButtonD3.FlatAppearance.BorderSize = 0
        Me.keyButtonD3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD3.ForeColor = System.Drawing.Color.White
        Me.keyButtonD3.IsPressed = False
        Me.keyButtonD3.KeyCode = 51
        Me.keyButtonD3.Location = New System.Drawing.Point(126, 340)
        Me.keyButtonD3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD3.Name = "keyButtonD3"
        Me.keyButtonD3.NormalText = Nothing
        Me.keyButtonD3.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD3.ShiftText = Nothing
        Me.keyButtonD3.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD3.TabIndex = 0
        Me.keyButtonD3.Text = "3"
        Me.keyButtonD3.UnNumLockKeyCode = 0
        Me.keyButtonD3.UnNumLockText = Nothing
        Me.keyButtonD3.UseMnemonic = False
        Me.keyButtonD3.UseVisualStyleBackColor = False
        '
        'keyButtonSpace
        '
        Me.keyButtonSpace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonSpace.FlatAppearance.BorderSize = 0
        Me.keyButtonSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonSpace.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonSpace.ForeColor = System.Drawing.Color.White
        Me.keyButtonSpace.IsPressed = False
        Me.keyButtonSpace.KeyCode = 32
        Me.keyButtonSpace.Location = New System.Drawing.Point(320, 184)
        Me.keyButtonSpace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonSpace.Name = "keyButtonSpace"
        Me.keyButtonSpace.NormalText = Nothing
        Me.keyButtonSpace.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonSpace.ShiftText = Nothing
        Me.keyButtonSpace.Size = New System.Drawing.Size(384, 55)
        Me.keyButtonSpace.TabIndex = 0
        Me.keyButtonSpace.UnNumLockKeyCode = 0
        Me.keyButtonSpace.UnNumLockText = Nothing
        Me.keyButtonSpace.UseMnemonic = False
        Me.keyButtonSpace.UseVisualStyleBackColor = False
        '
        'keyButtonC
        '
        Me.keyButtonC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonC.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonC.FlatAppearance.BorderSize = 0
        Me.keyButtonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonC.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonC.ForeColor = System.Drawing.Color.White
        Me.keyButtonC.IsPressed = False
        Me.keyButtonC.KeyCode = 67
        Me.keyButtonC.Location = New System.Drawing.Point(242, 124)
        Me.keyButtonC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonC.Name = "keyButtonC"
        Me.keyButtonC.NormalText = Nothing
        Me.keyButtonC.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonC.ShiftText = Nothing
        Me.keyButtonC.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonC.TabIndex = 0
        Me.keyButtonC.Text = "c"
        Me.keyButtonC.UnNumLockKeyCode = 0
        Me.keyButtonC.UnNumLockText = Nothing
        Me.keyButtonC.UseMnemonic = False
        Me.keyButtonC.UseVisualStyleBackColor = False
        '
        'keyButtonD
        '
        Me.keyButtonD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonD.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonD.FlatAppearance.BorderSize = 0
        Me.keyButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonD.ForeColor = System.Drawing.Color.White
        Me.keyButtonD.IsPressed = False
        Me.keyButtonD.KeyCode = 68
        Me.keyButtonD.Location = New System.Drawing.Point(188, 64)
        Me.keyButtonD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD.Name = "keyButtonD"
        Me.keyButtonD.NormalText = Nothing
        Me.keyButtonD.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD.ShiftText = Nothing
        Me.keyButtonD.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonD.TabIndex = 0
        Me.keyButtonD.Text = "d"
        Me.keyButtonD.UnNumLockKeyCode = 0
        Me.keyButtonD.UnNumLockText = Nothing
        Me.keyButtonD.UseMnemonic = False
        Me.keyButtonD.UseVisualStyleBackColor = False
        '
        'keyButtonE
        '
        Me.keyButtonE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonE.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonE.FlatAppearance.BorderSize = 0
        Me.keyButtonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonE.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonE.ForeColor = System.Drawing.Color.White
        Me.keyButtonE.IsPressed = False
        Me.keyButtonE.KeyCode = 69
        Me.keyButtonE.Location = New System.Drawing.Point(164, 4)
        Me.keyButtonE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonE.Name = "keyButtonE"
        Me.keyButtonE.NormalText = Nothing
        Me.keyButtonE.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonE.ShiftText = Nothing
        Me.keyButtonE.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonE.TabIndex = 0
        Me.keyButtonE.Text = "e"
        Me.keyButtonE.UnNumLockKeyCode = 0
        Me.keyButtonE.UnNumLockText = Nothing
        Me.keyButtonE.UseMnemonic = False
        Me.keyButtonE.UseVisualStyleBackColor = False
        '
        'keyButtonF12
        '
        Me.keyButtonF12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF12.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF12.FlatAppearance.BorderSize = 0
        Me.keyButtonF12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF12.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF12.ForeColor = System.Drawing.Color.White
        Me.keyButtonF12.IsPressed = False
        Me.keyButtonF12.KeyCode = 123
        Me.keyButtonF12.Location = New System.Drawing.Point(872, 15)
        Me.keyButtonF12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF12.Name = "keyButtonF12"
        Me.keyButtonF12.NormalText = Nothing
        Me.keyButtonF12.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF12.ShiftText = Nothing
        Me.keyButtonF12.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF12.TabIndex = 0
        Me.keyButtonF12.Text = "F12"
        Me.keyButtonF12.UnNumLockKeyCode = 0
        Me.keyButtonF12.UnNumLockText = Nothing
        Me.keyButtonF12.UseMnemonic = False
        Me.keyButtonF12.UseVisualStyleBackColor = False
        '
        'keyButtonF2
        '
        Me.keyButtonF2.BackColor = System.Drawing.Color.Black
        Me.keyButtonF2.FlatAppearance.BorderSize = 0
        Me.keyButtonF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF2.ForeColor = System.Drawing.Color.White
        Me.keyButtonF2.IsPressed = False
        Me.keyButtonF2.KeyCode = 113
        Me.keyButtonF2.Location = New System.Drawing.Point(115, 96)
        Me.keyButtonF2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF2.Name = "keyButtonF2"
        Me.keyButtonF2.NormalText = Nothing
        Me.keyButtonF2.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF2.ShiftText = Nothing
        Me.keyButtonF2.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonF2.TabIndex = 0
        Me.keyButtonF2.Text = "F2"
        Me.keyButtonF2.UnNumLockKeyCode = 0
        Me.keyButtonF2.UnNumLockText = Nothing
        Me.keyButtonF2.UseMnemonic = False
        Me.keyButtonF2.UseVisualStyleBackColor = False
        '
        'keyButtonD2
        '
        Me.keyButtonD2.BackColor = System.Drawing.Color.Black
        Me.keyButtonD2.FlatAppearance.BorderSize = 0
        Me.keyButtonD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD2.ForeColor = System.Drawing.Color.White
        Me.keyButtonD2.IsPressed = False
        Me.keyButtonD2.KeyCode = 50
        Me.keyButtonD2.Location = New System.Drawing.Point(90, 340)
        Me.keyButtonD2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD2.Name = "keyButtonD2"
        Me.keyButtonD2.NormalText = Nothing
        Me.keyButtonD2.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD2.ShiftText = Nothing
        Me.keyButtonD2.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD2.TabIndex = 0
        Me.keyButtonD2.Text = "2"
        Me.keyButtonD2.UnNumLockKeyCode = 0
        Me.keyButtonD2.UnNumLockText = Nothing
        Me.keyButtonD2.UseMnemonic = False
        Me.keyButtonD2.UseVisualStyleBackColor = False
        '
        'keyButtonLAlt
        '
        Me.keyButtonLAlt.BackColor = System.Drawing.Color.Black
        Me.keyButtonLAlt.FlatAppearance.BorderSize = 0
        Me.keyButtonLAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonLAlt.ForeColor = System.Drawing.Color.White
        Me.keyButtonLAlt.IsPressed = False
        Me.keyButtonLAlt.KeyCode = 18
        Me.keyButtonLAlt.Location = New System.Drawing.Point(357, 153)
        Me.keyButtonLAlt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonLAlt.Name = "keyButtonLAlt"
        Me.keyButtonLAlt.NormalText = Nothing
        Me.keyButtonLAlt.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonLAlt.ShiftText = Nothing
        Me.keyButtonLAlt.Size = New System.Drawing.Size(38, 30)
        Me.keyButtonLAlt.TabIndex = 0
        Me.keyButtonLAlt.Text = "Alt"
        Me.keyButtonLAlt.UnNumLockKeyCode = 0
        Me.keyButtonLAlt.UnNumLockText = Nothing
        Me.keyButtonLAlt.UseMnemonic = False
        Me.keyButtonLAlt.UseVisualStyleBackColor = False
        '
        'keyButtonX
        '
        Me.keyButtonX.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonX.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonX.FlatAppearance.BorderSize = 0
        Me.keyButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonX.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonX.ForeColor = System.Drawing.Color.White
        Me.keyButtonX.IsPressed = False
        Me.keyButtonX.KeyCode = 88
        Me.keyButtonX.Location = New System.Drawing.Point(164, 124)
        Me.keyButtonX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonX.Name = "keyButtonX"
        Me.keyButtonX.NormalText = Nothing
        Me.keyButtonX.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonX.ShiftText = Nothing
        Me.keyButtonX.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonX.TabIndex = 0
        Me.keyButtonX.Text = "x"
        Me.keyButtonX.UnNumLockKeyCode = 0
        Me.keyButtonX.UnNumLockText = Nothing
        Me.keyButtonX.UseMnemonic = False
        Me.keyButtonX.UseVisualStyleBackColor = False
        '
        'keyButtonS
        '
        Me.keyButtonS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonS.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonS.FlatAppearance.BorderSize = 0
        Me.keyButtonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonS.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonS.ForeColor = System.Drawing.Color.White
        Me.keyButtonS.IsPressed = False
        Me.keyButtonS.KeyCode = 83
        Me.keyButtonS.Location = New System.Drawing.Point(110, 64)
        Me.keyButtonS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonS.Name = "keyButtonS"
        Me.keyButtonS.NormalText = Nothing
        Me.keyButtonS.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonS.ShiftText = Nothing
        Me.keyButtonS.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonS.TabIndex = 0
        Me.keyButtonS.Text = "s"
        Me.keyButtonS.UnNumLockKeyCode = 0
        Me.keyButtonS.UnNumLockText = Nothing
        Me.keyButtonS.UseMnemonic = False
        Me.keyButtonS.UseVisualStyleBackColor = False
        '
        'keyButtonW
        '
        Me.keyButtonW.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonW.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonW.FlatAppearance.BorderSize = 0
        Me.keyButtonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonW.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonW.ForeColor = System.Drawing.Color.White
        Me.keyButtonW.IsPressed = False
        Me.keyButtonW.KeyCode = 87
        Me.keyButtonW.Location = New System.Drawing.Point(86, 4)
        Me.keyButtonW.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonW.Name = "keyButtonW"
        Me.keyButtonW.NormalText = Nothing
        Me.keyButtonW.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonW.ShiftText = Nothing
        Me.keyButtonW.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonW.TabIndex = 0
        Me.keyButtonW.Text = "w"
        Me.keyButtonW.UnNumLockKeyCode = 0
        Me.keyButtonW.UnNumLockText = Nothing
        Me.keyButtonW.UseMnemonic = False
        Me.keyButtonW.UseVisualStyleBackColor = False
        '
        'keyButtonF11
        '
        Me.keyButtonF11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonF11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonF11.FlatAppearance.BorderSize = 0
        Me.keyButtonF11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF11.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonF11.ForeColor = System.Drawing.Color.White
        Me.keyButtonF11.IsPressed = False
        Me.keyButtonF11.KeyCode = 122
        Me.keyButtonF11.Location = New System.Drawing.Point(794, 15)
        Me.keyButtonF11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF11.Name = "keyButtonF11"
        Me.keyButtonF11.NormalText = Nothing
        Me.keyButtonF11.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF11.ShiftText = Nothing
        Me.keyButtonF11.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonF11.TabIndex = 0
        Me.keyButtonF11.Text = "F11"
        Me.keyButtonF11.UnNumLockKeyCode = 0
        Me.keyButtonF11.UnNumLockText = Nothing
        Me.keyButtonF11.UseMnemonic = False
        Me.keyButtonF11.UseVisualStyleBackColor = False
        '
        'keyButtonF1
        '
        Me.keyButtonF1.BackColor = System.Drawing.Color.Black
        Me.keyButtonF1.FlatAppearance.BorderSize = 0
        Me.keyButtonF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonF1.ForeColor = System.Drawing.Color.White
        Me.keyButtonF1.IsPressed = False
        Me.keyButtonF1.KeyCode = 112
        Me.keyButtonF1.Location = New System.Drawing.Point(72, 96)
        Me.keyButtonF1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonF1.Name = "keyButtonF1"
        Me.keyButtonF1.NormalText = Nothing
        Me.keyButtonF1.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonF1.ShiftText = Nothing
        Me.keyButtonF1.Size = New System.Drawing.Size(40, 30)
        Me.keyButtonF1.TabIndex = 0
        Me.keyButtonF1.Text = "F1"
        Me.keyButtonF1.UnNumLockKeyCode = 0
        Me.keyButtonF1.UnNumLockText = Nothing
        Me.keyButtonF1.UseMnemonic = False
        Me.keyButtonF1.UseVisualStyleBackColor = False
        '
        'keyButtonD1
        '
        Me.keyButtonD1.BackColor = System.Drawing.Color.Black
        Me.keyButtonD1.FlatAppearance.BorderSize = 0
        Me.keyButtonD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonD1.ForeColor = System.Drawing.Color.White
        Me.keyButtonD1.IsPressed = False
        Me.keyButtonD1.KeyCode = 49
        Me.keyButtonD1.Location = New System.Drawing.Point(53, 340)
        Me.keyButtonD1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonD1.Name = "keyButtonD1"
        Me.keyButtonD1.NormalText = Nothing
        Me.keyButtonD1.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonD1.ShiftText = Nothing
        Me.keyButtonD1.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonD1.TabIndex = 0
        Me.keyButtonD1.Text = "1"
        Me.keyButtonD1.UnNumLockKeyCode = 0
        Me.keyButtonD1.UnNumLockText = Nothing
        Me.keyButtonD1.UseMnemonic = False
        Me.keyButtonD1.UseVisualStyleBackColor = False
        '
        'keyButtonWin
        '
        Me.keyButtonWin.BackColor = System.Drawing.Color.Black
        Me.keyButtonWin.FlatAppearance.BorderSize = 0
        Me.keyButtonWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonWin.ForeColor = System.Drawing.Color.White
        Me.keyButtonWin.IsPressed = False
        Me.keyButtonWin.KeyCode = 91
        Me.keyButtonWin.Location = New System.Drawing.Point(392, 15)
        Me.keyButtonWin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonWin.Name = "keyButtonWin"
        Me.keyButtonWin.NormalText = Nothing
        Me.keyButtonWin.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonWin.ShiftText = Nothing
        Me.keyButtonWin.Size = New System.Drawing.Size(43, 30)
        Me.keyButtonWin.TabIndex = 0
        Me.keyButtonWin.Text = "Win"
        Me.keyButtonWin.UnNumLockKeyCode = 0
        Me.keyButtonWin.UnNumLockText = Nothing
        Me.keyButtonWin.UseMnemonic = False
        Me.keyButtonWin.UseVisualStyleBackColor = False
        '
        'keyButtonZ
        '
        Me.keyButtonZ.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonZ.FlatAppearance.BorderSize = 0
        Me.keyButtonZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonZ.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonZ.ForeColor = System.Drawing.Color.White
        Me.keyButtonZ.IsPressed = False
        Me.keyButtonZ.KeyCode = 90
        Me.keyButtonZ.Location = New System.Drawing.Point(86, 124)
        Me.keyButtonZ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonZ.Name = "keyButtonZ"
        Me.keyButtonZ.NormalText = Nothing
        Me.keyButtonZ.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonZ.ShiftText = Nothing
        Me.keyButtonZ.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonZ.TabIndex = 0
        Me.keyButtonZ.Text = "z"
        Me.keyButtonZ.UnNumLockKeyCode = 0
        Me.keyButtonZ.UnNumLockText = Nothing
        Me.keyButtonZ.UseMnemonic = False
        Me.keyButtonZ.UseVisualStyleBackColor = False
        '
        'keyButtonA
        '
        Me.keyButtonA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonA.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonA.FlatAppearance.BorderSize = 0
        Me.keyButtonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonA.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonA.ForeColor = System.Drawing.Color.White
        Me.keyButtonA.IsPressed = False
        Me.keyButtonA.KeyCode = 65
        Me.keyButtonA.Location = New System.Drawing.Point(32, 64)
        Me.keyButtonA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonA.Name = "keyButtonA"
        Me.keyButtonA.NormalText = Nothing
        Me.keyButtonA.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonA.ShiftText = Nothing
        Me.keyButtonA.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonA.TabIndex = 0
        Me.keyButtonA.Text = "a"
        Me.keyButtonA.UnNumLockKeyCode = 0
        Me.keyButtonA.UnNumLockText = Nothing
        Me.keyButtonA.UseMnemonic = False
        Me.keyButtonA.UseVisualStyleBackColor = False
        '
        'keyButtonQ
        '
        Me.keyButtonQ.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.keyButtonQ.FlatAppearance.BorderSize = 0
        Me.keyButtonQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonQ.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.keyButtonQ.ForeColor = System.Drawing.Color.White
        Me.keyButtonQ.IsPressed = False
        Me.keyButtonQ.KeyCode = 81
        Me.keyButtonQ.Location = New System.Drawing.Point(8, 4)
        Me.keyButtonQ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonQ.Name = "keyButtonQ"
        Me.keyButtonQ.NormalText = Nothing
        Me.keyButtonQ.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonQ.ShiftText = Nothing
        Me.keyButtonQ.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonQ.TabIndex = 0
        Me.keyButtonQ.Text = "q"
        Me.keyButtonQ.UnNumLockKeyCode = 0
        Me.keyButtonQ.UnNumLockText = Nothing
        Me.keyButtonQ.UseMnemonic = False
        Me.keyButtonQ.UseVisualStyleBackColor = False
        '
        'keyButtonTilde
        '
        Me.keyButtonTilde.BackColor = System.Drawing.Color.Black
        Me.keyButtonTilde.FlatAppearance.BorderSize = 0
        Me.keyButtonTilde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonTilde.ForeColor = System.Drawing.Color.White
        Me.keyButtonTilde.IsPressed = False
        Me.keyButtonTilde.KeyCode = 192
        Me.keyButtonTilde.Location = New System.Drawing.Point(18, 340)
        Me.keyButtonTilde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonTilde.Name = "keyButtonTilde"
        Me.keyButtonTilde.NormalText = Nothing
        Me.keyButtonTilde.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonTilde.ShiftText = Nothing
        Me.keyButtonTilde.Size = New System.Drawing.Size(30, 30)
        Me.keyButtonTilde.TabIndex = 0
        Me.keyButtonTilde.Text = "`"
        Me.keyButtonTilde.UnNumLockKeyCode = 0
        Me.keyButtonTilde.UnNumLockText = Nothing
        Me.keyButtonTilde.UseMnemonic = False
        Me.keyButtonTilde.UseVisualStyleBackColor = False
        '
        'keyButtonLControl
        '
        Me.keyButtonLControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.keyButtonLControl.FlatAppearance.BorderSize = 0
        Me.keyButtonLControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonLControl.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonLControl.ForeColor = System.Drawing.Color.White
        Me.keyButtonLControl.IsPressed = False
        Me.keyButtonLControl.KeyCode = 17
        Me.keyButtonLControl.Location = New System.Drawing.Point(169, 8)
        Me.keyButtonLControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonLControl.Name = "keyButtonLControl"
        Me.keyButtonLControl.NormalText = Nothing
        Me.keyButtonLControl.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonLControl.ShiftText = Nothing
        Me.keyButtonLControl.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonLControl.TabIndex = 0
        Me.keyButtonLControl.Text = "Ctrl"
        Me.keyButtonLControl.UnNumLockKeyCode = 0
        Me.keyButtonLControl.UnNumLockText = Nothing
        Me.keyButtonLControl.UseMnemonic = False
        Me.keyButtonLControl.UseVisualStyleBackColor = False
        '
        'keyButtonLShift
        '
        Me.keyButtonLShift.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonLShift.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonLShift.FlatAppearance.BorderSize = 0
        Me.keyButtonLShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonLShift.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyButtonLShift.ForeColor = System.Drawing.Color.White
        Me.keyButtonLShift.IsPressed = False
        Me.keyButtonLShift.KeyCode = 16
        Me.keyButtonLShift.Location = New System.Drawing.Point(8, 124)
        Me.keyButtonLShift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonLShift.Name = "keyButtonLShift"
        Me.keyButtonLShift.NormalText = Nothing
        Me.keyButtonLShift.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonLShift.ShiftText = Nothing
        Me.keyButtonLShift.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonLShift.TabIndex = 0
        Me.keyButtonLShift.Text = "↑"
        Me.keyButtonLShift.UnNumLockKeyCode = 0
        Me.keyButtonLShift.UnNumLockText = Nothing
        Me.keyButtonLShift.UseMnemonic = False
        Me.keyButtonLShift.UseVisualStyleBackColor = False
        '
        'keyButtonCapsLock
        '
        Me.keyButtonCapsLock.BackColor = System.Drawing.Color.Black
        Me.keyButtonCapsLock.FlatAppearance.BorderSize = 0
        Me.keyButtonCapsLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonCapsLock.ForeColor = System.Drawing.Color.White
        Me.keyButtonCapsLock.IsPressed = False
        Me.keyButtonCapsLock.KeyCode = 20
        Me.keyButtonCapsLock.Location = New System.Drawing.Point(449, 17)
        Me.keyButtonCapsLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonCapsLock.Name = "keyButtonCapsLock"
        Me.keyButtonCapsLock.NormalText = Nothing
        Me.keyButtonCapsLock.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonCapsLock.ShiftText = Nothing
        Me.keyButtonCapsLock.Size = New System.Drawing.Size(81, 30)
        Me.keyButtonCapsLock.TabIndex = 0
        Me.keyButtonCapsLock.Text = "Caps"
        Me.keyButtonCapsLock.UnNumLockKeyCode = 0
        Me.keyButtonCapsLock.UnNumLockText = Nothing
        Me.keyButtonCapsLock.UseMnemonic = False
        Me.keyButtonCapsLock.UseVisualStyleBackColor = False
        '
        'keyButtonTab
        '
        Me.keyButtonTab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.keyButtonTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.keyButtonTab.FlatAppearance.BorderSize = 0
        Me.keyButtonTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonTab.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.keyButtonTab.ForeColor = System.Drawing.Color.White
        Me.keyButtonTab.IsPressed = False
        Me.keyButtonTab.KeyCode = 9
        Me.keyButtonTab.Location = New System.Drawing.Point(325, 17)
        Me.keyButtonTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonTab.Name = "keyButtonTab"
        Me.keyButtonTab.NormalText = Nothing
        Me.keyButtonTab.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonTab.ShiftText = Nothing
        Me.keyButtonTab.Size = New System.Drawing.Size(72, 55)
        Me.keyButtonTab.TabIndex = 0
        Me.keyButtonTab.Text = "Tab"
        Me.keyButtonTab.UnNumLockKeyCode = 0
        Me.keyButtonTab.UnNumLockText = Nothing
        Me.keyButtonTab.UseMnemonic = False
        Me.keyButtonTab.UseVisualStyleBackColor = False
        '
        'keyButtonEscape
        '
        Me.keyButtonEscape.BackColor = System.Drawing.Color.Black
        Me.keyButtonEscape.FlatAppearance.BorderSize = 0
        Me.keyButtonEscape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyButtonEscape.ForeColor = System.Drawing.Color.White
        Me.keyButtonEscape.IsPressed = False
        Me.keyButtonEscape.KeyCode = 27
        Me.keyButtonEscape.Location = New System.Drawing.Point(24, 96)
        Me.keyButtonEscape.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.keyButtonEscape.Name = "keyButtonEscape"
        Me.keyButtonEscape.NormalText = Nothing
        Me.keyButtonEscape.Padding = New System.Windows.Forms.Padding(2)
        Me.keyButtonEscape.ShiftText = Nothing
        Me.keyButtonEscape.Size = New System.Drawing.Size(45, 30)
        Me.keyButtonEscape.TabIndex = 0
        Me.keyButtonEscape.Text = "Esc"
        Me.keyButtonEscape.UnNumLockKeyCode = 0
        Me.keyButtonEscape.UnNumLockText = Nothing
        Me.keyButtonEscape.UseMnemonic = False
        Me.keyButtonEscape.UseVisualStyleBackColor = False
        '
        'KeyButton1
        '
        Me.KeyButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton1.FlatAppearance.BorderSize = 0
        Me.KeyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyButton1.ForeColor = System.Drawing.Color.White
        Me.KeyButton1.IsPressed = False
        Me.KeyButton1.KeyCode = 8
        Me.KeyButton1.Location = New System.Drawing.Point(788, 244)
        Me.KeyButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton1.Name = "KeyButton1"
        Me.KeyButton1.NormalText = Nothing
        Me.KeyButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton1.ShiftText = Nothing
        Me.KeyButton1.Size = New System.Drawing.Size(150, 55)
        Me.KeyButton1.TabIndex = 3
        Me.KeyButton1.Text = "<<"
        Me.KeyButton1.UnNumLockKeyCode = 0
        Me.KeyButton1.UnNumLockText = Nothing
        Me.KeyButton1.UseMnemonic = False
        Me.KeyButton1.UseVisualStyleBackColor = False
        '
        'KeyButton2
        '
        Me.KeyButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton2.FlatAppearance.BorderSize = 0
        Me.KeyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton2.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton2.ForeColor = System.Drawing.Color.White
        Me.KeyButton2.IsPressed = False
        Me.KeyButton2.KeyCode = 110
        Me.KeyButton2.Location = New System.Drawing.Point(866, 424)
        Me.KeyButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton2.Name = "KeyButton2"
        Me.KeyButton2.NormalText = Nothing
        Me.KeyButton2.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton2.ShiftText = Nothing
        Me.KeyButton2.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton2.TabIndex = 4
        Me.KeyButton2.Text = "Hide"
        Me.KeyButton2.UnNumLockKeyCode = 0
        Me.KeyButton2.UnNumLockText = Nothing
        Me.KeyButton2.UseMnemonic = False
        Me.KeyButton2.UseVisualStyleBackColor = False
        '
        'KeyButton3
        '
        Me.KeyButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton3.FlatAppearance.BorderSize = 0
        Me.KeyButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton3.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton3.ForeColor = System.Drawing.Color.White
        Me.KeyButton3.IsPressed = False
        Me.KeyButton3.KeyCode = 110
        Me.KeyButton3.Location = New System.Drawing.Point(866, 184)
        Me.KeyButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton3.Name = "KeyButton3"
        Me.KeyButton3.NormalText = Nothing
        Me.KeyButton3.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton3.ShiftText = Nothing
        Me.KeyButton3.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton3.TabIndex = 5
        Me.KeyButton3.Text = "Hide"
        Me.KeyButton3.UnNumLockKeyCode = 0
        Me.KeyButton3.UnNumLockText = Nothing
        Me.KeyButton3.UseMnemonic = False
        Me.KeyButton3.UseVisualStyleBackColor = False
        '
        'KeyButton5
        '
        Me.KeyButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.KeyButton5.FlatAppearance.BorderSize = 0
        Me.KeyButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton5.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton5.ForeColor = System.Drawing.Color.White
        Me.KeyButton5.IsPressed = False
        Me.KeyButton5.KeyCode = 110
        Me.KeyButton5.Location = New System.Drawing.Point(756, 27)
        Me.KeyButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton5.Name = "KeyButton5"
        Me.KeyButton5.NormalText = Nothing
        Me.KeyButton5.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton5.ShiftText = Nothing
        Me.KeyButton5.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton5.TabIndex = 7
        Me.KeyButton5.UnNumLockKeyCode = 0
        Me.KeyButton5.UnNumLockText = Nothing
        Me.KeyButton5.UseMnemonic = False
        Me.KeyButton5.UseVisualStyleBackColor = False
        '
        'KeyButton6
        '
        Me.KeyButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.KeyButton6.FlatAppearance.BorderSize = 0
        Me.KeyButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton6.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton6.ForeColor = System.Drawing.Color.White
        Me.KeyButton6.IsPressed = False
        Me.KeyButton6.KeyCode = 110
        Me.KeyButton6.Location = New System.Drawing.Point(725, 139)
        Me.KeyButton6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton6.Name = "KeyButton6"
        Me.KeyButton6.NormalText = Nothing
        Me.KeyButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton6.ShiftText = Nothing
        Me.KeyButton6.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton6.TabIndex = 8
        Me.KeyButton6.UnNumLockKeyCode = 0
        Me.KeyButton6.UnNumLockText = Nothing
        Me.KeyButton6.UseMnemonic = False
        Me.KeyButton6.UseVisualStyleBackColor = False
        '
        'KeyButton7
        '
        Me.KeyButton7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton7.FlatAppearance.BorderSize = 0
        Me.KeyButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton7.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton7.ForeColor = System.Drawing.Color.White
        Me.KeyButton7.IsPressed = False
        Me.KeyButton7.KeyCode = 110
        Me.KeyButton7.Location = New System.Drawing.Point(8, 184)
        Me.KeyButton7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton7.Name = "KeyButton7"
        Me.KeyButton7.NormalText = Nothing
        Me.KeyButton7.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton7.ShiftText = Nothing
        Me.KeyButton7.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton7.TabIndex = 9
        Me.KeyButton7.Text = "&123"
        Me.KeyButton7.UnNumLockKeyCode = 0
        Me.KeyButton7.UnNumLockText = Nothing
        Me.KeyButton7.UseMnemonic = False
        Me.KeyButton7.UseVisualStyleBackColor = False
        '
        'KeyButton8
        '
        Me.KeyButton8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton8.BackColor = System.Drawing.Color.DarkOrange
        Me.KeyButton8.FlatAppearance.BorderSize = 0
        Me.KeyButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton8.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton8.ForeColor = System.Drawing.Color.White
        Me.KeyButton8.IsPressed = False
        Me.KeyButton8.KeyCode = 110
        Me.KeyButton8.Location = New System.Drawing.Point(8, 424)
        Me.KeyButton8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton8.Name = "KeyButton8"
        Me.KeyButton8.NormalText = Nothing
        Me.KeyButton8.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton8.ShiftText = Nothing
        Me.KeyButton8.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton8.TabIndex = 38
        Me.KeyButton8.Text = "&123"
        Me.KeyButton8.UnNumLockKeyCode = 0
        Me.KeyButton8.UnNumLockText = Nothing
        Me.KeyButton8.UseMnemonic = False
        Me.KeyButton8.UseVisualStyleBackColor = False
        '
        'KeyButton14
        '
        Me.KeyButton14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton14.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton14.FlatAppearance.BorderSize = 0
        Me.KeyButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton14.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton14.ForeColor = System.Drawing.Color.White
        Me.KeyButton14.IsPressed = False
        Me.KeyButton14.KeyCode = 74
        Me.KeyButton14.Location = New System.Drawing.Point(414, 75)
        Me.KeyButton14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton14.Name = "KeyButton14"
        Me.KeyButton14.NormalText = Nothing
        Me.KeyButton14.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton14.ShiftText = Nothing
        Me.KeyButton14.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton14.TabIndex = 31
        Me.KeyButton14.UnNumLockKeyCode = 0
        Me.KeyButton14.UnNumLockText = Nothing
        Me.KeyButton14.UseMnemonic = False
        Me.KeyButton14.UseVisualStyleBackColor = False
        '
        'KeyButton15
        '
        Me.KeyButton15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton15.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton15.FlatAppearance.BorderSize = 0
        Me.KeyButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton15.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton15.ForeColor = System.Drawing.Color.White
        Me.KeyButton15.IsPressed = False
        Me.KeyButton15.KeyCode = 85
        Me.KeyButton15.Location = New System.Drawing.Point(414, 15)
        Me.KeyButton15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton15.Name = "KeyButton15"
        Me.KeyButton15.NormalText = Nothing
        Me.KeyButton15.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton15.ShiftText = Nothing
        Me.KeyButton15.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton15.TabIndex = 30
        Me.KeyButton15.UnNumLockKeyCode = 0
        Me.KeyButton15.UnNumLockText = Nothing
        Me.KeyButton15.UseMnemonic = False
        Me.KeyButton15.UseVisualStyleBackColor = False
        '
        'KeyButton16
        '
        Me.KeyButton16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton16.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton16.FlatAppearance.BorderSize = 0
        Me.KeyButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton16.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton16.ForeColor = System.Drawing.Color.White
        Me.KeyButton16.IsPressed = False
        Me.KeyButton16.KeyCode = 78
        Me.KeyButton16.Location = New System.Drawing.Point(414, 135)
        Me.KeyButton16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton16.Name = "KeyButton16"
        Me.KeyButton16.NormalText = Nothing
        Me.KeyButton16.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton16.ShiftText = Nothing
        Me.KeyButton16.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton16.TabIndex = 29
        Me.KeyButton16.UnNumLockKeyCode = 0
        Me.KeyButton16.UnNumLockText = Nothing
        Me.KeyButton16.UseMnemonic = False
        Me.KeyButton16.UseVisualStyleBackColor = False
        '
        'KeyButton17
        '
        Me.KeyButton17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton17.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton17.FlatAppearance.BorderSize = 0
        Me.KeyButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton17.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton17.ForeColor = System.Drawing.Color.White
        Me.KeyButton17.IsPressed = False
        Me.KeyButton17.KeyCode = 72
        Me.KeyButton17.Location = New System.Drawing.Point(336, 75)
        Me.KeyButton17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton17.Name = "KeyButton17"
        Me.KeyButton17.NormalText = Nothing
        Me.KeyButton17.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton17.ShiftText = Nothing
        Me.KeyButton17.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton17.TabIndex = 28
        Me.KeyButton17.UnNumLockKeyCode = 0
        Me.KeyButton17.UnNumLockText = Nothing
        Me.KeyButton17.UseMnemonic = False
        Me.KeyButton17.UseVisualStyleBackColor = False
        '
        'KeyButton18
        '
        Me.KeyButton18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton18.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton18.FlatAppearance.BorderSize = 0
        Me.KeyButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton18.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton18.ForeColor = System.Drawing.Color.White
        Me.KeyButton18.IsPressed = False
        Me.KeyButton18.KeyCode = 89
        Me.KeyButton18.Location = New System.Drawing.Point(336, 15)
        Me.KeyButton18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton18.Name = "KeyButton18"
        Me.KeyButton18.NormalText = Nothing
        Me.KeyButton18.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton18.ShiftText = Nothing
        Me.KeyButton18.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton18.TabIndex = 27
        Me.KeyButton18.UnNumLockKeyCode = 0
        Me.KeyButton18.UnNumLockText = Nothing
        Me.KeyButton18.UseMnemonic = False
        Me.KeyButton18.UseVisualStyleBackColor = False
        '
        'KeyButton19
        '
        Me.KeyButton19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton19.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton19.FlatAppearance.BorderSize = 0
        Me.KeyButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton19.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton19.ForeColor = System.Drawing.Color.White
        Me.KeyButton19.IsPressed = False
        Me.KeyButton19.KeyCode = 66
        Me.KeyButton19.Location = New System.Drawing.Point(336, 135)
        Me.KeyButton19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton19.Name = "KeyButton19"
        Me.KeyButton19.NormalText = Nothing
        Me.KeyButton19.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton19.ShiftText = Nothing
        Me.KeyButton19.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton19.TabIndex = 26
        Me.KeyButton19.UnNumLockKeyCode = 0
        Me.KeyButton19.UnNumLockText = Nothing
        Me.KeyButton19.UseMnemonic = False
        Me.KeyButton19.UseVisualStyleBackColor = False
        '
        'KeyButton20
        '
        Me.KeyButton20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton20.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton20.FlatAppearance.BorderSize = 0
        Me.KeyButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton20.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton20.ForeColor = System.Drawing.Color.White
        Me.KeyButton20.IsPressed = False
        Me.KeyButton20.KeyCode = 71
        Me.KeyButton20.Location = New System.Drawing.Point(258, 75)
        Me.KeyButton20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton20.Name = "KeyButton20"
        Me.KeyButton20.NormalText = Nothing
        Me.KeyButton20.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton20.ShiftText = Nothing
        Me.KeyButton20.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton20.TabIndex = 25
        Me.KeyButton20.UnNumLockKeyCode = 0
        Me.KeyButton20.UnNumLockText = Nothing
        Me.KeyButton20.UseMnemonic = False
        Me.KeyButton20.UseVisualStyleBackColor = False
        '
        'KeyButton21
        '
        Me.KeyButton21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton21.FlatAppearance.BorderSize = 0
        Me.KeyButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton21.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton21.ForeColor = System.Drawing.Color.White
        Me.KeyButton21.IsPressed = False
        Me.KeyButton21.KeyCode = 84
        Me.KeyButton21.Location = New System.Drawing.Point(258, 15)
        Me.KeyButton21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton21.Name = "KeyButton21"
        Me.KeyButton21.NormalText = Nothing
        Me.KeyButton21.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton21.ShiftText = Nothing
        Me.KeyButton21.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton21.TabIndex = 35
        Me.KeyButton21.UnNumLockKeyCode = 0
        Me.KeyButton21.UnNumLockText = Nothing
        Me.KeyButton21.UseMnemonic = False
        Me.KeyButton21.UseVisualStyleBackColor = False
        '
        'KeyButton22
        '
        Me.KeyButton22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton22.FlatAppearance.BorderSize = 0
        Me.KeyButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton22.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton22.ForeColor = System.Drawing.Color.White
        Me.KeyButton22.IsPressed = False
        Me.KeyButton22.KeyCode = 86
        Me.KeyButton22.Location = New System.Drawing.Point(258, 135)
        Me.KeyButton22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton22.Name = "KeyButton22"
        Me.KeyButton22.NormalText = Nothing
        Me.KeyButton22.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton22.ShiftText = Nothing
        Me.KeyButton22.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton22.TabIndex = 10
        Me.KeyButton22.UnNumLockKeyCode = 0
        Me.KeyButton22.UnNumLockText = Nothing
        Me.KeyButton22.UseMnemonic = False
        Me.KeyButton22.UseVisualStyleBackColor = False
        '
        'KeyButton23
        '
        Me.KeyButton23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton23.FlatAppearance.BorderSize = 0
        Me.KeyButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton23.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton23.ForeColor = System.Drawing.Color.White
        Me.KeyButton23.IsPressed = False
        Me.KeyButton23.KeyCode = 70
        Me.KeyButton23.Location = New System.Drawing.Point(180, 75)
        Me.KeyButton23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton23.Name = "KeyButton23"
        Me.KeyButton23.NormalText = Nothing
        Me.KeyButton23.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton23.ShiftText = Nothing
        Me.KeyButton23.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton23.TabIndex = 22
        Me.KeyButton23.UnNumLockKeyCode = 0
        Me.KeyButton23.UnNumLockText = Nothing
        Me.KeyButton23.UseMnemonic = False
        Me.KeyButton23.UseVisualStyleBackColor = False
        '
        'KeyButton24
        '
        Me.KeyButton24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton24.FlatAppearance.BorderSize = 0
        Me.KeyButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton24.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton24.ForeColor = System.Drawing.Color.White
        Me.KeyButton24.IsPressed = False
        Me.KeyButton24.KeyCode = 82
        Me.KeyButton24.Location = New System.Drawing.Point(180, 15)
        Me.KeyButton24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton24.Name = "KeyButton24"
        Me.KeyButton24.NormalText = Nothing
        Me.KeyButton24.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton24.ShiftText = Nothing
        Me.KeyButton24.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton24.TabIndex = 21
        Me.KeyButton24.UnNumLockKeyCode = 0
        Me.KeyButton24.UnNumLockText = Nothing
        Me.KeyButton24.UseMnemonic = False
        Me.KeyButton24.UseVisualStyleBackColor = False
        '
        'KeyButton25
        '
        Me.KeyButton25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton25.FlatAppearance.BorderSize = 0
        Me.KeyButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton25.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton25.ForeColor = System.Drawing.Color.White
        Me.KeyButton25.IsPressed = False
        Me.KeyButton25.KeyCode = 32
        Me.KeyButton25.Location = New System.Drawing.Point(342, 27)
        Me.KeyButton25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton25.Name = "KeyButton25"
        Me.KeyButton25.NormalText = Nothing
        Me.KeyButton25.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton25.ShiftText = Nothing
        Me.KeyButton25.Size = New System.Drawing.Size(228, 55)
        Me.KeyButton25.TabIndex = 20
        Me.KeyButton25.Text = "Space"
        Me.KeyButton25.UnNumLockKeyCode = 0
        Me.KeyButton25.UnNumLockText = Nothing
        Me.KeyButton25.UseMnemonic = False
        Me.KeyButton25.UseVisualStyleBackColor = False
        '
        'KeyButton26
        '
        Me.KeyButton26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton26.FlatAppearance.BorderSize = 0
        Me.KeyButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton26.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton26.ForeColor = System.Drawing.Color.White
        Me.KeyButton26.IsPressed = False
        Me.KeyButton26.KeyCode = 67
        Me.KeyButton26.Location = New System.Drawing.Point(180, 135)
        Me.KeyButton26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton26.Name = "KeyButton26"
        Me.KeyButton26.NormalText = Nothing
        Me.KeyButton26.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton26.ShiftText = Nothing
        Me.KeyButton26.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton26.TabIndex = 19
        Me.KeyButton26.UnNumLockKeyCode = 0
        Me.KeyButton26.UnNumLockText = Nothing
        Me.KeyButton26.UseMnemonic = False
        Me.KeyButton26.UseVisualStyleBackColor = False
        '
        'KeyButton27
        '
        Me.KeyButton27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton27.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton27.FlatAppearance.BorderSize = 0
        Me.KeyButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton27.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton27.ForeColor = System.Drawing.Color.White
        Me.KeyButton27.IsPressed = False
        Me.KeyButton27.KeyCode = 68
        Me.KeyButton27.Location = New System.Drawing.Point(102, 75)
        Me.KeyButton27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton27.Name = "KeyButton27"
        Me.KeyButton27.NormalText = Nothing
        Me.KeyButton27.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton27.ShiftText = Nothing
        Me.KeyButton27.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton27.TabIndex = 18
        Me.KeyButton27.UnNumLockKeyCode = 0
        Me.KeyButton27.UnNumLockText = Nothing
        Me.KeyButton27.UseMnemonic = False
        Me.KeyButton27.UseVisualStyleBackColor = False
        '
        'KeyButton28
        '
        Me.KeyButton28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton28.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton28.FlatAppearance.BorderSize = 0
        Me.KeyButton28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton28.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton28.ForeColor = System.Drawing.Color.White
        Me.KeyButton28.IsPressed = False
        Me.KeyButton28.KeyCode = 69
        Me.KeyButton28.Location = New System.Drawing.Point(102, 15)
        Me.KeyButton28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton28.Name = "KeyButton28"
        Me.KeyButton28.NormalText = Nothing
        Me.KeyButton28.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton28.ShiftText = Nothing
        Me.KeyButton28.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton28.TabIndex = 17
        Me.KeyButton28.UnNumLockKeyCode = 0
        Me.KeyButton28.UnNumLockText = Nothing
        Me.KeyButton28.UseMnemonic = False
        Me.KeyButton28.UseVisualStyleBackColor = False
        '
        'KeyButton29
        '
        Me.KeyButton29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton29.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton29.FlatAppearance.BorderSize = 0
        Me.KeyButton29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton29.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton29.ForeColor = System.Drawing.Color.White
        Me.KeyButton29.IsPressed = False
        Me.KeyButton29.KeyCode = 88
        Me.KeyButton29.Location = New System.Drawing.Point(102, 135)
        Me.KeyButton29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton29.Name = "KeyButton29"
        Me.KeyButton29.NormalText = Nothing
        Me.KeyButton29.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton29.ShiftText = Nothing
        Me.KeyButton29.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton29.TabIndex = 16
        Me.KeyButton29.UnNumLockKeyCode = 0
        Me.KeyButton29.UnNumLockText = Nothing
        Me.KeyButton29.UseMnemonic = False
        Me.KeyButton29.UseVisualStyleBackColor = False
        '
        'KeyButton30
        '
        Me.KeyButton30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton30.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton30.FlatAppearance.BorderSize = 0
        Me.KeyButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton30.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton30.ForeColor = System.Drawing.Color.White
        Me.KeyButton30.IsPressed = False
        Me.KeyButton30.KeyCode = 83
        Me.KeyButton30.Location = New System.Drawing.Point(24, 75)
        Me.KeyButton30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton30.Name = "KeyButton30"
        Me.KeyButton30.NormalText = Nothing
        Me.KeyButton30.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton30.ShiftText = Nothing
        Me.KeyButton30.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton30.TabIndex = 15
        Me.KeyButton30.UnNumLockKeyCode = 0
        Me.KeyButton30.UnNumLockText = Nothing
        Me.KeyButton30.UseMnemonic = False
        Me.KeyButton30.UseVisualStyleBackColor = False
        '
        'KeyButton31
        '
        Me.KeyButton31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton31.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton31.FlatAppearance.BorderSize = 0
        Me.KeyButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton31.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton31.ForeColor = System.Drawing.Color.White
        Me.KeyButton31.IsPressed = False
        Me.KeyButton31.KeyCode = 87
        Me.KeyButton31.Location = New System.Drawing.Point(24, 15)
        Me.KeyButton31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton31.Name = "KeyButton31"
        Me.KeyButton31.NormalText = Nothing
        Me.KeyButton31.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton31.ShiftText = Nothing
        Me.KeyButton31.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton31.TabIndex = 14
        Me.KeyButton31.UnNumLockKeyCode = 0
        Me.KeyButton31.UnNumLockText = Nothing
        Me.KeyButton31.UseMnemonic = False
        Me.KeyButton31.UseVisualStyleBackColor = False
        '
        'KeyButton32
        '
        Me.KeyButton32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton32.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.KeyButton32.FlatAppearance.BorderSize = 0
        Me.KeyButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton32.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.KeyButton32.ForeColor = System.Drawing.Color.White
        Me.KeyButton32.IsPressed = False
        Me.KeyButton32.KeyCode = 90
        Me.KeyButton32.Location = New System.Drawing.Point(24, 135)
        Me.KeyButton32.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton32.Name = "KeyButton32"
        Me.KeyButton32.NormalText = Nothing
        Me.KeyButton32.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton32.ShiftText = Nothing
        Me.KeyButton32.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton32.TabIndex = 13
        Me.KeyButton32.UnNumLockKeyCode = 0
        Me.KeyButton32.UnNumLockText = Nothing
        Me.KeyButton32.UseMnemonic = False
        Me.KeyButton32.UseVisualStyleBackColor = False
        '
        'KeyButton35
        '
        Me.KeyButton35.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton35.FlatAppearance.BorderSize = 0
        Me.KeyButton35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton35.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.KeyButton35.ForeColor = System.Drawing.Color.White
        Me.KeyButton35.IsPressed = False
        Me.KeyButton35.KeyCode = 17
        Me.KeyButton35.Location = New System.Drawing.Point(244, 8)
        Me.KeyButton35.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton35.Name = "KeyButton35"
        Me.KeyButton35.NormalText = Nothing
        Me.KeyButton35.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton35.ShiftText = Nothing
        Me.KeyButton35.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton35.TabIndex = 23
        Me.KeyButton35.Text = "Ctrl"
        Me.KeyButton35.UnNumLockKeyCode = 0
        Me.KeyButton35.UnNumLockText = Nothing
        Me.KeyButton35.UseMnemonic = False
        Me.KeyButton35.UseVisualStyleBackColor = False
        '
        'KeyButton9
        '
        Me.KeyButton9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton9.FlatAppearance.BorderSize = 0
        Me.KeyButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton9.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyButton9.ForeColor = System.Drawing.Color.White
        Me.KeyButton9.IsPressed = False
        Me.KeyButton9.KeyCode = 39
        Me.KeyButton9.Location = New System.Drawing.Point(710, 424)
        Me.KeyButton9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton9.Name = "KeyButton9"
        Me.KeyButton9.NormalText = Nothing
        Me.KeyButton9.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton9.ShiftText = Nothing
        Me.KeyButton9.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton9.TabIndex = 39
        Me.KeyButton9.Text = "→"
        Me.KeyButton9.UnNumLockKeyCode = 0
        Me.KeyButton9.UnNumLockText = Nothing
        Me.KeyButton9.UseMnemonic = False
        Me.KeyButton9.UseVisualStyleBackColor = False
        '
        'KeyButton11
        '
        Me.KeyButton11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KeyButton11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.KeyButton11.FlatAppearance.BorderSize = 0
        Me.KeyButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyButton11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyButton11.ForeColor = System.Drawing.Color.White
        Me.KeyButton11.IsPressed = False
        Me.KeyButton11.KeyCode = 37
        Me.KeyButton11.Location = New System.Drawing.Point(632, 424)
        Me.KeyButton11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyButton11.Name = "KeyButton11"
        Me.KeyButton11.NormalText = Nothing
        Me.KeyButton11.Padding = New System.Windows.Forms.Padding(2)
        Me.KeyButton11.ShiftText = Nothing
        Me.KeyButton11.Size = New System.Drawing.Size(72, 55)
        Me.KeyButton11.TabIndex = 40
        Me.KeyButton11.Text = "←"
        Me.KeyButton11.UnNumLockKeyCode = 0
        Me.KeyButton11.UnNumLockText = Nothing
        Me.KeyButton11.UseMnemonic = False
        Me.KeyButton11.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlMain.Controls.Add(Me.KeyButton8)
        Me.pnlMain.Controls.Add(Me.keyButtonQ)
        Me.pnlMain.Controls.Add(Me.keyButtonLShift)
        Me.pnlMain.Controls.Add(Me.KeyButton9)
        Me.pnlMain.Controls.Add(Me.KeyButton7)
        Me.pnlMain.Controls.Add(Me.keyButtonA)
        Me.pnlMain.Controls.Add(Me.KeyButton11)
        Me.pnlMain.Controls.Add(Me.keyButtonZ)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad7)
        Me.pnlMain.Controls.Add(Me.keyButtonW)
        Me.pnlMain.Controls.Add(Me.KeyButton3)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad4)
        Me.pnlMain.Controls.Add(Me.keyButtonS)
        Me.pnlMain.Controls.Add(Me.keyButtonX)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad1)
        Me.pnlMain.Controls.Add(Me.keyButtonE)
        Me.pnlMain.Controls.Add(Me.keyButtonProcess)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad0)
        Me.pnlMain.Controls.Add(Me.keyButtonD)
        Me.pnlMain.Controls.Add(Me.keyButtonC)
        Me.pnlMain.Controls.Add(Me.keyButtonNumReturn)
        Me.pnlMain.Controls.Add(Me.keyButtonSpace)
        Me.pnlMain.Controls.Add(Me.keyButtonRight)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad8)
        Me.pnlMain.Controls.Add(Me.keyButtonR)
        Me.pnlMain.Controls.Add(Me.keyButtonRShift)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad5)
        Me.pnlMain.Controls.Add(Me.keyButtonF)
        Me.pnlMain.Controls.Add(Me.keyButtonReturn)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad2)
        Me.pnlMain.Controls.Add(Me.keyButtonV)
        Me.pnlMain.Controls.Add(Me.keyButtonT)
        Me.pnlMain.Controls.Add(Me.keyButtonDecimal)
        Me.pnlMain.Controls.Add(Me.keyButtonG)
        Me.pnlMain.Controls.Add(Me.keyButtonB)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad9)
        Me.pnlMain.Controls.Add(Me.keyButtonY)
        Me.pnlMain.Controls.Add(Me.keyButtonH)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad6)
        Me.pnlMain.Controls.Add(Me.keyButtonN)
        Me.pnlMain.Controls.Add(Me.keyButtonF6)
        Me.pnlMain.Controls.Add(Me.keyButtonNumberPad3)
        Me.pnlMain.Controls.Add(Me.keyButtonU)
        Me.pnlMain.Controls.Add(Me.keyButtonJ)
        Me.pnlMain.Controls.Add(Me.keyButtonBack)
        Me.pnlMain.Controls.Add(Me.keyButtonM)
        Me.pnlMain.Controls.Add(Me.keyButtonF7)
        Me.pnlMain.Controls.Add(Me.keyButtonI)
        Me.pnlMain.Controls.Add(Me.KeyButton1)
        Me.pnlMain.Controls.Add(Me.keyButtonK)
        Me.pnlMain.Controls.Add(Me.keyButtonLeft)
        Me.pnlMain.Controls.Add(Me.KeyButton2)
        Me.pnlMain.Controls.Add(Me.keyButtonComma)
        Me.pnlMain.Controls.Add(Me.keyButtonF8)
        Me.pnlMain.Controls.Add(Me.keyButtonMinus)
        Me.pnlMain.Controls.Add(Me.keyButtonO)
        Me.pnlMain.Controls.Add(Me.keyButtonL)
        Me.pnlMain.Controls.Add(Me.keyButtonPeriod)
        Me.pnlMain.Controls.Add(Me.keyButtonP)
        Me.pnlMain.Location = New System.Drawing.Point(145, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(947, 587)
        Me.pnlMain.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.keyButtonTab)
        Me.Panel1.Controls.Add(Me.keyButtonF11)
        Me.Panel1.Controls.Add(Me.keyButtonF12)
        Me.Panel1.Controls.Add(Me.keyButtonF9)
        Me.Panel1.Controls.Add(Me.keyButtonF10)
        Me.Panel1.Controls.Add(Me.keyButtonNumLock)
        Me.Panel1.Controls.Add(Me.keyButtonMultiply)
        Me.Panel1.Controls.Add(Me.KeyButton6)
        Me.Panel1.Controls.Add(Me.keyButtonSubtract)
        Me.Panel1.Controls.Add(Me.KeyButton5)
        Me.Panel1.Controls.Add(Me.keyButtonCapsLock)
        Me.Panel1.Controls.Add(Me.keyButtonUp)
        Me.Panel1.Controls.Add(Me.KeyButton35)
        Me.Panel1.Controls.Add(Me.keyButtonDown)
        Me.Panel1.Controls.Add(Me.keyButtonOpenBrackets)
        Me.Panel1.Controls.Add(Me.keyButtonOemPipe)
        Me.Panel1.Controls.Add(Me.keyButtonScrollLock)
        Me.Panel1.Controls.Add(Me.keyButtonD0)
        Me.Panel1.Controls.Add(Me.KeyButton14)
        Me.Panel1.Controls.Add(Me.keyButtonDelete)
        Me.Panel1.Controls.Add(Me.keyButtonEnd)
        Me.Panel1.Controls.Add(Me.keyButtonPrintScreen)
        Me.Panel1.Controls.Add(Me.keyButtonPlus)
        Me.Panel1.Controls.Add(Me.KeyButton15)
        Me.Panel1.Controls.Add(Me.keyButtonRControl)
        Me.Panel1.Controls.Add(Me.keyButtonCloseBrackets)
        Me.Panel1.Controls.Add(Me.keyButtonPageDown)
        Me.Panel1.Controls.Add(Me.keyButtonQuestion)
        Me.Panel1.Controls.Add(Me.KeyButton16)
        Me.Panel1.Controls.Add(Me.keyButtonPause)
        Me.Panel1.Controls.Add(Me.keyButtonSemicolon)
        Me.Panel1.Controls.Add(Me.keyButtonInsert)
        Me.Panel1.Controls.Add(Me.keyButtonD9)
        Me.Panel1.Controls.Add(Me.KeyButton17)
        Me.Panel1.Controls.Add(Me.keyButtonHome)
        Me.Panel1.Controls.Add(Me.keyButtonPageUp)
        Me.Panel1.Controls.Add(Me.keyButtonDivide)
        Me.Panel1.Controls.Add(Me.keyButtonApps)
        Me.Panel1.Controls.Add(Me.KeyButton18)
        Me.Panel1.Controls.Add(Me.keyButtonD8)
        Me.Panel1.Controls.Add(Me.keyButtonWin)
        Me.Panel1.Controls.Add(Me.keyButtonD7)
        Me.Panel1.Controls.Add(Me.keyButtonLAlt)
        Me.Panel1.Controls.Add(Me.KeyButton19)
        Me.Panel1.Controls.Add(Me.keyButtonD6)
        Me.Panel1.Controls.Add(Me.KeyButton25)
        Me.Panel1.Controls.Add(Me.keyButtonRAlt)
        Me.Panel1.Controls.Add(Me.keyButtonD5)
        Me.Panel1.Controls.Add(Me.keyButtonAdd)
        Me.Panel1.Controls.Add(Me.KeyButton20)
        Me.Panel1.Controls.Add(Me.keyButtonD4)
        Me.Panel1.Controls.Add(Me.keyButtonEscape)
        Me.Panel1.Controls.Add(Me.keyButtonD3)
        Me.Panel1.Controls.Add(Me.keyButtonF1)
        Me.Panel1.Controls.Add(Me.KeyButton21)
        Me.Panel1.Controls.Add(Me.keyButtonD2)
        Me.Panel1.Controls.Add(Me.keyButtonF2)
        Me.Panel1.Controls.Add(Me.keyButtonD1)
        Me.Panel1.Controls.Add(Me.keyButtonF3)
        Me.Panel1.Controls.Add(Me.KeyButton22)
        Me.Panel1.Controls.Add(Me.keyButtonTilde)
        Me.Panel1.Controls.Add(Me.keyButtonF4)
        Me.Panel1.Controls.Add(Me.keyButtonF5)
        Me.Panel1.Controls.Add(Me.keyButtonLControl)
        Me.Panel1.Controls.Add(Me.KeyButton23)
        Me.Panel1.Controls.Add(Me.KeyButton31)
        Me.Panel1.Controls.Add(Me.KeyButton30)
        Me.Panel1.Controls.Add(Me.KeyButton32)
        Me.Panel1.Controls.Add(Me.KeyButton29)
        Me.Panel1.Controls.Add(Me.KeyButton24)
        Me.Panel1.Controls.Add(Me.KeyButton28)
        Me.Panel1.Controls.Add(Me.KeyButton27)
        Me.Panel1.Controls.Add(Me.KeyButton26)
        Me.Panel1.Location = New System.Drawing.Point(140, 715)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 406)
        Me.Panel1.TabIndex = 43
        Me.Panel1.Visible = False
        '
        'frm4RowKeyboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1243, 771)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(938, 243)
        Me.Name = "frm4RowKeyboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.pnlMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub






#End Region

	Private keyButtonEscape As KeyButton
	Private keyButtonTilde As KeyButton
	Private keyButtonD1 As KeyButton
	Private keyButtonD2 As KeyButton
	Private keyButtonD3 As KeyButton
	Private keyButtonD4 As KeyButton
	Private keyButtonD5 As KeyButton
	Private keyButtonD6 As KeyButton
	Private keyButtonD7 As KeyButton
	Private keyButtonD8 As KeyButton
	Private keyButtonD9 As KeyButton
	Private keyButtonD0 As KeyButton
	Private keyButtonMinus As KeyButton
	Private keyButtonPlus As KeyButton
	Private keyButtonBack As KeyButton
	Private keyButtonTab As KeyButton
	Private keyButtonQ As KeyButton
	Private keyButtonW As KeyButton
	Private keyButtonE As KeyButton
	Private keyButtonR As KeyButton
	Private keyButtonT As KeyButton
	Private keyButtonY As KeyButton
	Private keyButtonU As KeyButton
	Private keyButtonI As KeyButton
	Private keyButtonO As KeyButton
	Private keyButtonP As KeyButton
	Private keyButtonCloseBrackets As KeyButton
	Private keyButtonOemPipe As KeyButton
	Private keyButtonDelete As KeyButton
	Private keyButtonOpenBrackets As KeyButton
	Private keyButtonCapsLock As KeyButton
	Private keyButtonA As KeyButton
	Private keyButtonS As KeyButton
	Private keyButtonD As KeyButton
	Private keyButtonF As KeyButton
	Private keyButtonG As KeyButton
	Private keyButtonH As KeyButton
	Private keyButtonJ As KeyButton
	Private keyButtonK As KeyButton
	Private keyButtonL As KeyButton
	Private keyButtonSemicolon As KeyButton
	Private keyButtonReturn As KeyButton
	Private keyButtonProcess As KeyButton
	Private keyButtonLShift As KeyButton
	Private keyButtonZ As KeyButton
	Private keyButtonX As KeyButton
	Private keyButtonC As KeyButton
	Private keyButtonV As KeyButton
	Private keyButtonB As KeyButton
	Private keyButtonN As KeyButton
	Private keyButtonM As KeyButton
	Private keyButtonComma As KeyButton
	Private keyButtonPeriod As KeyButton
	Private keyButtonQuestion As KeyButton
	Private keyButtonRShift As KeyButton
	Private keyButtonLControl As KeyButton
	Private keyButtonWin As KeyButton
	Private keyButtonLAlt As KeyButton
	Private keyButtonSpace As KeyButton
	Private keyButtonRAlt As KeyButton
	Private keyButtonApps As KeyButton
	Private keyButtonLeft As KeyButton
	Private keyButtonDown As KeyButton
	Private keyButtonRight As KeyButton
	Private keyButtonRControl As KeyButton
	Private keyButtonUp As KeyButton
	Private keyButtonHome As KeyButton
	Private keyButtonPageUp As KeyButton
	Private keyButtonEnd As KeyButton
	Private keyButtonPageDown As KeyButton
	Private keyButtonInsert As KeyButton
	Private keyButtonPause As KeyButton
	Private keyButtonPrintScreen As KeyButton
	Private keyButtonScrollLock As KeyButton
	Private keyButtonNumberPad7 As KeyButton
	Private keyButtonNumberPad8 As KeyButton
	Private keyButtonNumberPad9 As KeyButton
	Private keyButtonDivide As KeyButton
	Private keyButtonNumberPad4 As KeyButton
	Private keyButtonNumberPad5 As KeyButton
	Private keyButtonNumberPad6 As KeyButton
	Private keyButtonMultiply As KeyButton
	Private keyButtonNumberPad1 As KeyButton
	Private keyButtonNumberPad2 As KeyButton
	Private keyButtonNumberPad3 As KeyButton
	Private keyButtonSubtract As KeyButton
	Private keyButtonNumberPad0 As KeyButton
	Private keyButtonDecimal As KeyButton
	Private keyButtonAdd As KeyButton
	Private keyButtonNumReturn As KeyButton
	Private keyButtonNumLock As KeyButton
	Private keyButtonF1 As KeyButton
	Private keyButtonF2 As KeyButton
	Private keyButtonF3 As KeyButton
	Private keyButtonF4 As KeyButton
	Private keyButtonF5 As KeyButton
	Private keyButtonF6 As KeyButton
	Private keyButtonF7 As KeyButton
	Private keyButtonF8 As KeyButton
	Private keyButtonF9 As KeyButton
	Private keyButtonF10 As KeyButton
	Private keyButtonF11 As KeyButton
	Private keyButtonF12 As KeyButton
    Private WithEvents KeyButton1 As KeyButton
    Private WithEvents KeyButton2 As KeyButton
    Private WithEvents KeyButton3 As KeyButton
    Private WithEvents KeyButton5 As KeyButton
    Private WithEvents KeyButton6 As KeyButton
    Private WithEvents KeyButton7 As KeyButton
    Private WithEvents KeyButton8 As KeyButton
    Private WithEvents KeyButton14 As KeyButton
    Private WithEvents KeyButton15 As KeyButton
    Private WithEvents KeyButton16 As KeyButton
    Private WithEvents KeyButton17 As KeyButton
    Private WithEvents KeyButton18 As KeyButton
    Private WithEvents KeyButton19 As KeyButton
    Private WithEvents KeyButton20 As KeyButton
    Private WithEvents KeyButton21 As KeyButton
    Private WithEvents KeyButton22 As KeyButton
    Private WithEvents KeyButton23 As KeyButton
    Private WithEvents KeyButton24 As KeyButton
    Private WithEvents KeyButton25 As KeyButton
    Private WithEvents KeyButton26 As KeyButton
    Private WithEvents KeyButton27 As KeyButton
    Private WithEvents KeyButton28 As KeyButton
    Private WithEvents KeyButton29 As KeyButton
    Private WithEvents KeyButton30 As KeyButton
    Private WithEvents KeyButton31 As KeyButton
    Private WithEvents KeyButton32 As KeyButton
    Private WithEvents KeyButton35 As KeyButton
    Private WithEvents KeyButton9 As KeyButton
    Private WithEvents KeyButton11 As KeyButton
	Friend WithEvents pnlMain As System.Windows.Forms.Panel
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
