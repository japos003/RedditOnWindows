using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RedditOnWindows
{

    class JSONResults
    {
        /*
         * JSONResults : Reads the JSON of subreddit and returns the results
         */

        string website_contents;
        String website;
        dynamic contents;
        public List<SubredditEntry> listOfSubredditEntry;

        public JSONResults()
        {
            var client = new WebClient();
            this.website = "http://www.reddit.com/.json";
            website_contents = client.DownloadString(website);

            analyzeJSON();
        }

        public JSONResults(String subreddit)
        {
            var client = new WebClient();
            this.website = "http://www.reddit.com/r/" + subreddit + "/.json";
            try {
                website_contents = client.DownloadString(website);

                analyzeJSON();
            } catch(WebException we)
            {
                MessageBox.Show("Subreddit failed to show. Showing main page...");
                this.website = "http://www.reddit.com/.json";
                website_contents = client.DownloadString(website);

                analyzeJSON();
            }

        }

        public List<SubredditEntry> getEntries()
        {
            return listOfSubredditEntry;
        }

        private void analyzeJSON()
        {
            

            listOfSubredditEntry = new List<SubredditEntry>();

            contents = JsonConvert.DeserializeObject(website_contents);

            var subreddit_contents = JObject.Parse((String)website_contents);

            foreach (var obj in subreddit_contents["data"]["children"])
            {
                SubredditEntry subreddit_entry = new SubredditEntry();

                //Console.Out.WriteLine(obj);

                subreddit_entry.author = (String)obj["data"]["author"];
                subreddit_entry.permalink = (String)obj["data"]["permalink"];
                subreddit_entry.subreddit = (String)obj["data"]["subreddit"];
                subreddit_entry.title = (String)obj["data"]["title"];
                subreddit_entry.url = (String)obj["data"]["url"];

                listOfSubredditEntry.Add(subreddit_entry);
            }

            Console.Out.WriteLine("Length of List: " + listOfSubredditEntry.Count);

        }
    }
}
