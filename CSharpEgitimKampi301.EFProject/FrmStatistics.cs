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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgLocationPrice.Text = (db.Location.Average(x => x.Price)).ToString();

            int lblLastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lblLastCountryId).Select(y => y.Country).FirstOrDefault();
           
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkıyeCapacityAvg.Text=db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName+" "+ y.GuideSurname).FirstOrDefault();

            var maxCapacity = db.Location.Max((x => x.Capacity));
            lblMaxCapacity.Text=db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault();

            var maxPrice = db.Location.Max((x => x.Price));
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString(); 

            var guideIdByNameAhmetCan = db.Guide.Where(x => x.GuideName == "Ahmet" && x.GuideSurname == "Can").Select(y => y.GuideId).FirstOrDefault();
            lblAhmetCanLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAhmetCan).Count().ToString();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
