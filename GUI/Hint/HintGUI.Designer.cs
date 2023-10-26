
namespace GUI
{
    partial class HintGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HintGUI));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Timer_Title = new System.Windows.Forms.Timer(this.components);
            this.Pbx_Home = new System.Windows.Forms.PictureBox();
            this.Pbx_Tutorial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Tutorial)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(324, 192);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(601, 386);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Btn_Home
            // 
            this.Btn_Home.AutoSize = true;
            this.Btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Home.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.ForeColor = System.Drawing.Color.Black;
            this.Btn_Home.Location = new System.Drawing.Point(50, 121);
            this.Btn_Home.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(100, 37);
            this.Btn_Home.TabIndex = 4;
            this.Btn_Home.Text = "Quay về";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseClick);
            this.Btn_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseDown);
            this.Btn_Home.MouseHover += new System.EventHandler(this.Btn_Home_MouseHover);
            this.Btn_Home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseUp);
            // 
            // Timer_Title
            // 
            this.Timer_Title.Enabled = true;
            this.Timer_Title.Interval = 500;
            // 
            // Pbx_Home
            // 
            this.Pbx_Home.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Home.Location = new System.Drawing.Point(-7, -4);
            this.Pbx_Home.Margin = new System.Windows.Forms.Padding(2);
            this.Pbx_Home.Name = "Pbx_Home";
            this.Pbx_Home.Size = new System.Drawing.Size(311, 184);
            this.Pbx_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Home.TabIndex = 5;
            this.Pbx_Home.TabStop = false;
            // 
            // Pbx_Tutorial
            // 
            this.Pbx_Tutorial.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Tutorial.Location = new System.Drawing.Point(248, 100);
            this.Pbx_Tutorial.Margin = new System.Windows.Forms.Padding(2);
            this.Pbx_Tutorial.Name = "Pbx_Tutorial";
            this.Pbx_Tutorial.Size = new System.Drawing.Size(744, 574);
            this.Pbx_Tutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Tutorial.TabIndex = 6;
            this.Pbx_Tutorial.TabStop = false;
            // 
            // HintGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 774);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Pbx_Home);
            this.Controls.Add(this.Pbx_Tutorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HintGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HintGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HintGUI_FormClosing);
            this.Load += new System.EventHandler(this.HintGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Tutorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Timer Timer_Title;
        private System.Windows.Forms.PictureBox Pbx_Home;
        private System.Windows.Forms.PictureBox Pbx_Tutorial;
    }
}