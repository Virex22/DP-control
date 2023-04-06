using ExamDP.Pattern.Bridge;
using ExamDP.Pattern.FlyWeight;
using ExamDP.Pattern.Memento;

namespace ExamDP
{
    public static class App{

        public static int Main(string[] args)
        {
            separate("bridge");
            testBridge();

            separate("flyweight");
            testFlyWeight();

            separate("memento");
            testMemento();
            return 0;
        }

        /*
         * Nous avons séparer la couleurs de la forme, pour pouvoir crée une forme il faudra lui
         * donner une couleur, ce qui permet de pouvoir évoluer rapidement notre application sans
         * devoir crée une classe pour chaque variant
         * si nous aurions fait une classe par forme nous aurions eu besoin de 9 classes
         */
        private static void testBridge()
        {
            Console.WriteLine("Creation d'un Cercle Bleu");
            AbstractShape form = new Circle(5, new Blue());
            form.Draw();
            Console.WriteLine("Creation d'un carre Rouge");
            form = new Square(4, new Red());
            form.Draw();
            Console.WriteLine("Creation d'un triangle Jaune");
            form = new Triangle(3, new Yellow());
            form.Draw();
        }

        /*
         *   Nous séparons les éléments intrinsèque des élements extrinsèque. dans ce cas, les coordonnées des
         *   particules sont intrinsèque car pratiquement unique pour chaque instance à contrario, nous
         *   pouvons avoir des images de particules similaire, donc ça ne sert à rien de stocker la même chose
         *   dans chaque particule
         */
        private static void testFlyWeight()
        {
            Console.WriteLine("pour verifier que ça marche on ve crée deux particule avec des coordonnees differente mais avec la meme image");
            ImageFactory factory = new ImageFactory();
            Particle particle = new Particle(factory);
            particle.SetCoords(50, 120);
            particle.setImage("fumee");
            Particle particle2 = new Particle(factory);
            particle2.SetCoords(15, 543);
            particle2.setImage("fumee");
            Console.WriteLine("on va verifier si les images sont de la même instance");
            Console.WriteLine("image 1 : " + particle.getImage().GetHashCode());
            Console.WriteLine("image 2 : " + particle2.getImage().GetHashCode());
        }

        /*
         *  Ici nous avons un dessin qui evolue en fonction de l'utilisateurs, dès qu'il pose un pixel
         *  à un endroit de la zone de dessin, le Canva va sauvegarder son état dans un memento afin
         *  de pouvoir le réutiliser pour revenir en arrière. à l'interieurs nous avons ajouter une 
         *  stack de memento afin de pouvoir gérer les retours en arrière multiple. 
         */
        private static void testMemento()
        {
            Console.WriteLine("Create 2 Pixel");
            Canvas canvas = new Canvas();
            Pixel pixel1 = new Pixel();
            pixel1.SetX(5);
            pixel1.SetY(10);
            canvas.PlacePixel(pixel1);
            Pixel pixel2 = new Pixel();
            pixel2.SetX(10);
            pixel2.SetY(5);
            canvas.PlacePixel(pixel2);
            Console.WriteLine("Draw the Pixel");
            canvas.Draw();
            Console.WriteLine("Add pixel and save the memento");
            Pixel pixel3 = new Pixel();
            pixel3.SetX(20);
            pixel3.SetY(20);
            Memento memento = canvas.PlacePixel(pixel3);
            Console.WriteLine("Draw the Pixel");
            canvas.Draw();
            Console.WriteLine("Undo");
            canvas.Undo();
            Console.WriteLine("Draw the Pixel");
            canvas.Draw();
            Console.WriteLine("Add pixel");
            canvas.PlacePixel(pixel3);
            Console.WriteLine("Draw the Pixel");
            canvas.Draw();
            Console.WriteLine("Load memento");
            canvas.Reset(memento);
            Console.WriteLine("Draw the Pixel");
            canvas.Draw();
        }
        private static void separate(string title)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            string separator = "========================================";
            int fillSize = separator.Length - title.Length;
            Console.WriteLine("\r\n\r\n\r\n" + separator);
            Console.Write(title.ToUpper());
            for (int i = 0; i < fillSize; i++) Console.Write(" ");
            Console.WriteLine();
            Console.WriteLine(separator);
            Console.ResetColor();
        }
    }
}