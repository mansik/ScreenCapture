﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScreenCapture
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
        Me.CaptureBtn = New System.Windows.Forms.Button()
        Me.CaptureBox = New System.Windows.Forms.PictureBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.FileSaveDlg = New System.Windows.Forms.SaveFileDialog()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.CaptureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaptureBtn
        '
        Me.CaptureBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaptureBtn.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CaptureBtn.Location = New System.Drawing.Point(456, 407)
        Me.CaptureBtn.Name = "CaptureBtn"
        Me.CaptureBtn.Size = New System.Drawing.Size(75, 23)
        Me.CaptureBtn.TabIndex = 0
        Me.CaptureBtn.Text = "&Capture"
        Me.CaptureBtn.UseVisualStyleBackColor = True
        '
        'CaptureBox
        '
        Me.CaptureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaptureBox.BackColor = System.Drawing.Color.Red
        Me.CaptureBox.Location = New System.Drawing.Point(12, 12)
        Me.CaptureBox.Name = "CaptureBox"
        Me.CaptureBox.Size = New System.Drawing.Size(600, 389)
        Me.CaptureBox.TabIndex = 1
        Me.CaptureBox.TabStop = False
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(537, 407)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 2
        Me.SaveBtn.Text = "&Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearBtn.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(375, 407)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 0
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "캡쳐하면 자동으로 클립보드에 저장됨"
        '
        'FrmScreenCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.CaptureBox)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CaptureBtn)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmScreenCapture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScreenCapture"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.CaptureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CaptureBtn As System.Windows.Forms.Button
    Friend WithEvents CaptureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents FileSaveDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Label1 As Label
End Class
