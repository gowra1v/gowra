Imports System.Data.OleDb

Public Class MainForm2



    Public myConnToAccess As OleDbConnection
    Dim mySQLCommand As OleDbCommand
    Dim mySQLStrg As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Friend employee_name As String
    Dim query1 As String
    Dim commision As Decimal
    Dim sales As Decimal
    

    Private Sub calculate_Click(sender As System.Object, e As System.EventArgs) Handles calculate.Click
        If totalsales.Text = "" Then
            MessageBox.Show("Give Total Sales value")
            Else

            employee_name = MainForm1.employeename
            sales = totalsales.Text
            myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vamsi\Desktop\Spring 2016\BIS_628\BIS_628\bis628.accdb")
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            query1 = "SELECT commission_rate FROM (depts INNER JOIN employees ON depts.dept_id = employees.dept_id) INNER JOIN list_employees ON employees.emp_id = list_employees.emp_id where fullname= '" + employee_name + "'"
            da = New OleDbDataAdapter(query1, myConnToAccess)
            da.Fill(ds, "Items")
            Dim view1 As New DataView(tables(0))
            commision = ds.Tables(0).Rows(0).Item(0)
            comm.Text = (commision * sales) / 100
        End If
    End Sub

    Private Sub Report_Click(sender As System.Object, e As System.EventArgs) Handles Report.Click
        'Begin the process for print preview of the selected item.
        If MainForm.Department.SelectedIndex = -1 Then
            'Select (None) if nothing selected.
            MainForm.Department.SelectedIndex = 0
        End If
        If MainForm1.Employee.SelectedIndex <> -1 Then
            'Item selected.

            PrintPreviewDialog1.Document = PrintSelectedPrintDocument

            PrintPreviewDialog1.ShowDialog()
        Else
            'No item selected.
            MessageBox.Show("Select Department and Employee.", "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub PrintSelectedPrintDocument_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSelectedPrintDocument.PrintPage

        'Handle printing and print previews when printing selected items. 
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintlocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintlocationSingle As Single = e.MarginBounds.Top
        Dim PrintlineString As String ' Set up and display heading lines'. 

        e.Graphics.DrawString(PrintlineString, HeadingFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)

        VerticalPrintlocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintlineString, HeadingFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        'Leave a blank line between the heading and detail line. 
        VerticalPrintlocationSingle += LineHeightSingle * 2
        ' Set up the selected line. 
        PrintlineString = "Department:" & MainForm.Department.Text & Environment.NewLine & "Employee:" & MainForm1.Employee.Text & Environment.NewLine & "TotalSales:" & totalsales.Text & Environment.NewLine & "Commission:" & comm.Text
        ' Send the line to the graphics page object. 
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
    End Sub
End Class