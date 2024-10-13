namespace C____Practice
{
    partial class TreeViewF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewF));
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Zaka");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("TheWolf", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Caty2");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Caty", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Obito");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Saski");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("madara");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Naruto", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Zoro");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sabo");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Nami");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("OnePeace", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FatherM");
            this.imageList1.Images.SetKeyName(1, "FatherC");
            this.imageList1.Images.SetKeyName(2, "SonC");
            this.imageList1.Images.SetKeyName(3, "SonM");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(32, 54);
            this.treeView1.Name = "treeView1";
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "ziko2";
            treeNode13.Text = "Zaka";
            treeNode14.Name = "ziko";
            treeNode14.Text = "TheWolf";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "ssiya2";
            treeNode15.Text = "Caty2";
            treeNode16.ImageIndex = 2;
            treeNode16.Name = "ssiya";
            treeNode16.Text = "Caty";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16});
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(346, 294);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // treeView2
            // 
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.Location = new System.Drawing.Point(470, 54);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Obito";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Saski";
            treeNode3.Name = "Node3";
            treeNode3.Text = "madara";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Naruto";
            treeNode17.Name = "Node5";
            treeNode17.Text = "Zoro";
            treeNode18.Name = "Node6";
            treeNode18.Text = "Sabo";
            treeNode19.Name = "Node7";
            treeNode19.Text = "Nami";
            treeNode20.Name = "Node4";
            treeNode20.Text = "OnePeace";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode20});
            this.treeView2.Size = new System.Drawing.Size(235, 238);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(490, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TreeViewF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 423);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeViewF";
            this.Text = "TreeViewF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox textBox1;
    }
}