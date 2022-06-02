<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceList
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PriceList))
        Me.btnQuotes = New System.Windows.Forms.Button()
        Me.btnPriceList = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.lblOre = New System.Windows.Forms.Label()
        Me.lblPriceRaw = New System.Windows.Forms.Label()
        Me.lblPriceRefined = New System.Windows.Forms.Label()
        Me.tbRawQuant = New System.Windows.Forms.TextBox()
        Me.tbRefinedQuant = New System.Windows.Forms.TextBox()
        Me.lblQuant = New System.Windows.Forms.Label()
        Me.lblBexalite = New System.Windows.Forms.Label()
        Me.tbRefinedBexalite = New System.Windows.Forms.TextBox()
        Me.tbRawBexalite = New System.Windows.Forms.TextBox()
        Me.lblTaranite = New System.Windows.Forms.Label()
        Me.tbRefinedTaranite = New System.Windows.Forms.TextBox()
        Me.tbRawTaranite = New System.Windows.Forms.TextBox()
        Me.lblBorase = New System.Windows.Forms.Label()
        Me.tbRefinedBorase = New System.Windows.Forms.TextBox()
        Me.tbRawBorase = New System.Windows.Forms.TextBox()
        Me.lblLaranite = New System.Windows.Forms.Label()
        Me.tbRefinedLaranite = New System.Windows.Forms.TextBox()
        Me.tbRawLaranite = New System.Windows.Forms.TextBox()
        Me.lblAgricium = New System.Windows.Forms.Label()
        Me.tbRefinedAgricium = New System.Windows.Forms.TextBox()
        Me.tbRawAgricium = New System.Windows.Forms.TextBox()
        Me.lblHephaestanite = New System.Windows.Forms.Label()
        Me.tbRefinedHephaestanite = New System.Windows.Forms.TextBox()
        Me.tbRawHephaestanite = New System.Windows.Forms.TextBox()
        Me.lblTitanium = New System.Windows.Forms.Label()
        Me.tbRefinedTitanium = New System.Windows.Forms.TextBox()
        Me.tbRawTitanium = New System.Windows.Forms.TextBox()
        Me.lblDiamond = New System.Windows.Forms.Label()
        Me.tbRefinedDiamond = New System.Windows.Forms.TextBox()
        Me.tbRawDiamond = New System.Windows.Forms.TextBox()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.tbRefinedGold = New System.Windows.Forms.TextBox()
        Me.tbRawGold = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbStonecSCU = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStonecSCU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuotes
        '
        Me.btnQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotes.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuotes.ForeColor = System.Drawing.Color.Black
        Me.btnQuotes.Location = New System.Drawing.Point(642, 12)
        Me.btnQuotes.Name = "btnQuotes"
        Me.btnQuotes.Size = New System.Drawing.Size(128, 33)
        Me.btnQuotes.TabIndex = 29
        Me.btnQuotes.Text = "Quotes"
        Me.btnQuotes.UseVisualStyleBackColor = True
        '
        'btnPriceList
        '
        Me.btnPriceList.Enabled = False
        Me.btnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPriceList.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriceList.ForeColor = System.Drawing.Color.Black
        Me.btnPriceList.Location = New System.Drawing.Point(488, 12)
        Me.btnPriceList.Name = "btnPriceList"
        Me.btnPriceList.Size = New System.Drawing.Size(128, 33)
        Me.btnPriceList.TabIndex = 28
        Me.btnPriceList.Text = "Price list"
        Me.btnPriceList.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(333, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(128, 33)
        Me.btnMainMenu.TabIndex = 27
        Me.btnMainMenu.Text = "Main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobs.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobs.ForeColor = System.Drawing.Color.Black
        Me.btnJobs.Location = New System.Drawing.Point(177, 12)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(128, 33)
        Me.btnJobs.TabIndex = 26
        Me.btnJobs.Text = "Jobs"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.ForeColor = System.Drawing.Color.Black
        Me.btnCalculator.Location = New System.Drawing.Point(22, 12)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(128, 33)
        Me.btnCalculator.TabIndex = 25
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'lblOre
        '
        Me.lblOre.AutoSize = True
        Me.lblOre.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOre.Location = New System.Drawing.Point(124, 66)
        Me.lblOre.Name = "lblOre"
        Me.lblOre.Size = New System.Drawing.Size(79, 24)
        Me.lblOre.TabIndex = 30
        Me.lblOre.Text = "Ore type:"
        '
        'lblPriceRaw
        '
        Me.lblPriceRaw.AutoSize = True
        Me.lblPriceRaw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceRaw.Location = New System.Drawing.Point(352, 66)
        Me.lblPriceRaw.Name = "lblPriceRaw"
        Me.lblPriceRaw.Size = New System.Drawing.Size(91, 24)
        Me.lblPriceRaw.TabIndex = 31
        Me.lblPriceRaw.Text = "Price Raw:"
        '
        'lblPriceRefined
        '
        Me.lblPriceRefined.AutoSize = True
        Me.lblPriceRefined.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceRefined.Location = New System.Drawing.Point(570, 66)
        Me.lblPriceRefined.Name = "lblPriceRefined"
        Me.lblPriceRefined.Size = New System.Drawing.Size(117, 24)
        Me.lblPriceRefined.TabIndex = 32
        Me.lblPriceRefined.Text = "Price Refined:"
        '
        'tbRawQuant
        '
        Me.tbRawQuant.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawQuant.ForeColor = System.Drawing.Color.White
        Me.tbRawQuant.Location = New System.Drawing.Point(333, 93)
        Me.tbRawQuant.MaxLength = 5
        Me.tbRawQuant.Name = "tbRawQuant"
        Me.tbRawQuant.Size = New System.Drawing.Size(128, 36)
        Me.tbRawQuant.TabIndex = 33
        Me.tbRawQuant.Text = "44,00"
        Me.tbRawQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRefinedQuant
        '
        Me.tbRefinedQuant.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedQuant.ForeColor = System.Drawing.Color.White
        Me.tbRefinedQuant.Location = New System.Drawing.Point(563, 93)
        Me.tbRefinedQuant.MaxLength = 5
        Me.tbRefinedQuant.Name = "tbRefinedQuant"
        Me.tbRefinedQuant.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedQuant.TabIndex = 34
        Me.tbRefinedQuant.Text = "88,00"
        Me.tbRefinedQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuant
        '
        Me.lblQuant.AutoSize = True
        Me.lblQuant.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuant.Location = New System.Drawing.Point(100, 96)
        Me.lblQuant.Name = "lblQuant"
        Me.lblQuant.Size = New System.Drawing.Size(131, 29)
        Me.lblQuant.TabIndex = 35
        Me.lblQuant.Text = "Quantanium:"
        '
        'lblBexalite
        '
        Me.lblBexalite.AutoSize = True
        Me.lblBexalite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBexalite.Location = New System.Drawing.Point(117, 135)
        Me.lblBexalite.Name = "lblBexalite"
        Me.lblBexalite.Size = New System.Drawing.Size(93, 29)
        Me.lblBexalite.TabIndex = 38
        Me.lblBexalite.Text = "Bexalite:"
        '
        'tbRefinedBexalite
        '
        Me.tbRefinedBexalite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedBexalite.ForeColor = System.Drawing.Color.White
        Me.tbRefinedBexalite.Location = New System.Drawing.Point(563, 135)
        Me.tbRefinedBexalite.MaxLength = 5
        Me.tbRefinedBexalite.Name = "tbRefinedBexalite"
        Me.tbRefinedBexalite.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedBexalite.TabIndex = 37
        Me.tbRefinedBexalite.Text = "44,00"
        Me.tbRefinedBexalite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawBexalite
        '
        Me.tbRawBexalite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawBexalite.ForeColor = System.Drawing.Color.White
        Me.tbRawBexalite.Location = New System.Drawing.Point(333, 135)
        Me.tbRawBexalite.MaxLength = 5
        Me.tbRawBexalite.Name = "tbRawBexalite"
        Me.tbRawBexalite.Size = New System.Drawing.Size(128, 36)
        Me.tbRawBexalite.TabIndex = 36
        Me.tbRawBexalite.Text = "20,33"
        Me.tbRawBexalite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTaranite
        '
        Me.lblTaranite.AutoSize = True
        Me.lblTaranite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaranite.Location = New System.Drawing.Point(117, 177)
        Me.lblTaranite.Name = "lblTaranite"
        Me.lblTaranite.Size = New System.Drawing.Size(93, 29)
        Me.lblTaranite.TabIndex = 41
        Me.lblTaranite.Text = "Taranite:"
        '
        'tbRefinedTaranite
        '
        Me.tbRefinedTaranite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedTaranite.ForeColor = System.Drawing.Color.White
        Me.tbRefinedTaranite.Location = New System.Drawing.Point(563, 177)
        Me.tbRefinedTaranite.MaxLength = 5
        Me.tbRefinedTaranite.Name = "tbRefinedTaranite"
        Me.tbRefinedTaranite.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedTaranite.TabIndex = 40
        Me.tbRefinedTaranite.Text = "35,31"
        Me.tbRefinedTaranite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawTaranite
        '
        Me.tbRawTaranite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawTaranite.ForeColor = System.Drawing.Color.White
        Me.tbRawTaranite.Location = New System.Drawing.Point(333, 177)
        Me.tbRawTaranite.MaxLength = 5
        Me.tbRawTaranite.Name = "tbRawTaranite"
        Me.tbRawTaranite.Size = New System.Drawing.Size(128, 36)
        Me.tbRawTaranite.TabIndex = 39
        Me.tbRawTaranite.Text = "16,29"
        Me.tbRawTaranite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBorase
        '
        Me.lblBorase.AutoSize = True
        Me.lblBorase.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorase.Location = New System.Drawing.Point(120, 219)
        Me.lblBorase.Name = "lblBorase"
        Me.lblBorase.Size = New System.Drawing.Size(84, 29)
        Me.lblBorase.TabIndex = 44
        Me.lblBorase.Text = "Borase:"
        '
        'tbRefinedBorase
        '
        Me.tbRefinedBorase.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedBorase.ForeColor = System.Drawing.Color.White
        Me.tbRefinedBorase.Location = New System.Drawing.Point(563, 219)
        Me.tbRefinedBorase.MaxLength = 5
        Me.tbRefinedBorase.Name = "tbRefinedBorase"
        Me.tbRefinedBorase.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedBorase.TabIndex = 43
        Me.tbRefinedBorase.Text = "35,31"
        Me.tbRefinedBorase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawBorase
        '
        Me.tbRawBorase.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawBorase.ForeColor = System.Drawing.Color.White
        Me.tbRawBorase.Location = New System.Drawing.Point(333, 219)
        Me.tbRawBorase.MaxLength = 5
        Me.tbRawBorase.Name = "tbRawBorase"
        Me.tbRawBorase.Size = New System.Drawing.Size(128, 36)
        Me.tbRawBorase.TabIndex = 42
        Me.tbRawBorase.Text = "16,29"
        Me.tbRawBorase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLaranite
        '
        Me.lblLaranite.AutoSize = True
        Me.lblLaranite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaranite.Location = New System.Drawing.Point(115, 261)
        Me.lblLaranite.Name = "lblLaranite"
        Me.lblLaranite.Size = New System.Drawing.Size(95, 29)
        Me.lblLaranite.TabIndex = 47
        Me.lblLaranite.Text = "Laranite:"
        '
        'tbRefinedLaranite
        '
        Me.tbRefinedLaranite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedLaranite.ForeColor = System.Drawing.Color.White
        Me.tbRefinedLaranite.Location = New System.Drawing.Point(563, 261)
        Me.tbRefinedLaranite.MaxLength = 5
        Me.tbRefinedLaranite.Name = "tbRefinedLaranite"
        Me.tbRefinedLaranite.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedLaranite.TabIndex = 46
        Me.tbRefinedLaranite.Text = "30,59"
        Me.tbRefinedLaranite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawLaranite
        '
        Me.tbRawLaranite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawLaranite.ForeColor = System.Drawing.Color.White
        Me.tbRawLaranite.Location = New System.Drawing.Point(333, 261)
        Me.tbRawLaranite.MaxLength = 5
        Me.tbRawLaranite.Name = "tbRawLaranite"
        Me.tbRawLaranite.Size = New System.Drawing.Size(128, 36)
        Me.tbRawLaranite.TabIndex = 45
        Me.tbRawLaranite.Text = "15,51"
        Me.tbRawLaranite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAgricium
        '
        Me.lblAgricium.AutoSize = True
        Me.lblAgricium.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgricium.Location = New System.Drawing.Point(113, 303)
        Me.lblAgricium.Name = "lblAgricium"
        Me.lblAgricium.Size = New System.Drawing.Size(102, 29)
        Me.lblAgricium.TabIndex = 50
        Me.lblAgricium.Text = "Agricium:"
        '
        'tbRefinedAgricium
        '
        Me.tbRefinedAgricium.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedAgricium.ForeColor = System.Drawing.Color.White
        Me.tbRefinedAgricium.Location = New System.Drawing.Point(563, 303)
        Me.tbRefinedAgricium.MaxLength = 5
        Me.tbRefinedAgricium.Name = "tbRefinedAgricium"
        Me.tbRefinedAgricium.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedAgricium.TabIndex = 49
        Me.tbRefinedAgricium.Text = "27,50"
        Me.tbRefinedAgricium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawAgricium
        '
        Me.tbRawAgricium.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawAgricium.ForeColor = System.Drawing.Color.White
        Me.tbRawAgricium.Location = New System.Drawing.Point(333, 303)
        Me.tbRawAgricium.MaxLength = 5
        Me.tbRawAgricium.Name = "tbRawAgricium"
        Me.tbRawAgricium.Size = New System.Drawing.Size(128, 36)
        Me.tbRawAgricium.TabIndex = 48
        Me.tbRawAgricium.Text = "13,75"
        Me.tbRawAgricium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHephaestanite
        '
        Me.lblHephaestanite.AutoSize = True
        Me.lblHephaestanite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHephaestanite.Location = New System.Drawing.Point(85, 345)
        Me.lblHephaestanite.Name = "lblHephaestanite"
        Me.lblHephaestanite.Size = New System.Drawing.Size(151, 29)
        Me.lblHephaestanite.TabIndex = 53
        Me.lblHephaestanite.Text = "Hephaestanite:"
        '
        'tbRefinedHephaestanite
        '
        Me.tbRefinedHephaestanite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedHephaestanite.ForeColor = System.Drawing.Color.White
        Me.tbRefinedHephaestanite.Location = New System.Drawing.Point(563, 345)
        Me.tbRefinedHephaestanite.MaxLength = 5
        Me.tbRefinedHephaestanite.Name = "tbRefinedHephaestanite"
        Me.tbRefinedHephaestanite.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedHephaestanite.TabIndex = 52
        Me.tbRefinedHephaestanite.Text = "15,85"
        Me.tbRefinedHephaestanite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawHephaestanite
        '
        Me.tbRawHephaestanite.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawHephaestanite.ForeColor = System.Drawing.Color.White
        Me.tbRawHephaestanite.Location = New System.Drawing.Point(333, 345)
        Me.tbRawHephaestanite.MaxLength = 5
        Me.tbRawHephaestanite.Name = "tbRawHephaestanite"
        Me.tbRawHephaestanite.Size = New System.Drawing.Size(128, 36)
        Me.tbRawHephaestanite.TabIndex = 51
        Me.tbRawHephaestanite.Text = "7,38"
        Me.tbRawHephaestanite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitanium
        '
        Me.lblTitanium.AutoSize = True
        Me.lblTitanium.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitanium.Location = New System.Drawing.Point(113, 387)
        Me.lblTitanium.Name = "lblTitanium"
        Me.lblTitanium.Size = New System.Drawing.Size(98, 29)
        Me.lblTitanium.TabIndex = 56
        Me.lblTitanium.Text = "Titanium:"
        '
        'tbRefinedTitanium
        '
        Me.tbRefinedTitanium.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedTitanium.ForeColor = System.Drawing.Color.White
        Me.tbRefinedTitanium.Location = New System.Drawing.Point(563, 387)
        Me.tbRefinedTitanium.MaxLength = 5
        Me.tbRefinedTitanium.Name = "tbRefinedTitanium"
        Me.tbRefinedTitanium.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedTitanium.TabIndex = 55
        Me.tbRefinedTitanium.Text = "8,90"
        Me.tbRefinedTitanium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawTitanium
        '
        Me.tbRawTitanium.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawTitanium.ForeColor = System.Drawing.Color.White
        Me.tbRawTitanium.Location = New System.Drawing.Point(333, 387)
        Me.tbRawTitanium.MaxLength = 5
        Me.tbRawTitanium.Name = "tbRawTitanium"
        Me.tbRawTitanium.Size = New System.Drawing.Size(128, 36)
        Me.tbRawTitanium.TabIndex = 54
        Me.tbRawTitanium.Text = "4,47"
        Me.tbRawTitanium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDiamond
        '
        Me.lblDiamond.AutoSize = True
        Me.lblDiamond.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiamond.Location = New System.Drawing.Point(113, 429)
        Me.lblDiamond.Name = "lblDiamond"
        Me.lblDiamond.Size = New System.Drawing.Size(99, 29)
        Me.lblDiamond.TabIndex = 59
        Me.lblDiamond.Text = "Diamond:"
        '
        'tbRefinedDiamond
        '
        Me.tbRefinedDiamond.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedDiamond.ForeColor = System.Drawing.Color.White
        Me.tbRefinedDiamond.Location = New System.Drawing.Point(563, 429)
        Me.tbRefinedDiamond.MaxLength = 5
        Me.tbRefinedDiamond.Name = "tbRefinedDiamond"
        Me.tbRefinedDiamond.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedDiamond.TabIndex = 58
        Me.tbRefinedDiamond.Text = "7,35"
        Me.tbRefinedDiamond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawDiamond
        '
        Me.tbRawDiamond.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawDiamond.ForeColor = System.Drawing.Color.White
        Me.tbRawDiamond.Location = New System.Drawing.Point(333, 429)
        Me.tbRawDiamond.MaxLength = 5
        Me.tbRawDiamond.Name = "tbRawDiamond"
        Me.tbRawDiamond.Size = New System.Drawing.Size(128, 36)
        Me.tbRawDiamond.TabIndex = 57
        Me.tbRawDiamond.Text = "3,68"
        Me.tbRawDiamond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGold.Location = New System.Drawing.Point(129, 471)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(59, 29)
        Me.lblGold.TabIndex = 62
        Me.lblGold.Text = "Gold:"
        '
        'tbRefinedGold
        '
        Me.tbRefinedGold.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefinedGold.ForeColor = System.Drawing.Color.White
        Me.tbRefinedGold.Location = New System.Drawing.Point(563, 471)
        Me.tbRefinedGold.MaxLength = 5
        Me.tbRefinedGold.Name = "tbRefinedGold"
        Me.tbRefinedGold.Size = New System.Drawing.Size(128, 36)
        Me.tbRefinedGold.TabIndex = 61
        Me.tbRefinedGold.Text = "6,41"
        Me.tbRefinedGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRawGold
        '
        Me.tbRawGold.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawGold.ForeColor = System.Drawing.Color.White
        Me.tbRawGold.Location = New System.Drawing.Point(333, 471)
        Me.tbRawGold.MaxLength = 5
        Me.tbRawGold.Name = "tbRawGold"
        Me.tbRawGold.Size = New System.Drawing.Size(128, 36)
        Me.tbRawGold.TabIndex = 60
        Me.tbRawGold.Text = "3,20"
        Me.tbRawGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(177, 530)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(155, 46)
        Me.btnReset.TabIndex = 63
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(536, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(155, 46)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StarCitizen_Mining.My.Resources.Resources.recycle
        Me.PictureBox1.Location = New System.Drawing.Point(123, 530)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'pbStonecSCU
        '
        Me.pbStonecSCU.Image = Global.StarCitizen_Mining.My.Resources.Resources.floppy_disk
        Me.pbStonecSCU.Location = New System.Drawing.Point(483, 530)
        Me.pbStonecSCU.Name = "pbStonecSCU"
        Me.pbStonecSCU.Size = New System.Drawing.Size(47, 46)
        Me.pbStonecSCU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStonecSCU.TabIndex = 65
        Me.pbStonecSCU.TabStop = False
        '
        'PriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 596)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbStonecSCU)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.tbRefinedGold)
        Me.Controls.Add(Me.tbRawGold)
        Me.Controls.Add(Me.lblDiamond)
        Me.Controls.Add(Me.tbRefinedDiamond)
        Me.Controls.Add(Me.tbRawDiamond)
        Me.Controls.Add(Me.lblTitanium)
        Me.Controls.Add(Me.tbRefinedTitanium)
        Me.Controls.Add(Me.tbRawTitanium)
        Me.Controls.Add(Me.lblHephaestanite)
        Me.Controls.Add(Me.tbRefinedHephaestanite)
        Me.Controls.Add(Me.tbRawHephaestanite)
        Me.Controls.Add(Me.lblAgricium)
        Me.Controls.Add(Me.tbRefinedAgricium)
        Me.Controls.Add(Me.tbRawAgricium)
        Me.Controls.Add(Me.lblLaranite)
        Me.Controls.Add(Me.tbRefinedLaranite)
        Me.Controls.Add(Me.tbRawLaranite)
        Me.Controls.Add(Me.lblBorase)
        Me.Controls.Add(Me.tbRefinedBorase)
        Me.Controls.Add(Me.tbRawBorase)
        Me.Controls.Add(Me.lblTaranite)
        Me.Controls.Add(Me.tbRefinedTaranite)
        Me.Controls.Add(Me.tbRawTaranite)
        Me.Controls.Add(Me.lblBexalite)
        Me.Controls.Add(Me.tbRefinedBexalite)
        Me.Controls.Add(Me.tbRawBexalite)
        Me.Controls.Add(Me.lblQuant)
        Me.Controls.Add(Me.tbRefinedQuant)
        Me.Controls.Add(Me.tbRawQuant)
        Me.Controls.Add(Me.lblPriceRefined)
        Me.Controls.Add(Me.lblPriceRaw)
        Me.Controls.Add(Me.lblOre)
        Me.Controls.Add(Me.btnQuotes)
        Me.Controls.Add(Me.btnPriceList)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnJobs)
        Me.Controls.Add(Me.btnCalculator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PriceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PriceList"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStonecSCU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuotes As Button
    Friend WithEvents btnPriceList As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnJobs As Button
    Friend WithEvents btnCalculator As Button
    Friend WithEvents lblOre As Label
    Friend WithEvents lblPriceRaw As Label
    Friend WithEvents lblPriceRefined As Label
    Friend WithEvents tbRawQuant As TextBox
    Friend WithEvents tbRefinedQuant As TextBox
    Friend WithEvents lblQuant As Label
    Friend WithEvents lblBexalite As Label
    Friend WithEvents tbRefinedBexalite As TextBox
    Friend WithEvents tbRawBexalite As TextBox
    Friend WithEvents lblTaranite As Label
    Friend WithEvents tbRefinedTaranite As TextBox
    Friend WithEvents tbRawTaranite As TextBox
    Friend WithEvents lblBorase As Label
    Friend WithEvents tbRefinedBorase As TextBox
    Friend WithEvents tbRawBorase As TextBox
    Friend WithEvents lblLaranite As Label
    Friend WithEvents tbRefinedLaranite As TextBox
    Friend WithEvents tbRawLaranite As TextBox
    Friend WithEvents lblAgricium As Label
    Friend WithEvents tbRefinedAgricium As TextBox
    Friend WithEvents tbRawAgricium As TextBox
    Friend WithEvents lblHephaestanite As Label
    Friend WithEvents tbRefinedHephaestanite As TextBox
    Friend WithEvents tbRawHephaestanite As TextBox
    Friend WithEvents lblTitanium As Label
    Friend WithEvents tbRefinedTitanium As TextBox
    Friend WithEvents tbRawTitanium As TextBox
    Friend WithEvents lblDiamond As Label
    Friend WithEvents tbRefinedDiamond As TextBox
    Friend WithEvents tbRawDiamond As TextBox
    Friend WithEvents lblGold As Label
    Friend WithEvents tbRefinedGold As TextBox
    Friend WithEvents tbRawGold As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pbStonecSCU As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
