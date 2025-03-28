using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using WinFormsBlazorTutorial.Services;

namespace WinFormsBlazorTutorial
{
    public partial class Form1 : Form
    {
        public Form1(IPersonService personService, IServiceProvider services)
        {
            InitializeComponent();

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services;

            foreach (var person in personService.GetPeople())
            {
                listBox1.Items.Add(new PersonListItem(person.PersonId, $"{person.FirstName} {person.LastName}"));
            }

            var parameters = new Dictionary<string, object>
            {
                { "PersonId", 1 }
            };

            blazorWebView1.RootComponents.Add<PersonDetail>("#app", parameters);
        }
        private void PeopleListSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = listBox1.SelectedItem as PersonListItem;

            if(selectedPerson == null)
            {
                return;
            }

            blazorWebView1.RootComponents.Remove("#app");

            var parameters = new Dictionary<string, object>
            {
                { "PersonId", selectedPerson.PersonId }
            };

            blazorWebView1.RootComponents.Add<PersonDetail>("#app", parameters);
        }

        public record PersonListItem(int PersonId, string Name)
        {
            public override string ToString()
            {
                return Name;
            }
        }
    }
}
