
namespace GUI
{

    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renderer_box = new System.Windows.Forms.ComboBox();
            this.Use_Defaults_Button = new System.Windows.Forms.Button();
            this.LAUNCH_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save_Options = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.ResolutionX = new System.Windows.Forms.NumericUpDown();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.ResolutionY = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.screen_mode = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.disable_text_Stream_box = new System.Windows.Forms.CheckBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.Language_combobox = new System.Windows.Forms.ComboBox();
            this.one_thread_box = new System.Windows.Forms.CheckBox();
            this.fixed_seed_box = new System.Windows.Forms.CheckBox();
            this.use_log_box = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.muteAll_box = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.software_render_box = new System.Windows.Forms.CheckBox();
            this.Use_all_Cores_box = new System.Windows.Forms.CheckBox();
            this.RHI_Bypass_box = new System.Windows.Forms.CheckBox();
            this.No_rhi_thread_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderer_box
            // 
            this.renderer_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.renderer_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renderer_box.DisplayMember = "Vulkan";
            this.renderer_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderer_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renderer_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renderer_box.FormattingEnabled = true;
            this.renderer_box.Items.AddRange(new object[] {
            "DirectX 11",
            "DirectX 12",
            "Vulkan"});
            this.renderer_box.Location = new System.Drawing.Point(0, 0);
            this.renderer_box.Margin = new System.Windows.Forms.Padding(6);
            this.renderer_box.MaximumSize = new System.Drawing.Size(100, 0);
            this.renderer_box.MinimumSize = new System.Drawing.Size(20, 0);
            this.renderer_box.Name = "renderer_box";
            this.renderer_box.Size = new System.Drawing.Size(94, 24);
            this.renderer_box.TabIndex = 1;
            this.renderer_box.Tag = "asdf";
            this.renderer_box.ValueMember = "Vulkan";
            this.renderer_box.SelectedValueChanged += new System.EventHandler(this.RHI_Change);
            // 
            // Use_Defaults_Button
            // 
            this.Use_Defaults_Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Use_Defaults_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Use_Defaults_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.Use_Defaults_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Use_Defaults_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Use_Defaults_Button.Location = new System.Drawing.Point(492, 344);
            this.Use_Defaults_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Use_Defaults_Button.Name = "Use_Defaults_Button";
            this.Use_Defaults_Button.Size = new System.Drawing.Size(110, 35);
            this.Use_Defaults_Button.TabIndex = 2;
            this.Use_Defaults_Button.Text = "Use Defaults";
            this.Use_Defaults_Button.UseVisualStyleBackColor = false;
            this.Use_Defaults_Button.Click += new System.EventHandler(this.reset_to_default);
            // 
            // LAUNCH_Button
            // 
            this.LAUNCH_Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAUNCH_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LAUNCH_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.LAUNCH_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAUNCH_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAUNCH_Button.ForeColor = System.Drawing.Color.Black;
            this.LAUNCH_Button.Location = new System.Drawing.Point(620, 333);
            this.LAUNCH_Button.Name = "LAUNCH_Button";
            this.LAUNCH_Button.Size = new System.Drawing.Size(168, 46);
            this.LAUNCH_Button.TabIndex = 1;
            this.LAUNCH_Button.Text = "LAUNCH GAME";
            this.LAUNCH_Button.UseVisualStyleBackColor = false;
            this.LAUNCH_Button.Click += new System.EventHandler(this.LAUNCH);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 447);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Save_Options
            // 
            this.Save_Options.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save_Options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.Save_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Save_Options.Location = new System.Drawing.Point(367, 345);
            this.Save_Options.Margin = new System.Windows.Forms.Padding(0);
            this.Save_Options.Name = "Save_Options";
            this.Save_Options.Size = new System.Drawing.Size(110, 35);
            this.Save_Options.TabIndex = 4;
            this.Save_Options.Text = "Save Settings";
            this.Save_Options.UseVisualStyleBackColor = false;
            this.Save_Options.Click += new System.EventHandler(this.save_clicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(24)))), ((int)(((byte)(100)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(275, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.28947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.71053F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 304);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer4);
            this.groupBox2.Controls.Add(this.splitContainer3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 2, 6, 4);
            this.groupBox2.Size = new System.Drawing.Size(230, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Windowed Resolution";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer4.Location = new System.Drawing.Point(6, 17);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Panel1MinSize = 0;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.ResolutionX);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.Size = new System.Drawing.Size(218, 22);
            this.splitContainer4.SplitterDistance = 132;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resolution X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResolutionX
            // 
            this.ResolutionX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResolutionX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResolutionX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResolutionX.Increment = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ResolutionX.Location = new System.Drawing.Point(0, 0);
            this.ResolutionX.Margin = new System.Windows.Forms.Padding(0);
            this.ResolutionX.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.ResolutionX.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ResolutionX.Name = "ResolutionX";
            this.ResolutionX.Size = new System.Drawing.Size(85, 22);
            this.ResolutionX.TabIndex = 0;
            this.ResolutionX.ThousandsSeparator = true;
            this.ResolutionX.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ResolutionX.ValueChanged += new System.EventHandler(this.Resolution_Changed);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer3.Location = new System.Drawing.Point(6, 44);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Panel1MinSize = 0;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ResolutionY);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Panel2MinSize = 0;
            this.splitContainer3.Size = new System.Drawing.Size(218, 22);
            this.splitContainer3.SplitterDistance = 132;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Resolution Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResolutionY
            // 
            this.ResolutionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResolutionY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResolutionY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResolutionY.Increment = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ResolutionY.Location = new System.Drawing.Point(0, 0);
            this.ResolutionY.Margin = new System.Windows.Forms.Padding(0);
            this.ResolutionY.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.ResolutionY.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ResolutionY.Name = "ResolutionY";
            this.ResolutionY.Size = new System.Drawing.Size(85, 22);
            this.ResolutionY.TabIndex = 0;
            this.ResolutionY.ThousandsSeparator = true;
            this.ResolutionY.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ResolutionY.ValueChanged += new System.EventHandler(this.Resolution_Changed);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 49);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.screen_mode);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(230, 23);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Force Screen Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // screen_mode
            // 
            this.screen_mode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.screen_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screen_mode.DisplayMember = "asdffa";
            this.screen_mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screen_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screen_mode.FormattingEnabled = true;
            this.screen_mode.Items.AddRange(new object[] {
            "None",
            "Fullscreen",
            "Windowed"});
            this.screen_mode.Location = new System.Drawing.Point(0, 0);
            this.screen_mode.MaximumSize = new System.Drawing.Size(100, 0);
            this.screen_mode.MinimumSize = new System.Drawing.Size(20, 0);
            this.screen_mode.Name = "screen_mode";
            this.screen_mode.Size = new System.Drawing.Size(94, 24);
            this.screen_mode.TabIndex = 2;
            this.screen_mode.Tag = "asdf";
            this.screen_mode.ValueMember = "fffff";
            this.screen_mode.SelectedValueChanged += new System.EventHandler(this.change_windowed_Clicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.renderer_box);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(230, 31);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renderer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.disable_text_Stream_box);
            this.groupBox3.Controls.Add(this.splitContainer6);
            this.groupBox3.Controls.Add(this.one_thread_box);
            this.groupBox3.Controls.Add(this.fixed_seed_box);
            this.groupBox3.Controls.Add(this.use_log_box);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(266, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 141);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Advanced";
            // 
            // disable_text_Stream_box
            // 
            this.disable_text_Stream_box.AutoSize = true;
            this.disable_text_Stream_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.disable_text_Stream_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disable_text_Stream_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.disable_text_Stream_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disable_text_Stream_box.Location = new System.Drawing.Point(3, 110);
            this.disable_text_Stream_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.disable_text_Stream_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.disable_text_Stream_box.Name = "disable_text_Stream_box";
            this.disable_text_Stream_box.Size = new System.Drawing.Size(200, 23);
            this.disable_text_Stream_box.TabIndex = 9;
            this.disable_text_Stream_box.Text = "Disable Texture Streaming";
            this.disable_text_Stream_box.UseVisualStyleBackColor = true;
            this.disable_text_Stream_box.CheckedChanged += new System.EventHandler(this.disable_text_Stream_box_CheckedChanged);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(3, 87);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.label6);
            this.splitContainer6.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.Language_combobox);
            this.splitContainer6.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.splitContainer6.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer6.Size = new System.Drawing.Size(231, 23);
            this.splitContainer6.SplitterDistance = 107;
            this.splitContainer6.SplitterWidth = 1;
            this.splitContainer6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Language";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseMnemonic = false;
            // 
            // Language_combobox
            // 
            this.Language_combobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Language_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Language_combobox.DisplayMember = "asdffa";
            this.Language_combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Language_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Language_combobox.FormattingEnabled = true;
            this.Language_combobox.Items.AddRange(new object[] {
            "English",
            "Français ",
            "中文 - ( 中国 )"});
            this.Language_combobox.Location = new System.Drawing.Point(0, 0);
            this.Language_combobox.MinimumSize = new System.Drawing.Size(20, 0);
            this.Language_combobox.Name = "Language_combobox";
            this.Language_combobox.Size = new System.Drawing.Size(118, 24);
            this.Language_combobox.TabIndex = 2;
            this.Language_combobox.Tag = "asdf";
            this.Language_combobox.ValueMember = "fffff";
            this.Language_combobox.SelectedIndexChanged += new System.EventHandler(this.Language_combobox_SelectedIndexChanged);
            // 
            // one_thread_box
            // 
            this.one_thread_box.AutoSize = true;
            this.one_thread_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.one_thread_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one_thread_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.one_thread_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_thread_box.Location = new System.Drawing.Point(3, 64);
            this.one_thread_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.one_thread_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.one_thread_box.Name = "one_thread_box";
            this.one_thread_box.Size = new System.Drawing.Size(200, 23);
            this.one_thread_box.TabIndex = 7;
            this.one_thread_box.Text = "Use One Thread";
            this.one_thread_box.UseVisualStyleBackColor = true;
            this.one_thread_box.CheckedChanged += new System.EventHandler(this.one_thread_box_CheckedChanged);
            // 
            // fixed_seed_box
            // 
            this.fixed_seed_box.AutoSize = true;
            this.fixed_seed_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fixed_seed_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixed_seed_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.fixed_seed_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixed_seed_box.Location = new System.Drawing.Point(3, 41);
            this.fixed_seed_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.fixed_seed_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.fixed_seed_box.Name = "fixed_seed_box";
            this.fixed_seed_box.Size = new System.Drawing.Size(200, 23);
            this.fixed_seed_box.TabIndex = 6;
            this.fixed_seed_box.Text = "Use Fixed Seed";
            this.fixed_seed_box.UseVisualStyleBackColor = true;
            this.fixed_seed_box.CheckedChanged += new System.EventHandler(this.fixed_seed_box_CheckedChanged);
            // 
            // use_log_box
            // 
            this.use_log_box.AutoSize = true;
            this.use_log_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.use_log_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.use_log_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.use_log_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.use_log_box.Location = new System.Drawing.Point(3, 18);
            this.use_log_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.use_log_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.use_log_box.Name = "use_log_box";
            this.use_log_box.Size = new System.Drawing.Size(200, 23);
            this.use_log_box.TabIndex = 5;
            this.use_log_box.Text = "Log Window";
            this.use_log_box.UseVisualStyleBackColor = true;
            this.use_log_box.CheckedChanged += new System.EventHandler(this.use_log_box_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.muteAll_box);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(10, 171);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 52);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Audio";
            // 
            // muteAll_box
            // 
            this.muteAll_box.AutoSize = true;
            this.muteAll_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.muteAll_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteAll_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.muteAll_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteAll_box.Location = new System.Drawing.Point(3, 18);
            this.muteAll_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.muteAll_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.muteAll_box.Name = "muteAll_box";
            this.muteAll_box.Size = new System.Drawing.Size(200, 23);
            this.muteAll_box.TabIndex = 7;
            this.muteAll_box.Text = "Mute All";
            this.muteAll_box.UseVisualStyleBackColor = true;
            this.muteAll_box.CheckedChanged += new System.EventHandler(this.muteAll_box_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.software_render_box);
            this.groupBox5.Controls.Add(this.Use_all_Cores_box);
            this.groupBox5.Controls.Add(this.RHI_Bypass_box);
            this.groupBox5.Controls.Add(this.No_rhi_thread_box);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(266, 171);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 122);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Unknown";
            // 
            // software_render_box
            // 
            this.software_render_box.AutoSize = true;
            this.software_render_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.software_render_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.software_render_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.software_render_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.software_render_box.Location = new System.Drawing.Point(3, 87);
            this.software_render_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.software_render_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.software_render_box.Name = "software_render_box";
            this.software_render_box.Size = new System.Drawing.Size(200, 23);
            this.software_render_box.TabIndex = 6;
            this.software_render_box.Text = "Allow Software Rendering";
            this.software_render_box.UseVisualStyleBackColor = true;
            this.software_render_box.CheckedChanged += new System.EventHandler(this.software_render_box_CheckedChanged);
            // 
            // Use_all_Cores_box
            // 
            this.Use_all_Cores_box.AutoSize = true;
            this.Use_all_Cores_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Use_all_Cores_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Use_all_Cores_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Use_all_Cores_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Use_all_Cores_box.Location = new System.Drawing.Point(3, 64);
            this.Use_all_Cores_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.Use_all_Cores_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.Use_all_Cores_box.Name = "Use_all_Cores_box";
            this.Use_all_Cores_box.Size = new System.Drawing.Size(200, 23);
            this.Use_all_Cores_box.TabIndex = 5;
            this.Use_all_Cores_box.Text = "Use All Available Cores (?)";
            this.Use_all_Cores_box.UseVisualStyleBackColor = true;
            this.Use_all_Cores_box.CheckedChanged += new System.EventHandler(this.Use_all_Cores_box_CheckedChanged);
            // 
            // RHI_Bypass_box
            // 
            this.RHI_Bypass_box.AutoSize = true;
            this.RHI_Bypass_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RHI_Bypass_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RHI_Bypass_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.RHI_Bypass_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RHI_Bypass_box.Location = new System.Drawing.Point(3, 41);
            this.RHI_Bypass_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.RHI_Bypass_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.RHI_Bypass_box.Name = "RHI_Bypass_box";
            this.RHI_Bypass_box.Size = new System.Drawing.Size(200, 23);
            this.RHI_Bypass_box.TabIndex = 4;
            this.RHI_Bypass_box.Text = "Force RHI Bypass (?)";
            this.RHI_Bypass_box.UseVisualStyleBackColor = true;
            this.RHI_Bypass_box.CheckedChanged += new System.EventHandler(this.RHI_Bypass_box_CheckedChanged);
            // 
            // No_rhi_thread_box
            // 
            this.No_rhi_thread_box.AutoSize = true;
            this.No_rhi_thread_box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.No_rhi_thread_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.No_rhi_thread_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.No_rhi_thread_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No_rhi_thread_box.Location = new System.Drawing.Point(3, 18);
            this.No_rhi_thread_box.MaximumSize = new System.Drawing.Size(200, 200);
            this.No_rhi_thread_box.MinimumSize = new System.Drawing.Size(170, 23);
            this.No_rhi_thread_box.Name = "No_rhi_thread_box";
            this.No_rhi_thread_box.Size = new System.Drawing.Size(200, 23);
            this.No_rhi_thread_box.TabIndex = 3;
            this.No_rhi_thread_box.Text = "No RHI Thread (?)";
            this.No_rhi_thread_box.UseVisualStyleBackColor = true;
            this.No_rhi_thread_box.CheckedChanged += new System.EventHandler(this.No_rhi_thread_box_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(24)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Save_Options);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LAUNCH_Button);
            this.Controls.Add(this.Use_Defaults_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forty Three Launcher";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(12)))), ((int)(((byte)(20)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionX)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionY)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Use_Defaults_Button;
        private System.Windows.Forms.Button LAUNCH_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save_Options;
        private System.Windows.Forms.ComboBox renderer_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox screen_mode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ResolutionX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ResolutionY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox muteAll_box;
        private System.Windows.Forms.CheckBox fixed_seed_box;
        private System.Windows.Forms.CheckBox use_log_box;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox one_thread_box;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Language_combobox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox software_render_box;
        private System.Windows.Forms.CheckBox Use_all_Cores_box;
        private System.Windows.Forms.CheckBox RHI_Bypass_box;
        private System.Windows.Forms.CheckBox No_rhi_thread_box;
        private System.Windows.Forms.CheckBox disable_text_Stream_box;
    }
}

