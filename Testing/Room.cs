using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Testing.RequestAndResponseHandler;

namespace Testing
{
    public partial class Room : Form
    {
        private readonly RoomType _roomType;
        private string _apiUrl = "https://localhost:7150/api/RoomType";
        private Guid? _selectedRoomTypeId = null; // Store the selected RoomType ID


        public Room()
        {
            InitializeComponent();
            _roomType = new RoomType();
            LoadRoomTypes();

        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnAddRoom_Click(object sender, EventArgs e)
        {
            var roomTypeDto = new RoomTypeDto
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Description = txtDescription.Text,
            };

            bool isSuccess = await _roomType.AddRoomTypeAsync(_apiUrl, roomTypeDto);

            if (isSuccess)
            {
                MessageBox.Show("RoomType added successfully!");
                LoadRoomTypes(); // Refresh the grid after adding
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add RoomType.");
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRoomTypeId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedRoomTypeId.Value}";
                bool isSuccess = await _roomType.DeleteRoomTypeByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType deleted successfully!");
                    LoadRoomTypes(); // Refresh the grid after deleting
                    Clear();

                }
                else
                {
                    MessageBox.Show("Failed to delete RoomType.");
                }
            }
            else
            {
                MessageBox.Show("Please select a RoomType to delete.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {

            if (_selectedRoomTypeId.HasValue)
            {
                var updatedRoomType = new RoomTypeDto
                {
                    Id = _selectedRoomTypeId.Value,
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };

                string fullUrl = $"{_apiUrl}/{_selectedRoomTypeId.Value}";
                bool isSuccess = await _roomType.UpdateRoomTypeAsync(fullUrl, updatedRoomType);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType updated successfully!");
                    LoadRoomTypes(); // Refresh the grid after updating
                    Clear();

                }
                else
                {
                    MessageBox.Show("Failed to update RoomType.");
                }
            }
            else
            {
                MessageBox.Show("Please select a RoomType to update.");
            }

        }

        private void gdvRoomType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private async void LoadRoomTypes()
        {
            try
            {
                var roomTypes = await _roomType.GetAllRoomTypesAsync(_apiUrl);

                if (roomTypes != null)
                {
                    gdvRoomType.DataSource = roomTypes;
                }
                else
                {
                    MessageBox.Show("Failed to load RoomTypes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    

        private void gdvRoomType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gdvRoomType.SelectedRows.Count > 0)
            {
                var selectedRow = gdvRoomType.SelectedRows[0];
                // Assuming ID is in the first column
                _selectedRoomTypeId = (Guid)selectedRow.Cells["Id"].Value; // Replace "Id" with the actual column name
                txtName.Text = selectedRow.Cells["Name"].Value.ToString(); // Replace "Name" with the actual column name
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString(); // Replace "Description" with the actual column name
            }

        }


        public async void Clear()
        {
            txtName.Clear();
            txtDescription.Clear();
        }
    }
}

