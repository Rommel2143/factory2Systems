Imports Guna.UI2.WinForms

Module HandleInputs

    ' Define allowed input types
    Public Enum InputType
        Digits
        Decimals
        NoSymbols
        Time
    End Enum

    ' Main method to handle key press
    Public Sub AllowInput(sender As Object, e As KeyPressEventArgs, inputType As InputType)
        Dim txt As Guna2TextBox = CType(sender, Guna2TextBox)

        ' Always allow control keys (e.g., backspace, delete)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        Select Case inputType
            Case InputType.Digits
                ' Digits only
                If Char.IsDigit(e.KeyChar) Then Return

            Case InputType.Decimals
                ' Digits + one decimal point
                If Char.IsDigit(e.KeyChar) Then Return
                If e.KeyChar = "."c AndAlso Not txt.Text.Contains(".") Then Return

            Case InputType.Time
                ' Digits + one decimal point
                If Char.IsDigit(e.KeyChar) Then Return
                If e.KeyChar = ":"c AndAlso Not txt.Text.Contains(":") Then Return

            Case InputType.NoSymbols
                ' Letters + digits only
                If Char.IsLetterOrDigit(e.KeyChar) Then Return
        End Select

        ' Block everything else
        e.Handled = True
    End Sub

End Module
