<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jobs))
        Me.btnQuotes = New System.Windows.Forms.Button()
        Me.btnPriceList = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.lvJobs = New System.Windows.Forms.ListView()
        Me.chNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRCosts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPeople = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cbStation = New System.Windows.Forms.ComboBox()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.cbCosts = New System.Windows.Forms.ComboBox()
        Me.lblMiner = New System.Windows.Forms.Label()
        Me.lblScouts = New System.Windows.Forms.Label()
        Me.tbMiner = New System.Windows.Forms.TextBox()
        Me.tbScout = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cbMiner = New System.Windows.Forms.ComboBox()
        Me.cbScout = New System.Windows.Forms.ComboBox()
        Me.btnAddMiner = New System.Windows.Forms.Button()
        Me.btnDeleteMiner = New System.Windows.Forms.Button()
        Me.btnAddScout = New System.Windows.Forms.Button()
        Me.btnDeleteScout = New System.Windows.Forms.Button()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblJobsTitleNumber = New System.Windows.Forms.Label()
        Me.lblJobsNumber = New System.Windows.Forms.Label()
        Me.lblJobsStation = New System.Windows.Forms.Label()
        Me.lblJobsTitleStation = New System.Windows.Forms.Label()
        Me.lblJobsDate = New System.Windows.Forms.Label()
        Me.lblJobsTitleDate = New System.Windows.Forms.Label()
        Me.lblJobsCosts = New System.Windows.Forms.Label()
        Me.lblJobsTitleCosts = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.tbPriceRefined1 = New System.Windows.Forms.TextBox()
        Me.tbPriceRaw1 = New System.Windows.Forms.TextBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblPriceRefined = New System.Windows.Forms.Label()
        Me.lblPriceRaw = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.tbMass = New System.Windows.Forms.TextBox()
        Me.lblMass = New System.Windows.Forms.Label()
        Me.lblTitleJobAssignment = New System.Windows.Forms.Label()
        Me.btnSaveTask = New System.Windows.Forms.Button()
        Me.btnResetTask = New System.Windows.Forms.Button()
        Me.lblBusiness = New System.Windows.Forms.Label()
        Me.lblAssignmentPerPerson = New System.Windows.Forms.Label()
        Me.lblAssignmentRaw = New System.Windows.Forms.Label()
        Me.lblAssignmentHeaderPerPerson = New System.Windows.Forms.Label()
        Me.lblAssignmentHeaderRaw = New System.Windows.Forms.Label()
        Me.lblAssignmentCosts = New System.Windows.Forms.Label()
        Me.lblAssignmentHeaderCosts = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pbRefinedProfit = New System.Windows.Forms.PictureBox()
        Me.pbRawProfit = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbStonecSCU = New System.Windows.Forms.PictureBox()
        Me.cbAssignmentMiner = New System.Windows.Forms.ComboBox()
        Me.cbAssignmentScouts = New System.Windows.Forms.ComboBox()
        Me.lblAssignmentMiner = New System.Windows.Forms.Label()
        Me.lblAssignmentScouts = New System.Windows.Forms.Label()
        Me.btnDeleteAssignments = New System.Windows.Forms.Button()
        Me.btnDeleteJob = New System.Windows.Forms.Button()
        Me.lblAssignmentCosts2 = New System.Windows.Forms.Label()
        Me.lblAssignmentRaw2 = New System.Windows.Forms.Label()
        Me.lblAssignmentPerPerson2 = New System.Windows.Forms.Label()
        Me.btnAssignmentMiner = New System.Windows.Forms.Button()
        Me.btnAssignmentScouts = New System.Windows.Forms.Button()
        Me.btnDeletePaid = New System.Windows.Forms.Button()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRefinedProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRawProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStonecSCU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuotes
        '
        Me.btnQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotes.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuotes.ForeColor = System.Drawing.Color.Black
        Me.btnQuotes.Location = New System.Drawing.Point(653, 12)
        Me.btnQuotes.Name = "btnQuotes"
        Me.btnQuotes.Size = New System.Drawing.Size(128, 33)
        Me.btnQuotes.TabIndex = 24
        Me.btnQuotes.Text = "Quotes"
        Me.btnQuotes.UseVisualStyleBackColor = True
        '
        'btnPriceList
        '
        Me.btnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPriceList.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriceList.ForeColor = System.Drawing.Color.Black
        Me.btnPriceList.Location = New System.Drawing.Point(499, 12)
        Me.btnPriceList.Name = "btnPriceList"
        Me.btnPriceList.Size = New System.Drawing.Size(128, 33)
        Me.btnPriceList.TabIndex = 23
        Me.btnPriceList.Text = "Price list"
        Me.btnPriceList.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(344, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(128, 33)
        Me.btnMainMenu.TabIndex = 22
        Me.btnMainMenu.Text = "Main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.Enabled = False
        Me.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobs.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobs.ForeColor = System.Drawing.Color.Black
        Me.btnJobs.Location = New System.Drawing.Point(188, 12)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(128, 33)
        Me.btnJobs.TabIndex = 21
        Me.btnJobs.Text = "Jobs"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.ForeColor = System.Drawing.Color.Black
        Me.btnCalculator.Location = New System.Drawing.Point(33, 12)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(128, 33)
        Me.btnCalculator.TabIndex = 20
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'lvJobs
        '
        Me.lvJobs.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNumber, Me.chDate, Me.chStation, Me.chRCosts, Me.chPeople})
        Me.lvJobs.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!)
        Me.lvJobs.ForeColor = System.Drawing.Color.White
        Me.lvJobs.GridLines = True
        Me.lvJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvJobs.HideSelection = False
        Me.lvJobs.Location = New System.Drawing.Point(33, 394)
        Me.lvJobs.MultiSelect = False
        Me.lvJobs.Name = "lvJobs"
        Me.lvJobs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lvJobs.Size = New System.Drawing.Size(748, 340)
        Me.lvJobs.TabIndex = 25
        Me.lvJobs.UseCompatibleStateImageBehavior = False
        Me.lvJobs.View = System.Windows.Forms.View.Details
        '
        'chNumber
        '
        Me.chNumber.Text = "Tasknumber"
        Me.chNumber.Width = 115
        '
        'chDate
        '
        Me.chDate.Text = "Date"
        Me.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDate.Width = 159
        '
        'chStation
        '
        Me.chStation.Text = "Station"
        Me.chStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chStation.Width = 145
        '
        'chRCosts
        '
        Me.chRCosts.Text = "Reimburse Costs"
        Me.chRCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chRCosts.Width = 168
        '
        'chPeople
        '
        Me.chPeople.Text = "Peoplecount"
        Me.chPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chPeople.Width = 157
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 746)
        Me.Splitter1.TabIndex = 26
        Me.Splitter1.TabStop = False
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStation.Location = New System.Drawing.Point(29, 69)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(137, 24)
        Me.lblStation.TabIndex = 27
        Me.lblStation.Text = "Refinery station:"
        '
        'cbStation
        '
        Me.cbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStation.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStation.ForeColor = System.Drawing.Color.White
        Me.cbStation.FormattingEnabled = True
        Me.cbStation.Items.AddRange(New Object() {"ARC-L1", "CRU-L1", "HUR-L1", "HUR-L2", "MIC-L1"})
        Me.cbStation.Location = New System.Drawing.Point(188, 70)
        Me.cbStation.Name = "cbStation"
        Me.cbStation.Size = New System.Drawing.Size(155, 27)
        Me.cbStation.TabIndex = 29
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.Location = New System.Drawing.Point(467, 69)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(144, 24)
        Me.lblCosts.TabIndex = 34
        Me.lblCosts.Text = "Reimburse costs:"
        '
        'cbCosts
        '
        Me.cbCosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCosts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCosts.ForeColor = System.Drawing.Color.White
        Me.cbCosts.FormattingEnabled = True
        Me.cbCosts.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbCosts.Location = New System.Drawing.Point(625, 66)
        Me.cbCosts.Name = "cbCosts"
        Me.cbCosts.Size = New System.Drawing.Size(155, 27)
        Me.cbCosts.TabIndex = 35
        '
        'lblMiner
        '
        Me.lblMiner.AutoSize = True
        Me.lblMiner.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiner.Location = New System.Drawing.Point(29, 116)
        Me.lblMiner.Name = "lblMiner"
        Me.lblMiner.Size = New System.Drawing.Size(119, 24)
        Me.lblMiner.TabIndex = 36
        Me.lblMiner.Text = "Mining people:"
        '
        'lblScouts
        '
        Me.lblScouts.AutoSize = True
        Me.lblScouts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScouts.Location = New System.Drawing.Point(467, 116)
        Me.lblScouts.Name = "lblScouts"
        Me.lblScouts.Size = New System.Drawing.Size(113, 24)
        Me.lblScouts.TabIndex = 37
        Me.lblScouts.Text = "Scout people:"
        '
        'tbMiner
        '
        Me.tbMiner.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMiner.ForeColor = System.Drawing.Color.White
        Me.tbMiner.Location = New System.Drawing.Point(188, 116)
        Me.tbMiner.MaxLength = 20000
        Me.tbMiner.Name = "tbMiner"
        Me.tbMiner.Size = New System.Drawing.Size(155, 30)
        Me.tbMiner.TabIndex = 38
        '
        'tbScout
        '
        Me.tbScout.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbScout.ForeColor = System.Drawing.Color.White
        Me.tbScout.Location = New System.Drawing.Point(625, 116)
        Me.tbScout.MaxLength = 20000
        Me.tbScout.Name = "tbScout"
        Me.tbScout.Size = New System.Drawing.Size(155, 30)
        Me.tbScout.TabIndex = 48
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(499, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(155, 46)
        Me.btnSave.TabIndex = 68
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(188, 301)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(155, 46)
        Me.btnReset.TabIndex = 67
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cbMiner
        '
        Me.cbMiner.BackColor = System.Drawing.Color.White
        Me.cbMiner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMiner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMiner.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMiner.ForeColor = System.Drawing.Color.White
        Me.cbMiner.FormattingEnabled = True
        Me.cbMiner.Location = New System.Drawing.Point(188, 189)
        Me.cbMiner.Name = "cbMiner"
        Me.cbMiner.Size = New System.Drawing.Size(155, 31)
        Me.cbMiner.TabIndex = 71
        '
        'cbScout
        '
        Me.cbScout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbScout.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbScout.ForeColor = System.Drawing.Color.White
        Me.cbScout.FormattingEnabled = True
        Me.cbScout.Location = New System.Drawing.Point(626, 189)
        Me.cbScout.Name = "cbScout"
        Me.cbScout.Size = New System.Drawing.Size(155, 31)
        Me.cbScout.TabIndex = 72
        '
        'btnAddMiner
        '
        Me.btnAddMiner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMiner.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMiner.ForeColor = System.Drawing.Color.Black
        Me.btnAddMiner.Location = New System.Drawing.Point(188, 152)
        Me.btnAddMiner.Name = "btnAddMiner"
        Me.btnAddMiner.Size = New System.Drawing.Size(67, 31)
        Me.btnAddMiner.TabIndex = 73
        Me.btnAddMiner.Text = "Add"
        Me.btnAddMiner.UseVisualStyleBackColor = True
        '
        'btnDeleteMiner
        '
        Me.btnDeleteMiner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteMiner.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteMiner.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteMiner.Location = New System.Drawing.Point(188, 226)
        Me.btnDeleteMiner.Name = "btnDeleteMiner"
        Me.btnDeleteMiner.Size = New System.Drawing.Size(67, 31)
        Me.btnDeleteMiner.TabIndex = 74
        Me.btnDeleteMiner.Text = "Delete"
        Me.btnDeleteMiner.UseVisualStyleBackColor = True
        '
        'btnAddScout
        '
        Me.btnAddScout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddScout.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddScout.ForeColor = System.Drawing.Color.Black
        Me.btnAddScout.Location = New System.Drawing.Point(625, 152)
        Me.btnAddScout.Name = "btnAddScout"
        Me.btnAddScout.Size = New System.Drawing.Size(67, 31)
        Me.btnAddScout.TabIndex = 75
        Me.btnAddScout.Text = "Add"
        Me.btnAddScout.UseVisualStyleBackColor = True
        '
        'btnDeleteScout
        '
        Me.btnDeleteScout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteScout.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteScout.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteScout.Location = New System.Drawing.Point(625, 226)
        Me.btnDeleteScout.Name = "btnDeleteScout"
        Me.btnDeleteScout.Size = New System.Drawing.Size(67, 31)
        Me.btnDeleteScout.TabIndex = 76
        Me.btnDeleteScout.Text = "Delete"
        Me.btnDeleteScout.UseVisualStyleBackColor = True
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Bell MT", 20.0!)
        Me.lblInformation.ForeColor = System.Drawing.Color.White
        Me.lblInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformation.Location = New System.Drawing.Point(1036, 10)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(186, 30)
        Me.lblInformation.TabIndex = 77
        Me.lblInformation.Text = "Job information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblJobsTitleNumber
        '
        Me.lblJobsTitleNumber.AutoSize = True
        Me.lblJobsTitleNumber.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsTitleNumber.Location = New System.Drawing.Point(859, 64)
        Me.lblJobsTitleNumber.Name = "lblJobsTitleNumber"
        Me.lblJobsTitleNumber.Size = New System.Drawing.Size(125, 27)
        Me.lblJobsTitleNumber.TabIndex = 80
        Me.lblJobsTitleNumber.Text = "Tasknumber :"
        '
        'lblJobsNumber
        '
        Me.lblJobsNumber.AutoSize = True
        Me.lblJobsNumber.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsNumber.Location = New System.Drawing.Point(990, 66)
        Me.lblJobsNumber.Name = "lblJobsNumber"
        Me.lblJobsNumber.Size = New System.Drawing.Size(0, 27)
        Me.lblJobsNumber.TabIndex = 81
        '
        'lblJobsStation
        '
        Me.lblJobsStation.AutoSize = True
        Me.lblJobsStation.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsStation.Location = New System.Drawing.Point(1319, 64)
        Me.lblJobsStation.Name = "lblJobsStation"
        Me.lblJobsStation.Size = New System.Drawing.Size(0, 27)
        Me.lblJobsStation.TabIndex = 84
        '
        'lblJobsTitleStation
        '
        Me.lblJobsTitleStation.AutoSize = True
        Me.lblJobsTitleStation.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsTitleStation.Location = New System.Drawing.Point(1158, 64)
        Me.lblJobsTitleStation.Name = "lblJobsTitleStation"
        Me.lblJobsTitleStation.Size = New System.Drawing.Size(155, 27)
        Me.lblJobsTitleStation.TabIndex = 83
        Me.lblJobsTitleStation.Text = "Refinery station :"
        '
        'lblJobsDate
        '
        Me.lblJobsDate.AutoSize = True
        Me.lblJobsDate.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsDate.Location = New System.Drawing.Point(1223, 123)
        Me.lblJobsDate.Name = "lblJobsDate"
        Me.lblJobsDate.Size = New System.Drawing.Size(0, 27)
        Me.lblJobsDate.TabIndex = 90
        '
        'lblJobsTitleDate
        '
        Me.lblJobsTitleDate.AutoSize = True
        Me.lblJobsTitleDate.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsTitleDate.Location = New System.Drawing.Point(1158, 123)
        Me.lblJobsTitleDate.Name = "lblJobsTitleDate"
        Me.lblJobsTitleDate.Size = New System.Drawing.Size(59, 27)
        Me.lblJobsTitleDate.TabIndex = 89
        Me.lblJobsTitleDate.Text = "Date :"
        '
        'lblJobsCosts
        '
        Me.lblJobsCosts.AutoSize = True
        Me.lblJobsCosts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsCosts.Location = New System.Drawing.Point(1019, 123)
        Me.lblJobsCosts.Name = "lblJobsCosts"
        Me.lblJobsCosts.Size = New System.Drawing.Size(0, 27)
        Me.lblJobsCosts.TabIndex = 87
        '
        'lblJobsTitleCosts
        '
        Me.lblJobsTitleCosts.AutoSize = True
        Me.lblJobsTitleCosts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobsTitleCosts.Location = New System.Drawing.Point(859, 123)
        Me.lblJobsTitleCosts.Name = "lblJobsTitleCosts"
        Me.lblJobsTitleCosts.Size = New System.Drawing.Size(160, 27)
        Me.lblJobsTitleCosts.TabIndex = 86
        Me.lblJobsTitleCosts.Text = "Reimburse Costs:"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Bell MT", 15.75!, System.Drawing.FontStyle.Italic)
        Me.lblHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHelp.Location = New System.Drawing.Point(270, 367)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(286, 24)
        Me.lblHelp.TabIndex = 91
        Me.lblHelp.Text = "Select the tasknumber for more info"
        Me.lblHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbPriceRefined1
        '
        Me.tbPriceRefined1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRefined1.ForeColor = System.Drawing.Color.White
        Me.tbPriceRefined1.Location = New System.Drawing.Point(1062, 321)
        Me.tbPriceRefined1.Name = "tbPriceRefined1"
        Me.tbPriceRefined1.ReadOnly = True
        Me.tbPriceRefined1.Size = New System.Drawing.Size(123, 32)
        Me.tbPriceRefined1.TabIndex = 101
        Me.tbPriceRefined1.TabStop = False
        Me.tbPriceRefined1.Text = "0"
        '
        'tbPriceRaw1
        '
        Me.tbPriceRaw1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceRaw1.ForeColor = System.Drawing.Color.White
        Me.tbPriceRaw1.Location = New System.Drawing.Point(844, 321)
        Me.tbPriceRaw1.Name = "tbPriceRaw1"
        Me.tbPriceRaw1.ReadOnly = True
        Me.tbPriceRaw1.Size = New System.Drawing.Size(132, 32)
        Me.tbPriceRaw1.TabIndex = 100
        Me.tbPriceRaw1.TabStop = False
        Me.tbPriceRaw1.Text = "0"
        '
        'cbType
        '
        Me.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbType.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.ForeColor = System.Drawing.Color.White
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Quantanium", "Bexalite", "Taranite", "Borase", "Laranite", "Agricium", "Hephaestanite", "Titanium", "Diamond", "Gold"})
        Me.cbType.Location = New System.Drawing.Point(1062, 243)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(123, 32)
        Me.cbType.TabIndex = 99
        '
        'lblPriceRefined
        '
        Me.lblPriceRefined.AutoSize = True
        Me.lblPriceRefined.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceRefined.Location = New System.Drawing.Point(1058, 294)
        Me.lblPriceRefined.Name = "lblPriceRefined"
        Me.lblPriceRefined.Size = New System.Drawing.Size(125, 24)
        Me.lblPriceRefined.TabIndex = 96
        Me.lblPriceRefined.Text = "Price (Refined)"
        '
        'lblPriceRaw
        '
        Me.lblPriceRaw.AutoSize = True
        Me.lblPriceRaw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceRaw.Location = New System.Drawing.Point(840, 294)
        Me.lblPriceRaw.Name = "lblPriceRaw"
        Me.lblPriceRaw.Size = New System.Drawing.Size(100, 24)
        Me.lblPriceRaw.TabIndex = 95
        Me.lblPriceRaw.Text = "Price (Raw)"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(1058, 216)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(75, 24)
        Me.lblType.TabIndex = 94
        Me.lblType.Text = "Ore type"
        '
        'tbMass
        '
        Me.tbMass.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMass.ForeColor = System.Drawing.Color.White
        Me.tbMass.Location = New System.Drawing.Point(844, 243)
        Me.tbMass.MaxLength = 4
        Me.tbMass.Multiline = True
        Me.tbMass.Name = "tbMass"
        Me.tbMass.Size = New System.Drawing.Size(132, 32)
        Me.tbMass.TabIndex = 93
        '
        'lblMass
        '
        Me.lblMass.AutoSize = True
        Me.lblMass.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.0!)
        Me.lblMass.Location = New System.Drawing.Point(840, 216)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.Size = New System.Drawing.Size(136, 24)
        Me.lblMass.TabIndex = 92
        Me.lblMass.Text = "Quantity (cSCU):"
        '
        'lblTitleJobAssignment
        '
        Me.lblTitleJobAssignment.AutoSize = True
        Me.lblTitleJobAssignment.Font = New System.Drawing.Font("Bell MT", 20.0!)
        Me.lblTitleJobAssignment.ForeColor = System.Drawing.Color.White
        Me.lblTitleJobAssignment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleJobAssignment.Location = New System.Drawing.Point(1019, 172)
        Me.lblTitleJobAssignment.Name = "lblTitleJobAssignment"
        Me.lblTitleJobAssignment.Size = New System.Drawing.Size(212, 30)
        Me.lblTitleJobAssignment.TabIndex = 104
        Me.lblTitleJobAssignment.Text = "Add a assignment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTitleJobAssignment.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSaveTask
        '
        Me.btnSaveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveTask.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTask.ForeColor = System.Drawing.Color.Black
        Me.btnSaveTask.Location = New System.Drawing.Point(1269, 242)
        Me.btnSaveTask.Name = "btnSaveTask"
        Me.btnSaveTask.Size = New System.Drawing.Size(141, 32)
        Me.btnSaveTask.TabIndex = 106
        Me.btnSaveTask.Text = "Save"
        Me.btnSaveTask.UseVisualStyleBackColor = True
        '
        'btnResetTask
        '
        Me.btnResetTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetTask.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTask.ForeColor = System.Drawing.Color.Black
        Me.btnResetTask.Location = New System.Drawing.Point(1269, 321)
        Me.btnResetTask.Name = "btnResetTask"
        Me.btnResetTask.Size = New System.Drawing.Size(141, 32)
        Me.btnResetTask.TabIndex = 105
        Me.btnResetTask.Text = "Reset"
        Me.btnResetTask.UseVisualStyleBackColor = True
        '
        'lblBusiness
        '
        Me.lblBusiness.AutoSize = True
        Me.lblBusiness.Font = New System.Drawing.Font("Bell MT", 20.0!)
        Me.lblBusiness.ForeColor = System.Drawing.Color.White
        Me.lblBusiness.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBusiness.Location = New System.Drawing.Point(1036, 367)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(171, 30)
        Me.lblBusiness.TabIndex = 109
        Me.lblBusiness.Text = "Your business" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblBusiness.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignmentPerPerson
        '
        Me.lblAssignmentPerPerson.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentPerPerson.Location = New System.Drawing.Point(1264, 448)
        Me.lblAssignmentPerPerson.Name = "lblAssignmentPerPerson"
        Me.lblAssignmentPerPerson.Size = New System.Drawing.Size(139, 32)
        Me.lblAssignmentPerPerson.TabIndex = 115
        Me.lblAssignmentPerPerson.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAssignmentPerPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignmentRaw
        '
        Me.lblAssignmentRaw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentRaw.Location = New System.Drawing.Point(1057, 448)
        Me.lblAssignmentRaw.Name = "lblAssignmentRaw"
        Me.lblAssignmentRaw.Size = New System.Drawing.Size(138, 32)
        Me.lblAssignmentRaw.TabIndex = 114
        Me.lblAssignmentRaw.Text = "0 "
        Me.lblAssignmentRaw.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignmentHeaderPerPerson
        '
        Me.lblAssignmentHeaderPerPerson.AutoSize = True
        Me.lblAssignmentHeaderPerPerson.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentHeaderPerPerson.Location = New System.Drawing.Point(1294, 421)
        Me.lblAssignmentHeaderPerPerson.Name = "lblAssignmentHeaderPerPerson"
        Me.lblAssignmentHeaderPerPerson.Size = New System.Drawing.Size(116, 19)
        Me.lblAssignmentHeaderPerPerson.TabIndex = 112
        Me.lblAssignmentHeaderPerPerson.Text = "Profit per person"
        '
        'lblAssignmentHeaderRaw
        '
        Me.lblAssignmentHeaderRaw.AutoSize = True
        Me.lblAssignmentHeaderRaw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentHeaderRaw.Location = New System.Drawing.Point(1098, 421)
        Me.lblAssignmentHeaderRaw.Name = "lblAssignmentHeaderRaw"
        Me.lblAssignmentHeaderRaw.Size = New System.Drawing.Size(76, 19)
        Me.lblAssignmentHeaderRaw.TabIndex = 110
        Me.lblAssignmentHeaderRaw.Text = "Raw profit"
        '
        'lblAssignmentCosts
        '
        Me.lblAssignmentCosts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentCosts.Location = New System.Drawing.Point(859, 448)
        Me.lblAssignmentCosts.Name = "lblAssignmentCosts"
        Me.lblAssignmentCosts.Size = New System.Drawing.Size(138, 32)
        Me.lblAssignmentCosts.TabIndex = 118
        Me.lblAssignmentCosts.Text = "0 "
        Me.lblAssignmentCosts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignmentHeaderCosts
        '
        Me.lblAssignmentHeaderCosts.AutoSize = True
        Me.lblAssignmentHeaderCosts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentHeaderCosts.Location = New System.Drawing.Point(900, 421)
        Me.lblAssignmentHeaderCosts.Name = "lblAssignmentHeaderCosts"
        Me.lblAssignmentHeaderCosts.Size = New System.Drawing.Size(43, 19)
        Me.lblAssignmentHeaderCosts.TabIndex = 116
        Me.lblAssignmentHeaderCosts.Text = "Costs"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.StarCitizen_Mining.My.Resources.Resources.crisis
        Me.PictureBox8.Location = New System.Drawing.Point(864, 415)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 117
        Me.PictureBox8.TabStop = False
        '
        'pbRefinedProfit
        '
        Me.pbRefinedProfit.Image = Global.StarCitizen_Mining.My.Resources.Resources.check_mark__1_
        Me.pbRefinedProfit.Location = New System.Drawing.Point(1258, 415)
        Me.pbRefinedProfit.Name = "pbRefinedProfit"
        Me.pbRefinedProfit.Size = New System.Drawing.Size(30, 30)
        Me.pbRefinedProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefinedProfit.TabIndex = 113
        Me.pbRefinedProfit.TabStop = False
        '
        'pbRawProfit
        '
        Me.pbRawProfit.Image = Global.StarCitizen_Mining.My.Resources.Resources.check_mark
        Me.pbRawProfit.Location = New System.Drawing.Point(1062, 415)
        Me.pbRawProfit.Name = "pbRawProfit"
        Me.pbRawProfit.Size = New System.Drawing.Size(30, 30)
        Me.pbRawProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRawProfit.TabIndex = 111
        Me.pbRawProfit.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.StarCitizen_Mining.My.Resources.Resources.recycle
        Me.PictureBox6.Location = New System.Drawing.Point(1228, 321)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 108
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.StarCitizen_Mining.My.Resources.Resources.floppy_disk
        Me.PictureBox7.Location = New System.Drawing.Point(1228, 242)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 107
        Me.PictureBox7.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.StarCitizen_Mining.My.Resources.Resources.calendar1
        Me.PictureBox4.Location = New System.Drawing.Point(1112, 116)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 88
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.StarCitizen_Mining.My.Resources.Resources.save_money
        Me.PictureBox5.Location = New System.Drawing.Point(813, 116)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 85
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.StarCitizen_Mining.My.Resources.Resources.rocket
        Me.PictureBox3.Location = New System.Drawing.Point(1112, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 82
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StarCitizen_Mining.My.Resources.Resources.task_list
        Me.PictureBox2.Location = New System.Drawing.Point(813, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StarCitizen_Mining.My.Resources.Resources.recycle
        Me.PictureBox1.Location = New System.Drawing.Point(134, 301)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'pbStonecSCU
        '
        Me.pbStonecSCU.Image = Global.StarCitizen_Mining.My.Resources.Resources.floppy_disk
        Me.pbStonecSCU.Location = New System.Drawing.Point(446, 301)
        Me.pbStonecSCU.Name = "pbStonecSCU"
        Me.pbStonecSCU.Size = New System.Drawing.Size(47, 46)
        Me.pbStonecSCU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStonecSCU.TabIndex = 69
        Me.pbStonecSCU.TabStop = False
        '
        'cbAssignmentMiner
        '
        Me.cbAssignmentMiner.BackColor = System.Drawing.Color.White
        Me.cbAssignmentMiner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAssignmentMiner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAssignmentMiner.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAssignmentMiner.ForeColor = System.Drawing.Color.White
        Me.cbAssignmentMiner.FormattingEnabled = True
        Me.cbAssignmentMiner.Location = New System.Drawing.Point(886, 555)
        Me.cbAssignmentMiner.Name = "cbAssignmentMiner"
        Me.cbAssignmentMiner.Size = New System.Drawing.Size(155, 31)
        Me.cbAssignmentMiner.TabIndex = 119
        '
        'cbAssignmentScouts
        '
        Me.cbAssignmentScouts.BackColor = System.Drawing.Color.White
        Me.cbAssignmentScouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAssignmentScouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAssignmentScouts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAssignmentScouts.ForeColor = System.Drawing.Color.White
        Me.cbAssignmentScouts.FormattingEnabled = True
        Me.cbAssignmentScouts.Location = New System.Drawing.Point(886, 645)
        Me.cbAssignmentScouts.Name = "cbAssignmentScouts"
        Me.cbAssignmentScouts.Size = New System.Drawing.Size(155, 31)
        Me.cbAssignmentScouts.TabIndex = 120
        '
        'lblAssignmentMiner
        '
        Me.lblAssignmentMiner.AutoSize = True
        Me.lblAssignmentMiner.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentMiner.Location = New System.Drawing.Point(809, 558)
        Me.lblAssignmentMiner.Name = "lblAssignmentMiner"
        Me.lblAssignmentMiner.Size = New System.Drawing.Size(60, 23)
        Me.lblAssignmentMiner.TabIndex = 125
        Me.lblAssignmentMiner.Text = "Miner :"
        '
        'lblAssignmentScouts
        '
        Me.lblAssignmentScouts.AutoSize = True
        Me.lblAssignmentScouts.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentScouts.Location = New System.Drawing.Point(801, 648)
        Me.lblAssignmentScouts.Name = "lblAssignmentScouts"
        Me.lblAssignmentScouts.Size = New System.Drawing.Size(68, 23)
        Me.lblAssignmentScouts.TabIndex = 126
        Me.lblAssignmentScouts.Text = "Scouts :"
        '
        'btnDeleteAssignments
        '
        Me.btnDeleteAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAssignments.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAssignments.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteAssignments.Location = New System.Drawing.Point(1248, 601)
        Me.btnDeleteAssignments.Name = "btnDeleteAssignments"
        Me.btnDeleteAssignments.Size = New System.Drawing.Size(155, 46)
        Me.btnDeleteAssignments.TabIndex = 127
        Me.btnDeleteAssignments.Text = "Delete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "assignments"
        Me.btnDeleteAssignments.UseVisualStyleBackColor = True
        '
        'btnDeleteJob
        '
        Me.btnDeleteJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteJob.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteJob.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteJob.Location = New System.Drawing.Point(1248, 535)
        Me.btnDeleteJob.Name = "btnDeleteJob"
        Me.btnDeleteJob.Size = New System.Drawing.Size(155, 46)
        Me.btnDeleteJob.TabIndex = 128
        Me.btnDeleteJob.Text = "Delete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "job"
        Me.btnDeleteJob.UseVisualStyleBackColor = True
        '
        'lblAssignmentCosts2
        '
        Me.lblAssignmentCosts2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentCosts2.Location = New System.Drawing.Point(859, 480)
        Me.lblAssignmentCosts2.Name = "lblAssignmentCosts2"
        Me.lblAssignmentCosts2.Size = New System.Drawing.Size(138, 57)
        Me.lblAssignmentCosts2.TabIndex = 129
        Me.lblAssignmentCosts2.Text = "aUEC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAssignmentCosts2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignmentRaw2
        '
        Me.lblAssignmentRaw2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentRaw2.Location = New System.Drawing.Point(1054, 480)
        Me.lblAssignmentRaw2.Name = "lblAssignmentRaw2"
        Me.lblAssignmentRaw2.Size = New System.Drawing.Size(138, 57)
        Me.lblAssignmentRaw2.TabIndex = 130
        Me.lblAssignmentRaw2.Text = "aUEC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAssignmentRaw2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignmentPerPerson2
        '
        Me.lblAssignmentPerPerson2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentPerPerson2.Location = New System.Drawing.Point(1264, 480)
        Me.lblAssignmentPerPerson2.Name = "lblAssignmentPerPerson2"
        Me.lblAssignmentPerPerson2.Size = New System.Drawing.Size(138, 40)
        Me.lblAssignmentPerPerson2.TabIndex = 131
        Me.lblAssignmentPerPerson2.Text = "aUEC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAssignmentPerPerson2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAssignmentMiner
        '
        Me.btnAssignmentMiner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignmentMiner.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignmentMiner.ForeColor = System.Drawing.Color.Black
        Me.btnAssignmentMiner.Location = New System.Drawing.Point(1066, 558)
        Me.btnAssignmentMiner.Name = "btnAssignmentMiner"
        Me.btnAssignmentMiner.Size = New System.Drawing.Size(129, 28)
        Me.btnAssignmentMiner.TabIndex = 132
        Me.btnAssignmentMiner.Text = "Paid? "
        Me.btnAssignmentMiner.UseVisualStyleBackColor = True
        '
        'btnAssignmentScouts
        '
        Me.btnAssignmentScouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignmentScouts.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignmentScouts.ForeColor = System.Drawing.Color.Black
        Me.btnAssignmentScouts.Location = New System.Drawing.Point(1066, 648)
        Me.btnAssignmentScouts.Name = "btnAssignmentScouts"
        Me.btnAssignmentScouts.Size = New System.Drawing.Size(129, 28)
        Me.btnAssignmentScouts.TabIndex = 133
        Me.btnAssignmentScouts.Text = "Paid? "
        Me.btnAssignmentScouts.UseVisualStyleBackColor = True
        '
        'btnDeletePaid
        '
        Me.btnDeletePaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePaid.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePaid.ForeColor = System.Drawing.Color.Black
        Me.btnDeletePaid.Location = New System.Drawing.Point(1247, 665)
        Me.btnDeletePaid.Name = "btnDeletePaid"
        Me.btnDeletePaid.Size = New System.Drawing.Size(155, 46)
        Me.btnDeletePaid.TabIndex = 134
        Me.btnDeletePaid.Text = "Reset paid"
        Me.btnDeletePaid.UseVisualStyleBackColor = True
        '
        'Jobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1447, 746)
        Me.Controls.Add(Me.btnDeletePaid)
        Me.Controls.Add(Me.btnAssignmentScouts)
        Me.Controls.Add(Me.btnAssignmentMiner)
        Me.Controls.Add(Me.lblAssignmentPerPerson2)
        Me.Controls.Add(Me.lblAssignmentRaw2)
        Me.Controls.Add(Me.lblAssignmentCosts2)
        Me.Controls.Add(Me.btnDeleteJob)
        Me.Controls.Add(Me.btnDeleteAssignments)
        Me.Controls.Add(Me.lblAssignmentScouts)
        Me.Controls.Add(Me.lblAssignmentMiner)
        Me.Controls.Add(Me.cbAssignmentScouts)
        Me.Controls.Add(Me.cbAssignmentMiner)
        Me.Controls.Add(Me.lblAssignmentCosts)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.lblAssignmentHeaderCosts)
        Me.Controls.Add(Me.lblAssignmentPerPerson)
        Me.Controls.Add(Me.lblAssignmentRaw)
        Me.Controls.Add(Me.pbRefinedProfit)
        Me.Controls.Add(Me.lblAssignmentHeaderPerPerson)
        Me.Controls.Add(Me.pbRawProfit)
        Me.Controls.Add(Me.lblAssignmentHeaderRaw)
        Me.Controls.Add(Me.lblBusiness)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.btnSaveTask)
        Me.Controls.Add(Me.btnResetTask)
        Me.Controls.Add(Me.lblTitleJobAssignment)
        Me.Controls.Add(Me.tbPriceRefined1)
        Me.Controls.Add(Me.tbPriceRaw1)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.lblPriceRefined)
        Me.Controls.Add(Me.lblPriceRaw)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.tbMass)
        Me.Controls.Add(Me.lblMass)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblJobsDate)
        Me.Controls.Add(Me.lblJobsTitleDate)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblJobsCosts)
        Me.Controls.Add(Me.lblJobsTitleCosts)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblJobsStation)
        Me.Controls.Add(Me.lblJobsTitleStation)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblJobsNumber)
        Me.Controls.Add(Me.lblJobsTitleNumber)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.btnDeleteScout)
        Me.Controls.Add(Me.btnAddScout)
        Me.Controls.Add(Me.btnDeleteMiner)
        Me.Controls.Add(Me.btnAddMiner)
        Me.Controls.Add(Me.cbScout)
        Me.Controls.Add(Me.cbMiner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbStonecSCU)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.tbScout)
        Me.Controls.Add(Me.tbMiner)
        Me.Controls.Add(Me.lblScouts)
        Me.Controls.Add(Me.lblMiner)
        Me.Controls.Add(Me.cbCosts)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.cbStation)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.lvJobs)
        Me.Controls.Add(Me.btnQuotes)
        Me.Controls.Add(Me.btnPriceList)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnJobs)
        Me.Controls.Add(Me.btnCalculator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Jobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jobs"
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRefinedProfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRawProfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lvJobs As ListView
    Friend WithEvents chNumber As ColumnHeader
    Friend WithEvents chDate As ColumnHeader
    Friend WithEvents chStation As ColumnHeader
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents lblStation As Label
    Friend WithEvents cbStation As ComboBox
    Friend WithEvents lblCosts As Label
    Friend WithEvents cbCosts As ComboBox
    Friend WithEvents lblMiner As Label
    Friend WithEvents lblScouts As Label
    Friend WithEvents tbMiner As TextBox
    Friend WithEvents tbScout As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbStonecSCU As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents cbMiner As ComboBox
    Friend WithEvents cbScout As ComboBox
    Friend WithEvents btnAddMiner As Button
    Friend WithEvents btnDeleteMiner As Button
    Friend WithEvents btnAddScout As Button
    Friend WithEvents btnDeleteScout As Button
    Friend WithEvents chRCosts As ColumnHeader
    Friend WithEvents chPeople As ColumnHeader
    Friend WithEvents lblInformation As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblJobsTitleNumber As Label
    Friend WithEvents lblJobsNumber As Label
    Friend WithEvents lblJobsStation As Label
    Friend WithEvents lblJobsTitleStation As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblJobsDate As Label
    Friend WithEvents lblJobsTitleDate As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblJobsCosts As Label
    Friend WithEvents lblJobsTitleCosts As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblHelp As Label
    Friend WithEvents tbPriceRefined1 As TextBox
    Friend WithEvents tbPriceRaw1 As TextBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents lblPriceRefined As Label
    Friend WithEvents lblPriceRaw As Label
    Friend WithEvents lblType As Label
    Friend WithEvents tbMass As TextBox
    Friend WithEvents lblMass As Label
    Friend WithEvents lblTitleJobAssignment As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnSaveTask As Button
    Friend WithEvents btnResetTask As Button
    Friend WithEvents lblBusiness As Label
    Friend WithEvents lblAssignmentPerPerson As Label
    Friend WithEvents lblAssignmentRaw As Label
    Friend WithEvents pbRefinedProfit As PictureBox
    Friend WithEvents lblAssignmentHeaderPerPerson As Label
    Friend WithEvents pbRawProfit As PictureBox
    Friend WithEvents lblAssignmentHeaderRaw As Label
    Friend WithEvents lblAssignmentCosts As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblAssignmentHeaderCosts As Label
    Friend WithEvents cbAssignmentMiner As ComboBox
    Friend WithEvents cbAssignmentScouts As ComboBox
    Friend WithEvents lblAssignmentMiner As Label
    Friend WithEvents lblAssignmentScouts As Label
    Friend WithEvents btnDeleteAssignments As Button
    Friend WithEvents btnDeleteJob As Button
    Friend WithEvents lblAssignmentCosts2 As Label
    Friend WithEvents lblAssignmentRaw2 As Label
    Friend WithEvents lblAssignmentPerPerson2 As Label
    Friend WithEvents btnAssignmentMiner As Button
    Friend WithEvents btnAssignmentScouts As Button
    Friend WithEvents btnDeletePaid As Button
End Class
