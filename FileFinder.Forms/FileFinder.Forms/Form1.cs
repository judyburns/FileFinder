using System;
using System.IO;
using System.Windows.Forms;

namespace FileFinder.Forms
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamWriter sw;
        int errorcount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // initialize fields
            errorcount = 0;
            errorvalue.Text = "";
            resultsvalue.Items.Clear();

            // path, extension, and search string input are required.
            if (pathvalue.Text == "")
            {
                errorvalue.Text = "You Must Enter a Folder Path to Search";
                errorcount = errorcount + 1;
            }
            else
            if (extvalue.Text == "")
            {
                errorvalue.Text = "You Must Enter a File Extension (eg, XML, TXT, JSON, CONFIG)";
                errorcount = errorcount + 1;
            }
            else
            if (stringvalue.Text == "")
            {
                errorvalue.Text = "You Must Enter a Search String";
                errorcount = errorcount + 1;
            }

            // check to see if an error has occurred. If so, then exit the method.
            if (errorcount > 0)
            {
                return;
            }

            try
            {
                fs = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Start Process");

                // populate listbox with files matching user input.
                PopulateListBox(resultsvalue, pathvalue.Text, extvalue.Text, stringvalue.Text);

                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "End Process");
                sw.Close();
            }
            catch(IOException ex)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "IO Exception Thrown: " + ex.Message);
                sw.Close();
                return;
            }
            catch(Exception ex)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: " + ex.Message);
                sw.Close();
                return;
            }

        }

        // retrieve files within a directory (path) matching the extension given by the user.
        private void PopulateListBox(ListBox resultsvalue, string pathvalue, string extvalue, string stringvalue)
        {
            // The path value given by the user should be an existing directory.
            // If not, DirectoryNotFoundException will be thrown.

            try
            {
                //Set the current directory to the user's path value.
                Directory.SetCurrentDirectory(this.pathvalue.Text);
            }
            catch (DirectoryNotFoundException)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: Directory Path Not Found");
                errorvalue.Text = "An Error Occurred. Directory Path Could Not Be Found";
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            // get files from the current directory with the extension specified by the user.
            // for each file, search its contents for the search string specified by the user.
            // when this string is found, add the file name to the listbox.
            DirectoryInfo directinfo = new DirectoryInfo(pathvalue);
            FileInfo[] files = directinfo.GetFiles("*." + extvalue);
            foreach (FileInfo file in files)
            {
                bool stringfound = false;
                stringfound = SearchFile(file, stringvalue);
                if (stringfound)
                {
                   resultsvalue.Items.Add(file.Name);
                }
            }
        }

        private bool SearchFile(FileInfo file, string stringvalue)
        {
            bool stringfound = false;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file.ToString()))
                {
                    string line;
                    sr.Read();
                    // Read and check lines for search string from the file
                    // until a match is found, or the end of file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.ToLower().Contains(stringvalue.ToLower()))
                        {
                            stringfound = true;
                            break;
                        }
                        else
                        {
                            stringfound = false;
                        }
                        sr.Read();
                    }
                }
            }
            catch (Exception)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: File Not Read");
                errorvalue.Text = "An Error Occurred. A File Could Not Be Read";
                throw;

            }
            return stringfound;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pathvalue.Text = "";
            extvalue.Text = "";
            stringvalue.Text = "";
            resultsvalue.Items.Clear();
        }
    }
}
