using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        int RHI_Selection = 0;
        int window_mode = 0;
        int resX = 1280;
        int resY = 720;
        bool mute_all = false;
        bool use_log = false;
        bool fixed_seed = false;
        bool use_one_thread = false;
        int language_index = 0;
        string[] langauges = { "Default", "English", "Français", "中文  - （中国）" };
        string[] lang_codes = { "en", "fr", "zh-Hans-CN" };
        bool disable_texture_stream = false;
        bool no_rhi_thread = false;
        bool force_bypass = false;
        bool all_cores = false;
        bool software_render = false;
        string launch_exe = "";

        public void set_defualt()
        {
            RHI_Selection = 0;
            window_mode = 0;
            resX = 1600;
            resY = 900;
            mute_all = false;
            use_log = false;
            fixed_seed = false;
            use_one_thread = false;
            language_index = 0;
            disable_texture_stream = false;
            no_rhi_thread = false;
            force_bypass = false;
            all_cores = false;
            software_render = false;
            launch_exe = "";
        }
        public void update_all_controls()
        {
            renderer_box.SelectedIndex = RHI_Selection;
            screen_mode.SelectedIndex = window_mode;
            ResolutionX.Value = resX;
            ResolutionY.Value = resY;
            muteAll_box.Checked = mute_all;
            use_log_box.Checked = use_log;
            fixed_seed_box.Checked = fixed_seed;
            one_thread_box.Checked = use_one_thread;
            Language_combobox.Items.Clear();
            foreach (var lang in langauges)
            {
                Language_combobox.Items.Add(lang);
            }
            Language_combobox.SelectedIndex = language_index;
            disable_text_Stream_box.Checked = disable_texture_stream;
            No_rhi_thread_box.Checked = no_rhi_thread;
            RHI_Bypass_box.Checked = force_bypass;
            Use_all_Cores_box.Checked = all_cores;
            software_render_box.Checked = software_render;

            ResolutionX.Enabled = (window_mode == 2);
            ResolutionY.Enabled = (window_mode == 2);

            LAUNCH_Button.Text = File.Exists(launch_exe) ? ("Launch " + Path.GetFileName(launch_exe)) : "No Game exe found";

        }

        public void Reset_Arg_File()
        {
            File.WriteAllText("Arguments.list", "-vulkan\n");
        }

        public string get_all_args_1D()
        {
            string[] temp = File.ReadAllLines("Arguments.list");
            string output = "";
            foreach (var item in temp)
            {
                if (item.StartsWith("Game")) { continue; }
                else
                {
                    output += item;
                    output += " ";
                }
            }
            return output;
        }

        public void Write_to_Arg()
        {
            string output = "";
            switch (RHI_Selection)
            {
                case 0:
                    output += "-d3d11\n"; 
                    break;
                case 1:
                    output += "-d3d12\n";
                    break;
                case 2:
                    output += "-vulkan\n";
                    break;
                default:
                    break;
            }

            switch (window_mode)
            {
                case 1://fullscreen
                    output += "-fullscreen\n";
                    break;
                case 2: //window
                    output += "-windowed\n";
                    output += "-ResX=" + resX + "\n";
                    output += "-ResY=" + resY + "\n";
                    break;
                default:
                    break;

            }

            if (mute_all)
            { output += "-nosound\n"; }


            if (use_log)
            {
                Console.WriteLine("output including log");
                output += "-log\n-newconsole\n";
            }

            if (fixed_seed)
            { output += "-fixedseed\n"; }

            if (use_one_thread)
            { output += "-onethread\n"; }

            if (language_index != 0)
            {
                output += "-culture=\"";
                output += lang_codes[(language_index - 1)];
                output += "\"\n";
            }

            if (disable_texture_stream)
            { output += "-NoTextureStreaming\n"; }

            if (no_rhi_thread)
            { output += "-NoRHIThread\n"; }

            if (force_bypass)
            { output += "-ForceRHIBypass\n"; }

            if (all_cores)
            { output += "-UseAllAvailableCores\n"; }

            if (software_render)
            { output += "-AllowSoftwareRendering\n"; }

            if (File.Exists(launch_exe))
            { output += "Game path = " + launch_exe; }

            File.WriteAllText("Arguments.list", output);
        }

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists("Arguments.list"))
            {
                Reset_Arg_File();
            }


            string[] lines = System.IO.File.ReadAllLines("Arguments.list");
            foreach (string line in lines)
            {
                if (line.StartsWith("Game path = "))
                {
                    launch_exe = line.Substring(12);
                    if (!File.Exists(launch_exe)) launch_exe = "";
                    Console.WriteLine("GAME PATH IS " + launch_exe);
                }
                else if (line.StartsWith("-vulkan"))
                {
                    RHI_Selection = 2;
                    Console.WriteLine("FOUND VULKAN");
                }
                else if (line.StartsWith("-d3d12"))
                {

                    RHI_Selection = 1;
                    Console.WriteLine("FOUND d12");

                }
                else if (line.StartsWith("-d3d11"))
                {
                    RHI_Selection = 0;
                    Console.WriteLine("FOUND d11");
                }
                else if (line.StartsWith("-fullscreen"))
                {
                    window_mode = 1;
                }
                else if (line.StartsWith("-windowed"))
                {
                    window_mode = 2;
                }
                else if (line.StartsWith("-ResX="))
                {
                    Regex re = new Regex(@"\d+");
                    Match m = re.Match(line);
                    if (m.Success)
                    {
                        resX = int.Parse(m.Value);
                    }
                    else
                    {
                        resX = 1280;
                    }
                }
                else if (line.StartsWith("-ResY="))
                {
                    Regex re = new Regex(@"\d+");
                    Match m = re.Match(line);
                    if (m.Success)
                    {
                        resY = int.Parse(m.Value);
                    }
                    else
                    {
                        resY = 720;
                    }
                }
                else if (line.StartsWith("-log"))
                {
                    use_log = true;
                }
                else if (line.StartsWith("-fixedseed"))
                {
                    fixed_seed = true;
                }
                else if (line.StartsWith("-onethread"))
                {
                    use_one_thread = true;
                }
                else if (line.StartsWith("-culture"))
                {
                    if (line.Contains("en"))
                    {
                        language_index = 1;
                    }
                    else if (line.Contains("fr"))
                    {
                        language_index = 2;
                    }
                    else if (line.Contains("zh"))
                    {
                        language_index = 3;
                    }
                    else
                    {
                        language_index = 0;
                    }
                }
                else if (line.StartsWith("-NoTextureStreaming"))
                {
                    disable_texture_stream = true;
                }
                else if (line.StartsWith("-NoRHIThread"))
                {
                    no_rhi_thread = true;
                }
                else if (line.StartsWith("-ForceRHIBypass"))
                {
                    force_bypass = true;
                }
                else if (line.StartsWith("-UseAllAvailableCores"))
                {
                    all_cores = true;
                }
                else if (line.StartsWith("-AllowSoftwareRendering"))
                {
                    software_render = true;
                }
                else if (line.StartsWith("-nosound"))
                {
                    mute_all = true;
                }
                                
                update_all_controls();
            }
        }



        private void reset_to_default(object sender, EventArgs e)
        {
            set_defualt();
            update_all_controls();
            Reset_Arg_File();
        }
        private void LAUNCH(object sender, EventArgs ev)
        {
            Write_to_Arg();
            string args = get_all_args_1D();

            File.WriteAllText("Given Parametres.log", args);

            try
            {
                if (File.Exists(launch_exe) == false)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        Console.WriteLine(launch_exe);
                        try
                        {
                            openFileDialog.InitialDirectory =
                                Directory.Exists(Path.GetDirectoryName(launch_exe))
                                ? Path.GetDirectoryName(launch_exe)
                                : Directory.GetCurrentDirectory();
                        }
                        catch (Exception)
                        {
                            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                        }
                        openFileDialog.Filter = "Game files (*.exe)|*.exe|Game files (*.sh)|*.sh";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            launch_exe = openFileDialog.FileName;
                            Console.WriteLine("Game path has been updated to " + launch_exe);
                            Write_to_Arg();
                            update_all_controls();

                        }
                    }
                }
                else
                {
                    System.Diagnostics.Process myProc = new System.Diagnostics.Process();
                    myProc.StartInfo.FileName = launch_exe;  //Attempting to start a non-existing executable
                    myProc.StartInfo.Arguments = args;
                    myProc.Start();     // Start the application and assign it to the process component.    

                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
            }
            catch (Win32Exception w)
            {
                Console.WriteLine(w.Message);
                Console.WriteLine(w.ErrorCode.ToString());
                Console.WriteLine(w.NativeErrorCode.ToString());
                Console.WriteLine(w.StackTrace);
                Console.WriteLine(w.Source);
                Exception e = w.GetBaseException();
                Console.WriteLine(e.Message);

                if (e.Message.Contains("cannot find the file"))
                {
                    LAUNCH_Button.Text = "Please Select\nGame executable";
                }
            }
        }

        private void RHI_Change(object sender, EventArgs e)
        {
            RHI_Selection = renderer_box.SelectedIndex;
            System.Console.WriteLine(RHI_Selection);
        }
        private void change_windowed_Clicked(object sender, EventArgs e)
        {
            window_mode = screen_mode.SelectedIndex;

            ResolutionX.Enabled = (window_mode == 2);
            ResolutionY.Enabled = (window_mode == 2);

        }
        private void save_clicked(object sender, EventArgs e)
        {
            Write_to_Arg();

        }

        private void Resolution_Changed(object sender, EventArgs e)
        {
            resX = (int)ResolutionX.Value;
            resY = (int)ResolutionY.Value;

            if (resX < 400)
            {
                resX = 400;
            }
            if (resY < 400)
            {
                resY = 400;
            }
            ResolutionX.Value = resX;
            ResolutionY.Value = resY;

        }

        private void No_rhi_thread_box_CheckedChanged(object sender, EventArgs e)
        {
            no_rhi_thread = No_rhi_thread_box.Checked;
        }


        private void use_log_box_CheckedChanged(object sender, EventArgs e)
        {
            use_log = use_log_box.Checked;
        }

        private void fixed_seed_box_CheckedChanged(object sender, EventArgs e)
        {
            fixed_seed = fixed_seed_box.Checked;
        }

        private void Language_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            language_index = Language_combobox.SelectedIndex;
        }

        private void disable_text_Stream_box_CheckedChanged(object sender, EventArgs e)
        {
            disable_texture_stream = disable_text_Stream_box.Checked;
        }

        private void muteAll_box_CheckedChanged(object sender, EventArgs e)
        {
            mute_all = muteAll_box.Checked;
        }

        private void RHI_Bypass_box_CheckedChanged(object sender, EventArgs e)
        {
            force_bypass = RHI_Bypass_box.Checked;
        }

        private void Use_all_Cores_box_CheckedChanged(object sender, EventArgs e)
        {
            all_cores = Use_all_Cores_box.Checked;
        }

        private void software_render_box_CheckedChanged(object sender, EventArgs e)
        {
            software_render = software_render_box.Checked;
        }

        private void one_thread_box_CheckedChanged(object sender, EventArgs e)
        {
            use_one_thread = one_thread_box.Checked;
        }


    }
}
