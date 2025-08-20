Imports MySql.Data.MySqlClient
Module ProcessQR
    Dim QRpartcode As String
    Dim QRlotnumber As String
    Dim QRqty As Integer
    Dim QRremarks As String
    Dim QRsupplier As String

    Private Function ProcessQRcode(qrcode As String) As Boolean
        Try
            ' Split the QR code using the pipe character
            Dim parts() As String = qrcode.Split("|")

            ' Validate the number of parts in the QR code
            If parts.Length >= 5 AndAlso parts.Length <= 8 Then

                ' Assign values to module-level variables
                QRpartcode = parts(0).Remove(0, 2).Trim()
                QRsupplier = parts(1).Remove(0, 2).Trim()
                QRlotnumber = parts(2).Remove(0, 2).Trim()
                QRqty = Convert.ToInt32(parts(3).Remove(0, 2).Trim())
                QRremarks = parts(4).Remove(0, 2).Trim()

                Return True ' Indicate success
            Else
                ' Show an error if the QR code format is invalid
                show_error("Invalid QR format!.", 1)
                Return False ' Indicate failure
            End If
        Catch ex As Exception
            ' Handle unexpected errors gracefully
            show_error("Invalid QR format!", 1)
            Return False ' Indicate failure
        Finally
            ' Ensure the database connection is properly closed
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

    Private Sub cleardata()
        QRpartcode = ""
        QRlotnumber = ""
        QRqty = 0
        QRremarks = ""
        QRsupplier = ""
    End Sub

    Private Function CheckPartName(partcode As String) As Boolean
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim query As String = "SELECT id FROM `logistics_masterlist` WHERE partcode = @partcode LIMIT 1"
            Using selectPartName As New MySqlCommand(query, con)
                selectPartName.Parameters.AddWithValue("@partcode", partcode)

                Using dr As MySqlDataReader = selectPartName.ExecuteReader()
                    If dr.HasRows = True Then
                        Return True
                    Else

                        show_error("Partcode Not Registered!", 1)
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception

            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function


    Public Function getProddate(input As String) As String
        Dim candidates As New List(Of DateTime)
        Dim today As DateTime = Date.Today

        ' First: scan for 6-digit YYMMDD
        For i As Integer = 0 To input.Length - 6
            Dim seg6 As String = input.Substring(i, 6)
            If seg6.All(AddressOf Char.IsDigit) Then
                Try
                    Dim yy As Integer = CInt(seg6.Substring(0, 2))
                    Dim mm As Integer = CInt(seg6.Substring(2, 2))
                    Dim dd As Integer = CInt(seg6.Substring(4, 2))

                    If IsValidDate(yy, mm, dd) Then
                        Dim fullYear As Integer = 2000 + yy
                        Dim dt As New DateTime(fullYear, mm, dd)
                        If dt <= today Then candidates.Add(dt)
                    End If
                Catch
                End Try
            End If
        Next

        ' Fallback: scan for 5-digit YYMDD
        For i As Integer = 0 To input.Length - 5
            Dim seg5 As String = input.Substring(i, 5)
            If seg5.All(AddressOf Char.IsDigit) Then
                Try
                    Dim yy As Integer = CInt(seg5.Substring(0, 2))
                    Dim m As Integer = CInt(seg5.Substring(2, 1))
                    Dim dd As Integer = CInt(seg5.Substring(3, 2))

                    If IsValidDate(yy, m, dd) Then
                        Dim fullYear As Integer = 2000 + yy
                        Dim dt As New DateTime(fullYear, m, dd)
                        If dt <= today Then candidates.Add(dt)
                    End If
                Catch
                End Try
            End If
        Next

        ' Return latest valid date ≤ today
        If candidates.Count > 0 Then
            Dim latest = candidates.OrderByDescending(Function(d) d).First()
            Return latest.ToString("yyyy-MM-dd")
        End If

        Return Nothing
    End Function

    Private Function IsValidDate(yy As Integer, mm As Integer, dd As Integer) As Boolean
        Try
            Dim fullYear As Integer = 2000 + yy
            Dim dt As New DateTime(fullYear, mm, dd)
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function checkQR(QR As String) As String
        ProcessQRcode(QR)
        Return QRpartcode
    End Function



End Module
