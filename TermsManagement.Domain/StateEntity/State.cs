﻿using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.Common;

namespace TermsManagement.Domain.StateEntity;

public class State : BaseEntity<int>
{
    public string? Title { get; private set; }
    public string? CloseStates { get; private set; }

    public List<City> Cities { get; private set; }

    public State(string title)
    {
        Title = title;
        CloseStates = "";
        Cities = new();
    }

    public void Edit(string title)
    {
        Title = title;
    }

    public void ChangeCloseStates(List<int> States)
    {
        CloseStates = string.Join("-", States);
    }
}