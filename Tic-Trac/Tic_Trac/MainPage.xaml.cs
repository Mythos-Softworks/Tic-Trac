using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tic_Trac
{
    public partial class MainPage : ContentPage
    {
#warning Change to cell type when finished
        private List<string> _CharacterList = new List<string>();

        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();

            _CharacterList.Add("a");
            _CharacterList.Add("b");
            _CharacterList.Add("c");
            _CharacterList.Add("d");
            _CharacterList.Add("a");
            _CharacterList.Add("b");
            _CharacterList.Add("c");
            _CharacterList.Add("d");
            _CharacterList.Add("a");
            _CharacterList.Add("b");
            _CharacterList.Add("c");
            _CharacterList.Add("d");
        }

        private void btnOffset_Clicked(object sender, EventArgs args)
        {
            int offset;
            Button btn = sender as Button;

            if(int.TryParse(btn.Text, out offset))
            {
                ApplyOffset(offset);
            }
        }

        private void btnHold_Clicked(object sender, EventArgs args)
        {
#warning    Find next person in list, get their offset, offset to them
            int offset = -1;

            ApplyOffset(offset);
        }

        private void btnAddChar_Clicked(object sender, EventArgs args)
        {
#warning    Add character to list
        }

        private void btnClear_Clicked(object sender, EventArgs args)
        {
#warning    Clear list of characters
        }

        private void ApplyOffset(int offset)
        {

        }
    }
}