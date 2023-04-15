<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class upload_backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(upload_backup))
        Me.uploadFile_btn = New System.Windows.Forms.Button()
        Me.backup_btn = New System.Windows.Forms.Button()
        Me.dgvCsv = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uploadFile_btn
        '
        Me.uploadFile_btn.BackColor = System.Drawing.SystemColors.Control
        Me.uploadFile_btn.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.uploadFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.uploadFile_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.uploadFile_btn.FlatAppearance.BorderSize = 0
        Me.uploadFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadFile_btn.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.uploadFile_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.uploadFile_btn.Location = New System.Drawing.Point(493, 375)
        Me.uploadFile_btn.Name = "uploadFile_btn"
        Me.uploadFile_btn.Size = New System.Drawing.Size(131, 52)
        Me.uploadFile_btn.TabIndex = 0
        Me.uploadFile_btn.Text = "Upload File"
        Me.uploadFile_btn.UseVisualStyleBackColor = False
        '
        'backup_btn
        '
        Me.backup_btn.BackColor = System.Drawing.SystemColors.Control
        Me.backup_btn.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.backup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backup_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.backup_btn.FlatAppearance.BorderSize = 0
        Me.backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backup_btn.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backup_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.backup_btn.Location = New System.Drawing.Point(645, 375)
        Me.backup_btn.Name = "backup_btn"
        Me.backup_btn.Size = New System.Drawing.Size(131, 52)
        Me.backup_btn.TabIndex = 1
        Me.backup_btn.Text = "Backup"
        Me.backup_btn.UseVisualStyleBackColor = False
        '
        'dgvCsv
        '
        Me.dgvCsv.AllowUserToAddRows = False
        Me.dgvCsv.AllowUserToDeleteRows = False
        Me.dgvCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCsv.Location = New System.Drawing.Point(12, 9)
        Me.dgvCsv.Name = "dgvCsv"
        Me.dgvCsv.ReadOnly = True
        Me.dgvCsv.RowTemplate.Height = 25
        Me.dgvCsv.Size = New System.Drawing.Size(779, 347)
        Me.dgvCsv.TabIndex = 2
        '
        'upload_backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvCsv)
        Me.Controls.Add(Me.backup_btn)
        Me.Controls.Add(Me.uploadFile_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "upload_backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Manager"
        CType(Me.dgvCsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uploadFile_btn As Button
    Friend WithEvents backup_btn As Button
    Friend WithEvents dgvCsv As DataGridView
End Class
