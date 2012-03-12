
Public Class cDataGridView
    Inherits DataGridView

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean

        Dim PKey As Keys = keyData And Keys.KeyCode

        If PKey = Keys.Enter Then

            Return Me.ProcessRightKey(keyData)

        End If

        Return MyBase.ProcessDialogKey(keyData)

    End Function

    Public Shadows Function ProcessRightKey(ByVal keyData As Keys)

        Dim PKey As Keys = keyData And Keys.KeyCode

        If PKey = Keys.Enter Then

            If MyBase.CurrentCell.ColumnIndex = MyBase.ColumnCount - 1 AndAlso _
               MyBase.CurrentCell.RowIndex = MyBase.RowCount - 1 Then

                MyBase.EndEdit()
                If isNothing(MyBase.DataSource) = False Then
                    CType(MyBase.DataSource, BindingSource).AddNew()
                End If
                MyBase.CurrentCell = MyBase.Rows(MyBase.RowCount - 1).Cells(0)
                Return True

            End If

            If MyBase.CurrentCell.ColumnIndex = MyBase.ColumnCount - 1 AndAlso _
               MyBase.CurrentCell.RowIndex + 1 <> MyBase.NewRowIndex Then

                MyBase.CurrentCell = MyBase.Rows(MyBase.CurrentCell.RowIndex + 1).Cells(0)
                Return True

            End If

            Return MyBase.ProcessRightKey(keyData)

        End If

        Return MyBase.ProcessDialogKey(keyData)

    End Function

    Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean

        If e.KeyCode = Keys.Enter Then

            Return Me.ProcessRightKey(e.KeyData)

        End If

        Return MyBase.ProcessDataGridViewKey(e)

    End Function

End Class
