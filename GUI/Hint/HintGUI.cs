using GUI.MessageBoxes;
using GUI.Ultils;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace GUI
{
    //this class uses for show GUI of Hint option in game 
    public partial class HintGUI : Form
    {
        private bool dirTitle = false;
        private int piv = 0;
        public HintGUI() =>
            InitializeComponent();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }
        //load form
        private void HintGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_Home.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Ultilities.ControlUltils.changeParent(Btn_Home, Pbx_Home, new Point(Btn_Home.Location.X, Btn_Home.Location.Y));


            Program.runAnimation(AnimationState.SINK, this);
        }
        private void loadImages()
        {
            Pbx_Home.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\back.png");
            Pbx_Tutorial.Image = Ultilities.ControlUltils.getImageFromFile(@"Hint\border2.png");
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Hint\background.jpg");
            //Pbx_Title.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\button.png");
        }
        //change background of the button when mouse hover
        private void Btn_Home_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Black;
        }

        //change background of the button when mouse leave
        private void Btn_Home_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.DarkCyan;

        //set effect of the title


        //back to start menu 
        private void Btn_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Home.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.START, new StartGUI());
        }

        private void Btn_Home_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_Home_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void HintGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.List_HiddenForms.Count <= 0)
            {
                Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
                StringManagement.MessTitle, StringManagement.Leave_Mess);
                if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
                    Application.ExitThread();
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
