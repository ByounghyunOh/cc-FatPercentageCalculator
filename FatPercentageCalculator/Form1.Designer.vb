﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumCal = New System.Windows.Forms.TextBox()
        Me.txtNumFat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPctCal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLowFat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of calories in the food:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the number of fat grams  in the food:"
        '
        'txtNumCal
        '
        Me.txtNumCal.Location = New System.Drawing.Point(226, 28)
        Me.txtNumCal.Name = "txtNumCal"
        Me.txtNumCal.Size = New System.Drawing.Size(84, 20)
        Me.txtNumCal.TabIndex = 2
        '
        'txtNumFat
        '
        Me.txtNumFat.Location = New System.Drawing.Point(226, 69)
        Me.txtNumFat.Name = "txtNumFat"
        Me.txtNumFat.Size = New System.Drawing.Size(84, 20)
        Me.txtNumFat.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Percentage of calories that come from fat:"
        '
        'lblPctCal
        '
        Me.lblPctCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPctCal.Location = New System.Drawing.Point(227, 110)
        Me.lblPctCal.Name = "lblPctCal"
        Me.lblPctCal.Size = New System.Drawing.Size(83, 22)
        Me.lblPctCal.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(28, 166)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(134, 166)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 7
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(235, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLowFat
        '
        Me.lblLowFat.AutoSize = True
        Me.lblLowFat.Location = New System.Drawing.Point(228, 140)
        Me.lblLowFat.Name = "lblLowFat"
        Me.lblLowFat.Size = New System.Drawing.Size(0, 13)
        Me.lblLowFat.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 209)
        Me.Controls.Add(Me.lblLowFat)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPctCal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumFat)
        Me.Controls.Add(Me.txtNumCal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumCal As TextBox
    Friend WithEvents txtNumFat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPctCal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLowFat As Label
End Class
