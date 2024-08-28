using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Testing.RequestAndResponseHandler
{
    public class HttpHall
    {
        private readonly HttpClient _client;

        // Constructor
        public HttpHall(string baseAddress)
        {
            _client = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<bool> AddHallAsync(string url, HallDto hallDto)
        {
            var jsonContent = JsonConvert.SerializeObject(hallDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                // Send a POST request to the API
                HttpResponseMessage response = await _client.PostAsync(url, content);

                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response Content: " + responseContent);

                // Check if the response indicates success
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Hall added successfully!");
                    return true;
                }
                else
                {
                    // Display error message with status code and response content
                    MessageBox.Show($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (HttpRequestException httpRequestEx)
            {
                // Handle HTTP request specific exceptions
                MessageBox.Show($"HTTP Request Error: {httpRequestEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"Exception: {ex.Message}");
                return false;
            }
        }




        public async Task<List<RoomTypeDto>> GetRoomTypesAsync(string url)
        {
            try
            {
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var roomTypeResponse = JsonConvert.DeserializeObject<RoomTypeResponse>(json);

                    if (roomTypeResponse != null && roomTypeResponse.Success)
                    {
                        return roomTypeResponse.Data;
                    }
                    else
                    {
                        throw new Exception("Error fetching room types.");
                    }
                }
                else
                {
                    throw new HttpRequestException($"Error fetching room types: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error occurred while fetching room types.", ex);
            }
        }


    }

}