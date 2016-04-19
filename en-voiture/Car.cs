﻿
using System.Drawing;
namespace en_voiture
{
    /// <summary>
    /// Représentation d'une voiture dans l'application.
    /// </summary>
    public class Car : RoadUser
    {
        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture d'après un rectangle.
        /// </summary>
        /// <param name="rectangle">Rectangle sur lequel baser la géométrie de la voiture</param>
        public Car(Rectangle rectangle) : base(rectangle) { }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public Car(int x, int y, int width, int height) : base(x, y, width, height) { }

    }
}
