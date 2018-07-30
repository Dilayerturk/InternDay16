﻿using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisCRUD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Edit(bool value)
        {
            txtID.ReadOnly = value;
            txtManufacturer.ReadOnly = value;
            txtModel.ReadOnly = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(RedisClient client=new RedisClient("localhost", 6379))
            {
                IRedisTypedClient<Phone> phone = client.As<Phone>();
                phoneBindingSource.DataSource = phone.GetAll();
                Edit(true);//Read only
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            phoneBindingSource.Add(new Phone());
            phoneBindingSource.MoveLast();
            Edit(false);//Allow edit
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(false);//Allow Edit
            txtID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(true);//Read Only
            phoneBindingSource.ResetBindings(false);
            ClearText();
        }

        void ClearText()
        {
            txtID.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtModel.Text = string.Empty;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this,"Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Phone p = phoneBindingSource.Current as Phone;
                if (p != null)
                {
                    using (RedisClient client = new RedisClient("localhost", 6379))
                    {
                        IRedisTypedClient<Phone> phone = client.As<Phone>();
                        phone.DeleteByIds(p.ID);
                        phoneBindingSource.RemoveCurrent();
                        ClearText();
                    }
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                phoneBindingSource.EndEdit();
                IRedisTypedClient<Phone> phone = client.As<Phone>();
                phone.StoreAll(phoneBindingSource.DataSource as List<Phone>);
                MetroFramework.MetroMessageBox.Show(this, "Your data has been successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                Edit(true);
            }
        }
    }
}
