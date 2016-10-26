using System.Windows.Forms;

namespace RedditOnWindows
{
    partial class MainWindow
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
            this.subredditListView = new System.Windows.Forms.ListView();
            this.poweredbyReddit = new System.Windows.Forms.Label();
            this.subredditURL = new System.Windows.Forms.TextBox();
            this.subredditURLGo = new System.Windows.Forms.Button();
            //this.subredditNextPage = new System.Windows.Forms.Button();
            //this.subredditPrevPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subredditListView - shows the list of entries of a subreddit
            // 
            this.subredditListView.Location = new System.Drawing.Point(15, 30);
            this.subredditListView.Name = "subredditListView";
            this.subredditListView.Size = new System.Drawing.Size(975, 445);
            this.subredditListView.TabIndex = 0;
            this.subredditListView.DoubleClick += new System.EventHandler(this.subredditListView_DoubleClick);
            this.subredditListView.KeyPress += new KeyPressEventHandler(this.subredditListView_KeyPress);
            this.subredditListView.MouseClick += new MouseEventHandler(this.subredditListView_RightClick);
            this.subredditListView.UseCompatibleStateImageBehavior = false;
            // 
            // poweredbyReddit - states that this app relies on Reddit
            // 
            this.poweredbyReddit.AutoSize = true;
            this.poweredbyReddit.Location = new System.Drawing.Point(445, 480);
            this.poweredbyReddit.Name = "powered by Reddit";
            this.poweredbyReddit.Size = new System.Drawing.Size(35, 13);
            this.poweredbyReddit.TabIndex = 1;
            this.poweredbyReddit.Text = "powered by Reddit";
            // 
            // subredditURL - Subreddit Input Form
            // 
            this.subredditURL.Location = new System.Drawing.Point(15, 5);
            this.subredditURL.Name = "subredditURL";
            this.subredditURL.Text = "Enter Subreddit Name Here";
            this.subredditURL.Size = new System.Drawing.Size(170, 20);
            this.subredditURL.TabIndex = 2;
            // 
            // subredditURLGo - Subreddit Confirmation Button
            // 
            this.subredditURLGo.Location = new System.Drawing.Point(190, 5);
            this.subredditURLGo.Name = "subredditURLGo";
            this.subredditURLGo.Size = new System.Drawing.Size(50, 20);
            this.subredditURLGo.TabIndex = 3;
            this.subredditURLGo.Text = "Go";
            this.subredditURLGo.UseVisualStyleBackColor = true;
            this.subredditURLGo.Click += new System.EventHandler(this.subredditURLGo_Click);

            /*
            //
            // subredditPrevPage - Previous Page Button
            //
            this.subredditPrevPage.Location = new System.Drawing.Point(245, 5);
            this.subredditPrevPage.Name = "Prev";
            this.subredditPrevPage.Size = new System.Drawing.Size(50, 20);
            this.subredditPrevPage.TabIndex = 4;
            this.subredditPrevPage.Text = "Prev";
            this.subredditPrevPage.UseVisualStyleBackColor = true;
            this.subredditPrevPage.Click += new System.EventHandler(this.subredditPrevPage_Click);
            //
            // subredditNextPage - Next Page Button
            //
            this.subredditNextPage.Location = new System.Drawing.Point(300, 5);
            this.subredditNextPage.Name = "Next";
            this.subredditNextPage.Size = new System.Drawing.Size(50, 20);
            this.subredditNextPage.TabIndex = 5;
            this.subredditNextPage.Text = "Next";
            this.subredditNextPage.UseVisualStyleBackColor = true;
            this.subredditNextPage.Click += new System.EventHandler(this.subredditNextPage_Click);
            */

            // 
            // MainWindow - Main Window Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.subredditURLGo);
            this.Controls.Add(this.subredditURL);
            //this.Controls.Add(this.subredditPrevPage);
            //this.Controls.Add(this.subredditNextPage);
            this.Controls.Add(this.poweredbyReddit);
            this.Controls.Add(this.subredditListView);
            this.Name = "MainWindow";
            this.Text = "RedditOnWindows";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView subredditListView;
        private System.Windows.Forms.Label poweredbyReddit;
        private System.Windows.Forms.TextBox subredditURL;
        private System.Windows.Forms.Button subredditURLGo;
        //private System.Windows.Forms.Button subredditNextPage;
        //private System.Windows.Forms.Button subredditPrevPage;
    }
}

