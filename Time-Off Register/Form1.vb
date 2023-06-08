Imports System.IO
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Public Class Form1

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Form1_Load1(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "HH:mm"

        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "HH:mm"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim timeIn As DateTime = DateTime.Parse(DateTimePicker2.Text)
        Dim timeOut As DateTime = DateTime.Parse(DateTimePicker3.Text)

        'PYEI Start and End Times
        Dim startTime_pyei As DateTime = DateTime.Parse("07:00:00")
        Dim endTime_mon_thurs As DateTime = DateTime.Parse("15:15:00")
        Dim endTime_frid As DateTime = DateTime.Parse("14:00:00")

        'WCED Start and End Times
        Dim wced_startTime As DateTime = DateTime.Parse("07:20:00")
        Dim wced_endTime_mon_wed As DateTime = DateTime.Parse("15:00:00")
        Dim wced_endTime_thurs As DateTime = DateTime.Parse("15:15:00")
        Dim wced_endTime_fri As DateTime = DateTime.Parse("13:00:00")

        Dim selectedDate As DateTime = DateTimePicker1.Value

        ' PYEI
        ' if you come in early (leave early,leave on time, leave late) Monday - Thursday
        If RadioButton1.Checked AndAlso selectedDate.DayOfWeek >= DayOfWeek.Monday AndAlso selectedDate.DayOfWeek <= DayOfWeek.Thursday AndAlso timeIn <= startTime_pyei Then
            Dim timeCompleted As TimeSpan = timeOut - endTime_mon_thurs

            Dim TimeOwed As TimeSpan = timeCompleted
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            'if you come in late (leave early, leave on time, leave late) Monday - Thursday
        ElseIf RadioButton1.Checked AndAlso selectedDate.DayOfWeek >= DayOfWeek.Monday AndAlso selectedDate.DayOfWeek <= DayOfWeek.Thursday Then
            Dim partTimeOwed As TimeSpan = timeIn - startTime_pyei
            Dim timeCompleted As TimeSpan = timeOut - endTime_mon_thurs

            Dim TimeOwed As TimeSpan = timeCompleted - partTimeOwed
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in early (leave early, leave on time, leave late) Friday
        ElseIf RadioButton1.Checked AndAlso selectedDate.DayOfWeek = DayOfWeek.Friday AndAlso timeIn <= startTime_pyei Then
            Dim timeCompleted As TimeSpan = timeOut - endTime_frid
            Dim TimeOwed As TimeSpan = timeCompleted
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in late (leave early, leave on time, leave late)
        ElseIf RadioButton1.Checked AndAlso selectedDate.DayOfWeek = DayOfWeek.Friday Then
            Dim partTimeOwed As TimeSpan = timeIn - startTime_pyei
            Dim timeCompleted As TimeSpan = timeOut - endTime_frid

            Dim TimeOwed As TimeSpan = timeCompleted - partTimeOwed
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)
        End If

        ' WCED
        ' If you come in early(leave early, leave on time, leave late) Monday to Wednesday
        If RadioButton2.Checked AndAlso selectedDate.DayOfWeek >= DayOfWeek.Monday AndAlso selectedDate.DayOfWeek <= DayOfWeek.Wednesday AndAlso timeIn <= wced_startTime Then
            Dim timeCompleted As TimeSpan = timeOut - wced_endTime_mon_wed

            Dim TimeOwed As TimeSpan = timeCompleted
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in late(leave early, leave on time, leave late) Monday to Wednesday
        ElseIf RadioButton2.Checked AndAlso selectedDate.DayOfWeek >= DayOfWeek.Monday AndAlso selectedDate.DayOfWeek <= DayOfWeek.Wednesday Then
            Dim partTimeOwed As TimeSpan = timeIn - wced_startTime
            Dim timeCompleted As TimeSpan = timeOut - wced_endTime_mon_wed

            Dim TimeOwed As TimeSpan = timeCompleted - partTimeOwed
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in early (leave early, leave on time, leave late) Thursday
        ElseIf RadioButton2.Checked AndAlso selectedDate.DayOfWeek = DayOfWeek.Thursday And timeIn <= wced_startTime Then
            Dim timeCompleted As TimeSpan = timeOut - wced_endTime_thurs

            Dim TimeOwed As TimeSpan = timeCompleted
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in late(leave early, leave on time, leave late) Thursday
        ElseIf RadioButton2.Checked AndAlso selectedDate.DayOfWeek = DayOfWeek.Thursday Then
            Dim partTimeOwed As TimeSpan = timeIn - wced_startTime
            Dim timeCompleted As TimeSpan = timeOut - wced_endTime_thurs

            Dim TimeOwed As TimeSpan = timeCompleted - partTimeOwed
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in early(leave early, leave on time, leave late) Friday
        ElseIf RadioButton2.Checked AndAlso selectedDate.DayOfWeek = DayOfWeek.Friday AndAlso timeIn <= wced_startTime Then
            Dim timeCompleted As TimeSpan = timeOut - wced_endTime_fri

            Dim TimeOwed As TimeSpan = timeCompleted
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)

            ' If you come in late (leave early, leave on time, leave late) Friday
        ElseIf RadioButton2.Checked AndAlso selectedDate.DayOfWeek = DayOfWeek.Friday Then
            Dim partTimeOwed As TimeSpan = timeIn - wced_startTime
            Dim timeCompleted As TimeSpan = timeOut - wced_endTime_fri

            Dim TimeOwed As TimeSpan = timeCompleted - partTimeOwed
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TimeOwed)
        End If

        ' General Assistants
        If RadioButton3.Checked Then
            Dim TotalHoursDaily As TimeSpan = timeOut - timeIn
            DataGridView1.Rows.Add(DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TotalHoursDaily)
        End If
    End Sub

    Private Sub Button2_Click2(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please type a file name")
            Return
        Else
            ' Create a new Excel workbook
            Dim spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create("C:\repos\EPS_Sign_In_Register\" + TextBox1.Text + ".xlsx", SpreadsheetDocumentType.Workbook)

            ' Add a new worksheet to the workbook
            Dim workbookPart As WorkbookPart = spreadsheetDocument.AddWorkbookPart()
            workbookPart.Workbook = New Workbook()

            Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
            worksheetPart.Worksheet = New Worksheet(New SheetData())

            Dim sheets As Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(Of Sheets)(New Sheets())

            ' Create a new sheet and specify the sheet ID
            Dim sheet As Sheet = New Sheet() With {
            .Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
            .SheetId = 1,
            .Name = "Sheet1"
        }
            sheets.Append(sheet)

            ' Get the worksheet data
            Dim sheetData As SheetData = worksheetPart.Worksheet.GetFirstChild(Of SheetData)()

            ' Set the column headers in the first row
            Dim headerRow As Row = New Row()

            For Each column As DataGridViewColumn In DataGridView1.Columns
                headerRow.AppendChild(CreateCell(column.HeaderText))
            Next

            sheetData.AppendChild(headerRow)

            ' Set the cell values from the DataGridView
            For Each dgvRow As DataGridViewRow In DataGridView1.Rows
                Dim newRow As Row = New Row()

                For Each cell As DataGridViewCell In dgvRow.Cells
                    If cell.Value IsNot Nothing Then
                        newRow.AppendChild(CreateCell(cell.Value.ToString()))
                    End If
                Next

                sheetData.AppendChild(newRow)
            Next

            ' Save the workbook
            workbookPart.Workbook.Save()

            ' Close the document
            spreadsheetDocument.Dispose()

            MessageBox.Show("Excel file saved successfully.")
        End If
    End Sub

    Private Function CreateCell(cellValue As String) As Cell
        Dim cell As Cell = New Cell()
        cell.DataType = CellValues.String
        cell.CellValue = New CellValue(cellValue)
        Return cell
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
    End Sub
End Class
