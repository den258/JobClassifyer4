<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fExport
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.objDateTimePickerEnd = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.objButtonExec = New System.Windows.Forms.Button
        Me.objDateTimePickerStart = New System.Windows.Forms.DateTimePicker
        Me.objOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.objFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.objSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.objCheckBoxAllDate = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "まで"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "から"
        '
        'objDateTimePickerEnd
        '
        Me.objDateTimePickerEnd.Location = New System.Drawing.Point(71, 31)
        Me.objDateTimePickerEnd.Name = "objDateTimePickerEnd"
        Me.objDateTimePickerEnd.Size = New System.Drawing.Size(152, 19)
        Me.objDateTimePickerEnd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "対象日付"
        '
        'objButtonExec
        '
        Me.objButtonExec.Location = New System.Drawing.Point(97, 84)
        Me.objButtonExec.Name = "objButtonExec"
        Me.objButtonExec.Size = New System.Drawing.Size(75, 35)
        Me.objButtonExec.TabIndex = 2
        Me.objButtonExec.Text = "実行する"
        Me.objButtonExec.UseVisualStyleBackColor = True
        '
        'objDateTimePickerStart
        '
        Me.objDateTimePickerStart.Location = New System.Drawing.Point(71, 6)
        Me.objDateTimePickerStart.Name = "objDateTimePickerStart"
        Me.objDateTimePickerStart.Size = New System.Drawing.Size(152, 19)
        Me.objDateTimePickerStart.TabIndex = 0
        '
        'objOpenFileDialog
        '
        Me.objOpenFileDialog.FileName = "objOpenFileDialog"
        '
        'objCheckBoxAllDate
        '
        Me.objCheckBoxAllDate.AutoSize = True
        Me.objCheckBoxAllDate.Location = New System.Drawing.Point(14, 62)
        Me.objCheckBoxAllDate.Name = "objCheckBoxAllDate"
        Me.objCheckBoxAllDate.Size = New System.Drawing.Size(144, 16)
        Me.objCheckBoxAllDate.TabIndex = 18
        Me.objCheckBoxAllDate.Text = "日付の範囲指定をしない"
        Me.objCheckBoxAllDate.UseVisualStyleBackColor = True
        '
        'FormExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 131)
        Me.Controls.Add(Me.objCheckBoxAllDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.objDateTimePickerEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.objButtonExec)
        Me.Controls.Add(Me.objDateTimePickerStart)
        Me.Name = "FormExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormExport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents objDateTimePickerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents objButtonExec As System.Windows.Forms.Button
    Friend WithEvents objDateTimePickerStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents objOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents objFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents objSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents objCheckBoxAllDate As System.Windows.Forms.CheckBox
End Class
