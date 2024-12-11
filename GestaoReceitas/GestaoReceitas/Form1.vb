Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "Base de dados vazia"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Dim Receita As New Receita
        Receita.Nome = TextBox2.Text
        Receita.AutorNome = TextBox3.Text
        Receita.AutorApelido = TextBox4.Text
        Receita.Imagem = TextBox5.Text
        Receita.Categoria = TextBox6.Text
        Receita.TempoConfecao = Decimal.Parse(TextBox7.Text)
        Receita.ModoPreparacao = TextBox8.Text
        TextBox1.AppendText(
            Receita.Nome +
            Environment.NewLine +
            Receita.AutorNome +
            Environment.NewLine +
            Receita.AutorApelido +
            Environment.NewLine +
            Receita.Imagem +
            Environment.NewLine +
            Receita.Categoria +
            Environment.NewLine +
            Receita.TempoConfecao.ToString() +
            Environment.NewLine +
            Receita.ModoPreparacao +
            Environment.NewLine
            )
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        Label13.Text = "Receita criada com sucesso"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        Dim Ingrediente As New ReceitaIngredientes
        Ingrediente.Unidade = TextBox9.Text
        Ingrediente.Quantidade = Decimal.Parse(TextBox10.Text)
        TextBox1.AppendText(
            Ingrediente.Unidade +
            Environment.NewLine +
            Ingrediente.Quantidade.ToString() +
            Environment.NewLine
        )
        TextBox9.Clear()
        TextBox10.Clear()
        Label14.Text = "Ingrediente criado com sucesso"
    End Sub
End Class
