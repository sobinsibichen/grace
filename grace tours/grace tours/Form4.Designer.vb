<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Button7 = New Button()
        Button5 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.grace_tour_logo
        PictureBox1.Location = New Point(744, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(249, 197)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(194, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(548, 41)
        Label2.TabIndex = 11
        Label2.Text = "Grace Tours And Travels"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(399, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 31)
        Label7.TabIndex = 30
        Label7.Text = "Booked Details"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua Titling MT", 7.8F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(510, 665)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 15)
        Label6.TabIndex = 32
        Label6.Text = "Sobin Sibichen"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua Titling MT", 7.8F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(412, 665)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 31
        Label5.Text = "Designed by"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 215)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(981, 344)
        DataGridView1.TabIndex = 33
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.ActiveBorder
        Button7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(231, 576)
        Button7.Name = "Button7"
        Button7.Size = New Size(187, 56)
        Button7.TabIndex = 35
        Button7.Text = "Booked Details"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.HotTrack
        Button5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(665, 576)
        Button5.Name = "Button5"
        Button5.Size = New Size(136, 56)
        Button5.TabIndex = 34
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(482, 576)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 56)
        Button1.TabIndex = 36
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1015, 689)
        Controls.Add(Button1)
        Controls.Add(Button7)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "Form4"
        Text = "Booked Details"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
End Class
