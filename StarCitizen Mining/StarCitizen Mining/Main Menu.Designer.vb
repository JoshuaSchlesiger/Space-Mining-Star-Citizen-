<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_menu))
        Me.lblHeadline = New System.Windows.Forms.Label()
        Me.lblSpaceCalculator = New System.Windows.Forms.Label()
        Me.lblJobs = New System.Windows.Forms.Label()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.lblQuotes = New System.Windows.Forms.Label()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbJobs = New System.Windows.Forms.PictureBox()
        Me.pbSpaceCalculator = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSpaceCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeadline
        '
        Me.lblHeadline.AutoSize = True
        Me.lblHeadline.Font = New System.Drawing.Font("Bell MT", 15.75!)
        Me.lblHeadline.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeadline.Location = New System.Drawing.Point(233, 9)
        Me.lblHeadline.Name = "lblHeadline"
        Me.lblHeadline.Size = New System.Drawing.Size(341, 75)
        Me.lblHeadline.TabIndex = 0
        Me.lblHeadline.Text = "Welcome to SpaceMining, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "calculating stone values, saving jobs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and calculating" &
    " costs can be found here"
        Me.lblHeadline.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSpaceCalculator
        '
        Me.lblSpaceCalculator.AutoSize = True
        Me.lblSpaceCalculator.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Underline)
        Me.lblSpaceCalculator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSpaceCalculator.Location = New System.Drawing.Point(100, 108)
        Me.lblSpaceCalculator.Name = "lblSpaceCalculator"
        Me.lblSpaceCalculator.Size = New System.Drawing.Size(159, 24)
        Me.lblSpaceCalculator.TabIndex = 2
        Me.lblSpaceCalculator.Text = "SpaceCalculator"
        '
        'lblJobs
        '
        Me.lblJobs.AutoSize = True
        Me.lblJobs.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Underline)
        Me.lblJobs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJobs.Location = New System.Drawing.Point(587, 108)
        Me.lblJobs.Name = "lblJobs"
        Me.lblJobs.Size = New System.Drawing.Size(52, 24)
        Me.lblJobs.TabIndex = 4
        Me.lblJobs.Text = "Jobs"
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Underline)
        Me.lblPrices.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrices.Location = New System.Drawing.Point(149, 454)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(67, 24)
        Me.lblPrices.TabIndex = 6
        Me.lblPrices.Text = "Prices"
        '
        'lblQuotes
        '
        Me.lblQuotes.AutoSize = True
        Me.lblQuotes.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Underline)
        Me.lblQuotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuotes.Location = New System.Drawing.Point(566, 454)
        Me.lblQuotes.Name = "lblQuotes"
        Me.lblQuotes.Size = New System.Drawing.Size(73, 24)
        Me.lblQuotes.TabIndex = 8
        Me.lblQuotes.Text = "Quotes"
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.Font = New System.Drawing.Font("Bell MT", 15.75!, System.Drawing.FontStyle.Italic)
        Me.lblSupport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSupport.Location = New System.Drawing.Point(302, 789)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(192, 48)
        Me.lblSupport.TabIndex = 9
        Me.lblSupport.Text = "Support me on Twitch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DochSergeantTV"
        Me.lblSupport.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StarCitizen_Mining.My.Resources.Resources.feedback
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(459, 493)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 278)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StarCitizen_Mining.My.Resources.Resources.pricing
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(32, 493)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'pbJobs
        '
        Me.pbJobs.Image = Global.StarCitizen_Mining.My.Resources.Resources.smart_contracts__2_
        Me.pbJobs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbJobs.Location = New System.Drawing.Point(459, 135)
        Me.pbJobs.Name = "pbJobs"
        Me.pbJobs.Size = New System.Drawing.Size(303, 299)
        Me.pbJobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbJobs.TabIndex = 3
        Me.pbJobs.TabStop = False
        '
        'pbSpaceCalculator
        '
        Me.pbSpaceCalculator.Image = Global.StarCitizen_Mining.My.Resources.Resources.mining
        Me.pbSpaceCalculator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbSpaceCalculator.Location = New System.Drawing.Point(32, 147)
        Me.pbSpaceCalculator.Name = "pbSpaceCalculator"
        Me.pbSpaceCalculator.Size = New System.Drawing.Size(303, 278)
        Me.pbSpaceCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSpaceCalculator.TabIndex = 1
        Me.pbSpaceCalculator.TabStop = False
        '
        'Main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(791, 846)
        Me.Controls.Add(Me.lblSupport)
        Me.Controls.Add(Me.lblQuotes)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblPrices)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblJobs)
        Me.Controls.Add(Me.pbJobs)
        Me.Controls.Add(Me.lblSpaceCalculator)
        Me.Controls.Add(Me.pbSpaceCalculator)
        Me.Controls.Add(Me.lblHeadline)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpaceMining"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSpaceCalculator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeadline As Label
    Friend WithEvents pbSpaceCalculator As PictureBox
    Friend WithEvents lblSpaceCalculator As Label
    Friend WithEvents pbJobs As PictureBox
    Friend WithEvents lblJobs As Label
    Friend WithEvents lblPrices As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblQuotes As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblSupport As Label
End Class
