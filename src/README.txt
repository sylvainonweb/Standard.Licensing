1) La solution ne compilait pas
=> j'ai modifi� la balise <TargetFrameworks> comme suit :
    Avant : <TargetFrameworks>netstandard2.0;netstandard1.3;netstandard1.0;net45;net40;portable-net45+win8+wpa81+wp8;portable-net403+sl50+win8+wp8;</TargetFrameworks>-->
    Apr�s : <TargetFrameworks>netstandard2.0;netstandard1.3;netstandard1.0;net45;net40;</TargetFrameworks>

2) Le projet de tests ne faisait plus partie de la solution
=> je l'ai ajout�

3) Le projet de tests ne compilait pas
=> j'ai ajout� les packages nugets suivants :
* System.Xml.Linq
* System.Xml.ReaderWriter
* NUnit

4) Les tests ne se lancaient pas
=> impossible de trouver pourquoi
=> j'ai ajout� un projet console pour les lancer explicitement. C'est mieux que rien
