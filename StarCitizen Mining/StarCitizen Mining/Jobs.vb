Imports System.ComponentModel
Imports Microsoft.VisualBasic.FileIO
Imports System
Imports System.Text

Public Class Jobs

    Dim HideMain As Boolean
    Dim IndexMiner As Integer
    Dim IndexScout As Integer
    Dim Number As Integer
    Dim txt As String
    Dim Persons As Integer

    Private Sub Jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.FromArgb(47, 53, 66)
        btnCalculator.BackColor = Color.FromArgb(255, 71, 87)
        btnMainMenu.BackColor = Color.FromArgb(255, 71, 87)
        btnPriceList.BackColor = Color.FromArgb(255, 71, 87)
        btnQuotes.BackColor = Color.FromArgb(255, 71, 87)
        btnJobs.BackColor = Color.FromArgb(46, 213, 115)

        cbStation.BackColor = Color.FromArgb(116, 125, 140)
        cbCosts.BackColor = Color.FromArgb(116, 125, 140)
        lblStation.ForeColor = Color.FromArgb(164, 176, 190)
        lblCosts.ForeColor = Color.FromArgb(164, 176, 190)
        lblMiner.ForeColor = Color.FromArgb(164, 176, 190)
        lblScouts.ForeColor = Color.FromArgb(164, 176, 190)


        btnReset.BackColor = Color.FromArgb(255, 71, 87)
        btnSave.BackColor = Color.FromArgb(46, 213, 115)

        btnSaveTask.BackColor = Color.FromArgb(46, 213, 115)
        btnResetTask.BackColor = Color.FromArgb(255, 71, 87)


        tbMiner.BackColor = Color.FromArgb(116, 125, 140)
        cbMiner.BackColor = Color.FromArgb(116, 125, 140)
        btnAddMiner.BackColor = Color.FromArgb(46, 213, 115)
        btnDeleteMiner.BackColor = Color.FromArgb(255, 71, 87)

        tbScout.BackColor = Color.FromArgb(116, 125, 140)
        cbScout.BackColor = Color.FromArgb(116, 125, 140)
        btnAddScout.BackColor = Color.FromArgb(46, 213, 115)
        btnDeleteScout.BackColor = Color.FromArgb(255, 71, 87)

        lvJobs.BackColor = Color.FromArgb(116, 125, 140)

        lblJobsTitleNumber.ForeColor = Color.FromArgb(164, 176, 190)
        lblJobsTitleStation.ForeColor = Color.FromArgb(164, 176, 190)
        lblJobsTitleCosts.ForeColor = Color.FromArgb(164, 176, 190)
        lblJobsTitleDate.ForeColor = Color.FromArgb(164, 176, 190)

        lblJobsDate.ForeColor = Color.FromArgb(46, 213, 115)
        lblJobsNumber.ForeColor = Color.FromArgb(46, 213, 115)
        lblJobsStation.ForeColor = Color.FromArgb(46, 213, 115)
        lblJobsCosts.ForeColor = Color.FromArgb(46, 213, 115)

        lblHelp.ForeColor = Color.FromArgb(164, 176, 190)

        lblType.ForeColor = Color.FromArgb(164, 176, 190)
        lblPriceRaw.ForeColor = Color.FromArgb(164, 176, 190)
        lblPriceRefined.ForeColor = Color.FromArgb(164, 176, 190)
        lblMass.ForeColor = Color.FromArgb(164, 176, 190)

        cbType.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRaw1.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRefined1.BackColor = Color.FromArgb(116, 125, 140)
        tbMass.BackColor = Color.FromArgb(116, 125, 140)

        lblAssignmentHeaderCosts.ForeColor = Color.FromArgb(116, 125, 140)
        lblAssignmentHeaderPerPerson.ForeColor = Color.FromArgb(116, 125, 140)
        lblAssignmentHeaderRaw.ForeColor = Color.FromArgb(116, 125, 140)

        lblAssignmentCosts.ForeColor = Color.FromArgb(255, 71, 87)
        lblAssignmentRaw.ForeColor = Color.FromArgb(46, 213, 115)
        lblAssignmentPerPerson.ForeColor = Color.FromArgb(46, 213, 115)

        lblAssignmentCosts2.ForeColor = Color.FromArgb(255, 71, 87)
        lblAssignmentRaw2.ForeColor = Color.FromArgb(46, 213, 115)
        lblAssignmentPerPerson2.ForeColor = Color.FromArgb(46, 213, 115)

        lblAssignmentMiner.ForeColor = Color.FromArgb(164, 176, 190)
        lblAssignmentScouts.ForeColor = Color.FromArgb(164, 176, 190)
        cbAssignmentMiner.BackColor = Color.FromArgb(116, 125, 140)
        cbAssignmentScouts.BackColor = Color.FromArgb(116, 125, 140)
        btnDeleteAssignments.BackColor = Color.FromArgb(255, 71, 87)
        btnDeleteJob.BackColor = Color.FromArgb(255, 71, 87)
        btnDeletePaid.BackColor = Color.FromArgb(255, 71, 87)

        Invisible()

        LoadJobs()

    End Sub

