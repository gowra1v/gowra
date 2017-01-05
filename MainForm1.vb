Imports System.Data.OleDb
Public Class MainForm1
    Public myConnToAccess As OleDbConnection
    Dim mySQLCommand As OleDbCommand
    Dim mySQLStrg As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Friend department As String
    Friend employeename As String
    Dim query As String
    Private Sub MainForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        department = MainForm.departmentname

        myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vamsi\Desktop\Spring 2016\BIS_628\BIS_628\bis628.accdb")
        myConnToAccess.Open()
        ds = New DataSet
        tables = ds.Tables
        query = "SELECT fullname FROM (depts INNER JOIN employees ON depts.dept_id = employees.dept_id) INNER JOIN list_employees ON employees.emp_id = list_employees.emp_id where department_name= '" + department + "'"
        da = New OleDbDataAdapter(query, myConnToAccess)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        If view1.Count = 0 Then
            MessageBox.Show("NO employe in this department")
        Else
            With Employee
                .DataSource = ds.Tables("Items")
                .DisplayMember = "fullname"
                .ValueMember = "fullname"
                .SelectedIndex = 0
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If
    End Sub

    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        employeename = Employee.Text

        MainForm2.ShowDialog()


            
    End Sub
End Class