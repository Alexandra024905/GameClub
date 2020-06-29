Imports System.Text
Imports Google.Protobuf.WellKnownTypes

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'TunbasedbattlerDataSet.players' table. You can move, or remove it, as needed.
        'Me.PlayersTableAdapter.Fill(Me.TunbasedbattlerDataSet.players)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employee As String = ComboBox1.Text
        Dim game As String = ComboBox2.Text

        Dim resul As New StringBuilder
        resul.AppendLine($"Име на служител: {employee}")
        resul.AppendLine($"Игра: {game}")

        If game = "Тенис на маса" Then
            resul.AppendLine("Такса за: 1 час")
            resul.AppendLine("Цена на играта: 5.00 лв")
        End If

        If game = "Флипер" Then
            resul.AppendLine("Такса за: 1 жетон")
            resul.AppendLine("Цена на играта: 0.50 лв")
        End If
        If game = "Билярд" Then
            resul.AppendLine("Такса за: 30 минути")
            resul.AppendLine("Цена на играта: 8.00 лв")
        End If
        If game = "Боулинг" Then
            resul.AppendLine("Такса за: 1 игра")
            resul.AppendLine("Цена на играта: 5.00 лв")
        End If
        If game = "Въздупен хокей" Then
            resul.AppendLine("Такса за: 1 жетон")
            resul.AppendLine("Цена на играта: 1.00 лв")
        End If
        If game = "Мини футбол" Then
            resul.AppendLine("Такса за: 1 жетон")
            resul.AppendLine("Цена на играта: 0.50 лв")
        End If
        If game = "Дартс" Then
            resul.AppendLine("Такса за: 1 жетон")
            resul.AppendLine("Цена на играта: 0.50 лв")
        End If
        If game = "3D симулатор" Then
            resul.AppendLine("Такса за: 1 жетон")
            resul.AppendLine("Цена на играта: 1.00 лв")
        End If

        resul.AppendLine($"Дата:{Now}")
        TextBox1.Text = resul.ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class
