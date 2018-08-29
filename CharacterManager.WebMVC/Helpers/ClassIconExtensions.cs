using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class ClassIconExtensions
{
    public static string ClassIconUrl(this String characterClass)
    {
        string icon = "";

        switch (characterClass)
        {
            case "Barbarian":
                icon = "Barbarian.jpg";
                break;
            case "Bard":
                icon = "Bard.jpg";
                break;
            case "Cleric":
                icon = "Cleric.jpg";
                break;
            case "Druid":
                icon = "Druid.jpg";
                break;
            case "Fighter":
                icon = "Fighter.jpg";
                break;
            case "Monk":
                icon = "Monk.jpg";
                break;
            case "Paladin":
                icon = "Paladin.jpg";
                break;
            case "Ranger":
                icon = "Ranger.jpg";
                break;
            case "Rogue":
                icon = "Rogue.jpg";
                break;
            case "Sorcerer":
                icon = "Sorcerer.jpg";
                break;
            case "Warlock":
                icon = "Warlock.jpg";
                break;
            case "Wizard":
                icon = "Wizard.jpg";
                break;
        }

        return icon;
    }
}