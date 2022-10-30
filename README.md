# Snake_Csharp
Petit Snake tranquile, fait en C# sur la plateform (windows forms).
Pour jouer vous pourrez vous déplacer avec les touches directionnelles, de votre clavier.Vous pouvez aussi aller plus vite avec la touche "espace". Après votre première Game vous pourrez choisir un autre mode de difficulté.

Attention votre serpent ira 2 fois plus vite tous les paliers de 45 de score, le problème qui pourrait survenire, si votre Pc n'est pas rapide, est que contrairement à un autre snake qui se déplacerait par tick, qui permet au corps du serpent de suivre sans se décrocher de la tete, étant donné que c'est une liste de Picture Box, qui vont récupérer la position de son parent et se coller à lui. Pour ma part j'ai préfèrer la fluidité du serpent,donc si vous allez trop vite et votre Pc ne suit pas, vous pourrer constaté par vous-même, le corps du serpent ce détachant de la tete. C'est un choix pour avoir un jeu plus fluide, surtout sur Windows formes qui n'est pas prévu à cet effet a mon grand regret.

Chaque méthod permet au bon déroulement du programme, l'un permet d'initialiser les variables, ou les méthodes nécessaires au lancement, comme la génération d'un fruit, et du serpent. Pour éviter une perte de performence le fruit ne ce génèrera que au lancement.
Un document texte, nommé "counter.txt" dans le fichier "test", vous permettra de connaitre votre meilleur score toutes gammes confondues.

Un petit snake simple, j'ai vraiment essayé de rendre propre le code, même si on peut facilement faire mieux en matière de propreté, et d'optimisation, le temp de prendre mes marques sur cette platforme voila le résultat.
Dernier point à voir c'est le fait de mourir, mettre fin au jeu, soit le serpent mord sa queu, soit sa tete doit sortir, du cadre de jeu.
(les méthodes vides sont justes, une fausse manipulation sur Windows formes que je n'ai pas encore retiré, n'impactant pas sur la jouabilité, ou aussi pouvant être complété par la suite, il n'était pas nécessaire de les retirer.)

![image](https://user-images.githubusercontent.com/39668417/198896371-350df3ad-3e73-4b01-b674-9dc89c75592c.png)
