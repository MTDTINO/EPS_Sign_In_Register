﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(129, 31)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(375, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 2
        Label1.Text = "Date"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 3
        Label2.Text = "Time In"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 4
        Label3.Text = "Time Out"' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(12, 188)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(570, 236)
        DataGridView1.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.Name = "Column1"' 
        ' Column2
        ' 
        Column2.HeaderText = "Time In"
        Column2.Name = "Column2"' 
        ' Column3
        ' 
        Column3.HeaderText = "Time Out"
        Column3.Name = "Column3"' 
        ' Column4
        ' 
        Column4.HeaderText = "Time"
        Column4.Name = "Column4"' 
        ' Column5
        ' 
        Column5.HeaderText = "TimeOwed"
        Column5.Name = "Column5"' 
        ' Column6
        ' 
        Column6.HeaderText = "TTO"
        Column6.Name = "Column6"' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(13, 475)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 23)
        Button1.TabIndex = 11
        Button1.Text = "APPEND"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Location = New Point(415, 475)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 23)
        Button2.TabIndex = 12
        Button2.Text = "CLEAR TABLE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Location = New Point(150, 475)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 23)
        Button3.TabIndex = 13
        Button3.Text = "EXPORT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(113, 164)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(48, 19)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "PYEI"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(258, 164)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(58, 19)
        RadioButton2.TabIndex = 15
        RadioButton2.TabStop = True
        RadioButton2.Text = "WCED"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(415, 164)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(41, 19)
        RadioButton3.TabIndex = 16
        RadioButton3.TabStop = True
        RadioButton3.Text = "GA"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(129, 70)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.ShowUpDown = True
        DateTimePicker2.Size = New Size(375, 23)
        DateTimePicker2.TabIndex = 17
        DateTimePicker2.TabStop = False
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker3.Location = New Point(129, 112)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.ShowUpDown = True
        DateTimePicker3.Size = New Size(375, 23)
        DateTimePicker3.TabIndex = 17
        DateTimePicker3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 455)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 18
        Label4.Text = "File Name"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 445)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(238, 23)
        TextBox1.TabIndex = 19
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(326, 445)
        Button4.Name = "Button4"
        Button4.Size = New Size(253, 23)
        Button4.TabIndex = 20
        Button4.Text = "CLEAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(13, 502)
        Button5.Name = "Button5"
        Button5.Size = New Size(566, 23)
        Button5.TabIndex = 21
        Button5.Text = "TIME OWED"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(13, 531)
        Button6.Name = "Button6"
        Button6.Size = New Size(566, 23)
        Button6.TabIndex = 22
        Button6.Text = "TTO"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(258, 475)
        Button7.Name = "Button7"
        Button7.Size = New Size(148, 23)
        Button7.TabIndex = 23
        Button7.Text = "IMPORT"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        ClientSize = New Size(591, 618)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker3)
        Controls.Add(DateTimePicker2)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
End Class
