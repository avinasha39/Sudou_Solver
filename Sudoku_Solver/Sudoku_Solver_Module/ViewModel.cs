using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver_Module
{
    class ViewModel
    {
        public CellViewModel[][] Cells { get; private set; }

        public ViewModel()
        {
            Cells = new CellViewModel[9][];
            for (var x = 0; x < 9; x++)
            {
                Cells[x] = new CellViewModel[9];
                for (var y = 0; y < 9; y++)
                {
                    Cells[x][y] = new CellViewModel();
                }
            }

        }
    }
}
