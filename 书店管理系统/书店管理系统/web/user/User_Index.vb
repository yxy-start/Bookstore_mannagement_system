Public Class User_Index

    Private Sub User_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Add("江江书店图书类别导航")
        TreeView1.Nodes(0).Nodes.Add("哲学/宗教")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("中国哲学")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("宗教理论")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("科学技术哲学")
        TreeView1.Nodes(0).Nodes.Add("政治/军事")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("中国政治")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("中国军事")
        TreeView1.Nodes(0).Nodes.Add("社会/科学")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("社会科学总论")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("语言文字")
        TreeView1.Nodes(0).Nodes.Add("自我实现/励志")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("成功")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("人际沟通")
        TreeView1.Nodes(0).Nodes.Add("法律")
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("法学理论")
        TreeView1.Nodes(0).Nodes.Add("小说传记")
        TreeView1.Nodes(0).Nodes(5).Nodes.Add("中国现代小说")
        TreeView1.Nodes(0).Nodes(5).Nodes.Add("武侠小说")
        TreeView1.Nodes(0).Nodes.Add("中国文学")
        TreeView1.Nodes(0).Nodes(6).Nodes.Add("诗歌")
        TreeView1.Nodes(0).Nodes(6).Nodes.Add("散文")
        TreeView1.Nodes(0).Nodes(6).Nodes.Add("小说")
        TreeView1.Nodes(0).Nodes.Add("退出系统")
        TreeView1.EndUpdate()
        '展开节点
        Dim node As TreeNode
        For Each node In TreeView1.Nodes
            node.ExpandAll()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "隐藏引导区" Then
            Button1.Left = 0
            Button1.Text = "显示引导区"
            TreeView1.Visible = False
        ElseIf Button1.Text = "显示引导区" Then
            Button1.Text = "隐藏引导区"
            TreeView1.Visible = True
            Button1.Left = TreeView1.Width + 10
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim tscx As New Book_User
        tscx.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim tscx As New Book_User
        tscx.ShowDialog()
    End Sub

    Private Sub 图书类别查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图书类别查询ToolStripMenuItem.Click
        Dim tscx As New Book_User
        tscx.ShowDialog()
    End Sub

    Private Sub 图书类别查询ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 图书类别查询ToolStripMenuItem1.Click
        Dim tscx As New Book_User
        tscx.ShowDialog()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub
End Class