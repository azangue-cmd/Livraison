using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Livraison
{
    public class MainViewModel
    {
        //private CommandeModel OldCommand;
        public ObservableCollection<CommandeModel> Commandes;
        public MainViewModel()
        {
            Commandes = new ObservableCollection<CommandeModel>()
            {
                new CommandeModel
                {
                    NameCommande = "Livraison Azangue",
                    Reference = "ref01",
                    Desciption = "Livraison de poulet",
                    LieuLivraison = "Douala",
                    NomClient = "Azangue",
                    TelephoneClient = 674091115,
                    ImageUrl = "cameroon.png",
                    CollImage = "add.png",
                    ExpImage = "moin.png",
                    Command_Details = new ObservableCollection<CommandDetails>
                    {
                        new CommandDetails {Key = "Ulrich", Value = "Telephone"},
                        new CommandDetails {Key = "Derrick", Value = "Iphone"}

                    }

                },


                 new CommandeModel
                 {
                        NameCommande = "Livraison Azangue",
                        Reference = "ref01",
                        Desciption = "Livraison de poulet",
                        LieuLivraison = "Douala",
                        NomClient = "Azangue",
                        TelephoneClient = 674091115,
                        ImageUrl = "cameroon.png",
                        CollImage = "add.png",
                        ExpImage = "moin.png",
                        Command_Details = new ObservableCollection<CommandDetails>
                        {
                            new CommandDetails {Key = "Ulrich", Value = "Telephone"},
                            new CommandDetails {Key = "Derrick", Value = "Iphone"}

                        }

                 },

                  new CommandeModel
                  {
                        NameCommande = "Livraison Azangue",
                        Reference = "ref01",
                        Desciption = "Livraison de poulet",
                        LieuLivraison = "Douala",
                        NomClient = "Azangue",
                        TelephoneClient = 674091115,
                        ImageUrl = "cameroon.png",
                        CollImage = "add.png",
                        ExpImage = "moin.png",
                        Command_Details = new ObservableCollection<CommandDetails>
                        {
                            new CommandDetails {Key = "Ulrich", Value = "Telephone"},
                            new CommandDetails {Key = "Derrick", Value = "Iphone"}

                        }

                  }
            };
        }
    }

    public class CommandeModel
    {
        public string NameCommande { get; set; }
        public string Reference { get; set; }
        public string Desciption { get; set; }
        public string LieuLivraison { get; set; }
        public string NomClient { get; set; }
        public double TelephoneClient { get; set; }
        public string ImageUrl { get; set; }
        public string CollImage { get; set; }
        public string ExpImage { get; set; }
        public ObservableCollection <CommandDetails> Command_Details { get; set; }

    }

    public class CommandDetails
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
