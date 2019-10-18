using ChangeTracking.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ChangeTracking
{
    public partial class UI : Form
    {
        private UIViewModel _ui;
        public UI(UIViewModel uiViewModel)
        {
            InitializeComponent();
            this._ui = uiViewModel;

            InitializeDataBindings();
        }
        void InitializeDataBindings()
        {
            //Data grid view
            dataGridViewPeople.DataSource = _ui._people;
        }

    }
}
