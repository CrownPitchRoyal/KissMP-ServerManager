using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;


/*
 * 
 * Made by: CrownPitch Royal#0471
 * 
 * Modify and improve this code however 
 * you like just leave this comment intact.
 * 
 */


namespace ServerManager
{
    public partial class Form1 : Form
    {
        public string rootDir;
        List<ServerList> sl = new List<ServerList>();

        List<ServerList> dgvStart = new List<ServerList>();

        bool IDC = false;


        public Form1()
        {
            InitializeComponent();
        }

        //SELECT A ROOT FOLDER
        private void selectROOTDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbLIST.Text = "";
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        rootDir = fbd.SelectedPath;
                        lROOTdir.Text = rootDir;
                        LoadServers();
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }

        //LOAD ALL SERVERS FROM FOLDERS THAT EXIST
        public void LoadServers()
        {
            try
            {
                string[] dirs = Directory.GetDirectories(rootDir);
                if (dirs.Length == 0)
                {
                    MessageBox.Show("No valid servers found!");
                }
                else
                {
                    foreach (var item in dirs)
                    {
                        string serverLocation = item + "\\config.json";
                        if (File.Exists(serverLocation) && Directory.GetFiles(item, "*.exe").Length != 0)
                        {
                            ServerList server = new ServerList();
                            server.ServerName = item.Substring(item.LastIndexOf('\\'));
                            server.ServerPath = item;


                            string[] files = Directory.GetFiles(item, "*.exe");
                            if (File.Exists(files[0]))
                            {
                                server.ServerExe = Path.GetFileName(files[0]).Replace(".exe", "");
                            }

                            sl.Add(server);
                            rtbLIST.Text += server.ServerName + "\n";
                        }
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }


        //SAVE ROOT DIR
        private void saveROOTDirLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("rootDir", rootDir);
                MessageBox.Show("Saved!");
            }
            catch (Exception err) { EH(err); }
        }

        //DESAVE ROOT DIR
        private void clearROOTDirLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("rootDir"))
                {
                    File.Delete("rootDir");
                    MessageBox.Show("Cleared!");
                }
            }
            catch (Exception err) { EH(err); }
        }

        //ON APP SHOWN
        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("rootDir"))
                {
                    string vrstice = File.ReadAllText("rootDir");
                    if (!String.IsNullOrEmpty(vrstice))
                    {
                        rootDir = vrstice;
                        lROOTdir.Text = rootDir;
                        LoadServers();
                    }
                }
                LoadSettings();
            }
            catch (Exception err) { EH(err); }
        }

        //LOADS DATA FROM FILES THAT WAS SAVED
        public void LoadSettings()
        {
            try
            {
                if (File.Exists("setting"))
                {
                    string vrstice = File.ReadAllText("setting");
                    if (!String.IsNullOrEmpty(vrstice))
                    {
                        IDC = Convert.ToBoolean(vrstice);
                    }
                }
                if (IDC) { lLIMIT.Visible = true; }
                else { lLIMIT.Visible = false; }
            }
            catch (Exception err) { EH(err); }
        }


        //REMOVE
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbLIST.Text.Length > 0)
                {
                    DialogResult rd = MessageBox.Show("Are you sure you want to DELETE all files and folders in each 'addons' folder of every server?", "Caution!", MessageBoxButtons.YesNo);
                    if (rd == DialogResult.Yes)
                    {
                        foreach (var item in sl)
                        {
                            string addonsF = item.ServerPath + "\\addons";
                            if (Directory.Exists(addonsF))
                            {
                                Directory.Delete(addonsF, true);
                            }
                            if (!Directory.Exists(addonsF))
                            {
                                Directory.CreateDirectory(addonsF);
                                MessageBox.Show("All files cleared from 'addons' folder!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No servers loaded!\nClick on 'Select ROOT dir' to select a ROOT dir of servers!");
                }
            }
            catch (Exception err) { EH(err); }
        }

        //REPLACE FILES
        private void btnREPLACE_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbLIST.Text.Length > 0)
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            string sourcePath = fbd.SelectedPath;


                            DialogResult rd = MessageBox.Show("Are you sure you want to REPLACE all files and folders in each 'addons' folder of every server?", "Caution!", MessageBoxButtons.YesNo);
                            if (rd == DialogResult.Yes)
                            {
                                foreach (var item in sl)
                                {
                                    string addonsF = item.ServerPath + "\\addons";
                                    if (Directory.Exists(addonsF))
                                    {
                                        Directory.Delete(addonsF, true);
                                    }
                                    if (!Directory.Exists(addonsF))
                                    {
                                        Directory.CreateDirectory(addonsF);

                                        DirectoryCopy(sourcePath, addonsF, true);

                                        MessageBox.Show("All files copied to 'addons' folder(s)!");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No servers loaded!\nClick on 'Select ROOT dir' to select a ROOT dir of servers!");
                }
            }
            catch (Exception err) { EH(err); }
        }
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            try
            {
                // Get the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();

                // If the destination directory doesn't exist, create it.       
                Directory.CreateDirectory(destDirName);

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string tempPath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(tempPath, false);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string tempPath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }

        //SHUTDOWN ALL SERVERS
        private void btnSHUTDOWN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rd = MessageBox.Show("Are you sure you want SHUTDOWN all running servers?", "Caution!", MessageBoxButtons.YesNo);
                if (rd == DialogResult.Yes)
                {
                    List<string> temp = new List<string>();
                    string laufa = "";
                    foreach (var item in sl)
                    {
                        Process[] localByName = Process.GetProcessesByName(item.ServerExe);
                        if (localByName.Length > 0)
                        {
                            temp.Add(item.ServerExe);
                            laufa += item.ServerExe + "\n";
                        }
                    }
                    laufa += "\nAre you sure you want to stop these servers?";

                    DialogResult rd1 = MessageBox.Show("Found these running servers:\n\n" + laufa, "Stop servers", MessageBoxButtons.YesNo);
                    if (rd1 == DialogResult.Yes)
                    {
                        foreach (var item in temp)
                        {
                            Process[] localByName = Process.GetProcessesByName(item);

                            Process proc = Process.GetProcessById(localByName[0].Id);
                            proc.Kill();
                        }
                        if (temp.Count > 0)
                        {
                            MessageBox.Show("All servers killed.", "AKA all servers offline");
                        }
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }

        //START ALL SERVERS THAT EXIST
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServers(sl);
        }

        //Function that starts the servers listed in the provided list of "ServerList" type
        public void StartServers(List<ServerList> list)
        {
            try
            {
                string laufa = "";
                foreach (var item in list)
                {
                    laufa += item.ServerExe + "\n";
                }

                DialogResult rd = MessageBox.Show("Are you sure you want to start the following servers?\n\n" + laufa, "Start servers", MessageBoxButtons.YesNo);
                if (rd == DialogResult.Yes)
                {
                    int st = 0;
                    string msg = "";
                    foreach (var item in list)
                    {
                        if (st < 10)
                        {
                            Process p = new Process();
                            p.StartInfo = new ProcessStartInfo(item.ServerExe); //"Chrome.exe"
                            p.StartInfo.WorkingDirectory = item.ServerPath;     //@"C:\Program Files\Chrome"; //item.ServerPath
                            p.StartInfo.CreateNoWindow = true;
                            p.Start();
                            if (!IDC)
                            {
                                st++;
                            }
                        }
                        else
                        {
                            msg = "\n more than 10 servers found! Started the first 10.";
                            MessageBox.Show("Servers started sucessfuly!" + msg, "Success!");
                            return;
                        }
                    }
                    Application.OpenForms["Form1"].BringToFront();
                    MessageBox.Show("Servers started sucessfuly!", "Success!");
                }
            }
            catch (Exception err) { EH(err); }
        }

        //OVERRIDE 10 SERVER LIMIT
        private void btnBULLY_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Are you sure you want to allow starting more than 10 servers?\n10 servers per host is maximum allowed. " +
                "\nIf you host more than 10 servers they might dissapear from the server list!", "ADVANCED", MessageBoxButtons.YesNo);
            if (rd == DialogResult.Yes)
            {
                try
                {
                    IDC = true;
                    lLIMIT.Visible = true;

                    DialogResult rd1 = MessageBox.Show("Would you like to save this setting?", "Save?", MessageBoxButtons.YesNo);
                    if (rd1 == DialogResult.Yes)
                    {
                        File.WriteAllText("setting", IDC.ToString());
                        MessageBox.Show("Saved!");
                    }
                    else
                    {
                        if (File.Exists("setting"))
                        {
                            File.Delete("setting");
                            MessageBox.Show("Cleared!");
                            IDC = false;
                            LoadSettings();
                        }
                    }
                }
                catch (Exception err) { EH(err); }
            }
            else
            {
                try
                {
                    if (File.Exists("setting"))
                    {
                        File.Delete("setting");
                        MessageBox.Show("Cleared!");
                        IDC = false;
                        LoadSettings();
                    }
                }
                catch (Exception err) { EH(err); }
            }
        }

        #region "Selective server start"
        private void btnSELSTART_Click(object sender, EventArgs e)
        {
            panelSELSTART.Visible = true;
            dgvSELECT.DataSource = sl;
        }

        private void panelSELSTART_Leave(object sender, EventArgs e)
        {
            panelSELSTART.Visible = false;
        }

        private void panel_btnCancel_Click(object sender, EventArgs e)
        {
            panelSELSTART.Visible = false;
        }

        private void panel_btnSTART_Click(object sender, EventArgs e)
        {
            StartServers(dgvStart);
        }

        private void dgvSELECT_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                dgvStart.Add(sl[row]);
                dgvToStart.DataSource = null;
                dgvToStart.Refresh();
                dgvToStart.DataSource = dgvStart;
                dgvToStart.Refresh();
            }
            catch (Exception err) { EH(err); }
        }

        private void panel_btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStart.Clear();
                dgvToStart.DataSource = dgvSELECT;
                dgvToStart.Refresh();
            }
            catch (Exception err) { EH(err); }
        }
        #endregion


        #region "Save start list for later"
        private void panel_btnSave_Click(object sender, EventArgs e)
        {
            NiImplemented();
            //IEnumerable<ServerList> data = 
            //DataTable table = new DataTable();
            //using (var reader = ObjectReader.Create(data))
            //{
            //    table.Load(reader);
            //}




            //DataTable dt = (DataTable)dgvToStart.DataSource;
            ////File.WriteAllLines("startList", dgvStart);
            //MessageBox.Show("Saved!");
        }

        private void panel_btnUNSAVE_Click(object sender, EventArgs e)
        {
            NiImplemented();
        }
        #endregion

        public void NiImplemented()
        {
            MessageBox.Show("Not implemented yet!");
        }


        //UPDATE ALL SERVERS FROM GITHUB
        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rd1 = MessageBox.Show("Are you sure you want to UPDATE All servers?\n\nBackup of each server will be created.\nBackups can be restored via 'Restore now'.", "UPDATE?", MessageBoxButtons.YesNo);
            if (rd1 == DialogResult.Yes)
            {
                try
                {
                    //CHECK IF FILE AND TEMP DIR EXIST FROM PREVIOUS SESSIONS AND DELETE THEM
                    if (Directory.Exists("temp"))
                    {
                        Directory.Delete("temp", true);
                    }
                    if (File.Exists("kissmp.zip"))
                    {
                        File.Delete("kissmp.zip");
                    }


                    //GET LINK OF LATEST TheHellBox release
                    var client = new RestClient("https://api.github.com/");
                    var request = new RestRequest("repos/TheHellBox/KISS-multiplayer/releases/latest");

                    request.AddHeader("Accept", "application / json");
                    request.AddHeader("User-Agent", "PostmanRuntime/7.28.0");
                    request.AddHeader("Host", "api.github.com");

                    var responseGet = client.Get(request);

                    string iscem = "browser_download_url";
                    string iscem2 = ".zip";
                    var json = ((RestSharp.RestResponseBase)responseGet).Content;

                    string link = json.Substring(json.IndexOf(iscem) + iscem.Length + 3);
                    string link2 = link.Substring(0, link.IndexOf(iscem2) + iscem2.Length);


                    //DOWNLOAD
                    WebClient webClient = new WebClient();
                    webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                    webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    webClient.DownloadFile(new Uri(link2), "kissmp.zip");
                    string exePath = AppDomain.CurrentDomain.BaseDirectory + "temp";


                    //EXTRACT
                    if (Directory.Exists(exePath))
                    {
                        ZipFile.ExtractToDirectory("kissmp.zip", exePath);

                        //DELETE DOWNLOADED FILE
                        if (File.Exists("kissmp.zip"))
                        {
                            File.Delete("kissmp.zip");
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(exePath);
                        ZipFile.ExtractToDirectory("kissmp.zip", exePath);

                        //DELETE DOWNLOADED FILE
                        if (File.Exists("kissmp.zip"))
                        {
                            File.Delete("kissmp.zip");
                        }
                    }

                    //UPDATE
                    string[] dirss = Directory.GetDirectories(exePath);
                    if (dirss.Length > 0)
                    {
                        exePath = dirss[0] + "\\windows";

                        if (Directory.Exists(exePath))
                        {
                            string[] files = Directory.GetFiles(exePath);
                            if (files.Length > 0)
                            {
                                foreach (var item in files)
                                {
                                    if (item.Contains("kissmp-server.exe"))
                                    {
                                        exePath = item;
                                    }
                                }
                            }

                            //IF kissmp-server.exe EXISTS, copy to each server dir, rename original exe to name.exe.old rename new one to name.exe
                            if (File.Exists(exePath))
                            {
                                foreach (var item in sl)
                                {
                                    if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe.old")) //IF exe.old exists delete it
                                    {
                                        File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe.old");
                                    }
                                    File.Copy(item.ServerPath + "\\" + item.ServerExe + ".exe", item.ServerPath + "\\" + item.ServerExe + ".exe.old"); //MAKE NEW BACKUP OF OG exe as exe.old

                                    if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe")) //IF OG exists, DELETE
                                    {
                                        File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe");
                                    }
                                    File.Copy(exePath, item.ServerPath + "\\" + item.ServerExe + ".exe"); //COPY NEW EXE IN DIR
                                }
                            }
                        }
                    }

                    //DELETE TEMP FILES
                    if (Directory.Exists("temp"))
                    {
                        Directory.Delete("temp", true);
                    }
                    MessageBox.Show("Servers updated!");
                }
                catch (Exception err) { EH(err); }
            }
        }

        //BACKUP SERVER EXE
        private void bACKUPExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rd1 = MessageBox.Show("Are you sure you want to make a backup of\nevery exe in each of the servers?\n\nBy doing this you can later use 'Restore exe'\nTo replace .exe with .exe.old.\n\nThis action will overwrite old backups!", "Backup?", MessageBoxButtons.YesNo);
            if (rd1 == DialogResult.Yes)
            {
                try
                {
                    foreach (var item in sl)
                    {
                        if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe.old")) //IF exe.old exists delete it
                        {
                            File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe.old");
                        }
                        File.Copy(item.ServerPath + "\\" + item.ServerExe + ".exe", item.ServerPath + "\\" + item.ServerExe + ".exe.old"); //MAKE NEW BACKUP OF OG exe as exe.old
                    }
                    MessageBox.Show("Backup complete!");
                }
                catch (Exception err) { EH(err); }
            }
        }

        //RESTORE SERVER EXE
        private void restoreExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rd1 = MessageBox.Show("Are you sure you want to restore the\n latest backupfor every server?\n\nBy doing this all current exe files will be replaced\nby the latest backup of the servers.\n\nThis action will also overwrite old backups with new ones!", "Restore?", MessageBoxButtons.YesNo);
            if (rd1 == DialogResult.Yes)
            {
                try
                {
                    foreach (var item in sl)
                    {
                        if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe.old")) //IF OLD EXIST GOOD
                        {
                            if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe")) //IF OG exists, BACKUP &DELETE
                            {
                                if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe.rest")) //IF exe.old exists delete it
                                {
                                    File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe.rest");
                                }
                                File.Copy(item.ServerPath + "\\" + item.ServerExe + ".exe", item.ServerPath + "\\" + item.ServerExe + ".exe.rest"); //MAKE NEW BACKUP OF OG exe as exe.rest
                                File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe");
                            }

                            File.Copy(item.ServerPath + "\\" + item.ServerExe + ".exe.old", item.ServerPath + "\\" + item.ServerExe + ".exe"); //Backup -> MAIN

                            if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe.old")) //IF exe.old exists delete it
                            {
                                File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe.old");
                            }
                            File.Copy(item.ServerPath + "\\" + item.ServerExe + ".exe.rest", item.ServerPath + "\\" + item.ServerExe + ".exe.old"); //MAKE NEW BACKUP OF OG exe as exe.old

                            if (File.Exists(item.ServerPath + "\\" + item.ServerExe + ".exe.rest"))
                            {
                                File.Delete(item.ServerPath + "\\" + item.ServerExe + ".exe.rest");
                            }
                        }
                    }
                    MessageBox.Show("Restore complete!");
                }
                catch (Exception err) { EH(err); }
            }
        }

        //ERROR HANDLER
        public void EH(Exception error)
        {
            try
            {
                MessageBox.Show(error.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://crownpitchroyal.com/ServerManager/help.html");
        }
    }

    public class ServerList
    {
        public string ServerName { get; set; }
        public string ServerPath { get; set; }
        public string ServerExe { get; set; }

        public ServerList()
        { }

        public ServerList(string sName, string sPath, string sExe)
        {
            ServerName = sName;
            ServerPath = sPath;
            ServerExe = sExe;
        }
    }
}
