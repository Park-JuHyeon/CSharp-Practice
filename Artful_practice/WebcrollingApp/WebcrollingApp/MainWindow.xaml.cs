using System.Windows;
using System.Windows.Controls;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Text;

using agi = HtmlAgilityPack;
using System;

namespace WebcrollingApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        public class Post
        {
            public string PostId { get; set; }
            public string Title { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
            public string Review { get; set; }

        }

        private void GrdResult_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void GrdResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.GetEncoding("KSC5601");
            // https://cafe.naver.com/soojebi?iframe_url=/ArticleList.nhn%3Fsearch.clubid=29835300%26search.boardtype=L
            string html = wc.DownloadString("https://cafe.naver.com/soojebi?iframe_url=/ArticleList.nhn%3Fsearch.clubid=29835300%26search.boardtype=L");
            
            agi.HtmlDocument htmlDoc = new agi.HtmlDocument();
            htmlDoc.LoadHtml(html);

            //var web = new HtmlWeb();
            //var htmlDoc = web.Load(cafeurl);


            // 게시판 글 목록 추출
            //var postNodes = doc.DocumentNode.SelectNodes($"//tr[@class='line a' or @class='line a-on']");

            //// Datagrid에 바인딩할 데이터 구성
            //var postList = new List<Post>();
            //foreach ( var post in postNodes )
            //{
            //    string postId = post.SelectSingleNode(".//a[@class='article']").InnerText;
            //    string title = post.SelectSingleNode(".//a[@class='article']").InnerText;
            //    string name = post.SelectSingleNode(".//td[@class='p-nick']//a").InnerText;
            //    string date = post.SelectSingleNode(".//td[@class='td_date']").InnerText;
            //    string review = post.SelectSingleNode(".//td[@class='td_article']").InnerText;
            //    postList.Add(new Post { Title = title, PostId = postId, Date = date, Name = name, Review = review});
            //}

            //GrdResult.ItemsSource = postList;
            Thread.Sleep(2000); // 2초 딜레이

            HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes("//iframe");

            foreach (var node in nodes)
            {
                try
                {
                    HtmlAttribute attr = node.Attributes["src"];
                    if (attr != null) {
                        Debug.WriteLine(attr.Value);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.Message);
                }                
            }
        }
    }
}
