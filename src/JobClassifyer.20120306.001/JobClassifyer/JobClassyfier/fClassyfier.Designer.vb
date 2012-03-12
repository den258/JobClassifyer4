<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fClassyfier
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
        Me.components = New System.ComponentModel.Container
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("[TP00000]:office.frog256")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fClassyfier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.objSplitContainer = New System.Windows.Forms.SplitContainer
        Me.objTreeView = New System.Windows.Forms.TreeView
        Me.objContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.objToolStripMenuItemAddCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemAddBusiness = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemAddClass = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemAddDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDeleteCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDeleteBusiness = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDeleteClass = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDeleteDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDeleteWorkTime = New System.Windows.Forms.ToolStripMenuItem
        Me.objImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.objLabelTime = New System.Windows.Forms.Label
        Me.objLabelTotalSpendTime = New System.Windows.Forms.Label
        Me.objDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.objDataGridView = New JobClassifyer.cDataGridView
        Me.objColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objColumnStart = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objColumnEnd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objColumnSpendTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objColumnAddDelButton = New System.Windows.Forms.DataGridViewButtonColumn
        Me.objColumnJob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objColumnWorkTimeDetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objColumnWorkTimeCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.objSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.objOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.objMenuStrip = New System.Windows.Forms.MenuStrip
        Me.objToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemSaveToXml = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemSaveToXmlWithEmptyNodeDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemLoadFromXmlAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemLoadFromXmlOverride = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemGetTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemGetTotalTimeByNode = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemBusinessCountSaveToCsv = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDateTerm = New System.Windows.Forms.ToolStripMenuItem
        Me.objSplitContainer.Panel1.SuspendLayout()
        Me.objSplitContainer.Panel2.SuspendLayout()
        Me.objSplitContainer.SuspendLayout()
        Me.objContextMenuStrip.SuspendLayout()
        CType(Me.objDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.objMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'objSplitContainer
        '
        Me.objSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objSplitContainer.Location = New System.Drawing.Point(0, 27)
        Me.objSplitContainer.Name = "objSplitContainer"
        Me.objSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'objSplitContainer.Panel1
        '
        Me.objSplitContainer.Panel1.Controls.Add(Me.objTreeView)
        '
        'objSplitContainer.Panel2
        '
        Me.objSplitContainer.Panel2.Controls.Add(Me.objLabelTime)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objLabelTotalSpendTime)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objDateTimePicker)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objDataGridView)
        Me.objSplitContainer.Size = New System.Drawing.Size(692, 473)
        Me.objSplitContainer.SplitterDistance = 266
        Me.objSplitContainer.TabIndex = 0
        '
        'objTreeView
        '
        Me.objTreeView.AllowDrop = True
        Me.objTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objTreeView.ContextMenuStrip = Me.objContextMenuStrip
        Me.objTreeView.ImageIndex = 0
        Me.objTreeView.ImageList = Me.objImageList
        Me.objTreeView.LabelEdit = True
        Me.objTreeView.Location = New System.Drawing.Point(0, 0)
        Me.objTreeView.Name = "objTreeView"
        TreeNode1.Name = "objRoot"
        TreeNode1.Tag = "Root,00000"
        TreeNode1.Text = "[TP00000]:office.frog256"
        Me.objTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.objTreeView.SelectedImageIndex = 0
        Me.objTreeView.Size = New System.Drawing.Size(692, 266)
        Me.objTreeView.TabIndex = 1
        '
        'objContextMenuStrip
        '
        Me.objContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objToolStripMenuItemAddCustomer, Me.objToolStripMenuItemAddBusiness, Me.objToolStripMenuItemAddClass, Me.objToolStripMenuItemAddDetail, Me.objToolStripMenuItemDeleteCustomer, Me.objToolStripMenuItemDeleteBusiness, Me.objToolStripMenuItemDeleteClass, Me.objToolStripMenuItemDeleteDetail, Me.objToolStripMenuItemDeleteWorkTime})
        Me.objContextMenuStrip.Name = "objContextMenuStrip"
        Me.objContextMenuStrip.Size = New System.Drawing.Size(147, 202)
        '
        'objToolStripMenuItemAddCustomer
        '
        Me.objToolStripMenuItemAddCustomer.Name = "objToolStripMenuItemAddCustomer"
        Me.objToolStripMenuItemAddCustomer.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemAddCustomer.Text = "顧客を追加する"
        '
        'objToolStripMenuItemAddBusiness
        '
        Me.objToolStripMenuItemAddBusiness.Name = "objToolStripMenuItemAddBusiness"
        Me.objToolStripMenuItemAddBusiness.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemAddBusiness.Text = "業務を追加する"
        '
        'objToolStripMenuItemAddClass
        '
        Me.objToolStripMenuItemAddClass.Name = "objToolStripMenuItemAddClass"
        Me.objToolStripMenuItemAddClass.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemAddClass.Text = "分類を追加する"
        '
        'objToolStripMenuItemAddDetail
        '
        Me.objToolStripMenuItemAddDetail.Name = "objToolStripMenuItemAddDetail"
        Me.objToolStripMenuItemAddDetail.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemAddDetail.Text = "詳細を追加する"
        '
        'objToolStripMenuItemDeleteCustomer
        '
        Me.objToolStripMenuItemDeleteCustomer.Name = "objToolStripMenuItemDeleteCustomer"
        Me.objToolStripMenuItemDeleteCustomer.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemDeleteCustomer.Text = "顧客を削除する"
        '
        'objToolStripMenuItemDeleteBusiness
        '
        Me.objToolStripMenuItemDeleteBusiness.Name = "objToolStripMenuItemDeleteBusiness"
        Me.objToolStripMenuItemDeleteBusiness.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemDeleteBusiness.Text = "業務を削除する"
        '
        'objToolStripMenuItemDeleteClass
        '
        Me.objToolStripMenuItemDeleteClass.Name = "objToolStripMenuItemDeleteClass"
        Me.objToolStripMenuItemDeleteClass.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemDeleteClass.Text = "分類を削除する"
        '
        'objToolStripMenuItemDeleteDetail
        '
        Me.objToolStripMenuItemDeleteDetail.Name = "objToolStripMenuItemDeleteDetail"
        Me.objToolStripMenuItemDeleteDetail.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemDeleteDetail.Text = "詳細を削除する"
        '
        'objToolStripMenuItemDeleteWorkTime
        '
        Me.objToolStripMenuItemDeleteWorkTime.Name = "objToolStripMenuItemDeleteWorkTime"
        Me.objToolStripMenuItemDeleteWorkTime.Size = New System.Drawing.Size(146, 22)
        Me.objToolStripMenuItemDeleteWorkTime.Text = "時間を削除する"
        '
        'objImageList
        '
        Me.objImageList.ImageStream = CType(resources.GetObject("objImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.objImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.objImageList.Images.SetKeyName(0, "orb.ico")
        Me.objImageList.Images.SetKeyName(1, "people.ico")
        Me.objImageList.Images.SetKeyName(2, "workspace.ico")
        Me.objImageList.Images.SetKeyName(3, "folder.ico")
        Me.objImageList.Images.SetKeyName(4, "editdoc.ico")
        Me.objImageList.Images.SetKeyName(5, "poorman.ico")
        '
        'objLabelTime
        '
        Me.objLabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objLabelTime.AutoSize = True
        Me.objLabelTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objLabelTime.Location = New System.Drawing.Point(640, 9)
        Me.objLabelTime.Name = "objLabelTime"
        Me.objLabelTime.Size = New System.Drawing.Size(40, 16)
        Me.objLabelTime.TabIndex = 6
        Me.objLabelTime.Text = "時間"
        '
        'objLabelTotalSpendTime
        '
        Me.objLabelTotalSpendTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objLabelTotalSpendTime.AutoSize = True
        Me.objLabelTotalSpendTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objLabelTotalSpendTime.Location = New System.Drawing.Point(583, 9)
        Me.objLabelTotalSpendTime.Name = "objLabelTotalSpendTime"
        Me.objLabelTotalSpendTime.Size = New System.Drawing.Size(51, 16)
        Me.objLabelTotalSpendTime.TabIndex = 5
        Me.objLabelTotalSpendTime.Text = "999.99"
        '
        'objDateTimePicker
        '
        Me.objDateTimePicker.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objDateTimePicker.Location = New System.Drawing.Point(12, 6)
        Me.objDateTimePicker.Name = "objDateTimePicker"
        Me.objDateTimePicker.Size = New System.Drawing.Size(138, 23)
        Me.objDateTimePicker.TabIndex = 4
        '
        'objDataGridView
        '
        Me.objDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.objDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.objColumnId, Me.objColumnStart, Me.objColumnEnd, Me.objColumnSpendTime, Me.objColumnAddDelButton, Me.objColumnJob, Me.objColumnWorkTimeDetail, Me.objColumnWorkTimeCode})
        Me.objDataGridView.Location = New System.Drawing.Point(0, 35)
        Me.objDataGridView.Name = "objDataGridView"
        Me.objDataGridView.RowTemplate.Height = 21
        Me.objDataGridView.Size = New System.Drawing.Size(692, 168)
        Me.objDataGridView.TabIndex = 1
        '
        'objColumnId
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.objColumnId.DefaultCellStyle = DataGridViewCellStyle1
        Me.objColumnId.HeaderText = "ID"
        Me.objColumnId.Name = "objColumnId"
        Me.objColumnId.Width = 40
        '
        'objColumnStart
        '
        Me.objColumnStart.HeaderText = "開始"
        Me.objColumnStart.Name = "objColumnStart"
        Me.objColumnStart.Width = 60
        '
        'objColumnEnd
        '
        Me.objColumnEnd.HeaderText = "終了"
        Me.objColumnEnd.Name = "objColumnEnd"
        Me.objColumnEnd.Width = 60
        '
        'objColumnSpendTime
        '
        Me.objColumnSpendTime.HeaderText = "時間"
        Me.objColumnSpendTime.Name = "objColumnSpendTime"
        Me.objColumnSpendTime.Width = 60
        '
        'objColumnAddDelButton
        '
        Me.objColumnAddDelButton.HeaderText = ""
        Me.objColumnAddDelButton.Name = "objColumnAddDelButton"
        Me.objColumnAddDelButton.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.objColumnAddDelButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.objColumnAddDelButton.Text = "リンク/解除"
        Me.objColumnAddDelButton.UseColumnTextForButtonValue = True
        Me.objColumnAddDelButton.Width = 80
        '
        'objColumnJob
        '
        Me.objColumnJob.HeaderText = "ジョブ"
        Me.objColumnJob.Name = "objColumnJob"
        Me.objColumnJob.ReadOnly = True
        Me.objColumnJob.Width = 220
        '
        'objColumnWorkTimeDetail
        '
        Me.objColumnWorkTimeDetail.HeaderText = "WorkTimeDetail"
        Me.objColumnWorkTimeDetail.Name = "objColumnWorkTimeDetail"
        Me.objColumnWorkTimeDetail.Visible = False
        '
        'objColumnWorkTimeCode
        '
        Me.objColumnWorkTimeCode.HeaderText = "WoroTimeCode"
        Me.objColumnWorkTimeCode.Name = "objColumnWorkTimeCode"
        Me.objColumnWorkTimeCode.Visible = False
        '
        'objMenuStrip
        '
        Me.objMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objToolStripMenuItemFile, Me.objToolStripMenuItemGetTotal})
        Me.objMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.objMenuStrip.Name = "objMenuStrip"
        Me.objMenuStrip.Size = New System.Drawing.Size(692, 24)
        Me.objMenuStrip.TabIndex = 8
        Me.objMenuStrip.Text = "MenuStrip"
        '
        'objToolStripMenuItemFile
        '
        Me.objToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objToolStripMenuItemSaveToXml, Me.objToolStripMenuItemSaveToXmlWithEmptyNodeDelete, Me.objToolStripMenuItemLoadFromXmlAdd, Me.objToolStripMenuItemLoadFromXmlOverride})
        Me.objToolStripMenuItemFile.Name = "objToolStripMenuItemFile"
        Me.objToolStripMenuItemFile.Size = New System.Drawing.Size(51, 20)
        Me.objToolStripMenuItemFile.Text = "ファイル"
        '
        'objToolStripMenuItemSaveToXml
        '
        Me.objToolStripMenuItemSaveToXml.Name = "objToolStripMenuItemSaveToXml"
        Me.objToolStripMenuItemSaveToXml.Size = New System.Drawing.Size(226, 22)
        Me.objToolStripMenuItemSaveToXml.Text = "保存する（空ノードを削除しない）"
        '
        'objToolStripMenuItemSaveToXmlWithEmptyNodeDelete
        '
        Me.objToolStripMenuItemSaveToXmlWithEmptyNodeDelete.Name = "objToolStripMenuItemSaveToXmlWithEmptyNodeDelete"
        Me.objToolStripMenuItemSaveToXmlWithEmptyNodeDelete.Size = New System.Drawing.Size(226, 22)
        Me.objToolStripMenuItemSaveToXmlWithEmptyNodeDelete.Text = "保存する（空ノードを削除する）"
        '
        'objToolStripMenuItemLoadFromXmlAdd
        '
        Me.objToolStripMenuItemLoadFromXmlAdd.Name = "objToolStripMenuItemLoadFromXmlAdd"
        Me.objToolStripMenuItemLoadFromXmlAdd.Size = New System.Drawing.Size(226, 22)
        Me.objToolStripMenuItemLoadFromXmlAdd.Text = "読み込み（追加）"
        '
        'objToolStripMenuItemLoadFromXmlOverride
        '
        Me.objToolStripMenuItemLoadFromXmlOverride.Name = "objToolStripMenuItemLoadFromXmlOverride"
        Me.objToolStripMenuItemLoadFromXmlOverride.Size = New System.Drawing.Size(226, 22)
        Me.objToolStripMenuItemLoadFromXmlOverride.Text = "読み込み（上書き）"
        '
        'objToolStripMenuItemGetTotal
        '
        Me.objToolStripMenuItemGetTotal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objToolStripMenuItemGetTotalTimeByNode, Me.objToolStripMenuItemBusinessCountSaveToCsv, Me.objToolStripMenuItemDateTerm})
        Me.objToolStripMenuItemGetTotal.Name = "objToolStripMenuItemGetTotal"
        Me.objToolStripMenuItemGetTotal.Size = New System.Drawing.Size(41, 20)
        Me.objToolStripMenuItemGetTotal.Text = "集計"
        '
        'objToolStripMenuItemGetTotalTimeByNode
        '
        Me.objToolStripMenuItemGetTotalTimeByNode.Name = "objToolStripMenuItemGetTotalTimeByNode"
        Me.objToolStripMenuItemGetTotalTimeByNode.Size = New System.Drawing.Size(256, 22)
        Me.objToolStripMenuItemGetTotalTimeByNode.Text = "Node 配下の時間を合計する"
        '
        'objToolStripMenuItemBusinessCountSaveToCsv
        '
        Me.objToolStripMenuItemBusinessCountSaveToCsv.Name = "objToolStripMenuItemBusinessCountSaveToCsv"
        Me.objToolStripMenuItemBusinessCountSaveToCsv.Size = New System.Drawing.Size(256, 22)
        Me.objToolStripMenuItemBusinessCountSaveToCsv.Text = "業務毎の集計値を CSV に保存する"
        '
        'objToolStripMenuItemDateTerm
        '
        Me.objToolStripMenuItemDateTerm.Name = "objToolStripMenuItemDateTerm"
        Me.objToolStripMenuItemDateTerm.Size = New System.Drawing.Size(256, 22)
        Me.objToolStripMenuItemDateTerm.Text = "指定した Node の日付範囲を取得する"
        '
        'fClassyfier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 501)
        Me.Controls.Add(Me.objMenuStrip)
        Me.Controls.Add(Me.objSplitContainer)
        Me.Name = "fClassyfier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClassyfier"
        Me.objSplitContainer.Panel1.ResumeLayout(False)
        Me.objSplitContainer.Panel2.ResumeLayout(False)
        Me.objSplitContainer.Panel2.PerformLayout()
        Me.objSplitContainer.ResumeLayout(False)
        Me.objContextMenuStrip.ResumeLayout(False)
        CType(Me.objDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.objMenuStrip.ResumeLayout(False)
        Me.objMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents objSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents objTreeView As System.Windows.Forms.TreeView
    Friend WithEvents objDataGridView As JobClassifyer.cDataGridView
    Friend WithEvents objLabelTime As System.Windows.Forms.Label
    Friend WithEvents objLabelTotalSpendTime As System.Windows.Forms.Label
    Friend WithEvents objDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents objImageList As System.Windows.Forms.ImageList
    Friend WithEvents objSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents objOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents objMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents objToolStripMenuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemSaveToXml As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemGetTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemGetTotalTimeByNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents objToolStripMenuItemAddCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemAddBusiness As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemAddClass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemAddDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDeleteCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDeleteBusiness As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDeleteClass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDeleteDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDeleteWorkTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objColumnStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objColumnEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objColumnSpendTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objColumnAddDelButton As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents objColumnJob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objColumnWorkTimeDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objColumnWorkTimeCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents objToolStripMenuItemLoadFromXmlAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemLoadFromXmlOverride As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemSaveToXmlWithEmptyNodeDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemBusinessCountSaveToCsv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDateTerm As System.Windows.Forms.ToolStripMenuItem
End Class
