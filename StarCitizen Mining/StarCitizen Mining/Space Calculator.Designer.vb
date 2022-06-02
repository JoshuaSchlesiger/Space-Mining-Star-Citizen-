<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Space_Calculator
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Space_Calculator))
        Me.lblcSCU = New System.Windows.Forms.Label()
        Me.lblMineral = New System.Windows.Forms.Label()
        Me.lblTrash = New System.Windows.Forms.Label()
        Me.lblRawProfit = New System.Windows.Forms.Label()
        Me.lblRefinedProfit = New System.Windows.Forms.Label()
        Me.lblValueStone = New System.Windows.Forms.Label()
        Me.lblValueMineral = New System.Windows.Forms.Label()
        Me.lblValueTrash = New System.Windows.Forms.Label()
        Me.lblValueRaw = New System.Windows.Forms.Label()
        Me.lblValueRefined = New System.Windows.Forms.Label()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnPriceList = New System.Windows.Forms.Button()
        Me.btnQuotes = New System.Windows.Forms.Button()
        Me.lblMass = New System.Windows.Forms.Label()
        Me.tbMass = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPriceRaw = New System.Windows.Forms.Label()
        Me.lblPriceRefined = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.cbType1 = New System.Windows.Forms.ComboBox()
        Me.tbPriceRaw1 = New System.Windows.Forms.TextBox()
        Me.tbPriceRefined1 = New System.Windows.Forms.TextBox()
        Me.tbPercentage1 = New System.Windows.Forms.TextBox()
        Me.tbQuantity1 = New System.Windows.Forms.TextBox()
        Me.tbQuantity2 = New System.Windows.Forms.TextBox()
        Me.tbPercentage2 = New System.Windows.Forms.TextBox()
        Me.tbPriceRefined2 = New System.Windows.Forms.TextBox()
        Me.tbPriceRaw2 = New System.Windows.Forms.TextBox()
        Me.cbType2 = New System.Windows.Forms.ComboBox()
        Me.tbQuantity3 = New System.Windows.Forms.TextBox()
        Me.tbPercentage3 = New System.Windows.Forms.TextBox()
        Me.tbPriceRefined3 = New System.Windows.Forms.TextBox()
        Me.tbPriceRaw3 = New System.Windows.Forms.TextBox()
        Me.cbType3 = New System.Windows.Forms.ComboBox()
        Me.lblValueStone2 = New System.Windows.Forms.Label()
        Me.lblValueMineral2 = New System.Windows.Forms.Label()
        Me.lblValueTrash2 = New System.Windows.Forms.Label()
        Me.pbRefinedProfit = New System.Windows.Forms.PictureBox()
        Me.pbRawProfit = New System.Windows.Forms.PictureBox()
        Me.pbTrash = New System.Windows.Forms.PictureBox()
        Me.pbMineral = New System.Windows.Forms.PictureBox()
        Me.pbStonecSCU = New System.Windows.Forms.PictureBox()
        CType(Me.pbRefinedProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRawProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMineral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStonecSCU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcSCU
        '
        Me.lblcSCU.AutoSize = True
        Me.lblcSCU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcSCU.Location = New System.Drawing.Point(65, 345)
        Me.lblcSCU.Name = "lblcSCU"
        Me.lblcSCU.Size = New System.Drawing.Size(80, 19)
        Me.lblcSCU.TabIndex = 0
        Me.lblcSCU.Text = "Stone cSCU"
        '
        'lblMineral
        '
        Me.lblMineral.AutoSize = True
        Me.lblMineral.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMineral.Location = New System.Drawing.Point(218, 345)
        Me.lblMineral.Name = "lblMineral"
        Me.lblMineral.Size = New System.Drawing.Size(104, 19)
        Me.lblMineral.TabIndex = 2
        Me.lblMineral.Text = "Mineralic cSCU"
        '
        'lblTrash
        '
        Me.lblTrash.AutoSize = True
        Me.lblTrash.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrash.Location = New System.Drawing.Point(380, 345)
        Me.lblTrash.Name = "lblTrash"
        Me.lblTrash.Size = New System.Drawing.Size(80, 19)
        Me.lblTrash.TabIndex = 4
        Me.lblTrash.Text = "Trash cSCU"
        '
        'lblRawProfit
        '
        Me.lblRawProfit.AutoSize = True
        Me.lblRawProfit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawProfit.Location = New System.Drawing.Point(535, 345)
        Me.lblRawProfit.Name = "lblRawProfit"
        Me.lblRawProfit.Size = New System.Drawing.Size(76, 19)
        Me.lblRawProfit.TabIndex = 6
        Me.lblRawProfit.Text = "Raw profit"
        '
        'lblRefinedProfit
        '
        Me.lblRefinedProfit.AutoSize = True
        Me.lblRefinedProfit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefinedProfit.Location = New System.Drawing.Point(678, 345)
        Me.lblRefinedProfit.Name = "lblRefinedProfit"
        Me.lblRefinedProfit.Size = New System.Drawing.Size(96, 19)
        Me.lblRefinedProfit.TabIndex = 8
        Me.lblRefinedProfit.Text = "Refined profit"
        '
        'lblValueStone
        '
        Me.lblValueStone.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueStone.Location = New System.Drawing.Point(29, 384)
        Me.lblValueStone.Name = "lblValueStone"
        Me.lblValueStone.Size = New System.Drawing.Size(116, 37)
        Me.lblValueStone.TabIndex = 10
        Me.lblValueStone.Text = "Value"
        Me.lblValueStone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueMineral
        '
        Me.lblValueMineral.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueMineral.Location = New System.Drawing.Point(194, 384)
        Me.lblValueMineral.Name = "lblValueMineral"
        Me.lblValueMineral.Size = New System.Drawing.Size(116, 37)
        Me.lblValueMineral.TabIndex = 11
        Me.lblValueMineral.Text = "Value"
        Me.lblValueMineral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueTrash
        '
        Me.lblValueTrash.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueTrash.Location = New System.Drawing.Point(349, 384)
        Me.lblValueTrash.Name = "lblValueTrash"
        Me.lblValueTrash.Size = New System.Drawing.Size(116, 37)
        Me.lblValueTrash.TabIndex = 12
        Me.lblValueTrash.Text = "Value"
        Me.lblValueTrash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueRaw
        '
        Me.lblValueRaw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueRaw.Location = New System.Drawing.Point(494, 390)
        Me.lblValueRaw.Name = "lblValueRaw"
        Me.lblValueRaw.Size = New System.Drawing.Size(138, 57)
        Me.lblValueRaw.TabIndex = 13
        Me.lblValueRaw.Text = "Value"
        Me.lblValueRaw.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblValueRefined
        '
        Me.lblValueRefined.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueRefined.Location = New System.Drawing.Point(648, 390)
        Me.lblValueRefined.Name = "lblValueRefined"
        Me.lblValueRefined.Size = New System.Drawing.Size(139, 57)
        Me.lblValueRefined.TabIndex = 14
        Me.lblValueRefined.Text = "Value"
        Me.lblValueRefined.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCalculator
        '
        Me.btnCalculator.Enabled = False
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.ForeColor = System.Drawing.Color.Black
        Me.btnCalculator.Location = New System.Drawing.Point(33, 12)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(128, 33)
        Me.btnCalculator.TabIndex = 15
        Me.btnCalculator.TabStop = False
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobs.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobs.ForeColor = System.Drawing.Color.Black
        Me.btnJobs.Location = New System.Drawing.Point(188, 12)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(128, 33)
        Me.btnJobs.TabIndex = 16
        Me.btnJobs.TabStop = False
        Me.btnJobs.Text = "Jobs"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(344, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(128, 33)
        Me.btnMainMenu.TabIndex = 17
        Me.btnMainMenu.TabStop = False
        Me.btnMainMenu.Text = "Main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnPriceList
        '
        Me.btnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPriceList.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriceList.ForeColor = System.Drawing.Color.Black
        Me.btnPriceList.Location = New System.Drawing.Point(493, 12)
        Me.btnPriceList.Name = "btnPriceList"
        Me.btnPriceList.Size = New System.Drawing.Size(128, 33)
        Me.btnPriceList.TabIndex = 18
        Me.btnPriceList.TabStop = False
        Me.btnPriceList.Text = "Price list"
        Me.btnPriceList.UseVisualStyleBackColor = True
        '
        'btnQuotes
        '
        Me.btnQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotes.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuotes.ForeColor = System.Drawing.Color.Black
        Me.btnQuotes.Location = New System.Drawing.Point(646, 12)
        Me.btnQuotes.Name = "btnQuotes"
        Me.btnQuotes.Size = New System.Drawing.Size(128, 33)
        Me.btnQuotes.TabIndex = 19
        Me.btnQuotes.TabStop = False
        Me.btnQuotes.Text = "Quotes"
        Me.btnQuotes.UseVisualStyleBackColor = True
        '
        'lblMass
        '
        Me.lblMass.AutoSize = True
        Me.lblMass.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMass.Location = New System.Drawing.Point(34, 69)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.Size = New System.Drawing.Size(122, 24)
        Me.lblMass.TabIndex = 20
        Me.lblMass.Text = "Mass of stone:"
        '
        'tbMass
        '
        Me.tbMass.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMass.ForeColor = System.Drawing.Color.White
        Me.tbMass.Location = New System.Drawing.Point(188, 70)
        Me.tbMass.MaxLength = 4
        Me.tbMass.Multiline = True
        Me.tbMass.Name = "tbMass"
        Me.tbMass.Size = New System.Drawing.Size(128, 24)
        Me.tbMass.TabIndex = 21
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(34, 111)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(62, 19)
        Me.lblType.TabIndex = 22
        Me.lblType.Text = "Ore type"
        '
        'lblPriceRaw
        '
        Me.lblPriceRaw.AutoSize = True
        Me.lblPriceRaw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceRaw.Location = New System.Drawing.Point(506, 111)
        Me.lblPriceRaw.Name = "lblPriceRaw"
        Me.lblPriceRaw.Size = New System.Drawing.Size(83, 19)
        Me.lblPriceRaw.TabIndex = 23
        Me.lblPriceRaw.Text = "Price (Raw)"
        '
        'lblPriceRefined
        '
        Me.lblPriceRefined.AutoSize = True
        Me.lblPriceRefined.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceRefined.Location = New System.Drawing.Point(659, 111)
        Me.lblPriceRefined.Name = "lblPriceRefined"
        Me.lblPriceRefined.Size = New System.Drawing.Size(103, 19)
        Me.lblPriceRefined.TabIndex = 24
        Me.lblPriceRefined.Text = "Price (Refined)"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(207, 111)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(103, 19)
        Me.lblPercentage.TabIndex = 25
        Me.lblPercentage.Text = "Percentage (%)"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(350, 111)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(102, 19)
        Me.lblQuantity.TabIndex = 26
        Me.lblQuantity.Text = "Quantity (SCU)"
        '
        'cbType1
        '
        Me.cbType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbType1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType1.ForeColor = System.Drawing.Color.White
        Me.cbType1.FormattingEnabled = True
        Me.cbType1.Items.AddRange(New Object() {"Quantanium", "Bexalite", "Taranite", "Borase", "Laranite", "Agricium", "Hephaestanite", "Titanium", "Diamond", "Gold"})
        Me.cbType1.Location = New System.Drawing.Point(38, 133)
        Me.cbType1.Name = "cbType1"
        Me.cbType1.Size = New System.Drawing.Size(123, 27)
        Me.cbType1.TabIndex = 28
        '
        'tbPriceRaw1
        '
        Me.tbPriceRaw1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRaw1.ForeColor = System.Drawing.Color.White
        Me.tbPriceRaw1.Location = New System.Drawing.Point(510, 133)
        Me.tbPriceRaw1.Name = "tbPriceRaw1"
        Me.tbPriceRaw1.ReadOnly = True
        Me.tbPriceRaw1.Size = New System.Drawing.Size(100, 28)
        Me.tbPriceRaw1.TabIndex = 29
        Me.tbPriceRaw1.TabStop = False
        Me.tbPriceRaw1.Text = "0"
        '
        'tbPriceRefined1
        '
        Me.tbPriceRefined1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRefined1.ForeColor = System.Drawing.Color.White
        Me.tbPriceRefined1.Location = New System.Drawing.Point(662, 133)
        Me.tbPriceRefined1.Name = "tbPriceRefined1"
        Me.tbPriceRefined1.ReadOnly = True
        Me.tbPriceRefined1.Size = New System.Drawing.Size(100, 28)
        Me.tbPriceRefined1.TabIndex = 30
        Me.tbPriceRefined1.TabStop = False
        Me.tbPriceRefined1.Text = "0"
        '
        'tbPercentage1
        '
        Me.tbPercentage1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPercentage1.ForeColor = System.Drawing.Color.White
        Me.tbPercentage1.Location = New System.Drawing.Point(211, 133)
        Me.tbPercentage1.MaxLength = 4
        Me.tbPercentage1.Name = "tbPercentage1"
        Me.tbPercentage1.Size = New System.Drawing.Size(100, 28)
        Me.tbPercentage1.TabIndex = 31
        Me.tbPercentage1.Text = "0"
        '
        'tbQuantity1
        '
        Me.tbQuantity1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuantity1.ForeColor = System.Drawing.Color.White
        Me.tbQuantity1.Location = New System.Drawing.Point(354, 133)
        Me.tbQuantity1.Name = "tbQuantity1"
        Me.tbQuantity1.ReadOnly = True
        Me.tbQuantity1.Size = New System.Drawing.Size(100, 28)
        Me.tbQuantity1.TabIndex = 32
        Me.tbQuantity1.TabStop = False
        Me.tbQuantity1.Text = "0"
        '
        'tbQuantity2
        '
        Me.tbQuantity2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuantity2.ForeColor = System.Drawing.Color.White
        Me.tbQuantity2.Location = New System.Drawing.Point(354, 192)
        Me.tbQuantity2.Name = "tbQuantity2"
        Me.tbQuantity2.ReadOnly = True
        Me.tbQuantity2.Size = New System.Drawing.Size(100, 28)
        Me.tbQuantity2.TabIndex = 37
        Me.tbQuantity2.TabStop = False
        Me.tbQuantity2.Text = "0"
        '
        'tbPercentage2
        '
        Me.tbPercentage2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPercentage2.ForeColor = System.Drawing.Color.White
        Me.tbPercentage2.Location = New System.Drawing.Point(211, 192)
        Me.tbPercentage2.MaxLength = 4
        Me.tbPercentage2.Name = "tbPercentage2"
        Me.tbPercentage2.Size = New System.Drawing.Size(100, 28)
        Me.tbPercentage2.TabIndex = 36
        Me.tbPercentage2.Text = "0"
        '
        'tbPriceRefined2
        '
        Me.tbPriceRefined2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRefined2.ForeColor = System.Drawing.Color.White
        Me.tbPriceRefined2.Location = New System.Drawing.Point(662, 192)
        Me.tbPriceRefined2.Name = "tbPriceRefined2"
        Me.tbPriceRefined2.ReadOnly = True
        Me.tbPriceRefined2.Size = New System.Drawing.Size(100, 28)
        Me.tbPriceRefined2.TabIndex = 35
        Me.tbPriceRefined2.TabStop = False
        Me.tbPriceRefined2.Text = "0"
        '
        'tbPriceRaw2
        '
        Me.tbPriceRaw2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRaw2.ForeColor = System.Drawing.Color.White
        Me.tbPriceRaw2.Location = New System.Drawing.Point(510, 192)
        Me.tbPriceRaw2.Name = "tbPriceRaw2"
        Me.tbPriceRaw2.ReadOnly = True
        Me.tbPriceRaw2.Size = New System.Drawing.Size(100, 28)
        Me.tbPriceRaw2.TabIndex = 34
        Me.tbPriceRaw2.TabStop = False
        Me.tbPriceRaw2.Text = "0"
        '
        'cbType2
        '
        Me.cbType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbType2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType2.ForeColor = System.Drawing.Color.White
        Me.cbType2.FormattingEnabled = True
        Me.cbType2.Items.AddRange(New Object() {"Quantanium", "Bexalite", "Taranite", "Borase", "Laranite", "Agricium", "Hephaestanite", "Titanium", "Diamond", "Gold"})
        Me.cbType2.Location = New System.Drawing.Point(38, 192)
        Me.cbType2.Name = "cbType2"
        Me.cbType2.Size = New System.Drawing.Size(123, 27)
        Me.cbType2.TabIndex = 33
        '
        'tbQuantity3
        '
        Me.tbQuantity3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuantity3.ForeColor = System.Drawing.Color.White
        Me.tbQuantity3.Location = New System.Drawing.Point(354, 254)
        Me.tbQuantity3.Name = "tbQuantity3"
        Me.tbQuantity3.ReadOnly = True
        Me.tbQuantity3.Size = New System.Drawing.Size(100, 28)
        Me.tbQuantity3.TabIndex = 42
        Me.tbQuantity3.TabStop = False
        Me.tbQuantity3.Text = "0"
        '
        'tbPercentage3
        '
        Me.tbPercentage3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPercentage3.ForeColor = System.Drawing.Color.White
        Me.tbPercentage3.Location = New System.Drawing.Point(211, 254)
        Me.tbPercentage3.MaxLength = 4
        Me.tbPercentage3.Name = "tbPercentage3"
        Me.tbPercentage3.Size = New System.Drawing.Size(100, 28)
        Me.tbPercentage3.TabIndex = 41
        Me.tbPercentage3.Text = "0"
        '
        'tbPriceRefined3
        '
        Me.tbPriceRefined3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRefined3.ForeColor = System.Drawing.Color.White
        Me.tbPriceRefined3.Location = New System.Drawing.Point(662, 254)
        Me.tbPriceRefined3.Name = "tbPriceRefined3"
        Me.tbPriceRefined3.ReadOnly = True
        Me.tbPriceRefined3.Size = New System.Drawing.Size(100, 28)
        Me.tbPriceRefined3.TabIndex = 40
        Me.tbPriceRefined3.TabStop = False
        Me.tbPriceRefined3.Text = "0"
        '
        'tbPriceRaw3
        '
        Me.tbPriceRaw3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRaw3.ForeColor = System.Drawing.Color.White
        Me.tbPriceRaw3.Location = New System.Drawing.Point(510, 254)
        Me.tbPriceRaw3.Name = "tbPriceRaw3"
        Me.tbPriceRaw3.ReadOnly = True
        Me.tbPriceRaw3.Size = New System.Drawing.Size(100, 28)
        Me.tbPriceRaw3.TabIndex = 39
        Me.tbPriceRaw3.TabStop = False
        Me.tbPriceRaw3.Text = "0"
        '
        'cbType3
        '
        Me.cbType3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbType3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType3.ForeColor = System.Drawing.Color.White
        Me.cbType3.FormattingEnabled = True
        Me.cbType3.Items.AddRange(New Object() {"Quantanium", "Bexalite", "Taranite", "Borase", "Laranite", "Agricium", "Hephaestanite", "Titanium", "Diamond", "Gold"})
        Me.cbType3.Location = New System.Drawing.Point(38, 254)
        Me.cbType3.Name = "cbType3"
        Me.cbType3.Size = New System.Drawing.Size(123, 27)
        Me.cbType3.TabIndex = 38
        '
        'lblValueStone2
        '
        Me.lblValueStone2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueStone2.Location = New System.Drawing.Point(29, 421)
        Me.lblValueStone2.Name = "lblValueStone2"
        Me.lblValueStone2.Size = New System.Drawing.Size(116, 20)
        Me.lblValueStone2.TabIndex = 43
        Me.lblValueStone2.Text = "Value"
        Me.lblValueStone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueMineral2
        '
        Me.lblValueMineral2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueMineral2.Location = New System.Drawing.Point(195, 421)
        Me.lblValueMineral2.Name = "lblValueMineral2"
        Me.lblValueMineral2.Size = New System.Drawing.Size(116, 20)
        Me.lblValueMineral2.TabIndex = 44
        Me.lblValueMineral2.Text = "Value"
        Me.lblValueMineral2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueTrash2
        '
        Me.lblValueTrash2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueTrash2.Location = New System.Drawing.Point(350, 421)
        Me.lblValueTrash2.Name = "lblValueTrash2"
        Me.lblValueTrash2.Size = New System.Drawing.Size(116, 20)
        Me.lblValueTrash2.TabIndex = 45
        Me.lblValueTrash2.Text = "Value"
        Me.lblValueTrash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbRefinedProfit
        '
        Me.pbRefinedProfit.Image = Global.StarCitizen_Mining.My.Resources.Resources.check_mark__1_
        Me.pbRefinedProfit.Location = New System.Drawing.Point(642, 339)
        Me.pbRefinedProfit.Name = "pbRefinedProfit"
        Me.pbRefinedProfit.Size = New System.Drawing.Size(30, 30)
        Me.pbRefinedProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefinedProfit.TabIndex = 9
        Me.pbRefinedProfit.TabStop = False
        '
        'pbRawProfit
        '
        Me.pbRawProfit.Image = Global.StarCitizen_Mining.My.Resources.Resources.check_mark
        Me.pbRawProfit.Location = New System.Drawing.Point(499, 339)
        Me.pbRawProfit.Name = "pbRawProfit"
        Me.pbRawProfit.Size = New System.Drawing.Size(30, 30)
        Me.pbRawProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRawProfit.TabIndex = 7
        Me.pbRawProfit.TabStop = False
        '
        'pbTrash
        '
        Me.pbTrash.Image = Global.StarCitizen_Mining.My.Resources.Resources.dustbin
        Me.pbTrash.Location = New System.Drawing.Point(344, 339)
        Me.pbTrash.Name = "pbTrash"
        Me.pbTrash.Size = New System.Drawing.Size(30, 30)
        Me.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTrash.TabIndex = 5
        Me.pbTrash.TabStop = False
        '
        'pbMineral
        '
        Me.pbMineral.Image = Global.StarCitizen_Mining.My.Resources.Resources.diamond
        Me.pbMineral.Location = New System.Drawing.Point(182, 339)
        Me.pbMineral.Name = "pbMineral"
        Me.pbMineral.Size = New System.Drawing.Size(30, 30)
        Me.pbMineral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMineral.TabIndex = 3
        Me.pbMineral.TabStop = False
        '
        'pbStonecSCU
        '
        Me.pbStonecSCU.Image = Global.StarCitizen_Mining.My.Resources.Resources.stone__1_
        Me.pbStonecSCU.Location = New System.Drawing.Point(29, 339)
        Me.pbStonecSCU.Name = "pbStonecSCU"
        Me.pbStonecSCU.Size = New System.Drawing.Size(30, 30)
        Me.pbStonecSCU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStonecSCU.TabIndex = 1
        Me.pbStonecSCU.TabStop = False
        '
        'Space_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(799, 450)
        Me.Controls.Add(Me.lblValueTrash2)
        Me.Controls.Add(Me.lblValueMineral2)
        Me.Controls.Add(Me.lblValueStone2)
        Me.Controls.Add(Me.tbQuantity3)
        Me.Controls.Add(Me.tbPercentage3)
        Me.Controls.Add(Me.tbPriceRefined3)
        Me.Controls.Add(Me.tbPriceRaw3)
        Me.Controls.Add(Me.cbType3)
        Me.Controls.Add(Me.tbQuantity2)
        Me.Controls.Add(Me.tbPercentage2)
        Me.Controls.Add(Me.tbPriceRefined2)
        Me.Controls.Add(Me.tbPriceRaw2)
        Me.Controls.Add(Me.cbType2)
        Me.Controls.Add(Me.tbQuantity1)
        Me.Controls.Add(Me.tbPercentage1)
        Me.Controls.Add(Me.tbPriceRefined1)
        Me.Controls.Add(Me.tbPriceRaw1)
        Me.Controls.Add(Me.cbType1)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblPriceRefined)
        Me.Controls.Add(Me.lblPriceRaw)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.tbMass)
        Me.Controls.Add(Me.lblMass)
        Me.Controls.Add(Me.btnQuotes)
        Me.Controls.Add(Me.btnPriceList)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnJobs)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.lblValueRefined)
        Me.Controls.Add(Me.lblValueRaw)
        Me.Controls.Add(Me.lblValueTrash)
        Me.Controls.Add(Me.lblValueMineral)
        Me.Controls.Add(Me.lblValueStone)
        Me.Controls.Add(Me.pbRefinedProfit)
        Me.Controls.Add(Me.lblRefinedProfit)
        Me.Controls.Add(Me.pbRawProfit)
        Me.Controls.Add(Me.lblRawProfit)
        Me.Controls.Add(Me.pbTrash)
        Me.Controls.Add(Me.lblTrash)
        Me.Controls.Add(Me.pbMineral)
        Me.Controls.Add(Me.lblMineral)
        Me.Controls.Add(Me.pbStonecSCU)
        Me.Controls.Add(Me.lblcSCU)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Space_Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpaceCalculator"
        CType(Me.pbRefinedProfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRawProfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTrash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMineral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStonecSCU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcSCU As Label
    Friend WithEvents pbStonecSCU As PictureBox
    Friend WithEvents pbMineral As PictureBox
    Friend WithEvents lblMineral As Label
    Friend WithEvents pbTrash As PictureBox
    Friend WithEvents lblTrash As Label
    Friend WithEvents pbRawProfit As PictureBox
    Friend WithEvents lblRawProfit As Label
    Friend WithEvents pbRefinedProfit As PictureBox
    Friend WithEvents lblRefinedProfit As Label
    Friend WithEvents lblValueStone As Label
    Friend WithEvents lblValueMineral As Label
    Friend WithEvents lblValueTrash As Label
    Friend WithEvents lblValueRaw As Label
    Friend WithEvents lblValueRefined As Label
    Friend WithEvents btnCalculator As Button
    Friend WithEvents btnJobs As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnPriceList As Button
    Friend WithEvents btnQuotes As Button
    Friend WithEvents lblMass As Label
    Friend WithEvents tbMass As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblPriceRaw As Label
    Friend WithEvents lblPriceRefined As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents cbType1 As ComboBox
    Friend WithEvents tbPriceRaw1 As TextBox
    Friend WithEvents tbPriceRefined1 As TextBox
    Friend WithEvents tbPercentage1 As TextBox
    Friend WithEvents tbQuantity1 As TextBox
    Friend WithEvents tbQuantity2 As TextBox
    Friend WithEvents tbPercentage2 As TextBox
    Friend WithEvents tbPriceRefined2 As TextBox
    Friend WithEvents tbPriceRaw2 As TextBox
    Friend WithEvents cbType2 As ComboBox
    Friend WithEvents tbQuantity3 As TextBox
    Friend WithEvents tbPercentage3 As TextBox
    Friend WithEvents tbPriceRefined3 As TextBox
    Friend WithEvents tbPriceRaw3 As TextBox
    Friend WithEvents cbType3 As ComboBox
    Friend WithEvents lblValueStone2 As Label
    Friend WithEvents lblValueMineral2 As Label
    Friend WithEvents lblValueTrash2 As Label
End Class
