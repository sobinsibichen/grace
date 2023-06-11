<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(233, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(548, 41)
        Label2.TabIndex = 2
        Label2.Text = "Grace Tours And Travels"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.grace_tour_logo
        PictureBox1.Location = New Point(777, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(249, 197)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(457, 152)
        Button1.Name = "Button1"
        Button1.Size = New Size(258, 88)
        Button1.TabIndex = 10
        Button1.Text = "Booked Details"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(114, 363)
        Button2.Name = "Button2"
        Button2.Size = New Size(258, 88)
        Button2.TabIndex = 11
        Button2.Text = "Package Calculator"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveBorder
        Button4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(114, 152)
        Button4.Name = "Button4"
        Button4.Size = New Size(258, 88)
        Button4.TabIndex = 13
        Button4.Text = "Booking"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.HotTrack
        Button6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = SystemColors.ControlText
        Button6.Location = New Point(457, 363)
        Button6.Name = "Button6"
        Button6.Size = New Size(258, 88)
        Button6.TabIndex = 15
        Button6.Text = "Cancel"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua Titling MT", 7.8F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(520, 673)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 15)
        Label6.TabIndex = 17
        Label6.Text = "Sobin Sibichen"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua Titling MT", 7.8F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(422, 673)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 16
        Label5.Text = "Designed by"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 713)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
