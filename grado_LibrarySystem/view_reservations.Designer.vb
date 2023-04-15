<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_reservations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_reservations))
        Me.rlogs_dgv = New System.Windows.Forms.DataGridView()
        CType(Me.rlogs_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rlogs_dgv
        '
        Me.rlogs_dgv.AllowUserToAddRows = False
        Me.rlogs_dgv.AllowUserToDeleteRows = False
        Me.rlogs_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.rlogs_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rlogs_dgv.Location = New System.Drawing.Point(55, 51)
        Me.rlogs_dgv.Name = "rlogs_dgv"
        Me.rlogs_dgv.ReadOnly = True
        Me.rlogs_dgv.RowTemplate.Height = 25
        Me.rlogs_dgv.Size = New System.Drawing.Size(617, 275)
        Me.rlogs_dgv.TabIndex = 0
        '
        'view_reservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(725, 394)
        Me.Controls.Add(Me.rlogs_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "view_reservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Reservations"
        Me.TopMost = True
        CType(Me.rlogs_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rlogs_dgv As DataGridView
End Class
