namespace Paint
{
    partial class mainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_title = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_width = new System.Windows.Forms.Panel();
            this.btn_info = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_width3 = new System.Windows.Forms.Button();
            this.btn_width2 = new System.Windows.Forms.Button();
            this.btn_width1 = new System.Windows.Forms.Button();
            this.PenColor = new System.Windows.Forms.PictureBox();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_colorSet = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_width.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btn_max);
            this.panelTop.Controls.Add(this.btn_min);
            this.panelTop.Controls.Add(this.btn_exit);
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Controls.Add(this.label_title);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 58);
            this.panelTop.TabIndex = 2;
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(682, 1);
            this.btn_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(39, 24);
            this.btn_min.TabIndex = 6;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(760, 1);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 24);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(84, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(126, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(231, 29);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Paint Application";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btn_info);
            this.panelMain.Controls.Add(this.pictureBox);
            this.panelMain.Controls.Add(this.panel_right);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 58);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 392);
            this.panelMain.TabIndex = 3;
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.Teal;
            this.panel_right.Controls.Add(this.panel_width);
            this.panel_right.Controls.Add(this.PenColor);
            this.panel_right.Controls.Add(this.btn_triangle);
            this.panel_right.Controls.Add(this.btn_line);
            this.panel_right.Controls.Add(this.btn_rectangle);
            this.panel_right.Controls.Add(this.btn_fill);
            this.panel_right.Controls.Add(this.btn_erase);
            this.panel_right.Controls.Add(this.btn_pen);
            this.panel_right.Controls.Add(this.btn_colorSet);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_right.Location = new System.Drawing.Point(0, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(112, 392);
            this.panel_right.TabIndex = 0;
            // 
            // panel_width
            // 
            this.panel_width.Controls.Add(this.btn_width3);
            this.panel_width.Controls.Add(this.btn_width2);
            this.panel_width.Controls.Add(this.btn_width1);
            this.panel_width.Location = new System.Drawing.Point(3, 69);
            this.panel_width.Name = "panel_width";
            this.panel_width.Size = new System.Drawing.Size(106, 73);
            this.panel_width.TabIndex = 12;
            // 
            // btn_info
            // 
            this.btn_info.BackgroundImage = global::Paint.Properties.Resources.info_removebg_preview;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_info.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.Location = new System.Drawing.Point(760, 354);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(40, 38);
            this.btn_info.TabIndex = 2;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(112, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(688, 392);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btn_width3
            // 
            this.btn_width3.BackColor = System.Drawing.Color.Transparent;
            this.btn_width3.BackgroundImage = global::Paint.Properties.Resources.width3_removebg_preview1;
            this.btn_width3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_width3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_width3.FlatAppearance.BorderSize = 0;
            this.btn_width3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_width3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_width3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_width3.Location = new System.Drawing.Point(9, 42);
            this.btn_width3.Name = "btn_width3";
            this.btn_width3.Size = new System.Drawing.Size(89, 27);
            this.btn_width3.TabIndex = 10;
            this.btn_width3.Tag = "6";
            this.btn_width3.UseVisualStyleBackColor = false;
            this.btn_width3.Click += new System.EventHandler(this.btn_width);
            // 
            // btn_width2
            // 
            this.btn_width2.BackColor = System.Drawing.Color.Transparent;
            this.btn_width2.BackgroundImage = global::Paint.Properties.Resources.width2_removebg_preview2;
            this.btn_width2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_width2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_width2.FlatAppearance.BorderSize = 0;
            this.btn_width2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_width2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_width2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_width2.Location = new System.Drawing.Point(18, 28);
            this.btn_width2.Name = "btn_width2";
            this.btn_width2.Size = new System.Drawing.Size(68, 23);
            this.btn_width2.TabIndex = 9;
            this.btn_width2.Tag = "4";
            this.btn_width2.UseVisualStyleBackColor = false;
            this.btn_width2.Click += new System.EventHandler(this.btn_width);
            // 
            // btn_width1
            // 
            this.btn_width1.BackColor = System.Drawing.Color.Transparent;
            this.btn_width1.BackgroundImage = global::Paint.Properties.Resources.width2_removebg_preview1;
            this.btn_width1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_width1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_width1.FlatAppearance.BorderSize = 0;
            this.btn_width1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_width1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_width1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_width1.Location = new System.Drawing.Point(31, 9);
            this.btn_width1.Name = "btn_width1";
            this.btn_width1.Size = new System.Drawing.Size(40, 27);
            this.btn_width1.TabIndex = 8;
            this.btn_width1.Tag = "2";
            this.btn_width1.UseVisualStyleBackColor = false;
            this.btn_width1.Click += new System.EventHandler(this.btn_width);
            // 
            // PenColor
            // 
            this.PenColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PenColor.Location = new System.Drawing.Point(66, 27);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(31, 23);
            this.PenColor.TabIndex = 11;
            this.PenColor.TabStop = false;
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackColor = System.Drawing.Color.Transparent;
            this.btn_triangle.BackgroundImage = global::Paint.Properties.Resources.width3_removebg_preview__3_;
            this.btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_triangle.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_triangle.FlatAppearance.BorderSize = 0;
            this.btn_triangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.Location = new System.Drawing.Point(58, 319);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(40, 40);
            this.btn_triangle.TabIndex = 6;
            this.btn_triangle.Tag = "6";
            this.btn_triangle.UseVisualStyleBackColor = false;
            this.btn_triangle.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.Transparent;
            this.btn_line.BackgroundImage = global::Paint.Properties.Resources.line1;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_line.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_line.FlatAppearance.BorderSize = 0;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Location = new System.Drawing.Point(12, 319);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(40, 40);
            this.btn_line.TabIndex = 5;
            this.btn_line.Tag = "5";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.Color.Transparent;
            this.btn_rectangle.BackgroundImage = global::Paint.Properties.Resources.rectangle1;
            this.btn_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_rectangle.FlatAppearance.BorderSize = 0;
            this.btn_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rectangle.Location = new System.Drawing.Point(23, 256);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(62, 57);
            this.btn_rectangle.TabIndex = 4;
            this.btn_rectangle.Tag = "4";
            this.btn_rectangle.UseVisualStyleBackColor = false;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.Transparent;
            this.btn_fill.BackgroundImage = global::Paint.Properties.Resources.fill;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fill.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_fill.FlatAppearance.BorderSize = 0;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Location = new System.Drawing.Point(34, 210);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(40, 40);
            this.btn_fill.TabIndex = 3;
            this.btn_fill.Tag = "3";
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::Paint.Properties.Resources.iraser;
            this.btn_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_erase.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_erase.FlatAppearance.BorderSize = 0;
            this.btn_erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erase.Location = new System.Drawing.Point(59, 148);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(40, 40);
            this.btn_erase.TabIndex = 2;
            this.btn_erase.Tag = "2";
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_pen
            // 
            this.btn_pen.BackColor = System.Drawing.Color.Transparent;
            this.btn_pen.BackgroundImage = global::Paint.Properties.Resources.pen;
            this.btn_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pen.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_pen.FlatAppearance.BorderSize = 0;
            this.btn_pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pen.Location = new System.Drawing.Point(12, 147);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(40, 40);
            this.btn_pen.TabIndex = 1;
            this.btn_pen.Tag = "1";
            this.btn_pen.UseVisualStyleBackColor = false;
            this.btn_pen.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_colorSet
            // 
            this.btn_colorSet.BackColor = System.Drawing.Color.Transparent;
            this.btn_colorSet.BackgroundImage = global::Paint.Properties.Resources.wheel_5_ryb;
            this.btn_colorSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_colorSet.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_colorSet.FlatAppearance.BorderSize = 0;
            this.btn_colorSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colorSet.Location = new System.Drawing.Point(3, 17);
            this.btn_colorSet.Name = "btn_colorSet";
            this.btn_colorSet.Size = new System.Drawing.Size(61, 46);
            this.btn_colorSet.TabIndex = 0;
            this.btn_colorSet.UseVisualStyleBackColor = false;
            this.btn_colorSet.Click += new System.EventHandler(this.btn_colorSet_Click);
            // 
            // btn_max
            // 
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_max.ForeColor = System.Drawing.Color.White;
            this.btn_max.Image = global::Paint.Properties.Resources.sq;
            this.btn_max.Location = new System.Drawing.Point(722, 2);
            this.btn_max.Margin = new System.Windows.Forms.Padding(0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(39, 24);
            this.btn_max.TabIndex = 7;
            this.btn_max.Text = "=";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Paint.Properties.Resources.add_new_icon_8;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Paint.Properties.Resources.folder_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Paint.Properties.Resources.save_icon;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::Paint.Properties.Resources.cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Paint.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Paint.Properties.Resources.paste_icon;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.panel_width.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_colorSet;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_width1;
        private System.Windows.Forms.Button btn_width2;
        private System.Windows.Forms.Button btn_width3;
        private System.Windows.Forms.PictureBox PenColor;
        private System.Windows.Forms.Panel panel_width;
        private System.Windows.Forms.Button btn_info;
    }
}