#Region "Invisible"
    Private Sub Invisible()

        lblMass.Visible = False
        lblType.Visible = False
        lblPriceRaw.Visible = False
        lblPriceRefined.Visible = False
        tbMass.Visible = False
        cbType.Visible = False
        tbPriceRaw1.Visible = False
        tbPriceRefined1.Visible = False
        btnSaveTask.Visible = False
        btnResetTask.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        lblTitleJobAssignment.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        lblJobsTitleCosts.Visible = False
        lblJobsTitleDate.Visible = False
        lblJobsTitleNumber.Visible = False
        lblJobsTitleStation.Visible = False
        lblBusiness.Visible = False
        lblAssignmentMiner.Visible = False
        lblAssignmentScouts.Visible = False
        cbAssignmentMiner.Visible = False
        cbAssignmentScouts.Visible = False
        btnDeleteAssignments.Visible = False
        btnDeleteJob.Visible = False
        PictureBox8.Visible = False
        pbRawProfit.Visible = False
        pbRefinedProfit.Visible = False
        lblAssignmentHeaderCosts.Visible = False
        lblAssignmentHeaderPerPerson.Visible = False
        lblAssignmentHeaderRaw.Visible = False
        lblAssignmentCosts.Visible = False
        lblAssignmentRaw.Visible = False
        lblAssignmentPerPerson.Visible = False
        lblInformation.Visible = False
        btnAssignmentMiner.Visible = False
        btnAssignmentScouts.Visible = False

        Me.Size = New Size(825, 785)
    End Sub
#End Region

#Region "Navigation"
    Private Sub Jobs_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If HideMain = False Then
            Main_menu.Show()
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        HideMain = True
        Me.Close()
        Main_menu.Show()
    End Sub

    Private Sub btnPriceList_Click(sender As Object, e As EventArgs) Handles btnPriceList.Click
        HideMain = True
        Me.Close()
        PriceList.Show()
    End Sub

    Private Sub btnQuotes_Click(sender As Object, e As EventArgs) Handles btnQuotes.Click
        HideMain = True
        Me.Close()
        Quotes.Show()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        HideMain = True
        Me.Close()
        Space_Calculator.Show()
    End Sub
#End Region

#Region "DeletePeople"

    Private Sub btnDeleteMiner_Click(sender As Object, e As EventArgs) Handles btnDeleteMiner.Click
        Try
            cbMiner.Items.RemoveAt(IndexMiner)
            cbMiner.Text = ""
        Catch ex As Exception
            MessageBox.Show("Please select an item in the upper combo box", "Error")
        End Try

    End Sub

    Private Sub cbMiner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMiner.SelectedIndexChanged
        IndexMiner = cbMiner.SelectedIndex
    End Sub

    Private Sub cbScout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbScout.SelectedIndexChanged
        IndexScout = cbScout.SelectedIndex
    End Sub

    Private Sub btnDeleteScout_Click(sender As Object, e As EventArgs) Handles btnDeleteScout.Click
        Try
            cbScout.Items.RemoveAt(IndexScout)
            cbScout.Text = ""
        Catch ex As Exception
            MessageBox.Show("Please select an item in the upper combo box", "Error")
        End Try

    End Sub
#End Region

