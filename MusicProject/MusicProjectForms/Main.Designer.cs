
namespace MusicProjectForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelButtonSelection = new System.Windows.Forms.Panel();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonSongs = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonArtists = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelList = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelManipulateButtons = new System.Windows.Forms.Panel();
            this.panelAudioControls = new System.Windows.Forms.Panel();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.Add = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.panelBot.SuspendLayout();
            this.panelManipulateButtons.SuspendLayout();
            this.panelAudioControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelButtonSelection);
            this.panelLeft.Controls.Add(this.buttonAlbums);
            this.panelLeft.Controls.Add(this.buttonSongs);
            this.panelLeft.Controls.Add(this.buttonGroups);
            this.panelLeft.Controls.Add(this.buttonArtists);
            this.panelLeft.Controls.Add(this.panelTopLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(162, 580);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panelLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // panelButtonSelection
            // 
            this.panelButtonSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.panelButtonSelection.Location = new System.Drawing.Point(152, 65);
            this.panelButtonSelection.Name = "panelButtonSelection";
            this.panelButtonSelection.Size = new System.Drawing.Size(10, 129);
            this.panelButtonSelection.TabIndex = 2;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAlbums.ForeColor = System.Drawing.Color.White;
            this.buttonAlbums.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlbums.Image")));
            this.buttonAlbums.Location = new System.Drawing.Point(0, 452);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(162, 128);
            this.buttonAlbums.TabIndex = 1;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            this.buttonAlbums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.buttonAlbums.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.buttonAlbums.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // buttonSongs
            // 
            this.buttonSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSongs.FlatAppearance.BorderSize = 0;
            this.buttonSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSongs.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSongs.ForeColor = System.Drawing.Color.White;
            this.buttonSongs.Image = ((System.Drawing.Image)(resources.GetObject("buttonSongs.Image")));
            this.buttonSongs.Location = new System.Drawing.Point(0, 323);
            this.buttonSongs.Name = "buttonSongs";
            this.buttonSongs.Size = new System.Drawing.Size(162, 129);
            this.buttonSongs.TabIndex = 1;
            this.buttonSongs.Text = "Songs";
            this.buttonSongs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSongs.UseVisualStyleBackColor = true;
            this.buttonSongs.Click += new System.EventHandler(this.buttonSongs_Click);
            this.buttonSongs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.buttonSongs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.buttonSongs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGroups.ForeColor = System.Drawing.Color.White;
            this.buttonGroups.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroups.Image")));
            this.buttonGroups.Location = new System.Drawing.Point(0, 194);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(162, 129);
            this.buttonGroups.TabIndex = 1;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            this.buttonGroups.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.buttonGroups.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.buttonGroups.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // buttonArtists
            // 
            this.buttonArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonArtists.FlatAppearance.BorderSize = 0;
            this.buttonArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtists.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArtists.ForeColor = System.Drawing.Color.White;
            this.buttonArtists.Image = ((System.Drawing.Image)(resources.GetObject("buttonArtists.Image")));
            this.buttonArtists.Location = new System.Drawing.Point(0, 65);
            this.buttonArtists.Name = "buttonArtists";
            this.buttonArtists.Size = new System.Drawing.Size(162, 129);
            this.buttonArtists.TabIndex = 1;
            this.buttonArtists.Text = "Artists";
            this.buttonArtists.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonArtists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonArtists.UseVisualStyleBackColor = true;
            this.buttonArtists.Click += new System.EventHandler(this.buttonArtists_Click);
            this.buttonArtists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.buttonArtists.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.buttonArtists.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.panelTopLeft.Controls.Add(this.labelHeading);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(162, 65);
            this.panelTopLeft.TabIndex = 0;
            this.panelTopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panelTopLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panelTopLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelHeading.Location = new System.Drawing.Point(3, 9);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(156, 41);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Orpheus";
            this.labelHeading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.labelHeading.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.labelHeading.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // listViewMain
            // 
            this.listViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.ForeColor = System.Drawing.Color.White;
            this.listViewMain.HideSelection = false;
            this.listViewMain.LargeImageList = this.imageList1;
            this.listViewMain.Location = new System.Drawing.Point(10, 10);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(829, 319);
            this.listViewMain.TabIndex = 2;
            this.listViewMain.TileSize = new System.Drawing.Size(200, 150);
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Tile;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            this.listViewMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.listViewMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.listViewMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.listViewMain);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(162, 31);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(10);
            this.panelList.Size = new System.Drawing.Size(849, 339);
            this.panelList.TabIndex = 3;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonMinimize);
            this.panelButtons.Controls.Add(this.buttonMaximize);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(162, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(849, 31);
            this.panelButtons.TabIndex = 3;
            this.panelButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panelButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panelButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.AutoSize = true;
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(744, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(35, 31);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.AutoSize = true;
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(779, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(35, 31);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(814, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 31);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridViewDetails.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDetails.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewDetails.RowTemplate.Height = 25;
            this.dataGridViewDetails.Size = new System.Drawing.Size(829, 190);
            this.dataGridViewDetails.TabIndex = 1;
            this.dataGridViewDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.dataGridViewDetails.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.dataGridViewDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.panelManipulateButtons);
            this.panelBot.Controls.Add(this.dataGridViewDetails);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(162, 370);
            this.panelBot.Name = "panelBot";
            this.panelBot.Padding = new System.Windows.Forms.Padding(10);
            this.panelBot.Size = new System.Drawing.Size(849, 210);
            this.panelBot.TabIndex = 1;
            this.panelBot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panelBot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panelBot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // panelManipulateButtons
            // 
            this.panelManipulateButtons.Controls.Add(this.panelAudioControls);
            this.panelManipulateButtons.Controls.Add(this.Add);
            this.panelManipulateButtons.Controls.Add(this.buttonEdit);
            this.panelManipulateButtons.Controls.Add(this.buttonDelete);
            this.panelManipulateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManipulateButtons.Location = new System.Drawing.Point(10, 174);
            this.panelManipulateButtons.Name = "panelManipulateButtons";
            this.panelManipulateButtons.Size = new System.Drawing.Size(829, 26);
            this.panelManipulateButtons.TabIndex = 2;
            // 
            // panelAudioControls
            // 
            this.panelAudioControls.Controls.Add(this.buttonSkip);
            this.panelAudioControls.Controls.Add(this.buttonStop);
            this.panelAudioControls.Controls.Add(this.buttonPlay);
            this.panelAudioControls.Controls.Add(this.buttonLeft);
            this.panelAudioControls.Controls.Add(this.trackBarVolume);
            this.panelAudioControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAudioControls.Location = new System.Drawing.Point(0, 0);
            this.panelAudioControls.Name = "panelAudioControls";
            this.panelAudioControls.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelAudioControls.Size = new System.Drawing.Size(408, 26);
            this.panelAudioControls.TabIndex = 10;
            this.panelAudioControls.Visible = false;
            // 
            // buttonSkip
            // 
            this.buttonSkip.AutoSize = true;
            this.buttonSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonSkip.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSkip.FlatAppearance.BorderSize = 0;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Image = ((System.Drawing.Image)(resources.GetObject("buttonSkip.Image")));
            this.buttonSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSkip.Location = new System.Drawing.Point(225, 0);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(35, 26);
            this.buttonSkip.TabIndex = 8;
            this.buttonSkip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.AutoSize = true;
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(190, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(35, 26);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlay.Location = new System.Drawing.Point(155, 0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(35, 26);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.OnButtonPlayClick);
            // 
            // buttonLeft
            // 
            this.buttonLeft.AutoSize = true;
            this.buttonLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeft.Image")));
            this.buttonLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeft.Location = new System.Drawing.Point(120, 0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(35, 26);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarVolume.Location = new System.Drawing.Point(20, 0);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(100, 26);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(582, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(76, 26);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(658, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(76, 26);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(734, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 26);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1011, 580);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(146)))), ((int)(((byte)(234)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Albums";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panelLeft.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.panelBot.ResumeLayout(false);
            this.panelManipulateButtons.ResumeLayout(false);
            this.panelManipulateButtons.PerformLayout();
            this.panelAudioControls.ResumeLayout(false);
            this.panelAudioControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonArtists;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonSongs;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Panel panelButtonSelection;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelManipulateButtons;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panelAudioControls;
    }
}

