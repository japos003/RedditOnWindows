using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditOnWindows
{
    public partial class MainWindow : Form
    {
        List<SubredditEntry> list;

        public MainWindow()
        {
            InitializeComponent();

            poweredbyReddit.Text = "Powered by reddit";
            subredditURL.Text = "Subreddit";
            subredditURLGo.Text = "Go";

            subredditListView.View = View.Details;
            subredditListView.Columns.Add("Author");
            subredditListView.Columns.Add("Title", 800);
            subredditListView.Columns.Add("URL");


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            JSONResults jsonresults = new JSONResults();
            list = jsonresults.getEntries();

            reloadReddit();
        }

        private void subredditURLGo_Click(object sender, EventArgs e)
        {
            String subreddit = subredditURL.Text;
            JSONResults jsonresults = new JSONResults(subreddit);

            list = jsonresults.getEntries();

            populateListView();

        }

        private void subredditListView_DoubleClick(Object sender, EventArgs e)
        {
            
            ListView lv = (ListView)sender;

            System.Diagnostics.Process.Start(lv.SelectedItems[0].SubItems[2].Text);

        }

        private void reloadReddit()
        {
            foreach (var obj in list)
            {
                subredditListView.Items.Add(new ListViewItem(new string[]
                {
                    obj.author,
                    obj.title,
                    obj.url
                }));
            }
        }

        private void populateListView()
        {
            subredditListView.Clear();

            subredditListView.View = View.Details;
            subredditListView.Columns.Add("Author");
            subredditListView.Columns.Add("Title", -2);
            subredditListView.Columns.Add("URL");

            reloadReddit();
        }
    }
}
