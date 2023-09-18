Imports System.IO
Imports System.Runtime.InteropServices
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports Microsoft.Office.Interop.Excel


Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Form1_Load1(sender As Object, e As EventArgs)
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "HH:mm"

        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "HH:mm"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.click
        Dim totalSpan As TimeSpan = TimeSpan.Zero

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cell As DataGridViewCell = row.Cells(3) ' Assuming column 4 is index 3

            If cell.Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(cell.Value.ToString()) Then
                Dim timeValue As String = cell.Value.ToString()

                Dim timeSpan As TimeSpan
                If TimeSpan.TryParse(timeValue, timeSpan) Then
                    totalSpan += timeSpan
                End If
            End If
        Next

        DataGridView1.Rows(0).Cells(5).Value = totalSpan.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Calculate the sum of negative time values in column 4
        Dim totalTime As TimeSpan = TimeSpan.Zero

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cell As DataGridViewCell = row.Cells(3) ' Assuming column 4 is at index 3

            If cell.Value IsNot Nothing AndAlso TypeOf cell.Value Is TimeSpan Then
                Dim timeValue As TimeSpan = CType(cell.Value, TimeSpan)
                If timeValue < TimeSpan.Zero Then
                    totalTime += timeValue
                End If
            End If
        Next

        ' Insert the sum into the first row of column 5
        If DataGridView1.Rows.Count > 0 Then
            Dim firstRow As DataGridViewRow = DataGridView1.Rows(0)
            Dim cell As DataGridViewCell = firstRow.Cells(4) ' Assuming column 5 is at index 4

            cell.Value = totalTime.ToString()
        End If

        MessageBox.Show("Sum of negative time values calculated and inserted into the first row of column 5.")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if the textbox is empty
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please enter a file name.")
            Return
        End If

        ' Create a new Excel workbook
        Dim spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create(Path.Combine("C:\repos\EPS_Sign_In_Register", TextBox1.Text & ".xlsx"), SpreadsheetDocumentType.Workbook)

        ' Add a new worksheet to the workbook
        Dim workbookPart As WorkbookPart = spreadsheetDocument.AddWorkbookPart()
        workbookPart.Workbook = New Spreadsheet.Workbook()

        Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
        worksheetPart.Worksheet = New Spreadsheet.Worksheet(New SheetData())

        Dim sheets As Spreadsheet.Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(Of Spreadsheet.Sheets)(New Spreadsheet.Sheets())

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
    End Sub

    Private Function CreateCell(cellValue As String) As Cell
        Dim cell As Cell = New Cell()
        cell.DataType = CellValues.String
        cell.CellValue = New CellValue(cellValue)
        Return cell
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        openFileDialog.Title = "Select an Excel File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim excelApp As Application
            Dim excelWorkbook As Microsoft.Office.Interop.Excel.Workbook
            Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet

            Try
                excelApp = New Application()
                excelWorkbook = excelApp.Workbooks.Open(openFileDialog.FileName)
                excelWorksheet = excelWorkbook.Application.Sheets(1) ' Change the sheet index as needed

                Dim range As Range = excelWorksheet.UsedRange
                Dim dataArr(,) As Object = range.Value

                ' Bind the data to the DataGridView
                DataGridView1.ColumnCount = range.Columns.Count
                For col As Integer = 1 To range.Columns.Count
                    DataGridView1.Columns(col - 1).HeaderText = dataArr(1, col)
                Next

                For row As Integer = 2 To range.Rows.Count
                    Dim rowData(range.Columns.Count - 1) As String
                    For col As Integer = 1 To range.Columns.Count
                        If dataArr(row, col) IsNot Nothing Then
                            rowData(col - 1) = dataArr(row, col).ToString()
                        Else
                            rowData(col - 1) = String.Empty ' Set an empty string or another default value
                        End If
                    Next
                    DataGridView1.Rows.Add(rowData)
                Next


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If excelWorkbook IsNot Nothing Then
                    excelWorkbook.Close()
                    Marshal.ReleaseComObject(excelWorkbook)
                End If
                If excelApp IsNot Nothing Then
                    excelApp.Quit()
                    Marshal.ReleaseComObject(excelApp)
                End If
            End Try
        End If
    End Sub
End Class
