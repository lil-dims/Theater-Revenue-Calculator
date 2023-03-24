<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        adultTicketPriceTextBox = New TextBox()
        adultTicketsSoldTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        grossRevenueAdultTicketsLabel = New Label()
        grossRevenueChildTicketsLabel = New Label()
        totalGrossRevenueLabel = New Label()
        CalculateButton = New Button()
        ClearButton = New Button()
        ExitButton = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label19 = New Label()
        Label20 = New Label()
        childTicketPriceTextBox = New TextBox()
        childTicketsSoldTextBox = New TextBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        netRevenueAdultTicketsLabel = New Label()
        netRevenueChildTicketsLabel = New Label()
        totalNetRevenueLabel = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' adultTicketPriceTextBox
        ' 
        adultTicketPriceTextBox.Location = New Point(115, 16)
        adultTicketPriceTextBox.Name = "adultTicketPriceTextBox"
        adultTicketPriceTextBox.Size = New Size(100, 23)
        adultTicketPriceTextBox.TabIndex = 0
        ' 
        ' adultTicketsSoldTextBox
        ' 
        adultTicketsSoldTextBox.Location = New Point(115, 55)
        adultTicketsSoldTextBox.Name = "adultTicketsSoldTextBox"
        adultTicketsSoldTextBox.Size = New Size(100, 23)
        adultTicketsSoldTextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 4
        Label1.Text = "Price Per Ticket"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 5
        Label2.Text = "Ticket Sold"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 15)
        Label6.TabIndex = 9
        Label6.Text = "Adult Ticket Sales:"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 15)
        Label7.TabIndex = 10
        Label7.Text = "Children Ticket Sales:"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(198, 15)
        Label8.TabIndex = 11
        Label8.Text = "Total Gross Revenue For Ticket Sales:"' 
        ' grossRevenueAdultTicketsLabel
        ' 
        grossRevenueAdultTicketsLabel.AutoSize = True
        grossRevenueAdultTicketsLabel.Location = New Point(124, 26)
        grossRevenueAdultTicketsLabel.Name = "grossRevenueAdultTicketsLabel"
        grossRevenueAdultTicketsLabel.Size = New Size(0, 15)
        grossRevenueAdultTicketsLabel.TabIndex = 16
        ' 
        ' grossRevenueChildTicketsLabel
        ' 
        grossRevenueChildTicketsLabel.AutoSize = True
        grossRevenueChildTicketsLabel.Location = New Point(124, 53)
        grossRevenueChildTicketsLabel.Name = "grossRevenueChildTicketsLabel"
        grossRevenueChildTicketsLabel.Size = New Size(0, 15)
        grossRevenueChildTicketsLabel.TabIndex = 17
        ' 
        ' totalGrossRevenueLabel
        ' 
        totalGrossRevenueLabel.AutoSize = True
        totalGrossRevenueLabel.Location = New Point(230, 85)
        totalGrossRevenueLabel.Name = "totalGrossRevenueLabel"
        totalGrossRevenueLabel.Size = New Size(0, 15)
        totalGrossRevenueLabel.TabIndex = 18
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(83, 322)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(75, 23)
        CalculateButton.TabIndex = 22
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(293, 322)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(75, 23)
        ClearButton.TabIndex = 23
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(507, 322)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 23)
        ExitButton.TabIndex = 24
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(adultTicketPriceTextBox)
        GroupBox1.Controls.Add(adultTicketsSoldTextBox)
        GroupBox1.Location = New Point(48, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(272, 100)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Adult Ticket Sales"' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(childTicketPriceTextBox)
        GroupBox2.Controls.Add(childTicketsSoldTextBox)
        GroupBox2.Location = New Point(354, 34)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(259, 100)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        GroupBox2.Text = "Child Ticket Sales"' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(22, 19)
        Label19.Name = "Label19"
        Label19.Size = New Size(87, 15)
        Label19.TabIndex = 4
        Label19.Text = "Price Per Ticket"' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(22, 58)
        Label20.Name = "Label20"
        Label20.Size = New Size(64, 15)
        Label20.TabIndex = 5
        Label20.Text = "Ticket Sold"' 
        ' childTicketPriceTextBox
        ' 
        childTicketPriceTextBox.Location = New Point(115, 16)
        childTicketPriceTextBox.Name = "childTicketPriceTextBox"
        childTicketPriceTextBox.Size = New Size(100, 23)
        childTicketPriceTextBox.TabIndex = 0
        ' 
        ' childTicketsSoldTextBox
        ' 
        childTicketsSoldTextBox.Location = New Point(115, 55)
        childTicketsSoldTextBox.Name = "childTicketsSoldTextBox"
        childTicketsSoldTextBox.Size = New Size(100, 23)
        childTicketsSoldTextBox.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(grossRevenueAdultTicketsLabel)
        GroupBox3.Controls.Add(grossRevenueChildTicketsLabel)
        GroupBox3.Controls.Add(totalGrossRevenueLabel)
        GroupBox3.Location = New Point(48, 165)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(272, 123)
        GroupBox3.TabIndex = 27
        GroupBox3.TabStop = False
        GroupBox3.Text = "Gross Ticket Revenue"' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(netRevenueAdultTicketsLabel)
        GroupBox4.Controls.Add(netRevenueChildTicketsLabel)
        GroupBox4.Controls.Add(totalNetRevenueLabel)
        GroupBox4.Location = New Point(354, 165)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(259, 123)
        GroupBox4.TabIndex = 28
        GroupBox4.TabStop = False
        GroupBox4.Text = "Net Ticket Revenue"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 9
        Label3.Text = "Adult Ticket Sales:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 15)
        Label4.TabIndex = 10
        Label4.Text = "Children Ticket Sales:"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 15)
        Label5.TabIndex = 11
        Label5.Text = "Total Gross Revenue For Ticket Sales:"' 
        ' netRevenueAdultTicketsLabel
        ' 
        netRevenueAdultTicketsLabel.AutoSize = True
        netRevenueAdultTicketsLabel.Location = New Point(124, 26)
        netRevenueAdultTicketsLabel.Name = "netRevenueAdultTicketsLabel"
        netRevenueAdultTicketsLabel.Size = New Size(0, 15)
        netRevenueAdultTicketsLabel.TabIndex = 16
        ' 
        ' netRevenueChildTicketsLabel
        ' 
        netRevenueChildTicketsLabel.AutoSize = True
        netRevenueChildTicketsLabel.Location = New Point(124, 53)
        netRevenueChildTicketsLabel.Name = "netRevenueChildTicketsLabel"
        netRevenueChildTicketsLabel.Size = New Size(0, 15)
        netRevenueChildTicketsLabel.TabIndex = 17
        ' 
        ' totalNetRevenueLabel
        ' 
        totalNetRevenueLabel.AutoSize = True
        totalNetRevenueLabel.Location = New Point(228, 85)
        totalNetRevenueLabel.Name = "totalNetRevenueLabel"
        totalNetRevenueLabel.Size = New Size(0, 15)
        totalNetRevenueLabel.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(696, 357)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ExitButton)
        Controls.Add(ClearButton)
        Controls.Add(CalculateButton)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents adultTicketPriceTextBox As TextBox
    Friend WithEvents adultTicketsSoldTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grossRevenueAdultTicketsLabel As Label
    Friend WithEvents grossRevenueChildTicketsLabel As Label
    Friend WithEvents totalGrossRevenueLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents childTicketPriceTextBox As TextBox
    Friend WithEvents childTicketsSoldTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents netRevenueAdultTicketsLabel As Label
    Friend WithEvents netRevenueChildTicketsLabel As Label
    Friend WithEvents totalNetRevenueLabel As Label
End Class
