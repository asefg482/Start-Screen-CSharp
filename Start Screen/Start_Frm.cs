using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_Screen
{
    public partial class Start_Frm : Form
    {
        Timer timer = new Timer();

        bool isPanelDragged = false;
        Point offset;

        public Start_Frm()
        {
            InitializeComponent();
            SetAndStartTimer();
        }

        private void SetAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            Tmr_Loading.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;
            if (count == 20)
            {
                Lbl_Show_Morning.Text = "Checking Users";
            }
            if (count == 60)
            {
                Lbl_Show_Morning.Text = "Checking DataBase Manager";
            }
            if (count == 80)
            {
                Lbl_Show_Morning.Text = "Access Checking";
            }
            if (count == 100)
            {
                Lbl_Show_Morning.Text = "Timer Checking";
            }
            if (count == 130)
            {
                Lbl_Show_Morning.Text = "Opening App . . .";
            }
            if (count == 160)
            {
                Lbl_Show_Morning.Text = "Opening App . . .";
            }
            if (count == 200)
            {
                Lbl_Show_Morning.Text = "Checking DataBase";
            }

            if (count == 200)
            {
                Lbl_Show_Morning.Text = "Checking DateBase";
                //Get_User_Data();
            }

            if (count == 250)
            {
                Lbl_Show_Morning.Text = "Opening App . . .";
            }

            if (count == 300)
            {
                Lbl_Loading.Text = "Welcome";
                //new User_Frm().Show();
                MessageBox.Show("Welcome");
                this.Hide();
            }
            if (count == 320)
            {
                timer.Stop();
                Tmr_Loading.Stop();
                Hide();
            }
        }


        #region Controller        
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isPanelDragged = false;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPanelDragged)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isPanelDragged = false;
        }
        #endregion
        private void Start_Frm_Load(object sender, EventArgs e)
        {

        }

        //private void Get_User_Data()
        //{
        //    try
        //    {
        //        string Is_Active = "";
        //        var User_Pass = from i in new Db().Db_User select i;
        //        foreach (var item in User_Pass)
        //        {
        //            Is_Active = item.Active_Inactive;
        //        }
        //        if (Is_Active == "فعال")
        //        {
        //            if (User_Pass.Any())
        //            {

        //                foreach (var item in User_Pass)
        //                {

        //                    Is_Active = item.Active_Inactive;
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show("خطا ی امنیتی با برنامه نویس تماس بگیرید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Application.Exit();
        //    }
        //}

        private void Tmr_Loading_Tick(object sender, EventArgs e)
        {
            if (Lbl_Loading.Text == "Loading . . .")
            {
                Lbl_Loading.Text = "Loading";
            }
            else if (Lbl_Loading.Text == "Loading")
            {
                Lbl_Loading.Text = "Loading .";
            }
            else if (Lbl_Loading.Text == "Loading .")
            {
                Lbl_Loading.Text = "Loading . .";
            }
            else if (Lbl_Loading.Text == "Loading . .")
            {
                Lbl_Loading.Text = "Loading . . .";
            }
            else
            {
                Lbl_Loading.Text = "Welcome";
            }
        }

        private void Chb_Top_Most_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                Chb_Top_Most.Checked = false;
                this.TopMost = false;
            }
            else
            {
                Chb_Top_Most.Checked = true;
                this.TopMost = true;
            }
        }

        private void Tmr_Opacity_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.10;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
