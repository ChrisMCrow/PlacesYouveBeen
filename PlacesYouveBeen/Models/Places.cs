using System;
using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
    public class Place
    {
        private string _city;
        private string _duration;
        private string _country;
        private string _activities;
        private int _id;
        private static List<Place> _places = new List<Place> {};

        public Place(string city)
        {
            _city = city;
            _places.Add(this);
            _id = _places.Count;
        }
        public string GetCity()
        {
            return _city;
        }
        public void SetDuration(string input)
        {
            _duration = input;
        }
        public string GetDuration()
        {
            return _duration;
        }
        public void SetCountry(string input)
        {
            _country = input;
        }
        public string GetCountry()
        {
            return _country;
        }
        public void SetActivities(string input)
        {
            _activities = input;
        }
        public string GetActivities()
        {
            return _activities;
        }
        public int GetId()
        {
            return _id;
        }
        public static Place Find(int searchId)
        {
            return _places[searchId - 1];
        }
        public static List<Place> GetAll()
        {
            return _places;
        }
        public static void ClearAll()
        {
            _places.Clear();
        }

    }
}
