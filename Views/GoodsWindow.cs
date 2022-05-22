using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowWorldDbSQLite.Services;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Controllers;
using WindowWorldDbSQLite.Views;

namespace WindowWorldDbSQLite.Views
{
    public partial class GoodsWindow : Form
    {
        GoodController controller = null;
        List<Good> psItems = null;
        User mUser = null;
        public GoodsWindow(User _user = null)
        {
            mUser = _user;
            controller = new GoodController();
            InitializeComponent();
            //this.Text = $"{this.Text} ({mUser.UserName})";
        }

        public void UpdateForm(string search = "", string field = "")
        {
            try
            {
                psItems = controller.GetAllGoodByFilter(search, field);
                if (psItems != null)
                {
                    dataGridView.Rows.Clear();
                    for (int i = 0; i < psItems.Count; i++)
                    {
                        dataGridView.Rows.Add(psItems[i]);
                        dataGridView[0, i].Value = psItems[i].Id;
                        dataGridView[1, i].Value = psItems[i].Name;
                        dataGridView[2, i].Value = psItems[i].Company;
                        dataGridView[3, i].Value = psItems[i].TypeGood;
                        dataGridView[4, i].Value = psItems[i].Price;
                        dataGridView[5, i].Value = psItems[i].PhotoUrl;
                        dataGridView[6, i].Value = psItems[i].IsActive;
                        dataGridView[7, i].Value = psItems[i].Progress;
                        dataGridView[8, i].Value = "Сохранить";
                        dataGridView[9, i].Value = "Удалить";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // gc = new GoodController();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GoodsWindow_Load(object sender, EventArgs e)
        {
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].Visible = false;
            UpdateForm();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                Good obj = new Good
                {
                    Id = Convert.ToInt32(dataGridView[0, e.RowIndex].Value),
                    Name = dataGridView[1, e.RowIndex].Value.ToString(),
                    Company = dataGridView[2, e.RowIndex].Value.ToString(),
                    TypeGood = dataGridView[3, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(dataGridView[4, e.RowIndex].Value),
                    PhotoUrl = dataGridView[5, e.RowIndex].Value.ToString(),
                    IsActive = Convert.ToBoolean(dataGridView[6, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView[7, e.RowIndex].Value)
                };

                if (controller.UpdateSingleGood(obj))
                {
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("При обновлении ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Good obj = new Good
                {
                    Id = Convert.ToInt32(dataGridView[0, e.RowIndex].Value),
                    Name = dataGridView[1, e.RowIndex].Value.ToString(),
                    Company = dataGridView[2, e.RowIndex].Value.ToString(),
                    TypeGood = dataGridView[3, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(dataGridView[4, e.RowIndex].Value),
                    PhotoUrl = dataGridView[5, e.RowIndex].Value.ToString(),
                    IsActive = Convert.ToBoolean(dataGridView[6, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView[7, e.RowIndex].Value)
                };

                if (e.ColumnIndex == 9)
                {
                    if (controller.DeleteSingleGood(obj))
                    {
                        UpdateForm();
                    }
                    else
                    {
                        MessageBox.Show("При удалении ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    imageBox.Load(obj.PhotoUrl);
                }
            }


        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            GoodController controller = new GoodController();
            switch (comboSearchBox.TabIndex)
            {
                case 1:
                    UpdateForm(searchBox.Text, "common");
                    break;
                case 2:
                    UpdateForm(searchBox.Text, "company");
                    break;
                case 3:
                    UpdateForm(searchBox.Text, "type");
                    break;
                case 4:
                    UpdateForm(searchBox.Text, "price");
                    break;
                case 5:
                    UpdateForm(searchBox.Text, "name");
                    break;
                default:
                    UpdateForm(searchBox.Text, "common");
                    break;
            }
        }

        private void imageAddBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                imageAddBox.Load(imgUrlBox.Text);
                imgUrlBox.ReadOnly = true;
            }
            catch
            {

            }

        }

        private void imgUrlBox_Click(object sender, EventArgs e)
        {
            imgUrlBox.Clear();
            imgUrlBox.ReadOnly = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            GoodController controller = new GoodController();
            Good obj = new Good
            {
                Name = nameAddBox.Text,
                Company = companyAddBox.Text,
                TypeGood = typeAddBox.Text,
                Price = Convert.ToInt32(priceAddBox.Text),
                PhotoUrl = imgUrlBox.Text,
            };

            if (nameAddBox.Text != String.Empty)
            {
                if (companyAddBox.Text != String.Empty)
                {
                    if (typeAddBox.Text != String.Empty)
                    {
                        if (priceAddBox.Text != String.Empty)
                        {
                            if (imgUrlBox.Text != String.Empty)
                            {
                                if (controller.AddSingleNewGood(obj))
                                {
                                    nameAddBox.Text = String.Empty;
                                    companyAddBox.Text = String.Empty;
                                    typeAddBox.Text = String.Empty;
                                    priceAddBox.Text = String.Empty;
                                    imgUrlBox.Text = String.Empty;
                                    imageAddBox.Load("https://kartinkin.net/uploads/posts/2021-01/1610490098_15-p-belii-teksturnii-fon-22.jpg");
                                    tabControl1.SelectTab(0);
                                    UpdateForm();
                                    //MessageBox.Show("Покупатель успешно добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    //MessageBox.Show("При добавлении произошла ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