#Region "Add"
    Private Sub btnAddMiner_Click(sender As Object, e As EventArgs) Handles btnAddMiner.Click
        AddMiner()
    End Sub
    Private Sub btnAddScout_Click(sender As Object, e As EventArgs) Handles btnAddScout.Click
        AddScout()
    End Sub

    Private Sub tbMiner_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMiner.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddMiner()
        End If
    End Sub

    Private Sub tbScout_KeyDown(sender As Object, e As KeyEventArgs) Handles tbScout.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddScout()
        End If
    End Sub


    Sub AddMiner()

        If tbMiner.Text <> "" Then
            cbMiner.Items.Add(tbMiner.Text)
            cbMiner.Text = tbMiner.Text
            tbMiner.Text = ""
        Else
            MessageBox.Show("Textbox can`t be empty", "Error")
        End If

    End Sub

    Sub AddScout()
        If tbScout.Text <> "" Then
            cbScout.Items.Add(tbScout.Text)
            cbScout.Text = tbScout.Text
            tbScout.Text = ""
        Else
            MessageBox.Show("Textbox can`t be empty", "Error")
        End If

    End Sub
#End Region

#Region "Save"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim str As String
        Dim check As Boolean
        str = cbStation.Text

        If str.Contains("!") Then
            MessageBox.Show("Never use a '!' it is needed for saving data", "Error")
            check = True
        End If
        str = cbCosts.Text
        If str.Contains("!") Then
            MessageBox.Show("Never use a '!' it is needed for saving data", "Error")
            check = True
        End If
        str = cbMiner.Text
        If str.Contains("!") Then
            MessageBox.Show("Never use a '!' it is needed for saving data", "Error")
            check = True
        End If
        str = cbScout.Text
        If str.Contains("!") Then
            MessageBox.Show("Never use a '!' it is needed for saving data", "Error")
            check = True
        End If

        If check = False Then
            If cbStation.Text <> "" And cbCosts.Text <> "" And cbMiner.Text <> "" Then
                ValuesRead()
                ValuesWrite()
                Save(Number)
                ResetBox()
                LoadJobs()
            Else
                MessageBox.Show("Please fill out all fields", "Error")
            End If
        End If
        check = False

    End Sub


    Sub Save(Tasknumber As Integer)
        My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Jobs")
        Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & Tasknumber & ".csv")

        objWriter.Write("!" & Tasknumber & "!")
        objWriter.Write(DateTime.Now.ToString(“dd.MM.yyyy”) & "!")
        objWriter.Write(cbStation.Text & "!")
        objWriter.Write(cbCosts.Text & "!")
        objWriter.Write(cbMiner.Items.Count + cbScout.Items.Count & "!")
        objWriter.Close()

        objWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & Tasknumber & "_People" & ".csv")
        objWriter.Write("!Miner")

        For Each item As String In cbMiner.Items
            objWriter.Write("!" & item)
        Next

        objWriter.Write("!Scouts")
        For Each item2 As String In cbScout.Items
            objWriter.Write("!" & item2)
        Next
        objWriter.Close()

    End Sub

    Sub ValuesRead()

        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Values/Values.csv")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("!")

                Dim currentRow As String()
                Dim i As Integer

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String


                    For Each currentField In currentRow

                        Select Case i
                            Case 1
                                Number = currentField
                        End Select
                        i += 1
                    Next

                End While
                i = 0

            End Using

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ValuesWrite()
        Number += 1

        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Values/Values.csv")
        Catch ex As Exception

        End Try

        My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Values")
        Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Values/Values.csv")

        If IO.File.Exists("SpaceMiner/Database/Values/Values.csv") Then
            objWriter.Write("!" & Number & "!")
        End If
        objWriter.Close()
    End Sub


#End Region

