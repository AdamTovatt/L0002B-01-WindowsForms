using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Change : Form
    {
        private ChangeCalculator changeCalculator; //kommer användas för att beräkna växel

        public Change()
        {
            InitializeComponent();
            changeCalculator = new ChangeCalculator(CurrencyLoader.Load("SEK")); //skapar en ny växelkalkulator med en valuta som laddas från den hårdkodade strängen "SEK". Om man vill expandera programmet för att stödja flera valutor bör man uppenbarligen inte hårdkoda den på det här viset
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int price = 0; //kommer senare innehålla priset tolkat som ett heltal från användarens input
            int payed = 0; //kommer senare innehålla mängd betalad tolkat som ett heltal från användarens input

            if (!int.TryParse(PriceInput.Text, out price) || !int.TryParse(PayedInput.Text, out payed)) //testar om input kan tolkas som int
            {
                MessageBox.Show("Pris och betald mängd måste anges som siffror"); //ger ett felmeddelande och returnerar så att vi inte fortsätter om någon input inte går att tolka som en int
                return; //vi ska inte fortsätta köra den här funktionen om vi har kommit hit
            }

            if(payed < price)
            {
                MessageBox.Show("Du måste betala minst så mycket det kostar"); //man måste betala minst så mycket det kostar
                return; //vi ska inte fortsätta köra den här funktionen om vi har kommit hit
            }

            Dictionary<Denomination, int> change = changeCalculator.GetChange(payed - price); //räknar ut växeln som användaren sa få

            StringBuilder changeText = new StringBuilder("Din växel:\n"); //kommer att användas för att skapa en text som visas för användaren
            foreach(Denomination denomination in change.Keys)
            {
                changeText.Append(string.Format("{0} {1}\n", change[denomination], change[denomination] > 1 ? denomination.PluralName : denomination.SingularName)); //lägger till text för att visa växeln. Om det är fler än 1 av en valör tar vi pluralversionen av namnet, annars singularversionen
            }

            changeText.Remove(changeText.Length - 1, 1); //ta bort sista tecknet som alltid kommer vara en onödig radbrytning

            MessageBox.Show(changeText.ToString()); //visar texten med växelinformation
        }
    }
}
