<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuTextBox2 = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaSwitch1 = New Guna.UI.WinForms.GunaSwitch()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Galyon-Bold", 36.0!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 106)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(131, 55)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Login"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
        Me.BunifuTextBox1.AnimationSpeed = 200
        Me.BunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox1.BackgroundImage = CType(resources.GetObject("BunifuTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox1.BorderColorActive = System.Drawing.Color.Yellow
        Me.BunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuTextBox1.BorderColorHover = System.Drawing.SystemColors.Control
        Me.BunifuTextBox1.BorderColorIdle = System.Drawing.Color.Yellow
        Me.BunifuTextBox1.BorderRadius = 25
        Me.BunifuTextBox1.BorderThickness = 1
        Me.BunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.BunifuTextBox1.DefaultText = ""
        Me.BunifuTextBox1.FillColor = System.Drawing.Color.Black
        Me.BunifuTextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuTextBox1.HideSelection = True
        Me.BunifuTextBox1.IconLeft = Nothing
        Me.BunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.IconPadding = 10
        Me.BunifuTextBox1.IconRight = Nothing
        Me.BunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.Lines = New String(-1) {}
        Me.BunifuTextBox1.Location = New System.Drawing.Point(103, 270)
        Me.BunifuTextBox1.MaxLength = 32767
        Me.BunifuTextBox1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.BunifuTextBox1.Modified = False
        Me.BunifuTextBox1.Multiline = False
        Me.BunifuTextBox1.Name = "BunifuTextBox1"
        StateProperties1.BorderColor = System.Drawing.Color.Yellow
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.BunifuTextBox1.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.SystemColors.Control
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Yellow
        StateProperties4.FillColor = System.Drawing.Color.Black
        StateProperties4.ForeColor = System.Drawing.SystemColors.Control
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnIdleState = StateProperties4
        Me.BunifuTextBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.White
        Me.BunifuTextBox1.PlaceholderText = "Enter Username"
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(260, 37)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox1.TabIndex = 1
        Me.BunifuTextBox1.TabStop = False
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginBottom = 0
        Me.BunifuTextBox1.TextMarginLeft = 3
        Me.BunifuTextBox1.TextMarginTop = 0
        Me.BunifuTextBox1.TextPlaceholder = "Enter Username"
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        Me.BunifuTextBox1.WordWrap = True
        '
        'BunifuTextBox2
        '
        Me.BunifuTextBox2.AcceptsReturn = False
        Me.BunifuTextBox2.AcceptsTab = False
        Me.BunifuTextBox2.AnimationSpeed = 200
        Me.BunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox2.BackgroundImage = CType(resources.GetObject("BunifuTextBox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox2.BorderColorActive = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuTextBox2.BorderColorHover = System.Drawing.Color.White
        Me.BunifuTextBox2.BorderColorIdle = System.Drawing.Color.Yellow
        Me.BunifuTextBox2.BorderRadius = 25
        Me.BunifuTextBox2.BorderThickness = 1
        Me.BunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox2.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.BunifuTextBox2.DefaultText = ""
        Me.BunifuTextBox2.FillColor = System.Drawing.Color.Black
        Me.BunifuTextBox2.ForeColor = System.Drawing.Color.White
        Me.BunifuTextBox2.HideSelection = True
        Me.BunifuTextBox2.IconLeft = Nothing
        Me.BunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox2.IconPadding = 10
        Me.BunifuTextBox2.IconRight = Nothing
        Me.BunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox2.Lines = New String(-1) {}
        Me.BunifuTextBox2.Location = New System.Drawing.Point(103, 337)
        Me.BunifuTextBox2.MaxLength = 32767
        Me.BunifuTextBox2.MinimumSize = New System.Drawing.Size(1, 1)
        Me.BunifuTextBox2.Modified = False
        Me.BunifuTextBox2.Multiline = False
        Me.BunifuTextBox2.Name = "BunifuTextBox2"
        StateProperties5.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox2.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.BunifuTextBox2.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.White
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox2.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Yellow
        StateProperties8.FillColor = System.Drawing.Color.Black
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox2.OnIdleState = StateProperties8
        Me.BunifuTextBox2.Padding = New System.Windows.Forms.Padding(3)
        Me.BunifuTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox2.PlaceholderForeColor = System.Drawing.Color.White
        Me.BunifuTextBox2.PlaceholderText = "Enter Password"
        Me.BunifuTextBox2.ReadOnly = False
        Me.BunifuTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BunifuTextBox2.SelectedText = ""
        Me.BunifuTextBox2.SelectionLength = 0
        Me.BunifuTextBox2.SelectionStart = 0
        Me.BunifuTextBox2.ShortcutsEnabled = True
        Me.BunifuTextBox2.Size = New System.Drawing.Size(260, 37)
        Me.BunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox2.TabIndex = 2
        Me.BunifuTextBox2.TabStop = False
        Me.BunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox2.TextMarginBottom = 0
        Me.BunifuTextBox2.TextMarginLeft = 3
        Me.BunifuTextBox2.TextMarginTop = 0
        Me.BunifuTextBox2.TextPlaceholder = "Enter Password"
        Me.BunifuTextBox2.UseSystemPasswordChar = False
        Me.BunifuTextBox2.WordWrap = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Login"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 40
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(157, 388)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 40
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.BorderRadius = 40
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.OnIdleState.BorderRadius = 40
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.BorderRadius = 40
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(150, 39)
        Me.BunifuButton1.TabIndex = 3
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1004, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 4
        '
        'GunaSwitch1
        '
        Me.GunaSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaSwitch1.CheckedOffColor = System.Drawing.Color.DimGray
        Me.GunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaSwitch1.Location = New System.Drawing.Point(327, 345)
        Me.GunaSwitch1.Name = "GunaSwitch1"
        Me.GunaSwitch1.Size = New System.Drawing.Size(28, 20)
        Me.GunaSwitch1.TabIndex = 5
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(70, 70)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(12, 12)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(51, 47)
        Me.GunaCircleButton1.TabIndex = 7
        '
        'LOGIN
        '
        Me.AcceptButton = Me.BunifuButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1049, 632)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.GunaSwitch1)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.BunifuTextBox2)
        Me.Controls.Add(Me.BunifuTextBox1)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuTextBox2 As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaSwitch1 As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
