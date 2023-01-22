﻿using MyClinicServiceNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktopForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadInfoButton_Click(object sender, EventArgs e)
        {
            MyClinicServiceClient myClinicServiceClient = new MyClinicServiceClient("http://localhost:5198/", new System.Net.Http.HttpClient());

            ICollection<Client> clients = myClinicServiceClient.GetAllAsync().Result;


            //ClinicServiceClient clinicServiceClient =  new ClinicServiceClient("http://localhost:5198/", new System.Net.Http.HttpClient());
            //ICollection<Client> clients = clinicServiceClient.GetAllAsync().Result;

            ClientsListView.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });

                ClientsListView.Items.Add(item);
            }
        }
    }
}
