Public Class Form1

    Private Sub CalculateButton_Click_1(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Read input values from text boxes
        Dim adultTicketPrice As Decimal = Decimal.Parse(adultTicketPriceTextBox.Text)
        Dim childTicketPrice As Decimal = Decimal.Parse(childTicketPriceTextBox.Text)
        Dim adultTicketsSold As Integer = Integer.Parse(adultTicketsSoldTextBox.Text)
        Dim childTicketsSold As Integer = Integer.Parse(childTicketsSoldTextBox.Text)

        ' Calculate gross and net revenue for adult tickets
        Dim grossRevenueAdultTickets As Decimal = adultTicketPrice * adultTicketsSold
        Dim netRevenueAdultTickets As Decimal = grossRevenueAdultTickets * 0.7 ' assuming 30% goes to movie company

        ' Calculate gross and net revenue for child tickets
        Dim grossRevenueChildTickets As Decimal = childTicketPrice * childTicketsSold
        Dim netRevenueChildTickets As Decimal = grossRevenueChildTickets * 0.7 ' assuming 30% goes to movie company

        ' Calculate total gross and net revenue
        Dim totalGrossRevenue As Decimal = grossRevenueAdultTickets + grossRevenueChildTickets
        Dim totalNetRevenue As Decimal = netRevenueAdultTickets + netRevenueChildTickets

        ' Display results in label controls
        grossRevenueAdultTicketsLabel.Text = grossRevenueAdultTickets.ToString("C")
        netRevenueAdultTicketsLabel.Text = netRevenueAdultTickets.ToString("C")
        grossRevenueChildTicketsLabel.Text = grossRevenueChildTickets.ToString("C")
        netRevenueChildTicketsLabel.Text = netRevenueChildTickets.ToString("C")
        totalGrossRevenueLabel.Text = totalGrossRevenue.ToString("C")
        totalNetRevenueLabel.Text = totalNetRevenue.ToString("C")
    End Sub

    Private Sub ClearButton_Click_1(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear input and output controls
        adultTicketPriceTextBox.Clear()
        childTicketPriceTextBox.Clear()
        adultTicketsSoldTextBox.Clear()
        childTicketsSoldTextBox.Clear()
        grossRevenueAdultTicketsLabel.Text = ""
        netRevenueAdultTicketsLabel.Text = ""
        grossRevenueChildTicketsLabel.Text = ""
        netRevenueChildTicketsLabel.Text = ""
        totalGrossRevenueLabel.Text = ""
        totalNetRevenueLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Close the application
        Me.Close()
    End Sub
End Class
