using GMS.Service.Dtos.Halls;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Testing.RequestAndResponseHandler;
namespace Testing
{
    public partial class Form1 : Form
    {
        private readonly HttpHall _httpHall;

        public Form1()
        {
            InitializeComponent();
            _httpHall = new HttpHall("https://localhost:7150/"); // Base URL for the API

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadRoomTypesAsync();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboRoomType.SelectedValue == null)
            {
                MessageBox.Show("Please select a RoomType.");
                return;
            }

            var hallDto = new HallDto
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Capacity = txtCapacity.Text,
                Location = txtLocation.Text,
                AvailabilityStatus = chkAvalibilty.Checked,
                RoomTypeId = (Guid)cboRoomType.SelectedValue
            };

            var success = await _httpHall.AddHallAsync("api/Hall", hallDto); // Relative path for the Hall endpoint

            if (success)
            {
                MessageBox.Show("Hall added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add hall.");
            }

        }

        private void gdvHall_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnUpdateHall_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadRoomTypesAsync()
        {
            try
            {
                var roomTypes = await _httpHall.GetRoomTypesAsync("api/RoomType"); // Relative path for the RoomType endpoint
                cboRoomType.DataSource = roomTypes;
                cboRoomType.DisplayMember = "Name";
                cboRoomType.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room types: " + ex.Message);
            }
        }
    }
}