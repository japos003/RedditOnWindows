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
            this.SuspendLayout();
            // 
            // subredditListView
            // 
            this.subredditListView.Location = new System.Drawing.Point(15, 30);
            this.subredditListView.Name = "subredditListView";
            this.subredditListView.Size = new System.Drawing.Size(975, 445);
            this.subredditListView.TabIndex = 0;
            this.subredditListView.DoubleClick += new System.EventHandler(this.subredditListView_DoubleClick);
            this.subredditListView.UseCompatibleStateImageBehavior = false;
            // 
            // poweredbyReddit
            // 
            this.poweredbyReddit.AutoSize = true;
            this.poweredbyReddit.Location = new System.Drawing.Point(445, 480);
            this.poweredbyReddit.Name = "poweredbyReddit";
            this.poweredbyReddit.Size = new System.Drawing.Size(35, 13);
            this.poweredbyReddit.TabIndex = 1;
            this.poweredbyReddit.Text = "poweredbyReddit";
            // 
            // subredditURL
            // 
            this.subredditURL.Location = new System.Drawing.Point(13, 3);
            this.subredditURL.Name = "subredditURL";
            this.subredditURL.Size = new System.Drawing.Size(173, 20);
            this.subredditURL.TabIndex = 2;
            // 
            // subredditURLGo
            // 
            this.subredditURLGo.Location = new System.Drawing.Point(192, 3);
            this.subredditURLGo.Name = "subredditURLGo";
            this.subredditURLGo.Size = new System.Drawing.Size(75, 23);
            this.subredditURLGo.TabIndex = 3;
            this.subredditURLGo.Text = "subredditURLGo";
            this.subredditURLGo.UseVisualStyleBackColor = true;
            this.subredditURLGo.Click += new System.EventHandler(this.subredditURLGo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.subredditURLGo);
            this.Controls.Add(this.subredditURL);
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
    }
}

