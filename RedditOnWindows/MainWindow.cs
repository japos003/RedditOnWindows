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
        String currentSubReddit;

        public MainWindow()
        {
            InitializeComponent();

            subredditListView.View = View.Details;
            subredditListView.Columns.Add("Author");
            subredditListView.Columns.Add("Title", 800);
            subredditListView.Columns.Add("URL");
            subredditListView.Columns.Add("Permalink");


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Loads the ListView with Main Page entries
            JSONResults jsonresults = new JSONResults();
            list = jsonresults.getEntries();

            reloadReddit();
        }

        private void subredditURLGo_Click(object sender, EventArgs e)
        {
            String currentSubReddit = subredditURL.Text;
            JSONResults jsonresults = new JSONResults(currentSubReddit);

            list = jsonresults.getEntries();

            populateListView();

        }

        private void subredditListView_DoubleClick(Object sender, EventArgs e)
        {
            //Straight To Link Button

            ListView lv = (ListView)sender;

            System.Diagnostics.Process.Start(lv.SelectedItems[0].SubItems[2].Text);

        }
/*
        private void subredditPrevPage_Click(Object sender, EventArgs e)
        {
            //Previous Page Button Event Call
        }

        private void subredditNextPage_Click(Object sender, EventArgs e)
        {
            //Next Page Button Event Call
        }

*/
        private void subredditListView_RightClick(Object sender, EventArgs e)
        {
            //Takes the user to the subreddit entry's page
            MouseEventArgs mea = (MouseEventArgs)e;
            ListView lv = (ListView)sender;

            if (mea.Button != MouseButtons.Right)
                return;

            System.Diagnostics.Process.Start("http://www.reddit.com" + lv.SelectedItems[0].SubItems[3].Text);
        }

        private void subredditListView_KeyPress(Object sender, EventArgs e)
        {
            //Takes the user to the link when the enter button is pressed
            ListView lv = (ListView)sender;

            System.Diagnostics.Process.Start(lv.SelectedItems[0].SubItems[2].Text);
        }

        private void reloadReddit()
        {
            //Populates the list with the subreddit entries
            foreach (var obj in list)
            {
                subredditListView.Items.Add(new ListViewItem(new string[]
                {
                    obj.author,
                    obj.title,
                    obj.url,
                    obj.permalink
                }));
            }
        }

        private void populateListView()
        {
            //Populates and Refreshes the list
            subredditListView.Clear();

            subredditListView.View = View.Details;
            subredditListView.Columns.Add("Author");
            subredditListView.Columns.Add("Title", -2);
            subredditListView.Columns.Add("URL");
            subredditListView.Columns.Add("Permalink");

            reloadReddit();
        }
    }
}
