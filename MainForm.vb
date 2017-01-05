Imports System.Data.OleDb

Public Class MainForm
    Public myConnToAccess As OleDbConnection
    Dim mySQLCommand As OleDbCommand
    Dim mySQLStrg As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Friend departmentname As String


    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vamsi\Desktop\Spring 2016\BIS_628\BIS_628\bis628.accdb")
        myConnToAccess.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT depts.[department_name] FROM depts", myConnToAccess)
        da.Fill(ds, "Items")
        
            Dim view1 As New DataView(tables(0))
            With Department
                .DataSource = ds.Tables("Items")
                .DisplayMember = "department_name"
                .ValueMember = "department_name"
                .SelectedIndex = 0
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With



    End Sub

    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        departmentname = Department.Text

        If Department.Text = " " Then
            MessageBox.Show("Please select a department")
        Else
            MainForm1.Show()
        End If
    End Sub

    
End Class
