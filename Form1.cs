using System.Windows.Forms;

namespace SQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource AlbumBS = new BindingSource();
        BindingSource tracksBS = new BindingSource();
        AlbumDAO albumDAO = new AlbumDAO();
        List<Album> album = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LoadAlbum_Click(object sender, EventArgs e)
        {
            album = albumDAO.getAllAlbums();
            AlbumBS.DataSource = album;
            //line below was before we added track List in Album class above line were not required
            //AlbumBS.DataSource = albumDAO.getAllAlbums();
            dataGridView1.DataSource = AlbumBS;
            comboBox1.DataSource = album;
            comboBox1.DisplayMember = "AlbumName";
            comboBox1.ValueMember = "ID";
     
            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");
            btn_EditAlbum.Enabled = true;
           
            btn_CreateAlbum.Enabled = true;
            btn_Search.Enabled= true;
            btn_CreateTrack.Enabled = true;
            

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            AlbumBS.DataSource = albumDAO.SearchAlbums(txt_Search.Text);
            dataGridView1.DataSource = AlbumBS;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;
            string imageURL = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            try
            {
                pictureBox1.Load(imageURL);
            }
            catch (Exception)
            {

            }

            //int albumID = (int)dataGridView.Rows[currentRow].Cells[0].Value;
            tracksBS.DataSource = album[currentRow].tracks;
            dataGridView2.DataSource = tracksBS;
            if (album[currentRow].tracks.Count > 0)
            {
                btn_EditTrack.Enabled = true;
                btn_DeleteTrack.Enabled = true;
            }
            else
            {
                btn_EditTrack.Enabled = false;
                btn_DeleteTrack.Enabled = false;
            }

        }

        private void btn_CreateAlbum_Click(object sender, EventArgs e)
        {
            if (chk_EditAlbum.Checked)
            {
                Album a = new Album();
                a.ID = int.Parse(txt_AlbumTitle.Tag.ToString());
                a.AlbumName = txt_AlbumTitle.Text;
                a.ArtistName = txt_Artist.Text;
                a.Year = int.Parse(txt_Year.Text);
                a.ImageURL = txt_ImageURL.Text;
                a.Description = txt_Description.Text;
                int albumadded = albumDAO.UpdateAlbum(a);
                MessageBox.Show("You have successfully Updated " + albumadded.ToString() + " album");
                txt_AlbumTitle.Clear();
                txt_Artist.Clear();
                txt_Year.Clear();
                txt_ImageURL.Clear();
                txt_Description.Clear();
                chk_EditAlbum.Checked = false;
                btn_CreateAlbum.Text = "Create Album";
                btn_EditAlbum.Text = "Edit Selected Album";
                refreshAll(sender, e);
            }
            else
            { 
                Album a = new Album();
                a.AlbumName = txt_AlbumTitle.Text;
                a.ArtistName = txt_Artist.Text;
                a.Year = int.Parse(txt_Year.Text);
                a.ImageURL = txt_ImageURL.Text;
                a.Description = txt_Description.Text;
                int albumadded = albumDAO.AddOneAlbum(a);
                MessageBox.Show("You have successfully created " + albumadded.ToString() + " album");
                txt_AlbumTitle.Clear();
                txt_Artist.Clear();
                txt_Year.Clear();
                txt_ImageURL.Clear();
                txt_Description.Clear();
                refreshAll(sender, e);
            }

        }
        private async Task Initiated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private void btn_DeleteTrack_Click(object sender, EventArgs e)
        {
            int currentAlbumRow = dataGridView1.CurrentRow.Index;
            
            
                int currentrow = dataGridView2.CurrentRow.Index;
                int trackID = (int)dataGridView2.Rows[currentrow].Cells[0].Value;

                int deleted = albumDAO.DeleteOneTrack(trackID);


                MessageBox.Show("You have successfully Deleted " + deleted + " track");
                refreshAll(sender, e);
                     
            // 
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow = dataGridView2.CurrentRow.Index;
            string videoURL = (string)dataGridView2.Rows[currentrow].Cells[3].Value;
            await Initiated();
            try
            {
                webView21.CoreWebView2.Navigate(videoURL);
            }
            catch (Exception)
            {

                
            }
            
        }

        private void btn_EditAlbum_Click(object sender, EventArgs e)
        {
            //DataGridView dataGridView = (DataGridView)sender;
            if (chk_EditAlbum.Checked)
            {
                chk_EditAlbum.Checked = false;
                btn_CreateAlbum.Text = "Create Album";
                btn_EditAlbum.Text = "Edit Selected Album";
                txt_AlbumTitle.Text = "";
                txt_Artist.Text = "";
                txt_Year.Text = "";
                txt_ImageURL.Text = "";
                txt_Description.Text = "";


            }
            else
            {
                btn_CreateAlbum.Text = "Update";
                btn_EditAlbum.Text = "Cancel";
                int currentRow = dataGridView1.CurrentRow.Index;

                chk_EditAlbum.Checked = true;
                //This following code also works
                //txt_AlbumID.Text = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
                //txt_AlbumTitle.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
                //txt_Artist.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
                //txt_Year.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
                //txt_ImageURL.Text = dataGridView1.Rows[currentRow].Cells[4].Value.ToString();
                //txt_Description.Text = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();
                Album editMe = album[currentRow];
                txt_AlbumTitle.Tag = editMe.ID.ToString();
                txt_AlbumTitle.Text = editMe.AlbumName;
                txt_Artist.Text = editMe.ArtistName;
                txt_Year.Text = editMe.Year.ToString();
                txt_ImageURL.Text = editMe.ImageURL;
                txt_Description.Text = editMe.Description;


            }
            
        }

        private void btn_CreateTrack_Click(object sender, EventArgs e)
        {
            if (chk_EditTrack.Checked)
            {
                Track t = new Track();
                t.ID = int.Parse(txt_TrackTitle.Tag.ToString());
                t.Track_Title = txt_TrackTitle.Text;
                t.Track_Number = int.Parse(txt_Number.Text);
                t.Video_URL = txt_VideoURL.Text;
                t.Lyrics = txt_Lyrics.Text;
                t.Album_ID = int.Parse(comboBox1.SelectedValue.ToString());
                int trackadded = albumDAO.UpdateTrack(t);
                MessageBox.Show("You have successfully Updated " + trackadded.ToString() + " Track");
                txt_TrackTitle.Clear();
                txt_Number.Clear();
                txt_VideoURL.Clear();
                txt_Lyrics.Clear();
                chk_EditTrack.Checked = false;
                btn_CreateTrack.Text = "Create Track";
                btn_EditTrack.Text = "Edit Selected Track";
                refreshAll(sender, e);
                
                
            }
            else
            {
                Track t = new Track();
                t.Track_Title = txt_TrackTitle.Text;
                t.Track_Number = int.Parse(txt_Number.Text);
                t.Video_URL = txt_VideoURL.Text;
                t.Lyrics = txt_Lyrics.Text;
                t.Album_ID = int.Parse(comboBox1.SelectedValue.ToString());
                int trackadded = albumDAO.AddOneTrack(t);
                MessageBox.Show("You have successfully created " + trackadded.ToString() + " track");
                txt_TrackTitle.Clear();
                txt_Number.Clear();
                txt_VideoURL.Clear();
                txt_Lyrics.Clear();
                refreshAll(sender, e);

            }
        }

        private void btn_EditTrack_Click(object sender, EventArgs e)
        {
            if (chk_EditTrack.Checked)
            {
                chk_EditTrack.Checked = false;
                btn_CreateTrack.Text = "Create Track";
                btn_EditTrack.Text = "Edit Selected Track";
                txt_TrackTitle.Text = "";
                txt_Number.Text = "";
                txt_VideoURL.Text = "";
                txt_Lyrics.Text = "";
                //txt_AlbumID.Text = "";


            }
            else
            {
                btn_CreateTrack.Text = "Update";
                btn_EditTrack.Text = "Cancel";
                int currentRow = dataGridView2.CurrentRow.Index;

                chk_EditTrack.Checked = true;
                //This following code also works
                //txt_AlbumID.Text = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
                //txt_AlbumTitle.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
                //txt_Artist.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
                //txt_Year.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
                //txt_ImageURL.Text = dataGridView1.Rows[currentRow].Cells[4].Value.ToString();
                //txt_Description.Text = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();
                int currentAlbumrow = dataGridView1.CurrentRow.Index;
                Track editMe =  album[currentAlbumrow].tracks[currentRow];
                txt_TrackTitle.Tag = editMe.ID.ToString();
                txt_TrackTitle.Text = editMe.Track_Title;
                txt_Number.Text = editMe.Track_Number.ToString();
                txt_VideoURL.Text = editMe.Video_URL;
                txt_Lyrics.Text = editMe.Lyrics;
                comboBox1.SelectedValue = editMe.Album_ID;
            }
        }

        private void btn_DeleteAlbum_Click(object sender, EventArgs e)
        {
            //Delete an album if and only if it is empty to avoid Orphan deta
            int currentAlbumRow = dataGridView1.CurrentRow.Index;
            if (album[currentAlbumRow].tracks.Count > 0)
            {
                MessageBox.Show("Album has Tracks please Delete tracks or move to another Album");
            }
            else
            {
                int albumID = album[currentAlbumRow].ID;
                albumID = albumDAO.DeleteOneAlbum(albumID);
                MessageBox.Show("You have deleted " + albumID + " Album ");
                refreshAll(sender, e);


            }

        }
       
        private void refreshAll(Object sender, EventArgs e)
        {
           
            btn_LoadAlbum_Click(sender, e);
            int currentAlbumRow = dataGridView1.CurrentRow.Index;
            dataGridView2.DataSource = null;
            tracksBS.DataSource = album[currentAlbumRow].tracks;
            dataGridView2.DataSource = tracksBS;
           
            if (album[currentAlbumRow].tracks.Count > 0)
            {

                btn_DeleteTrack.Enabled = true;
                btn_EditTrack.Enabled = true;

            }
            else 
            {
                btn_DeleteTrack.Enabled = false;
                btn_EditTrack.Enabled = false;
            }
        }


        //Ensuring User enters only 4 digits of integers

        // Custom code
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Year.Mask = "0000";

            txt_Year.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            txt_Year.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }
        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(txt_Year);
        }

        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txt_Year.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", txt_Year, 0, -20, 5000);
            }
            else if (e.Position == txt_Year.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", txt_Year, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", txt_Year, 0, -20, 5000);
            }
        }

        //Custom Code



    }
}