#Region "Load"
    Private Sub LoadJobs()

        lvJobs.Items.Clear()

        Dim Jobnumber As Integer
        Dim Time As String
        Dim Station As String
        Dim Costs As String
        Dim peopleCount As Integer

        Dim Counter As Integer
        Dim Counter2 As Integer

        ValuesRead()

        Counter = Number

        While Counter > 0

            If IO.File.Exists("SpaceMiner/Database/Jobs/Job_No" & Counter & ".csv") Then

                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Jobs/Job_No" & Counter & ".csv")
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters("!")

                    Dim currentRow As String()
                    Dim i As Integer

                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadFields()
                        Dim currentField As String


                        For Each currentField In currentRow

                            Select Case i
                                Case 1
                                    Jobnumber = currentField
                                Case 2
                                    Time = currentField
                                Case 3
                                    Station = currentField
                                Case 4
                                    Costs = currentField
                                Case 5
                                    peopleCount = currentField
                            End Select
                            i += 1
                        Next

                    End While
                    i = 0
                End Using

                lvJobs.Items.Add(Jobnumber)
                lvJobs.Items(Counter2).SubItems.Add(Time)
                lvJobs.Items(Counter2).SubItems.Add(Station)
                lvJobs.Items(Counter2).SubItems.Add(Costs)
                lvJobs.Items(Counter2).SubItems.Add(peopleCount)
                Counter2 += 1


            End If

            Counter -= 1
        End While

    End Sub
#End Region

#Region "Listinfo"
    Private Sub lvJobs_Click(sender As Object, e As EventArgs) Handles lvJobs.Click
        txt = lvJobs.SelectedItems(0).Text
        lblJobsNumber.Text = txt

        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Jobs/Job_No" & txt & ".csv")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("!")

                Dim currentRow As String()
                Dim i As Integer

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String


                    For Each currentField In currentRow

                        Select Case i
                            Case 2
                                lblJobsDate.Text = currentField
                            Case 3
                                lblJobsStation.Text = currentField
                            Case 4
                                lblJobsCosts.Text = currentField
                            Case 5
                                Persons = currentField
                        End Select
                        i += 1
                    Next

                End While
                i = 0

            End Using

        Catch ex As Exception

        End Try

        tbMass.Text = ""
        cbType.Text = ""
        tbPriceRaw1.Text = 0
        tbPriceRefined1.Text = 0

        lblMass.Visible = True
        lblType.Visible = True
        lblPriceRaw.Visible = True
        lblPriceRefined.Visible = True
        tbMass.Visible = True
        cbType.Visible = True
        tbPriceRaw1.Visible = True
        tbPriceRefined1.Visible = True
        btnSaveTask.Visible = True
        btnResetTask.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        lblTitleJobAssignment.Visible = True
        lblBusiness.Visible = True
        lblAssignmentMiner.Visible = True
        lblAssignmentScouts.Visible = True
        cbAssignmentMiner.Visible = True
        cbAssignmentScouts.Visible = True
        btnDeleteAssignments.Visible = True
        btnDeleteJob.Visible = True
        PictureBox8.Visible = True
        pbRawProfit.Visible = True
        pbRefinedProfit.Visible = True
        lblAssignmentHeaderCosts.Visible = True
        lblAssignmentHeaderPerPerson.Visible = True
        lblAssignmentHeaderRaw.Visible = True
        lblAssignmentCosts.Visible = True
        lblAssignmentRaw.Visible = True
        lblAssignmentPerPerson.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        lblJobsTitleCosts.Visible = True
        lblJobsTitleDate.Visible = True
        lblJobsTitleNumber.Visible = True
        lblJobsTitleStation.Visible = True
        lblInformation.Visible = True
        btnAssignmentMiner.Visible = True
        btnAssignmentScouts.Visible = True

        Me.Size = New Size(1463, 785)

        CalcAssignment()
        ReadPeople()

    End Sub

#End Region

#Region "ResetBox"

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ResetBox()

    End Sub

    Sub ResetBox()

        cbStation.Text = ""
        cbCosts.Text = ""
        tbMiner.Text = ""
        tbScout.Text = ""
        cbMiner.Items.Clear()
        cbMiner.Text = ""
        cbScout.Items.Clear()
        cbScout.Text = ""

    End Sub




#End Region

#Region "TypeValue"
    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        Dim x As Integer = cbType.SelectedIndex

        Select Case x
            Case 0
                Read(1, 1)
            Case 1
                Read(2, 1)
            Case 2
                Read(3, 1)
            Case 3
                Read(4, 1)
            Case 4
                Read(5, 1)
            Case 5
                Read(6, 1)
            Case 6
                Read(7, 1)
            Case 7
                Read(8, 1)
            Case 8
                Read(9, 1)
            Case 9
                Read(10, 1)
        End Select

    End Sub
