using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values= db.Guide.Select(x => new 
            { 
               FullName= x.GuideName+ " "+ x.GuideSurname,
                x.GuideId
            }).ToList();

            //var values = db.Guide.ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapasity.Text);
            location.City = txtCity.Text;            // <<< DÜZELTİLDİ
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text); // <<< DÜZELTİLDİ
            location.DayNight = txtDayNight.Text;     // <<< DÜZELTİLDİ
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());

            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");









        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deleteValue = db.Location.Find(id);
            db.Location.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.DayNight = txtDayNight.Text;
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.City = txtCity.Text;
            updateValue.Country = txtCountry.Text;
            updateValue.Capacity = byte.Parse(nudCapasity.Text);
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi");


        }
    }
}
