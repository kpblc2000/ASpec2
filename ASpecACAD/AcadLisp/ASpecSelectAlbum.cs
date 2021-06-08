using ASpecCore.Models.Data;
using ASpecCore.ViewModels;
using ASpecCore.Views;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD.AcadLisp
{
 public   class ASpecSelectAlbum
    {
        [LispFunction("ASPecSelectAlbum")]
        public void AcadLispSelectAlbum(ResultBuffer arg)
        {
            SelectAlbumView winSelAlb = new SelectAlbumView();
            winSelAlb.ShowDialog();
            if (winSelAlb.DialogResult == true)
            {
                AlbumViewModel vm = winSelAlb.DataContext as AlbumViewModel;
                album selAlb = vm.SelectedAlbum;

                Document doc = Application.DocumentManager.MdiActiveDocument;
                if (doc == null)
                {
                    return;
                }
                Editor ed = doc.Editor;
                ed.WriteMessage($"{selAlb.id_album} | {selAlb.name_alb} | {selAlb.description_alb}");
            }
        }
    }
}
