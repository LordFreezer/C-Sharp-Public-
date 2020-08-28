using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecentlyVisitedSitesGiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.MouseEnter += OnMouseEnterLinkLabel1;
            linkLabel2.MouseEnter += OnMouseEnterLinkLabel2;
            linkLabel3.MouseEnter += OnMouseEnterLinkLabel3;
            this.MouseEnter += OnMouseEnterForm1;
                
        }

         private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             //System.Diagnostics.Process.Start(e.Link.LinkData as string);
             System.Diagnostics.Process.Start("www.microsoft.com");
             /*System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("http://www.microsoft.com");
             System.Diagnostics.Process.Start(sInfo);*/
         }
         private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             //System.Diagnostics.Process.Start(e.Link.LinkData as string);
             System.Diagnostics.Process.Start("www.google.com");
           /*  System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("http://www.google.com");
             System.Diagnostics.Process.Start(sInfo);*/
         }
         private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             //System.Diagnostics.Process.Start(e.Link.LinkData as string);
             System.Diagnostics.Process.Start("www.youtube.com");
            /* System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("http://www.youtube.com");
            System.Diagnostics.Process.Start(sInfo);*/
         }
       /* private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel1.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + url;

            var si = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(si);
            linkLabel1.LinkVisited = true;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel2.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + url;

            var si = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(si);
            linkLabel2.LinkVisited = true;
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel3.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + url;

            var si = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(si);
            linkLabel3.LinkVisited = true;
        }*/
        private void Form1_Load(object sender, System.EventArgs e)
        {
            
           /* linkLabel1.Text = "Click here to get more info.";
            linkLabel2.Text = "Click here to get more info.";
            linkLabel3.Text = "Click here to get more info.";
            LinkLabel.Link link1 = new LinkLabel.Link();
            link1.LinkData = "http://www.youtube.com";
            linkLabel1.Links.Add(link1);
            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "http://www.google.com";
            linkLabel2.Links.Add(link2);   
            LinkLabel.Link link3 = new LinkLabel.Link();
            link3.LinkData = "http://www.youtube.com";
            linkLabel3.Links.Add(link3);
            linkLabel1.Links.Add(6, 4, "www.microsoft.com");
            linkLabel2.Links.Add(6, 4, "www.google.com");
            linkLabel3.Links.Add(6, 4, "www.youtube.com");*/
        }
        private void OnMouseEnterLinkLabel1(object sender, EventArgs e)
        {
            linkLabel1.Text = "This sends you to Microsoft's site";
            //linkLabel1.Text = "http://www.youtube.com";
        }
        private void OnMouseEnterLinkLabel2(object sender, EventArgs e)
        {
            linkLabel2.Text = "This sends you to google's site";
            //linkLabel2.Text = "http://www.google.com";
        }
        private void OnMouseEnterLinkLabel3(object sender, EventArgs e)
        {
            linkLabel3.Text = "This sends you to Youtube's site";
            //linkLabel3.Text = "http://www.microsoft.com";
        }

        private void OnMouseEnterForm1(object sender, EventArgs e)
        {
            linkLabel1.Text = "Click here to get more info.";
            linkLabel2.Text = "Click here to get more info.";
            linkLabel3.Text = "Click here to get more info.";
        }
    }
}

