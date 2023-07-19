using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace SQLMusicApp
{
    public class AlbumDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

        public List<Album> getAllAlbums()
        {
            List<Album> album = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * From album", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
              while(reader.Read()) 
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    //second call to database in following line in previous loop slows down database significantly
                    // Remove following line to get the the function to its original version and no List in Album class
                    a.tracks = GetAllTracks(a.ID);
                    album.Add(a);
                
                }  
            }
            connection.Close();
            return album;
        }

        internal int AddOneAlbum(Album album)
        {
            int record = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); 
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO `album` (`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_URL`, `DESCRIPTION`) VALUES ( @album_title, @artist, @year, @image_URL, @desc)";
                command.Connection = connection;
                command.Parameters.AddWithValue("album_title", album.AlbumName);
                command.Parameters.AddWithValue("artist", album.ArtistName);
                command.Parameters.AddWithValue("year", album.Year);
                command.Parameters.AddWithValue("image_URL", album.ImageURL);
                command.Parameters.AddWithValue("desc", album.Description);
                record = command.ExecuteNonQuery();
                connection.Close();
            }
            
           
            return record;
        }

        internal List<Album> SearchAlbums(string searchphrase)
        {
            List<Album> album = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_URL, DESCRIPTION" +
                " FROM album WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("search", searchphrase);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    album.Add(a);

                }
            }
            connection.Close();
            return album;
        }

        internal List<Track> GetAllTracks(int albumID)
        {
            List<Track> track = new List<Track>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM tracks WHERE album_ID = @search";
            command.Parameters.AddWithValue("search", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Track_Title = reader.GetString(1),
                        Track_Number = reader.GetInt32(2),
                        Video_URL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                        Album_ID = reader.GetInt32(5)
                       
                    };
                    track.Add(t);

                }
            }
            connection.Close();
            return track;
        }

       
        internal List<JObject> GetAllTracksUsingJoins(int albumID)
        {
            List<JObject> track = new List<JObject>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT tracks.ID , TRACK_TITLE, album.ALBUM_TITLE, VIDEO_URL, LYRICS FROM tracks JOIN album ON tracks.album_ID = album.ID WHERE album_ID = @search";
            command.Parameters.AddWithValue("search", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject t = new JObject();    
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            t.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        }
                        

                    };
                    track.Add(t);

                }
            }
            connection.Close();
            return track;
        }

        internal int DeleteOneTrack(int trackID)
        {
           
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `tracks` WHERE ID = @trackid";
            command.Parameters.AddWithValue("trackid", trackID);
            command.Connection = connection;
            int deleted = command.ExecuteNonQuery();
            connection.Close();
            return deleted;
        }

        internal int UpdateAlbum(Album album)
        {
            int record = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "UPDATE `album` SET `ALBUM_TITLE` = @album_title, `ARTIST` = @artist, `YEAR` = @year, `IMAGE_URL` = @image_URL, `DESCRIPTION` = @desc WHERE `album`.`ID` = @id";
                command.Connection = connection;
                command.Parameters.AddWithValue("id", album.ID);
                command.Parameters.AddWithValue("album_title", album.AlbumName);
                command.Parameters.AddWithValue("artist", album.ArtistName);
                command.Parameters.AddWithValue("year", album.Year);
                command.Parameters.AddWithValue("image_URL", album.ImageURL);
                command.Parameters.AddWithValue("desc", album.Description);
                record = command.ExecuteNonQuery();
                connection.Close();
            }
            return record;
        }

        internal int UpdateTrack(Track t)
        {
            int record = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "UPDATE `tracks` SET `TRACK_TITLE` = @title, `TRACK_NUMBER` = @tracknumber, `VIDEO_URL` = @video_URL, `LYRICS` = @lyrics, `album_ID` = @albumid WHERE `tracks`.`ID` = @id";
                command.Connection = connection;
                command.Parameters.AddWithValue("id", t.ID);
                command.Parameters.AddWithValue("title", t.Track_Title);
                command.Parameters.AddWithValue("tracknumber", t.Track_Number);
                command.Parameters.AddWithValue("video_URL", t.Video_URL);
                command.Parameters.AddWithValue("lyrics", t.Lyrics);
                command.Parameters.AddWithValue("albumid", t.Album_ID);
                record = command.ExecuteNonQuery();
                connection.Close();
            }
            return record;
        }

        internal int AddOneTrack(Track t)
        {
            int record = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO `tracks` (`ID`, `TRACK_TITLE`, `TRACK_NUMBER`, `VIDEO_URL`, `LYRICS`, `album_ID`) VALUES (NULL, @title, @tracknumber, @video_URL, @lyrics, @albumid)";
                command.Connection = connection;
                
                command.Parameters.AddWithValue("title", t.Track_Title);
                command.Parameters.AddWithValue("tracknumber", t.Track_Number);
                command.Parameters.AddWithValue("video_URL", t.Video_URL);
                command.Parameters.AddWithValue("lyrics", t.Lyrics);
                command.Parameters.AddWithValue("albumid", t.Album_ID);
                record = command.ExecuteNonQuery();
                connection.Close();
            }
            return record;
        }

        internal int DeleteOneAlbum(int albumID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `album` WHERE ID = @albumid";
            command.Parameters.AddWithValue("albumid", albumID);
            command.Connection = connection;
            int deleted = command.ExecuteNonQuery();
            connection.Close();
            return deleted;
        }
    }
}
