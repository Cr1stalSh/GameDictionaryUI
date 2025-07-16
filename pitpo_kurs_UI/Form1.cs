using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace pitpo_kurs_UI
{
    public partial class Form1 : Form
    {
        private string _section = "Персонажи";
        private const string ConnStr = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=postgres";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstResults.DisplayMember = "Title";
            lstResults.SelectedIndexChanged += (s, ev) => ShowDetails();

            btnSectionsCharacters.Click += (s, ev) => SwitchSection("Персонажи");
            btnSectionsArtifacts.Click += (s, ev) => SwitchSection("Артефакты");
            btnSectionsEnemies.Click += (s, ev) => SwitchSection("Враги");

            btnSearch.Click += (s, ev) => RefreshList();

            SwitchSection(_section);
        }
        private void SwitchSection(string section)
        {
            _section = section;
            txtSearch.Clear();
            txtMinViews.Text = "0";
            lstResults.Items.Clear();
            txtDescription.Clear();
            RefreshList();
        }

        private void RefreshList()
        {
            lstResults.Items.Clear();
            if (!int.TryParse(txtMinViews.Text, out int minViews))
                minViews = 0;

            string keyword = txtSearch.Text;
            List<Article> filteredArticles = GetFilteredArticles(minViews, keyword);
            filteredArticles.ForEach(a => lstResults.Items.Add(a));
        }


        public List<Article> GetFilteredArticles(int minViews, string keyword)
        {
            List<Article> articles = GetArticles();
            if (articles == null)
            {
                return new List<Article>();//ioio
            }

            string lowerKeyword = string.IsNullOrWhiteSpace(keyword) ? "" : keyword.Trim().ToLower();

            List<Article> filteredArticles = new List<Article>();

            foreach (var article in articles)
            {
                if (article.Views < minViews)
                    continue;

                if (string.IsNullOrEmpty(lowerKeyword))
                {
                    if (article.Tags != null &&
                        article.Tags.Any(tag => tag.Equals(_section, StringComparison.OrdinalIgnoreCase)))
                    {
                        filteredArticles.Add(article);
                    }
                }
                else
                {
                    bool matchesTitle = article.Title.ToLower().Contains(lowerKeyword);
                    bool matchesTags = article.Tags != null &&
                                       article.Tags.Any(tag => tag.ToLower().Contains(lowerKeyword));

                    if (matchesTitle || matchesTags)
                        filteredArticles.Add(article);
                }
            }

            return filteredArticles;
        }



        private void ShowDetails()
        {
            if (lstResults.SelectedItem is Article art)
            {
                txtDescription.Text =
                    $"Название: {art.Title}\r\n" +
                    $"Описание: {art.Description}\r\n" +
                    $"Просмотров: {art.Views}\r\n" +
                    $"Теги: {string.Join(", ", art.Tags)}";
            }
        }

        private List<Article> GetArticles()
        {
            var list = new List<Article>();
            using var conn = new NpgsqlConnection(ConnStr);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT id, title, description, views, tags FROM articles", conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Article
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Description = rd.GetString(2),
                    Views = rd.GetInt32(3),
                    Tags = !rd.IsDBNull(4)
                        ? rd.GetString(4)
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToList()
                        : new List<string>()
                });
            }
            return list;
        }

    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public List<string> Tags { get; set; }
        public override string ToString() => Title;
    }
}
    

