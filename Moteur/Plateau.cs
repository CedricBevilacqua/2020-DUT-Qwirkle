using System;
using System.Collections.Generic;
using System.Linq;

namespace QwirkleGame
{
    public class Plateau
    {
        private static List<Tuile> GrillePiecesContent = new List<Tuile>();
        private static List<Tuile> PiecesToAdd = new List<Tuile>();
        private static int[,] GrilleIndex = new int[10, 10]; //Il faut retirer 1 à l'index, car sinon on n'aurait pas pu distinguer une case vide d'une case contenant la première pièce qui est à l'index 0
        private static int[,] PosToAdd = new int[6, 2];
        private static int NbToAdd = 0;
        private static int NbLn = 10;
        private static int NbCol = 10;

        public static void ResetAllPlateau() //Utile pour les tests
        {
            GrillePiecesContent.Clear();
            PiecesToAdd.Clear();
            GrilleIndex = new int[10, 10];
            PosToAdd = new int[6, 2];
            NbToAdd = 0;
            NbLn = 10;
            NbCol = 10;
        }

        public static void ResetForNextPlayer()
        {
            PiecesToAdd.Clear();
            PosToAdd = new int[6, 2];
            NbToAdd = 0;
        }

        public static void ExtendSize()
        {
            int[,] TempGrilleIndex = new int[NbLn, NbCol];
            for (int BoucleLn = 0; BoucleLn < NbLn; BoucleLn++)
            {
                for (int BoucleCol = 0; BoucleCol < NbCol; BoucleCol++)
                {
                    TempGrilleIndex[BoucleLn, BoucleCol] = GrilleIndex[BoucleLn, BoucleCol];
                }
            }

            NbCol = NbCol + 2;
            NbLn = NbLn + 2;
            GrilleIndex = new int[NbLn, NbCol];

            for (int BoucleLn = 0; BoucleLn < NbLn - 2; BoucleLn++)
            {
                for (int BoucleCol = 0; BoucleCol < NbCol - 2; BoucleCol++)
                {
                    GrilleIndex[BoucleLn + 1, BoucleCol + 1] = TempGrilleIndex[BoucleLn, BoucleCol];
                }
            }

            for (int BoucleToAdd = 0; BoucleToAdd < NbToAdd; BoucleToAdd++)
            {
                PosToAdd[BoucleToAdd, 0]++;
                PosToAdd[BoucleToAdd, 1]++;
            }
        }

        //Adding pieces

        public static void AddPiece()
        {
            for (int Boucle = 0; Boucle < NbToAdd; Boucle++)
            {
                GrillePiecesContent.Add(PiecesToAdd[Boucle]);
                GrilleIndex[PosToAdd[Boucle, 0], PosToAdd[Boucle, 1]] = GrillePiecesContent.Count();
            }
        }

        public static void AddPieceToAdd(Tuile Piece, int PosX, int PosY)
        {
            if (NbToAdd < 6 && PosX >= 0 && PosY >= 0)
            {
                PosToAdd[NbToAdd, 0] = PosX;
                PosToAdd[NbToAdd, 1] = PosY;
                PiecesToAdd.Add(Piece);
                NbToAdd++;
            }
        }

        public static void ResetPiecesToAdd()
        {
            PiecesToAdd.Clear();
            NbToAdd = 0;
            PosToAdd = new int[6, 2];
        }

        //Comptage des points

        public static int CountPoint(int CoordonneeX, int CoordonneeY)
        {
            throw new NotImplementedException();
        }

        public static int ScoreFirstTuileLn(int CoordonneeX, int CoordonneeY)
        {
            int FirstPieceX = CoordonneeX;
            bool PieceExist = true;
            while (PieceExist || GrilleIndex[FirstPieceX, CoordonneeY] > 0)
            {
                PieceExist = false;
                FirstPieceX--;
                for (int BoucleNbToAdd = 0; BoucleNbToAdd < NbToAdd; BoucleNbToAdd++)
                {
                    if (PosToAdd[BoucleNbToAdd, 0] == FirstPieceX && PosToAdd[BoucleNbToAdd, 1] == CoordonneeY)
                    {
                        PieceExist = true;
                    }
                }
            }
            return FirstPieceX + 1;
        }

