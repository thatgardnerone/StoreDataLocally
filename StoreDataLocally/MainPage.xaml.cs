using StoreDataLocally.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace StoreDataLocally;

public partial class MainPage : ContentPage
{
    private readonly PersonRepository _personRepository;

    public MainPage()
    {
        _personRepository = App.PersonRepository;
        InitializeComponent();
    }

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        _personRepository.AddNewPerson(newPerson.Text);
        statusMessage.Text = _personRepository.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Person> people = _personRepository.GetAllPeople();
        peopleList.ItemsSource = people;
    }
}

