namespace SQLMusicApp
{
    partial class Form1
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
            this.btn_LoadAlbum = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_AlbumTitle = new System.Windows.Forms.TextBox();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.txt_ImageURL = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_CreateAlbum = new System.Windows.Forms.Button();
            this.chk_EditAlbum = new System.Windows.Forms.CheckBox();
            this.btn_DeleteTrack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Year = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_EditTrack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_TrackTitle = new System.Windows.Forms.TextBox();
            this.txt_Number = new System.Windows.Forms.MaskedTextBox();
            this.chk_EditTrack = new System.Windows.Forms.CheckBox();
            this.txt_VideoURL = new System.Windows.Forms.TextBox();
            this.btn_CreateTrack = new System.Windows.Forms.Button();
            this.txt_Lyrics = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_EditAlbum = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_DeleteAlbum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadAlbum
            // 
            this.btn_LoadAlbum.Location = new System.Drawing.Point(238, 12);
            this.btn_LoadAlbum.Name = "btn_LoadAlbum";
            this.btn_LoadAlbum.Size = new System.Drawing.Size(100, 23);
            this.btn_LoadAlbum.TabIndex = 0;
            this.btn_LoadAlbum.Text = "Load / Refresh";
            this.btn_LoadAlbum.UseVisualStyleBackColor = true;
            this.btn_LoadAlbum.Click += new System.EventHandler(this.btn_LoadAlbum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(595, 216);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.Location = new System.Drawing.Point(618, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(88, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(344, 11);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(268, 23);
            this.txt_Search.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(848, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_AlbumTitle
            // 
            this.txt_AlbumTitle.Location = new System.Drawing.Point(94, 19);
            this.txt_AlbumTitle.Name = "txt_AlbumTitle";
            this.txt_AlbumTitle.Size = new System.Drawing.Size(100, 23);
            this.txt_AlbumTitle.TabIndex = 5;
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(94, 48);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(100, 23);
            this.txt_Artist.TabIndex = 6;
            // 
            // txt_ImageURL
            // 
            this.txt_ImageURL.Location = new System.Drawing.Point(94, 106);
            this.txt_ImageURL.Name = "txt_ImageURL";
            this.txt_ImageURL.Size = new System.Drawing.Size(100, 23);
            this.txt_ImageURL.TabIndex = 8;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(94, 136);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(100, 23);
            this.txt_Description.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Album Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Artist Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Image URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(240, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(238, 304);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(451, 220);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_CreateAlbum
            // 
            this.btn_CreateAlbum.Enabled = false;
            this.btn_CreateAlbum.Location = new System.Drawing.Point(6, 176);
            this.btn_CreateAlbum.Name = "btn_CreateAlbum";
            this.btn_CreateAlbum.Size = new System.Drawing.Size(94, 23);
            this.btn_CreateAlbum.TabIndex = 17;
            this.btn_CreateAlbum.Text = "Create Album";
            this.btn_CreateAlbum.UseVisualStyleBackColor = true;
            this.btn_CreateAlbum.Click += new System.EventHandler(this.btn_CreateAlbum_Click);
            // 
            // chk_EditAlbum
            // 
            this.chk_EditAlbum.AutoSize = true;
            this.chk_EditAlbum.Enabled = false;
            this.chk_EditAlbum.Location = new System.Drawing.Point(106, 180);
            this.chk_EditAlbum.Name = "chk_EditAlbum";
            this.chk_EditAlbum.Size = new System.Drawing.Size(46, 19);
            this.chk_EditAlbum.TabIndex = 18;
            this.chk_EditAlbum.Tag = "Edit Mode Enabled";
            this.chk_EditAlbum.Text = "Edit";
            this.toolTip1.SetToolTip(this.chk_EditAlbum, "Edit Mode is enabled");
            this.chk_EditAlbum.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteTrack
            // 
            this.btn_DeleteTrack.Enabled = false;
            this.btn_DeleteTrack.Location = new System.Drawing.Point(446, 278);
            this.btn_DeleteTrack.Name = "btn_DeleteTrack";
            this.btn_DeleteTrack.Size = new System.Drawing.Size(134, 23);
            this.btn_DeleteTrack.TabIndex = 19;
            this.btn_DeleteTrack.Text = "Delete Selected Track";
            this.btn_DeleteTrack.UseVisualStyleBackColor = true;
            this.btn_DeleteTrack.Click += new System.EventHandler(this.btn_DeleteTrack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Year);
            this.groupBox1.Controls.Add(this.txt_Artist);
            this.groupBox1.Controls.Add(this.txt_AlbumTitle);
            this.groupBox1.Controls.Add(this.chk_EditAlbum);
            this.groupBox1.Controls.Add(this.btn_CreateAlbum);
            this.groupBox1.Controls.Add(this.txt_ImageURL);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 209);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create/Update Album";
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(94, 77);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 23);
            this.txt_Year.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webView21);
            this.panel1.Location = new System.Drawing.Point(697, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 272);
            this.panel1.TabIndex = 21;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(436, 272);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // btn_EditTrack
            // 
            this.btn_EditTrack.Enabled = false;
            this.btn_EditTrack.Location = new System.Drawing.Point(299, 278);
            this.btn_EditTrack.Name = "btn_EditTrack";
            this.btn_EditTrack.Size = new System.Drawing.Size(134, 23);
            this.btn_EditTrack.TabIndex = 22;
            this.btn_EditTrack.Text = "Edit Selected Track";
            this.btn_EditTrack.UseVisualStyleBackColor = true;
            this.btn_EditTrack.Click += new System.EventHandler(this.btn_EditTrack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txt_TrackTitle);
            this.groupBox2.Controls.Add(this.txt_Number);
            this.groupBox2.Controls.Add(this.chk_EditTrack);
            this.groupBox2.Controls.Add(this.txt_VideoURL);
            this.groupBox2.Controls.Add(this.btn_CreateTrack);
            this.groupBox2.Controls.Add(this.txt_Lyrics);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 209);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create/Update Tracks";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // txt_TrackTitle
            // 
            this.txt_TrackTitle.Location = new System.Drawing.Point(94, 19);
            this.txt_TrackTitle.Name = "txt_TrackTitle";
            this.txt_TrackTitle.Size = new System.Drawing.Size(100, 23);
            this.txt_TrackTitle.TabIndex = 5;
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(94, 48);
            this.txt_Number.Mask = "00";
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(100, 23);
            this.txt_Number.TabIndex = 6;
            this.txt_Number.ValidatingType = typeof(int);
            // 
            // chk_EditTrack
            // 
            this.chk_EditTrack.AutoSize = true;
            this.chk_EditTrack.Enabled = false;
            this.chk_EditTrack.Location = new System.Drawing.Point(106, 180);
            this.chk_EditTrack.Name = "chk_EditTrack";
            this.chk_EditTrack.Size = new System.Drawing.Size(46, 19);
            this.chk_EditTrack.TabIndex = 18;
            this.chk_EditTrack.Text = "Edit";
            this.chk_EditTrack.UseVisualStyleBackColor = true;
            // 
            // txt_VideoURL
            // 
            this.txt_VideoURL.Location = new System.Drawing.Point(94, 77);
            this.txt_VideoURL.Name = "txt_VideoURL";
            this.txt_VideoURL.Size = new System.Drawing.Size(100, 23);
            this.txt_VideoURL.TabIndex = 7;
            // 
            // btn_CreateTrack
            // 
            this.btn_CreateTrack.Enabled = false;
            this.btn_CreateTrack.Location = new System.Drawing.Point(6, 176);
            this.btn_CreateTrack.Name = "btn_CreateTrack";
            this.btn_CreateTrack.Size = new System.Drawing.Size(94, 23);
            this.btn_CreateTrack.TabIndex = 17;
            this.btn_CreateTrack.Text = "Create Track";
            this.btn_CreateTrack.UseVisualStyleBackColor = true;
            this.btn_CreateTrack.Click += new System.EventHandler(this.btn_CreateTrack_Click);
            // 
            // txt_Lyrics
            // 
            this.txt_Lyrics.Location = new System.Drawing.Point(94, 106);
            this.txt_Lyrics.Name = "txt_Lyrics";
            this.txt_Lyrics.Size = new System.Drawing.Size(100, 23);
            this.txt_Lyrics.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Track Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Album";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Track Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Lyrics";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Video URL";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(SQLMusicApp.Album);
            // 
            // btn_EditAlbum
            // 
            this.btn_EditAlbum.Enabled = false;
            this.btn_EditAlbum.Location = new System.Drawing.Point(712, 12);
            this.btn_EditAlbum.Name = "btn_EditAlbum";
            this.btn_EditAlbum.Size = new System.Drawing.Size(121, 23);
            this.btn_EditAlbum.TabIndex = 23;
            this.btn_EditAlbum.Text = "Edit Selected Album";
            this.btn_EditAlbum.UseVisualStyleBackColor = true;
            this.btn_EditAlbum.Click += new System.EventHandler(this.btn_EditAlbum_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipTitle = "ToolTip";
            // 
            // btn_DeleteAlbum
            // 
            this.btn_DeleteAlbum.Location = new System.Drawing.Point(839, 12);
            this.btn_DeleteAlbum.Name = "btn_DeleteAlbum";
            this.btn_DeleteAlbum.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteAlbum.TabIndex = 24;
            this.btn_DeleteAlbum.Text = "Delete Album";
            this.btn_DeleteAlbum.UseVisualStyleBackColor = true;
            this.btn_DeleteAlbum.Click += new System.EventHandler(this.btn_DeleteAlbum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 554);
            this.Controls.Add(this.btn_DeleteAlbum);
            this.Controls.Add(this.btn_EditAlbum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_EditTrack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeleteTrack);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_LoadAlbum);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_LoadAlbum;
        private DataGridView dataGridView1;
        private Button btn_Search;
        private TextBox txt_Search;
        private PictureBox pictureBox1;
        private TextBox txt_AlbumTitle;
        private TextBox txt_Artist;
        private TextBox txt_ImageURL;
        private TextBox txt_Description;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
        private Button btn_CreateAlbum;
        private CheckBox chk_EditAlbum;
        private Button btn_DeleteTrack;
        private GroupBox groupBox1;
        private Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btn_EditTrack;
        private GroupBox groupBox2;
        private TextBox txt_TrackTitle;
        private CheckBox chk_EditTrack;
        private TextBox txt_VideoURL;
        private Button btn_CreateTrack;
        private TextBox txt_Lyrics;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btn_EditAlbum;
        private ToolTip toolTip1;
        private Button btn_DeleteAlbum;
        private MaskedTextBox txt_Year;
        private MaskedTextBox txt_Number;
        private ComboBox comboBox1;
        private BindingSource albumBindingSource;
    }
}