        public static int ScoreNbTuileLn(int CoordonneeX, int CoordonneeY)
        {
            int NbPion = 0;
            bool PieceExist = false;
            do
            {
                PieceExist = false;
                NbPion++;
                for (int BoucleNbToAdd = 0; BoucleNbToAdd < NbToAdd; BoucleNbToAdd++)
                {
                    if (PosToAdd[BoucleNbToAdd, 0] == ScoreFirstTuileLn(CoordonneeX, CoordonneeY) + NbPion && PosToAdd[BoucleNbToAdd, 1] == CoordonneeY)
                    {
                        PieceExist = true;
                    }
                }

            } while (PieceExist == true || GrilleIndex[ScoreFirstTuileLn(CoordonneeX, CoordonneeY) + NbPion, CoordonneeY] > 0);
            return NbPion;
        }

        public static int ScoreDoubleLn(int CoordonneeX, int CoordonneeY)
        {
            int NbDouble = 0;
            int Avancee = 0;
            bool PieceExist;
            bool NextPieceExist;
            do
            {
                PieceExist = false;
                NextPieceExist = false;
                for (int BoucleNbToAdd = 0; BoucleNbToAdd < NbToAdd; BoucleNbToAdd++)
                {
                    if (PosToAdd[BoucleNbToAdd, 0] == ScoreFirstTuileLn(CoordonneeX, CoordonneeY) + Avancee && PosToAdd[BoucleNbToAdd, 1] == CoordonneeY - 1)
                    {
                        PieceExist = true;
                    }
                    if (PosToAdd[BoucleNbToAdd, 0] == ScoreFirstTuileLn(CoordonneeX, CoordonneeY) + Avancee && PosToAdd[BoucleNbToAdd, 1] == CoordonneeY + 1)
                    {
                        PieceExist = true;
                    }
                    if (PosToAdd[BoucleNbToAdd, 0] == ScoreFirstTuileLn(CoordonneeX, CoordonneeY) + Avancee && PosToAdd[BoucleNbToAdd, 1] == CoordonneeY)
                    {
                        NextPieceExist = true;
                    }
                }
                if (PieceExist == true)
                {
                    NbDouble++;
                }
                Avancee++;
            } while (NextPieceExist == true);
            return NbDouble;
        }

        public static int ScoreFirstTuileCol(int CoordonneeX, int CoordonneeY)
        {
            throw new NotImplementedException();
        }

        public static int ScoreNbTuileCol(int CoordonneeX, int CoordonneeY)
        {
            throw new NotImplementedException();
        }

        public static int ScoreDoubleCol(int CoordonneeX, int CoordonneeY)
        {
            throw new NotImplementedException();
        }

        //Vérification du placement

        public static Boolean VerifPlacement(int PosX, int PosY)
        {
            bool PresentInToAdd = false;
            for (int BoucleToAdd = 0; BoucleToAdd < 6; BoucleToAdd++)
            {
                if (GetToAddCaseInformation()[BoucleToAdd, 0] == PosX && GetToAddCaseInformation()[BoucleToAdd, 1] == PosY && BoucleToAdd < NbToAdd)
                {
                    PresentInToAdd = true;
                }
            }
            if (GrilleIndex[PosX, PosY] > 0 || PresentInToAdd)
            {
                return false;
            }
            return true;
        }

        //Accesseurs

        public static int[,] GetGrilleIndex()
        {
            return GrilleIndex;
        }

        public static int[,] GetToAddCaseInformation()
        {
            return PosToAdd;
        }

        public static Tuile GetAddedPieceInformation(int PosX, int PosY)
        {
            return GrillePiecesContent[GrilleIndex[PosX, PosY] - 1];
        }

        public static Tuile GetToAddPieceInformation(int Index)
        {
            if (PiecesToAdd.Count() - 1 >= Index)
            {
                return PiecesToAdd[Index];
            }
            else
            {
                return null;
            }
        }

        public static Tuile GetPieceToAddInCollection(int Index)
        {
            return PiecesToAdd[Index];
        }

        public static int GetPiecesToAdd()
        {
            return PiecesToAdd.Count();
        }

        public static int GetNbPiecesToAdd()
        {
            return NbToAdd;
        }

        public static int[,] GetPosToAdd()
        {
            return PosToAdd;
        }
    }
}
