using System;
using System.Windows.Forms;

namespace SwitchDataGridDatasource
{
    public partial class SwapView : Form
    {
        private readonly SwapViewModel _viewModel;

        public SwapView(SwapViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            InitializeBinding();
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
            simpleButtonSwapDatasource.Click += SimpleButtonSwapDatasource_Click;
        }

        private void SimpleButtonSwapDatasource_Click(object sender, EventArgs e)
        {
            switch (_viewModel.ActiveSource)
            {
                case SwapViewModel.ActiveDatasource.Result:
                    _viewModel.ActiveSource = SwapViewModel.ActiveDatasource.Audit;
                    break;
                case SwapViewModel.ActiveDatasource.Audit:
                    _viewModel.ActiveSource = SwapViewModel.ActiveDatasource.Result;
                    break;
                default:
                    break;
            }
        }

        private void _viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //change datasource
            if (e.PropertyName == nameof(_viewModel.ActiveSource))
            {
                ChangeDataSource(_viewModel.ActiveSource);
            }
        }

        private void ChangeDataSource(SwapViewModel.ActiveDatasource activeSource)
        {
            switch (activeSource)
            {
                case SwapViewModel.ActiveDatasource.Result:
                    gridView1.Columns.Clear();
                    gridControl1.DataSource = _viewModel.Results;
                    break;
                case SwapViewModel.ActiveDatasource.Audit:
                    gridView1.Columns.Clear();
                    gridControl1.DataSource = _viewModel.AuditTrail;
                    break;
                default:
                    break;
            }

            gridControl1.RefreshDataSource();

        }

        private void InitializeBinding()
        {
            //grid
            this.gridControl1.DataSource = _viewModel.Results;
        }
    }


}