#End Region

#Region "Read"

    Private Sub Read(type As Integer, line As Integer)

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Pricelist/RawPrices.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("!")

            Dim currentRow As String()

            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
                Dim currentField As String
                Dim i As Integer

                For Each currentField In currentRow

                    If i = type Then
                        If line = 1 Then
                            tbPriceRaw1.Text = currentField
                        End If
                    End If

                    i += 1

                Next

                i = 0
            End While
        End Using

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Pricelist/RefinedPrices.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("!")

            Dim currentRow As String()

            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
                Dim currentField As String
                Dim i As Integer

                For Each currentField In currentRow

                    If i = type Then
                        If line = 1 Then
                            tbPriceRefined1.Text = currentField
                        End If
                    End If

                    i += 1

                Next

                i = 0
            End While

        End Using

    End Sub


#End Region

#Region "Assignment"
    Private Sub btnResetTask_Click(sender As Object, e As EventArgs) Handles btnResetTask.Click
        tbMass.Text = ""
        cbType.Text = ""
        tbPriceRaw1.Text = 0
        tbPriceRefined1.Text = 0
    End Sub

    Private Sub btnSaveTask_Click(sender As Object, e As EventArgs) Handles btnSaveTask.Click
        If tbMass.Text = "" Or cbType.Text = "" Then

            MessageBox.Show("Please fill out all fields", "Error")

        Else

            If IsNumeric(tbMass.Text) Then
                My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Jobs")
                Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_Assignment" & ".csv")

                objWriter.Write("!" & tbMass.Text & "!" & tbPriceRefined1.Text)
                objWriter.Close()

                tbMass.Text = ""
                cbType.Text = ""
                tbPriceRaw1.Text = 0
                tbPriceRefined1.Text = 0
            Else
                MessageBox.Show("Only numbers are allowed as quantity", "Error")
                tbMass.Text = ""
            End If

        End If

        CalcAssignment()
    End Sub

    Private Sub CalcAssignment()

        lblAssignmentRaw.Text = 0
        lblAssignmentCosts.Text = 0
        lblAssignmentPerPerson.Text = 0


        If IO.File.Exists("SpaceMiner/Database/Jobs/Job_No" & txt & "_Assignment" & ".csv") Then


            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Jobs/Job_No" & txt & "_Assignment" & ".csv")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("!")

                Dim currentRow As String()
                Dim i As Integer

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    Dim Mass As Double
                    Dim Price As Double
                    Dim Profit As Double

                    For Each currentField In currentRow

                        Select Case i
                            Case 1
                                Mass = currentField
                            Case 2
                                Price = currentField
                                Profit = Mass * Price
                                lblAssignmentRaw.Text += Profit
                                lblAssignmentCosts.Text += Mass * 2

                                If lblJobsCosts.Text = "Yes" Then
                                    lblAssignmentPerPerson.Text = (CInt(lblAssignmentRaw.Text) / Persons) - (CInt(lblAssignmentCosts.Text / Persons))
                                Else
                                    lblAssignmentPerPerson.Text = CInt(lblAssignmentRaw.Text) / Persons
                                End If

                                i = 0
                        End Select
                        i += 1


                    Next

                End While

                i = 0
            End Using

        End If
    End Sub

    Private Sub ReadPeople()

        cbAssignmentMiner.Items.Clear()
        cbAssignmentScouts.Items.Clear()


        If IO.File.Exists("SpaceMiner/Database/Jobs/Job_No" & txt & "_People" & ".csv") Then


            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Jobs/Job_No" & txt & "_People" & ".csv")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("!")

                Dim currentRow As String()
                Dim i As Integer

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    Dim buffer As Boolean

                    For Each currentField In currentRow

                        If i >= 2 Then
                            If currentField = "Scouts" Then
                                buffer = True
                            End If

                            If buffer Then
                                If currentField <> "Scouts" Then
                                    cbAssignmentScouts.Items.Add(currentField)
                                End If

                            ElseIf buffer = False Then
                                    cbAssignmentMiner.Items.Add(currentField)
                            End If
                        End If

                        i += 1
                    Next

                End While

                i = 0
            End Using

        End If
    End Sub

    Private Sub cbAssignmentMiner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAssignmentMiner.SelectedIndexChanged

        btnAssignmentMiner.BackColor = Color.FromArgb(255, 71, 87)

        If IO.File.Exists("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv") Then
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("!")

                Dim currentRow As String()

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    Dim buffer As Boolean

                    For Each currentField In currentRow

                        If cbAssignmentMiner.Text = currentField Then
                            btnAssignmentMiner.BackColor = Color.FromArgb(46, 213, 115)
                            btnAssignmentMiner.Enabled = False
                            buffer = True
                        ElseIf buffer = False Then
                            btnAssignmentMiner.Enabled = True
                            btnAssignmentMiner.BackColor = Color.FromArgb(255, 71, 87)
                        End If
                    Next

                    buffer = False
                End While

            End Using
        Else
            My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Jobs")
            Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")
            objWriter.Close()
        End If
    End Sub

    Private Sub btnAssignmentMiner_Click(sender As Object, e As EventArgs) Handles btnAssignmentMiner.Click

        If cbAssignmentMiner.Text = "" Then
            MessageBox.Show("Please select a miner", "Error")
            btnAssignmentMiner.Enabled = True
        Else
            Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")

            objWriter.Write(cbAssignmentMiner.Text & "!")
            objWriter.Close()

            btnAssignmentMiner.Enabled = False
            btnAssignmentMiner.BackColor = Color.FromArgb(46, 213, 115)
        End If


    End Sub

    Private Sub btnAssignmentScouts_Click(sender As Object, e As EventArgs) Handles btnAssignmentScouts.Click
        If cbAssignmentScouts.Text = "" Then
            MessageBox.Show("Please select a scout", "Error")
            btnAssignmentScouts.Enabled = True
        Else
            Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")

            objWriter.Write(cbAssignmentScouts.Text & "!")
            objWriter.Close()

            btnAssignmentScouts.Enabled = False
            btnAssignmentScouts.BackColor = Color.FromArgb(46, 213, 115)
        End If
    End Sub

    Private Sub cbAssignmentScouts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAssignmentScouts.SelectedIndexChanged

        btnAssignmentScouts.BackColor = Color.FromArgb(255, 71, 87)

        If IO.File.Exists("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv") Then
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("!")

                Dim currentRow As String()

                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    Dim buffer As Boolean

                    For Each currentField In currentRow

                        If cbAssignmentScouts.Text = currentField Then
                            btnAssignmentScouts.BackColor = Color.FromArgb(46, 213, 115)
                            btnAssignmentScouts.Enabled = False
                            buffer = True
                        ElseIf buffer = False Then
                            btnAssignmentScouts.Enabled = True
                            btnAssignmentScouts.BackColor = Color.FromArgb(255, 71, 87)
                        End If
                    Next

                    buffer = False
                End While

            End Using
        Else
            My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Jobs")
            Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")
            objWriter.Close()
        End If
    End Sub

    Private Sub btnDeleteAssignments_Click(sender As Object, e As EventArgs) Handles btnDeleteAssignments.Click
        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_Assignment" & ".csv")
            lblAssignmentCosts.Text = 0
            lblAssignmentRaw.Text = 0
            lblAssignmentPerPerson.Text = 0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDeletePaid_Click(sender As Object, e As EventArgs) Handles btnDeletePaid.Click
        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")
            btnAssignmentMiner.BackColor = Color.FromArgb(255, 71, 87)
            btnAssignmentScouts.BackColor = Color.FromArgb(255, 71, 87)
            btnAssignmentScouts.Enabled = True
            btnAssignmentMiner.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteJob_Click(sender As Object, e As EventArgs) Handles btnDeleteJob.Click

        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & ".csv")
        Catch ex As Exception

        End Try

        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & "_Paid" & ".csv")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_Assignment" & ".csv")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Jobs/Job_No" & lblJobsNumber.Text & "_People" & ".csv")
        Catch ex As Exception

        End Try


        LoadJobs()

        Invisible()


    End Sub

#End Region

End Class